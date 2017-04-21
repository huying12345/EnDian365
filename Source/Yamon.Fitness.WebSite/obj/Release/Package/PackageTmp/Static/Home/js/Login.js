var loginViewModel = function () {
    var self = this;
    self.check = function () {
        if (jQuery("#txtName").val() == "") {
            alert("请输入用户名！");
            jQuery("#txtName").focus();
            return false;
        }
        if (jQuery("#txtPwd").val() == "") {
            alert("请输入登录密码！");
            jQuery("#txtPwd").focus();
            return false;
        }
        return true;
    };
    self.loginClick = function() {
        jQuery("#btn_login").bind("click", function() {
            if (self.check()) {
                var sName = jQuery("#txtName").val();
                var sPwd = jQuery("#txtPwd").val();
                jQuery.ajax({
                    url: '/api/UCenter/User/Login',
                    type: 'POST',
                    dataType: 'Json',
                    data: { "username": sName, "password": sPwd },
                    timeout: 20000,
                    success: function(data) {
                        if (data.success) {
                            location.href = 'Index';
                        } else {
                            alert(data.message);
                            if ((data.message).indexOf('密码') != -1) {
                                jQuery("#txtPwd").focus();
                            } else {
                                jQuery("#txtName").focus();
                            }
                        }
                    },
                    error: function(error) {
                    }
                });
            }
        });
    };
    self.enterToSubmit=function() {
        jQuery(document).keydown(function (event) {
            event = event ? event : window.event;
            event.keyCode == 13 ? jQuery("#btn_login").click() : null;
        });
    }
    self.init = function () {
        self.loginClick();
        self.enterToSubmit();
    }
};
