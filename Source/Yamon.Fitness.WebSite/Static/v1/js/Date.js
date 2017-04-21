Date.prototype.pattern=function(fmt) {     
    var o = {     
    "M+" : this.getMonth()+1, //月份     
    "d+" : this.getDate(), //日     
    "h+" : this.getHours()%12 == 0 ? 12 : this.getHours()%12, //小时     
    "H+" : this.getHours(), //小时     
    "m+" : this.getMinutes(), //分     
    "s+" : this.getSeconds(), //秒     
    "q+" : Math.floor((this.getMonth()+3)/3), //季度     
    "S" : this.getMilliseconds() //毫秒     
    };     
    var week = {     
    "0" : "\u65e5",     
    "1" : "\u4e00",     
    "2" : "\u4e8c",     
    "3" : "\u4e09",     
    "4" : "\u56db",     
    "5" : "\u4e94",     
    "6" : "\u516d"    
    };     
    if(/(y+)/.test(fmt)){     
        fmt=fmt.replace(RegExp.$1, (this.getFullYear()+"").substr(4 - RegExp.$1.length));     
    }     
    if(/(E+)/.test(fmt)){     
        fmt=fmt.replace(RegExp.$1, ((RegExp.$1.length>1) ? (RegExp.$1.length>2 ? "\u661f\u671f" : "\u5468") : "")+week[this.getDay()+""]);     
    }     
    for(var k in o){     
        if(new RegExp("("+ k +")").test(fmt)){     
            fmt = fmt.replace(RegExp.$1, (RegExp.$1.length==1) ? (o[k]) : (("00"+ o[k]).substr((""+ o[k]).length)));     
        }     
    }     
    return fmt;
}
function curDateTime() {
    var d = new Date();
    var year = d.getFullYear();
    var month = d.getMonth() + 1;
    var date = d.getDate();
    var day = d.getDay();
    var hours = d.getHours();
    var minutes = d.getMinutes();
    var seconds = d.getSeconds();
    var ms = d.getMilliseconds();
    var curDateTime = year;
    if (month > 9)
        curDateTime = curDateTime + "-" + month;
    else
        curDateTime = curDateTime + "-0" + month;
    if (date > 9)
        curDateTime = curDateTime + "-" + date;
    else
        curDateTime = curDateTime + "-0" + date;
    if (hours > 9)
        curDateTime = curDateTime + " " + hours;
    else
        curDateTime = curDateTime + " 0" + hours;
    if (minutes > 9)
        curDateTime = curDateTime + ":" + minutes;
    else
        curDateTime = curDateTime + ":0" + minutes;
    if (seconds > 9)
        curDateTime = curDateTime + ":" + seconds;
    else
        curDateTime = curDateTime + ":0" + seconds;
    return curDateTime;
}
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
    var time = year + "年" + month + "月" + date + "日" + " " + hour + "时" + minu + "分" + sec + "秒";
    $("#bgclock").html(time);
    var timer = setTimeout("clockon()", 1000);
}
//格式化CST日期的字串

function formatCSTDate(strDate, format) {

    return formatDate(new Date(strDate), format);

}



//格式化日期,

function formatDate(date, format) {

    var paddNum = function (num) {

        num += "";

        return num.replace(/^(\d)$/, "0$1");

    }

    //指定格式字符

    var cfg = {

        yyyy: date.getFullYear() //年 : 4位

          , yy: date.getFullYear().toString().substring(2)//年 : 2位

          , M: date.getMonth() + 1  //月 : 如果1位的时候不补0

          , MM: paddNum(date.getMonth() + 1) //月 : 如果1位的时候补0

          , d: date.getDate()   //日 : 如果1位的时候不补0

          , dd: paddNum(date.getDate())//日 : 如果1位的时候补0

          , hh: date.getHours()  //时

          , HH: paddNum(date.getHours()) //时: 如果1位的时候补0

          , mm: paddNum(date.getMinutes()) //分

          , ss: paddNum(date.getSeconds()) //秒

    }

    format || (format = "yyyy-MM-dd hh:mm:ss");

    return format.replace(/([a-z])(\1)*/ig, function (m) { return cfg[m]; });

}

//格式化日期,jd

function formatDatejd(dates, format,addday) {

    date = new Date(dates.replace(/-/g, "/"));
    date.setDate(date.getDate() + addday);
    var paddNum = function (num) {
        num += "";
        return num.replace(/^(\d)$/, "0$1");
    }
    //指定格式字符
    var cfg = {
        yyyy: date.getFullYear() //年 : 4位
          , yy: date.getFullYear().toString().substring(2)//年 : 2位
          , M: date.getMonth() + 1  //月 : 如果1位的时候不补0
          , MM: paddNum(date.getMonth() + 1) //月 : 如果1位的时候补0
          , d: date.getDate()   //日 : 如果1位的时候不补0
          , dd: paddNum(date.getDate())//日 : 如果1位的时候补0
          , hh: date.getHours()  //时
          , HH: paddNum(date.getHours()) //时: 如果1位的时候补0
          , mm: paddNum(date.getMinutes()) //分
          , ss: paddNum(date.getSeconds()) //秒
    }
    format || (format = "yyyy-MM-dd hh:mm:ss");
    return format.replace(/([a-z])(\1)*/ig, function (m) { return cfg[m]; });
} 