namespace Examinationsuppgift2
{
    partial class frmShotgun
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShotgun));
            lblPlayerInformation = new Label();
            lblAmmoCount = new Label();
            lblPlayerWins = new Label();
            lblLosses = new Label();
            lblOpponentInformation = new Label();
            lblOpponentAmmoCount = new Label();
            lblInfoText = new Label();
            buttonLoad = new Button();
            buttonBlock = new Button();
            buttonShoot = new Button();
            buttonShotgun = new Button();
            lblDisplayUserWins = new Label();
            lblDisplayUserLosses = new Label();
            lblDisplayAmmoCount = new Label();
            lblDisplayNpcAmmoCount = new Label();
            SuspendLayout();
            // 
            // lblPlayerInformation
            // 
            lblPlayerInformation.AutoSize = true;
            lblPlayerInformation.BackColor = SystemColors.Desktop;
            lblPlayerInformation.BorderStyle = BorderStyle.Fixed3D;
            lblPlayerInformation.Font = new Font("Segoe UI", 18F);
            lblPlayerInformation.Location = new Point(12, 9);
            lblPlayerInformation.Name = "lblPlayerInformation";
            lblPlayerInformation.Size = new Size(212, 34);
            lblPlayerInformation.TabIndex = 0;
            lblPlayerInformation.Text = "Player information";
            // 
            // lblAmmoCount
            // 
            lblAmmoCount.AutoSize = true;
            lblAmmoCount.BackColor = SystemColors.Desktop;
            lblAmmoCount.BorderStyle = BorderStyle.Fixed3D;
            lblAmmoCount.Font = new Font("Segoe UI", 12F);
            lblAmmoCount.Location = new Point(12, 118);
            lblAmmoCount.Name = "lblAmmoCount";
            lblAmmoCount.Size = new Size(102, 23);
            lblAmmoCount.TabIndex = 1;
            lblAmmoCount.Text = "Ammo count";
            // 
            // lblPlayerWins
            // 
            lblPlayerWins.AutoSize = true;
            lblPlayerWins.BackColor = SystemColors.Desktop;
            lblPlayerWins.BorderStyle = BorderStyle.Fixed3D;
            lblPlayerWins.Font = new Font("Segoe UI", 12F);
            lblPlayerWins.Location = new Point(12, 54);
            lblPlayerWins.Name = "lblPlayerWins";
            lblPlayerWins.Size = new Size(47, 23);
            lblPlayerWins.TabIndex = 2;
            lblPlayerWins.Text = "Wins";
            // 
            // lblLosses
            // 
            lblLosses.AutoSize = true;
            lblLosses.BackColor = SystemColors.Desktop;
            lblLosses.BorderStyle = BorderStyle.Fixed3D;
            lblLosses.Font = new Font("Segoe UI", 12F);
            lblLosses.Location = new Point(122, 54);
            lblLosses.Name = "lblLosses";
            lblLosses.Size = new Size(58, 23);
            lblLosses.TabIndex = 3;
            lblLosses.Text = "Losses";
            // 
            // lblOpponentInformation
            // 
            lblOpponentInformation.AutoSize = true;
            lblOpponentInformation.BackColor = SystemColors.Desktop;
            lblOpponentInformation.BorderStyle = BorderStyle.Fixed3D;
            lblOpponentInformation.Font = new Font("Segoe UI", 18F);
            lblOpponentInformation.Location = new Point(739, 9);
            lblOpponentInformation.Name = "lblOpponentInformation";
            lblOpponentInformation.Size = new Size(257, 34);
            lblOpponentInformation.TabIndex = 4;
            lblOpponentInformation.Text = "Opponent information";
            // 
            // lblOpponentAmmoCount
            // 
            lblOpponentAmmoCount.AutoSize = true;
            lblOpponentAmmoCount.BackColor = SystemColors.Desktop;
            lblOpponentAmmoCount.BorderStyle = BorderStyle.Fixed3D;
            lblOpponentAmmoCount.Font = new Font("Segoe UI", 12F);
            lblOpponentAmmoCount.Location = new Point(894, 54);
            lblOpponentAmmoCount.Name = "lblOpponentAmmoCount";
            lblOpponentAmmoCount.Size = new Size(102, 23);
            lblOpponentAmmoCount.TabIndex = 5;
            lblOpponentAmmoCount.Text = "Ammo count";
            // 
            // lblInfoText
            // 
            lblInfoText.AutoSize = true;
            lblInfoText.BackColor = SystemColors.Desktop;
            lblInfoText.BorderStyle = BorderStyle.Fixed3D;
            lblInfoText.Font = new Font("Segoe UI", 18F);
            lblInfoText.ForeColor = SystemColors.ControlText;
            lblInfoText.Location = new Point(379, 713);
            lblInfoText.Name = "lblInfoText";
            lblInfoText.Size = new Size(283, 34);
            lblInfoText.TabIndex = 10;
            lblInfoText.Text = "Choose your next action!";
            // 
            // buttonLoad
            // 
            buttonLoad.BackgroundImage = (Image)resources.GetObject("buttonLoad.BackgroundImage");
            buttonLoad.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLoad.Location = new Point(102, 768);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(187, 172);
            buttonLoad.TabIndex = 11;
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonBlock
            // 
            buttonBlock.BackgroundImage = (Image)resources.GetObject("buttonBlock.BackgroundImage");
            buttonBlock.BackgroundImageLayout = ImageLayout.Stretch;
            buttonBlock.Location = new Point(311, 768);
            buttonBlock.Name = "buttonBlock";
            buttonBlock.Size = new Size(187, 172);
            buttonBlock.TabIndex = 12;
            buttonBlock.UseVisualStyleBackColor = true;
            buttonBlock.Click += buttonBlock_Click;
            // 
            // buttonShoot
            // 
            buttonShoot.BackgroundImage = (Image)resources.GetObject("buttonShoot.BackgroundImage");
            buttonShoot.BackgroundImageLayout = ImageLayout.Stretch;
            buttonShoot.Location = new Point(529, 768);
            buttonShoot.Name = "buttonShoot";
            buttonShoot.Size = new Size(187, 172);
            buttonShoot.TabIndex = 13;
            buttonShoot.UseVisualStyleBackColor = true;
            buttonShoot.Click += buttonShoot_Click;
            // 
            // buttonShotgun
            // 
            buttonShotgun.BackgroundImage = (Image)resources.GetObject("buttonShotgun.BackgroundImage");
            buttonShotgun.BackgroundImageLayout = ImageLayout.Stretch;
            buttonShotgun.Location = new Point(739, 768);
            buttonShotgun.Name = "buttonShotgun";
            buttonShotgun.Size = new Size(187, 172);
            buttonShotgun.TabIndex = 14;
            buttonShotgun.UseVisualStyleBackColor = true;
            buttonShotgun.Click += buttonShotgun_Click;
            // 
            // lblDisplayUserWins
            // 
            lblDisplayUserWins.AutoSize = true;
            lblDisplayUserWins.BorderStyle = BorderStyle.Fixed3D;
            lblDisplayUserWins.Font = new Font("Segoe UI", 12F);
            lblDisplayUserWins.Location = new Point(25, 86);
            lblDisplayUserWins.Name = "lblDisplayUserWins";
            lblDisplayUserWins.Size = new Size(54, 23);
            lblDisplayUserWins.TabIndex = 15;
            lblDisplayUserWins.Text = "label1";
            // 
            // lblDisplayUserLosses
            // 
            lblDisplayUserLosses.AutoSize = true;
            lblDisplayUserLosses.BorderStyle = BorderStyle.Fixed3D;
            lblDisplayUserLosses.Font = new Font("Segoe UI", 12F);
            lblDisplayUserLosses.Location = new Point(140, 86);
            lblDisplayUserLosses.Name = "lblDisplayUserLosses";
            lblDisplayUserLosses.Size = new Size(54, 23);
            lblDisplayUserLosses.TabIndex = 16;
            lblDisplayUserLosses.Text = "label1";
            // 
            // lblDisplayAmmoCount
            // 
            lblDisplayAmmoCount.AutoSize = true;
            lblDisplayAmmoCount.BorderStyle = BorderStyle.Fixed3D;
            lblDisplayAmmoCount.Font = new Font("Segoe UI", 12F);
            lblDisplayAmmoCount.Location = new Point(48, 150);
            lblDisplayAmmoCount.Name = "lblDisplayAmmoCount";
            lblDisplayAmmoCount.Size = new Size(54, 23);
            lblDisplayAmmoCount.TabIndex = 17;
            lblDisplayAmmoCount.Text = "label1";
            // 
            // lblDisplayNpcAmmoCount
            // 
            lblDisplayNpcAmmoCount.AutoSize = true;
            lblDisplayNpcAmmoCount.BorderStyle = BorderStyle.Fixed3D;
            lblDisplayNpcAmmoCount.Font = new Font("Segoe UI", 12F);
            lblDisplayNpcAmmoCount.Location = new Point(933, 86);
            lblDisplayNpcAmmoCount.Name = "lblDisplayNpcAmmoCount";
            lblDisplayNpcAmmoCount.Size = new Size(54, 23);
            lblDisplayNpcAmmoCount.TabIndex = 18;
            lblDisplayNpcAmmoCount.Text = "label1";
            // 
            // frmShotgun
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1008, 985);
            Controls.Add(lblDisplayNpcAmmoCount);
            Controls.Add(lblDisplayAmmoCount);
            Controls.Add(lblDisplayUserLosses);
            Controls.Add(lblDisplayUserWins);
            Controls.Add(buttonShotgun);
            Controls.Add(buttonShoot);
            Controls.Add(buttonBlock);
            Controls.Add(buttonLoad);
            Controls.Add(lblInfoText);
            Controls.Add(lblOpponentAmmoCount);
            Controls.Add(lblOpponentInformation);
            Controls.Add(lblLosses);
            Controls.Add(lblPlayerWins);
            Controls.Add(lblAmmoCount);
            Controls.Add(lblPlayerInformation);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmShotgun";
            Text = "Shotgun";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlayerInformation;
        private Label lblAmmoCount;
        private Label lblPlayerWins;
        private Label lblLosses;
        private Label lblOpponentInformation;
        private Label lblOpponentAmmoCount;
        private Label lblInfoText;
        private Button buttonLoad;
        private Button buttonBlock;
        private Button buttonShoot;
        private Button buttonShotgun;
        private Label lblDisplayUserWins;
        private Label lblDisplayUserLosses;
        private Label lblDisplayAmmoCount;
        private Label lblDisplayNpcAmmoCount;
    }
}
