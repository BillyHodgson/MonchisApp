using Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApplication
{
    public class ServiceApi
    {
        private readonly HttpClient client;

        public ServiceApi(HttpClient client)
        {
            this.client = client;
        }

        #region Categorias
        public async Task<IEnumerable<CategoriaEntity>> CategoriaGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<CategoriaEntity>>("api/Categoria");
            return result;
        }

        public async Task<IEnumerable<CategoriaEntity>> CategoriaGetLista()
        {
            var result = await client.ServicioGetAsync<IEnumerable<CategoriaEntity>>("api/Categoria/Lista");
            return result;
        }

        public async Task<CategoriaEntity> CategoriaGetById(int id)
        {
            var result = await client.ServicioGetAsync<CategoriaEntity>("api/Categoria/" + id);
            if (result.CodeError is not 0) throw new Exception(result.MsgError);
            return result;
        }
        #endregion

        #region Productos
        public async Task<IEnumerable<ProductosEntity>> ProductosGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ProductosEntity>>("api/Productos");
            return result;
        }

        public async Task<IEnumerable<ProductosEntity>> ProductosGetLista()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ProductosEntity>>("api/Productos/Lista");
            return result;
        }

        public async Task<ProductosEntity> ProductosGetById(int id)
        {
            var result = await client.ServicioGetAsync<ProductosEntity>("api/Productos/" + id);
            if (result.CodeError is not 0) throw new Exception(result.MsgError);
            return result;
        }
        #endregion

        #region Pedido
        public async Task<IEnumerable<PedidoEntity>> PedidoGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<PedidoEntity>>("api/Pedido");

            return result;

        }

        public async Task<PedidoEntity> PedidoGetById(int id)
        {
            var result = await client.ServicioGetAsync<PedidoEntity>("api/Pedido/" + id);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;

        }

        public async Task<IEnumerable<PedidoEntity>> PedidoGetLista()
        {
            var result = await client.ServicioGetAsync<IEnumerable<PedidoEntity>>("api/Pedido/Lista");
            return result;
        }

        #endregion

        #region Cliente

        public async Task<IEnumerable<ClienteEntity>> ClienteGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ClienteEntity>>("api/Cliente");

            return result;


        }

        public async Task<IEnumerable<ClienteEntity>> ClienteGetLista()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ClienteEntity>>("api/Cliente/Lista");

            return result;

        }

        public async Task<ClienteEntity> ClienteGetById(int id)
        {
            var result = await client.ServicioGetAsync<ClienteEntity>("api/Cliente/" + id);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;


        }

        #endregion

        #region Entrega

        public async Task<IEnumerable<EntregaEntity>> EntregaGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<EntregaEntity>>("api/Entrega");

            return result;


        }

        public async Task<IEnumerable<EntregaEntity>> EntregaGetLista()
        {
            var result = await client.ServicioGetAsync<IEnumerable<EntregaEntity>>("api/Entrega/Lista");

            return result;

        }

        public async Task<EntregaEntity> EntregaGetById(int id)
        {
            var result = await client.ServicioGetAsync<EntregaEntity>("api/Entrega/" + id);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;


        }
        #endregion

        #region Camion

        public async Task<IEnumerable<CamionEntity>> CamionGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<CamionEntity>>("api/Camion");
            return result;
        }

        public async Task<CamionEntity> CamionGetById(int id)
        {
            var result = await client.ServicioGetAsync<CamionEntity>("api/Camion/" + id);
            if (result.CodeError is not 0) throw new Exception(result.MsgError);
            return result;
        }

        #endregion

        #region Conductor

        public async Task<IEnumerable<ConductorEntity>> ConductorGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ConductorEntity>>("api/Conductor");
            return result;
        }

        public async Task<IEnumerable<ConductorEntity>> ConductorGetLista()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ConductorEntity>>("api/Conductor/Lista");
            return result;
        }

        public async Task<ConductorEntity> ConductorGetById(int id)
        {
            var result = await client.ServicioGetAsync<ConductorEntity>("api/Conductor/" + id);
            if (result.CodeError is not 0) throw new Exception(result.MsgError);
            return result;
        }

        #endregion

        #region Usuario

        public async Task<UsuariosEntity> UsuarioLogin(UsuariosEntity entity)
        {

            var result = await client.ServicioPostAsync<UsuariosEntity>("api/Usuarios/Login", entity);

            return result;
        }

        #endregion

    }
}
