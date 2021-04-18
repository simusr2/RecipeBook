let _recipePostUrl: string;
let _recipeId: number;

function saveRecipe() {
    const form: HTMLFormElement = <HTMLFormElement>document.getElementById("recipeForm");
    const formData = new FormData(form);

    let body: any = {}; // TODO model
    formData.forEach((value, key) => body[key] = value);
    
    const request: XMLHttpRequest = new XMLHttpRequest();

    request.open(_recipeId == 0 ? "POST" : "PUT", _recipePostUrl + (_recipeId == 0 ? "" : "/" + _recipeId));
    request.setRequestHeader('Content-Type', 'application/json');
    request.send(JSON.stringify(body));
}

