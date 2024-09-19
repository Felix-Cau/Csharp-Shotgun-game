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
            txtboxPlayerWins = new TextBox();
            txtBoxPlayerLosses = new TextBox();
            txtBoxNpcAmmoCount = new TextBox();
            txtBoxPlayerAmmoCount = new TextBox();
            lblInfoText = new Label();
            buttonLoad = new Button();
            buttonBlock = new Button();
            buttonShoot = new Button();
            buttonShotgun = new Button();
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
            // txtboxPlayerWins
            // 
            txtboxPlayerWins.BackColor = SystemColors.Desktop;
            txtboxPlayerWins.Font = new Font("Segoe UI", 12F);
            txtboxPlayerWins.Location = new Point(12, 80);
            txtboxPlayerWins.Name = "txtboxPlayerWins";
            txtboxPlayerWins.Size = new Size(81, 29);
            txtboxPlayerWins.TabIndex = 6;
            // 
            // txtBoxPlayerLosses
            // 
            txtBoxPlayerLosses.BackColor = SystemColors.Desktop;
            txtBoxPlayerLosses.Font = new Font("Segoe UI", 12F);
            txtBoxPlayerLosses.Location = new Point(122, 80);
            txtBoxPlayerLosses.Name = "txtBoxPlayerLosses";
            txtBoxPlayerLosses.Size = new Size(81, 29);
            txtBoxPlayerLosses.TabIndex = 7;
            // 
            // txtBoxNpcAmmoCount
            // 
            txtBoxNpcAmmoCount.BackColor = SystemColors.Desktop;
            txtBoxNpcAmmoCount.Font = new Font("Segoe UI", 12F);
            txtBoxNpcAmmoCount.Location = new Point(915, 80);
            txtBoxNpcAmmoCount.Name = "txtBoxNpcAmmoCount";
            txtBoxNpcAmmoCount.Size = new Size(81, 29);
            txtBoxNpcAmmoCount.TabIndex = 8;
            // 
            // txtBoxPlayerAmmoCount
            // 
            txtBoxPlayerAmmoCount.BackColor = SystemColors.Desktop;
            txtBoxPlayerAmmoCount.Font = new Font("Segoe UI", 12F);
            txtBoxPlayerAmmoCount.Location = new Point(12, 144);
            txtBoxPlayerAmmoCount.Name = "txtBoxPlayerAmmoCount";
            txtBoxPlayerAmmoCount.Size = new Size(81, 29);
            txtBoxPlayerAmmoCount.TabIndex = 9;
            // 
            // lblInfoText
            // 
            lblInfoText.AutoSize = true;
            lblInfoText.BackColor = SystemColors.Desktop;
            lblInfoText.BorderStyle = BorderStyle.Fixed3D;
            lblInfoText.Font = new Font("Segoe UI", 18F);
            lblInfoText.ForeColor = SystemColors.ControlText;
            lblInfoText.Location = new Point(336, 705);
            lblInfoText.Name = "lblInfoText";
            lblInfoText.Size = new Size(355, 34);
            lblInfoText.TabIndex = 10;
            lblInfoText.Text = "Choose your next action player!";
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
            // 
            // frmShotgun
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1008, 985);
            Controls.Add(buttonShotgun);
            Controls.Add(buttonShoot);
            Controls.Add(buttonBlock);
            Controls.Add(buttonLoad);
            Controls.Add(lblInfoText);
            Controls.Add(txtBoxPlayerAmmoCount);
            Controls.Add(txtBoxNpcAmmoCount);
            Controls.Add(txtBoxPlayerLosses);
            Controls.Add(txtboxPlayerWins);
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
        private TextBox txtboxPlayerWins;
        private TextBox txtBoxPlayerLosses;
        private TextBox txtBoxNpcAmmoCount;
        private TextBox txtBoxPlayerAmmoCount;
        private Label lblInfoText;
        private Button buttonLoad;
        private Button buttonBlock;
        private Button buttonShoot;
        private Button buttonShotgun;
    }
}
