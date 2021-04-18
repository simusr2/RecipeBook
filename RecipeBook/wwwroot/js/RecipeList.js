var _recipeTable;
var _recipeTableId = "recipe-table";
var _recipeTableSelector = "#" + _recipeTableId;
var _recipeTableGetUrl;
var _recipeUrl;
_recipeTable = createRecipeTable(_recipeTableSelector, _recipeTableGetUrl);
//_recipeTable.setData();
function createRecipeTable(selector, getUrl) {
    var columns = [
        { title: "Nome", field: "recipeName" },
        { title: "Descrizione", field: "recipeDescription", formatter: "textarea" }
    ];
    var dblClick = function (e, row) {
        var id = row.getIndex();
        window.location.href = _recipeUrl + "?id=" + id;
    };
    var options = {
        columns: columns,
        layout: "fitColumns",
        ajaxURL: getUrl,
        index: "recipeId",
        rowDblClick: dblClick,
        rowDblTap: dblClick
    };
    return new Tabulator(selector, options);
}
function openNewRecipe() {
    window.location.href = _recipeUrl;
}
