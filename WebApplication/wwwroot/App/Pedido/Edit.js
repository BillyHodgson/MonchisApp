"use strict";
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
                var _this = this;
                Loading.fire("Cargando..");
                console.log(this.Entity);
                App.AxiosProvider.PedidoChangeProducto(this.Entity).then(function (data) {
                    Loading.close();
                    _this.Entity.Producto = data;
                });
            },
            CalculoMontoTotalFn: function () {
                var total = ((this.Entity.Impuesto / 100) * this.Entity.Monto) + this.Entity.Monto;
                return total;
            },
            CompraServicio: function (entity) {
                if (entity.IdCompra == null) {
                    return App.AxiosProvider.PedidoGuardar(entity);
                }
                else {
                    return App.AxiosProvider.PedidoActualizar(entity);
                }
            },
            consultarPrecioUnitario: function () {
                Loading.fire("Cargando..");
                App.AxiosProvider.PedidoChangeProducto(this.Entity).then(function (data) {
                    Loading.close();
                    console.log(data);
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
        computed: {
            CalculoMontoTotalCP: function () {
                var total = ((this.Entity.Impuesto / 100) * this.Entity.SubTotal) + this.Entity.SubTotal;
                return total;
            }
        }
    });
    Formulario.$mount("#AppEdit");
})(PedidoEdit || (PedidoEdit = {}));
//# sourceMappingURL=Edit.js.map