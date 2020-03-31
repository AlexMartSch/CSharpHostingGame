namespace HostingGame
{
    partial class Menu
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
            this.playBtn = new MetroFramework.Controls.MetroButton();
            this.quitbtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.versionLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(23, 63);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(417, 108);
            this.playBtn.Style = MetroFramework.MetroColorStyle.Pink;
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Jugar";
            this.playBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // quitbtn
            // 
            this.quitbtn.Location = new System.Drawing.Point(23, 177);
            this.quitbtn.Name = "quitbtn";
            this.quitbtn.Size = new System.Drawing.Size(417, 108);
            this.quitbtn.Style = MetroFramework.MetroColorStyle.Pink;
            this.quitbtn.TabIndex = 1;
            this.quitbtn.Text = "Salir";
            this.quitbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.quitbtn.Click += new System.EventHandler(this.quitbtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(65, 323);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(313, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Desarrollado por AlexBanPer - Copyright 2017-2018";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.versionLabel.Location = new System.Drawing.Point(203, 359);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(38, 19);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "V1.0";
            this.versionLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 398);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.quitbtn);
            this.Controls.Add(this.playBtn);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Menu";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Game Menu";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton playBtn;
        private MetroFramework.Controls.MetroButton quitbtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel versionLabel;
    }
}