using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages.Pedido
{
    public class EditModel : PageModel
    {

            private readonly ServiceApi service;

            public EditModel(ServiceApi service)
            {
                this.service = service;
            }


            [BindProperty(SupportsGet = true)]
            public int? id { get; set; }


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
        }
    
}
