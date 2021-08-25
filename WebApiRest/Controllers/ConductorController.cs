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
    public class ConductorController : ControllerBase
    {
        private readonly IConductorService conductorService;

        public ConductorController(IConductorService conductorService )
        {
            this.conductorService = conductorService;
        }


        [HttpGet]
        public async Task<IEnumerable<ConductorEntity>> Get()
        {
            try
            {
                return await conductorService.Get();
            }
            catch (Exception ex)
            {

                return new List<ConductorEntity>();
            }
        }

        [HttpGet("Lista")]
        public async Task<IEnumerable<ConductorEntity>> GetLista()
        {
            try
            {
                return await conductorService.Get();
            }
            catch (Exception ex)
            {

                return new List<ConductorEntity>();
            }
        }

        [HttpGet("{id}")]
        public async Task<ConductorEntity> GetById(int id)
        {
            try
            {
                return await conductorService.GetById(new ConductorEntity { IdConductor = id });
            }
            catch (Exception ex)
            {

                return new ConductorEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }




        [HttpPost]
        public async Task<DBEntity> Create(ConductorEntity entity)
        {
            try
            {
                return await conductorService.Create(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        [HttpPut]
        public async Task<DBEntity> Update(ConductorEntity entity)
        {
            try
            {
                return await conductorService.Update(entity);
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
                return await conductorService.Delete(new ConductorEntity() { IdConductor = id });
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }
    }
}
