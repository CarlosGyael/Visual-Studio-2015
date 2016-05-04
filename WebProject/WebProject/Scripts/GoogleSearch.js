var map;
var infowindow;
var MarkerColor = [null];
var pos;
var Notes = '<button onclick="myFunction2()">Notes</button>'
var Money = '<button onclick="myFunction()">Money</button>'

function initMap() {

    var infoWindow2 = new google.maps.InfoWindow({ map: map });

    var pyrmont = navigator.geolocation.getCurrentPosition(function (position) {
        pos = {
            lat: position.coords.latitude,
            lng: position.coords.longitude
        };
        var marker = new google.maps.Marker({
            position: pos,
            map: map,
            animation: google.maps.Animation.DROP,
            icon: 'https://www.dropbox.com/s/5fpobncigmw9o4c/blue.png?dl=1'
        });
        var contentString = 'You'
        var infowindow = new google.maps.InfoWindow({
            content: contentString,
            position: pos
        });
        marker.addListener('click', function () {
            infowindow.open(map, marker);
        });
    });

    var a = document.getElementById("Business");
    var strUser2 = a.options[a.selectedIndex].value;
    var e = document.getElementById("Radius");
    var strUser = e.options[e.selectedIndex].value;

    var pyrmont = navigator.geolocation.getCurrentPosition(function (position) {
        var pos = {
            lat: position.coords.latitude,
            lng: position.coords.longitude
        };

        map = new google.maps.Map(document.getElementById('map'), {
            center: pos,
            zoom: 15
        });

        infowindow = new google.maps.InfoWindow();
        var service = new google.maps.places.PlacesService(map);
        service.nearbySearch({
            location: pos,
            radius: [strUser],
            type: strUser2
        }, callback);
    })

}


function callback(results, status) {
    if (MarkerColor.length < results.length) {
        MarkerColor = results;
    }

    if (status === google.maps.places.PlacesServiceStatus.OK) {
        for (var i = 0; i < results.length; i++) {

            rand = Math.floor(Math.random() * (3 - 1 + 1) + 1);

            if (2 == rand) {
                var http = 'https://www.dropbox.com/s/nkrk81z790mowyi/Green.png?dl=1';
                createMarker(results[i], http, i);
            }
            else if (1 == rand) {
                var http = 'https://www.dropbox.com/s/4rhpbj2mzyjlzai/Yellow.png?dl=1';
                createMarker(results[i], http, i);
            }
            else if (3 == rand) {
                var http = 'https://www.dropbox.com/s/0mub96h09kjotie/google-maps-marker-for-residencelamontagne-hi.png?dl=1';
                createMarker(results[i], http, i);
            }
        }
    }
}

function createMarker(place, link, i) {
    j = 0;
    var placeLoc = place.geometry.location;

    var marker = new google.maps.Marker({
        map: map,
        icon: link,
        position: place.geometry.location
    });

    google.maps.event.addListener(marker, 'click', function () {
        infowindow.setContent(place.name + " (Double click for color change) " + Notes + " " + Money);
        infowindow.open(map, this);

    });
    google.maps.event.addListener(marker, 'dblclick', function () {
        if (j == 0) {
            if (link == 'https://www.dropbox.com/s/0mub96h09kjotie/google-maps-marker-for-residencelamontagne-hi.png?dl=1') {

            }
            else {
                link = CheckLink(link);
                createMarker(place, link, i);
            }
        }
        else {
            initMap();
        }
    });
}
function CheckLink(link) {
    if (link == 'https://www.dropbox.com/s/nkrk81z790mowyi/Green.png?dl=1') {
        link = 'https://www.dropbox.com/s/4rhpbj2mzyjlzai/Yellow.png?dl=1';
    }
    else if (link == 'https://www.dropbox.com/s/4rhpbj2mzyjlzai/Yellow.png?dl=1') {
        link = 'https://www.dropbox.com/s/nkrk81z790mowyi/Green.png?dl=1';
    }

    return link;
}
function myFunction() {
    window.open("Home/Money", "myFuction2", "width=400,height=300");
}
function myFunction2() {
    window.open("Home/Notes", "myFunction", "width=400,height=300");
}