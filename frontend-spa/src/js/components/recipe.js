export default function FoodType(foodType){
    return `
        <h1>${recipe.name}</h1>
        <ol>
            ${fodType.recipes.map(recipe =>{
                return `
                <li>
                    <h4>Recipe Name: ${recipe.name}</h4>
                    <h4>Recipe Ingredients: ${recipe.ingredients}</h4>
                    <div class="recipe__image">
                    <img src="/images/DefaultFoodImage.jpg" alt='${foodType.foodType}' style="width: 100px; height: 100px;">
                    </div> 
                </li>
                `
            }).join("")}
        <ol>
    `
}