using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IClienteService
    {
        Task<DBEntity> Create(ClienteEntity entity);
        Task<DBEntity> Delete(ClienteEntity entity);
        Task<IEnumerable<ClienteEntity>> Get();
        Task<ClienteEntity> GetById(ClienteEntity entity);
        Task<IEnumerable<ClienteEntity>> GetLista();
        Task<DBEntity> Update(ClienteEntity entity);
    }

    public class ClienteService : IClienteService
    {
        private readonly IDataAccess sql;

        public ClienteService(IDataAccess _sql)
        {
            sql = _sql;
        }

        public async Task<IEnumerable<ClienteEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<ClienteEntity>("ClienteObtener");

                return await result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<ClienteEntity>> GetLista()
        {
            try
            {
                var result = sql.QueryAsync<ClienteEntity>("ClienteLista");
                return await result;
            }
            catch (Exception EX)
            {
                throw;
            }
        }

        public async Task<ClienteEntity> GetById(ClienteEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<ClienteEntity>("ClienteObtener", new
                {
                    entity.IdCliente
                });
                return await result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DBEntity> Create(ClienteEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ClienteInsertar", new
                {
                    entity.Cedula,
                    entity.NombreCompleto,
                    entity.FechaNacimiento,
                    entity.Telefono,
                    entity.Estado
                });
                return await result;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<DBEntity> Update(ClienteEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ClienteActualizar", new
                {
                    entity.IdCliente,
                    entity.Cedula,
                    entity.NombreCompleto,
                    entity.FechaNacimiento,
                    entity.Telefono,
                    entity.Estado
                });
                return await result;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<DBEntity> Delete(ClienteEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ClienteEliminar", new
                {
                    entity.IdCliente
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
