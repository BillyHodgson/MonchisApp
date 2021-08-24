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

        public int? IdCliente { get; set; }
        public ClienteEntity Cliente { get; set; }

        public DateTime FechaPedido { get; set; } = DateTime.Today;

        public string IdProducto { get; set; }
        public ProductosEntity Producto { get; set; }

        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Envio { get; set; }

        public decimal Impuesto { get; set; }

        public decimal Total { get; set; }

    }
}
