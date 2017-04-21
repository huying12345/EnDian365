
jQuery(function () {

    NewUserChars("line-xz");

    $(".nav-tabs li").click(function () {
        var ID = "line-" + $(this).attr("id");
        if (ID == "line-xz") {
            NewUserChars(ID);
        } else if (ID == "line-qd") {
            ActiveChars(ID);
        } else if (ID == "line-lj") {
            CountChars(ID);
        } else {
            AllChars(ID);
        }
    })
})

function NewUserChars(ID) {
    jQuery.ajax({
        url: '/App/Stat/GetNewUser/',
        dataType: 'json',
        success: function (msg) {
            var title = ['新增用户'];
            var ArrNum = new Array();
            var ArrTime = new Array();
            for (var i = 0; i < msg.length; i++) {
                ArrNum.push(msg[i].count);
                ArrTime.push(msg[i].datatime);
            }

            data = [
                            { name: '新增用户', type: 'line', stack: '总量', data: ArrNum }
            ];
            var xAxis = ArrTime;

            echars(ID, title, data, xAxis);
        }
    });
}

function ActiveChars(ID) {
    jQuery.ajax({
        url: '/App/Stat/GetActiveUser/',
        dataType: 'json',
        success: function (msg) {
            var title = ['活跃用户'];
            var ArrNum = new Array();
            var ArrTime = new Array();
            for (var i = 0; i < msg.length; i++) {
                ArrNum.push(msg[i].count);
                ArrTime.push(msg[i].datatime);
            }

            data = [
                            { name: '活跃用户', type: 'line', stack: '总量', data: ArrNum }
            ];
            var xAxis = ArrTime;

            echars(ID, title, data, xAxis);
        }
    });
}

function CountChars(ID) {
    jQuery.ajax({
        url: '/App/Stat/GetCount/',
        dataType: 'json',
        success: function (msg) {
            var title = ['启动次数'];
            var ArrNum = new Array();
            var ArrTime = new Array();
            for (var i = 0; i < msg.length; i++) {
                ArrNum.push(msg[i].count);
                ArrTime.push(msg[i].datatime);
            }

            data = [
                            { name: '启动次数', type: 'line', stack: '总量', data: ArrNum }
            ];
            var xAxis = ArrTime;

            echars(ID, title, data, xAxis);
        }
    });
}

function AllChars(ID) {
    jQuery.ajax({
        url: '/App/Stat/GetAllUser/',
        dataType: 'json',
        success: function (msg) {
            var title = ['累计用户'];
            var ArrNum = new Array();
            var ArrTime = new Array();
            for (var i = 0; i < msg.length; i++) {
                ArrNum.push(msg[i].count);
                ArrTime.push(msg[i].datatime);
            }

            data = [
                            { name: '累计用户', type: 'line', stack: '总量', data: ArrNum }
            ];
            var xAxis = ArrTime;

            echars(ID, title, data, xAxis);
        }
    });
}

function echars(ID, title, data, xAxis) {

    // 基于准备好的dom，初始化echarts图表
    var myChart = echarts.init(document.getElementById(ID));

    var option;

    option = {
        tooltip: {
            trigger: 'axis'
        },
        legend: {
            data: title
        },
        xAxis: [
            {
                type: 'category',
                boundaryGap: false,
                data: xAxis
            }
        ],
        yAxis: [
            {

                type: 'value'
            }
        ],
        series: data
    };
    // 为echarts对象加载数据
    myChart.setOption(option);

}


