using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostingGame
{
    public partial class addWorker : MetroFramework.Forms.MetroForm
    {
        public addWorker()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Vas a contratar a un desarrollador por $1320 mensuales, ¿Seguro?",
                                     "Confirmar el contrato.",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("¡Has contratado a un nuevo desarrollador!");
                gameConstructor.getManager().agregarDeveloper();
                return;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Vas a contratar a un tecnico por $960 mensuales, ¿Seguro?",
                                     "Confirmar el contrato.",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("¡Has contratado a un nuevo tenico!");
                gameConstructor.getManager().agregarTecnico();
                return;
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
