$(function () {
    // 切换视频
    $(".Vedio p").click(function () {
        var obj = $(this);
        var id = obj.attr("id");
        if (id == undefined) {
            window.open('');
        } else {
            var title = obj.text();
            window.open(id);
        }
    });
    $('.Audio p').click(function () {
        var obj = $(this);
        var id = obj.attr("id");

        if (id == undefined) {
            window.open('');
        } else {
            var title = obj.text();
            window.open(id);
        }
    });
    $('.more p').click(function () {
        var obj = $(this);
        var id = obj.attr("id");
        if (id == undefined) {
            window.open('');
        } else {
            var title = obj.text();
            window.open(id);
        }
    });
});    