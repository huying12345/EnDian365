$.extend($.fn.datagrid.defaults.editors, {
    datetime: {
        init: function (container, options) {
            var input = $('<input type="text" class="Wdate" type="text" onClick="WdatePicker({dateFmt:\'' + options.format + '\'})">').appendTo(container);
            return input;
        },
        getValue: function (target) {
            return $(target).val();
        },
        setValue: function (target, value) {
            value = value.replace(/\//g, '-');
            $(target).val(value);
        },
        resize: function (target, width) {
            var input = $(target);
            if ($.boxModel == true) {
                input.width(width - (input.outerWidth() - input.width()));
            } else {
                input.width(width);
            }
        }
    },

    Select: {
        init: function (container, options) {
            var html = "<select>";
            for (var i = 0; i < options.data.length; i++) {
                html += '<option value="' + options.data[i].ID + '">' + options.data[i].Name + '</option>';
            }
            html += "</select>";
            var input = $(html).appendTo(container);
            return input;
        },
        getValue: function (target) {
            return $(target).val();
        },
        setValue: function (target, value) {
            $(target).val(value);
        },
        resize: function (target, width) {
            var input = $(target);
            if ($.boxModel == true) {
                input.width(width - (input.outerWidth() - input.width()));
            } else {
                input.width(width);
            }
        }
    },
    color: {
        init: function (container, options) {
            var input = $('<input type="text" class="datagrid-editable-input" />').appendTo(container);
            return input;
        },
        getValue: function (target) {
            return $(target).val();
        },
        setValue: function (target, value) {
            $(target).val(value);
            $(target).css('backgroundColor', value);
            $(target).ColorPicker({
                color: $(target).val(),
                onShow: function (colpkr) {
                    jQuery(colpkr).fadeIn(500);
                    return false;
                },
                onHide: function (colpkr) {
                    jQuery(colpkr).fadeOut(500);
                    return false;
                },
                onChange: function (hsb, hex, rgb) {
                    $(target).val('#' + hex);
                    $(target).css('backgroundColor', '#' + hex);
                }
            });
        },
        resize: function (target, width) {
            var input = $(target);
            if ($.boxModel == true) {
                input.width(width - (input.outerWidth() - input.width()));
            } else {
                input.width(width);
            }
        }
    }
});

var selectedRows = "";

jQuery(function () {
    window.onresize = setGridHeight;
    jQuery('#tt').edatagrid({
        url: Data.DataUrl,
        saveUrl: Data.QuickCreateActionUrl,
        updateUrl: Data.QuickEditActionUrl,
        destroyUrl: Data.DeleteUrl,
        //title: '$!{model.ModelName}',
        fitColumns: false, //设置横向滚动条没有，宽度永远只有那么大
        striped: true, //行是否隔行换样式
        pagination: Data.PageSize > 0 ? true : false, //显示分页
        pageSize: Data.PageSize,
        selectOnCheck: false,
        checkOnSelect: false,

        loadMsg: '数据加载中，请稍等...', //显示加载信息
        rownumbers: true, //显示序号
        singleSelect: true, //单选一行

        sortName: Data.SortField,
        sortOrder: Data.OrderType,
        remoteSort: true,

        idField: Data.PrimaryKey,
        frozenColumns: [[
	                { field: 'ck', checkbox: true },
                    {
                        field: 'operate', title: '操作', width: 65, align: 'center', formatter: function (value, row, index) {
                            if (row.editing) {
                                return "<a href='javascript:void(0)' style='color:red;' onclick='saverow(" + index + ")'>保存</a> <a href='javascript:void(0)' style='color:red;' onclick='cancelrow(" + index + ")'>取消</a>";
                            }
                            else {
                                return "<a href='javascript:void(0)' style='color:red;' onclick='editrow(" + index + ")'>编辑</a>";
                            }
                        }
                    }
        ]],
        columns: Data.columns,

        toolbar: Data.toolbar,
        onHeaderContextMenu: function (e, field) {
            e.preventDefault();
            if (!jQuery('#tmenu').length) {
                createColumnMenu();
            }
            jQuery('#tmenu').menu('show', {
                left: e.pageX,
                top: e.pageY
            });
        },
        onDblClickRow: function (rowIndex, rowData) {
            //editrow(rowIndex);
        },
        onBeforeEdit: function (index, row) {
            row.editing = true;
            EditActions();
            rowClick(index, row);
        },
        onAfterEdit: function (index, row) {
            row.editing = false;
            EditActions();
        },
        onCancelEdit: function (index, row) {
            row.editing = false;
            EditActions();
        },
        onClickRow: function (rowIndex) {
            //if (lastIndex != rowIndex){
            //    jQuery('#tt').datagrid('endEdit', lastIndex);
            //}
            //lastIndex=-1;

        },
        destroyMsg: {
            norecord: {	// when no record is selected
                title: 'Warning',
                msg: 'No record is selected.'
            },
            confirm: {	// when select a row
                title: 'Confirm',
                msg: 'Are you sure you want to delete?'
            }
        },
        onBeforeLoad: function () {
            $(this).datagrid('uncheckAll');
            $(this).datagrid('rejectChanges');
        },
        onLoadError: function () {
            $.messager.alert('加载数据出错', "加载数据出错", 'error');
        },
        onLoadSuccess: function (data) {
            if (data.total == "-1") {
                $.messager.alert('加载数据出错', data.msg, 'error');
            }
        }
    });

    setGridHeight();
    jQuery("#p").css("height", jQuery("#searchtable").css("height") + 100);
    jQuery("#p").css("width", jQuery("#searchtable").css("width") + 100);


    jQuery("#btnSubmit").click(function () {
        SubmitSearchForm();
    });

    jQuery("#btnReset").click(function () {
        jQuery('#searchForm').clearForm();
    });

    if (Data.UnAutoLoad == 1) {
        SubmitSearchForm();
    }

});

function SubmitSearchForm() {
    Data.UnAutoLoad = 0;
    //查询设置当前页码为1
    $('#tt').datagrid("options").url = Data.DataUrl + GetBaseUrl(Data.BaseUrl, '#searchForm') + "&" + jQuery('#searchForm').formSerialize();
    jQuery('#tt').datagrid('reload');
}

function rowClick(rowIndex) {

}
function EditActions() {
    var rowcount = $('#tt').datagrid('getRows').length;
    for (var i = 0; i < rowcount; i++) {
        $('#tt').datagrid('updateRow', {
            index: i,
            row: { operate: '' }
        });
    }
}

//修改行
function editrow(index) {
    jQuery('#tt').edatagrid('editRow', index);
}
function cancelrow(index) {
    $('#tt').edatagrid('cancelRow',index);
}
function saverow(index) {
    $('#tt').edatagrid('saveRow');
}
//新增
function OpenDialog_InsertForm() {
    $('#tt').edatagrid('addRow');
}