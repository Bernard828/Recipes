export default function FoodType(foodType) {
    return `
        <u><h1 class="foodType__category">${foodType.foodCategory}</h1></u>
            ${foodType.recipes.map(recipe => {
                return `
                <ul>
                <a href="#">
                    <h2> <span class="recipeName"> ${recipe.recipeName} </span>  <br> <img src="images/${recipe.recipeImage}" alt="image"> </br> </h2>
                </a>
                <div class="recipeInfo">
                    <p>Cook Time: ${recipe.cookTime}</p>
                    <p>Ingredients: ${recipe.ingredients}</p>
                </div>
                <button class='recipe-item__delete'>Delete</button>
                <input class='foodType__name' type="hidden" id="${recipe.recipeId}" value='${recipe.recipeName}'>
                </ul>
                `
            }).join("")}

    `
}