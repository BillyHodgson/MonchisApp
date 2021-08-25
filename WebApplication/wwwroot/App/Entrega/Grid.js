"use strict";
var EntregaGrid;
(function (EntregaGrid) {
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar esta Entrega? ", "Eliminar", "warning", "#3085d6", "#d33")
            .then(function (result) {
            if (result.isConfirmed) {
                //animacion
                Loading.fire("Borrando..");
                App.AxiosProvider.EntregaEliminar(id).then(function (data) {
                    //cerrar animacion
                    Loading.close();
                    if (data.CodeError == 0) {
                        Toast.fire({ title: "Se elimino correctamente!", icon: "success" }).then(function () { return window.location.href = "Producto/Grid"; });
                    }
                    else {
                        Toast.fire({ title: data.MsgError, icon: "error" });
                    }
                });
            }
        });
    }
    EntregaGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(EntregaGrid || (EntregaGrid = {}));
//# sourceMappingURL=Grid.js.map