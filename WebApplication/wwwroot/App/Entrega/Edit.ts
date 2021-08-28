namespace EntregaEdit {


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


            EntregaServicio(entity) {
                console.log(entity);
                if (entity.IdEntrega == null) {
                    return App.AxiosProvider.EntregaGuardar(entity);
                } else {
                    return App.AxiosProvider.EntregaActualizar(entity);
                }
            },

            OnChangeFechaEntrega() {
                App.AxiosProvider.CamionLista(this.Entity).then(data => {
                    Loading.close();
                    this.CamionLista = data;
                });
            },

            OnChangeProvincia() {
                Loading.fire("Cargando..");
                App.AxiosProvider.EntregaChangeProvincia(this.Entity).then(data => {
                    Loading.close();
                    this.CantonLista = data;

                });

            },

            OnChangeCanton() {
                Loading.fire("Cargando..");

                App.AxiosProvider.EntregaChangeCanton(this.Entity).then(data => {
                    Loading.close();
                    this.DistritoLista = data;

                });


            },

            Save() {

                if (BValidateData(this.Formulario)) {

                    Loading.fire("Guardando");
                    this.EntregaServicio(this.Entity).then(data => {

                        Loading.close();

                        if (data.CodeError == 0) {
                            Toast.fire({ title: "Se ha creado la Entrega!", icon: "success" })
                                .then(() => window.location.href = "Entrega/Grid")
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

        },
        created() {
            this.OnChangeProvincia();
            this.OnChangeCanton();
            this.OnChangeFechaEntrega();
        }



    });

    Formulario.$mount("#AppEdit")
}