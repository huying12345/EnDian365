//页面加载完就执行
$(function () {
    hljs.initHighlightingOnLoad();

    //为所有table标签添加bootstap支持的表格类
    $("table").addClass("table table-bordered table-hover");

    //超链接都在新窗口打开
    $('a[href^="http"]').each(function () {
        $(this).attr('target', '_blank');
    });

    $("table thead tr").css({ "background-color": "#08c", "color": "#fff" });

    $("table tr").each(function () {
        if ($(this).find("td").eq(1).html() == "object") {
            $(this).css({ "background-color": "#99CC99", "color": "#000" });
        }
    });

    $('li[data-apiid="' + myPage.APIID + '"]').addClass('active');
    $('li[data-apiid="' + myPage.APIID + '"]').parent('ul').parent('li').addClass('active');
    $('li[data-apiid="' + myPage.APIID + '"]').parent('ul').parent('li').parent('ul').parent('li').addClass('active');

    $('#side-menu').metisMenu({ toggle: false });
    //增加返回顶部按钮
    $.goup({
        trigger: 100,
        bottomOffset: 150,
        locationOffset: 100,
        title: '回到顶部',
        titleAsText: true,
        containerColor: "#08c"
    });
    if (myPage.APIType == 1) {
        InitRequestParam();
        if (myPage.IsTool == 0) {
            $('#Nav_DocIndex').addClass('active');
            var responseParamVal = $('#ResponseParam').val();
            if (responseParamVal != '') {
                var responsetList1 = $.parseJSON(responseParamVal);
                responsetList1.splice(0, 0, {
                    name: 'message',
                    title: '消息',
                    type: 'string',
                    desc: '描述',
                    children: []
                });
                responsetList1.splice(0, 0, {
                    name: 'success',
                    title: '是否成功',
                    type: 'bool',
                    desc: '成功为true,否则为false',
                    children: []
                });
            }
            $('#ResponseParam').val(JSON.stringify(responsetList1));
            InitErrorParam();
            InitResponseParam();
        } else {
            $('#Nav_APITool').addClass('active');
            InitApiToolForm();
        }
    }
    $('#btnLogin').click(function () {
        $.post('/api/UCenter/User/Login', { UserName: $('#UserName').val(), Password: $('#Password').val() }, function (result) {
            if (result.success) {
                self.location.href = self.location.href;
            } else {
                alert(result.message);
            }
        });
    });

    $('#AppList').change(function () {
        location.href = myPage.pageUrl + $('#AppList').val();
    });

    if (myPage.APIType == 2) {
        var testEditormdView = editormd.markdownToHTML("test-editormd-view2", {
            htmlDecode: "style,script,iframe",  // you can filter tags decode
            emoji: true,
            taskList: true,
            path: "/Resources/JsLib/",
            pluginPath: '/Resources/JsLib/editormd/plugins/',
            tocm: true,
            tex: true,  // 默认不解析
            flowChart: false,  // 默认不解析
            sequenceDiagram: false  // 默认不解析
        });
    }
});

function InitApiToolForm() {
    if ($.cookie('apitool_token')) {
        $('#Token').val($.cookie('apitool_token'));
        $('#ApiToolLoginMsg').text('当前登录用户：' + $.cookie('apitool_TrueName') + '(' + $.cookie('apitool_UserName') + ')');
    } else {
        $('#ApiToolLoginMsg').text('未登录，请先到登录接口执行登录功能');
    }
    //$("#APIForm").validate();
    var v = jQuery("#APIForm").validate({
        submitHandler: function (form) {
                jQuery(form).ajaxSubmit({
                    type: 'post',
                    dataType: 'text',
                    url: '/SiteManage/API/GetAPIContent',
                    success: function (data) {
                        if ($('input[name="Url"]').val() == '/api/UCenter/User/Login') {
                            eval('var result = ' + data + ';');
                            if (result.success) {
                                $.cookie('apitool_token', result.token);
                                $.cookie('apitool_TrueName', result.User.TrueName);
                                $.cookie('apitool_UserName', result.User.UserName);
                            }
                        } else if ($('input[name="Url"]').val() == '/api/Member/MemberInfo/MemberLogin') {
                            eval('var result = ' + data + ';');
                            if (result.success) {
                                $.cookie('apitool_token', result.token);
                            }
                        }
                        $('#result').html(data);
                        $('pre code').each(function (i, e) { hljs.highlightBlock(e) });
                    },
                    error: function (error) {
                        return false;
                    }
                });
        }
    });
  


}




