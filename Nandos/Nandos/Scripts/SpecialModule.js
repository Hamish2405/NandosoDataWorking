var SpecialModule = (function () {
    // Return anything that you want to expose outside the closure
    return {
        getSpecials: function (callback) {

            $.ajax({
                type: "GET",
                dataType: "json",
                
                    //http://localhost:58346/api/Specials
                url: "http://nandoso-hamish.azurewebsites.net/api/specials",
                success: function (data) {
                    console.log(data);
                    callback(data);
                }
            });
        }
    };
}());