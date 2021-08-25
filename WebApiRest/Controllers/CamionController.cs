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
    public class CamionController : ControllerBase
    {
        private readonly ICamionService camionService;

        public CamionController(ICamionService camionService)
        {
            this.camionService = camionService;
        }

        [HttpGet]
        public async Task<IEnumerable<CamionEntity>> Get()
        {
            try
            {
                return await camionService.Get();
            }
            catch (Exception ex)
            {

                return new List<CamionEntity>();
            }
        }

        [HttpGet("Lista")]
        public async Task<IEnumerable<CamionEntity>> GetLista()
        {
            try
            {
                return await camionService.Get();
            }
            catch (Exception ex)
            {

                return new List<CamionEntity>();
            }
        }

        [HttpGet("{id}")]
        public async Task<CamionEntity> GetById(int id)
        {
            try
            {
                return await camionService.GetById(new CamionEntity { IdCamion = id });
            }
            catch (Exception ex)
            {
                return new CamionEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        [HttpPost]
        public async Task<DBEntity> Create(CamionEntity entity)
        {
            try
            {
                return await camionService.Create(entity);
            }
            catch (Exception ex)
            {
                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        [HttpPut]
        public async Task<DBEntity> Update(CamionEntity entity)
        {
            try
            {
                return await camionService.Update(entity);
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
                return await camionService.Delete(new CamionEntity() { IdCamion = id });
            }
            catch (Exception ex)
            {
                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }
    }
}
