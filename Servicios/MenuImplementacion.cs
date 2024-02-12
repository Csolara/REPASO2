using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO2.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int MENU()
        {
            int opcionseleccionada;

            Console.WriteLine("##################################");
            Console.WriteLine("0. Cerrar aplicacion.");
            Console.WriteLine("1. Dar de alta una actividad.");
            Console.WriteLine("2. Mostrar una actividad.");
            Console.WriteLine("3. Eliminar una atividad.");
            Console.WriteLine("##################################");

            opcionseleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionseleccionada;
        }

    }
}
