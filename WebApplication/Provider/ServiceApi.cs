using Entity;
using System;
using System.Collections.Generic;
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

    }
}
