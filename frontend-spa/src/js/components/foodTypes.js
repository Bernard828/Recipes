
export default function FoodTypes(foodTypes) {
    return `
    <h1><u>Food Types</h1></u>
     <class="foodtype__list">
        ${foodTypes.map(foodType => {
        return `
        <div id="recipes"
                <ul>
                <article>
                   <a class ="foodType__category" id="${foodType.id}" href="#">
                    <h2 >${foodType.foodCategory}</h2>
                    <p><img src="images/${foodType.foodImage}" alt="image"></p>          
                    </a>
                    </article>
                </ul>
        </div>
        `
    }).join("")}
        `
}