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
    public partial class addServer : MetroFramework.Forms.MetroForm
    {
        public addServer()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Compraras un servidor pequeño por $160, ¿Seguro?",
                                     "Confirmar la compra.",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (gameConstructor.getManager().masServidores(1) == true)
                {
                    MessageBox.Show("¡Gracias por tu compra!");
                    gameConstructor.getManager().agregarServidor(1);
                    return;
                }
                else
                {
                    MessageBox.Show("Hacen falta mas trabajadores!");
                    return;
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Compraras un servidor mediano por $250, ¿Seguro?",
                         "Confirmar la compra.",
                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if(gameConstructor.getManager().masServidores(2) == true)
                {
                    MessageBox.Show("¡Gracias por tu compra!");
                    gameConstructor.getManager().agregarServidor(2);
                    return;
                }
                else
                {
                    MessageBox.Show("Hacen falta mas trabajadores!");
                    return;
                }
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Compraras un servidor grande por $400, ¿Seguro?",
             "Confirmar la compra.",
             MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (gameConstructor.getManager().masServidores(3) == true)
                {
                    MessageBox.Show("¡Gracias por tu compra!");
                    gameConstructor.getManager().agregarServidor(3);
                    return;
                }
                else
                {
                    MessageBox.Show("Hacen falta mas trabajadores!");
                    return;
                }
            }
        }
    }
}
