using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApplication.Pages.Pedido
{
    public class EditModel : PageModel
    {
         private readonly ServiceApi service;

        private readonly IProductosService productosService;

        public EditModel(ServiceApi service, IProductosService productosService)
            {
                this.service = service;
                this.productosService = productosService;
            }

            [BindProperty(SupportsGet = true)]
            public int? id { get; set; }

        [BindProperty]
        [FromBody]
        public PedidoEntity Entity { get; set; } = new PedidoEntity();

            public IEnumerable<ClienteEntity> ClienteLista { get; set; } = new List<ClienteEntity>();

            public IEnumerable<ProductosEntity> ProductoLista { get; set; } = new List<ProductosEntity>();

            public async Task<IActionResult> OnGet()
            {
                try
                {
                    
                    if (id.HasValue)
                    {
                        Entity = await service.PedidoGetById(id.Value);
                    }


                    ClienteLista = await service.ClienteGetLista();

                    ProductoLista = await service.ProductosGetLista();

                    return Page();
                }
                catch (Exception ex)
                {

                    return Content(ex.Message);
                }
            }

            public async Task<IActionResult> OnPostChangeProducto()
            {
                try
                {
                Debug.WriteLine("======================================");
                Debug.WriteLine(Entity.IdProducto);
                var result = await productosService.GetById(
                          new ProductosEntity { IdProducto = Entity.IdProducto }
                        );
                    return new JsonResult(result);
                }
                catch (Exception ex)
                {

                    return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
                }

            }
    }
    
}
