$(function () {
    $(".Video li").click(function () {
        var obj = $(this);
        var id = obj.attr("id");
        if (id == undefined) {
            window.open('');
        } else {
            var title = obj.text();
            window.open(id);
        }
    });

})