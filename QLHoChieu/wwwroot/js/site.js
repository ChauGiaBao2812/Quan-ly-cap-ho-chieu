// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function callMyApi() {
    fetch('/api/myendpoint', {
        method: 'POST',  // or GET, PUT, DELETE depending on your API
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ key1: 'value1', key2: 'value2' }) // for POST
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not OK');
            }
            return response.json();
        })
        .then(data => {
            console.log('Success:', data);
            // do something with the returned data
        })
        .catch(error => {
            console.error('Error:', error);
        });
}