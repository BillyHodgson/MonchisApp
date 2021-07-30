using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public class EntregaService
    {
        private readonly IDataAccess sql;

        public EntregaService(IDataAccess _sql)
        {
            sql = _sql;
        }

        public async Task<IEnumerable<EntregaEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<EntregaEntity, PedidoEntity, CamionEntity>("EntregaObtener", "IdEntrega,IdPedido,IdCamion");

                return await result;

            }
            catch (Exception)
            {

                throw;
            }
        }
            public async Task<EntregaEntity> GetById(EntregaEntity entity)
            {
                try
                {
                    var result = sql.QueryFirstAsync<EntregaEntity>("EntregaObtener", new
                    {
                        entity.IdEntrega
                    });

                    return await result;
                }
                catch (Exception)
                {

                    throw;
                }


            }


        public async Task<DBEntity> Create(EntregaEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("EntregaInsertar", new
                {
                    entity.FechaEntrega,
                    entity.IdPedido,
                    entity.Destino,
                    entity.IdCamion,
                    entity.Estado,
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<DBEntity> Update(EntregaEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("EntregaActualizar", new
                {
                    entity.IdEntrega,
                    entity.FechaEntrega,
                    entity.IdPedido,
                    entity.Destino,
                    entity.IdCamion,
                    entity.Estado,
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }


        public async Task<DBEntity> Delete(EntregaEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("EntregaEliminar", new
                {
                    entity.IdEntrega
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
