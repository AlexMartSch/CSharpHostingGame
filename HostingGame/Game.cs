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
    public partial class Game : MetroFramework.Forms.MetroForm
    {
        public int monthCount = 10;
        public int monthCounter = 0;

        public Game()
        {
            InitializeComponent();
            // ESTABLECER NOMBRE DE EMPRESA Y DIRECTOR
            nombreEmpresaTxT.Text = gameConstructor.getManager().nombreEmpresa;
            directorTxT.Text = "Gerente: " + gameConstructor.getManager().nombreDirector;

            actualizarDatos.Start();
        }

        private void actualizarDatos_Tick(object sender, EventArgs e)
        {
            try
            {
                monthCounterTxT.Text = "(" + monthCounter + ")";

                dineroActualTxT.Text = "$" + gameConstructor.getManager().dineroActual;

                //Empleados
                totalEmpleadosTxT.Text = gameConstructor.getManager().TotalEmpleados().ToString();
                developerCount.Text = gameConstructor.getManager().desarrolladores.ToString();
                tecnicosCount.Text = gameConstructor.getManager().tecnicos.ToString();


                //Servidores
                totalServidoresTxT.Text = gameConstructor.getManager().TotalServidores().ToString();
                smallServerCount.Text = gameConstructor.getManager().smallServer.ToString();
                mediumServerCount.Text = gameConstructor.getManager().mediumServer.ToString();
                bigServerCount.Text = gameConstructor.getManager().bigServer.ToString();

                smallServer.Text = gameConstructor.getManager().clientesSmallServer + "/" + gameConstructor.getManager().capacidadTotal(1);
                smallBar.Maximum = gameConstructor.getManager().capacidadTotal(1);
                smallBar.Value = gameConstructor.getManager().clientesSmallServer;

                mediumServer.Text = gameConstructor.getManager().clientesMediumServer + "/" + gameConstructor.getManager().capacidadTotal(2);
                mediumBar.Maximum = gameConstructor.getManager().capacidadTotal(2);
                mediumBar.Value = gameConstructor.getManager().clientesMediumServer;

                bigServer.Text = gameConstructor.getManager().clientesBigServer + "/" + gameConstructor.getManager().capacidadTotal(3);
                bigBar.Maximum = gameConstructor.getManager().capacidadTotal(3);
                bigBar.Value = gameConstructor.getManager().clientesBigServer;

                //Clientes
                totalClientesTxT.Text = gameConstructor.getManager().TotalClientes().ToString();
                clientePequeño.Text = gameConstructor.getManager().clientesSmallServer.ToString();
                clienteMediano.Text = gameConstructor.getManager().clientesMediumServer.ToString();
                clienteGrande.Text = gameConstructor.getManager().clientesBigServer.ToString();

                //Gastos & Ganancias
                if (gameConstructor.getManager().prestamoActivo())
                {
                    gastosTxT.Text = "$ -" + gameConstructor.getManager().gastosTotales() + " per month. - ($"
                        + gameConstructor.getManager().dineroRestantePrestamos() + " P)";
                }
                else
                {
                    gastosTxT.Text = "$ -" + gameConstructor.getManager().gastosTotales() + " per month. ";
                }

                gananciasTxT.Text = "$ +" + gameConstructor.getManager().gananciasTotales() + " per month.            ";
                int newTotal = gameConstructor.getManager().gastosTotales() - gameConstructor.getManager().gananciasTotales();
                if (newTotal < 0)
                {
                    totalPerdido.Text = "$ " + newTotal.ToString().Replace("-", "+") + " per month.";
                }
                else
                {
                    totalPerdido.Text = "$ -" + newTotal + " per month.";
                }

                //Month Bar
                monthBar.Value = monthCount;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error reported: "+ex.Message);
            }
        }

        private void paymonth_Tick(object sender, EventArgs e)
        {
            gameConstructor.getManager().nuevoSaldo();


            if (gameConstructor.getManager().enBancarrota())
            {
                TimerToClients.Enabled = false;
                timerInSecconds.Enabled = false;
                actualizarDatos.Enabled = false;
                MessageBox.Show("En bancarrota...");
                this.Close();
                Menu menu = new Menu();
                menu.Visible = true;
            }
        }

        private void Clientes_Tick(object sender, EventArgs e)
        {
            gameConstructor.getManager().agregarCliente();
        }

        private void TimerToClients_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            Clientes.Interval = random.Next(1000, 1999);
        }


        public int monthPerSecond = 10;
        private void timerInSecconds_Tick(object sender, EventArgs e)
        {
            //Agregar clientes
            //gameConstructor.getManager().agregarCliente();

            //Pago mensual
            if (monthPerSecond == 0)
            {
                gameConstructor.getManager().nuevoSaldo();

                monthPerSecond = 10;

                if (gameConstructor.getManager().enBancarrota())
                {
                    TimerToClients.Enabled = false;
                    timerInSecconds.Enabled = false;
                    actualizarDatos.Enabled = false;
                    MessageBox.Show("En bancarrota...");
                    this.Close();
                    Menu menu = new Menu();
                    menu.Visible = true;
                }
            }
            else
            {
                monthPerSecond -= 1;
            }


            // Prestamos
            if (monthCount == 10)
            {
                //paymonth.Enabled = true;
                pagarPrestamo1.Enabled = true;
                pagarPrestamo2.Enabled = true;
            }

            if (monthCount == 0)
            {
                monthCounter += 1;
                //timerInSecconds.Enabled = false;
                monthCount = 10;
            }
            else
            {
                monthCount--;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            addServer addServer = new addServer();
            addServer.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            addWorker addWorker = new addWorker();
            addWorker.ShowDialog();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            Menu menu = new Menu();
            menu.Visible = true;
        }

        private void eliminarCliente_Tick(object sender, EventArgs e)
        {
            gameConstructor.getManager().eliminarCliente();
        }

        private void pagarPrestamo1_Tick(object sender, EventArgs e)
        {
            if (gameConstructor.getManager().prestamoActivo(1))
                gameConstructor.getManager().pagarPrestamo(1);
        }

        private void pagarPrestamo2_Tick(object sender, EventArgs e)
        {
            if (gameConstructor.getManager().prestamoActivo(2))
                gameConstructor.getManager().pagarPrestamo(2);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            finanzas fina = new finanzas();
            fina.ShowDialog();
        }
    }
}
