"use strict";

function myFunction() {
    var x = document.getElementById("myTopnav");
    if (x.className === "topnav") {
        x.className += " responsive";
    } else {
        x.className = "topnav";
    }
}

function active(id) {
    
    var items = document.querySelectorAll(".active");
    for (var i = 0, max = items.length; i < max; i++) {
        items[i].classList.remove("active");
    }

    var active = document.getElementById(id);
    active.classList.add("active");
    
}

function addClass(id, nameClass) {
    document.getElementById(id).classList.add(nameClass);
}

