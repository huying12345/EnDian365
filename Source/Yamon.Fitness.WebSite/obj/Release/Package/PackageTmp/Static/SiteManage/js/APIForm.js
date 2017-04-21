function initApiKO() {
    var requestParamList = [];
    if ($('#RequestParam').val() != '') {
        var requestList = eval($('#RequestParam').val());
        for (var i = 0; i < requestList.length; i++) {
            requestParamList.push(new RequestParam(requestList[i]));
        }
    }
    ko.applyBindings(new RequestParamModel(requestParamList), document.getElementById('RequestParamDiv'));

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

var RequestParam = function (model) {
    var self = this;
    self.name = ko.observable(model.name);
    self.title = ko.observable(model.title);
    self.type = ko.observable(model.type);
    self.required = ko.observable(model.required);
    self.sign = ko.observable(model.sign);
    self.desc = ko.observable(model.children);
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
            desc: ''
        }));
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
                desc: line.desc()
            } : undefined;
        });
        $('#RequestParam').val(JSON.stringify(dataToSave));
        return JSON.stringify(dataToSave);
    }, this);
};


var ResponseParam = function (model) {
    var self = this;
    self.name = ko.observable(model.name);
    self.title = ko.observable(model.title);
    self.type = ko.observable(model.type);
    self.desc = ko.observable(model.desc);
    self.children = ko.observableArray(model.chid);
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
            desc: ''
        }));
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
                    desc: param.desc()
                } : undefined;
            });
            return line.name() ? {
                name: line.name(),
                title: line.title(),
                type: line.type(),
                desc: line.desc(),
                children: childJson
            } : undefined;
        });
        $('#ResponseParam').val(JSON.stringify(dataToSave));
        return JSON.stringify(dataToSave);
    }, this);
};