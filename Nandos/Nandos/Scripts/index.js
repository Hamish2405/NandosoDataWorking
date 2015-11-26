// This event triggers on page load
document.addEventListener("DOMContentLoaded", function () {
    loadSpecials();
});

function loadSpecials() {

    //reference to div where data will be stored
    var specialsWall = document.getElementById("specialsWall");

    SpecialModule.getSpecials(function (specialsList) {
        setupSpecialsWall(specialsList);
    });

    //This is the callback for when the data comes into the module
    function setupSpecialsWall(specials) {
        console.log(specials.length);


        for (var i = 0; i < specials.length ; i++) {
            //Create h1
            var row = document.createElement('div');

            //add data 
            var namehead = document.createElement('h1');
            namehead.innerHTML = specials[i].Name;
            row.appendChild(namehead);

            var pricehead = document.createElement('h2');
            pricehead.innerHTML = specials[i].Price;
            row.appendChild(pricehead);

            var dscriphead = document.createElement('p');
            dscriphead.innerHTML = specials[i].Description;
            dscriphead.setAttribute("class", "dText");
            row.appendChild(dscriphead);

            var imghead = document.createElement('IMG');
            imghead.setAttribute("src", specials[i].Picture);
            imghead.setAttribute("class", "img-responsive");
            row.appendChild(imghead);

            var pageheader = document.createElement('p');
            pageheader.setAttribute("class", "page-header");
            row.appendChild(pageheader);

            specialsWall.appendChild(row);
        }
    }
}