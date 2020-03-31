namespace HostingGame
{
    partial class addWorker
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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroButton2
            // 
            this.metroButton2.AutoSize = true;
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(12, 68);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(177, 39);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Contratar Desarrollador";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(196, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(131, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Pago Mensual: $1320";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(196, 140);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(126, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Pago Mensual: $960";
            // 
            // metroButton1
            // 
            this.metroButton1.AutoSize = true;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(12, 130);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(177, 39);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Contratar Tecnico";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(23, 242);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(285, 35);
            this.metroTile1.TabIndex = 10;
            this.metroTile1.Text = "CERRAR";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // addWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 300);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton2);
            this.Name = "addWorker";
            this.Text = "Añadir Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}