export default function FoodTypes(foodTypes) {
    return `
    <h1>Welcome to Dan & Bern's CookBook!</h1>
    <p>Check out this prototype of our cookbook that al eaters can enjoy. This site is currently under construction, some features may not work due to an upgrade session.</p>
     <class="foodtype__list">
        ${foodTypes.map(foodType => {
        return `
        <div id="recipes"
        <ul>
            <a class ="foodType__category" id="${foodType.id}" href="#">
                <article>
                    <h2>${foodType.foodCategory}</h2>
                    <img class="foodTypeImage" src="images/${foodType.foodImage}" alt="image">
                </article>
            </a>
        </ul>
        </div>
        `
    }).join("")}
        `
}