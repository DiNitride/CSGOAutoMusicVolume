using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;
using AudioSwitcher.AudioApi.Session;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace CSGOMusicController
{
    public partial class ControlWindow : Form
    {

        HttpListener postListener;
        Thread loop;
        IAudioSession player;
        int health;
        List<IAudioSession> sessions;
        bool running = false;
        double oldVolume, deadVol, aliveVol;

        public ControlWindow()
        {
            InitializeComponent();
            postListener = new HttpListener();
            postListener.Prefixes.Add("http://127.0.0.1:5659/");
            loop = new Thread(new ThreadStart(PollForData));
            LoadFromFile();
            
        }

        private void LoadFromFile()
        {   
            try
            {
                string readText = File.ReadAllText("automusic.config");
                Console.WriteLine("Loaded Config: {0}", readText);
                var vols = readText.Split(new string[] { "," }, StringSplitOptions.None);
                Console.WriteLine("Dead Volume: {0} Alive Volume: {1}", vols[0], vols[1]);
                int dVolT, aVolT;
                if (Int32.TryParse(vols[0], out dVolT))
                {
                    Console.WriteLine("Success Converting Dead");
                    if ((dVolT > 100) || (dVolT < 0))
                    {
                        Console.WriteLine("Loaded Dead Value OOB");
                        dVolT = 50;
                    }
                    deadVol = dVolT;
                }
                if (Int32.TryParse(vols[1], out aVolT))
                {
                    Console.WriteLine("Success Converting Alive");
                    if ((aVolT > 100) || (aVolT < 0))
                    {
                        Console.WriteLine("Loaded Alive Value OOB");
                        aVolT = 50;
                    }
                    aliveVol = aVolT;
                }
                UpdateVolumeGui();
            } catch (FileNotFoundException)
            {
                Console.WriteLine("Config File Not Found!");
                defaultVolumes();
            }
        }

        private void defaultVolumes()
        {
            deadVol = 100;
            aliveVol = 50;
            UpdateVolumeGui();
        }

        private void UpdateVolumeGui()
        {
            deadVolumeInp.Value = (int) deadVol;
            aliveVolumeInp.Value = (int) aliveVol;
        }

        private void SaveFile()
        {

            string createText = deadVol + "," + aliveVol;
            File.WriteAllText("automusic.config", createText);
        }

        public CoreAudioController Controller
        {
            get;  
            private set;
        }

        private void ControlWindow_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Starting Listen Server");
            postListener.Start();
            loop.Start();
            CoreAudioController Controller = new CoreAudioController();
            sessions = new List<IAudioSession>();
            Console.WriteLine("Audio Sessions Discovered:");
            foreach (var audioSession in Controller.DefaultPlaybackDevice.GetCapability<IAudioSessionController>())
            {   
                String name = audioSession.DisplayName;
                if (!(name.Equals("")))
                {
                    AudioDevicesList.Items.Add(name);
                    sessions.Add(audioSession);
                    Console.WriteLine("--- {0}", name);
                }
            }
        }

        private void OnDeath()
        {
            Console.WriteLine("Player Dead!");
            SetStateText("Dead");
            SetHealth(health);
            if (running)
            {
                Console.WriteLine("Set audio volume to {0}", deadVol);
                player.SetVolumeAsync(deadVol);
            }
            
        }

        private void OnAlive()
        {
            Console.WriteLine("Player Alive!");
            SetStateText("Alive!");
            SetHealth(health);
            if (running)
            {
                Console.WriteLine("Set audio volume to {0}", aliveVol);
                player.SetVolumeAsync(aliveVol);
            }
            
        }

        private int GetHealth(HttpListenerRequest r)
        {
            System.IO.Stream body = r.InputStream;
            System.Text.Encoding encoding = r.ContentEncoding;
            System.IO.StreamReader reader = new System.IO.StreamReader(body, encoding);
            string s = reader.ReadToEnd();
            body.Close();
            reader.Close();
            DataJson d = JsonConvert.DeserializeObject<DataJson>(s);
            try
            {
                return d.Player.State.Health;
            } catch (NullReferenceException)
            {
                return 0;
            }
            
        }

        delegate void StringArgReturningVoidDelegate(string state);

        delegate void IntArgReturningVoidDelegate(int health);

        private void SetStateText(String state)
        {
            if (this.deadOrAlive.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetStateText);
                this.Invoke(d, new object[] { state });
            }
            else
            {
                this.deadOrAlive.Text = state;
            }
        }

        private void SetHealth(int health)
        {
            if (this.healthIntLabel.InvokeRequired)
            {
                IntArgReturningVoidDelegate d = new IntArgReturningVoidDelegate(SetHealth);
                this.Invoke(d, new object[] { health });
            }
            else
            {
                this.healthIntLabel.Text = health.ToString();
                this.healthBar.Value = health;
            }
        }

        private void PollForData()
        {
            HttpListenerContext context;
            HttpListenerRequest request;
            HttpListenerResponse response;
            try
            {
                while (true)
                {
                    context = postListener.GetContext();
                    request = context.Request;
                    if (request.HttpMethod != "POST") { continue; }
                    health = GetHealth(request);
                    Console.WriteLine("Player Health: {0}", health);
                    if (health > 0)
                    {
                        OnAlive();
                    } else
                    {
                        OnDeath();
                    }
                    response = context.Response;
                    response.Close();
                }
            }
            catch (ThreadAbortException)
            {
                Console.WriteLine("Ended Loop Thread");
            }
        }

        private void ControlWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFile();
            loop.Abort();
            postListener.Stop();
        }

        private void AudioDevicesList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Console.WriteLine("Selected Audio Session '{0}' at index {1}", sessions[AudioDevicesList.SelectedIndex].DisplayName, AudioDevicesList.SelectedIndex);
            player = sessions[AudioDevicesList.SelectedIndex];
        }

        private void StartStopToggle_Click(object sender, EventArgs e)
        {
            if (running == true)
            {
                // Program is changing volumes
                Console.WriteLine("Stopping Program");
                StartStopToggle.Text = "Start";
                player.SetVolumeAsync(oldVolume);
                AudioDevicesList.Enabled = true;
                running = false;

            } else
            {
                Console.WriteLine("Starting Program");
                // Program is idle
                if (player == null)
                {
                    return;
                }
                oldVolume = player.Volume;
                StartStopToggle.Text = "Stop";
                AudioDevicesList.Enabled = false;
                running = true;
            }
        }

        private void aliveVolumeInp_ValueChanged(object sender, EventArgs e)
        {
            aliveVol = (double) aliveVolumeInp.Value;
            if (health > 0)
            {
                OnAlive();
            }
        }

        private void deadVolumeInp_ValueChanged(object sender, EventArgs e)
        {
            deadVol = (double) deadVolumeInp.Value;
            if (health == 0)
            {
                OnDeath();
            }
        }
    }

    public class DataJson
    {
        [JsonProperty("player")]
        public PlayerJson Player { get; set; }

        [JsonProperty("previously")]
        public PreviouslyJson Previosuly { get; set; }
    }

    public class PlayerJson
    {
        [JsonProperty("state")]
        public StateJson State { get; set; }
    }

    public class PreviouslyJson
    {
        [JsonProperty("previously")]
        public PlayerJson Player { get; set; }
    }

    public class StateJson
    {
        [JsonProperty("health")]
        public int Health { get; set; }
    }

}
