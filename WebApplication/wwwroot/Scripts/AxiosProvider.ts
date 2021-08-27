
namespace App.AxiosProvider   {

    export const CategoriaEliminar = (id) => ServiceApi.delete<DBEntity>("api/Categoria/" + id).then(({ data }) => data);
    export const CategoriaGuardar = (entity) => ServiceApi.post<DBEntity>("api/Categoria", entity).then(({ data }) => data);
    export const CategoriaActualizar = (entity) => ServiceApi.put<DBEntity>("api/Categoria", entity).then(({ data }) => data);

    export const ProductosEliminar = (id) => ServiceApi.delete<DBEntity>("api/Productos/" + id).then(({ data }) => data);
    export const ProductosGuardar = (entity) => ServiceApi.post<DBEntity>("api/Productos", entity).then(({ data }) => data);
    export const ProductosActualizar = (entity) => ServiceApi.put<DBEntity>("api/Productos", entity).then(({ data }) => data);

    export const ClienteEliminar = (id) => ServiceApi.delete<DBEntity>("api/Cliente/" + id).then(({ data }) => data);
    export const ClienteGuardar = (entity) => ServiceApi.post<DBEntity>("api/Cliente", entity).then(({ data }) => data);
    export const ClienteActualizar = (entity) => ServiceApi.put<DBEntity>("api/Cliente", entity).then(({ data }) => data);

    export const PedidoEliminar = (id) => ServiceApi.delete<DBEntity>("api/Pedido/" + id).then(({ data }) => data);
    export const PedidoGuardar = (entity) => ServiceApi.post<DBEntity>("api/Pedido", entity).then(({ data }) => data);
    export const PedidoActualizar = (entity) => ServiceApi.put<DBEntity>("api/Pedido", entity).then(({ data }) => data);
    export const PedidoChangeProducto = (entity) => axios.post<any[]>("Pedido/Edit?handler=ChangeProducto", entity).then(({ data }) => data);

    export const EntregaEliminar = (id) => ServiceApi.delete<DBEntity>("api/Entrega/" + id).then(({ data }) => data);
    export const EntregaGuardar = (entity) => ServiceApi.post<DBEntity>("api/Entrega", entity).then(({ data }) => data);
    export const EntregaActualizar = (entity) => ServiceApi.put<DBEntity>("api/Entrega", entity).then(({ data }) => data);
    export const EntregaChangeProvincia = (entity) => axios.post<any[]>("Entrega/Edit?handler=ChangeProvincia", entity).then(({ data }) => data);
    export const EntregaChangeCanton = (entity) => axios.post<any[]>("Entrega/Edit?handler=ChangeCanton", entity).then(({ data }) => data);

    export const CamionEliminar = (id) => ServiceApi.delete<DBEntity>("api/Camion/" + id).then(({ data }) => data);
    export const CamionGuardar = (entity) => ServiceApi.post<DBEntity>("api/Camion", entity).then(({ data }) => data);
    export const CamionActualizar = (entity) => ServiceApi.put<DBEntity>("api/Camion", entity).then(({ data }) => data);

    export const ConductorEliminar = (id) => ServiceApi.delete<DBEntity>("api/Conductor/" + id).then(({ data }) => data);
    export const ConductorGuardar = (entity) => ServiceApi.post<DBEntity>("api/Conductor", entity).then(({ data }) => data);
    export const ConductorActualizar = (entity) => ServiceApi.put<DBEntity>("api/Conductor", entity).then(({ data }) => data);
}




