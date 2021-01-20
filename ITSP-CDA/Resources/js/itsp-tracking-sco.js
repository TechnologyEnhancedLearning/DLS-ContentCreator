var fixedtime = "0";
var ContentType = "XXContentTypeXX";
var PLAThresh = 123456789;
var iscomplete = false;
var startDate = new Date().getTime();
; (function ($) {

    $.preload = function () {
        var imgs = Object.prototype.toString.call(arguments[0]) === '[object Array]'
          ? arguments[0] : arguments;

        var tmp = [];
        var i = imgs.length;

        // reverse loop run faster
        for (; i-- ;) tmp.push($('<img />').attr('src', imgs[i]));
    };
})(jQuery);

function getp(name) {
    return decodeURIComponent((new RegExp('[?|&]' + name + '=' + '([^&;]+?)(&|#|;|$)').exec(location.search) || [, ""])[1].replace(/\+/g, '%20')) || null;
}
(function (CCPlayer, $, undefined) {
    CCPlayer.IsTracked = true;
    CCPlayer.ContentType = ContentType;
    CCPlayer.PLAThresh = 0;
    CCPlayer.SelectionEnd = 0;
    CCPlayer.SelectionStart = 0;
    CCPlayer.myscore = 0;
    CCPlayer.wrongcount = 0;
    CCPlayer.AssessAttempted = false;
    CCPlayer.LessonStatus = 'incomplete';
    CCPlayer.OutcomeAnimation = 0;
    CCPlayer.MarkLearningComplete = function () {
        iscomplete = true;
        CCPlayer.LessonStatus = 'completed';
    };
    CCPlayer.CloseLearning = function () {
        doQuit(CCPlayer.LessonStatus);
    };
    CCPlayer.UpdateAssessmentScore = function (tutorialid, score) {
        //Mark the assessment as attempted. This will determine whether we should store the final assessment outcome:
        //iterate through the objson objective list to find a matching tutorial id:
        if (CCPlayer.PLAThresh === 0) {
            CCPlayer.PLAThresh = doLMSGetValue('cmi.student_data.mastery_score');
            if (isNaN(CCPlayer.PLAThresh))
            {
                CCPlayer.PLAThresh = PLAThresh;
            }
        }
        //it was correct, so increment the score:
        if (score > 0) { CCPlayer.myscore = CCPlayer.myscore + score; } else {
            //it was incorrect, so increment the wrongcount:
            CCPlayer.wrongcount = CCPlayer.wrongcount + 1;
        }
    };
    
    CCPlayer.SubmitPLAssessOutcome = function (pc) {
        doLMSSetValue("cmi.core.score.raw", pc);
        if (pc >= CCPlayer.PLAThresh) {
            CCPlayer.LessonStatus = "passed";
            doLMSSetValue("cmi.core.lesson_status", "passed");
        }
        else
        {
            CCPlayer.LessonStatus = "failed";
            doLMSSetValue("cmi.core.lesson_status", "failed");
        };
    };
}(window.CCPlayer = window.CCPlayer || {}, jQuery));
function StoreProgressStatus(stat) {
    doContinue(stat);
}
jQuery.fn.reverse = [].reverse;

