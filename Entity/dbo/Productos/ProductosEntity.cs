using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class ProductosEntity: EN
    {
        public int? IdProducto { get; set; }
        public int? IdCategoria { get; set; }
        public string  Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Caracteristicas { get; set; }
    }
}
