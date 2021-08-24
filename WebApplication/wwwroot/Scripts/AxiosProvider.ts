
namespace App.AxiosProvider   {

    export const CategoriaEliminar = (id) => ServiceApi.delete<DBEntity>("api/Categoria/" + id).then(({ data }) => data);
    export const CategoriaGuardar = (entity) => ServiceApi.post<DBEntity>("api/Categoria", entity).then(({ data }) => data);
    export const CategoriaActualizar = (entity) => ServiceApi.put<DBEntity>("api/Categoria", entity).then(({ data }) => data);

    export const ProductosEliminar = (id) => ServiceApi.delete<DBEntity>("api/Productos/" + id).then(({ data }) => data);
    export const ProductosGuardar = (entity) => ServiceApi.post<DBEntity>("api/Productos", entity).then(({ data }) => data);
    export const ProductosActualizar = (entity) => ServiceApi.put<DBEntity>("api/Productos", entity).then(({ data }) => data);

    export const PedidoEliminar = (id) => ServiceApi.delete<DBEntity>("api/Pedido/" + id).then(({ data }) => data);
    export const PedidoGuardar = (entity) => ServiceApi.post<DBEntity>("api/Pedido", entity).then(({ data }) => data);
    export const PedidoActualizar = (entity) => ServiceApi.put<DBEntity>("api/Pedido", entity).then(({ data }) => data);

}




