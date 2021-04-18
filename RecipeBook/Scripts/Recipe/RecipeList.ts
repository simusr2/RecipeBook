let _recipeTable: Tabulator;
const _recipeTableId: string = "recipe-table";
const _recipeTableSelector: string = "#" + _recipeTableId;
let _recipeTableGetUrl: string;
let _recipeUrl: string;

_recipeTable = createRecipeTable(_recipeTableSelector, _recipeTableGetUrl);
//_recipeTable.setData();

function createRecipeTable(selector: string, getUrl: string) {
    const columns: Tabulator.ColumnDefinition[] = [
        { title: "Nome", field: "recipeName" },
        { title: "Descrizione", field: "recipeDescription", formatter: "textarea" }
    ];

    const dblClick: Tabulator.RowEventCallback = function (e: UIEvent, row: Tabulator.RowComponent) {
        const id: string = row.getIndex();
        window.location.href = _recipeUrl + "?id=" + id;
    }

    const options: Tabulator.Options = {
        columns,
        virtualDomHoz: false,
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
