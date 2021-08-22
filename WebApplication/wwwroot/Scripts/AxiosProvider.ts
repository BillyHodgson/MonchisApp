
namespace App.AxiosProvider   {

    export const CategoriaEliminar = (id) => ServiceApi.delete<DBEntity>("api/Categoria/" + id).then(({ data }) => data);
    export const CategoriaGuardar = (entity) => ServiceApi.post<DBEntity>("api/Categoria", entity).then(({ data }) => data);
    export const CategoriaActualizar = (entity) => ServiceApi.put<DBEntity>("api/Categoria", entity).then(({ data }) => data);

}




