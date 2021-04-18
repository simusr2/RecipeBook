var _recipePostUrl;
var _recipeId;
function saveRecipe() {
    var form = document.getElementById("recipeForm");
    var formData = new FormData(form);
    var body = {}; // TODO model
    formData.forEach(function (value, key) { return body[key] = value; });
    var request = new XMLHttpRequest();
    request.open(_recipeId == 0 ? "POST" : "PUT", _recipePostUrl + (_recipeId == 0 ? "" : "/" + _recipeId));
    request.setRequestHeader('Content-Type', 'application/json');
    request.send(JSON.stringify(body));
}
