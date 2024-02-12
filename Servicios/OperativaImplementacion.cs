using Microsoft.VisualBasic;
using REPASO2.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO2.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {

        public void darAltaCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto actividad = crearNuevaActividad();
            listaAntigua.Add(actividad);                      
        }

        private ClienteDto crearNuevaActividad()
        {
            ClienteDto nuevoCliente = new ClienteDto();

            Console.WriteLine("Introduzca el nombre: ");
            nuevoCliente.NombreActividad = Console.ReadLine();

            Console.WriteLine("Introduzca la fecha de inicio (XX/XX/XXXX XX:XX:XX): ");
            nuevoCliente.FechaInicioActividad = Convert.ToDateTime(Console.ReadLine());            

            DateTime FechaFinCliente = DateTime.Now;
            Console.WriteLine(FechaFinCliente.ToString());

            nuevoCliente.DuracionActividad = FechaFinCliente - nuevoCliente.FechaInicioActividad;

            Console.WriteLine("");
            Console.WriteLine("=======================================");
            Console.WriteLine("Nombre: " + nuevoCliente.NombreActividad);
            Console.WriteLine("Fecha de inicio: " + nuevoCliente.FechaInicioActividad);
            Console.WriteLine("Fecha de fin: " + FechaFinCliente);
            Console.WriteLine("Duracion de la actividad: " + nuevoCliente.DuracionActividad.TotalMinutes + " minutos.");
            Console.WriteLine("=======================================");
            Console.WriteLine("");

            return nuevoCliente;
        }

        public void MostrarActividades(List<ClienteDto> listaAntigua)
        {
            foreach (ClienteDto Actividad in listaAntigua)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================");
                Console.WriteLine("Nombre: " + Actividad.NombreActividad);
                Console.WriteLine("Fecha inicial: " + Actividad.FechaInicioActividad);
                Console.WriteLine("Fecha final: " + Actividad.FechaFinActividad);
                Console.WriteLine("Minutos: " + Actividad.DuracionActividad.TotalMinutes);
                Console.WriteLine("=============================");
                Console.WriteLine("");
            }
        }

        public void borrarActividad(List<ClienteDto> listaAntigua)
        {
            foreach (ClienteDto Actividad in listaAntigua)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================");
                Console.WriteLine("Nombre: " + Actividad.NombreActividad);
                Console.WriteLine("Minutos: " + Actividad.DuracionActividad.TotalMinutes);
                Console.WriteLine("=============================");
                Console.WriteLine("");
            }

            Console.WriteLine("Escriba el nombre de la actividad que quiere borrar: ");
            string NOMBRE = Console.ReadLine();

            ClienteDto borrarCliente = listaAntigua.Find(c => c.NombreActividad == NOMBRE);

            if (borrarCliente != null)
            {
                listaAntigua.Remove(borrarCliente);
                Console.WriteLine("La actividad " + NOMBRE + " se ha eliminado.");
            }
            else
            {
                Console.WriteLine("No se ha encontrado una actividad con el nombre: " + NOMBRE + ".");
            }
        }
    }
}
