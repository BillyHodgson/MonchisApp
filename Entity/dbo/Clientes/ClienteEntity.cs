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

        public string Nombre { get; set; }

        public string Primer_Apellido { get; set; }

        public string Segundo_Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public int Telefono { get; set; }

    }
}
