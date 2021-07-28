using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.dbo.Pedidos
{
    public class Pedido
    {

        public int Codigo { get; set; }

        public string Cliente { get; set; }

        public DateTime FechaPedido { get; set; } = DateTime.Today;

        public string Producto { get; set; }

        public int Cantidad { get; set; }

        public double SubTotal { get; set; }

        public double Envio { get; set; }

        public double IVA { get; set; } = 0.13;

        public double Total { get; set; }

    }
}
