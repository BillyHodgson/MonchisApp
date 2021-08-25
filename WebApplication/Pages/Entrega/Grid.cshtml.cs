using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApplication.Pages.Entrega
{
    public class GridModel : PageModel
    {
        private readonly ServiceApi service;

        public GridModel(ServiceApi service)
        {
            this.service = service;
        }

        public IEnumerable<EntregaEntity> GridList { get; set; } = new List<EntregaEntity>();


        public async Task<IActionResult> OnGet()
        {
            try
            {
                GridList = await service.EntregaGet();
                return Page();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }      

    }
}
