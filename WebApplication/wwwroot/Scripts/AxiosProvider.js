"use strict";
var App;
(function (App) {
    var AxiosProvider;
    (function (AxiosProvider) {
        AxiosProvider.CategoriaEliminar = function (id) { return ServiceApi.delete("api/Categoria/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CategoriaGuardar = function (entity) { return ServiceApi.post("api/Categoria", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CategoriaActualizar = function (entity) { return ServiceApi.put("api/Categoria", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ProductosEliminar = function (id) { return ServiceApi.delete("api/Productos/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ProductosGuardar = function (entity) { return ServiceApi.post("api/Productos", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ProductosActualizar = function (entity) { return ServiceApi.put("api/Productos", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ClienteEliminar = function (id) { return ServiceApi.delete("api/Cliente/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ClienteGuardar = function (entity) { return ServiceApi.post("api/Cliente", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ClienteActualizar = function (entity) { return ServiceApi.put("api/Cliente", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.PedidoEliminar = function (id) { return ServiceApi.delete("api/Pedido/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.PedidoGuardar = function (entity) { return ServiceApi.post("api/Pedido", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.PedidoActualizar = function (entity) { return ServiceApi.put("api/Pedido", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.PedidoChangeProducto = function (entity) { return axios.post("Pedido/Edit?handler=ChangeProducto", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.EntregaEliminar = function (id) { return ServiceApi.delete("api/Entrega/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.EntregaGuardar = function (entity) { return ServiceApi.post("api/Entrega", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.EntregaActualizar = function (entity) { return ServiceApi.put("api/Entrega", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.EntregaChangeProvincia = function (entity) { return axios.post("Entrega/Edit?handler=ChangeProvincia", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.EntregaChangeCanton = function (entity) { return axios.post("Entrega/Edit?handler=ChangeCanton", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CamionLista = function (entity) { return axios.post("Entrega/Edit?handler=GetListaCamiones", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CamionEliminar = function (id) { return ServiceApi.delete("api/Camion/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CamionGuardar = function (entity) { return ServiceApi.post("api/Camion", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CamionActualizar = function (entity) { return ServiceApi.put("api/Camion", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ConductorEliminar = function (id) { return ServiceApi.delete("api/Conductor/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ConductorGuardar = function (entity) { return ServiceApi.post("api/Conductor", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ConductorActualizar = function (entity) { return ServiceApi.put("api/Conductor", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
    })(AxiosProvider = App.AxiosProvider || (App.AxiosProvider = {}));
})(App || (App = {}));
//# sourceMappingURL=AxiosProvider.js.map