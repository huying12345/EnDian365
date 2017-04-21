$(function () {
    jQuery("#Contactsubmit").click(function () {
        var GuestName = jQuery("#GuestName").val();
        if (GuestName == "") {
            alert('请输入姓名！');
            jQuery("#GuestName").focus();
            return;
        }

        var GuestEmail = jQuery("#GuestEmail").val();
        //邮件验证
        if (GuestEmail == "") {
            alert('请输入邮件地址！');
            jQuery("#GuestEmail").focus();
            return;
        } else if (/^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+((\.[a-zA-Z0-9_-]{2,3}){1,2})$/.test(GuestEmail) == false) {
            alert('邮箱格式错误！');
            jQuery("#GuestEmail").focus();
            return;
        }

        var GuestContent = jQuery("#GuestContent").val();
        if (GuestContent == "") {
            alert('请输入内容！');
            jQuery("#GuestContent").focus();
            return;
        }

        jQuery("#ContactForm").ajaxSubmit({
            type: 'post',
            dataType: 'json',
            url: "/api/PortalIPS/GuestBook/InsertGuestBook",
            success: function (msg) {
                if (msg.success) {
                    alert("提交成功！");
                    window.location.reload();
                } else {
                    alert("提交失败！" + msg.message);
                }
            },
            error: function (error) {

            }
        });

    });
});
