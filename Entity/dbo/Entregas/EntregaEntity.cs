using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntregaEntity : EN
    {
        public EntregaEntity()
        {
            Pedido = Pedido ?? new PedidoEntity();
            Camion = Camion ?? new CamionEntity();
        }

        public int? IdEntrega { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Destino { get; set; }
        public int? IdPedido { get; set; }
        public PedidoEntity Pedido { get; set; }
        public int? IdCamion { get; set; }
        public CamionEntity Camion { get; set; }
    }
}
