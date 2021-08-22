using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages.Productos
{
    public class GridModel : PageModel
    {
        private readonly ServiceApi service;

        public GridModel(ServiceApi service)
        {
            this.service = service;
        }

        public IEnumerable<ProductosEntity> GridList { get; set; } = new List<ProductosEntity>();

        public async Task<IActionResult> OnGet()
        {
            try
            {
                GridList = await service.ProductosGet();
                return Page();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
    }
}
