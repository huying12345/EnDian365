$(function(){jQuery("#Contactsubmit").click(function(){var e=jQuery("#GuestName").val();if(""==e)return alert("请输入姓名！"),void jQuery("#GuestName").focus();var t=jQuery("#GuestEmail").val();if(""==t)return alert("请输入邮件地址！"),void jQuery("#GuestEmail").focus();if(0==/^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+((\.[a-zA-Z0-9_-]{2,3}){1,2})$/.test(t))return alert("邮箱格式错误！"),void jQuery("#GuestEmail").focus();var u=jQuery("#GuestContent").val();return""==u?(alert("请输入内容！"),void jQuery("#GuestContent").focus()):void jQuery("#ContactForm").ajaxSubmit({type:"post",dataType:"json",url:"/api/PortalIPS/GuestBook/InsertGuestBook",success:function(e){e.success?(alert("提交成功！"),window.location.reload()):alert("提交失败！"+e.message)},error:function(){}})})});