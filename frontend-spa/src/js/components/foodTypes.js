export default function FoodTypes(foodTypes) {
    return `
    <h1><u>Food Types</h1></u>
     <class="foodtype__list">
        ${foodTypes.map(foodType => {
        return `
        <div id="recipes"
                <ul><article>
                    <h2 class ="foodType__category" id="${foodType.foodTypeId}">${foodType.foodCategory}</h2>
                    <img src="images/${foodType.recipeImage}" alt="image" style="width: 100px; height: 100px">
                    <p><img src="images/${foodType.image}" alt="image"></p>                   
                </ul></article>
        </div>
        `
    }).join("")}
        `
}