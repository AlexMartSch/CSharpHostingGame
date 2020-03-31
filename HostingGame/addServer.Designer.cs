namespace HostingGame
{
    partial class addServer
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(23, 253);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(274, 35);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "CERRAR";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.AutoSize = true;
            this.metroButton3.DialogResult = System.Windows.Forms.DialogResult.No;
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(23, 194);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(177, 39);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "Comprar Servidor Grande";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.AutoSize = true;
            this.metroButton1.DialogResult = System.Windows.Forms.DialogResult.No;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(23, 136);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(177, 39);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Comprar Servidor Mediano";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.AutoSize = true;
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(23, 73);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(177, 39);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Comprar Servidor Pequeño";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(206, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Precio: $160";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(206, 145);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Precio: $250";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(206, 203);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Precio: $400";
            // 
            // addServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 300);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroTile1);
            this.Movable = false;
            this.Name = "addServer";
            this.Resizable = false;
            this.Text = "Comprar nuevo servidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}