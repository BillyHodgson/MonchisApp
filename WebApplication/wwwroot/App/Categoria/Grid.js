"use strict";
var CategoriaGrid;
(function (CategoriaGrid) {
    if (MensajeApp != "") {
        Toast.fire({
            icon: "success", title: MensajeApp
        });
    }
    function OnClickEliminar(id) {
        ComfirmAlert("Desea elimiar este registro?", "Eliminar", "warning", "#3085d6", "d33")
            .then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "Categoria/Grid?handler=Eliminar&id" + id;
            }
        });
    }
    CategoriaGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(CategoriaGrid || (CategoriaGrid = {}));
//# sourceMappingURL=Grid.js.map