"use strict";
var CategoriaGrid;
(function (CategoriaGrid) {
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar el registro? ", "Eliminar", "warning", "#3085d6", "#d33")
            .then(function (result) {
            if (result.isConfirmed) {
                //animacion
                Loading.fire("Borrando..");
                App.AxiosProvider.CategoriaEliminar(id).then(function (data) {
                    //cerrar animacion
                    //////////////////////////Loading.close();
                    if (data.CodeError == 0) {
                        Toast.fire({ title: "Se elimino correctamente!", icon: "success" }).then(function () { return window.location.href = "Categoria/Grid"; });
                    }
                    else {
                        Toast.fire({ title: data.MsgError, icon: "error" });
                    }
                });
            }
        });
    }
    CategoriaGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(CategoriaGrid || (CategoriaGrid = {}));
//# sourceMappingURL=Grid.js.map