var $el = $("#content");
var elHeight = $el.outerHeight();
var elWidth = $el.outerWidth();

var $wrapper = $("#scaleable-wrapper");

//$wrapper.resizable({
//    resize: doResize
//});
var scale;
function doResize(event, uheight, uwidth) {
    $wrapper.css({ width: uwidth + "px", height: uheight + "px" });
    scale = Math.min(
        uwidth / elWidth,
        uheight / elHeight
    );

    $el.css({
        transform: "translate(-50%, -50%) " + "scale(" + scale + ")"
    });

}
window.onresize = function () {
    doResize(null, $(window).height(), $(window).width());
}
$(function () {
    doResize(null, $(window).height(), $(window).width());
});