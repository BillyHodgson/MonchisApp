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
        private readonly ICamionService camionService;

        public EditModel(ServiceApi service, ICatalogoProvinciaService catalogoProvinciaService,
            ICatalogoCantonService catalogoCantonService, ICatalogoDistritoService catalogoDistritoService
            , ICamionService camionService)
        {
            this.service = service;
            this.catalogoProvinciaService = catalogoProvinciaService;
            this.catalogoCantonService = catalogoCantonService;
            this.catalogoDistritoService = catalogoDistritoService;
            this.camionService = camionService;
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

        public async Task<IActionResult> OnPostGetListaCamiones()
        {
            Debug.WriteLine("============================44444444444");
            Debug.WriteLine(Entity.FechaEntrega);
            Debug.WriteLine(Entity.IdCamion);
              try
            {
                var result = await camionService.GetLista(
                          new EntregaEntity { FechaEntrega = Entity.FechaEntrega, IdCamion = Entity.IdCamion }
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
