"use strict";
var CategoriaEdit;
(function (CategoriaEdit) {
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit"
        },
        mounted: function () {
            CreateValidator(this.Formulario);
        }
    });
    Formulario.$mount("#AppEdit");
})(CategoriaEdit || (CategoriaEdit = {}));
//# sourceMappingURL=Edit.js.map