var map;

function initMap() {

    var myLatLng = { lat: -34.397, lng: 150.644 };

    // Create a map object and specify the DOM element for display.
    var map = new google.maps.Map(document.getElementById('map'), {
        scrollwheel: false,
        zoom: 8
    });

    var geocoder = new google.maps.Geocoder();

    // Create a marker and set its position.
    var marker = new google.maps.Marker({
        map: geocoder,
        position: myLatLng,
        title: "Post Location"
    });

    geocodeAddress(geocoder, map);

    getLongLang(geocoder);

    document.getElementById('submit').addEventListener('click', function () {
        geocodeAddress(geocoder, map);
    });
}

function geocodeAddress(geocoder, resultsMap) {
    var address = document.getElementById('address').value;
    geocoder.geocode({ 'address': address }, function (results, status) {
        if (status === google.maps.GeocoderStatus.OK) {
            resultsMap.setCenter(results[0].geometry.location);
            var marker = new google.maps.Marker({
                map: resultsMap,
                position: results[0].geometry.location
            });
            var lat = results[0].geometry.location.lat();
            var lng = results[0].geometry.location.lng();
            document.getElementById("street").src = 'htt' + 'ps://maps.googleapis.com/maps/api/streetview?size=400x400&location=' + lat + "," + lng + "&fov=90&heading=235&pitch=10&key=AIzaSyD0df7Y8Kq2jyE0LBusA7xXSD3GrCqhGHM";
        } else {
            alert('Geocode was not successful for the following reason: ' + status);
        }
    });
}

function getLongLang(geocoder) {
    var address = document.getElementById('address').value;
    geocoder.geocode({ 'address': address }, function (results, status) {
        if (status === google.maps.GeocoderStatus.OK) {
            var lat = results[0].geometry.location.lat();
            var lng = results[0].geometry.location.lng();
            document.getElementById("street").src = 'htt' + 'ps://maps.googleapis.com/maps/api/streetview?size=400x400&location=' + lat + "," + lng + "&fov=90&heading=235&pitch=10&key=AIzaSyD0df7Y8Kq2jyE0LBusA7xXSD3GrCqhGHM";
        } else {
            alert('Geocode was not successful for the following reason: ' + status);
        }
    });
}