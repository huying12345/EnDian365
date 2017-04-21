(function ($) {
    $.fn.batchFileUpload = function (options) {
        var defaults = {
            UploadFieldName: "FileList",
            FieldName: "FileList",
            ModelID: 'DocInformationView',
            ModuleID: 'Doc',
            Value:''
        }
        var arrFileList = new Array();
        var previewNode;
        var myDropzone;
        var previewTemplate;
        options = $.extend(defaults, options);
        this.each(function () {
            var html = '<input type="button" id="fileinput-button_' + options.UploadFieldName + '" class="easyui-linkbutton" value="上传" />';
            html += '<input id="' + options.UploadFieldName + '" name="' + options.UploadFieldName + '" type="hidden" value=" ' + options.Value + ' " />';
            html += '<ul id="previews_' + options.UploadFieldName + '">';
            html += '<li id="template_' + options.UploadFieldName + '" class="file-row">';
            html += '</li>';
            html += '</ul>';
            $(this).html(html);
            initDropzone(jQuery(this).attr('id'));
        });

        function initDropzone(containerId) {
            if (jQuery.trim(jQuery('#' + options.UploadFieldName).val()) != '') {
                arrFileList = jQuery('#' + options.UploadFieldName).val().split('|');
            }
            initUploadFile();
            $(document).on("click", ".btnupload_delete", function (e) {
                var fileName = jQuery(this).parent().find(".name").attr('filePath');
                var index = jQuery.inArray(fileName, arrFileList);
                arrFileList.splice(index, 1);
                jQuery('#FileList').val(arrFileList.join('|'));
                jQuery(this).parent().remove();
                e.preventDefault();
                e.stopPropagation();
            });

            previewNode = document.querySelector("#template_" + options.UploadFieldName);
            previewNode.id = "";
            previewTemplate = previewNode.parentNode.innerHTML;
            previewNode.parentNode.removeChild(previewNode);

            myDropzone = new Dropzone(document.querySelector("#" + containerId), {
                url: '/Common/UploadFile/UploadAction?FieldName=' + options.FieldName + '&UploadFieldName=Upload_' + options.UploadFieldName + '&ModelID=' + options.ModelID + '&ModuleID=' + options.ModuleID,
                thumbnailWidth: 80,
                thumbnailHeight: 80,
                parallelUploads: 20,
                paramName: 'Upload_' + options.UploadFieldName,
                previewTemplate: previewTemplate,
                autoQueue: true,
                previewsContainer: "#previews_" + options.UploadFieldName,
                clickable: document.querySelector("#fileinput-button_" + options.UploadFieldName)
            });

            myDropzone.on("success", function (data) {
                eval('var res = ' + data.xhr.responseText + ';');
                if (res.Status == 1) {
                    arrFileList.push(res.returnValue);
                    jQuery('#' + options.UploadFieldName).val(arrFileList.join('|'));
                    appendFileTemplate(res.returnValue);
                } else {
                    alert(res.returnValue);
                    myDropzone.removeFile(data);
                }
            });
        }

        function initUploadFile() {
            for (var i = 0; i < arrFileList.length; i++) {
                if (arrFileList[i] != '') {
                    appendFileTemplate(arrFileList[i]);
                }
            }
        }

        function appendFileTemplate(filePath) {
            jQuery('#previews_' + options.UploadFieldName).append('<li><span class="name" filePath="' + filePath + '">' + filePath.substr(filePath.lastIndexOf('/') + 1) + '</span><button class="btnupload_delete">删除</button></li>');
        }
    };
})(jQuery);
