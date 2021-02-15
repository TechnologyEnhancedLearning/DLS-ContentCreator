var $el = $("#content"); var elHeight = $el.outerHeight(); var elWidth = $el.outerWidth(); var $wrapper = $("#scaleable-wrapper"); var scale = 1; function doResize(event, uheight, uwidth) { $wrapper.css({ width: uwidth + "px", height: uheight + "px" }); scale = Math.min(uwidth / elWidth, uheight / elHeight); $el.css({ transform: "translate(-50%, -50%) " + "scale(" + scale + ")" }); }
window.onresize = function () { doResize(null, $(window).height(), $(window).width()); }
$(function () { doResize(null, $(window).height(), $(window).width()); }); function resizeFix(event, ui) { var changeWidth = ui.size.width - ui.originalSize.width; var newWidth = ui.originalSize.width + changeWidth / scale; var changeHeight = ui.size.height - ui.originalSize.height; var newHeight = ui.originalSize.height + changeHeight / scale; ui.size.width = newWidth; ui.size.height = newHeight; }
function startFix(event, ui) {
    ui.position.left = 0; ui.position.top = 0; 
}

function createFix(event, ui) {
$(this).attr('oriLeft', $(this).css('left'));
    $(this).attr('oriTop', $(this).css('top'));
}
function dragFix(event, ui) { var changeLeft = ui.position.left - ui.originalPosition.left; var newLeft = ui.originalPosition.left + changeLeft / scale; var changeTop = ui.position.top - ui.originalPosition.top; var newTop = ui.originalPosition.top + changeTop / scale; ui.position.left = newLeft; ui.position.top = newTop; }
$('#content').css('opacity', 0); $(window).load(function () { $('#content').css('opacity', 1); }); $(document).ready(function () { setTimeout('$("#content").css("opacity", 1)', 1000); if (typeof InitialiseUI === "function") { InitialiseUI(); } });