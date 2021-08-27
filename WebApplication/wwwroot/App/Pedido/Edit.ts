namespace PedidoEdit {

    var Entity = $("#AppEdit").data("entity");

    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit",
            Entity: Entity,

        },

        methods: {
            async OnChangeProducto() {
                Loading.fire("Cargando..");
                await App.AxiosProvider.PedidoChangeProducto(this.Entity).then(data => {
                    Loading.close();
                    this.Entity.Producto = data;
                });
                this.Calcular();
            },

            OnChangeCantidad() {               
                this.Calcular();
                if (this.Entity.Cantidad < 1) {
                    this.Entity.Cantidad = 1;
                    Toast.fire({ title: "No es posible comprar menos de una unidad", icon: "error" });
                }
                if (this.Entity.Cantidad > this.Entity.Producto.Cantidad) {
                    this.Entity.Cantidad = this.Entity.Producto.Cantidad
                    Toast.fire({ title: "No es posible comprar mas de lo disponible en stock", icon: "error" });
                }
            },

             OnChangeCostoEnvio() {
                 this.Calcular();
            },

            Calcular() {
                this.Entity.SubTotal = this.Entity.Cantidad * this.Entity.Producto.Precio + this.Entity.Envio
                this.Entity.Impuesto = ((this.Entity.Cantidad * this.Entity.Producto.Precio + this.Entity.Envio) * 0.13).toFixed(2)
                this.Entity.Total = ((this.Entity.Cantidad * this.Entity.Producto.Precio + this.Entity.Envio) * 1.13).toFixed(2)
            },

            CompraServicio(entity) {

                if (this.Entity.IdPedido == null) {
                    console.log("aaa")
                    return App.AxiosProvider.PedidoGuardar(entity);
                } else {
                    console.log("bbb")
                    return App.AxiosProvider.PedidoActualizar(entity);
                }
            },
            consultarPrecioUnitario() {
                Loading.fire("Cargando..");

                App.AxiosProvider.PedidoChangeProducto(this.Entity).then(data => {
                    Loading.close();
    
                });
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

        created() {
            console.log(this.Entity)
            this.OnChangeProducto()
        }

    });

    Formulario.$mount("#AppEdit")
}