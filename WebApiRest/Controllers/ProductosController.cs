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
    public class ProductosController : ControllerBase
    {
        private readonly IProductosService productosService;

        public ProductosController(IProductosService productosService)
        {
            this.productosService = productosService;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductosEntity>> Get()
        {
            try
            {
                return await productosService.Get();
            }
            catch (Exception ex)
            {

                return new List<ProductosEntity>();
            }
        }

        [HttpGet("Lista")]
        public async Task<IEnumerable<ProductosEntity>> GetLista()
        {
            try
            {
                return await productosService.Get();
            }
            catch (Exception ex)
            {

                return new List<ProductosEntity>();
            }
        }

        [HttpGet("{id}")]
        public async Task<ProductosEntity> GetById(int id)
        {
            try
            {
                return await productosService.GetById(new ProductosEntity { IdProducto = id });
            }
            catch (Exception ex)
            {
                return new ProductosEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        [HttpPost]
        public async Task<DBEntity> Create(ProductosEntity entity)
        {
            try
            {
                return await productosService.Create(entity);
            }
            catch (Exception ex)
            {
                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        [HttpPut]
        public async Task<DBEntity> Update(ProductosEntity entity)
        {
            try
            {
                return await productosService.Update(entity);
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
                return await productosService.Delete(new ProductosEntity() { IdProducto = id });
            }
            catch (Exception ex)
            {
                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }
    }
}
