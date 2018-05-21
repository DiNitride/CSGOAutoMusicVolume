using AudioSwitcher.AudioApi.CoreAudio;
using AudioSwitcher.AudioApi.Session;
using Gameloop.Vdf;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
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
        String CSDIR = "\\steamapps\\common\\Counter-Strike Global Offensive\\";
        String CFGDIR = "\\steamapps\\common\\Counter-Strike Global Offensive\\csgo\\cfg\\gamestate_integration_musicControllApp.cfg";
        String SteamInstallDir;
        String RegLocation = "HKEY_CURRENT_USER\\Software\\DiNitride\\CSGOMusicController";
        CoreAudioController AudioController;

        public ControlWindow()
        {
            InitializeComponent();
            CheckSetup();
            postListener = new HttpListener();
            postListener.Prefixes.Add("http://127.0.0.1:5659/");
            loop = new Thread(new ThreadStart(PollForData));
            LoadFromFile();
        }

        private void CheckSetup()
        {
            String steamInstall = (String)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", "NA");
            Console.WriteLine(steamInstall);
            String steamGameLocations = File.ReadAllText(steamInstall + "\\steamapps\\libraryfolders.vdf");
            Console.WriteLine(steamGameLocations);
            // Volves weird VDF file format uses 1, 2, 3 as keys, which you then can't access through the created object so, I just replaced the first 8 with the word
            // So I can access through that
            // If you have more than 8 Steam Game Libraries, you'll have to do things manually.
            steamGameLocations = steamGameLocations.Replace("1", "One").Replace("2", "Two").Replace("3", "Three").Replace("4", "Four").Replace("5", "Five").Replace("6", "Six").Replace("7", "Seven").Replace("8", "Eight");
            Console.WriteLine(steamGameLocations);
            dynamic GameLocations = VdfConvert.Deserialize(steamGameLocations);
            try
            {
                if (CheckCSFolder(steamInstall)) {
                    SteamInstallDir = steamInstall;
                    Console.WriteLine("CSGO IN DEFAULT AT {0}", SteamInstallDir);
                    CheckCfg();
                }
                else if (CheckCSFolder(GameLocations.Value.One.ToString()))
                {
                    SteamInstallDir = GameLocations.Value.One.ToString();
                    Console.WriteLine("CSGO IN DIR 1 AT {0}", SteamInstallDir);
                    CheckCfg();
                }
                else if (CheckCSFolder(GameLocations.Value.Two.ToString()))
                {
                    SteamInstallDir = GameLocations.Value.Two.ToString();
                    Console.WriteLine("CSGO IN DIR 2 AT {0}", SteamInstallDir);

                    CheckCfg();
                }
                else if (CheckCSFolder(GameLocations.Value.Three.ToString()))
                {
                    SteamInstallDir = GameLocations.Value.Three.ToString();
                    Console.WriteLine("CSGO IN DIR 3 AT {0}", SteamInstallDir);

                    CheckCfg();
                }
                else if (CheckCSFolder(GameLocations.Value.Four.ToString()))
                {
                    SteamInstallDir = GameLocations.Value.Four.ToString();
                    Console.WriteLine("CSGO IN DIR 4 AT {0}", SteamInstallDir);

                    CheckCfg();
                }
                else if (CheckCSFolder(GameLocations.Value.Five.ToString()))
                {
                    SteamInstallDir = GameLocations.Value.Five.ToString();
                    Console.WriteLine("CSGO IN DIR 5 AT {0}", SteamInstallDir);

                    CheckCfg();
                }
                else if (CheckCSFolder(GameLocations.Value.Six.ToString()))
                {

                    SteamInstallDir = GameLocations.Value.Six.ToString();
                    Console.WriteLine("CSGO IN DIR 6 AT {0}", SteamInstallDir);

                    CheckCfg();
                }
                else if (CheckCSFolder(GameLocations.Value.Seven.ToString()))
                {
                    SteamInstallDir = GameLocations.Value.Seven.ToString();
                    Console.WriteLine("CSGO IN DIR 7 AT {0}", SteamInstallDir);

                    CheckCfg();
                }
                else if (CheckCSFolder(GameLocations.Value.Eight.ToString()))
                {
                    SteamInstallDir = GameLocations.Value.Eight.ToString();
                    Console.WriteLine("CSGO IN DIR 8 AT {0}", SteamInstallDir);

                    CheckCfg();
                }
                else
                {
                    CSNotFoundError();
                }
            } catch (KeyNotFoundException)
            {
                CSNotFoundError();
            }

        }

        private void CSNotFoundError()
        {
            Console.WriteLine("COULD NOT FIND CSGO!!!!!!!");
            MessageBox.Show("Please manually place 'gamestate_integration_musicControllApp.cfg' inside your CS:GO Game directory, in the location ../steamapps/common/<INSTALL_DIR>/csgo/cfg/", "A CS:GO Install could not be located",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
            
        private bool CheckCSFolder(String installDir)
        {
            return (Directory.Exists(installDir + CSDIR));
        }

        private void CheckCfg()
        {
            if (File.Exists(SteamInstallDir + CFGDIR))
            {
                Console.WriteLine("CFG EXISTS");
            } else
            {
                Console.WriteLine("CFG DOESN'T EXIST, WILL CREATE ONE");
                String cfg = File.ReadAllText("gamestate_integration_musicControllApp.cfg");
                File.WriteAllText(SteamInstallDir + CFGDIR, cfg);
            }
        }

        private void LoadFromFile()
        {   
            try
            {

                String readText = (String) Registry.GetValue(RegLocation, "preference", "100,50");

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
            Registry.SetValue(RegLocation, "preference", createText);
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
            AudioController = new CoreAudioController();
            sessions = new List<IAudioSession>();
            RefreshAudioSessions();
        }

        private void RefreshAudioSessions()
        {
            Console.WriteLine("Refreshing Session List");
            sessions.Clear();
            AudioDevicesList.Items.Clear();
            Console.WriteLine("Audio Sessions Discovered:");
            foreach (var audioSession in AudioController.DefaultPlaybackDevice.GetCapability<IAudioSessionController>())
            {
                String name = audioSession.DisplayName;
                if (name == null)
                {
                    continue;
                }
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
            Stream body = r.InputStream;
            System.Text.Encoding encoding = r.ContentEncoding;
            StreamReader reader = new StreamReader(body, encoding);
            DataJson d;
            string s = reader.ReadToEnd();
            Console.WriteLine("===== NEW JSON DATA =====\n{0}\n=========================", s);
            body.Close();
            reader.Close();
            d = JsonConvert.DeserializeObject<DataJson>(s);
            if (d.Player.ID == d.Provider.ID)
            {
                try
                {
                    return d.Player.State.Health;
                }
                catch (NullReferenceException)
                {
                    return 0;
                }
            } else {
                Console.WriteLine("INFO -> Player is spectating, ID's do not match");
                return 1000;
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
                    if (health != 1000)
                    {
                        if (health > 0)
                        {
                            OnAlive();
                        }
                        else
                        {
                            OnDeath();
                        }
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
                    MessageBox.Show("Please select one from the dropdown menu.", "No Media player selected!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                oldVolume = player.Volume;
                StartStopToggle.Text = "Stop";
                AudioDevicesList.Enabled = false;
                running = true;
                UpdateVolumeManually();
            }
        }

        private void UpdateVolumeManually()
        {
            if (health == 1000) { return; }
            if (health > 0)
            {
                OnAlive();
            }
            else
            {
                OnDeath();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshAudioSessions();
        }

        private void GHLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DiNitride");
        }

        private void SourceCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DiNitride/CSGOAutoMusicVolume");
        }

        private void aliveVolumeInp_ValueChanged(object sender, EventArgs e)
        {
            aliveVol = (double) aliveVolumeInp.Value;
            UpdateVolumeManually();
        }

        private void deadVolumeInp_ValueChanged(object sender, EventArgs e)
        {
            deadVol = (double) deadVolumeInp.Value;
            UpdateVolumeManually();
        }
    }

    public class DataJson
    {
        [JsonProperty("player")]
        public PlayerJson Player { get; set; }

        [JsonProperty("previously")]
        public PreviouslyJson Previosuly { get; set; }

        [JsonProperty("provider")]
        public ProviderJson Provider { get; set; }
    }

    public class PlayerJson
    {
        [JsonProperty("state")]
        public StateJson State { get; set; }

        [JsonProperty("steamid")]
        public String ID { get; set; }
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

    public class ProviderJson
    {
        [JsonProperty("steamid")]
        public String ID { get; set; }
    }

}
