function check_frame(e){top.location==self.location&&(top.location.href=e)}function ShowTabs(e){var t=document.getElementById("TabTitle"+tID),n=document.getElementById("Tabs"+tID),c=document.getElementById("TabTitle"+e),o=document.getElementById("Tabs"+e);e!=tID&&(t.className="title1",c.className="title2",n.style.display="none",o.style.display="",tID=e)}function showtr(e){"1"==e?$("#clzshow").show():"2"==e&&$("#cwcshow").show()}function CheckAll(){for(var e=document.formlist.all.checked,t=0;t<document.formlist.elements.length;t++){var n=document.formlist.elements[t];"all"!=n.name&&(n.checked=e)}}function checkData(){for(var e=0,t=0;t<document.formlist.elements.length;t++){var n=document.formlist.elements[t];"all"!=n.name&&n.checked&&e++}return e?confirm("即将操作所有选择的记录， 是否继续 ？")?!0:!1:(alert("你还没选择记录！"),!1)}function Selectsource(e){var t;t=e,document.formlist.source.value=t,document.formlist.source.focus()}function Selectauthor(e){var t;t=e,document.formlist.author.value=t,document.formlist.author.focus()}function show(e){document.getElementById("dlqy").style.display=2==e?"block":"none",1==e?(document.getElementById("gsmc").style.display="block",document.getElementById("ywfw").style.display="block"):(document.getElementById("gsmc").style.display="none",document.getElementById("ywfw").style.display="none")}function changeselect1(e){for(document.formlist.ty.length=0,document.formlist.ty.options[0]=new Option("-请选择-",""),i=0;i<subcat.length;i++)subcat[i][0]==e&&(document.formlist.ty.options[document.formlist.ty.length]=new Option(subcat[i][1],subcat[i][2]))}function changeselect2(e){for(document.formlist.tty.length=0,document.formlist.tty.options[0]=new Option("-请选择-",""),n=0;n<subcat2.length;n++)subcat2[n][0]==e&&(document.formlist.tty.options[document.formlist.tty.length]=new Option(subcat2[n][1],subcat2[n][2]))}function changeselect3(e){for(document.formlist.cityid.length=0,document.formlist.cityid.options[0]=new Option("-请选择-",""),i=0;i<subcat.length;i++)subcat[i][0]==e&&(document.formlist.cityid.options[document.formlist.cityid.length]=new Option(subcat[i][1],subcat[i][2]))}function changeselect4(e){for(document.formlist.countyid.length=0,document.formlist.countyid.options[0]=new Option("-请选择-",""),n=0;n<subcat2.length;n++)subcat2[n][0]==e&&(document.formlist.countyid.options[document.formlist.countyid.length]=new Option(subcat2[n][1],subcat2[n][2]))}function changecats(e){for(document.formlist.ty.length=0,document.formlist.ty.options[0]=new Option("-请选择-",""),i=0;i<subcat3.length;i++)subcat3[i][0]==e&&(document.formlist.ty.options[document.formlist.ty.length]=new Option(subcat3[i][1],subcat3[i][2]))}function checkspace(e){var t="";for(i=0;i<e.length;i++)t+=" ";return t==e}function checkform(e){return checkspace(e.username.value)?(alert("请输入登录用户名!"),e.username.focus(),!1):checkspace(e.password.value)?(alert("请输入登录密码!"),e.password.focus(),!1):checkspace(e.door.value)?(alert("请输入验证码!"),e.door.focus(),!1):void 0}function checkform(){var e=document.forms[0].item("content");if(checkspace(e.value))return alert("留言内容是必填!"),!1;var t=document.forms[0].item("ansercontent");return checkspace(t.value)?(alert("回复内容是必填!"),!1):!0}function check_link(e){return checkspace(e.title.value)?(alert("请输入链接名称！"),e.title.focus(),!1):checkspace(e.linkurl.value)||"http://"==e.linkurl.value?(alert("请输入链接地址！"),e.linkurl.focus(),!1):void 0}function check_qq(e){return checkspace(e.title.value)?(alert("请输入客服名称！"),e.title.focus(),!1):checkspace(e.ftitle.value)?(alert("请输入QQ！"),e.ftitle.focus(),!1):void 0}function check_file(e){return checkspace(e.title.value)?(alert("请输入文件名称！"),e.title.focus(),!1):void 0}function check_ad(e){return checkspace(e.title.value)?(alert("请输入广告名称！"),e.title.focus(),!1):void 0}function checkcats(e){return checkspace(e.catname.value)?(alert("请输入类别名称！"),e.catname.focus(),!1):void 0}function ConfirmDelInfo(){return confirm("确定要删除此信息吗？删除后不能恢复！")?!0:!1}function ConfirmDelBig(){return confirm("确定要删除此一级分类吗？删除后不可恢复，请慎重操作！\n\n若分类名称有误，可点击修改按钮修改分类名字即可！\n")?!0:!1}function ConfirmDelSmall(){return confirm("确定要删除此二级分类吗？删除后不可恢复，请慎重操作！\n\n若分类名称有误，可点击修改按钮修改分类名字即可！\n")?!0:!1}function ConfirmDelSmall1(){return confirm("确定要删除此三级分类吗？删除后不可恢复，请慎重操作！\n\n若分类名称有误，可点击修改按钮修改分类名字即可！\n")?!0:!1}function selectad(e){var t;t=e;var n=e.split("|");document.formlist.adname.value=n[0],document.formlist.width.value=n[1],document.formlist.height.value=n[2],document.formlist.pid.value=n[3],document.formlist.ty.value=n[4]}function checkperson(e){return checkspace(e.pwd_old.value)?(alert("原密码不能为空！"),e.pwd_old.focus(),!1):checkspace(e.pwd_new.value)?(alert("新密码不能为空！"),e.pwd_new.focus(),!1):e.pwd_new1.value!=e.pwd_new1.value?(alert("二次密码不一样！"),document.frm.pwd_new1.focus(),!1):void 0}function SelectAd(e){var t;t=e;var n=e.split("|");document.form1.remark.value=n[0],document.form1.width.value=n[1],document.form1.height.value=n[2],document.form1.pid.value=n[3],document.form1.ty.value=n[4]}function checkcats(e){return checkspace(e.catname.value)?(alert("分类名称不能为空！"),e.catname.focus(),!1):void 0}function contents_check(){return""==eWebEditor1.getHTML()?(alert("内容不能为空!"),!1):void 0}function news_check(e){return checkspace(e.title.value)?(alert("请输入标题！"),e.title.focus(),!1):void 0}function movie_check(e){return checkspace(e.title.value)?(alert("请输入影片名称！"),e.title.focus(),!1):checkspace(e.pid.value)||0==e.pid.value?(alert("请选择影片分类！"),e.pid.focus(),!1):checkspace(e.content.value)?(alert("请输入影片介绍！"),!1):void 0}function uselinkurljs(e){1==e.uselinkurl.checked?(e.linkurl.disabled=!1,article.style.display="none"):(e.linkurl.disabled=!0,article.style.display="")}function checkmanager_add(e){if(checkspace(e.username.value))return alert("请输入管理帐号！"),e.username.focus(),!1;if(checkspace(e.password.value))return alert("请输入登陆密码！"),e.password.focus(),!1;if(e.password.value!=e.password1.value)return alert("请保证两次密码一致！"),e.password1.focus(),!1;for(var t=0,n=0;n<document.formlist.elements.length;n++){var c=document.formlist.elements[n];1==c.checked&&(t=1)}return 0==t?(window.alert("请选择权限!"),!1):!0}function checkmanager_edit(e){if(checkspace(e.username.value))return alert("请输入管理帐号！"),e.username.focus(),!1;if(e.password.value!=e.password1.value)return alert("请保证两次密码一致！"),e.password1.focus(),!1;for(var t=0,n=0;n<document.formlist.elements.length;n++){var c=document.formlist.elements[n];1==c.checked&&(t=1)}return 0==t?(window.alert("请选择权限!"),!1):!0}check_frame("Index");var tID=0;