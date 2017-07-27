(function () {
    define(['jquery', 'jquerynewsticker'], function ($) {
        return {
            initNewsTicker: function (selector, options) {
                $(selector).bootstrapNews(options);
            }
        }
    })
})();

