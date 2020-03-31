namespace HostingGame
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.actualizarDatos = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dineroActualTxT = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile11 = new MetroFramework.Controls.MetroTile();
            this.clienteGrande = new MetroFramework.Controls.MetroLabel();
            this.metroTile10 = new MetroFramework.Controls.MetroTile();
            this.clienteMediano = new MetroFramework.Controls.MetroLabel();
            this.metroTile9 = new MetroFramework.Controls.MetroTile();
            this.clientePequeño = new MetroFramework.Controls.MetroLabel();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.bigServerCount = new MetroFramework.Controls.MetroLabel();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.mediumServerCount = new MetroFramework.Controls.MetroLabel();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.smallServerCount = new MetroFramework.Controls.MetroLabel();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.tecnicosCount = new MetroFramework.Controls.MetroLabel();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.developerCount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.totalClientesTxT = new MetroFramework.Controls.MetroLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.totalServidoresTxT = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.totalEmpleadosTxT = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.totalPerdido = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.gananciasTxT = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.gastosTxT = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.monthCounterTxT = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.monthBar = new MetroFramework.Controls.MetroProgressBar();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.directorTxT = new MetroFramework.Controls.MetroLabel();
            this.nombreEmpresaTxT = new MetroFramework.Controls.MetroLabel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.bigServer = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.bigBar = new MetroFramework.Controls.MetroProgressBar();
            this.mediumServer = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.mediumBar = new MetroFramework.Controls.MetroProgressBar();
            this.smallServer = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.smallBar = new MetroFramework.Controls.MetroProgressBar();
            this.TimerToClients = new System.Windows.Forms.Timer(this.components);
            this.timerInSecconds = new System.Windows.Forms.Timer(this.components);
            this.eliminarCliente = new System.Windows.Forms.Timer(this.components);
            this.pagarPrestamo1 = new System.Windows.Forms.Timer(this.components);
            this.pagarPrestamo2 = new System.Windows.Forms.Timer(this.components);
            this.Clientes = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1.SuspendLayout();
            this.metroTile11.SuspendLayout();
            this.metroTile10.SuspendLayout();
            this.metroTile9.SuspendLayout();
            this.metroTile8.SuspendLayout();
            this.metroTile7.SuspendLayout();
            this.metroTile6.SuspendLayout();
            this.metroTile5.SuspendLayout();
            this.metroTile4.SuspendLayout();
            this.metroTile3.SuspendLayout();
            this.metroTile2.SuspendLayout();
            this.metroTile1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.metroPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // actualizarDatos
            // 
            this.actualizarDatos.Interval = 500;
            this.actualizarDatos.Tick += new System.EventHandler(this.actualizarDatos_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(1, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Dinero Empresa:";
            // 
            // dineroActualTxT
            // 
            this.dineroActualTxT.AutoSize = true;
            this.dineroActualTxT.Location = new System.Drawing.Point(125, 3);
            this.dineroActualTxT.Name = "dineroActualTxT";
            this.dineroActualTxT.Size = new System.Drawing.Size(28, 19);
            this.dineroActualTxT.TabIndex = 3;
            this.dineroActualTxT.Text = "100";
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoSize = true;
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroTile11);
            this.metroPanel1.Controls.Add(this.metroTile10);
            this.metroPanel1.Controls.Add(this.metroTile9);
            this.metroPanel1.Controls.Add(this.metroTile8);
            this.metroPanel1.Controls.Add(this.metroTile7);
            this.metroPanel1.Controls.Add(this.metroTile6);
            this.metroPanel1.Controls.Add(this.metroTile5);
            this.metroPanel1.Controls.Add(this.metroTile4);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroTile3);
            this.metroPanel1.Controls.Add(this.metroTile2);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 30);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.metroPanel1.Size = new System.Drawing.Size(159, 426);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTile11
            // 
            this.metroTile11.AutoSize = true;
            this.metroTile11.Controls.Add(this.clienteGrande);
            this.metroTile11.Location = new System.Drawing.Point(17, 379);
            this.metroTile11.Name = "metroTile11";
            this.metroTile11.Size = new System.Drawing.Size(138, 23);
            this.metroTile11.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile11.TabIndex = 14;
            this.metroTile11.Text = "Grandes:";
            this.metroTile11.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile11.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // clienteGrande
            // 
            this.clienteGrande.AutoSize = true;
            this.clienteGrande.Location = new System.Drawing.Point(90, 2);
            this.clienteGrande.Name = "clienteGrande";
            this.clienteGrande.Size = new System.Drawing.Size(16, 19);
            this.clienteGrande.TabIndex = 0;
            this.clienteGrande.Text = "0";
            // 
            // metroTile10
            // 
            this.metroTile10.AutoSize = true;
            this.metroTile10.Controls.Add(this.clienteMediano);
            this.metroTile10.Location = new System.Drawing.Point(17, 355);
            this.metroTile10.Name = "metroTile10";
            this.metroTile10.Size = new System.Drawing.Size(138, 23);
            this.metroTile10.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile10.TabIndex = 13;
            this.metroTile10.Text = "Mediano:";
            this.metroTile10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile10.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // clienteMediano
            // 
            this.clienteMediano.AutoSize = true;
            this.clienteMediano.Location = new System.Drawing.Point(90, 2);
            this.clienteMediano.Name = "clienteMediano";
            this.clienteMediano.Size = new System.Drawing.Size(16, 19);
            this.clienteMediano.TabIndex = 0;
            this.clienteMediano.Text = "0";
            // 
            // metroTile9
            // 
            this.metroTile9.AutoSize = true;
            this.metroTile9.Controls.Add(this.clientePequeño);
            this.metroTile9.Location = new System.Drawing.Point(17, 331);
            this.metroTile9.Name = "metroTile9";
            this.metroTile9.Size = new System.Drawing.Size(138, 23);
            this.metroTile9.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile9.TabIndex = 12;
            this.metroTile9.Text = "Pequeño:";
            this.metroTile9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile9.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // clientePequeño
            // 
            this.clientePequeño.AutoSize = true;
            this.clientePequeño.Location = new System.Drawing.Point(90, 2);
            this.clientePequeño.Name = "clientePequeño";
            this.clientePequeño.Size = new System.Drawing.Size(16, 19);
            this.clientePequeño.TabIndex = 0;
            this.clientePequeño.Text = "0";
            // 
            // metroTile8
            // 
            this.metroTile8.AutoSize = true;
            this.metroTile8.Controls.Add(this.bigServerCount);
            this.metroTile8.Location = new System.Drawing.Point(17, 253);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(138, 23);
            this.metroTile8.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile8.TabIndex = 11;
            this.metroTile8.Text = "Grandes:";
            this.metroTile8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile8.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // bigServerCount
            // 
            this.bigServerCount.AutoSize = true;
            this.bigServerCount.Location = new System.Drawing.Point(90, 2);
            this.bigServerCount.Name = "bigServerCount";
            this.bigServerCount.Size = new System.Drawing.Size(16, 19);
            this.bigServerCount.TabIndex = 0;
            this.bigServerCount.Text = "0";
            // 
            // metroTile7
            // 
            this.metroTile7.AutoSize = true;
            this.metroTile7.Controls.Add(this.mediumServerCount);
            this.metroTile7.Location = new System.Drawing.Point(17, 229);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(138, 23);
            this.metroTile7.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile7.TabIndex = 10;
            this.metroTile7.Text = "Medianos:";
            this.metroTile7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile7.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // mediumServerCount
            // 
            this.mediumServerCount.AutoSize = true;
            this.mediumServerCount.Location = new System.Drawing.Point(90, 2);
            this.mediumServerCount.Name = "mediumServerCount";
            this.mediumServerCount.Size = new System.Drawing.Size(16, 19);
            this.mediumServerCount.TabIndex = 0;
            this.mediumServerCount.Text = "0";
            // 
            // metroTile6
            // 
            this.metroTile6.AutoSize = true;
            this.metroTile6.Controls.Add(this.smallServerCount);
            this.metroTile6.Location = new System.Drawing.Point(17, 205);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(138, 23);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile6.TabIndex = 9;
            this.metroTile6.Text = "Pequeños";
            this.metroTile6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // smallServerCount
            // 
            this.smallServerCount.AutoSize = true;
            this.smallServerCount.Location = new System.Drawing.Point(90, 2);
            this.smallServerCount.Name = "smallServerCount";
            this.smallServerCount.Size = new System.Drawing.Size(16, 19);
            this.smallServerCount.TabIndex = 0;
            this.smallServerCount.Text = "0";
            // 
            // metroTile5
            // 
            this.metroTile5.AutoSize = true;
            this.metroTile5.Controls.Add(this.tecnicosCount);
            this.metroTile5.Location = new System.Drawing.Point(17, 95);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(138, 23);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile5.TabIndex = 8;
            this.metroTile5.Text = "Tecnicos:";
            this.metroTile5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // tecnicosCount
            // 
            this.tecnicosCount.AutoSize = true;
            this.tecnicosCount.Location = new System.Drawing.Point(90, 2);
            this.tecnicosCount.Name = "tecnicosCount";
            this.tecnicosCount.Size = new System.Drawing.Size(16, 19);
            this.tecnicosCount.TabIndex = 0;
            this.tecnicosCount.Text = "0";
            // 
            // metroTile4
            // 
            this.metroTile4.AutoSize = true;
            this.metroTile4.Controls.Add(this.developerCount);
            this.metroTile4.Location = new System.Drawing.Point(17, 71);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(138, 23);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile4.TabIndex = 7;
            this.metroTile4.Text = "Developers:";
            this.metroTile4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // developerCount
            // 
            this.developerCount.AutoSize = true;
            this.developerCount.Location = new System.Drawing.Point(90, 2);
            this.developerCount.Name = "developerCount";
            this.developerCount.Size = new System.Drawing.Size(16, 19);
            this.developerCount.TabIndex = 0;
            this.developerCount.Text = "0";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.SeaShell;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(17, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(120, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Gestion Empresa";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroTile3
            // 
            this.metroTile3.AutoSize = true;
            this.metroTile3.Controls.Add(this.totalClientesTxT);
            this.metroTile3.Location = new System.Drawing.Point(1, 306);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(154, 23);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile3.TabIndex = 5;
            this.metroTile3.Text = "Clientes:";
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // totalClientesTxT
            // 
            this.totalClientesTxT.AutoSize = true;
            this.totalClientesTxT.Location = new System.Drawing.Point(90, 2);
            this.totalClientesTxT.Name = "totalClientesTxT";
            this.totalClientesTxT.Size = new System.Drawing.Size(16, 19);
            this.totalClientesTxT.TabIndex = 0;
            this.totalClientesTxT.Text = "0";
            // 
            // metroTile2
            // 
            this.metroTile2.AutoSize = true;
            this.metroTile2.Controls.Add(this.totalServidoresTxT);
            this.metroTile2.Location = new System.Drawing.Point(1, 181);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(154, 23);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Servidores:";
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // totalServidoresTxT
            // 
            this.totalServidoresTxT.AutoSize = true;
            this.totalServidoresTxT.Location = new System.Drawing.Point(90, 2);
            this.totalServidoresTxT.Name = "totalServidoresTxT";
            this.totalServidoresTxT.Size = new System.Drawing.Size(16, 19);
            this.totalServidoresTxT.TabIndex = 0;
            this.totalServidoresTxT.Text = "0";
            // 
            // metroTile1
            // 
            this.metroTile1.AutoSize = true;
            this.metroTile1.Controls.Add(this.totalEmpleadosTxT);
            this.metroTile1.Location = new System.Drawing.Point(1, 47);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(154, 23);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Empleados:";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // totalEmpleadosTxT
            // 
            this.totalEmpleadosTxT.AutoSize = true;
            this.totalEmpleadosTxT.Location = new System.Drawing.Point(90, 2);
            this.totalEmpleadosTxT.Name = "totalEmpleadosTxT";
            this.totalEmpleadosTxT.Size = new System.Drawing.Size(16, 19);
            this.totalEmpleadosTxT.TabIndex = 0;
            this.totalEmpleadosTxT.Text = "0";
            // 
            // metroButton1
            // 
            this.metroButton1.AutoSize = true;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(6, 31);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(141, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Contratar Empleados";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.AutoSize = true;
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(6, 3);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(141, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Comprar Servidores";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.AutoSize = true;
            this.metroPanel2.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.totalPerdido);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.gananciasTxT);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.gastosTxT);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroButton4);
            this.metroPanel2.Controls.Add(this.metroButton3);
            this.metroPanel2.Controls.Add(this.metroButton1);
            this.metroPanel2.Controls.Add(this.metroButton2);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(179, 399);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(531, 57);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // totalPerdido
            // 
            this.totalPerdido.AutoSize = true;
            this.totalPerdido.FontSize = MetroFramework.MetroLabelSize.Small;
            this.totalPerdido.Location = new System.Drawing.Point(367, 39);
            this.totalPerdido.Name = "totalPerdido";
            this.totalPerdido.Size = new System.Drawing.Size(28, 15);
            this.totalPerdido.TabIndex = 13;
            this.totalPerdido.Text = "-100";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(299, 39);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(35, 15);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Total:";
            // 
            // gananciasTxT
            // 
            this.gananciasTxT.AutoSize = true;
            this.gananciasTxT.FontSize = MetroFramework.MetroLabelSize.Small;
            this.gananciasTxT.Location = new System.Drawing.Point(367, 22);
            this.gananciasTxT.Name = "gananciasTxT";
            this.gananciasTxT.Size = new System.Drawing.Size(28, 15);
            this.gananciasTxT.TabIndex = 12;
            this.gananciasTxT.Text = "-100";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(299, 22);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 15);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Ganancias:";
            // 
            // gastosTxT
            // 
            this.gastosTxT.AutoSize = true;
            this.gastosTxT.FontSize = MetroFramework.MetroLabelSize.Small;
            this.gastosTxT.Location = new System.Drawing.Point(368, 2);
            this.gastosTxT.Name = "gastosTxT";
            this.gastosTxT.Size = new System.Drawing.Size(28, 15);
            this.gastosTxT.TabIndex = 10;
            this.gastosTxT.Text = "-100";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(299, 3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 15);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Gastos:";
            // 
            // metroButton4
            // 
            this.metroButton4.AutoSize = true;
            this.metroButton4.Enabled = false;
            this.metroButton4.Highlight = true;
            this.metroButton4.Location = new System.Drawing.Point(154, 31);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(137, 23);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton4.TabIndex = 8;
            this.metroButton4.Text = "Opciones";
            // 
            // metroButton3
            // 
            this.metroButton3.AutoSize = true;
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(154, 3);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(137, 23);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton3.TabIndex = 7;
            this.metroButton3.Text = "Finanzas";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.metroLabel10);
            this.metroPanel3.Controls.Add(this.monthCounterTxT);
            this.metroPanel3.Controls.Add(this.metroLabel8);
            this.metroPanel3.Controls.Add(this.monthBar);
            this.metroPanel3.Controls.Add(this.metroPanel4);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(179, 30);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(531, 57);
            this.metroPanel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel3.TabIndex = 8;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(494, 20);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(30, 19);
            this.metroLabel10.TabIndex = 10;
            this.metroLabel10.Text = "v1.0";
            // 
            // monthCounterTxT
            // 
            this.monthCounterTxT.AutoSize = true;
            this.monthCounterTxT.FontSize = MetroFramework.MetroLabelSize.Small;
            this.monthCounterTxT.Location = new System.Drawing.Point(386, 6);
            this.monthCounterTxT.Name = "monthCounterTxT";
            this.monthCounterTxT.Size = new System.Drawing.Size(19, 15);
            this.monthCounterTxT.TabIndex = 9;
            this.monthCounterTxT.Text = "(0)";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.SeaShell;
            this.metroLabel8.CustomBackground = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(305, 3);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(84, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Fin del mes";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel8.UseStyleColors = true;
            // 
            // monthBar
            // 
            this.monthBar.Location = new System.Drawing.Point(216, 25);
            this.monthBar.Maximum = 10;
            this.monthBar.Name = "monthBar";
            this.monthBar.Size = new System.Drawing.Size(265, 23);
            this.monthBar.Style = MetroFramework.MetroColorStyle.Orange;
            this.monthBar.TabIndex = 3;
            this.monthBar.Value = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel4.Controls.Add(this.directorTxT);
            this.metroPanel4.Controls.Add(this.nombreEmpresaTxT);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 0);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(205, 57);
            this.metroPanel4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel4.TabIndex = 2;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // directorTxT
            // 
            this.directorTxT.AutoSize = true;
            this.directorTxT.BackColor = System.Drawing.Color.SeaShell;
            this.directorTxT.CustomBackground = true;
            this.directorTxT.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.directorTxT.Location = new System.Drawing.Point(33, 29);
            this.directorTxT.Name = "directorTxT";
            this.directorTxT.Size = new System.Drawing.Size(87, 19);
            this.directorTxT.Style = MetroFramework.MetroColorStyle.Blue;
            this.directorTxT.TabIndex = 8;
            this.directorTxT.Text = "Mi Empresa";
            this.directorTxT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.directorTxT.UseStyleColors = true;
            // 
            // nombreEmpresaTxT
            // 
            this.nombreEmpresaTxT.AutoSize = true;
            this.nombreEmpresaTxT.BackColor = System.Drawing.Color.SeaShell;
            this.nombreEmpresaTxT.CustomBackground = true;
            this.nombreEmpresaTxT.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nombreEmpresaTxT.Location = new System.Drawing.Point(60, 4);
            this.nombreEmpresaTxT.Name = "nombreEmpresaTxT";
            this.nombreEmpresaTxT.Size = new System.Drawing.Size(87, 19);
            this.nombreEmpresaTxT.Style = MetroFramework.MetroColorStyle.Blue;
            this.nombreEmpresaTxT.TabIndex = 7;
            this.nombreEmpresaTxT.Text = "Mi Empresa";
            this.nombreEmpresaTxT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.nombreEmpresaTxT.UseStyleColors = true;
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.metroPanel6);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(182, 93);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(527, 300);
            this.metroPanel5.TabIndex = 9;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // metroPanel6
            // 
            this.metroPanel6.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel6.Controls.Add(this.metroPanel7);
            this.metroPanel6.Controls.Add(this.bigServer);
            this.metroPanel6.Controls.Add(this.metroLabel11);
            this.metroPanel6.Controls.Add(this.bigBar);
            this.metroPanel6.Controls.Add(this.mediumServer);
            this.metroPanel6.Controls.Add(this.metroLabel9);
            this.metroPanel6.Controls.Add(this.mediumBar);
            this.metroPanel6.Controls.Add(this.smallServer);
            this.metroPanel6.Controls.Add(this.metroLabel6);
            this.metroPanel6.Controls.Add(this.metroLabel5);
            this.metroPanel6.Controls.Add(this.smallBar);
            this.metroPanel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(0, 0);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(229, 300);
            this.metroPanel6.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel6.TabIndex = 2;
            this.metroPanel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // metroPanel7
            // 
            this.metroPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroPanel7.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel7.Controls.Add(this.metroLabel1);
            this.metroPanel7.Controls.Add(this.dineroActualTxT);
            this.metroPanel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel7.ForeColor = System.Drawing.Color.Red;
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(0, 274);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(229, 26);
            this.metroPanel7.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel7.TabIndex = 16;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            // 
            // bigServer
            // 
            this.bigServer.AutoSize = true;
            this.bigServer.Location = new System.Drawing.Point(161, 190);
            this.bigServer.Name = "bigServer";
            this.bigServer.Size = new System.Drawing.Size(33, 19);
            this.bigServer.TabIndex = 15;
            this.bigServer.Text = "0/10";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(3, 190);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(106, 19);
            this.metroLabel11.TabIndex = 14;
            this.metroLabel11.Text = "Servidor Grande";
            // 
            // bigBar
            // 
            this.bigBar.Location = new System.Drawing.Point(3, 212);
            this.bigBar.Name = "bigBar";
            this.bigBar.Size = new System.Drawing.Size(223, 23);
            this.bigBar.Style = MetroFramework.MetroColorStyle.Pink;
            this.bigBar.TabIndex = 13;
            // 
            // mediumServer
            // 
            this.mediumServer.AutoSize = true;
            this.mediumServer.Location = new System.Drawing.Point(161, 116);
            this.mediumServer.Name = "mediumServer";
            this.mediumServer.Size = new System.Drawing.Size(33, 19);
            this.mediumServer.TabIndex = 12;
            this.mediumServer.Text = "0/10";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(3, 116);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(115, 19);
            this.metroLabel9.TabIndex = 11;
            this.metroLabel9.Text = "Servidor Mediano";
            // 
            // mediumBar
            // 
            this.mediumBar.Location = new System.Drawing.Point(3, 138);
            this.mediumBar.Name = "mediumBar";
            this.mediumBar.Size = new System.Drawing.Size(223, 23);
            this.mediumBar.Style = MetroFramework.MetroColorStyle.Magenta;
            this.mediumBar.TabIndex = 10;
            // 
            // smallServer
            // 
            this.smallServer.AutoSize = true;
            this.smallServer.Location = new System.Drawing.Point(161, 51);
            this.smallServer.Name = "smallServer";
            this.smallServer.Size = new System.Drawing.Size(33, 19);
            this.smallServer.TabIndex = 9;
            this.smallServer.Text = "0/10";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 51);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(114, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Servidor Pequeño";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.SeaShell;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(71, 12);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(82, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Servidores";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseStyleColors = true;
            // 
            // smallBar
            // 
            this.smallBar.Location = new System.Drawing.Point(3, 73);
            this.smallBar.Name = "smallBar";
            this.smallBar.Size = new System.Drawing.Size(223, 23);
            this.smallBar.Style = MetroFramework.MetroColorStyle.Purple;
            this.smallBar.TabIndex = 2;
            // 
            // TimerToClients
            // 
            this.TimerToClients.Enabled = true;
            this.TimerToClients.Interval = 2000;
            this.TimerToClients.Tick += new System.EventHandler(this.TimerToClients_Tick);
            // 
            // timerInSecconds
            // 
            this.timerInSecconds.Enabled = true;
            this.timerInSecconds.Interval = 1000;
            this.timerInSecconds.Tick += new System.EventHandler(this.timerInSecconds_Tick);
            // 
            // eliminarCliente
            // 
            this.eliminarCliente.Enabled = true;
            this.eliminarCliente.Interval = 2500;
            this.eliminarCliente.Tick += new System.EventHandler(this.eliminarCliente_Tick);
            // 
            // pagarPrestamo1
            // 
            this.pagarPrestamo1.Interval = 40000;
            this.pagarPrestamo1.Tick += new System.EventHandler(this.pagarPrestamo1_Tick);
            // 
            // pagarPrestamo2
            // 
            this.pagarPrestamo2.Interval = 60000;
            this.pagarPrestamo2.Tick += new System.EventHandler(this.pagarPrestamo2_Tick);
            // 
            // Clientes
            // 
            this.Clientes.Enabled = true;
            this.Clientes.Interval = 1000;
            this.Clientes.Tick += new System.EventHandler(this.Clientes_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::HostingGame.Properties.Resources.background_game;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(730, 476);
            this.Controls.Add(this.metroPanel5);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroTile11.ResumeLayout(false);
            this.metroTile11.PerformLayout();
            this.metroTile10.ResumeLayout(false);
            this.metroTile10.PerformLayout();
            this.metroTile9.ResumeLayout(false);
            this.metroTile9.PerformLayout();
            this.metroTile8.ResumeLayout(false);
            this.metroTile8.PerformLayout();
            this.metroTile7.ResumeLayout(false);
            this.metroTile7.PerformLayout();
            this.metroTile6.ResumeLayout(false);
            this.metroTile6.PerformLayout();
            this.metroTile5.ResumeLayout(false);
            this.metroTile5.PerformLayout();
            this.metroTile4.ResumeLayout(false);
            this.metroTile4.PerformLayout();
            this.metroTile3.ResumeLayout(false);
            this.metroTile3.PerformLayout();
            this.metroTile2.ResumeLayout(false);
            this.metroTile2.PerformLayout();
            this.metroTile1.ResumeLayout(false);
            this.metroTile1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.metroPanel7.ResumeLayout(false);
            this.metroPanel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer actualizarDatos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel dineroActualTxT;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel totalEmpleadosTxT;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroLabel totalServidoresTxT;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroLabel totalClientesTxT;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel nombreEmpresaTxT;
        private MetroFramework.Controls.MetroLabel gastosTxT;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTile metroTile10;
        private MetroFramework.Controls.MetroLabel clienteMediano;
        private MetroFramework.Controls.MetroTile metroTile9;
        private MetroFramework.Controls.MetroLabel clientePequeño;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroLabel bigServerCount;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroLabel mediumServerCount;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroLabel smallServerCount;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroLabel tecnicosCount;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroLabel developerCount;
        private MetroFramework.Controls.MetroTile metroTile11;
        private MetroFramework.Controls.MetroLabel clienteGrande;
        private MetroFramework.Controls.MetroLabel gananciasTxT;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel directorTxT;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private MetroFramework.Controls.MetroLabel bigServer;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroProgressBar bigBar;
        private MetroFramework.Controls.MetroLabel mediumServer;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroProgressBar mediumBar;
        private MetroFramework.Controls.MetroLabel smallServer;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroProgressBar smallBar;
        private System.Windows.Forms.Timer TimerToClients;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel totalPerdido;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroProgressBar monthBar;
        private System.Windows.Forms.Timer timerInSecconds;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private MetroFramework.Controls.MetroLabel monthCounterTxT;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.Timer eliminarCliente;
        private System.Windows.Forms.Timer pagarPrestamo1;
        private System.Windows.Forms.Timer pagarPrestamo2;
        private System.Windows.Forms.Timer Clientes;
    }
}

