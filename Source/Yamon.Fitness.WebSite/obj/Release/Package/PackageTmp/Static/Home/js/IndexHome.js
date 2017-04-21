
jQuery(function () {
    var index = new indexHome();
    ko.applyBindings(index);
    index.init();
})

var indexHome = function () {
    var self = this;

    self.lines = ko.observableArray([]);
    self.lists = ko.observableArray([]);
    self.init = function () {

        self.countDay();
        self.secondList(jQuery("#clicklist .active a").attr('class'))
        self.clicklist();
        //self.countEchars();
        //self.boxBorder();
    }
  
    self.countDay = function () {
        var html = "";
        $.ajax({
            url: '/api/Product/OrderInfo/GetToDayCountlist?',
            dataType: 'json',
            success: function (msg) {
                if (msg.length > 0) {
                    html = template("t_template", msg[0]);
                }
                $("#t_list").html(html);
            }
        });
    }
    self.clicklist = function () {
       
        jQuery("#clicklist a").click(function () {
            self.lines([])
            var str = jQuery(this).attr('class');
            $.each(self.lists(), function (i) {
                if (self.lists()[i].Models == str) {
                    console.log(self.lists()[i].Models+"|"+ str)
                    self.lines.push(self.lists()[i])
                }
            });
        })
   
    }
    self.secondList = function (type) {
        $.ajax({
            url: '/api/Product/OrderInfo/GetSecond?',
            dataType: 'json',
            success: function (msg) {
                if (msg.length > 0) {
                    for (var i = 0; i < msg.length; i++) {
                        self.lists.push(msg[i]);
                        if (msg[i].Models == type) {
                            self.lines.push(msg[i]);
                        }
                       
                    }
                }
            }
        });
    }
    self.boxBorder = function () {
        jQuery("#box-border .knob-label").click(function () {
            jQuery(this).addClass("tab-echars").slibings().removeClass("tab-echars")
        })
    }
    //self.countEchars = function () {

    //    var myChart = echarts.init(document.getElementById('world-map'));

    //    // 指定图表的配置项和数据
    //    var option = {
    //        title: {
    //            text: "在馆人数",
    //            textStyle: {

    //                color: '#fff',
                   
    //            },
    //        },
    //        tooltip: {
    //            trigger: 'axis'
    //        },
            
    //        grid: {
    //            left: '3%',
    //            right: '4%',
    //            bottom: '3%',
    //            borderColor: '#fff',
    //            containLabel: true
    //        },
    //        toolbox: {
    //            feature: {
    //                saveAsImage: {}
    //            }
    //        },
    //        xAxis: {
    //            type: 'category',
    //            boundaryGap: false,
    //            data: ["9:01", "9:02", "9:03", "9:04", "9:05", "9:06", "9:07", "9:08", "9:9", "9:10", "9:11", "9:12"],
    //            axisLine: {

    //                show: true,
    //                onZero: true,
    //                lineStyle: {

    //                    color: '#fff',

    //                },

    //            },
    //        },
    //        yAxis: {
    //            type: 'value',
    //            axisLine: {

    //                show: true,
    //                onZero: true,
    //                lineStyle: {

    //                    color: '#fff',
          
    //                },

    //            },
    //        },
    //        series: [
    //            {
    //                name: '餐饮',
    //                type: 'line',
    //                smooth: true,//是否曲线
    //                stack: '总金额',
    //                data: [0, 2, 3, 6, 9, 9, 1, 2, 6, 0, 4, 6, ],
    //                itemStyle: {

    //                    normal: {

    //                        color: "#fff",

    //                    }
    //                }
    //            }
    //        ]
    //    };

    //    myChart.setOption(option);
    //}

    self.more = function () {
        window.location.href = "/Product/OrderInfo/Second?&Frame=1&Menu=58e527ff-25c0-448a-9108-01e35b0d0b0c&Models=" + jQuery("#clicklist .active a").attr('class');
    }


}