using BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Diagnostics;

namespace WBL
{
    public interface ICamionService
    {
        Task<DBEntity> Create(CamionEntity entity);
        Task<DBEntity> Delete(CamionEntity entity);
        Task<IEnumerable<CamionEntity>> Get();
        Task<CamionEntity> GetById(CamionEntity entity);
        Task<IEnumerable<CamionEntity>> GetLista(EntregaEntity entity);
        Task<DBEntity> Update(CamionEntity entity);
    }

    public class CamionService : ICamionService
    {
        private readonly IDataAccess sql;

        public CamionService(IDataAccess _sql)
        {
            sql = _sql;
        }

        public async Task<IEnumerable<CamionEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<CamionEntity, ConductorEntity>("CamionObtener", "IdConductor");

                return await result;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<CamionEntity>> GetLista(EntregaEntity entity)
        {
            Debug.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            Debug.WriteLine(entity.FechaEntrega.ToString("yyy-MM-dd"));
            Debug.WriteLine(entity.IdCamion);
            string FechaEntrega = entity.FechaEntrega.ToString("yyyy-MM-dd");
            try
            {
                var result = sql.QueryAsync<CamionEntity>("CamionLista", new { FechaEntrega , entity.IdCamion });
                return await result;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<CamionEntity> GetById(CamionEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<CamionEntity>("CamionObtener", new
                {
                    entity.IdCamion
                });

                return await result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DBEntity> Create(CamionEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("CamionInsertar", new
                {
                    entity.IdConductor,
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

        public async Task<DBEntity> Update(CamionEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("CamionActualizar", new
                {
                    entity.IdCamion,
                    entity.IdConductor,
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

        public async Task<DBEntity> Delete(CamionEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("CamionEliminar", new
                {
                    entity.IdCamion
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
