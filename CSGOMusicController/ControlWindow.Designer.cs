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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlWindow));
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
            this.RefreshButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.Credit = new System.Windows.Forms.Label();
            this.GHLink = new System.Windows.Forms.LinkLabel();
            this.SourceCode = new System.Windows.Forms.LinkLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aliveVolumeInp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadVolumeInp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // deadOrAlive
            // 
            this.deadOrAlive.AutoSize = true;
            this.deadOrAlive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadOrAlive.Location = new System.Drawing.Point(171, 192);
            this.deadOrAlive.Name = "deadOrAlive";
            this.deadOrAlive.Size = new System.Drawing.Size(42, 17);
            this.deadOrAlive.TabIndex = 3;
            this.deadOrAlive.Text = "Dead";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(120, 192);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(45, 17);
            this.stateLabel.TabIndex = 4;
            this.stateLabel.Text = "State:";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(8, 192);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(53, 17);
            this.healthLabel.TabIndex = 5;
            this.healthLabel.Text = "Health:";
            // 
            // healthIntLabel
            // 
            this.healthIntLabel.AutoSize = true;
            this.healthIntLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthIntLabel.Location = new System.Drawing.Point(67, 192);
            this.healthIntLabel.Name = "healthIntLabel";
            this.healthIntLabel.Size = new System.Drawing.Size(16, 17);
            this.healthIntLabel.TabIndex = 6;
            this.healthIntLabel.Text = "0";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(12, 215);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(237, 29);
            this.healthBar.TabIndex = 7;
            // 
            // AudioDevicesList
            // 
            this.AudioDevicesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AudioDevicesList.FormattingEnabled = true;
            this.AudioDevicesList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AudioDevicesList.Location = new System.Drawing.Point(103, 50);
            this.AudioDevicesList.Name = "AudioDevicesList";
            this.AudioDevicesList.Size = new System.Drawing.Size(146, 21);
            this.AudioDevicesList.TabIndex = 8;
            this.AudioDevicesList.SelectionChangeCommitted += new System.EventHandler(this.AudioDevicesList_SelectionChangeCommitted);
            // 
            // StartStopToggle
            // 
            this.StartStopToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStopToggle.Location = new System.Drawing.Point(12, 250);
            this.StartStopToggle.Name = "StartStopToggle";
            this.StartStopToggle.Size = new System.Drawing.Size(237, 44);
            this.StartStopToggle.TabIndex = 9;
            this.StartStopToggle.Text = "Start";
            this.StartStopToggle.UseVisualStyleBackColor = true;
            this.StartStopToggle.Click += new System.EventHandler(this.StartStopToggle_Click);
            // 
            // aliveVolumeInp
            // 
            this.aliveVolumeInp.Location = new System.Drawing.Point(107, 116);
            this.aliveVolumeInp.Name = "aliveVolumeInp";
            this.aliveVolumeInp.Size = new System.Drawing.Size(142, 20);
            this.aliveVolumeInp.TabIndex = 10;
            this.aliveVolumeInp.ValueChanged += new System.EventHandler(this.aliveVolumeInp_ValueChanged);
            // 
            // deadVolumeInp
            // 
            this.deadVolumeInp.Location = new System.Drawing.Point(107, 139);
            this.deadVolumeInp.Name = "deadVolumeInp";
            this.deadVolumeInp.Size = new System.Drawing.Size(142, 20);
            this.deadVolumeInp.TabIndex = 11;
            this.deadVolumeInp.ValueChanged += new System.EventHandler(this.deadVolumeInp_ValueChanged);
            // 
            // AudioDeviceLabel
            // 
            this.AudioDeviceLabel.AutoSize = true;
            this.AudioDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AudioDeviceLabel.Location = new System.Drawing.Point(9, 51);
            this.AudioDeviceLabel.Name = "AudioDeviceLabel";
            this.AudioDeviceLabel.Size = new System.Drawing.Size(88, 17);
            this.AudioDeviceLabel.TabIndex = 12;
            this.AudioDeviceLabel.Text = "Audio Player";
            // 
            // AliveVolumeLabel
            // 
            this.AliveVolumeLabel.AutoSize = true;
            this.AliveVolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AliveVolumeLabel.Location = new System.Drawing.Point(12, 116);
            this.AliveVolumeLabel.Name = "AliveVolumeLabel";
            this.AliveVolumeLabel.Size = new System.Drawing.Size(89, 17);
            this.AliveVolumeLabel.TabIndex = 13;
            this.AliveVolumeLabel.Text = "Alive Volume";
            // 
            // DeadVolumeLabel
            // 
            this.DeadVolumeLabel.AutoSize = true;
            this.DeadVolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeadVolumeLabel.Location = new System.Drawing.Point(12, 139);
            this.DeadVolumeLabel.Name = "DeadVolumeLabel";
            this.DeadVolumeLabel.Size = new System.Drawing.Size(93, 17);
            this.DeadVolumeLabel.TabIndex = 14;
            this.DeadVolumeLabel.Text = "Dead Volume";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(224, 25);
            this.Title.TabIndex = 15;
            this.Title.Text = "CS:GO Music Controller";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(12, 77);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(237, 33);
            this.RefreshButton.TabIndex = 16;
            this.RefreshButton.Text = "Refresh Audio Sessions";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(12, 297);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(237, 180);
            this.infoLabel.TabIndex = 17;
            this.infoLabel.Text = resources.GetString("infoLabel.Text");
            // 
            // Credit
            // 
            this.Credit.AutoSize = true;
            this.Credit.Location = new System.Drawing.Point(12, 477);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(41, 13);
            this.Credit.TabIndex = 18;
            this.Credit.Text = "Built by";
            // 
            // GHLink
            // 
            this.GHLink.AutoSize = true;
            this.GHLink.Location = new System.Drawing.Point(50, 477);
            this.GHLink.Name = "GHLink";
            this.GHLink.Size = new System.Drawing.Size(47, 13);
            this.GHLink.TabIndex = 19;
            this.GHLink.TabStop = true;
            this.GHLink.Text = "DiNitride";
            this.GHLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GHLink_LinkClicked);
            // 
            // SourceCode
            // 
            this.SourceCode.AutoSize = true;
            this.SourceCode.Location = new System.Drawing.Point(13, 494);
            this.SourceCode.Name = "SourceCode";
            this.SourceCode.Size = new System.Drawing.Size(135, 13);
            this.SourceCode.TabIndex = 20;
            this.SourceCode.TabStop = true;
            this.SourceCode.Text = "Source available on Github";
            this.SourceCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SourceCode_LinkClicked);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(168, 165);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Volume up delay msec";
            // 
            // ControlWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.SourceCode);
            this.Controls.Add(this.GHLink);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.RefreshButton);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(277, 551);
            this.MinimumSize = new System.Drawing.Size(277, 551);
            this.Name = "ControlWindow";
            this.Text = "CS:GO Music";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlWindow_FormClosing);
            this.Load += new System.EventHandler(this.ControlWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aliveVolumeInp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadVolumeInp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label Credit;
        private System.Windows.Forms.LinkLabel GHLink;
        private System.Windows.Forms.LinkLabel SourceCode;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}

