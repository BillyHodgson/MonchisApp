using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IPedidoService
    {
        Task<DBEntity> Create(PedidoEntity entity);
        Task<DBEntity> Delete(PedidoEntity entity);
        Task<IEnumerable<PedidoEntity>> Get();
        Task<PedidoEntity> GetById(PedidoEntity entity);
        Task<DBEntity> Update(PedidoEntity entity);
    }

    public class PedidoService : IPedidoService
    {
        private readonly IDataAccess sql;

        public PedidoService(IDataAccess _sql)
        {
            sql = _sql;
        }

        public async Task<IEnumerable<PedidoEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<PedidoEntity, ClienteEntity, ProductosEntity>("PedidoObtener", "IdPedido,IdCliente,IdProducto");

                return await result;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<PedidoEntity> GetById(PedidoEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<PedidoEntity>("PedidoObtener", new
                {
                    entity.IdPedido
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<DBEntity> Create(PedidoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("PedidoInsertar", new
                {
                    entity.IdCliente,
                    entity.FechaPedido,
                    entity.IdProducto,
                    entity.Cantidad,
                    entity.PrecioUnitario,
                    entity.SubTotal,
                    entity.Envio,
                    entity.Impuesto,
                    entity.Total
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<DBEntity> Update(PedidoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("PedidoActualizar", new
                {
                    entity.IdPedido,
                    entity.IdCliente,
                    entity.FechaPedido,
                    entity.IdProducto,
                    entity.Cantidad,
                    entity.PrecioUnitario,
                    entity.SubTotal,
                    entity.Envio,
                    entity.Impuesto,
                    entity.Total
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<DBEntity> Delete(PedidoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("PedidoEliminar", new
                {
                    entity.IdPedido
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
