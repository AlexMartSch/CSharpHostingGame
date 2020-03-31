using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpUpdater;
using System.Reflection;

namespace HostingGame
{
    public partial class Menu : MetroFramework.Forms.MetroForm, iSharpUpdatable
    {
        public string ApplicationName => "Hosting Game";

        public string ApplicationID => "hgame";

        public Assembly ApplicationAssembly => Assembly.GetExecutingAssembly();

        public Uri UpdateXmlLocation => new Uri("");

        public Icon ApplicationIcon => this.Icon;

        public Form Context => this;

        public Menu()
        {
            InitializeComponent();
            playSound();

            versionLabel.Text = this.ApplicationAssembly.GetName().Version.ToString();
        }

        private void quitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            Game thegame = new Game();
            thegame.Show();
            this.Visible = false;
        }

        private void playSound()
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.musica_menu);
            audio.PlayLooping();
        }
    }
}
