function InitResponseParam() {
    var responsetParamList = [];
    if ($('#ResponseParam').val() != '') {
        var responsetList = $.parseJSON($('#ResponseParam').val());
        for (var i = 0; i < responsetList.length; i++) {
            var response = new ResponseParam(responsetList[i]);
            for (var j = 0; j < responsetList[i].children.length; j++) {
                response.children.push(new ResponseParam(responsetList[i].children[j]));
            }
            responsetParamList.push(response);
        }
    }
    ko.applyBindings(new ResponseParamModel(responsetParamList), document.getElementById('ResponseParamDiv'));
}



var ResponseParam = function (model) {
    var self = this;
    self.name = ko.observable(model.name);
    self.title = ko.observable(model.title);
    self.type = ko.observable(model.type);
    self.desc = ko.observable(model.desc);
    self.orderId = ko.observable(model.orderId);
    self.children = ko.observableArray([]);
};

//返回参数
var ResponseParamModel = function (params) {
    var self = this;
    self.params = ko.observableArray(params);

    self.addParam = function () {
        self.params.push(new ResponseParam({
            name: "",
            title: '',
            type: "string",
            orderId: self.params().length + 1,
            desc: ''
        }));
    };
    self.removeParam = function (param) {
        self.params.remove(param);
    };


    self.addChildParam = function (param) {
        param.children.push(new ResponseParam({
            name: "",
            title: '',
            type: "string",
            orderId: param.children().length + 1,
            desc: ''
        }));
    };

    self.addChildParamFromModel = function(param) {
        var entityName = prompt("请输入实体类（如：Yamon.Module.SiteManage.Entity.API）", "");
        if (entityName != null && entityName != "") {
            $.post("/SiteManage/API/GetEntityFields", { entityName: entityName }, function (result) {
                if (result.success) {
                    for (var i = 0; i < result.rows.length; i++) {
                        param.children.push(new ResponseParam({
                            name: result.rows[i].ColumnName,
                            title: result.rows[i].Description,
                            type: result.rows[i].TypeName,
                            orderId: param.children().length + 1,
                            desc: ''
                        }));
                    }
                } else {
                    alert(result.message);
                }
            });
        }
    };
    self.removeChildParam = function (param) {
        $.each(self.params(), function () {
            this.children.remove(param);
        });
    };
    self.ResponseJson = ko.pureComputed(function () {
        var dataToSave = $.map(self.params(), function (line) {
            var childJson = $.map(line.children(), function (param) {
                return param.name() ? {
                    name: param.name(),
                    title: param.title(),
                    type: param.type(),
                    orderId: param.orderId(),
                    desc: param.desc()
                } : undefined;
            });
            childJson = _.sortBy(childJson, function (o) {
                return parseInt(o.orderId);
            });
            return line.name() ? {
                name: line.name(),
                title: line.title(),
                type: line.type(),
                desc: line.desc(),
                orderId: line.orderId(),
                children: childJson
            } : undefined;
        });
        dataToSave = _.sortBy(dataToSave, function (o) {
            return parseInt(o.orderId);
        });
        $('#ResponseParam').val(JSON.stringify(dataToSave));
        return JSON.stringify(dataToSave);
    }, this);
};