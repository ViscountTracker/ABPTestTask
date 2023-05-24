// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function handleButtonClick() {
    console.log("Button cliked!");
}

function makeApiRequest() {
    fetch('/api/data')
        .then(response => response.json())
        .then(data => {
            // Process the returned data
            console.log(data);
        })
        .catch(error => {
             // Handle any errors that occur during the API request
            console.error('Error!', error);
        });
}
document.addEventListener("DOMContentLoaded", function () {
    const button = document.getElementById("My button");
    button.addEventListener("click", handleButtonClick);

    makeApiRequest();
});