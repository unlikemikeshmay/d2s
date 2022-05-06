// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded",function(){
    var date = new Date();
    date.getFullYear();
    document.getElementById("footerDate").innerHTML = date.toString();
})