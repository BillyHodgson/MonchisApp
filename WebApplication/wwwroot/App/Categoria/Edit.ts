namespace CategoriaEdit {
    var Entity = $("#AppEdit").data("entity");
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit",
            Entity: Entity,
        },
        methods: {
            CategoriaServicio(entity) {
                console.log(entity)
                if (entity.IdCategoria == null) {
                    return App.AxiosProvider.CategoriaGuardar(entity);
                } else {
                    return App.AxiosProvider.CategoriaActualizar(entity);
                }
            },
            Save() {
                if (BValidateData(this.Formulario)) {
                    Loading.fire("Guardando");
                    this.CategoriaServicio(this.Entity).then(data => {
                        Loading.close();
                        if (data.CodeError == 0) {
                            Toast.fire({ title: "Se guardo sastifactoriamente!", icon: "success" })
                                .then(() => window.location.href = "Categoria/Grid")
                        } else {
                            Toast.fire({ title: data.MsgError, icon: "error" });
                        }
                    }).catch(c => console.log(c));
                } else {
                    Toast.fire({ title: "Por favor complete los campos requeridos!", icon: "error" });
                }
            }
        },
        mounted() {
            CreateValidator(this.Formulario);
        }
    });

    Formulario.$mount("#AppEdit")
}