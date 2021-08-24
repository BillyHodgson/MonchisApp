using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages.Pedido
{
    public class GridModel : PageModel
    {
        private readonly ServiceApi service;

        public GridModel(ServiceApi service)
        {
            this.service = service;
        }
        public IEnumerable<PedidoEntity> GridList { get; set; } = new List<PedidoEntity>();
        public async Task<IActionResult> OnGet()
        {

            try
            {
                GridList = await service.PedidoGet();

                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }
    }
}
