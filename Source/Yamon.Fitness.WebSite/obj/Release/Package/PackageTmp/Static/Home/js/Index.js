$(function() {
    clockon();
    jQuery('#editpass').click(function() {
        OpenMyDialog("/UCenter/User/ChangePwd", '修改密码', 420, 220);
    });
    jQuery('#btnEp').click(function() {
        serverLogin();
    });
    jQuery('#btnCancel').click(function() { closePwd(); });
    jQuery('#loginOut').click(function() {
        jQuery.messager.confirm('系统提示', '您确定要退出本次登录吗?', function(r) {
            if (r) {
                location.href = '/UCenter/User/LogoutAction';
            }
        });
    });

    jQuery("#loading-mask").css("display", "none");
    jQuery("#loading").css("display", "none");
    $('.easyui-accordion li a').click(function() {
        var tabTitle = $(this).text();
        var url = $(this).attr("href");
        var frameName = $(this).attr("target");
        addTab(tabTitle, url, frameName);
        $('.easyui-accordion li div').removeClass("selected");
        $(this).parent().addClass("selected");
    }).hover(function() {
        $(this).parent().addClass("hover");
    }, function() {
        $(this).parent().removeClass("hover");
    });
    tabClose();
    tabCloseEven();
});

//系统时间
function clockon() {
    var now = new Date();
    var year = now.getFullYear(); //getFullYear getYear
    var month = now.getMonth();
    var date = now.getDate();
    var day = now.getDay();
    var hour = now.getHours();
    var minu = now.getMinutes();
    var sec = now.getSeconds();
    var week;
    month = month + 1;
    if (month < 10) month = "0" + month;
    if (date < 10) date = "0" + date;
    if (hour < 10) hour = "0" + hour;
    if (minu < 10) minu = "0" + minu;
    if (sec < 10) sec = "0" + sec;
    var arr_week = new Array("星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六");
    week = arr_week[day];
    var time = year + "年" + month + "月" + date + "日" + " " + hour + ":" + minu + ":" + sec + " " + week;
    $("#bgclock").html(time);
    var timer = setTimeout("clockon()", 1000);
}

