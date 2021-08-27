"use strict";
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
var PedidoEdit;
(function (PedidoEdit) {
    var Entity = $("#AppEdit").data("entity");
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit",
            Entity: Entity,
        },
        methods: {
            OnChangeProducto: function () {
                return __awaiter(this, void 0, void 0, function () {
                    var _this = this;
                    return __generator(this, function (_a) {
                        switch (_a.label) {
                            case 0:
                                Loading.fire("Cargando..");
                                return [4 /*yield*/, App.AxiosProvider.PedidoChangeProducto(this.Entity).then(function (data) {
                                        Loading.close();
                                        _this.Entity.Producto = data;
                                    })];
                            case 1:
                                _a.sent();
                                this.Calcular();
                                return [2 /*return*/];
                        }
                    });
                });
            },
            OnChangeCantidad: function () {
                this.Calcular();
                if (this.Entity.Cantidad < 1) {
                    this.Entity.Cantidad = 1;
                    Toast.fire({ title: "No es posible comprar menos de una unidad", icon: "error" });
                }
                if (this.Entity.Cantidad > this.Entity.Producto.Cantidad) {
                    this.Entity.Cantidad = this.Entity.Producto.Cantidad;
                    Toast.fire({ title: "No es posible comprar mas de lo disponible en stock", icon: "error" });
                }
            },
            OnChangeCostoEnvio: function () {
                this.Calcular();
            },
            Calcular: function () {
                this.Entity.SubTotal = this.Entity.Cantidad * this.Entity.Producto.Precio + this.Entity.Envio;
                this.Entity.Impuesto = ((this.Entity.Cantidad * this.Entity.Producto.Precio + this.Entity.Envio) * 0.13).toFixed(2);
                this.Entity.Total = ((this.Entity.Cantidad * this.Entity.Producto.Precio + this.Entity.Envio) * 1.13).toFixed(2);
            },
            CompraServicio: function (entity) {
                if (this.Entity.IdPedido == null) {
                    console.log("aaa");
                    return App.AxiosProvider.PedidoGuardar(entity);
                }
                else {
                    console.log("bbb");
                    return App.AxiosProvider.PedidoActualizar(entity);
                }
            },
            consultarPrecioUnitario: function () {
                Loading.fire("Cargando..");
                App.AxiosProvider.PedidoChangeProducto(this.Entity).then(function (data) {
                    Loading.close();
                });
            },
            Save: function () {
                if (BValidateData(this.Formulario)) {
                    Loading.fire("Guardando");
                    this.CompraServicio(this.Entity).then(function (data) {
                        Loading.close();
                        if (data.CodeError == 0) {
                            Toast.fire({ title: "Se ha realizado el pedido!", icon: "success" })
                                .then(function () { return window.location.href = "Pedido/Grid"; });
                        }
                        else {
                            Toast.fire({ title: data.MsgError, icon: "error" });
                        }
                    }).catch(function (c) { return console.log(c); });
                }
                else {
                    Toast.fire({ title: "Por favor complete los campos requeridos!", icon: "error" });
                }
            }
        },
        mounted: function () {
            CreateValidator(this.Formulario);
        },
        created: function () {
            console.log(this.Entity);
            this.OnChangeProducto();
        }
    });
    Formulario.$mount("#AppEdit");
})(PedidoEdit || (PedidoEdit = {}));
//# sourceMappingURL=Edit.js.map