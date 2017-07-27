(function () {
    define(['jquery', 'bootstrap'], function ($) {
        return {
            initCarousel: function (selector) {
                $(selector).carousel({
                    interval: 6000
                })
            }
        }
    })
})();

