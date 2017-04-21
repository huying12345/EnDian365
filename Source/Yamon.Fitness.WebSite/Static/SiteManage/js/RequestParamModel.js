function InitRequestParam() {
    var requestParamList = [];
    if ($('#RequestParam').val() != '') {
        var requestList = eval($('#RequestParam').val());
        //requestList=_.sortBy(requestList, 'orderId');
        for (var i = 0; i < requestList.length; i++) {
            requestParamList.push(new RequestParam(requestList[i]));
        }
    }
    ko.applyBindings(new RequestParamModel(requestParamList), document.getElementById('RequestParamDiv'));
}

var RequestParam = function (model) {
    var self = this;
    self.name = ko.observable(model.name);
    self.title = ko.observable(model.title);
    self.type = ko.observable(model.type);
    self.required = ko.observable(model.required);
    self.sign = ko.observable(model.sign);
    self.desc = ko.observable(model.desc);
    self.orderId = ko.observable(model.orderId);
    self.requiredmsg = ko.pureComputed(function () {
        return this.required() ? '必填参数' : '可选参数';
    }, this);
};

//请求参数
var RequestParamModel = function (params) {
    var self = this;
    self.params = ko.observableArray(params);

    self.addParam = function () {
        self.params.push(new RequestParam({
            name: '',
            title: '',
            type: "string",
            required: false,
            sign: false,
            orderId: self.params().length + 1,
            desc: ''
        }));
       
    };
    self.addEntityParam = function () {
        var entityName = prompt("请输入实体类（如：Yamon.Module.SiteManage.Entity.API）", "");
        if (entityName != null && entityName != "") {
            $.post("/SiteManage/API/GetEntityFields", { entityName: entityName }, function (result) {
                if (result.success) {
                    for (var i = 0; i < result.rows.length; i++) {
                        self.params.push(new RequestParam({
                            name: result.rows[i].ColumnName,
                            title: result.rows[i].Description,
                            type: result.rows[i].TypeName,
                            required: false,
                            sign: false,
                            orderId: self.params().length + 1 + i,
                            desc: ''
                        }));
                    }
                } else {
                    alert(result.message);
                }
            });
        }
    };
    self.removeParam = function (param) {
        self.params.remove(param);
    };
    self.RequestJson = ko.pureComputed(function () {
        var dataToSave = $.map(self.params(), function (line) {
            return line.name() ? {
                name: line.name(),
                title: line.title(),
                type: line.type(),
                required: line.required(),
                sign: line.sign(),
                orderId: line.orderId(),
                desc: line.desc()
            } : undefined;
        });
        dataToSave = _.sortBy(dataToSave, function(o) {
            return parseInt(o.orderId);
        });
        $('#RequestParam').val(JSON.stringify(dataToSave));
        return JSON.stringify(dataToSave);
    }, this);
};

