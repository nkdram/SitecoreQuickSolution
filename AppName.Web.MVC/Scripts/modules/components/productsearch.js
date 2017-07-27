(function () {
    define(['jquery', 'bootstrap', '/Scripts/modules/puajax.js'], function ($, bootstrap, ajax) {
        ProductSearch = {
            initSearch: function (selector) {
                var searchSelector = selector + '.search-panel';
                $(searchSelector + ' .dropdown-menu').find('a').click(function (e) {
                    e.preventDefault();
                    var param = $(this).attr("href").replace("#", "");
                    var concept = $(this).text();
                    $(searchSelector + ' span#search_concept').text(concept);
                    $('.input-group #search_param').val(param);
                });

                // Load Facets
                ProductSearch.search('/api/Sitecore/common/LoadFacets', {}, function (data) {
                    //Build Facets
                    if (data.result) {
                        var facets = '';
                        $.each(data.result, function (i, item) {
                            facets += ProductSearch.buildTags(item.Count, ProductSearch.toTitleCasing(item.Name), 'producttype');
                        });
                        $(selector + ' .filters').html(facets);
                    }
                },
                function (err) {
                    // Log error
                });
                $(document).on('click', selector + " .search," + selector + " .filters input[type='checkbox']", function () {
                    var facets = ProductSearch.getSelectedFilters(selector);
                    var strProducts = '';
                    $.each(facets, function (i, item) {
                        strProducts += '|' + item.value
                    });
                    var searchData = {
                        searchTerm: $(selector + " .searchTxt").val(),
                        productType: strProducts
                    };
                    ProductSearch.search('/api/Sitecore/common/SearchResult', searchData, function (data) {
                        console.log(data);
                        var result = data.result;
                        var productList = '';
                        if (result) {
                            $.each(result, function (i, item) {
                                productList += ProductSearch.buildProduct(item);
                            });
                            $(selector + " .product-list").html(productList);
                        }
                    },
                    function (err) {
                        // Log error
                    });
                });
            },
            search: function (url, searchdata, successCallback, failCallback) {
                ajax.postData(url, searchdata, successCallback, failCallback);
            },
            buildTags: function (tagCount, tag, taggroup) {
                return '<li class="list-group-item">' +

                    ' <input type="checkbox" value="' + tag + '" data-taggroup ="' + taggroup + '">' +

                  '<span class="tag tag-default tag-pill float-xs-right">' + tagCount + '</span>'
                  + tag +
                  '</li>';
            },
            buildProduct: function (productData) {
                return '<h1>' + productData.ItemName + '</h1>' +
                     '<p>' + productData.Appetite + '</p>'
                    //<div>
                    //    <span class="badge badge-success">Posted 2012-08-02 20:47:04</span>
                    //        <div class="pull-right">
                    //        <span class="label">alice</span> <span class="label">story</span> 
                    //        <span class="label">blog</span> <span class="label">personal</span>
                    // </div>
                    //</div>     
                  + '<hr>';
            },
            toTitleCasing: function (str) {
                return str.replace(/(?:^|\s)\w/g, function (match) {
                    return match.toUpperCase();
                })
            },
            getSelectedFilters: function (selector) {
                var selected = [];
                $(selector + ' .filters input:checked').each(function () {
                    selected.push({
                        value: $(this).val(),
                        group: $(this).data('taggroup')
                    });
                });
                return selected;
            }
        }

        return ProductSearch
    })
})();

