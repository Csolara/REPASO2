using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO2.Dtos
{
    internal class ClienteDto
    {

        string nombreActividad;
        DateTime fechaInicioActividad;
        DateTime fechaFinActividad = DateTime.Now;
        TimeSpan duracionActividad;

        public string NombreActividad { get => nombreActividad; set => nombreActividad = value; }
        public DateTime FechaInicioActividad { get => fechaInicioActividad; set => fechaInicioActividad = value; }
        public DateTime FechaFinActividad { get => fechaFinActividad; set => fechaFinActividad = value; }
        public TimeSpan DuracionActividad { get => duracionActividad; set => duracionActividad = value; }

        public ClienteDto(string nombreActividad, DateTime fechaInicioActividad, DateTime fechaFinActividad, TimeSpan duracionActividad)
        {
            this.nombreActividad = nombreActividad;
            this.fechaInicioActividad = fechaInicioActividad;
            this.fechaFinActividad = fechaFinActividad;
            this.duracionActividad = fechaFinActividad - fechaInicioActividad;
        }

        public ClienteDto()
        {
        }             

        override
        public string ToString()
        {
            string cliente = "nombreCliente:  " + this.nombreActividad +
                "    fechaInicioCliente:  " + this.fechaInicioActividad +
                "    fechaFinCliente:  " + this.fechaFinActividad +
                "    durcionCliente:  " + this.duracionActividad;
            return cliente;
        }
    }
}
