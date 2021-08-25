using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApplication.Pages.Entregas
{
    public class GridModel : PageModel
    {
        private readonly IEntregaService entregaService;

        public GridModel(IEntregaService entregaService)
        {
            this.entregaService = entregaService;
        }

        public IEnumerable<EntregaEntity> GridList { get; set; } = new List<EntregaEntity>();

        public string Mensaje { get; set; } = "";

        public async Task<IActionResult> OnGet()
        {
            try
            {
                
                GridList = await entregaService.Get();

                if (TempData.ContainsKey("Msg"))
                {
                    Mensaje = TempData["Msg"] as string;
                }

                TempData.Clear();

                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }

        public async Task<IActionResult> OnGetEliminar(int id)
        {
            try
            {
                var result = await entregaService.Delete(new()
                {
                    IdEntrega = id

                });

                if (result.CodeError != 0)
                {
                    throw new Exception(result.MsgError);
                }
                TempData["Msg"] = "Se elimino correctamente";

                return Redirect("Grid");

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }

    }
}
