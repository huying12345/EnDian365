jQuery(function () {
    jQuery('#searchForm').append('<input type="checkbox" id="ShowChild" name="ShowChild"  value="1" onclick="SubmitSearchForm();" /><label for="ShowChild">显示下级栏目</label>');
});

// 新窗口打开新增窗体
function Location_MyInsertForm() {
    location.href = Data.CreateUrl.replace('/vwInfoCategory/', '/SMB_Information/');
}

// 弹窗打开修改窗体
function Location_MyUpdateForm(categoryId, infoguid) {
    location.href = Data.BaseUrl.replace('/vwInfoCategory', '/SMB_Information') + "/Edit/" + infoguid + "?CategoryID=" + categoryId;
}

// 批量删除数据
function MyMutiDelete() {
    var id = getSelectIds();
    if (id == "" || id == undefined)
        return;
    jQuery.messager.confirm('Confirm', '确定要删除选中的信息吗?', function (r) {
        if (r) {
            jQuery.ajax({
                type: 'post',
                dataType: 'json',
                url: '/api/PortalIPS/SMB_Information/DelAction?' + _pageUrl.replace('&ModelID=vwInfoCategory', '&ModelID=SMB_Information'),
                data: { "ids": id },
                success: function (msg) {
                    if (msg.success) {
                        alert("删除成功！");
                        ReloadData();
                    } else {
                        alert("删除失败：" + msg.message);
                        return;
                    }
                }
            });
        }
    });
}

function Check(categoryId, infoguid) {
    location.href = Data.BaseUrl.replace('/vwInfoCategory', '/SMB_Information') + "/Edit/" + infoguid + "?CategoryID=" + categoryId + "&ShowAudit=1";
}

function Audit(categoryId, infoguid) {
    location.href = Data.BaseUrl.replace('/vwInfoCategory', '/SMB_Information') + "/Edit/" + infoguid + "?CategoryID=" + categoryId + "&ShowAudit=2";
}

// 重审数据
function ReAudit(categoryId, infoguid) {

    jQuery.messager.confirm('Confirm', '确定要重新审核此信息吗?', function (r) {
        if (r) {
            jQuery.ajax({
                type: 'post',
                dataType: 'text',
                url: '/PortalIPS/Info/ReAuditAction',
                data: { "CategoryID": categoryId, "InfoGuid": infoguid },
                success: function (msg) {
                    if (msg == "1") {
                        alert("重审成功！");
                        ReloadData();
                    } else {
                        alert("重审失败：" + msg);
                        return;
                    }
                }
            });
        }
    });
}

function InfoToTop() {
    var id = getSelectId();
    if (id == "" || id == undefined)
        return;
    jQuery.messager.confirm('Confirm', '确定要置顶选中信息吗?', function (r) {
        if (r) {
            jQuery.ajax({
                type: 'post',
                dataType: 'text',
                url: '/PortalIPS/Info/ToTopAction?' + _pageUrl,
                data: { "InfoGuid": id },
                success: function (msg) {
                    if (msg == "1") {
                        alert("操作成功！");
                        ReloadData();
                    } else {
                        alert("操作失败：" + msg);
                        return;
                    }
                }
            });
        }
    });
}
function ToBold() {
    var id = getSelectIds();
    if (id == "" || id == undefined)
        return;
    jQuery.messager.confirm('Confirm', '确定要突出选中信息吗?', function (r) {
        if (r) {
            jQuery.ajax({
                type: 'post',
                dataType: 'text',
                url: '/PortalIPS/Info/ToBoldAction?' + _pageUrl,
                data: { "InfoGuid": id },
                success: function (msg) {
                    if (msg == "1") {
                        alert("操作成功！");
                        ReloadData();
                    } else {
                        alert("操作失败：" + msg);
                        return;
                    }
                }
            });
        }
    });
}
// 批量审核
function Checks() {

    var id = getSelectIds();
    if (id == "" || id == undefined)
        return;
    jQuery.messager.confirm('审核', '确定要审核选中信息吗(待审核的信息才可审核成功)?', function (r) {
        if (r) {
            jQuery.ajax({
                type: 'post',
                dataType: 'json',
                url: '/api/PortalIPS/SMB_Information/ChecksAction?' + _pageUrl,
                data: { "ids": id },
                success: function (msg) {
                    if (msg.result == "1") {
                        alert("操作成功！");
                        ReloadData();
                    } else {
                        alert("审核失败!" + msg.message);
                        return;
                    }
                }
            });
        }
    });
}

// 批量发布
function Audits() {
    var id = getSelectIds();
    if (id == "" || id == undefined)
        return;
    jQuery.messager.confirm('Confirm', '确定要批量发布选中信息吗(已审核的信息才可发布成功)?', function (r) {
        if (r) {
            jQuery.ajax({
                type: 'post',
                dataType: 'text',
                url: '/PortalIPS/Info/AuditsAction?' + _pageUrl,
                data: { "InfoGuid": id },
                success: function (msg) {
                    if (msg == "1") {
                        alert("操作成功！");
                        ReloadData();
                    } else {
                        alert("发布失败,可能选中信息状态不全是已审核!");
                        return;
                    }
                }
            });
        }
    });
}

//加粗
function ToUnBold() {
    var id = getSelectIds();
    if (id == "" || id == undefined)
        return;
    jQuery.messager.confirm('Confirm', '确定要取消突出选中信息吗?', function (r) {
        if (r) {
            jQuery.ajax({
                type: 'post',
                dataType: 'text',
                url: '/PortalIPS/Info/ToUnBoldAction?' + _pageUrl,
                data: { "InfoGuid": id },
                success: function (msg) {
                    if (msg == "1") {
                        alert("操作成功！");
                        ReloadData();
                    } else {
                        alert("操作失败：" + msg);
                        return;
                    }
                }
            });
        }
    });
}

//复制
function ToCopy() {
    var id = getSelectIds();
    if (id == "" || id == undefined)
        return;
    OpenMyDialog("/PortalIPS/Category/CategoryTreeDialog?myaction=CopyInfo&ID=" + id + '&' + _pageUrl, '复制信息', 300, 500);
}

//移动
function ToMove() {
    var id = getSelectIds();
    if (id == "" || id == undefined)
        return;
    OpenMyDialog("/PortalIPS/Category/CategoryTreeDialog?isCheckbox=0&myaction=MoveInfo&ID=" + id + '&' + _pageUrl, '移动信息', 300, 500);
}

//显示日志
function ShowLog() {
    var id = getSelectId();
    if (id == "" || id == undefined)
        return;
    OpenMyDialog("/SF/SiteManage/Log/Grid?FilterID=Log_LogKey&Model=PortalIPS_SMB_Information&LogKey=PortalIPS_SMB_Information_" + id, '日志信息', 800, 500);
}

//批量修改
function BatchEdit() {
    var id = getSelectIds();
    if (id == "" || id == undefined)
        return;
    OpenMyDialog("/SF/PortalIPS/vwInfoCategory/EditGrid?FilterID=vwInfoCategory_InfoGuid&CategoryID=1812386F-8021-4659-A3AA-3AFCC660EA74&ID=" + id, '批量修改', 700, 500);
}

//复制到区县站
function CopyToSite() {
    var id = getSelectIds();
    if (id == "" || id == undefined)
        return;
    OpenMyDialog("/PortalIPS/Info/CopyToSite?CategoryID=1812386F-8021-4659-A3AA-3AFCC660EA74&ID=" + id, '复制到区县站', 400, 500);
}
