﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Yamon.Framework.Common;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/Test.cshtml")]
    public partial class _Views_Home_Test_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Home_Test_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Home\Test.cshtml"
  
    ViewBag.Title = "Test";
    Layout = "~/Views/Shared/_SimpleLayout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Test</h2>\r\n<button");

WriteLiteral(" onclick=\"PrintReport()\"");

WriteLiteral(">打印报表</button>\r\n<button");

WriteLiteral(" onclick=\" PrintProductLabel() \"");

WriteLiteral(">打印标签条码</button>\r\n<br/>\r\n\r\n<button");

WriteLiteral(" onclick=\"InitCard()\"");

WriteLiteral(">初始化卡</button>\r\n<input");

WriteLiteral(" id=\"CardSN\"");

WriteLiteral(" type=\"text\"");

WriteLiteral("/>\r\n<br/>\r\n<input");

WriteLiteral(" id=\"Money\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" />\r\n<button");

WriteLiteral(" onclick=\"RechargeToCard()\"");

WriteLiteral(">充值</button>\r\n");

DefineSection("scripts", () => {

WriteLiteral(@"
    <script>
        function PrintReport() {
            if (typeof (jsObj) == 'undefined') {
                alert('此功能只能在客户端下使用');
                return;
            }
            jsObj.PrintReport('20160824160838');
        }

        function PrintProductLabel() {
            if (typeof (jsObj) == 'undefined') {
                alert('此功能只能在客户端下使用');
                return;
            }
            jsObj.PrintProductLabel('10016', 100);
        }

        function InitCard() {
            if (typeof (cardEvent) == 'undefined') {
                alert('此功能只能在客户端下使用');
                return;
            }
            var cardNo = cardEvent.InitCard();
            $('#CardSN').val(cardNo);
        }

        function RechargeToCard() {
            if (typeof (cardEvent) == 'undefined') {
                alert('此功能只能在客户端下使用');
                return;
            }
            var money = $('#Money').val();
            var result = cardEvent.RechargeToCard(parseFloat(money), 10);
            alert(result);
        }
    </script>
");

});

        }
    }
}
#pragma warning restore 1591
