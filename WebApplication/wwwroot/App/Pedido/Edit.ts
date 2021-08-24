namespace PedidoEdit {

    var Entity = $("#AppEdit").data("entity");

    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit",
            Entity: Entity,

        },

        methods: {

            CalculoMontoTotalFn() {
                var total = ((this.Entity.Impuesto / 100) * this.Entity.Monto) + this.Entity.Monto;
                return total;
            },
            CompraServicio(entity) {

                if (entity.IdCompra == null) {
                    return App.AxiosProvider.PedidoGuardar(entity);
                } else {
                    return App.AxiosProvider.PedidoActualizar(entity);
                }
            },
            Save() {

                if (BValidateData(this.Formulario)) {

                    Loading.fire("Guardando");
                    this.CompraServicio(this.Entity).then(data => {

                        Loading.close();

                        if (data.CodeError == 0) {
                            Toast.fire({ title: "Se ha realizado el pedido!", icon: "success" })
                                .then(() => window.location.href = "Pedido/Grid")
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

        computed: {
            CalculoMontoTotalCP: function (): number {
                var total = ((this.Entity.Impuesto / 100) * this.Entity.SubTotal) + this.Entity.SubTotal;
                return total;
            }
        }

    });

    Formulario.$mount("#AppEdit")
}