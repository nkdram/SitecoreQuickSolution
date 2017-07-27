(function () {
    define(['jquery', 'bootstrap','bootsrapformhelper'], function ($) {
        return {
            toggleHeader: function () {
                $(document).on("scroll", function () {
                    if ($(document).scrollTop() > 20) {
                        $("header").removeClass("large").addClass("small");
                        $(".utility-nav").removeClass("expand");
                    } else {
                        $("header").removeClass("small").addClass("large");
                        $(".utility-nav").addClass("expand");
                    }
                });
            }
        }
    })
})()
