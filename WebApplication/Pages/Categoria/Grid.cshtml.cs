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

        public void OnGet()
        {
        }
    }
}
