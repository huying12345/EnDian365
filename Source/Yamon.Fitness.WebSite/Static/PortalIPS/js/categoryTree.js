var parentId = "FoundationBusiness";
jQuery(function () {
    if (navigator.userAgent.indexOf("MSIE") > 0) {
        jQuery('.sjjk_list').css('paddingLeft', '5px');
    }
    resizeWin();
    window.onresize = resizeWin;
    jQuery("#btnToggleMenu").click(function () {
        parent.toggleMenu();
    });


    jQuery("#categorytree").tree(
    {
        lines: true,
        url: "/api/PortalIPS/Category/GetMyCategoryTreeJsonAction?ShowRoot=1",
        animate: true,
        onClick: function (node) {
            if (node.id != "") {
                if (node.attributes.BackNvarchar2 == '外部链接') {
                    parent.addTab(node.text, node.attributes.ManageLinkUrl);
                    return;
                }
                if (node.attributes.BackNvarchar2 == '映射栏目') {
                    alert('映射栏目不可编辑');
                    return;
                }
                if (node.attributes.CategoryInfoType == "LinkInfo") {
                    parent.addTab(node.text, "/PortalIPS/PLinks/Grid1?Menu=SMB_Menu_Information&CategoryID=" + node.id);
                } else if (node.attributes.CategoryInfoType == "MailInfo") {
                    parent.addTab(node.text, "/PortalIPS/MailBox/Grid1?Menu=ReplyDisplay&CategoryID=" + node.id);
                } else if (node.attributes.CategoryInfoType == "VoteInfo") {
                    parent.addTab(node.text, "/PortalIPS/Vote/Grid1?Menu=Vote_List&CategoryID=" + node.id);
                } else {
                    parent.addTab(node.text, "/PortalIPS/vwInfoCategory/Grid1?Menu=05e2c21c-b486-4f46-923d-e0432f0e27f7&CategoryID=" + node.id);
                }
            } else {
                parent.addTab(node.text, "/PortalIPS/vwInfoCategory/Grid1?Menu=vwInfoCategory&ModuleID=PortalIPS");
            }
        },
        onLoadSuccess: function (node, data) {
            console.log(data);
            jQuery("#categorytree").tree('collapseAll');
            jQuery("#categorytree").tree('expand', jQuery("#categorytree").tree("getRoot").target);
        },
        onLoadError: function () {
        }

    });
    jQuery("#expandAll").click(function () {
        jQuery("#categorytree").tree('expandAll');
    });
    jQuery("#collapseAll").click(function () {
        jQuery("#categorytree").tree('collapseAll');
    });
    jQuery("#AppID").change(function () {
        location.href = "PortalIPS.aspx?m=categorytree&AppID=" + jQuery(this).val();
    });
});
function resizeWin() {
    var bodyHeight = jQuery(window).height(); //浏览器当前窗口文档body的高度
    var bodyWidth = jQuery(window).width();
    jQuery(".sjjk_left").css("height", bodyHeight);
    jQuery(".sjjk_con").css("height", bodyHeight + 5);
}
