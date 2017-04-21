function setGridHeight() {
    var w = (window.innerWidth || (window.document.documentElement.clientWidth
			|| window.document.body.clientWidth || document.body.offsetWidth));
    var h = (window.innerHeight || (window.document.documentElement.clientHeight
			|| window.document.body.clientHeight || document.body.offsetHeight));
    
    //jQuery('#tt').treegrid('resize', {// 给treegrid加属性
    //    height: h - 80,
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
    var rows = $('#tt').datagrid('getSelections');
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
    var rows = $('#tt').datagrid('getSelections');
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
    var rows = $('#tt').treegrid('getSelections');
    if (rows == null || rows.length < 1) {
        jQuery.messager.alert('提示', '至少请选择一行！', 'info');
        return;
    } else if (rows.length > 1) {
        jQuery.messager.alert('提示', '只能选择一行！', 'info');
        return;
    } else {
        if (rows) {
            var selected = $('#tt').treegrid('getSelected');
            if (selected) {
                return selected[Data.PrimaryKey];
            }
        }
    }
    return "";
}
// 选中多行
function getSelectIds() {
    var ids = [];
    var rows = $('#tt').treegrid('getSelections');
    if (rows == null || rows.length < 1) {
        jQuery.messager.alert('提示', '至少请选择一行！', 'info');
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
    var tmenu = $('<div id="tmenu" style="width:100px;"></div>').appendTo(
			'body');
    var fields = $('#tt').treegrid('getColumnFields');
    for (var i = 0; i < fields.length; i++) {
        $('<div iconCls="icon-ok"/>').attr("id", "columnMenu_" + fields[i])
				.html($('#tt').treegrid('getColumnOption', fields[i]).title)
				.appendTo(tmenu);
    }
    tmenu.menu({
        onClick: function (item) {
            if (item.iconCls == 'icon-ok') {
                jQuery('#tt').treegrid('hideColumn',
						item.id.replace("columnMenu_", ""));
                tmenu.menu('setIcon', {
                    target: item.target,
                    iconCls: 'icon-empty'
                });
            } else {
                jQuery('#tt').treegrid('showColumn',
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
    jQuery('#tt').treegrid('reload');
    jQuery('#tt').treegrid('unselectAll');
}