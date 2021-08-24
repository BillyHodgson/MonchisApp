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
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;
        public string Telefono { get; set; }

    }
}
