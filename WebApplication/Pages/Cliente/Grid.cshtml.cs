using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages.Cliente
{
    public class GridModel : PageModel
    {
        private readonly ServiceApi service;
        public GridModel(ServiceApi service)
        {
            this.service = service;
        }

        public IEnumerable<ClienteEntity> GridList { get; set; } = new List<ClienteEntity>();

        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (!this.SessionOnline()) return RedirectToPage("../Login");

                GridList = await service.ClienteGet();
                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }



        }
    }
}
