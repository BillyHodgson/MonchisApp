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
    })(AxiosProvider = App.AxiosProvider || (App.AxiosProvider = {}));
})(App || (App = {}));
//# sourceMappingURL=AxiosProvider.js.map