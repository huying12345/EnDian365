var SubPlan = {
    subPlanId: '#SubPlanId',
    subPlanDesc: '#SubPlanDesc',
    //增加按钮
    init: function (subPlanId, subPlanDesc) {
        this.subPlanId = subPlanId;
        this.subPlanDesc = subPlanDesc;
        var html = '<a href="javascript:void(0)" class="easyui-linkbutton" onclick="SubPlan.SetSubPlan()">设置周期</a>';
        jQuery(this.subPlanDesc).after(html);
        jQuery('.linkbutton,.easyui-linkbutton').linkbutton();
    },
    //设置周期
    SetSubPlan: function () {
        var url = "/SiteManage/SubPlan/";
        if (jQuery(this.subPlanId).val() > 0) {
            url += 'Edit/' + jQuery(this.subPlanId).val();
        } else {
            url += "Create?GetNewID=1";
        }
        OpenThisMyDialog(url, '设置周期', 600, 300);
    },
    UpdateSubPlan: function (planId, title) {
        jQuery(this.subPlanId).val(planId);
        jQuery(this.subPlanDesc).val(title);
    }
};