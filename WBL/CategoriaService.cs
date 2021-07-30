using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface ICategoriaService
    {
        Task<DBEntity> Create(CategoriaEntity entity);
        Task<DBEntity> Delete(CategoriaEntity entity);
        Task<IEnumerable<CategoriaEntity>> Get();
        Task<CategoriaEntity> GetById(CategoriaEntity entity);
        Task<DBEntity> Update(CategoriaEntity entity);
    }

    public class CategoriaService : ICategoriaService
    {
        private readonly IDataAccess sql;


        public CategoriaService(IDataAccess _sql)
        {
            sql = _sql;
        }

        public async Task<IEnumerable<CategoriaEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<CategoriaEntity>("CategoriaObtener");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<CategoriaEntity> GetById(CategoriaEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<CategoriaEntity>("CategoriaObtener", new
                {
                    entity.IdCategoria
                }


                );

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DBEntity> Create(CategoriaEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("CategoriaInsertar", new
                {
                    entity.IdCategoria,
                    entity.Descripcion
                }


                );

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<DBEntity> Update(CategoriaEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("CategoriaActualizar", new
                {
                    entity.IdCategoria,
                    entity.Descripcion
                }


                );

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<DBEntity> Delete(CategoriaEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("CategoriaEliminar", new
                {
                    entity.IdCategoria

                }


                );

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
