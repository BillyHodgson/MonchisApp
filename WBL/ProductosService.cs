using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IProductosService
    {
        Task<DBEntity> Create(ProductosEntity entity);
        Task<DBEntity> Delete(ProductosEntity entity);
        Task<IEnumerable<ProductosEntity>> Get();
        Task<ProductosEntity> GetById(ProductosEntity entity);
        Task<DBEntity> Update(ProductosEntity entity);
    }

    public class ProductosService : IProductosService
    {
        private readonly IDataAccess sql;

        public ProductosService(IDataAccess sql)
        {
            this.sql = sql;
        }

        public async Task<IEnumerable<ProductosEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<ProductosEntity, CategoriaEntity>("ProductosObtener", "IdCategoria");
                return await result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ProductosEntity> GetById(ProductosEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<ProductosEntity>("ProductosObtener", new
                {
                    entity.IdProducto
                });
                return await result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DBEntity> Create(ProductosEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ProductosInsertar", new
                {
                    entity.IdCategoria,
                    entity.Nombre,
                    entity.Precio,
                    entity.Cantidad,
                    entity.Caracteristicas,
                    entity.Estado
                });
                return await result;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<DBEntity> Update(ProductosEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ProductosActualizar", new
                {
                    entity.IdProducto,
                    entity.IdCategoria,
                    entity.Nombre,
                    entity.Precio,
                    entity.Cantidad,
                    entity.Caracteristicas,
                    entity.Estado
                });
                return await result;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<DBEntity> Delete(ProductosEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ProductosEliminar", new
                {
                    entity.IdProducto
                });
                return await result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
