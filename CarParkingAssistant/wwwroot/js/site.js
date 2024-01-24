// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener('DOMContentLoaded', function () {
    var header = document.querySelector('.site-header');
    var headerHeight = header.offsetHeight;

    // Change background color on scroll
    window.addEventListener('scroll', function () {
        if (window.scrollY > headerHeight / 3) {
            header.classList.add('scrolled');

        } else {
            header.classList.remove('scrolled');
        }
    });
});

