export default function Recipes(recipes){
    return `
        <h1><u>Recipes</h1></u>
        <h2>Scroll down to add a new receipe or edit/delete an existing one</h2>
            ${recipes.map(recipe => {
                return `
                <article id="recipes">
                    <h2 class='recipe__name'>${recipe.recipeName}</h2>
                    <img class="recipe__image" src="images/${recipe.recipeImage}" alt="image" style="width: 100px; height: 100px">
                <div>
                    <p class='recipe__cookTime'> Cook Time: ${recipe.cookTime} </p>
                    <p class='recipe__ingredients'>Ingredients: ${recipe.ingredients} </p>
                </div>
                <button class='recipe-item__edit'>Edit</button>
                <button class='recipe-item__delete'>Delete</button>
                <h4 class='recipe__foodCategory' href="#"> ${recipe.foodType.foodCategory} </h4>
                <input class='recipe-item__id' type="hidden" value='${recipe.recipeId}'><br><br>
                </article>
        
                `
            }).join("")}
            <section class="create-recipe">
            <button class="create-recipe__button">Add Recipe</button>
            </section>
            </section>
    `;
}