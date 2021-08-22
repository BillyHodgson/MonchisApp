using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entity;

namespace WebApplication.Pages.Categoria
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

        public CategoriaEntity Entity = new CategoriaEntity();

        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await service.CategoriaGetById(id.Value);
                }
                return Page();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
    }
}
