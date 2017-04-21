function setGridHeight() {
    var w = (window.innerWidth || (window.document.documentElement.clientWidth
			|| window.document.body.clientWidth || document.body.offsetWidth));
    var h = (window.innerHeight || (window.document.documentElement.clientHeight
			|| window.document.body.clientHeight || document.body.offsetHeight));
    //jQuery('#tt').datagrid('resize', {// 给datagrid加属性
    //    height: h-80,
    //    width: '100%',
    //    margin: 'auto'
    //});
}

function getSelectNameFileds() {
    if (Data.FieldShowType_Name_FieldName) {
        return getSelectFields(Data.FieldShowType_Name_FieldName);
    } else {
        return getSelectIds();
    }
}

function getSelectNameFiled() {
    if (Data.FieldShowType_Name_FieldName) {
        return getSelectField(Data.FieldShowType_Name_FieldName);
    } else {
        return getSelectId();
    }
}

function getFieldShowType_Name_Title() {
    if (Data.FieldShowType_Name_Title) {
        return Data.FieldShowType_Name_Title;
    } else {
        return 'ID';
    }
}

function getSelectNameFiled() {
    if (Data.FieldShowType_Name_FieldName) {
        return getSelectField(Data.FieldShowType_Name_FieldName);
    } else {
        return getSelectId();
    }
}
// 选中一行
function getSelectField(fieldName) {
    var ids = [];
    var rows = $('#tt').datagrid('getChecked');
    if (rows == null || rows.length < 1) {
        jQuery.messager.alert('提示', '至少请勾选一行！', 'info');
        return;
    } else if (rows.length > 1) {
        jQuery.messager.alert('提示', '只能勾选一行！', 'info');
        return;
    } else {
        for (var i = 0; i < rows.length; i++) {
            ids.push(rows[i][fieldName]);
        }
    }
    return ids.join(",");
}

// 选中多行
function getSelectFields(fieldName) {
    var ids = [];
    var rows = $('#tt').datagrid('getChecked');
    if (rows == null || rows.length < 1) {
        jQuery.messager.alert('提示', '至少请勾选一行！', 'info');
        return;
    } else {
        for (var i = 0; i < rows.length; i++) {
            ids.push(rows[i][fieldName]);
        }
    }
    return ids.join(",");
}
// 选中一行
function getSelectId() {
    var ids = [];
    var rows = $('#tt').datagrid('getChecked');
    if (rows == null || rows.length < 1) {
        jQuery.messager.alert('提示', '请勾选一行！', 'info');
        return;
    } else if (rows.length > 1) {
        jQuery.messager.alert('提示', '只能勾选一行！', 'info');
        return;
    } else {
        for (var i = 0; i < rows.length; i++) {
            ids.push(rows[i][Data.PrimaryKey]);
        }
    }
    return ids.join(",");
}
// 选中多行
function getSelectIds() {
    var ids = [];
    var rows = $('#tt').datagrid('getChecked');
    if (rows == null || rows.length < 1) {
        jQuery.messager.alert('提示', '至少请勾选一行！', 'info');
        return;
    } else {
        for (var i = 0; i < rows.length; i++) {
            ids.push(rows[i][Data.PrimaryKey]);
        }
    }
    return ids.join(",");
}

// 栏隐显右键菜单
function createColumnMenu() {
    var fields = $('#tt').datagrid('getColumnFields');

    var tmenu = $('<div id="tmenu" style="width:100px;"></div>').appendTo(
			'body');
    var html = "";
    for (var i = 0; i < fields.length; i++) {
        if (i == 15 && fields.length > 15) {
            html += "<div><span>更多...</span><div style=\"width:150px;\">";
        }
        var iconCls = 'icon-ok';
        var obj = $('#tt').datagrid('getColumnOption', fields[i]);
        if (obj.hidden) {
            iconCls = 'icon-empty';
        }
        html += '<div iconCls="' + iconCls + '" id="columnMenu_' + fields[i] + '">' + obj.title + '</div>';
    }
    if (fields.length > 15) {
        html += "</div></div>";
    }
    tmenu.append(html);
    tmenu.menu({
        onClick: function (item) {
            if (item.iconCls == 'icon-ok') {
                jQuery('#tt').datagrid('hideColumn',
						item.id.replace("columnMenu_", ""));
                tmenu.menu('setIcon', {
                    target: item.target,
                    iconCls: 'icon-empty'
                });
            } else {
                jQuery('#tt').datagrid('showColumn',
						item.id.replace("columnMenu_", ""));
                tmenu.menu('setIcon', {
                    target: item.target,
                    iconCls: 'icon-ok'
                });
            }
        }
    });
}


// 重新加载数据
function ReloadData() {
    jQuery('#tt').datagrid('reload');
    jQuery('#tt').datagrid('unselectAll');
}

function GetBaseUrl(baseUrl, formId) {
    baseUrl = 'test.html?' + baseUrl.substring(1);
    var baseUrlObj = jQuery.query.load(baseUrl);
    var fieldList = jQuery(formId).formToArray();
    for (var i = 0; i < fieldList.length; i++) {
        if (baseUrlObj.get(fieldList[i].name) != undefined) {
            baseUrlObj = baseUrlObj.remove(fieldList[i].name);
        }
    }
    return "&"+baseUrlObj.toString().substring(1);
}