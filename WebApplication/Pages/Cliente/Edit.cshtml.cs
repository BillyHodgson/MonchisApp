using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages.Cliente
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

        public ClienteEntity Entity = new ClienteEntity();


        public async Task<IActionResult> OnGet()
        {

            try
            {
                
                if (id.HasValue)
                {
                    Entity = await service.ClienteGetById(id.Value);
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
