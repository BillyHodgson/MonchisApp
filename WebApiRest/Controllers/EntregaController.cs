using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBL;

namespace WebApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntregaController : ControllerBase
    {
        private readonly IEntregaService entregaService;

        public EntregaController(IEntregaService entregaService)
        {
            this.entregaService = entregaService;
        }


        [HttpGet]
        public async Task<IEnumerable<EntregaEntity>> Get()
        {
            try
            {
                return await entregaService.Get();
            }
            catch (Exception ex)
            {

                return new List<EntregaEntity>();
            }
        }


        [HttpGet("Lista")]
        public async Task<IEnumerable<EntregaEntity>> GetLista()
        {
            try
            {
                return await entregaService.Get();
            }
            catch (Exception ex)
            {

                return new List<EntregaEntity>();
            }
        }

        [HttpGet("{id}")]
        public async Task<EntregaEntity> GetById(int id)
        {
            try
            {
                return await entregaService.GetById(new EntregaEntity { IdEntrega = id });
            }
            catch (Exception ex)
            {

                return new EntregaEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }




        [HttpPost]
        public async Task<DBEntity> Create(EntregaEntity entity)
        {
            try
            {
                return await entregaService.Create(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        [HttpPut]
        public async Task<DBEntity> Update(EntregaEntity entity)
        {
            try
            {
                return await entregaService.Update(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }


        [HttpDelete("{id}")]
        public async Task<DBEntity> Delete(int id)
        {
            try
            {
                return await entregaService.Delete(new EntregaEntity() { IdEntrega = id });
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

    }
}
