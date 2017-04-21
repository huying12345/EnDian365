$.extend($.fn.validatebox.defaults.rules, {
    phone: {
        validator: function (value, param) {
            return /^((\(\d{2,3}\))|(\d{3}\-))?(\(0\d{2,3}\)|0\d{2,3}-)?[1-9]\d{6,7}(\-\d{1,4})?$/.test(value);
        },
        message: '请输入正确的电话号码！示例：021-38384388'
    }
    ,
    mobile: {
        validator: function (value, param) {
            return /^((\(\d{2,3}\))|(\d{3}\-))?(13\d{9}|15\d{9}|18\d{9})$/.test(value);
        },
        message: '请输入正确的手机号码！示例：13812345678'
    }
    ,
    zip: {
        validator: function (value, param) {
            return /^[1-9]\d{5}$/.test(value);
        },
        message: '请输入正确的邮政编码！示例：344800'
    }
    ,
    english: {
        validator: function (value, param) {
            return /^[A-Za-z]+$/.test(value);
        },
        message: '请输入英文字母！示例：abcd'
    }
    ,
    chinese: {
        validator: function (value, param) {
            return /^[\u0391-\uFFE5]+$/.test(value);
        },
        message: '请输入中文字符！示例：中国'
    }
    ,
    number: {
        validator: function (value, param) {
            return /^\d+$/.test(value);
        },
        message: '请输入数字！示例：123'
    }
    ,
    reg: {
        validator: function (value, param) {
            return new RegExp(param[0], "g").test(value);
        },
        message: "格式错误！."
    },
    equals: {
        validator: function (value, param) {
            return value == $(param[0]).val();
        },
        message: '输入不一致！'
    }
});