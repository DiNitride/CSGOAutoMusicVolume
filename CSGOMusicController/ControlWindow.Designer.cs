namespace CSGOMusicController
{
    partial class ControlWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deadOrAlive = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.healthIntLabel = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.AudioDevicesList = new System.Windows.Forms.ComboBox();
            this.StartStopToggle = new System.Windows.Forms.Button();
            this.aliveVolumeInp = new System.Windows.Forms.NumericUpDown();
            this.deadVolumeInp = new System.Windows.Forms.NumericUpDown();
            this.AudioDeviceLabel = new System.Windows.Forms.Label();
            this.AliveVolumeLabel = new System.Windows.Forms.Label();
            this.DeadVolumeLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aliveVolumeInp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadVolumeInp)).BeginInit();
            this.SuspendLayout();
            // 
            // deadOrAlive
            // 
            this.deadOrAlive.AutoSize = true;
            this.deadOrAlive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadOrAlive.Location = new System.Drawing.Point(432, 50);
            this.deadOrAlive.Name = "deadOrAlive";
            this.deadOrAlive.Size = new System.Drawing.Size(42, 17);
            this.deadOrAlive.TabIndex = 3;
            this.deadOrAlive.Text = "Dead";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(381, 50);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(45, 17);
            this.stateLabel.TabIndex = 4;
            this.stateLabel.Text = "State:";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(272, 50);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(53, 17);
            this.healthLabel.TabIndex = 5;
            this.healthLabel.Text = "Health:";
            // 
            // healthIntLabel
            // 
            this.healthIntLabel.AutoSize = true;
            this.healthIntLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthIntLabel.Location = new System.Drawing.Point(331, 50);
            this.healthIntLabel.Name = "healthIntLabel";
            this.healthIntLabel.Size = new System.Drawing.Size(16, 17);
            this.healthIntLabel.TabIndex = 6;
            this.healthIntLabel.Text = "0";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(275, 73);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(252, 20);
            this.healthBar.TabIndex = 7;
            // 
            // AudioDevicesList
            // 
            this.AudioDevicesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AudioDevicesList.FormattingEnabled = true;
            this.AudioDevicesList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AudioDevicesList.Location = new System.Drawing.Point(129, 49);
            this.AudioDevicesList.Name = "AudioDevicesList";
            this.AudioDevicesList.Size = new System.Drawing.Size(123, 21);
            this.AudioDevicesList.TabIndex = 8;
            this.AudioDevicesList.SelectionChangeCommitted += new System.EventHandler(this.AudioDevicesList_SelectionChangeCommitted);
            // 
            // StartStopToggle
            // 
            this.StartStopToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStopToggle.Location = new System.Drawing.Point(204, 136);
            this.StartStopToggle.Name = "StartStopToggle";
            this.StartStopToggle.Size = new System.Drawing.Size(108, 44);
            this.StartStopToggle.TabIndex = 9;
            this.StartStopToggle.Text = "Start";
            this.StartStopToggle.UseVisualStyleBackColor = true;
            this.StartStopToggle.Click += new System.EventHandler(this.StartStopToggle_Click);
            // 
            // aliveVolumeInp
            // 
            this.aliveVolumeInp.Location = new System.Drawing.Point(129, 73);
            this.aliveVolumeInp.Name = "aliveVolumeInp";
            this.aliveVolumeInp.Size = new System.Drawing.Size(123, 20);
            this.aliveVolumeInp.TabIndex = 10;
            this.aliveVolumeInp.ValueChanged += new System.EventHandler(this.aliveVolumeInp_ValueChanged);
            // 
            // deadVolumeInp
            // 
            this.deadVolumeInp.Location = new System.Drawing.Point(129, 96);
            this.deadVolumeInp.Name = "deadVolumeInp";
            this.deadVolumeInp.Size = new System.Drawing.Size(123, 20);
            this.deadVolumeInp.TabIndex = 11;
            this.deadVolumeInp.ValueChanged += new System.EventHandler(this.deadVolumeInp_ValueChanged);
            // 
            // AudioDeviceLabel
            // 
            this.AudioDeviceLabel.AutoSize = true;
            this.AudioDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AudioDeviceLabel.Location = new System.Drawing.Point(12, 50);
            this.AudioDeviceLabel.Name = "AudioDeviceLabel";
            this.AudioDeviceLabel.Size = new System.Drawing.Size(88, 17);
            this.AudioDeviceLabel.TabIndex = 12;
            this.AudioDeviceLabel.Text = "Audio Player";
            // 
            // AliveVolumeLabel
            // 
            this.AliveVolumeLabel.AutoSize = true;
            this.AliveVolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AliveVolumeLabel.Location = new System.Drawing.Point(12, 73);
            this.AliveVolumeLabel.Name = "AliveVolumeLabel";
            this.AliveVolumeLabel.Size = new System.Drawing.Size(89, 17);
            this.AliveVolumeLabel.TabIndex = 13;
            this.AliveVolumeLabel.Text = "Alive Volume";
            // 
            // DeadVolumeLabel
            // 
            this.DeadVolumeLabel.AutoSize = true;
            this.DeadVolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeadVolumeLabel.Location = new System.Drawing.Point(12, 96);
            this.DeadVolumeLabel.Name = "DeadVolumeLabel";
            this.DeadVolumeLabel.Size = new System.Drawing.Size(93, 17);
            this.DeadVolumeLabel.TabIndex = 14;
            this.DeadVolumeLabel.Text = "Dead Volume";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(150, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(224, 25);
            this.Title.TabIndex = 15;
            this.Title.Text = "CS:GO Music Controller";
            // 
            // ControlWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 206);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DeadVolumeLabel);
            this.Controls.Add(this.AliveVolumeLabel);
            this.Controls.Add(this.AudioDeviceLabel);
            this.Controls.Add(this.deadVolumeInp);
            this.Controls.Add(this.aliveVolumeInp);
            this.Controls.Add(this.StartStopToggle);
            this.Controls.Add(this.AudioDevicesList);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.healthIntLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.deadOrAlive);
            this.MaximumSize = new System.Drawing.Size(555, 245);
            this.MinimumSize = new System.Drawing.Size(555, 245);
            this.Name = "ControlWindow";
            this.Text = "CSGO Music Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlWindow_FormClosing);
            this.Load += new System.EventHandler(this.ControlWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aliveVolumeInp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadVolumeInp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label deadOrAlive;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label healthIntLabel;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.ComboBox AudioDevicesList;
        private System.Windows.Forms.Button StartStopToggle;
        private System.Windows.Forms.NumericUpDown aliveVolumeInp;
        private System.Windows.Forms.NumericUpDown deadVolumeInp;
        private System.Windows.Forms.Label AudioDeviceLabel;
        private System.Windows.Forms.Label AliveVolumeLabel;
        private System.Windows.Forms.Label DeadVolumeLabel;
        private System.Windows.Forms.Label Title;
    }
}

