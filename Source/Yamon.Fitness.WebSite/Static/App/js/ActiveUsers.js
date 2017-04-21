jQuery(function () {
    echarsLine("line-chartA");
    echarsLine("line-chartB");
    echarsLine("line-chartC");
    echarsLine("line-chartD");
})

// 使用
function echarsLine(ID) {

    // 基于准备好的dom，初始化echarts图表
    var myChart = echarts.init(document.getElementById(ID));

    var option;

    option = {
        tooltip: {
            trigger: 'axis'
        },
        legend: {
            data: ['今日', '昨日', '7天前', '30天前']
        },
        xAxis: [
            {
                type: 'category',
                boundaryGap: false,
                data: ['00', '03', '06', '09', '12', '15', '18', '21']
            }
        ],
        yAxis: [
            {

                type: 'value'
            }
        ],
        series: [
            {
                name: '今日',
                type: 'line',
                stack: '总量',
                data: [120, 132, 101, 134, 90, 230, 210, 122]
            },
            {
                name: '昨日',
                type: 'line',
                stack: '总量',
                data: [220, 182, 191, 234, 290, 330, 310, 122]
            },
            {
                name: '7天前',
                type: 'line',
                stack: '总量',
                data: [150, 232, 201, 154, 190, 330, 410, 122]
            },
            {
                name: '30天前',
                type: 'line',
                stack: '总量',
                data: [320, 332, 301, 334, 390, 330, 320, 122]
            }
        ]
    };
    // 为echarts对象加载数据
    myChart.setOption(option);
}
