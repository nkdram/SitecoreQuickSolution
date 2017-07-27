require.config({
    paths: {
        "jquery-private": "modules/jquery.no-conflict",
        jquery: '/bower_components/jquery/dist/jquery.min',
        jqueryvalidate: '/bower_components/jquery-validation/dist/jquery.validate.min',
        jqueryunobtrusive: '/bower_components/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min',
        bootstrap: '/bower_components/bootstrap/dist/js/bootstrap.min',
        modernizr: '/bower_components/modernizr/modernizr',
        bootsrapformhelper: '/bower_components/bootstrap-formhelpers/dist/js/bootstrap-formhelpers',
        jquerynewsticker: '/bower_components/news-ticker/jquery.bootstrap.newsbox.min',
        jqueryslick:'/bower_components/slick-carousel/slick/slick.min',
        lightbox: '/bower_components/ekko-lightbox/dist/ekko-lightbox.min',
        tether: '/bower_components/tether/dist/js/tether.min',

        //Custome Modules
        header: '/Scripts/modules/common/Header',
        newsticker: '/Scripts/modules/components/newsticker',
        carousel: '/Scripts/modules/components/carousel',
        lightboxmod: '/Scripts/modules/common/LightBox',
        jOverlay: 'https://cdn.jsdelivr.net/jquery.loadingoverlay/latest/loadingoverlay.min',
        jOverlayProg:'https://cdn.jsdelivr.net/jquery.loadingoverlay/latest/loadingoverlay_progress.min'
    },
    shim: {
        "bootstrap": {
            deps: ["jquery", "tether"]
        },
        "jqueryvalidate": {
            deps: ["jquery"]
        },
        "jqueryunobtrusive": {
            deps: ["jquery", "jqueryvalidate"]
        },
        "bootsrapformhelper": {
            deps: ["jquery", "bootstrap"]
        },
        "header": {
            deps: ["jquery", "bootstrap"]
        },
        "jquerynewsticker": {
            deps: ["jquery"]
        },
        "jqueryslick": {
            deps: ["jquery", "bootstrap"]
        },
        "lightbox": {
            deps: ["jquery", "bootstrap"]
        },
        "jOverlay": {
            dep: ["jquery", "bootstrap", "jOverlayProg"]
        }

    },
    map: {
        // '*' means all modules will get 'jquery-private'
        // for their 'jquery' dependency.
        '*': {
            'jquery': 'jquery-private'
        },
        // 'jquery-private' wants the real jQuery module
        // though. If this line was not here, there would
        // be an unresolvable cyclic dependency.
        'jquery-private': {
            'jquery': 'jquery'
        }
    }
});
// Now run any initialization javascript for the site:
require(['tether'], function (tether) {
    // Init code here
    window.Tether = tether;
});