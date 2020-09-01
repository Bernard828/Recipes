
export default function Home() {
    return `
    <h1><u> Official Home Page</h1></u>
    <h1>Welcome to Our CookBook!</h1>
    <p>Click any of the navigation menus at the top of the page to get started.</p>
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