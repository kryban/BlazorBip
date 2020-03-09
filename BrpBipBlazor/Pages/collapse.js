$(".head").click(function () {
    if ($("#collapsable").hasClass("out")) {
        $("#collapsable").addClass("in");
        $("#collapsable").removeClass("out");
    }
    else {
        $("#collapsable").addClass("out");
        $("#collapsable").removeClass("in");
    }
});