﻿var SpecialModule = (function () {
    // Return anything that you want to expose outside the closure
    return {
        getSpecials: function (callback) {

            $.ajax({
                type: "GET",
                dataType: "json",
                url: "http://localhost:58346/api/Specials",
                success: function (data) {
                    console.log(data);
                    callback(data);
                }
            });
        }
    };
}());