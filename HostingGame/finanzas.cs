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
    public partial class finanzas : MetroFramework.Forms.MetroForm
    {
        static finanzas finanza = new finanzas();
        public static finanzas getManager()
        {
            return finanza;
        }


        public finanzas()
        {
            InitializeComponent();
        }

        public void actualizarBTN(int id)
        {
            switch (id)
            {
                case 1:
                    faltantePrestamo1.Text = "$" + gameConstructor.getManager().dineroRestantePrestamo(1);
                    break;
                case 2:
                   // faltantePrestamo2.Text = "$" + gameConstructor.getManager().dineroRestantePrestamo(2);
                    break;
                case 3:
                    // faltantePrestamo3.Text = "$" + gameConstructor.getManager().dineroRestantePrestamo(3);
                    break;
                default:
                    break;
            }
        }

        private void prestamo1Btn_Click(object sender, EventArgs e)
        {
            if (gameConstructor.getManager().prestamoActivo(1))
            {
                if (gameConstructor.getManager().dineroActual > gameConstructor.getManager().dineroRestantePrestamo(1))
                {
                    var confirmResult = MessageBox.Show("Aceptaras pagar $"+ gameConstructor.getManager().dineroRestantePrestamo(1) + " por el prestamo, ¿Seguro?",
                                        "Confirmar el pago.",
                                        MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        gameConstructor.getManager().dineroActual -= gameConstructor.getManager().dineroRestantePrestamo(1);
                        MessageBox.Show("¡Has pagado el prestamo por un total de $" + gameConstructor.getManager().dineroRestantePrestamo(1));
                        gameConstructor.getManager().pagarPrestamoTotal(1);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("¡No tienes suficiente dinero para pagar el prestamo!");
                    return;
                }
            }
            else
            {
                var confirmResult = MessageBox.Show("Aceptaras un prestamo de $10.000, ¿Seguro?",
                                         "Confirmar el contrato.",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    MessageBox.Show("¡Has recibido un prestamo!");
                    prestamo1Btn.Text = "¡Pagar todo!";
                    actualizarBTN(1);
                    gameConstructor.getManager().tomarPrestamo(1);
                    return;
                }
            }
        }

        private void changeButtons_Tick(object sender, EventArgs e)
        {
            if(gameConstructor.getManager().prestamoActivo(1))
            {
                faltantePrestamo1.Text = "Restan: $" + gameConstructor.getManager().dineroRestantePrestamo(1);
            }
            else
            {
                faltantePrestamo1.Text = "¡Aprovechalo!";
            }
        }

        private void finanzas_Load(object sender, EventArgs e)
        {
            if (gameConstructor.getManager().prestamoActivo(1))
            {
                prestamo1Btn.Text = "¡Pagar todo!";
                faltantePrestamo1.Text = "Restan: $" + gameConstructor.getManager().dineroRestantePrestamo(1);
            }
        }
    }
}
