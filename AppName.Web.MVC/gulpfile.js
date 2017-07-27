/// <reference path="bower_components/tether/dist/js/tether.min.js" />
/// <reference path="bower_components/ekko-lightbox/dist/ekko-lightbox.min.js" />
/// <reference path="bower_components/ekko-lightbox/dist/ekko-lightbox.min.js" />


var gulp = require('gulp');


var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var del = require('del');
var minifyCSS = require('gulp-minify-css');
var copy = require('gulp-copy');
var bower = require('gulp-bower');
var sourcemaps = require('gulp-sourcemaps');
var rjs = require('requirejs'), shell = require('gulp-shell');

var config = {
    //JavaScript files that will be combined into a jquery bundle
    jquerysrc: [
        'bower_components/jquery/dist/jquery.min.js',
        'bower_components/jquery-validation/dist/jquery.validate.min.js',
        'bower_components/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js'
    ],
    jquerybundle: 'Scripts/jquery-bundle.min.js',

    //JavaScript files that will be combined into a Bootstrap bundle
    bootstrapsrc: [
        'bower_components/bootstrap/dist/js/bootstrap.min.js',
        'bower_components/respond-minmax/dest/respond.min.js',
        'bower_components/tether/dist/js/tether.min.js'
    ],
    bootstrapbundle: 'Scripts/bootstrap-bundle.min.js',

    //Modernizr
    modernizrsrc: ['bower_components/modernizr/modernizr.js'],
    modernizrbundle: 'Scripts/modernizer.min.js',

    //Vendor
    vendorcss: [
        'bower_components/bootstrap-formhelpers/dist/css/bootstrap-formhelpers.css',
        'bower_components/slick-carousel/slick/slick-theme.css',
        'bower_components/slick-carousel/slick/slick.css',
        'bower_components/ekko-lightbox/dist/ekko-lightbox.css'
    ],
    vendorjs: [
        'bower_components/bootstrap-formhelpers/dist/js/bootstrap-formhelpers.js',
        'bower_components/slick-carousel/slick/slick.min.js',
        'bower_components/ekko-lightbox/dist/ekko-lightbox.min.js'
    ],

    //Bootstrap CSS and Fonts
    bootstrapcss: 'bower_components/bootstrap/dist/css/bootstrap.css',
    fonts: 'bower_components/bootstrap/dist/fonts/*.*',
    slickfonts: 'bower_components/slick-carousel/slick/fonts/*.*',

    appcss: './Content/Site.css',
    fontsout: './Content/dist/fonts',
    slickfontsout: './Content/dist/css/fonts',
    cssout: './Content/dist/css'

}



gulp.task('scripts', shell.task([
    'r.js -o ./Scripts/build/build.js'
]))

// Synchronously delete the output style files (css / fonts)
gulp.task('clean-styles', function (cb) {
    //del([config.fontsout,
    //          config.cssout, config.slickfontsout], cb);
});

gulp.task('css', ['bower-restore'], function () {
    return gulp.src([config.bootstrapcss, config.appcss])
     .pipe(concat('app.css'))
     .pipe(gulp.dest(config.cssout))
     .pipe(minifyCSS())
     .pipe(concat('app.min.css'))
     .pipe(gulp.dest(config.cssout));
});

gulp.task('fonts', ['bower-restore'], function () {
    return
    gulp.src(config.fonts)
        .pipe(gulp.dest(config.fontsout))
        .pipe(gulp.src(config.slickfonts))
        .pipe(gulp.dest(config.fontsout));
});

gulp.task('vendorcss', ['bower-restore'], function () {
    return
    gulp.src(config.vendorcss)
      .pipe(concat('vendor.css'))
      .pipe(gulp.dest(config.cssout))
      .pipe(minifyCSS())
      .pipe(concat('vendor.min.css'))
      .pipe(gulp.dest(config.cssout));
});



// Combine and minify css files and output fonts
gulp.task('styles', ['css',  'vendorcss'], function () {

});

//Restore all bower packages
gulp.task('bower-restore', function () {
    return bower();
});

//Set a default tasks
gulp.task('default', ['styles'], function () {

});