
function addTab(subtitle, url, frameName,isReload) {
    if (!$('#tabs').tabs('exists', subtitle)) {
        $('#tabs').tabs('add', {
            title: subtitle,
            content: createFrame(url, frameName),
            closable: true
        });
    } else {
        $('#tabs').tabs('select', subtitle);
        if (isReload == undefined) {
            isReload = true;
        }
        if (isReload) {
            GetCurrentFrame().location.href = url;
        }
    }
    tabClose();
}

function tabClose() {
    /*双击关闭TAB选项卡*/
    $(".tabs-inner").dblclick(function () {
        var subtitle = $(this).children("span").text();
        $('#tabs').tabs('close', subtitle);
    })

    $(".tabs-inner").bind('contextmenu', function (e) {
        $('#mm').menu('show', {
            left: e.pageX,
            top: e.pageY
        });

        var subtitle = $(this).children("span").text();
        $('#mm').data("currtab", subtitle);

        return false;
    });
}
//绑定右键菜单事件
function tabCloseEven() {
    //关闭当前
    $('#mm-tabclose').click(function () {
        var currtab_title = $('#mm').data("currtab");
        $('#tabs').tabs('close', currtab_title);
    })
    //关闭除当前之外的TAB
    $('#mm-tabcloseother').click(function () {
        var currtab_title = $('#mm').data("currtab");
        $('.tabs-inner span').each(function (i, n) {
            var t = $(n).text();
            if (t != currtab_title)
                $('#tabs').tabs('close', t);
        });
    });
    //关闭当前右侧的TAB
    $('#mm-tabcloseright').click(function () {
        var nextall = $('.tabs-selected').nextAll();
        if (nextall.length == 0) {
            alert('后边没有啦~~');
            return false;
        }
        nextall.each(function (i, n) {
            var t = $('a:eq(0) span', $(n)).text();
            $('#tabs').tabs('close', t);
        });
        return false;
    });
    //关闭当前左侧的TAB
    $('#mm-tabcloseleft').click(function () {
        var prevall = $('.tabs-selected').prevAll();
        if (prevall.length == 0) {
            alert('到头了，前边没有啦~~');
            return false;
        }
        prevall.each(function (i, n) {
            var t = $('a:eq(0) span', $(n)).text();
            $('#tabs').tabs('close', t);
        });
        return false;
    });
}

function GetCurrentFrame() {
    if (jQuery('#tabs').length == 0) {
        return this;
    } else {
        var refreshTab = $('#tabs').tabs("getSelected");
        if (refreshTab && refreshTab.find('iframe').length > 0) {
            return refreshTab.find('iframe')[0].contentWindow;
        }
    }
}


//打开窗体
function OpenDialog(url, options) {
    if (window.top == window.self) {
        options.content = '<iframe id="iFrameUrl" name="iFrameUrl" frameborder="0" src="' + url + '" style="width: 100%; height: 100%;"></iframe>';
        jQuery('#dialogDiv').window(options);
        jQuery('#dialogDiv').window('center');
        jQuery('#dialogDiv').window('open');
        //frames["iFrameUrl"].location = url;
    } else {
        parent.OpenDialog(url, options);
    }
}

//打开内容对话框
function OpenContentDialog(title, content, width, height) {
    jQuery('#dialogDiv').window({
        title: title,
        content: content,
        width: width,
        height: height,
        modal: true,
        shadow: true,
        closed: true,
        resizable: false,
        minimizable: false,
        maximizable: false,
        collapsible: false,
        buttons: [{
            text: '关闭 ',
            iconCls: 'icon-cancel',
            handler: function () {
                jQuery('#dialogDiv').window('close');
            }
        }]
    });
    jQuery('#dialogDiv').window('center');
    jQuery('#dialogDiv').window('open');

}

function OpenMyDialog(url, title, width, height) {
    OpenDialog(url, {
        title: title,
        width: width,
        height: height,
        modal: true,
        shadow: true,
        closed: true,
        resizable: false,
        minimizable: false,
        maximizable: false,
        collapsible: false
    });
}

//关闭窗口
function CloseDialog() {
    if (window.top == window.self) {
        try {
            jQuery('#dialogDiv').window('close');
        } catch (e) {
        }
    } else {
        parent.CloseDialog();
    }
}

//弹出信息窗口 title:标题 msgString:提示信息 msgType:信息类型 [error,info,question,warning]
function msgShow(title, msgString, msgType) {
    jQuery.messager.alert(title, msgString, msgType);
}

function createFrame(url, frameName) {
    var s = '<iframe name="' + frameName + '" scrolling="auto" frameborder="0"  src="' + url + '" style="width:100%;height:100%"></iframe>';
    return s;
}


//打开窗体
function OpenThisDialog(url, options) {
    options.content = '<iframe id="iFrameUrl" name="iFrameUrl" frameborder="0" src="' + config.ResourcesPath + 'loading.htm" style="width: 100%; height: 100%;"></iframe>';
    jQuery('#dialogDiv').window(options);
    jQuery('#dialogDiv').window('center');
    jQuery('#dialogDiv').window('open');
    frames["iFrameUrl"].location = url;
}

function OpenThisMyDialog(url, title, width, height) {
    OpenThisDialog(url, {
        title: title,
        width: width,
        height: height,
        modal: true,
        shadow: true,
        closed: true,
        resizable: false,
        minimizable: false,
        maximizable: false,
        collapsible: false
    });
}

//关闭窗口
function CloseThisDialog() {
    jQuery('#dialogDiv').window('close');
}