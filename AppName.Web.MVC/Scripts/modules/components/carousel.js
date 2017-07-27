(function () {
    define(['jquery', 'bootstrap', 'jqueryslick'], function ($) {
        return {
            initCarousel: function (selector, options) {
                $(selector).carousel(options);
            },
            slickConfig: function (selector, autoplaySpeed, autoplay, dots) {
                //Uncomment Below lines based on responsive changes
                $(selector).slick({
                    dots: dots,
                    autoplay: autoplay,
                    mobileFirst: true,
                    autoplaySpeed: autoplaySpeed
                    //responsive: [{
                    //    breakpoint: 1024,
                    //    settings: {
                    //       // slidesToShow: 3,
                    //        infinite: true
                    //    }
                    //}, {

                    //    breakpoint: 600,
                    //    settings: {
                    //        //slidesToShow: 2,
                    //        dots: true
                    //    }

                    //}, {

                    //    breakpoint: 300,
                    //    settings: "unslick" // destroys slick
                    //}]
                });
            },
            resizeHeight: function () {
                vpw = $(window).width();
                vph = $(window).height() - 100;
                $('.slick-track').css({ 'height': vph + 'px' });
            }
        }
    })
})();

