
$(window).on('load', function () {
    $(".zxing-button start").hide();
    $(".zxing-button stop").hide();
});

document.addEventListener("DOMContentLoaded", function () {
    // Hide the buttons on page load
    $(".zxing-button.stop, .zxing-button.start").hide();
});


function startCamera() {
    $('.start').trigger('click');
    $(".stopButtonHandler").removeAttr("hidden");
    $(".startButtonHandler").hide();
}

function stopCamera() {
    $('.stop').trigger('click');
    $(".startButtonHandler").show();
    $(".stopButtonHandler").hide();
}


