jQuery(document).ready(function ($) {
    $('#ReservationVOL').on('show.bs.modal', function (e) {
        var bookId = $(e.relatedTarget).data('id');
        $.ajax({
            type: 'GET',
            crossDomain: true,
            crossOrigin: true,
            url: 'http://localhost:5000/api/Vol/' + bookId,
            headers: { "Authorization": "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.e30.atWrWc4h8upVfiER1UMyB6PPQ2V82iF9QGzeP-TrmOM"},
            datatype: 'jsonp',
            success: function (data) {
                var intI = 0;
                    var Valeur1 = document.getElementById('Compagnie');
                Valeur1.innerText = data.compagnie;
                var Valeur2 = document.getElementById('Date');
                var date = new Date(data.dateVol);
                Valeur2.innerText = date.toLocaleString() ;
                $.each(data.listePlaces, function (i, item) {
                    var maTable = document.getElementById('Table_VOL');
                    var nouvelleLigne = maTable.insertRow(-1);

                    var Premiere = nouvelleLigne.insertCell(0);
                    var newText1 = document.createTextNode(item.nom);
                    Premiere.appendChild(newText1);

                    var deuxieme = nouvelleLigne.insertCell(1);
                    var newText2 = document.createTextNode(item.prix + " €");
                    deuxieme.appendChild(newText2);

                    var troisieme = nouvelleLigne.insertCell(2);
                    var newButton = document.createElement('button');
                    newButton.setAttribute('id', 'user_' + item.id);
                    newButton.setAttribute('onclick', 'Reserver("VOL",' + data.id + ',' + item.nom + ',this)');
                    newButton.setAttribute('type', 'button');
                    if (item.etat == false) {
                        newButton.setAttribute('class', 'btn btn-success');
                        newButton.innerHTML = "+";
                    } else {
                        newButton.setAttribute('class', 'btn btn-danger');
                        newButton.innerHTML = "-";
                    }
                    troisieme.appendChild(newButton);
                    if (item.etat == false) {
                        intI++;
                    }
                });

                var Valeur3 = document.getElementById('NbrPlace');
                Valeur3.innerText = intI + " / " + data.listePlaces.length;
            }
        });
    });
    $('#ReservationVOL').on('hide.bs.modal', function (e) {
        var nombrevol = 0;
        var intI = 0;
        $.ajax({
            type: 'GET',
            crossDomain: true,
            crossOrigin: true,
            url: 'http://localhost:5000/api/Vol/GetAllVol',
            headers: { "Authorization": "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.e30.atWrWc4h8upVfiER1UMyB6PPQ2V82iF9QGzeP-TrmOM" },
            datatype: 'jsonp',
            success: function (data) {
                $.each(data, function (i, item) {
                    $.each(item.listePlaces, function (i, itemFinale) { if (itemFinale.etat == false) { intI++; } });
                    for (let x = 1; x <= data.length; x++) { document.getElementById("NombreDePlaceDispo_" + (i + 1)).innerHTML = intI + " / " + item.listePlaces.length; }
                    intI = 0;
                    nombrevol = item.listePlaces.length;
                });
                for (let pas = 0; pas < nombrevol; pas++) { document.getElementById("Table_VOL").deleteRow(1); }
            }
        });

    });

    $('#ReservationHOTEL').on('show.bs.modal', function (e) {
        var bookId = $(e.relatedTarget).data('id');
        $.ajax({
            type: 'GET',
            crossDomain: true,
            crossOrigin: true,
            url: 'http://localhost:5000/api/Hotel/' + bookId,
            headers: { "Authorization": "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.e30.atWrWc4h8upVfiER1UMyB6PPQ2V82iF9QGzeP-TrmOM" },
            datatype: 'jsonp',
            success: function (data) {
                var intI = 0;
                var Valeur1 = document.getElementById('NomHotel');
                Valeur1.innerText = data.name;
                $.each(data.rooms, function (i, item) {
                    var maTable = document.getElementById('Table_HOTEL');
                    var nouvelleLigne = maTable.insertRow(-1);
                    var Premiere = nouvelleLigne.insertCell(0);
                    var newText1 = document.createTextNode(item.roomNumber);
                    Premiere.appendChild(newText1);
                    var deuxieme = nouvelleLigne.insertCell(1);
                    var categorieutil = "";
                    if (item.category == 0) {
                        categorieutil = "Single";
                    } else if (item.category == 1) {
                        categorieutil = "Double";
                    } else if (item.category == 2) {
                        categorieutil = "Suite";
                    }
                    var newText2 = document.createTextNode(categorieutil);
                    deuxieme.appendChild(newText2);
                    var troisieme = nouvelleLigne.insertCell(2);
                    var newText3 = document.createTextNode(item.price + " €");
                    troisieme.appendChild(newText3);
                    var quatrieme = nouvelleLigne.insertCell(3);
                    var newButton = document.createElement('button');
                    newButton.setAttribute('id', 'use_' + item.roomNumber);
                    newButton.setAttribute('onclick', 'Reserver("HOTEL","' + data.name + '",' + item.roomNumber + ',this)');
                    newButton.setAttribute('type', 'button');
                    if (item.available == true) {
                        newButton.setAttribute('class', 'btn btn-success');
                        newButton.innerHTML = "+";
                    } else {
                        newButton.setAttribute('class', 'btn btn-danger');
                        newButton.innerHTML = "-";
                    }
                    quatrieme.appendChild(newButton);
                    if (item.available == true) {
                        intI++;
                    }
                });

                var Valeur3 = document.getElementById('NbrPlaceHotel');
                Valeur3.innerText = intI + " / " + data.rooms.length;
            }
        });
    });
    $('#ReservationHOTEL').on('hide.bs.modal', function (e) {
        var nombretotal = 0;
        $.ajax({
            type: 'GET',
            crossDomain: true,
            crossOrigin: true,
            url: 'http://localhost:5000/api/Hotel/GetAllHotel',
            headers: { "Authorization": "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.e30.atWrWc4h8upVfiER1UMyB6PPQ2V82iF9QGzeP-TrmOM" },
            datatype: 'jsonp',
            success: function (data) {
                $.each(data, function (i, item) {
                    var intI = 0;
                    $.each(item.rooms, function (i, itemFinale) { if (itemFinale.available == true) { intI++; } });
                    for (let x = 1; x <= data.length; x++) { document.getElementById("NombreChambre_" + (i + 1)).innerHTML = intI + " / " + item.rooms.length; }
                    intI = 0;
                    nombretotal = item.rooms.length;
                });
                for (let pas = 0; pas < nombretotal; pas++) { document.getElementById("Table_HOTEL").deleteRow(1); }
            }
        });
    });
});

function Reserver(type, id, nom, button) {
    if (type == "VOL") {
        $.ajax({
            type: 'PUT',
            crossDomain: true,
            crossOrigin: true,
            url: 'http://localhost:5000/api/Vol/' + id + '/' + nom,
            headers: { "Authorization": "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.e30.atWrWc4h8upVfiER1UMyB6PPQ2V82iF9QGzeP-TrmOM" },
            datatype: 'jsonp',
            success: function () {
                var NbrPlace = document.getElementById('NbrPlace');
                var NouveauNombre = NbrPlace.innerText.split(' ');
                var Newvalue = 0;
                if (button.classList.contains("btn-success")) {
                    button.innerHTML = "-";
                    Newvalue = Number(NouveauNombre[0]) - 1;
                    NbrPlace.innerText = Newvalue + " / " + NouveauNombre[2];
                    button.setAttribute('class', 'btn btn-danger')
                }
                else {
                    button.innerHTML = "+";
                    Newvalue = Number(NouveauNombre[0]) + 1;
                    NbrPlace.innerText = Newvalue + " / " + NouveauNombre[2];
                    button.setAttribute('class', 'btn btn-success')
                }
            }
        });
    } else {
        $.ajax({
            type: 'PUT',
            crossDomain: true,
            crossOrigin: true,
            url: 'http://localhost:5000/api/Hotel/' + id + '/' + nom,
            headers: { "Authorization": "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.e30.atWrWc4h8upVfiER1UMyB6PPQ2V82iF9QGzeP-TrmOM" },
            datatype: 'jsonp',
            success: function () {
                var NbrPlace = document.getElementById('NbrPlaceHotel');
                var NouveauNombre = NbrPlace.innerText.split(' ');
                var Newvalue = 0;
                if (button.classList.contains("btn-success")) {
                    button.innerHTML = "-";
                    Newvalue = Number(NouveauNombre[0]) - 1;
                    NbrPlace.innerText = Newvalue + " / " + NouveauNombre[2];
                    button.setAttribute('class', 'btn btn-danger')
                }
                else {
                    button.innerHTML = "+";
                    Newvalue = Number(NouveauNombre[0]) + 1;
                    NbrPlace.innerText = Newvalue + " / " + NouveauNombre[2];
                    button.setAttribute('class', 'btn btn-success')
                }
            }
        });
    }
}