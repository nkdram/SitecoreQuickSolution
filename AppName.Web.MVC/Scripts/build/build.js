
(function () {
    return {
        baseUrl: "../../Scripts/modules",
        name: "init",
        out: "app-built.js",

        paths: {
            init: '../init',
            "jquery-private": "jquery.no-conflict",
            jquery: '../../bower_components/jquery/dist/jquery.min',
            jqueryvalidate: '../../bower_components/jquery-validation/dist/jquery.validate.min',
            jqueryunobtrusive: '../../bower_components/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min',
            bootstrap: '../../bower_components/bootstrap/dist/js/bootstrap.min',
            modernizr: '../../bower_components/modernizr/modernizr',
            bootsrapformhelper: '../../bower_components/bootstrap-formhelpers/dist/js/bootstrap-formhelpers',
            jquerynewsticker: '../../bower_components/news-ticker/jquery.bootstrap.newsbox.min',
            jqueryslick: '../../bower_components/slick-carousel/slick/slick.min',
            lightbox: '../../bower_components/ekko-lightbox/dist/ekko-lightbox.min',
            tether: '../../bower_components/tether/dist/js/tether.min',

            //Custome Modules
            header: 'common/Header',
            newsticker: 'components/newsticker',
            carousel: 'components/carousel',
            lightboxmod: 'common/LightBox'
        },
        "optimize": "uglify2"
    };
})()

