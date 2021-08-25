using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ConductorEntity : EN
    {
        public int? IdConductor { get; set; }

        public string NombreCompleto { get; set; }

        public string Cedula { get; set; }

        public string Telefono { get; set; }

    }
}
