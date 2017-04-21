
jQuery(function () {

    echarsPie("Pie-chartA");
    echarsPie("Pie-chartB");
    echarsPie("Pie-chartC");
    echarsPie("Pie-chartD");
    echarsPie("Pie-chartE");
    echarsPie("Pie-chartF");

    NewUserChars("line-newUser");

    $(".nav-tabs-line li").click(function () {
        var ID = "line-" + $(this).attr("id");
        if (ID == "line-undefined") {
            return null;
        } else if (ID == "line-newUser") {
            NewUserChars(ID);
        } else if (ID == "line-Active") {
            ActiveChars(ID);
        } else if (ID == "line-StartsNum") {
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



// 使用
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
        xAxis: {
            labels: {
                step: 10
            },
            type: 'category',
            boundaryGap: false,
            data: xAxis,

        },
        yAxis: [
            {

                type: 'value'
            }
        ],
        series: data
    };
    // 为echarts对象加载数据
    myChart.setOption(option);
    window.onresize = myChart.resize;



}

function echarsPie(ID) {

    // 基于准备好的dom，初始化echarts图表
    var myChart = echarts.init(document.getElementById(ID));

    var option;

    option = {
        title: {
            text: '某站点用户访问来源',
            subtext: '纯属虚构',
            x: 'center'
        },
        tooltip: {
            trigger: 'item',
            formatter: "{a} <br/>{b} : {c} ({d}%)"
        },
        legend: {
            orient: 'vertical',
            x: 'left',
            data: ['直接访问', '邮件营销', '联盟广告', '视频广告', '搜索引擎']
        },
        toolbox: {
            show: true,
            feature: {
                mark: { show: true },
                dataView: { show: true, readOnly: false },
                magicType: {
                    show: true,
                    type: ['pie', 'funnel'],
                    option: {
                        funnel: {
                            x: '25%',
                            width: '50%',
                            funnelAlign: 'left',
                            max: 1548
                        }
                    }
                },
                restore: { show: true },
                saveAsImage: { show: true }
            }
        },
        calculable: true,
        series: [
            {
                name: '访问来源',
                type: 'pie',
                radius: '55%',
                center: ['50%', '60%'],
                data: [
                    { value: 335, name: '直接访问' },
                    { value: 310, name: '邮件营销' },
                    { value: 234, name: '联盟广告' },
                    { value: 135, name: '视频广告' },
                    { value: 1548, name: '搜索引擎' }
                ]
            }
        ]
    };

    // 为echarts对象加载数据
    myChart.setOption(option);

}




