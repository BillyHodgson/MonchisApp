using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CamionEntity : EN
    {
        public CamionEntity()
        {
            Conductor = Conductor ?? new ConductorEntity();
        }

        public int? IdCamion { get; set; }       
        public string Caracteristicas { get; set; }
        public int? IdConductor { get; set; }
        public virtual ConductorEntity Conductor { get; set; }

    }
}
