(function () {
    define(['jquery', 'bootstrap', 'lightbox'], function ($) {
        return {
            initLightBox: function (selector) {
                $(selector).on('click', '[data-toggle="lightbox"]', function (event) {
                    event.preventDefault();
                    $(this).ekkoLightbox();
                });
            }
        }
    })
})()
