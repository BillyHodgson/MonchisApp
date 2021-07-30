using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PedidoEntity
    {
        public PedidoEntity()
        {
            Cliente = Cliente ?? new ClienteEntity();
            Producto = Producto ?? new ProductosEntity();

        }

        public int? IdPedido { get; set; }

        public int? IdCliente { get; set; }
        public ClienteEntity Cliente { get; set; }

        public DateTime FechaPedido { get; set; } = DateTime.Today;

        public string IdProducto { get; set; }
        public ProductosEntity Producto { get; set; }

        public int Cantidad { get; set; }

        public double SubTotal { get; set; }

        public double Envio { get; set; }

        public double IVA { get; set; } = 0.13;

        public double Total { get; set; }

    }
}
