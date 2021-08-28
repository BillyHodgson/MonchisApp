"use strict";
var EntregaEdit;
(function (EntregaEdit) {
    var Entity = $("#AppEdit").data("entity");
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit",
            Entity: Entity,
            CantonLista: [],
            DistritoLista: [],
            CamionLista: [],
        },
        methods: {
            EntregaServicio: function (entity) {
                console.log(entity);
                if (entity.IdEntrega == null) {
                    return App.AxiosProvider.EntregaGuardar(entity);
                }
                else {
                    return App.AxiosProvider.EntregaActualizar(entity);
                }
            },
            OnChangeFechaEntrega: function () {
                var _this = this;
                App.AxiosProvider.CamionLista(this.Entity).then(function (data) {
                    console.log(data);
                    Loading.close();
                    _this.CamionLista = data;
                });
            },
            OnChangeProvincia: function () {
                var _this = this;
                Loading.fire("Cargando..");
                App.AxiosProvider.EntregaChangeProvincia(this.Entity).then(function (data) {
                    Loading.close();
                    _this.CantonLista = data;
                });
            },
            OnChangeCanton: function () {
                var _this = this;
                Loading.fire("Cargando..");
                App.AxiosProvider.EntregaChangeCanton(this.Entity).then(function (data) {
                    Loading.close();
                    _this.DistritoLista = data;
                });
            },
            Save: function () {
                if (BValidateData(this.Formulario)) {
                    Loading.fire("Guardando");
                    this.EntregaServicio(this.Entity).then(function (data) {
                        Loading.close();
                        if (data.CodeError == 0) {
                            Toast.fire({ title: "Se ha creado la Entrega!", icon: "success" })
                                .then(function () { return window.location.href = "Entrega/Grid"; });
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
            this.OnChangeProvincia();
            this.OnChangeCanton();
            this.OnChangeFechaEntrega();
        }
    });
    Formulario.$mount("#AppEdit");
})(EntregaEdit || (EntregaEdit = {}));
//# sourceMappingURL=Edit.js.map