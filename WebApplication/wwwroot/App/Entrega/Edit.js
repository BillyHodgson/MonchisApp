"use strict";
var EntregaEdit;
(function (EntregaEdit) {
    var Entity = $("#AppEdit").data("entity");
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit",
            Entity: Entity,
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
    });
    Formulario.$mount("#AppEdit");
})(EntregaEdit || (EntregaEdit = {}));
//# sourceMappingURL=Edit.js.map