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

    }
}
