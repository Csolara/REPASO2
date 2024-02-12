using REPASO2.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO2.Servicios
{
    internal interface OperativaInterfaz
    {

        public void darAltaCliente(List<ClienteDto> listaAntigua);

        public void MostrarActividades(List<ClienteDto> listaAntigua);

        public void borrarActividad(List<ClienteDto> listaAntigua);

    }
}
