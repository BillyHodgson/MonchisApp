using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ClienteEntity : EN
    {

        public int IdCliente { get; set; }
        public string Cedula { get; set; }

        public string NombreCompleto { get; set; }
        public string FechaNacimiento { get; set; }
        public int Telefono { get; set; }

    }
}
