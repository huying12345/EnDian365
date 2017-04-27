$(function () {

    //返回顶部
    $(window).scroll(function () {
        if ($(window).scrollTop() >= 2000) {
            $('#backUp').show();
        } else {
            $('#backUp').hide();
        }
    });
    $('#backUp').click(function () {
        $("html,body").animate({
            scrollTop: 0 + 'px'
        }, 500);
    });
});
