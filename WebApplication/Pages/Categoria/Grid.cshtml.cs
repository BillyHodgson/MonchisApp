using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApplication.Pages.Categoria
{
    public class GridModel : PageModel
    {
        private readonly ICategoriaService categoriaService;

        public GridModel(ICategoriaService categoriaService)
        {
            this.categoriaService = categoriaService;
        }

        public IEnumerable<CategoriaEntity> GridList { get; set; } = new List<CategoriaEntity>();

        public async Task<IActionResult> OnGet()
        {
            try
            {
                GridList = await categoriaService.Get();
                return Page();

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
    }
}
