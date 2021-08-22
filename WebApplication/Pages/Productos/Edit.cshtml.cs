using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages.Productos
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

        public ProductosEntity Entity = new ProductosEntity();

        public IEnumerable<CategoriaEntity> CategoriaLista { get; set; } = new List<CategoriaEntity>();

        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await service.ProductosGetById(id.Value);
                }

                CategoriaLista = await service.CategoriaGetLista();

                return Page();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
    }
}
