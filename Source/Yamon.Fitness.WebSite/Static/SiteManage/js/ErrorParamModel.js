function InitErrorParam() {
    var ErrorParamList = [];
    if ($('#ErrorCodeParam').val() != '') {
        var ErrorList = eval($('#ErrorCodeParam').val());
        for (var i = 0; i < ErrorList.length; i++) {
            ErrorParamList.push(new ErrorParam(ErrorList[i]));
        }
    }
    ko.applyBindings(new ErrorParamModel(ErrorParamList), document.getElementById('ErrorCodeDiv'));
}

var ErrorParam = function (model) {
    var self = this;
    self.name = ko.observable(model.name);
    self.desc = ko.observable(model.desc);
};

//请求参数
var ErrorParamModel = function (params) {
    var self = this;
    self.params = ko.observableArray(params);

    self.addParam = function () {
        self.params.push(new ErrorParam({
            name: '',
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
                desc: line.desc()
            } : undefined;
        });
        dataToSave = _.sortBy(dataToSave, function (o) {
            return parseInt(o.name);
        });
        $('#ErrorCodeParam').val(JSON.stringify(dataToSave));
        return JSON.stringify(dataToSave);
    }, this);
};

