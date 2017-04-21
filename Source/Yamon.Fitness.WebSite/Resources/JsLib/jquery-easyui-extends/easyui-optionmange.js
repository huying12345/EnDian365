
(function($) {
    function Init(obj) {
        var opts = $.data(obj, "optionmanage").options;
        if (opts.id) {
            $(obj).attr("id", opts.id);
        } else {
            $(obj).removeAttr("id");
        }
        $(obj).after(GetOptionHtml(obj));
        InitGroupListBoxValue(obj);
        jQuery('.easyui-linkbutton').linkbutton();
    };
    function GetOptionHtml(obj) {
        var opts = $.data(obj, "optionmanage").options;
        if (opts.id) {
            $(obj).attr("id", opts.id);
        } else {
            $(obj).removeAttr("id");
        }
        var html = '<table border="0" cellpadding="0" cellspacing="0" style="width:100%">';
        html += '            <tr style="border:0px;">';
        html += '                <td align="left" style="border:0px;width:' + opts.listBoxWidth + '">';
        html += '                   <select size="4" name="' + opts.id + '_ListBox" id="' + opts.id + '_ListBox" ondblclick="return ModifyOption(\'' + opts.id + '\');" style="width: ' + opts.listBoxWidth + '; height: ' + opts.listBoxHeight + ';">';
        html += '                    </select>';
        html += '                </td>';
        html += '                <td align="left" valign="top" style="line-height:30px;padding:5px;border:0px;">';
        html += '                   <a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:\'icon-add\'" onclick="AddOption(\'' + opts.id + '\');">添加新' + opts.optionName + '&nbsp;&nbsp;&nbsp</a><br />';
        html += '                   <a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:\'icon-edit\'" onclick="return ModifyOption(\'' + opts.id + '\');">修改当前' + opts.optionName + '</a><br />';
        html += '                   <a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:\'icon-cancel\'" onclick="DelOption(\'' + opts.id + '\');">删除当前' + opts.optionName + '</a><br />';
        html += '                   <a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:\'icon-undo\'" onclick="UpOrder(\'' + opts.id + '\')">向上移动' + opts.optionName + '</a><br />';
        html += '                   <a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:\'icon-redo\'" onclick="DownOrder(\'' + opts.id + '\')">向下移动' + opts.optionName + '</a><br />';
        html += '              </td>';
        html += '          </tr>';
        html += ' </table>';
        return html;
    }
    function InitGroupListBoxValue(obj) {
        var opts = $.data(obj, "optionmanage").options;
        if (opts.id) {
            $(obj).attr("id", opts.id);
        } else {
            $(obj).removeAttr("id");
        }
        listboxId = opts.id + "_ListBox";
        var value = obj.value;
        var arrValue = value.split("$$$");
        for (var i = 0; i < arrValue.length; i++) {
            if (arrValue != "") {
                document.getElementById(listboxId).options[document
							.getElementById(listboxId).length] = new Option(
							arrValue[i], arrValue[i]);
            }
        }
    }

    $.fn.optionmanage = function(_a, _b) {
        if (typeof _a == "string") {
            return $.fn.optionmanage.methods[_a](this, _b);
        }
        _a = _a || {};
        return this.each(function() {
            var _c = $.data(this, "optionmanage");
            if (_c) {
                $.extend(_c.options, _a);
            } else {
                $.data(this, "optionmanage", {
                    options: $.extend({}, $.fn.optionmanage.defaults,
							$.fn.optionmanage.parseOptions(this), _a)
                });
            }
            Init(this);
        });
    };
    $.fn.optionmanage.methods = {
        options: function(jq) {
            return $.data(jq[0], "optionmanage").options;
        }
    };
    $.fn.optionmanage.parseOptions = function(_d) {
        var t = $(_d);
        return {
            id: t.attr("id"),
            disabled: (t.attr("disabled") ? true : undefined),
            plain: (t.attr("plain") ? t.attr("plain") == "true" : undefined),
            text: $.trim(t.html()),
            iconCls: (t.attr("icon") || t.attr("iconCls")),
            optionName: t.attr("optionName"),
            listBoxWidth: t.attr("listBoxWidth"),
            listBoxHeight: t.attr("listBoxHeight")
        };
    };
    $.fn.optionmanage.defaults = {
        id: null,
        disabled: false,
        plain: false,
        text: "",
        optionName: "选项",
        listBoxWidth: "250px",
        listBoxHeight:"120px",
        iconCls: null
    };
})(jQuery);

function AddOption(id) {
    listboxId = id + "_ListBox";
    var thisurl = '选项名称'+ (document.getElementById(listboxId).length + 1) + '|选项值';
    jQuery.messager.prompt('请输入', '选项名称和值，中间用“|”隔开：', function(text) {
        if (text) {
            thisurl = text;
            document.getElementById(listboxId).options[document
							.getElementById(listboxId).length] = new Option(
							thisurl, thisurl);
            ChangeHiddenFieldValue(id);
        }
    }, thisurl);
}
function ModifyOption(id) {
    listboxId = id + "_ListBox";
    if (document.getElementById(listboxId).length == 0)
        return false;
    var thisurl = document.getElementById(listboxId).value;
    if (thisurl == '') {
        jQuery.messager.alert('提示', '请先选择一个选项，再点修改按钮！', 'info');
        return false;
    }
    jQuery.messager.prompt('请输入', '选项名称和值，中间用“|”隔开：', function(text) {
        if (text) {
            thisurl = text;
            document.getElementById(listboxId).options[document
							.getElementById(listboxId).selectedIndex] = new Option(
							thisurl, thisurl);
            ChangeHiddenFieldValue(id);
        }
    }, thisurl);

}
function DelOption(id) {
    listboxId = id + "_ListBox";
    if (document.getElementById(listboxId).length == 0)
        return false;
    var thisurl = document.getElementById(listboxId).value;
    if (thisurl == '') {
        jQuery.messager.alert('提示', '请先选择一个选项，再点删除按钮！', 'info');
        return false;
    }
    document.getElementById(listboxId).options[document
					.getElementById(listboxId).selectedIndex] = null;
    ChangeHiddenFieldValue(id);
}

function UpOrder(id) {
    listboxId = id + "_ListBox";
    var sel = document.getElementById(listboxId);
    if (sel.selectedIndex >= 0) {
        var tempValue = sel.options[sel.selectedIndex].value;
        var tempText = sel.options[sel.selectedIndex].text;
    } else {
        jQuery.messages.alert('提示', '请选择要移动的项。', 'info');
        return;
    }
    if (sel.selectedIndex > 0) {
        sel.options[sel.selectedIndex].text = sel.options[sel.selectedIndex
						- 1].text;
        sel.options[sel.selectedIndex - 1].text = tempText;
        sel.options[sel.selectedIndex].value = sel.options[sel.selectedIndex
						- 1].value;
        sel.options[sel.selectedIndex - 1].value = tempValue;
        sel.selectedIndex = sel.selectedIndex - 1;
    }
    if (sel.onchange) {
        sel.onchange();
    }
    ChangeHiddenFieldValue(id);
}
function DownOrder(id) {
    listboxId = id + "_ListBox";
    var sel = document.getElementById(listboxId);
    if (sel.selectedIndex >= 0) {
        var tempValue = sel.options[sel.selectedIndex].value;
        var tempText = sel.options[sel.selectedIndex].text;
    } else {
        jQuery.messages.alert('提示', '请选择要移动的项。', 'info');
        return;
    }
    if (sel.selectedIndex < sel.options.length - 1) {
        sel.options[sel.selectedIndex].text = sel.options[sel.selectedIndex
						+ 1].text;
        sel.options[sel.selectedIndex + 1].text = tempText;
        sel.options[sel.selectedIndex].value = sel.options[sel.selectedIndex
						+ 1].value;
        sel.options[sel.selectedIndex + 1].value = tempValue;
        sel.selectedIndex = sel.selectedIndex + 1;
    }
    if (sel.onchange) {
        sel.onchange();
    }
    ChangeHiddenFieldValue(id);
}

function ChangeHiddenFieldValue(id) {
    listboxId = id + "_ListBox";
    var choiceUrl = document.getElementById(listboxId);
    var value = "";
    for (i = 0; i < choiceUrl.length; i++) {
        if (value != "") {
            value = value + "$$$";
        }
        value = value + choiceUrl.options[i].value;
    }
    jQuery("#"+id).val(value);
    return true;
}