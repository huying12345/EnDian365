# 启用代码编译
```
Enable-RazorGenerator
```
# 每次通过代码生成器或其它外部程序修改过cshtml文件，都需要重新编译文件
```
Redo-RazorGenerator Yamon.Module.UCenter.Web;Redo-RazorGenerator Yamon.Module.App.Web;Redo-RazorGenerator Yamon.Module.SiteManage.Web;Redo-RazorGenerator Yamon.Module.Product.Web;Redo-RazorGenerator Yamon.Module.Member.Web;Redo-RazorGenerator Yamon.CoffeeCloud.WebSite

```

# 重新自动生成页面
在对应模块的AreaRegistration中增加`RegisterArea(AreaRegistrationContext context)`增加以下方法

```
SiteCommon.AddCustomPage("~/Areas/UCenter/Views/User/_/Create.cshtml", "~/Areas/UCenter/Views/User/Create.cshtml");

```

Install-Package RazorGenerator.Mvc -Version 2.4.2
Install-Package Microsoft.AspNet.Mvc.zh-Hans -Version 4.0.40804.0
Install-Package Newtonsoft.Json -Version 9.0.1

