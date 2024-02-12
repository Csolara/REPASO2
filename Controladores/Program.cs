using REPASO2.Dtos;
using REPASO2.Servicios;

namespace REPASO2.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            List<ClienteDto> listaClientes = new List<ClienteDto>();

            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();

            bool cerrarMenu = false;

            while(!cerrarMenu)
            {
                int recogido = mi.MENU();
                switch (recogido)
                {
                    case 0:
                        Console.WriteLine("La aplicacion se cerrara.");
                        cerrarMenu = true;
                        break;
                    case 1:
                        oi.darAltaCliente(listaClientes);
                        break;
                    case 2:
                        oi.MostrarActividades(listaClientes);
                        break;
                    case 3:
                        oi.borrarActividad(listaClientes);
                        break;
                    default:
                        Console.WriteLine("La opcion que ha seleccionada no coincide con ninguna.");
                        break;
                }
            }
        }
    }
}
