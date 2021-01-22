export default function FoodTypes(foodTypes) {
    return `
    <h1>Welcome to Dan & Bern's CookBook!</h1>
    <p>Check out this prototype of our cookbook that al eaters can enjoy. This site is currently under construction, some features may not work due to an upgrade session.</p>
    ${foodTypes.map(foodType => {
        return `
        <div class="foodtype__list">
        <ol> <a class ="foodType__category" id="${foodType.id}" href="#"> ${foodType.foodCategory} <img class="foodTypeImage" src="images/${foodType.foodImage}" alt="image"> </a> </ol>
            </div>
            `
    }).join("")}
        `
}