$(function () {
    jQuery('#myRoleID').val(jQuery('#RoleID').val());
    $('#tt').treegrid({
        iconCls: 'icon-save',
        checkbox: false,
        nowrap: false,
        rownumbers: true,
        singleSelect: true, //单选一行
        animate: true,
        collapsible: true,
        //height: 200,
        idField: 'MenuID',
        treeField: 'MenuName',
        columns: [
            [
                { field: 'MenuID', title: 'ID', sortable: true, width: 100, hidden: true },
                { field: 'PageCode', title: '权限', sortable: true, width: 30 },
                { field: 'MenuName', title: '菜单名称', sortable: true, width: 300 },
                { field: 'ToolBar', title: '工具栏权限', sortable: true, width: 400 }
            ]
        ],
        onBeforeLoad: function (row, param) {
            jQuery(this).treegrid('options').url = _DataUrl;
        },
        toolbar: '#toolbar'
    });

    setGridHeight();
    window.onresize = setGridHeight;
});

var options = {
    type: 'post',
    dataType: 'json',
    url: "/api/UCenter/Role/SetRolePurview",
    success: function (msg) {
        if (msg.success) {
            alert("保存成功");
        } else {
            alert("保存失败：" + msg.message);
        }
    },
    error: function (error) {
        jQuery.messager.alert('提示', '保存失败：' + error.toString(), 'info');
        return false;
    }
};

function goBack() {
    location.href = '/UCenter/Role/Grid1?&Frame=1&Menu=Role_List';
}
//保存数据
function saveData(id) {
    jQuery("#myForm").ajaxSubmit(options);
    return false;
}

//全选
function selectAll() {
    jQuery("td").find("input[name=Purview]").each(function () {
        jQuery(this).prop("checked", true);
    });
}

//反选
function unSelect() {
    jQuery("td").find("input[name=Purview]").each(function () {
        if ($(this).prop("checked")) {
            $(this).prop("checked", false);
        } else {
            $(this).prop("checked", true);
        }
    });
}

//不选
function noSelect() {
    jQuery("td").find("input[name=Purview]").each(function () {
        jQuery(this).prop("checked", false);
    });
}

function setPurview(obj) {
    var checked = jQuery(obj).prop("checked");
    jQuery(obj).parent().parent().siblings("td").find("input").prop("checked", checked);
    var parentPath = jQuery(obj).attr("ParentPath");
    var allChildId = jQuery(obj).attr("AllChildID");
    if (checked) {
        if (parentPath != "") {
            var arrParentId = parentPath.split(',');
            for (var i = 0; i < arrParentId.length; i++) {
                jQuery('#Purview' + arrParentId[i]).prop("checked", checked);
                setToolPurview1('#Purview' + arrParentId[i]);
            }
        }
    }

    if (allChildId != '') {
        var arrChildId = allChildId.split(',');
        for (var i = 0; i < arrChildId.length; i++) {

            jQuery('#Purview' + arrChildId[i]).prop("checked", checked);

            setToolPurview1('#Purview' + arrChildId[i]);
        }
    }
}

function setToolPurview1(obj) {
    if (jQuery(obj).prop('checked')) {
        jQuery(obj).parent().parent().siblings("td").find("input").prop("checked", jQuery(obj).prop('checked'));
    } else {
        jQuery(obj).parent().parent().siblings("td").find("input").prop("checked", false);
    }
}

function setToolPurview(obj) {
    if (jQuery(obj).prop("checked")) {
        jQuery(obj).parent().parent().siblings("td").find("input").prop("checked", true);
    }
}

function roleChange() {
    location.href = "SetRolePurview?Frame=1&RoleID=" + jQuery('#myRoleID').val();
}