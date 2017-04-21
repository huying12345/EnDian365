! function (a) {
    a(".search").focus(), a(".search").on("keyup", function (b) {
        var c = a(b.currentTarget).val();
        console.log(c), c.length > 0 ? (a("#all-packages [data-library-name]").hide(), a('#all-packages [data-library-name*="' + c + '"]').show()) : a("[data-library-name]").show()
    }), a(document).on("input", ".clearable", function () {
        this.value ? a(this).next("i").removeClass("fa-search").addClass("fa-close x") : a(this).next("i").removeClass("fa-close").addClass("fa-search")
    }).on("mousemove", ".x", function (b) {
        a(this).addClass("onX")
    }).on("click", ".onX", function () {
        a(this).removeClass("x onX").prev("input").val("").change(), a(this).removeClass("fa-close").addClass("fa-search"), a("[data-library-name]").show()
    }), a(window).scroll(function () {
        a(this).scrollTop() > 100 ? a("#back-to-top").fadeIn() : a("#back-to-top").fadeOut()
    }), a("#back-to-top").on("click", function (b) {
        return b.preventDefault(), a("html, body").animate({
            scrollTop: 0
        }, 1e3), !1
    });
    
}(jQuery), $(function () {
    function a(a) {
        var b = document,
            c = a;
        if (b.body.createTextRange) {
            var d = b.body.createTextRange();
            d.moveToElementText(c), d.select()
        } else if (window.getSelection) {
            var e = window.getSelection(),
                d = b.createRange();
            d.selectNodeContents(c), e.removeAllRanges(), e.addRange(d)
        }
    }

    function b() {
        $(".library").on("mouseenter", function(b) {
            $("library-url", this).text();
            a($(b.currentTarget)[0])
        }).on("mouseleave", function(a) {});
    }


});
