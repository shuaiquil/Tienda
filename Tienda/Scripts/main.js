
//-----------------------MAPA---------------------------------------------------------
function iniciarMap() {
    var map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: -53.7874797, lng: -67.6989907 },
        zoom: 22,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    });
    var marker = new google.maps.Marker({
        position: { lat: -53.7874797, lng: -67.6989907 }, map: map
    });
}
