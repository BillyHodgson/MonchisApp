"use strict";
var PedidoGrid;
(function (PedidoGrid) {
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar el registro? ", "Eliminar", "warning", "#3085d6", "#d33")
            .then(function (result) {
            if (result.isConfirmed) {
                //animacion
                Loading.fire("Borrando..");
                App.AxiosProvider.PedidoEliminar(id).then(function (data) {
                    //cerrar animacion
                    Loading.close();
                    if (data.CodeError == 0) {
                        Toast.fire({ title: "Se elimino correctamente!", icon: "success" }).then(function () { return window.location.href = "Pedido/Grid"; });
                    }
                    else {
                        Toast.fire({ title: data.MsgError, icon: "error" });
                    }
                });
            }
        });
    }
    PedidoGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(PedidoGrid || (PedidoGrid = {}));
//# sourceMappingURL=Grid.js.map