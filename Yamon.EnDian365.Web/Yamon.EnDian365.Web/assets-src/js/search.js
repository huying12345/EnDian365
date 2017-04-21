var SearchViewModel = function () {
    //viewModel本身。用来防止直接使用this的时候作用域混乱
    var self = this;
    //数据
    //this.items = ko.observableArray();
    this.search = ko.observableArray([]);
    //要访问的页码
    this.pageIndex = ko.observable(1);
    //总计页数
    this.pageCount = ko.observable(1);
    //页码数
    this.pageNumbers = ko.observableArray();
    //当前页
    this.currengePage = ko.observable(1);
    this.refresh = function () {
        //限制请求页码在该数据页码范围内
        if (self.pageIndex() < 1) {
            self.pageIndex(1);
        }
        if (self.pageIndex() > self.pageCount()) {
            self.pageIndex(self.pageCount());
        }
        //post异步加载数据
        $.post(
            "/api/PortalIPS/vwInfoCategory/GetvwInfoBySearchPage",
           {
               "Series": jQuery("#Series").val(),
               "CategoryID": jQuery("#CategoryID").val(),
               "Author": jQuery("#Author").val(),
               "keyword": jQuery("#keyword").val(),
               page: this.pageIndex,
               pageSize: 5,
           },
           function (data) {
               // 加载新的数据前，先移除原先的数据
               self.search.removeAll();
               self.pageNumbers.removeAll();
               self.pageCount(Math.round(data["rows"] / 10));
               for (var i = 1; i <= self.pageCount() ; i++) {
                   //装填页码
                   self.pageNumbers.push({ "number": i, "visible": i == self.pageIndex() ? "on" : "" });
               }
               //for...in 语句用于对数组或者对象的属性进行循环操作。
               //for ... in 循环中的代码每执行一次，就会对数组的元素或者对象的属性进行一次操作。
               for (var i in data["data"]) {
                   //装填数据
                   self.search.push(data["data"][i]);
               }
           },
           "json")
    }
    //请求第一页数据
    this.first = function () {
        self.pageIndex(1);
        self.refresh();
    }
    //请求下一页数据
    this.next = function () {
        self.pageIndex(this.pageIndex() + 1);
        self.refresh();

    }
    //请求先前一页数据
    this.previous = function () {
        self.pageIndex(this.pageIndex() - 1);
        self.refresh();
    }
    //请求最后一页数据
    this.last = function () {
        self.pageIndex(this.pageCount());
        self.refresh();
    }
    //跳转到某页
    this.gotoPage = function (data, event) {
        self.pageIndex(data["number"]);
        self.refresh();
    }
}


