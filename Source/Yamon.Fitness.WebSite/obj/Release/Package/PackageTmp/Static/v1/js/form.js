var MyForm = {};

MyForm.SubmitForm = function (url) {
    if (!url) {
        url= $('#myForm').attr("action");
    }
    if (MyForm.onBeforeSubmit()) {
        jQuery("#myForm").ajaxSubmit({
            type: 'post',
            dataType: 'json',
            url: url,
            beforeSubmit: MyForm.validate,
            success: function(data) {
                MyForm.onSubmitSuccess(data);
            },
            error: function(error) {
                jQuery.messager.progress('close');
                jQuery.messager.alert('提示', '保存失败：' + error.toString(), 'info');
                return false;
            }
        });
    }
}

MyForm.validate = function (formData, jqForm, options) {
    if (jQuery("#myForm").form('validate')) {
        var win = jQuery.messager.progress({
            title: '请稍候',
            msg: '数据提交中...'
        });
        return true;
    }
    return false;
}

MyForm.onSubmitSuccess = function (msg) {
    jQuery.messager.progress('close');
    if (msg.success) {
        jQuery.messager.alert('提示', '保存成功！', 'info');
        CloseDialog();
        if (window.top != window.self) {
            parent.GetCurrentFrame().ReloadData();
        }
    } else {
        jQuery.messager.alert('提示', '保存失败：' + msg.message, 'info');
        return false;
    }
}

//提前之前加载事件
MyForm.onBeforeSubmit = function () {
    if (typeof (MyFormBeforeSubmit) == 'function') {
        return MyFormBeforeSubmit();
    }
    return true;
}

MyForm.CancelDialog = function () {
    CloseDialog();
}

jQuery(function () {
    jQuery("#btnSubmit").click(function () {
        MyForm.SubmitForm();
        return false;
    });
});