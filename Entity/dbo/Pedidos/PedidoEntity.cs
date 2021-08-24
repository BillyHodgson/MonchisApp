using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PedidoEntity : EN
    {
        public PedidoEntity()
        {
            Cliente = Cliente ?? new ClienteEntity();
            Producto = Producto ?? new ProductosEntity();

        }

        public int? IdPedido { get; set; }

        public DateTime FechaPedido { get; set; } = DateTime.Today;

        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Envio { get; set; }

        public decimal Impuesto { get; set; }

        public decimal Total { get; set; }

        public int? IdCliente { get; set; }
        public ClienteEntity Cliente { get; set; }

        public int? IdProducto { get; set; }
        public ProductosEntity Producto { get; set; }

    }
}
