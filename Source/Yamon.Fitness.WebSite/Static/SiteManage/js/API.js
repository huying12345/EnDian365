function CreateAPI() {
    Data.CreateUrl = _baseUrl + '/Create?APIType=1&' + _pageUrl;
    Data.DialogWidth = 900;
    Data.DialogHeight = 600;
    OpenDialog_InsertForm();
}

function CreateAPIType() {
    Data.DialogWidth = 500;
    Data.DialogHeight = 300;
    Data.CreateUrl = _baseUrl + '/Create?APIType=0&' + _pageUrl;
    OpenDialog_InsertForm();
}

function CreateAPIDoc() {
    Data.CreateUrl = _baseUrl + '/Create?APIType=2&' + _pageUrl;
    Data.DialogWidth = 900;
    Data.DialogHeight = 600;
    OpenDialog_InsertForm();
}

function APIExportToExcel() {
    var ids = getSelectIds();
    if (ids == "" || ids == undefined)
        return;
    window.open("/api/SiteManage/API/ExportToExcel/" + ids);
}
