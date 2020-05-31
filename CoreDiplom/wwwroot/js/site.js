// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var countDownDate = new Date("Jul 1, 2020 00:00:00").getTime();

// Update the count down every 1 second
var x = setInterval(function () {

    // Get today's date and time
    var now = new Date().getTime();

    // Find the distance between now and the count down date
    var distance = countDownDate - now;

    // Time calculations for days, hours, minutes and seconds
    var days = Math.floor(distance / (1000 * 60 * 60 * 24));
    var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
    var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
    var seconds = Math.floor((distance % (1000 * 60)) / 1000);

    // Output the result in an element with id="demo"
    let timersGoods = document.getElementsByClassName("timerGood");

    for (let i = 0; i < timersGoods.length; i++) {
        let p = timersGoods.item(i);
        p.innerHTML = days + "d " + hours + "h "
            + minutes + "m " + seconds + "s ";
        p.style.color = "#ea5455";
    }


    // If the count down is over, write some text 
    if (distance < 0) {
        countDownDate.days = Date.days + 1;

    }
}, 1000);