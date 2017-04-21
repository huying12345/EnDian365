jQuery(function () {
    if (Data.Height == 0) {
        window.onresize = setGridHeight;
    }

    if (Data.UnAutoLoadGrid == 0) {
        LoadGrid();
    }
});

function LoadGrid() {
    jQuery('#tt').datagrid({
        url: Data.DataUrl,
        title: '',
        fitColumns: false, // 设置横向滚动条没有，宽度永远只有那么大
        striped: true, // 行是否隔行换样式
        pagination: Data.PageSize > 0 ? true : false, // 显示分页
       // height: Data.Height,
        pageSize: Data.PageSize,
        pageList: [10, 20, 30, 40, 50, 100],
        nowrap: true,
        loadMsg: '数据加载中，请稍等...', // 显示加载信息
        rownumbers: true, // 显示序号
        singleSelect: Data.singleSelect, // 单选一行
        remoteSort: true,
        idField: Data.PrimaryKey,
        frozenColumns: Data.frozenColumns,
        columns: Data.columns,
        onBeforeLoad: function (row, param) {
            if (Data.UnAutoLoad == 1) {
                return false;
            }
            jQuery(this).datagrid('uncheckAll');
        },
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
            Grid_DblClickRow(rowIndex, rowData);
        },
        onClickRow: function (rowIndex, rowData) {
            if (typeof (Grid_ClickRow_My) == 'function') {
                Grid_ClickRow_My(rowIndex, rowData);
            }
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
    if (Data.Height == 0) {
       // setGridHeight();
    }
    jQuery("#p").css("height", jQuery("#searchtable").css("height") + 100);
    jQuery("#p").css("width", jQuery("#searchtable").css("width") + 100);
    jQuery("#btnSubmit").click(function () {
        SubmitSearchForm();
    });
    jQuery("#btnReset").click(function () {
        jQuery('#searchForm').form("clear");
    });

    if (Data.UnAutoLoad == 1) {
        SubmitSearchForm();
    }
    BindBatchCheck();
}

function SubmitSearchForm() {
        Data.UnAutoLoad = 0;
        //查询设置当前页码为1
        var p = jQuery('#tt').datagrid('getPager');
        if (p) {
            jQuery(p).pagination({ pageNumber: 1 });
        }
        jQuery('#tt').datagrid("options").url = Data.DataUrl+"&"
					    								+ GetBaseUrl(Data.BaseUrl, '#searchForm')
					    								+ "&"
					    								+ jQuery('#searchForm').formSerialize();

        jQuery('#tt').datagrid('reload');
   
}

function BindBatchCheck() {
    var p = jQuery('#tt').datagrid('getPager');
    if (p) {
        jQuery(p).pagination({
            buttons: '#PagerButtons'
        });
    }
    $("#BatchCheck").change(function () {
        jQuery('#tt').datagrid("options").singleSelect = !($(this).prop('checked'));
    });
}