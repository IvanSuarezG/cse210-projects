/* W02-Task - Profile Home Page */

/* Step 1 - Setup type tasks - no code required */

/* Step 2 - Variables */
let fullName = 'Ivan Antonio Suarez Gaitan';
const currentYear = 2024;
let profilePicture = 'images/Picture.png'




/* Step 3 - Element Variables */
const nameElement = document.getElementById('name');
const foodElement = document.getElementById('food');
const yearElement = document.querySelector('#year');
const imageElement = document.querySelector('picture');




/* Step 4 - Adding Content */

nameElement.innerHTML = `<strong>${fullName}</strong>`;
yearElement.innerHTML = `<strong>${currentYear}</strong>`;
imageElement.setAttribute('scr',profilePicture);
imageElement.setAttribute('alt',profilePicture);




/* Step 5 - Array */

let food =['lasagna', 'corn cake', 'Milanese', 'ravioli', 'strawberries']
foodElement.innerHTML = `<strong>${food}</strong>`;
let new_food = 'Melon';
food.push(new_food);
foodElement.innerHTML += `<br>${food}`;
food.shift();
foodElement.innerHTML += `<br>${food}`;
food.pop();
foodElement.innerHTML += `<br>${food}`;




