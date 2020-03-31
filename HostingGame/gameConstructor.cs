using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostingGame
{
    class gameConstructor
    {
        public static gameConstructor gc = new gameConstructor();

        public static gameConstructor getManager()
        { return gc; }


        //Detalles empresa
        public String nombreEmpresa = "Mi empresa";
        public String nombreDirector = "usuario_01";

        //Economia
        public int dineroActual = 5000;
        //public double iva = 0.01;

        //Empleados
        public int desarrolladores = 0;
        public int developersPersServer = 2;

        public int pagaDevelopers = 1320;
        public int tecnicos = 0;
        public int tecnicosPerServer = 3;
        public int pagaTecnicos = 960;

        //Servidores
        public int smallServer = 0;
        public int costeCompraSmallServer = 160;
        public int costeMantenimientoServidorS = 98;
        public int costeEnergiaSmall = 68;

        public int mediumServer = 0;
        public int costeCompraMediumServer = 250;
        public int costeMantenimientoServidorM = 215;
        public int costeEnergiaMedium = 140;

        public int bigServer = 0;
        public int costeCompraBigServer = 400;
        public int costeMantenimientoServidorB = 330;
        public int costeEnergiaBig = 187;

        //Clientes
        public int clientesSmallServer = 0;
        public int precioSmallServer = 67;

        public int clientesMediumServer = 0;
        public int precioMediumServer = 128;

        public int clientesBigServer = 0;
        public int precioBigServer = 223;

        public string nombreEmpresaTxT { get; internal set; }

        //Prestamos
        public Boolean prestamo1 = false;
        public int darPrestamo1 = 10000;
        public int payPrestamo1 = 1022;
        public int vecesPagado1 = 0;

        public Boolean prestamo2 = false;
        public int darPrestamo2 = 50000;
        public int payPrestamo2 = 4460;
        public int vecesPagado2 = 0;

        public Boolean prestamo3 = false;
        public int darPrestamo3 = 100000;
        public int payPrestamo3 = 8698;
        public int vecesPagado3 = 0;

        public int dineroRestantePrestamos()
        {
            int totalPagos = 12;
            int totalEnPrestamo = 0;
            if(prestamo1)
                totalEnPrestamo += payPrestamo1 * (totalPagos - vecesPagado1);

            if(prestamo2)
                totalEnPrestamo += payPrestamo2 * (totalPagos - vecesPagado2);

            if(prestamo3)
                totalEnPrestamo += payPrestamo3 * (totalPagos - vecesPagado3);

            return totalEnPrestamo;
        }

        public int dineroRestantePrestamo(int id)
        {
            int totalPagos = 12;
            switch (id)
            {
                case 1:
                    return payPrestamo1 * (totalPagos - vecesPagado1);
                case 2:
                    return payPrestamo2 * (totalPagos - vecesPagado2);
                case 3:
                    return payPrestamo3 * (totalPagos - vecesPagado3);
                default:
                    return 0;
            }
        }

        public void pagarPrestamoTotal(int id)
        {
            switch (id)
            {
                case 1:
                    prestamo1 = false;
                    vecesPagado1 = 0;
                    break;
                case 2:
                    prestamo2 = false;
                    vecesPagado2 = 0;
                    break;
                case 3:
                    prestamo3 = false;
                    vecesPagado3 = 0;
                    break;
                default:
                    break;
            }
        }

        public void pagarPrestamo(int id)
        {
            switch (id)
            {
                case 1:
                    if (vecesPagado1 == 12)
                    {
                        prestamo1 = false;
                        vecesPagado1 = 0;
                        return;
                    }
                    gameConstructor.getManager().dineroActual -= gameConstructor.getManager().payPrestamo1;
                    vecesPagado1 += 1;
                    break;
                case 2:
                    if (vecesPagado2 == 12)
                    {
                        prestamo2 = false;
                        vecesPagado2 = 0;
                        return;
                    }
                    gameConstructor.getManager().dineroActual -= gameConstructor.getManager().payPrestamo2;
                    vecesPagado2 += 1;
                    break;
                case 3:
                    if (vecesPagado3 == 12)
                    {
                        prestamo3 = false;
                        vecesPagado3 = 0;
                        return;
                    }
                    gameConstructor.getManager().dineroActual -= gameConstructor.getManager().payPrestamo3;
                    vecesPagado3 += 1;
                    break;
                default:
                    break;
            }
        }

        public Boolean prestamoActivo(int id)
        {
            switch (id)
            {
                case 1:
                    if (prestamo1 == true)
                        return true;
                    break;
                case 2:
                    if (prestamo2 == true)
                        return true;
                    break;
                case 3:
                    if (prestamo3 == true)
                        return true;
                    break;
                default:
                    break;
            }
            return false;
        }

        public void tomarPrestamo(int id)
        {
            switch (id)
            {
                case 1:
                    prestamo1 = true;
                    dineroActual += darPrestamo1;
                    break;
                case 2:
                    prestamo2 = true;
                    dineroActual += darPrestamo2;
                    break;
                case 3:
                    prestamo3 = true;
                    dineroActual += darPrestamo3;
                    break;
                default:
                    break;
            }
        }

        public Boolean prestamoActivo()
        {
            if ((prestamo1 || prestamo2 || prestamo3) == true)
                return true;
            return false;
        }

        public void agregarDeveloper()
        { desarrolladores += 1; }

        public void agregarTecnico()
        { tecnicos += 1; }

        public void agregarServidor(int type)
        {
            switch (type)
            {
                case 1:
                    smallServer += 1;
                    dineroActual -= costeCompraSmallServer;
                    break;
                case 2:
                    mediumServer += 1;
                    dineroActual -= costeCompraMediumServer;
                    break;
                case 3:
                    bigServer += 1;
                    dineroActual -= costeCompraBigServer;
                    break;
                default:
                    break;
            }
        }

        public int capacidadTotal(int type)
        {
            switch (type)
            {
                case 1:
                    return (smallServer * 5);
                case 2:
                    return (mediumServer * 15);
                case 3:
                    return (bigServer * 20);
                default:
                    return -1;
            }
        }

        public void eliminarCliente()
        {
            Random random = new Random();

            int numero = random.Next(0, 5);

            if (numero == 1)
            {
                if (menosClientes(1) == true)
                {
                    clientesSmallServer -= 1;
                    return;
                }
            }

            if (numero == 2)
            {
                if (menosClientes(2) == true)
                {
                    clientesMediumServer -= 1;
                    return;
                }
            }

            if (numero == 3)
            {
                if (menosClientes(3) == true)
                {
                    clientesBigServer -= 1;
                    return;
                }
            }
            return;
        }

        public void agregarCliente()
        {
            Random random = new Random();

            int numero = random.Next(1, 4);

            if (numero == 1)
            {
                if (masClientes(1) == true)
                {
                    clientesSmallServer += 1;
                    return;
                }
            }

            if (numero == 2)
            {
                if (masClientes(2) == true)
                {
                    clientesMediumServer += 1;
                    return;
                }
            }

            if (numero == 3)
            {
                if (masClientes(3) == true)
                {
                    clientesBigServer += 1;
                    return;
                }
            }
            return;
        }

        public int totalServers()
        {
            int totalServer = smallServer + mediumServer + bigServer;
            return totalServer;
        }

        public Boolean masServidores(int type)
        {
            switch (type)
            {
                case 1:
                    if ((desarrolladores * developersPersServer >= smallServer) && !(totalServers() >= desarrolladores * developersPersServer))
                        return true;
                    break;
                case 2:
                    if ((desarrolladores * developersPersServer >= mediumServer) && !(totalServers() >= desarrolladores * developersPersServer))
                        return true;
                    break;
                case 3:
                    if (((desarrolladores * developersPersServer >= bigServer) && (tecnicos * tecnicosPerServer >= bigServer)) && !(totalServers() >= desarrolladores * developersPersServer))
                        return true;
                    break;
                default:
                    return false;
            }
            return false;
        }

        public Boolean menosClientes(int type)
        {
            switch (type)
            {
                case 1:
                    if (clientesSmallServer > 1)
                        return true;
                    break;
                case 2:
                    if (clientesMediumServer > 1)
                        return true;
                    break;
                case 3:
                    if (clientesBigServer > 1)
                        return true;
                    break;
                default:
                    return false;
            }
            return false;
        }

        public Boolean masClientes(int type)
        {
            switch (type)
            {
                case 1:
                    if (clientesSmallServer != (smallServer * 5) && ((smallServer * 100) > 0))
                        return true;
                    break;
                case 2:
                    if (clientesMediumServer != (mediumServer * 15) && ((mediumServer * 100) > 0))
                        return true;
                    break;
                case 3:
                    if (clientesBigServer != (bigServer * 20) && ((bigServer * 100) > 0))
                        return true;
                    break;
                default:
                    return false;
            }
            return false;
        }

        public Boolean enBancarrota()
        {
            if (dineroActual <= -10000)
                return true;
            return false;
        }

        public void nuevoSaldo()
        {
            dineroActual += gananciasTotales() - gastosTotales();
        }

        public int gananciasTotales()
        {
            int ganancias = (clientesSmallServer * precioSmallServer) + (clientesMediumServer * precioMediumServer)
                + (clientesBigServer * precioBigServer);
            return ganancias;
        }

        public int gastosTotales()
        {
            int gastosTotales = (desarrolladores * pagaDevelopers) + (tecnicos * pagaTecnicos)
                + (smallServer * costeMantenimientoServidorS) + (mediumServer * costeMantenimientoServidorM)
                + (bigServer * costeMantenimientoServidorB)
                + (costeEnergiaSmall * smallServer) + (costeEnergiaMedium * mediumServer) + (costeEnergiaBig * bigServer);
            return gastosTotales;
        }

        public int gastosTotales(int masGastos)
        {
            return gastosTotales() + masGastos;
        }

        public int TotalClientes()
        {
            int totalclientes = clientesSmallServer + clientesMediumServer + clientesBigServer;
            return totalclientes;
        }

        public int TotalServidores()
        {
            int totalServidores = smallServer + mediumServer + bigServer;
            return totalServidores;
        }

        public int TotalEmpleados()
        {
            int totalempleados = desarrolladores + tecnicos;
            return totalempleados;
        }

        public Boolean verificarServidoresPorCliente()
        {
            if ((smallServer <= TotalClientes()) &&
                (mediumServer <= TotalClientes()) &&
                (bigServer <= TotalClientes()))
                return true;
            return false;
        }

        public void setNombreEmpresa(String newValue)
        {
            nombreEmpresaTxT = newValue;
        }
    }
}
