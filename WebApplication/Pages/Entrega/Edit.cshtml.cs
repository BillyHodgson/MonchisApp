using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApplication.Pages.Entregas
{
    public class EditModel : PageModel
    {
        private readonly ServiceApi service;

        private readonly ICatalogoProvinciaService catalogoProvinciaService;
        private readonly ICatalogoCantonService catalogoCantonService;
        private readonly ICatalogoDistritoService catalogoDistritoService;

        public EditModel(ServiceApi service, ICatalogoProvinciaService catalogoProvinciaService,
            ICatalogoCantonService catalogoCantonService, ICatalogoDistritoService catalogoDistritoService)
        {
            this.service = service;
            this.catalogoProvinciaService = catalogoProvinciaService;
            this.catalogoCantonService = catalogoCantonService;
            this.catalogoDistritoService = catalogoDistritoService;
        }

        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        [BindProperty]
        [FromBody]
        public EntregaEntity Entity { get; set; } = new EntregaEntity();

        public IEnumerable<CatalogoProvinciaEntity> ProvinciaLista { get; set; } = new List<CatalogoProvinciaEntity>();

        public IEnumerable<PedidoEntity> PedidoLista { get; set; } = new List<PedidoEntity>();
        public IEnumerable<CamionEntity> CamionLista { get; set; } = new List<CamionEntity>();

        public async Task<IActionResult> OnGet()
        {

            try
            {
                
                if (id.HasValue)
                {
                    Entity = await service.EntregaGetById(id.Value);
                }

                ProvinciaLista = await catalogoProvinciaService.GetLista();
                PedidoLista = await service.PedidoGetLista();
                CamionLista = await service.CamionGetLista();

                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        public async Task<IActionResult> OnPostChangeProvincia(string e)
        {

            try
            {
                var result = await catalogoCantonService.GetLista(

                      new CatalogoProvinciaEntity { IdCatalogoProvincia = Entity.IdCatalogoProvincia }
                    );
                return new JsonResult(result);
            }
            catch (Exception ex)
            {

                return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }

        }

        public async Task<IActionResult> OnPostChangeCanton()
        {

            try
            {
                var result = await catalogoDistritoService.GetLista(
                      new CatalogoCantonEntity { IdCatalogoCanton = Entity.IdCatalogoCanton }
                    );
                return new JsonResult(result);
            }
            catch (Exception ex)
            {

                return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }

        }
    }
}
