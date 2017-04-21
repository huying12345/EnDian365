function Grid_DblClickRow(rowIndex, rowData) {
    if (typeof (Grid_DblClickRow_My) == 'function') {
        Grid_DblClickRow_My(rowIndex, rowData);
    } else {
        OpenDialog_ViewFormByID(rowData[Data.PrimaryKey]);
    }
}


// 获取指定行的值
function GetNameByID(id, json) {
    var data = eval(json);
    for (var i = 0; i < data.length; i++) {
        if (id == data[i].ID) {
            return data[i].Name;
        }
    }
    return id;
}

// 弹窗打开新增窗体
function OpenDialog_InsertForm() {
    OpenMyDialog(Data.CreateUrl, '新建' + Data.ItemName, Data.DialogWidth, Data.DialogHeight);
}

// 原页面打开新增窗体
function Location_InsertForm() {
    location.href = Data.CreateUrl;
}
// 新窗口打开新增窗体
function Open_InsertForm() {
    window.open(Data.CreateUrl);
}

// 弹窗打开修改窗体
function OpenDialog_UpdateFormByID(id) {
    if (id == "" || id == undefined)
        return;
    OpenMyDialog(Data.EditUrl.replace('{id}', id).replace('%7Bid%7D', id), '修改' + Data.ItemName, Data.DialogWidth, Data.DialogHeight);
}
// 原页面打开修改窗体
function Location_UpdateFormByID(id) {
    if (id == "" || id == undefined)
        return;
    location.href = Data.EditUrl.replace('{id}', id).replace('%7Bid%7D', id);
}

// 新窗口打开修改窗体
function Open_UpdateFormByID(id) {
    if (id == "" || id == undefined)
        return;
    window.open(Data.EditUrl.replace('{id}', id).replace('%7Bid%7D', id));
}

// 弹窗打开修改窗体
function OpenDialog_UpdateForm() {
    OpenDialog_UpdateFormByID(getSelectId());
}

function UpdateFormInRow(value, row, index) {
    return "<a href='javascript:void(0)' style='color:red;' onclick=\"OpenDialog_UpdateFormByID('" + row[Data.PrimaryKey] + "')\">修改</a>";
}

function UpdateLocationFormInRow(value, row, index) {
    return "<a href='javascript:void(0)' style='color:red;' onclick=\"Location_UpdateFormByID('" + row[Data.PrimaryKey] + "')\">修改</a>";
}
// 原页面打开修改窗体
function Location_UpdateForm() {
    Location_UpdateFormByID(getSelectId());
}

// 新窗口打开修改窗体
function Open_UpdateForm() {
    Open_UpdateFormByID(getSelectId());
}

// 弹窗打开数据
function OpenDialog_ViewFormByID(id) {
    if (id == "" || id == undefined)
        return;
    OpenMyDialog(Data.ShowUrl + id, '查看' + Data.ItemName, Data.DialogWidth, Data.DialogHeight);
}

// 原窗口打开查看页面
function Location_ViewFormByID(id) {
    location.href = Data.ShowUrl + id;
}
// 新窗口打开查看页面
function Open_ViewFormByID(id) {
    window.open(Data.ShowUrl + id);
}

// 弹窗打开数据
function OpenDialog_ViewForm() {
    OpenDialog_ViewFormByID(getSelectId());
}

// 原窗口打开查看页面
function Location_ViewForm() {
    Location_ViewFormByID(getSelectId());
}

// 新窗口打开查看页面
function Open_ViewForm() {
    Open_ViewFormByID(getSelectId());
}

// 批量删除数据
function BatchDeleteByID(id) {
    if (id == "" || id == undefined)
        return;
    jQuery.messager.confirm('Confirm', '确定要删除[ ' + Data.ItemName + getFieldShowType_Name_Title() + '为' + getSelectNameFileds()
			+ ' ]的信息吗?', function (r) {
			    if (r) {
			        jQuery.ajax({
			            type: 'post',
			            dataType: 'json',
			            url: Data.BatchDeleteUrl,
			            data: { "ids": id },
			            success: function (data) {
			                if (data.success) {
			                    alert("删除成功！");
			                    ReloadData();
			                } else {
			                    alert("删除失败：" + data.message);
			                    return;
			                }
			            }
			        });
			    }
			});
}

function MutiDelete() {
    BatchDelete();
}
// 批量删除
function BatchDelete() {
    BatchDeleteByID(getSelectIds());
}
function onDblClickRow() {

}
// 删除单条数据
function DeleteByID(id) {
    if (id == "" || id == undefined)
        return;
    jQuery.messager.confirm('Confirm', '确定要删除[ ' + Data.ItemName + getFieldShowType_Name_Title() + '为' + getSelectNameFiled()
			+ ' ]的信息吗?', function (r) {
			    if (r) {
			        jQuery.ajax({
			            type: 'post',
			            dataType: 'json',
			            url: Data.DeleteUrl,
			            data: { "ID": id },
			            success: function (data) {
			                if (data.success) {
			                    alert("删除成功！");
			                    ReloadData();
			                } else {
			                    alert("删除失败：" + data.msg);
			                    return;
			                }
			            }
			        });
			    }
			});
}
// 删除单条数据
function Delete() {
    DeleteByID(getSelectId());
}

//// 导出到Excel
function ExportToExcel() {
    ExportToExcel_All(0, 1);
}


// 导出到Excel,只导出列表和数据库中的值
function ExportToExcel_Entity() {
    ExportToExcel_All(0, 0);
}
// 导出到Excel，导出所有字段和数据库的值
function ExportToExcel_AllEntity() {
    ExportToExcel_All(1, 0);
}
// 导出到Excel，导出所有字段和显示的值
function ExportToExcel_AllList() {
    ExportToExcel_All(1, 1);
}
// 导出到Excel，导出列表字段和显示的值
function ExportToExcel_List() {
    ExportToExcel_All(0, 1);
}

// 导出到Excel
function ExportToExcel_All(showAllField, showValue) {
    var rows = Data.PageSize;
    var page = 1;
    var p = jQuery('#tt').datagrid('getPager');
    if (p) {
        rows = jQuery(p).pagination('options').pageSize;
        page = jQuery(p).pagination('options').pageNumber;
    }
    window.open(Data.ApiUrl + "/ExportToExcel?FilterID=" + Data.FilterID + "&page=" + page + "&rows=" + rows + "&showAllField=" + showAllField + "&ShowValue=" + showValue + GetBaseUrl(_pageUrl, '#searchForm') + "&" + jQuery('#searchForm').formSerialize());
}

// 导出到Excel
function ExportToExcel_Show_Fields(fields, showValue) {
    window.open(Data.ApiUrl + "/ExportToExcel?FilterID=" + Data.FilterID + "&showAllField=-1&Show_Fields=" + fields + "&ShowValue=" + showValue + GetBaseUrl(Data.BaseUrl, '#searchForm') + "&" + jQuery('#searchForm').formSerialize());
}
// 导出到Excel，导出列表字段和显示的值
function ExportToExcel_ListRow(rows) {
    ExportToExcel_AllRow(0, 1, rows);
}
// 导出到Excel
function ExportToExcel_AllRow(showAllField, showValue, rows) {
    window.open(Data.ApiUrl + "/ExportToExcel?FilterID=" + Data.FilterID + "&showAllField=" + showAllField + "&ShowValue=" + showValue + GetBaseUrl(Data.BaseUrl, '#searchForm') + "&rows=" + rows + "&" + jQuery('#searchForm').formSerialize());
}

// 从Excel导入
function ImportFromExcel() {
    OpenMyDialog(Data.BaseUrl + "/ImportFromExcel", '从Excel导入', 400, 240);
}

//导出到Word
function ExportToWord() {
    var id = getSelectId();
    if (id == "" || id == undefined)
        return;

    window.open(_baseUrl + '/ExportToWordAction/' + id);
}



//显示高级查询
function ShowSearchFrm(flag) {

    if (flag) {
        $('#p').panel('open');
    } else {
        $('#p').panel('close');
    }
}
function onDblClickRow() {

}
//排序与移动
function OpenEditTreeDialog(IsAsync) {
    if (IsAsync == 1) {
        OpenMyDialog(Data.BaseUrl + "/AsyncEditTree?" + _pageUrl, '排序移动' + Data.ItemName, 400, 500);
    } else {
        OpenMyDialog(Data.BaseUrl + "/EditTree?" + _pageUrl, '排序移动' + Data.ItemName, 400, 500);
    }
}