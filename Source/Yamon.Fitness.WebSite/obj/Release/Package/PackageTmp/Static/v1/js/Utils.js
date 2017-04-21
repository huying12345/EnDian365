String.prototype.endWith = function(str) {
    if (str == null || str == "" || this.length == 0 || str.length > this.length)
        return false;
    if (this.substring(this.length - str.length) == str)
        return true;
    else
        return false;
    return true;
}

String.prototype.startWith = function(str) {
    if (str == null || str == "" || this.length == 0 || str.length > this.length)
        return false;
    if (this.substr(0, str.length) == str)
        return true;
    else
        return false;
    return true;
}

//获取参数
function getUrlParamRegExp(name) {
    var reg = new RegExp("(^|\\?|&)" + name + "=([^&]*)(\\s|&|$)", "i");
    if (reg.test(location.href))
        return decodeURI(RegExp.$2.replace(/\+/g, " "));
    return "";
}
function G(id) { return document.getElementById(id); }
function F(id) { return parent.document.getElementById(id); }  //父文档的元素ID

function OpenWindow(Url, Width, Height, WindowObj) {
    if (Url.indexOf("?") == -1) {
        Url += "?r=" + Math.random();
    } else {
        Url += "&r=" + Math.random();
    }
    var ReturnStr = window.showModalDialog(Url, WindowObj, 'dialogWidth:' + Width
			+ 'px;dialogHeight:' + Height
			+ 'px;status:no;help:no;scroll:auto;status:0;help:0;');
    return ReturnStr;
}

function WindowOpen(Url, Width, Height, WindowObj) {
    if (Url.indexOf("?") == -1) {
        Url += "?r=" + Math.random();
    } else {
        Url += "&r=" + Math.random();
    }
    var ReturnStr = window.open(Url, 'newwindow', 'width=' + Width
			+ ',height=' + Height
			+ '');
    return ReturnStr;
}


function OpenWindowSetValue(Url, Width, Height, WindowObj, SetObj) {
    if (Url.indexOf("?") == -1) {
        Url += "?r=" + Math.random();
    } else {
        Url += "&r=" + Math.random();
    }
    var ReturnStr = showModalDialog(Url, WindowObj, 'dialogWidth:' + Width
			+ 'px;dialogHeight:' + Height
			+ 'px;status:no;help:no;scroll:auto;status:0;help:0;scroll:0;');
    if (ReturnStr != '' && ReturnStr != undefined) {
        SetObj.value = ReturnStr;
    }
    return ReturnStr;
}

//检查必填项
function CheckNotNull(objField, strText) {
    if (Trim(objField.value) == "") {
        alert("请填写“" + strText + "”！");
        objField.focus();
        return false;
    }
    return true;
}

//去除字符串左端空格
function LTrim(str) {
    return str.replace(/^\s*/, '');
}

//去除字符串右端空格
function RTrim(str) {
    return str.replace(/\s*$/, '');
}

//去除字符串两端空格
function Trim(str) {
    return LTrim(RTrim(str));
}

//检查字符串是否出现中文
function CheckNoChinese(objField, strText) {
    if (objField.value == "") return true;
    var RE = new RegExp("[^\x01-\x7F]");
    if (objField.value.search(RE) != -1) {
        alert("“" + strText + "”中不能出现中文！");
        objField.focus();
        return false;
    }
    return true;
}

//检查是否为数值
function CheckNumber(objField, strText, numMinValue, numMaxValue) {
    if (objField.value == "") return true;
    if (isNaN(objField.value)) {
        alert("“" + strText + "”中只能填写数字！");
        objField.focus();
        return false;
    }
    var numValue = parseFloat(objField.value);
    if (numMinValue != null) {
        if (numValue < numMinValue) {
            alert("“" + strText + "”的值不能小于 " + numMinValue.toString() + " ！");
            return false;
        }
    }
    if (numMaxValue != null) {
        if (numValue > numMaxValue) {
            objField.focus();
            alert("“" + strText + "”的值不能大于 " + numMaxValue.toString() + " ！");
            return false;
        }
    }
    return true;
}

//检查字符串长度
function CheckStringLength(objField, strText, numMinLen, numMaxLen) {
    if (objField.value == "") return true;
    if (numMinLen != null) {
        if (objField.value.length < numMinLen) {
            alert("“" + strText + "”的长度不能少于 " + numMinLen.toString() + " 个字符！");
            objField.focus();
            return false;
        }
    }
    if (numMaxLen != null) {
        if (objField.value.length > numMaxLen) {
            alert("“" + strText + "”的长度不能多于 " + numMaxLen.toString() + " 个字符！");
            objField.focus();
            return false;
        }
    }
    return true;
}

//检查为Email
function CheckEmail(objField, strText) {
    var objValue = Trim(objField.value);
    if (objValue == "") return true;
    var strErr = "“" + strText + "”不是正确的Email格式！";

    var regex = /\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*/;
    if (regex.test(objValue)) {
        var str = " !#$%^&*()+=|\{[]}:;'<,>?/";
        var str2 = '"';
        var result = true;
        for (var j = 0; j < objValue.length; j++) {
            if (str.indexOf(objValue.charAt(j)) != -1 || str2.indexOf(objValue.charAt(j)) != -1) {
                result = false;
                break;
            }
        }
        if (result == true) {
            return true;
        }
        else {
            alert(strErr);
            objField.focus();
            return false;
        }
    }
    else {
        alert(strErr);
        objField.focus();
        return false;
    }
}

//检测为电话号码
function CheckPhone(objField, strText) {
    var objValue = Trim(objField.value);
    if (objValue == "") return true;
    var strErr = "“" + strText + "”不是正确的电话号码格式！";
    var reg = /(^[0-9]{3,4}\-[0-9]{3,8}$)|(^[0-9]{7,11}$)|(^\([0-9]{3,4}\)[0-9]{3,8}$)|(^0{0,1}1(3|4|5|8)[0-9]{9}$)|(^(400|800)[0-9]{7}$)/;
    if (!reg.exec(objValue)) {
        alert(strErr);
        objField.focus();
        return false;
    }
    return true;
}

//检验企业法人代码
function CheckCorpCode(objField, strText) {
    var objValue = Trim(objField.value);
    if (objValue == "") return true;
    var strErr = "“" + strText + "”不是正确的企业法人代码格式！";
    var patrn = /^(\d){15}$/;
    if (!patrn.exec(objValue)) {
        alert(strErr);
        objField.focus();
        return false;
    }
    return true;
}

//校验邮政编码
function CheckPostalCode(objField, strText) {
    var objValue = Trim(objField.value);
    if (objValue == "") return true;
    var strErr = "“" + strText + "”不是正确的邮政编码格式！";
    var patrn = /^[0-9]{1}(\d){5}$/;
    if (!patrn.exec(objValue)) {
        alert(strErr);
        objField.focus();
        return false;
    }
    return true;
}

//判断单选/复选题必选
function CheckRadioSelectNoClick(objField, strText) {
    var theAllOptionDisabled = true;
    var theOptionId = 0;
    for (t = 0; t < objField.length; t++) {
        if ((objField[t].value != 0 && objField[t].disabled == false && theAllOptionDisabled == true) || (objField[t].value == 0 && objField[t].parentNode.parentNode.style.display != 'none' && theAllOptionDisabled == true)) {
            theOptionId = t;
            theAllOptionDisabled = false;
        }
        if (objField[t].checked) return true;
    }
    if (theAllOptionDisabled == false) {
        var strErr = "“" + strText + "”必须选择一个选项！";
        alert(strErr);
        objField[theOptionId].focus();
        return false;
    }
    else {
        return true;
    }
}

//判断单选/复选必选
function CheckRadioNoClick(objField, strText) {
    var strErr = "“" + strText + "”必须选择一个选项！";
    for (i = 0; i < objField.length; i++) {
        if (objField[i].checked) return true;
    }
    alert(strErr);
    objField[0].focus();
    return false;
}

//移除单选/复选的选择值
function RadioUnClick(objField) {
    var i;
    for (i = 0; i < objField.length; i++) {
        objField[i].checked = false;
    }
    objField.value = '';
}

//移除输入框的值
function TextUnInput(objField) {
    objField.value = '';
}

//移除下拉框的值
function ListUnSelect(objField) {
    var j = 0;
    for (i = 0; i < objField.options.length; i++) {
        objField.options[i].selected = false;
    }
    objField.value = '';
}

//检测复选最多几项
function CheckCheckBoxMaxClick(objField, strText, maxNum) {
    var j = 0;
    for (i = 0; i < objField.length; i++) {
        if (objField[i].checked) {
            j = j + 1;
        }
    }
    if (j > maxNum) {
        alert("最多只能选择" + maxNum + "项“" + strText + "”");
        objField[0].focus();
        return false;
    }
    else {
        if (j == 0) {
            alert("请选择“" + strText + "”");
            objField[0].focus();
            return false;
        }
        else return true;
    }
}

//检测复选最少几项
function CheckCheckBoxMinClick(objField, strText, minNum) {
    var j = 0;
    for (i = 0; i < objField.length; i++) {
        if (objField[i].checked) {
            j = j + 1;
        }
    }
    if (j < minNum) {
        alert("最少必须选择" + minNum + "项“" + strText + "”");
        objField[0].focus();
        return false;
    }
    else {
        if (j == 0) {
            alert("请选择“" + strText + "”");
            objField[0].focus();
            return false;
        }
        else return true;
    }
}

//检测复选题最多几项
function CheckCheckMaxClick(objField, strText, maxNum) {
    var theAllOptionDisabled = true;
    var theOptionId = 0;
    var j = 0;
    for (t = 0; t < objField.length; t++) {
        if ((objField[t].value != 0 && objField[t].disabled == false && theAllOptionDisabled == true) || (objField[t].value == 0 && objField[t].parentNode.parentNode.style.display != 'none' && theAllOptionDisabled == true)) {
            theOptionId = t;
            theAllOptionDisabled = false;
        }
        if (objField[t].checked) j = j + 1;
    }
    if (theAllOptionDisabled == false) {
        if (j > maxNum) {
            alert("最多只能选择" + maxNum + "项“" + strText + "”");
            objField[theOptionId].focus();
            return false;
        }
        else {
            if (j == 0) {
                alert("请选择“" + strText + "”");
                objField[theOptionId].focus();
                return false;
            }
            else return true;
        }
    }
    else {
        return true;
    }
}

//检测复选题最少几项
function CheckCheckMinClick(objField, strText, minNum) {
    var theAllOptionDisabled = true;
    var theOptionId = 0;
    var j = 0;
    var theRemainNum = 0;
    for (t = 0; t < objField.length; t++) {
        if ((objField[t].value != 0 && objField[t].disabled == false) || (objField[t].value == 0 && objField[t].parentNode.parentNode.style.display != 'none')) {
            theRemainNum++;
            if (theAllOptionDisabled == true) {
                theOptionId = t;
                theAllOptionDisabled = false;
            }
        }
        if (objField[t].checked) j = j + 1;
    }
    if (theAllOptionDisabled == false) {
        if (j < minNum && j < theRemainNum) {
            alert("最少必须选择" + minNum + "项“" + strText + "”");
            objField[theOptionId].focus();
            return false;
        }
        else {
            if (j == 0) {
                alert("请选择“" + strText + "”");
                objField[theOptionId].focus();
                return false;
            }
            else return true;
        }
    }
    else {
        return true;
    }
}

//检测下拉必选
function CheckListNoSelect(objField, strText) {
    for (i = 0; i < objField.options.length; i++) {
        if (objField.options[i].selected && objField.value != '') {
            return true;
        }
    }
    alert("请选择“" + strText + "”！");
    objField[0].focus();
    return false;
}

//检测下拉最多几项
function CheckListMaxSelect(objField, strText, maxNum) {
    var j = 0;
    for (i = 0; i < objField.options.length; i++) {
        if (objField.options[i].selected) {
            j = j + 1;
        }
    }
    if (j > maxNum) {
        alert("最多只能选择" + maxNum + "项“" + strText + "”");
        objField[0].focus();
        return false;
    }
    else {
        if (j == 0) {
            alert("请选择“" + strText + "”");
            objField[0].focus();
            return false;
        }
        else return true;
    }
}

//检测下拉最少几项
function CheckListMinSelect(objField, strText, minNum) {
    var j = 0;
    for (i = 0; i < objField.options.length; i++) {
        if (objField.options[i].selected) {
            j = j + 1;
        }
    }
    if (j < minNum) {
        alert("最少必须选择" + minNum + "项“" + strText + "”");
        objField[0].focus();
        return false;
    }
    else {
        if (j == 0) {
            alert("请选择“" + strText + "”");
            objField[0].focus();
            return false;
        }
        else return true;
    }
}

//检测值在复选下拉选中
function IsInSelectedList(objField, optionValue) {
    for (i = 0; i < objField.options.length; i++) {
        if (objField.item(i).selected && objField.item(i).value == optionValue) {
            return true;
        }
    }
    return false;
}

function IsInCheckBox(objField, optionValue) {
	if(objField==undefined) return false;
    for (i = 0; i < objField.length; i++) {
        if (objField[i].checked && objField[i].value == optionValue) {
            return true;
        }
    }
    return false;
}

//检测为短日期
function CheckDate(objField, strText) {
    var objValue = Trim(objField.value);
    if (objValue == "") return true;
    var strErr = "“" + strText + "”不是正确的日期格式(例：2007-10-1)！";
    var r = objValue.match(/^(\d{1,4})(-|\/)(\d{1,2})\2(\d{1,2})$/);
    if (r == null) {
        alert(strErr);
        objField.focus();
        return false;
    }
    var d = new Date(r[1], r[3] - 1, r[4]);
    var B = d.getFullYear() == r[1] && (d.getMonth() + 1) == r[3] && d.getDate() == r[4];
    if (!B) {
        alert(strErr);
        objField.focus();
        return false;
    }
    return true;
}

//检测为身份证号
function CheckIDCardNo(objField, strText) {
    var objValue = Trim(objField.value);
    if (objValue == "") return true;
    var len = objValue.length, re;
    if (len == 15)
        re = new RegExp(/^(\d{6})()?(\d{2})(\d{2})(\d{2})(\d{3})$/);
    else if (len == 18) {
        re = new RegExp(/^(\d{6})()?(\d{4})(\d{2})(\d{2})(\d{3})[x|X|(\d{1})]$/);
    }
    else {
        alert("“" + strText + "”输入的数字位数不正确！");
        objField.focus();
        return false;
    }
    var a = objValue.match(re);
    if (a != null) {
        if (len == 15) {
            var D = new Date("19" + a[3] + "/" + a[4] + "/" + a[5]);
            var B = D.getYear() == a[3] && (D.getMonth() + 1) == a[4] && D.getDate() == a[5];
        }
        else {
            var D = new Date(a[3] + "/" + a[4] + "/" + a[5]);
            var B = D.getFullYear() == a[3] && (D.getMonth() + 1) == a[4] && D.getDate() == a[5];
        }
        if (!B) {
            alert("“" + strText + "”输入的身份证号 " + a[0] + " 内出生日期不正确！");
            objField.focus();
            return false;
        }
    }
    else {
        alert("“" + strText + "”输入不正确的身份证号!");
        objField.focus();
        return false;
    }

    return true;
}

//检测文件上传类型与大小
function CheckFileTypeSize(objField, strText, allowExt, maxSize) {
    FileExt = objField.value.substr(objField.value.lastIndexOf(".")).toLowerCase();
    if (allowExt.indexOf(FileExt + "|") == -1) {
        alert(strText + " - 上传的文件扩展名仅支持：" + allowExt);
        objField.focus();
        return false;
    }
    return true;
}

//清除文件选择框的值
function FileUnSelect(objField) {
    objField.outerHTML = objField.outerHTML;
}

function getID(_sId) {
    return document.getElementById(_sId);
}

//检查某值在某字符串中
function isInValueList(theValue, valueList) {
    if (Trim(valueList) == "") return false;
    var valueArray = valueList.split(',');
    for (i = 0; i < valueArray.length; i++) {
        if (valueArray[i] == theValue) {
            return true;
        }
    }
    return false;
}

//得到单选复选的值
function getRadioCheckBoxValue(objField) {
    var theSelectedValue = '';
    if (objField[0].tagName.toLowerCase() == 'input') {
        for (i = 0; i < objField.length; i++) {
            if (objField[i].checked) theSelectedValue += objField[i].value + ',';
        }
    }
    else {
        for (i = 0; i < objField.options.length; i++) {
            if (objField.item(i).selected) theSelectedValue += objField.item(i).value + ',';
        }
    }
    return theSelectedValue.substr(0, theSelectedValue.length - 1);
}

//得到评分题的选中值
function getRatingValue(objField) {
    var theSelectedValue = 0;
    for (i = 0; i < objField.length; i++) {
        if (objField[i].checked) theSelectedValue = objField[i].value;
    }
    return theSelectedValue;
}

//排除性选项
function theExcludeItem(objField, theOptionOrderID, isSelect) {
    if (isSelect == 1)  //列表框
    {
        var theSelectID = theOptionOrderID + 1;
        if (objField.item(theSelectID).selected) {
            for (i = 0; i < theSelectID; i++) {
                objField.options[i].selected = false;
            }
        }
    }
    else {
        if (objField[theOptionOrderID].checked == true) {
            for (i = 0; i < theOptionOrderID; i++) {
                objField[i].checked = false;
                objField[i].disabled = true;
            }
        }
        else {
            for (i = 0; i < theOptionOrderID; i++) {
                objField[i].disabled = false;
            }
        }
    }
}

//互斥
function isExcludeItem(objField, theOptionOrderID, maxOptionNum) {
    if (objField[theOptionOrderID].checked == true) {
        for (i = 0; i < maxOptionNum; i++) {
            if (i != theOptionOrderID) {
                objField[i].checked = false;
                objField[i].disabled = true;
            }
        }
    }
    else {
        if (objField[theOptionOrderID].disabled != true) {
            for (i = 0; i < maxOptionNum; i++) {
                objField[i].disabled = false;
            }
        }
    }
}

//检查矩阵填空
function CheckMultipleText(qtnID, labelID, minOptionID, maxOptionID, strText) {
    for (i = minOptionID; i <= maxOptionID; i++) {
        objField = eval("document.Survey_Form.option_" + qtnID + "_" + i + "_" + labelID);
        if (objField != null) {
            if (Trim(objField.value) != "") {
                return true;
            }
        }
    }
    alert("请填写“" + strText + "”！");
    objField = eval("document.Survey_Form.option_" + qtnID + "_" + minOptionID + "_" + labelID);
    objField.focus();
    return false;
}

//以下函数处理答案带入问题
function getRadioOptionText(objField, theBaseID, theQtnID, theBaseType) {
    var theObjField = eval("document.Survey_Form." + objField);
    if (theObjField != null) {
        var theBaseValue = getRadioCheckBoxValue(theObjField);
        var theBaseOptionID = eval("document.getElementById('optionName_" + theBaseType + "_" + theBaseID + "_" + theBaseValue + "')");
        var theQtnTextID = eval("document.getElementById('node_" + theQtnID + "_" + theBaseID + "')");
        if (theBaseOptionID != null && theQtnTextID != null) {
            theQtnTextID.innerHTML = theBaseOptionID.innerText;
        }
    }
}

function getSelectOptionText(objField, theBaseID, theQtnID) {
    var theObjField = eval("document.Survey_Form." + objField);
    if (theObjField != null) {
        var theQtnText = '';
        for (i = 0; i < theObjField.options.length; i++) {
            if (theObjField.item(i).selected && theObjField.value != '') {
                theQtnText = theObjField.item(i).text;
                break;
            }
        }
        var theQtnTextID = eval("document.getElementById('node_" + theQtnID + "_" + theBaseID + "')");
        if (theQtnTextID != null) {
            theQtnTextID.innerHTML = theQtnText;
        }
    }
}

function getAutoOptionText(objField, theBaseID, theQtnID) {
    var theObjField = eval("document.Survey_Form." + objField);
    if (theObjField != null) {
        var theBaseValue = getRadioCheckBoxValue(theObjField);
        var theBaseOptionID = eval("document.getElementById('textNode_" + theBaseID + "_" + theBaseValue + "')");
        var theQtnTextID = eval("document.getElementById('node_" + theQtnID + "_" + theBaseID + "')");
        if (theBaseOptionID != null && theQtnTextID != null) {
            theQtnTextID.innerHTML = theBaseOptionID.innerText;
        }
    }
}

function getInputTextValue(objField, theBaseID, theQtnID) {
    var theObjField = eval("document.Survey_Form." + objField);
    if (theObjField != null) {
        var theQtnTextID = eval("document.getElementById('node_" + theQtnID + "_" + theBaseID + "')");
        if (theQtnTextID != null) {
            theQtnTextID.innerHTML = theObjField.value;
        }
    }
}

//检测为网址
function CheckURL(objField, strText) {
    var objValue = Trim(objField.value);
    if (objValue == "") return true;
    var strErr = "“" + strText + "”不是正确的URL格式！";
    var reg = /^([hH][tT]{2}[pP]:\/\/|[hH][tT]{2}[pP][sS]:\/\/)*[A-Za-z0-9]+\.[A-Za-z0-9]+[\/=\?%\-&_~`@[\]\':+!]*([^<>\"\"])*$/;
    if (!reg.test(objValue)) {
        alert(strErr);
        objField.focus();
        return false;
    }
    return true;
}

//计算可分配的比重值
function ReCalcSum(questionID, minOptionNum, maxOptionNum, maxNum) {
    var obj, optionTotalNum = 0;
    for (i = minOptionNum; i <= maxOptionNum; i++) {
        obj = eval("document.Survey_Form.option_" + questionID + "_" + i);
        if (obj != null) {
            optionTotalNum += Number(obj.value);
        }
    }
    var rtnValue = maxNum - optionTotalNum;
    var tarObj = eval("document.Survey_Form.option_" + questionID + "_total");
    tarObj.value = rtnValue.toString();
}

//FirFox下innerText补丁
(function(bool) {
    function setInnerText(o, s) {
        while (o.childNodes.length != 0) {
            o.removeChild(o.childNodes[0]);
        }

        o.appendChild(document.createTextNode(s));
    }

    function getInnerText(o) {
        var sRet = "";

        for (var i = 0; i < o.childNodes.length; i++) {
            if (o.childNodes[i].childNodes.length != 0) {
                sRet += getInnerText(o.childNodes[i]);
            }

            if (o.childNodes[i].nodeValue) {
                if (o.currentStyle.display == "block") {
                    sRet += o.childNodes[i].nodeValue + "\n";
                } else {
                    sRet += o.childNodes[i].nodeValue;
                }
            }
        }

        return sRet;
    }

    if (bool) {
        HTMLElement.prototype.__defineGetter__("currentStyle", function() {
            return this.ownerDocument.defaultView.getComputedStyle(this, null);
        });

        HTMLElement.prototype.__defineGetter__("innerText", function() {
            return getInnerText(this);
        })

        HTMLElement.prototype.__defineSetter__("innerText", function(s) {
            setInnerText(this, s);
        })
    }
})(/Firefox/.test(window.navigator.userAgent));


//得到字符总数
function getChars(str) {
	var i = 0;
	var c = 0.0;
	var unicode = 0;
	var len = 0;

	if (str == null || str == "") {
		return 0;
	}
	len = str.length;
	for(i = 0; i < len; i++) {
			unicode = str.charCodeAt(i);
		if (unicode < 127) { //判断是单字符还是双字符
			c += 1;
		} else {  //chinese
			c += 2;
		}
	}
	return c;
}

function sb_strlen(str) {
    return getChars(str);
}
//截取字符
function sb_substr(str, startp, endp) {
    var i=0; c = 0; unicode=0; rstr = '';
    var len = str.length;
    var sblen = sb_strlen(str);

    if (startp < 0) {
        startp = sblen + startp;
    }

    if (endp < 1) {
        endp = sblen + endp;// - ((str.charCodeAt(len-1) < 127) ? 1 : 2);
    }
    // 寻找起点
    for(i = 0; i < len; i++) {
        if (c >= startp) {
            break;
        }
	    var unicode = str.charCodeAt(i);
		if (unicode < 127) {
			c += 1;
		} else {
			c += 2;
		}
	}

	// 开始取
	for(i = i; i < len; i++) {
	    var unicode = str.charCodeAt(i);
		if (unicode < 127) {
			c += 1;
		} else {
			c += 2;
		}
		rstr += str.charAt(i);

		if (c >= endp) {
		    break;
		}
	}

	return rstr;
}



function mb_strlen(str) {
	var len = 0;
	for(var i = 0; i < str.length; i++) {
		len += str.charCodeAt(i) < 0 || str.charCodeAt(i) > 255 ? (charset == 'utf-8' ? 3 : 2) : 1;
	}
	return len;
}
