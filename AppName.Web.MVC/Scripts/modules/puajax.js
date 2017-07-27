(function () {
    define(['jquery', 'jOverlay'], function ($, jOverlay) {
        return {
            getRequest: function (url, successCallback, failCallback) {
                $.LoadingOverlay("show", {
                    image: "/Content/img/gear.gif"
                });
                $.ajax({
                    url: url,
                    timeout: 3000,
                    dataType: "json",
                    success: successCallback,
                    error: failCallback
                }).done(function () {
                    $.LoadingOverlay("hide");
                })
            },
            postData: function (url, data, successCallback, failCallback) {
                $.LoadingOverlay("show", {
                    image: "/Content/img/gear.gif"
                });
                $.ajax(url, {
                    method: 'POST',
                    data: data
                }).then(
                    successCallback,
                    failCallback
                ).done(function () {
                    $.LoadingOverlay("hide");
                })
            }
        }
    })
})();
