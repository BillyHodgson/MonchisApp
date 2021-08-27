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
            Provincia = Provincia ?? new CatalogoProvinciaEntity();
            Canton = Canton ?? new CatalogoCantonEntity();
            Distrito = Distrito ?? new CatalogoDistritoEntity();
        }

        public int? IdEntrega { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int? IdCatalogoProvincia { get; set; }
        public CatalogoProvinciaEntity Provincia { get; set; }
        public int? IdCatalogoCanton { get; set; }
        public CatalogoCantonEntity Canton { get; set; }
        public int? IdCatalogoDistrito { get; set; }
        public CatalogoDistritoEntity Distrito { get; set; }
        public int? IdPedido { get; set; }
        public PedidoEntity Pedido { get; set; }
        public int? IdCamion { get; set; }
        public CamionEntity Camion { get; set; }
    }
}
