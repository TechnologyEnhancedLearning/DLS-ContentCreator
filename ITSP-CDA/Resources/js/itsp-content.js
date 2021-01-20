//Handle assessment outcome:
var qs = '';
var vSelectionStart = -10;
var vSelectionEnd = -10;
function AssessmentOutcome(correct, tutid) {
    if (isPreview === true) {
        window.status = window.status.replace('Assessment outcome: CORRECT', '');
        window.status = window.status.replace('Assessment outcome: INCORRECT', '');
        if (correct) {
            window.status = window.status + 'Assessment outcome: CORRECT';
            qs = '?outcome=1';
        }
        else {
            window.status = window.status + 'Assessment outcome: INCORRECT';
            qs = '?outcome=2';
        }
    }
    else {
        //handle score incrementing here:
        if (window.console) {
            if (correct) {
                console.log('Assessment outcome ' + tutid.toString + ': CORRECT');
            }
            else {
                console.log('Assessment outcome ' + tutid.toString + ': INCORRECT');
            }
        }
        if (typeof parent.CCPlayer.UpdateAssessmentScore == 'function') {
            if (correct) {
                parent.CCPlayer.UpdateAssessmentScore(tutid, 1);
                parent.CCPlayer.OutcomeAnimation = 1;
            }
            else {
                parent.CCPlayer.UpdateAssessmentScore(tutid, 0);
                parent.CCPlayer.OutcomeAnimation = 2;
            }
        }
    }
}
function setToCenterOfParent(element, parent, ignoreWidth, ignoreHeight) {
    parentWidth = $(parent).width();
    parentHeight = $(parent).height();
    elementWidth = $(element).width();
    elementHeight = $(element).height();
    if (!ignoreWidth)
        $(element).css('margin-left', parentWidth / 2 - elementWidth / 2);
    if (!ignoreHeight)
        $(element).css('top', parentHeight / 2 - elementHeight / 2);
}
function exit_learning() {
    if (isPreview) {
        window.opener = window.self;
        window.close();
    }
    else {
        parent.CCPlayer.CloseLearning();
    }
}

var getSelection = function (elem) {
    var range = document.getSelection().getRangeAt(0);
    return {
        start: range.startOffset,
        end: range.endOffset
    };
};
function SelectionChanged(elem) {
    s = getSelectionStart(elem);
    e = getSelectionEnd(elem);
    if (typeof parent.CCPlayer !== 'undefined') {
        parent.CCPlayer.SelectionStart = s;
        parent.CCPlayer.SelectionEnd = e;
    }
    if (isPreview) {
        window.status = 'Selection start: ' + s + ', selection end: ' + e + '  ';
        if (window.console) {
            console.log('Selection start: ' + s + ', selection end: ' + e + '  ');
        }
    }

}
var BreakException = {};
function getSelectionStart(elem) {
    var range = document.getSelection().getRangeAt(0);
    var prev = 0;
    //var elem = elem.childNodes[1];
    NodeList.prototype.forEach = Array.prototype.forEach;
    var children = elem.childNodes;
    try {
        children.forEach(function (item) {
            item.childNodes.forEach(function (i) {
                if (i.firstChild !== null) {
                    if (typeof range.startContainer.innerText !== 'undefined') {
                        if (i.firstChild.data !== range.startContainer.innerText) { prev = prev + i.firstChild.data.length; } else { throw BreakException; }
                    }
                    else if (i.firstChild.data.length > 0) {
                        if (i.firstChild.data !== range.startContainer.data) { prev = prev + i.firstChild.data.length; } else { throw BreakException; }
                    }
                    else {
                        if (i.firstChild.length > 0) {
                            if (i.firstChild.text !== range.startContainer.text) { prev = prev + i.firstChild.length; } else { throw BreakException; }
                        }
                    }

                }
            });
        });
    }
    catch (e) {
        if (e !== BreakException) throw e;
    }
    vSelectionStart = range.startOffset + prev;
    return range.startOffset + prev;
}

function getSelectionEnd(elem) {
    var range = document.getSelection().getRangeAt(0);
    var prev = 0;
    //var elem = elem.childNodes[1];
    NodeList.prototype.forEach = Array.prototype.forEach;
    var children = elem.childNodes;
    try {
        children.forEach(function (item) {
            item.childNodes.forEach(function (i) {
                if (i.firstChild !== null) {
                    if (typeof range.endContainer.innerText !== 'undefined') {
                        if (i.firstChild.data !== range.endContainer.innerText) { prev = prev + i.firstChild.data.length; } else if (typeof range.EndContainer !== typeof range.startContainer){prev = prev + i.firstChild.data.length; throw BreakException; } else { throw BreakException; }
                    }
                    else if (i.firstChild.data.length > 0) {
                        if (i.firstChild.data !== range.endContainer.data) { prev = prev + i.firstChild.data.length; } else { throw BreakException; }
                    }
                    else {
                        if (i.firstChild.length > 0) {
                            if (i.firstChild.text !== range.endContainer.text) { prev = prev + i.firstChild.length; } else { throw BreakException; }
                        }
                    }

                }
            });
        });
    }
    catch (e) {
        if (e !== BreakException) throw e;
    }
    vSelectionEnd = range.endOffset + prev;
    return range.endOffset + prev;
}

var setSelection = function (elem, start, end) {
    var range = document.createRange();
    vSelectionEnd = end;
    vSelectionStart = start;
    var toEnd = end - start;
    var toStart = start;
    //var elem = elem.childNodes[1];
    NodeList.prototype.forEach = Array.prototype.forEach;
    var children = elem.childNodes;
    children.forEach(function (item) {
        item.childNodes.forEach(function (i) {
            if (toEnd >= 0 && i.firstChild !== null) {

                if (i.firstChild.data.length >= toStart && toStart >= 0) {
                    range.setStart(i.firstChild, toStart);
                    if (i.firstChild.data.length >= (toStart + toEnd)) {
                        range.setEnd(i.firstChild, (toStart + toEnd));
                        toEnd = -1;
                    }
                    else {
                        toEnd = toEnd - (i.firstChild.data.length - toStart);
                    }
                    toStart = -1;
                }
                else {
                    toStart = toStart - i.firstChild.data.length;
                    if (i.firstChild.data.length >= (toEnd) && toStart <= 0) {
                        range.setEnd(i.firstChild, (toEnd));
                        toEnd = -1;
                    }
                    else if (toStart <= 0) {
                        toEnd = toEnd - i.firstChild.data.length;
                    }
                }
            }
        });
    });
    var sel = document.getSelection();
    sel.removeAllRanges();
    sel.addRange(range);
};

function getCharCount(elem) {
    //var elem = elem.childNodes[1];
    NodeList.prototype.forEach = Array.prototype.forEach;
    var children = elem.childNodes;
    var nchars = 0;
    children.forEach(function (item) {
        item.childNodes.forEach(function (i) {
            if (i.firstChild !== null) {
                if (i.firstChild.data.length > 0) {
                    nchars = nchars + i.firstChild.data.length;
                }
            }
        });
    }
    );
    window.status = 'Character count: ' + nchars.toString();
    if (window.console) {
        console.log('Character count: ' + nchars.toString());
    }
    return nchars;
}
function getText(elem) {
    NodeList.prototype.forEach = Array.prototype.forEach;
    var children = elem.childNodes;
    var stext = '';
    children.forEach(function (item) {
        item.childNodes.forEach(function (i) {
            if (i.firstChild !== null) {
                if (typeof i.firstChild.data !== 'undefined') {
                    if (i.firstChild.data.length > 0) {
                        stext = stext + i.firstChild.data;
                    }
                    else {
                        if (i.firstChild.length > 0) {
                            stext = stext + i.firstChild.text;
                        }
                    }
                }

            }
        });
    }
    );
    return stext.trim();
}
function setText(elem, stext) {
    NodeList.prototype.forEach = Array.prototype.forEach;
    var children = elem.childNodes;
    children.forEach(function (item) {
        item.childNodes.forEach(function (i) {
            if (i.firstChild !== null) {
                if (typeof i.firstChild.data !== 'undefined') {
                    if (i.firstChild.data.length > 0) {
                        i.firstChild.data = stext;
                    }
                    else {
                        if (i.firstChild.length > 0) {
                            i.firstChild.text = stext;
                        }
                    }
                }
            }
        });
    }
    );
    return stext.trim();
}

$(function () {

    qs = '';
    if (typeof parent.CCPlayer != 'undefined') {
        if (parent.CCPlayer.ContentType != "learn") {
            changeHashOnLoad();
        }
        if (typeof parent.CCPlayer.UpdateAssessmentScore == 'function') {
            if (parent.CCPlayer.OutcomeAnimation == 1) {
                //$('#FailCircle').remove();
                $('#SuccessCircle').fadeOutAndRemove(1500);
                parent.CCPlayer.OutcomeAnimation = 0;
            }
            else if (parent.CCPlayer.OutcomeAnimation == 2) {
                // $('#SuccessCircle').remove();
                $('#FailCircle').fadeOutAndRemove(1500);
                parent.CCPlayer.OutcomeAnimation = 0;
            }
        }
    };
    if (typeof getUrlParameter('outcome') != 'undefined') {
        if (getUrlParameter('outcome') == 1) {
            //$('#FailCircle').remove();
            $('#SuccessCircle').fadeOutAndRemove(1500);
        }
        else if (getUrlParameter('outcome') == 2) {
            // $('#SuccessCircle').remove();
            $('#FailCircle').fadeOutAndRemove(1500);
        }
    };
    $('*').contextmenu(function () {
        return false;
    });
    $("video").bind("contextmenu", function () {
        return false;
    });
    $('.list-group.checked-list-box .list-group-item').each(function () {
        // Settings
        var $widget = $(this),
            $checkbox = $('<input type="' + $widget.data('type') + '" name="choices" />'),

            color = ($widget.data('color') ? $widget.data('color') : "primary"),
            style = ($widget.data('style') === "button" ? "btn-" : "list-group-item-");
        //settings = {
        //    on: {
        //        icon: 'glyphicon glyphicon-check'
        //    },
        //    off: {
        //        icon: 'glyphicon glyphicon-unchecked'
        //    }
        //};

        $widget.css('cursor', 'pointer');
        $widget.prepend($checkbox);

        // Event Handlers
        $widget.on('click', function () {
            $checkbox.prop('checked', !$checkbox.is(':checked'));
            $checkbox.triggerHandler('change');
            updateDisplay();
        });
        $checkbox.on('click', function () {
            $checkbox.prop('checked', !$checkbox.is(':checked'));
            $checkbox.triggerHandler('change');
            updateDisplay();
        });
        $checkbox.on('change', function () {
            updateDisplay();
        });


        // Actions
        function updateDisplay() {
            var isChecked = $checkbox.is(':checked');

            // Set the button's state
            $widget.data('state', (isChecked) ? "on" : "off");

            //// Set the button's icon
            //$widget.find('.state-icon')
            //    .removeClass()
            //    .addClass('state-icon ' + settings[$widget.data('state')].icon);
            if ($widget.data('type') === 'radio') {
                $(".active").removeClass(style + color + ' active');
            }

            // Update the button's color
            if (isChecked) {
                $widget.addClass(style + color + ' active');
            } else {
                $widget.removeClass(style + color + ' active');
            }
        }

        // Initialization
        function init() {

            if ($widget.data('checked') === true) {
                $checkbox.prop('checked', !$checkbox.is(':checked'));
            }

            updateDisplay();

            // Inject the icon if applicable
            //if ($widget.find('.state-icon').length == 0) {
            //    $widget.prepend('<span class="state-icon ' + settings[$widget.data('state')].icon + '"></span>');
            //}
        }
        init();
    });

    $('#get-checked-data').on('click', function (event) {
        event.preventDefault();
        var checkedItems = {}, counter = 0;
        $("#check-list-box li.active").each(function (idx, li) {
            checkedItems[counter] = $(li).text();
            counter++;
        });
        $('#display-json').html(JSON.stringify(checkedItems, null, '\t'));
    });
});

//Shuffle elements function:
(function ($) {
    $.fn.shuffle = function () {

        var allElems = this.get(),
            getRandom = function (max) {
                return Math.floor(Math.random() * max);
            },
            shuffled = $.map(allElems, function () {
                var random = getRandom(allElems.length),
                    randEl = $(allElems[random]).clone(true)[0];
                allElems.splice(random, 1);
                return randEl;
            });

        this.each(function (i) {
            $(this).replaceWith($(shuffled[i]));
        });
        return $(shuffled);
    };
})(jQuery);

function getQuizResult() {
    var isCorrect = true;
    $(".q-choice").each(function (index) {
        if (($(this).hasClass("active") | $(this).hasClass("object-selected")) && $(this).data("iscor") === 'False') {
            isCorrect = false;
        }
        if ($(this).hasClass("active") === false && $(this).hasClass("object-selected") === false && $(this).data("iscor") === 'True') {
            isCorrect = false;
        }
    });
    return isCorrect;
}



/*jslint browser: true*/
/*jslint jquery: true*/

/*
 * jQuery Hotkeys Plugin
 * Copyright 2010, John Resig
 * Dual licensed under the MIT or GPL Version 2 licenses.
 *
 * Based upon the plugin by Tzury Bar Yochay:
 * https://github.com/tzuryby/jquery.hotkeys
 *
 * Original idea by:
 * Binny V A, http://www.openjs.com/scripts/events/keyboard_shortcuts/
 */

/*
 * One small change is: now keys are passed by object { keys: '...' }
 * Might be useful, when you want to pass some other data to your handler
 */

(function (jQuery) {

    jQuery.hotkeys = {
        version: "0.2.0",

        specialKeys: {
            8: "backspace",
            9: "tab",
            10: "return",
            13: "return",
            16: "shift",
            17: "ctrl",
            18: "alt",
            19: "pause",
            20: "capslock",
            27: "esc",
            32: "space",
            33: "pageup",
            34: "pagedown",
            35: "end",
            36: "home",
            37: "left",
            38: "up",
            39: "right",
            40: "down",
            45: "insert",
            46: "del",
            59: ";",
            61: "=",
            96: "0",
            97: "1",
            98: "2",
            99: "3",
            100: "4",
            101: "5",
            102: "6",
            103: "7",
            104: "8",
            105: "9",
            106: "*",
            107: "+",
            109: "-",
            110: ".",
            111: "/",
            112: "f1",
            113: "f2",
            114: "f3",
            115: "f4",
            116: "f5",
            117: "f6",
            118: "f7",
            119: "f8",
            120: "f9",
            121: "f10",
            122: "f11",
            123: "f12",
            144: "numlock",
            145: "scroll",
            173: "-",
            186: ";",
            187: "=",
            188: ",",
            189: "-",
            190: ".",
            191: "/",
            192: "`",
            219: "[",
            220: "\\",
            221: "]",
            222: "'"
        },

        shiftNums: {
            "`": "~",
            "1": "!",
            "2": "@",
            "3": "#",
            "4": "$",
            "5": "%",
            "6": "^",
            "7": "&",
            "8": "*",
            "9": "(",
            "0": ")",
            "-": "_",
            "=": "+",
            ";": ": ",
            "'": "\"",
            ",": "<",
            ".": ">",
            "/": "?",
            "\\": "|"
        },

        // excludes: button, checkbox, file, hidden, image, password, radio, reset, search, submit, url
        textAcceptingInputTypes: [
            "text", "password", "number", "email", "url", "range", "date", "month", "week", "time", "datetime",
            "datetime-local", "search", "color", "tel"],

        // default input types not to bind to unless bound directly
        textInputTypes: /textarea|input|select/i,

        options: {
            filterInputAcceptingElements: true,
            filterTextInputs: true,
            filterContentEditable: true
        }
    };

    function keyHandler(handleObj) {
        if (typeof handleObj.data === "string") {
            handleObj.data = {
                keys: handleObj.data
            };
        }

        // Only care when a possible input has been specified
        if (!handleObj.data || !handleObj.data.keys || typeof handleObj.data.keys !== "string") {
            return;
        }

        var origHandler = handleObj.handler,
            keys = handleObj.data.keys.toLowerCase().split(" ");

        handleObj.handler = function (event) {


            var special = event.type !== "keypress" && jQuery.hotkeys.specialKeys[event.which],
                character = String.fromCharCode(event.which).toLowerCase(),
                modif = "",
                possible = {};

            jQuery.each(["alt", "ctrl", "shift"], function (index, specialKey) {

                if (event[specialKey + 'Key'] && special !== specialKey) {
                    modif += specialKey + '+';
                }
            });

            // metaKey is triggered off ctrlKey erronously
            if (event.metaKey && !event.ctrlKey && special !== "meta") {
                modif += "meta+";
            }

            if (event.metaKey && special !== "meta" && modif.indexOf("alt+ctrl+shift+") > -1) {
                modif = modif.replace("alt+ctrl+shift+", "hyper+");
            }

            if (special) {
                possible[modif + special] = true;
            }
            else {
                possible[modif + character] = true;
                possible[modif + jQuery.hotkeys.shiftNums[character]] = true;

                // "$" can be triggered as "Shift+4" or "Shift+$" or just "$"
                if (modif === "shift+") {
                    possible[jQuery.hotkeys.shiftNums[character]] = true;
                }
            }

            for (var i = 0, l = keys.length; i < l; i++) {
                if (possible[keys[i]]) {
                    return origHandler.apply(this, arguments);
                }
            }
        };
    }

    jQuery.each(["keydown", "keyup", "keypress"], function () {
        jQuery.event.special[this] = {
            add: keyHandler
        };
    });

})(jQuery || this.jQuery || window.jQuery);

function moveOnCheck(tutid) {
    var moveon = false;
    if (tutid !== 1234567890) {
        moveon = true;
        if (parent.CCPlayer.ContentType === "diag") {
            $.each(parent.CCPlayer.ObjList, function (i, item) {
                if (item == tutid) {
                    moveon = false;
                }
            });
        }
        else {
            moveon = false;
        }
    }
    return moveon;
}
function fadeDisable() {

    $('.fade-in').removeClass('fade-in');
    $('.text-box').css('opacity', '1');
}
jQuery.fn.fadeOutAndRemove = function (speed) {
    $(this).css('display', 'inline')
    $(this).fadeOut(speed, function () {
        $(this).remove();
    })
}
var getUrlParameter = function getUrlParameter(sParam) {
    var sPageURL = decodeURIComponent(window.location.search.substring(1)),
        sURLVariables = sPageURL.split('&'),
        sParameterName,
        i;

    for (i = 0; i < sURLVariables.length; i++) {
        sParameterName = sURLVariables[i].split('=');

        if (sParameterName[0] === sParam) {
            return sParameterName[1] === undefined ? true : sParameterName[1];
        }
    }
};
function replaceNbsps(str) {
    var re = new RegExp(String.fromCharCode(160), "g");
    return str.replace(re, " ");
}
function stripSpanClass(str) {
    var re = new RegExp(/ class=\"\w+\"/g);
    return str.replace(re, "");
}
//Stop back button navigation stuff:
function changeHashOnLoad() {
    window.location.href += "#";
    setTimeout("changeHashAgain()", "50");
}

function changeHashAgain() {
    window.location.href += "1";
}

var storedHash = window.location.hash;
window.setInterval(function () {
    if (window.location.hash != storedHash) {
        window.location.hash = storedHash;
    }
}, 50);

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

doResize(null, $(window).height(), $(window).width());
