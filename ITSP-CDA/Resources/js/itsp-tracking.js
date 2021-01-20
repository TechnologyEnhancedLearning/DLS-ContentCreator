var fixedtime = "0";
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
    CCPlayer.CustomisationID = getp('CustomisationID');
    CCPlayer.ContentType = getp('type');
    CCPlayer.Version = getp('Version');
    CCPlayer.SectionID = getp('SectionID');
    CCPlayer.CandidateID = getp('CandidateID');
    CCPlayer.ProgressID = getp('ProgressID');
    CCPlayer.TutorialID = getp('TutorialID');
    CCPlayer.PLAThresh = getp("plathresh");
    CCPlayer.TrackURL = getp("TrackURL");
    CCPlayer.myscore = 0;
    CCPlayer.wrongcount = 0;
    CCPlayer.SelectionEnd = 0;
    CCPlayer.SelectionStart = 0;
    if (CCPlayer.TrackURL == null) {
        CCPlayer.TrackURL = 'https://www.itskills.nhs.uk/tracking/tracker.aspx';
    }
    if (typeof CCPlayer.CustomisationID === 'undefined')
    {
        CCPlayer.IsTracked = false;
        CCPlayer.CustomisationID = "1";
        CCPlayer.ContentType = "learn";
        CCPlayer.Version = "2";
        CCPlayer.SectionID = "3";
        CCPlayer.CandidateID = "4";
        CCPlayer.ProgressID = "5";
        CCPlayer.PLAThresh = "85";
    }
    
    CCPlayer.MarkLearningComplete = function () {
        if (CCPlayer.IsTracked === true) {
            iscomplete = true;
            StoreProgressStatus("2");
        }
        else {
            alert('Learning complete');
        }
    };
    CCPlayer.CloseLearning = function () {
        if (CCPlayer.IsTracked === true) {
            if (iscomplete === false) { StoreProgressStatus("1"); }
            window.parent.closeMpe();
        }
        else {
            alert('Close learning');
            window.opener = window.self;
            window.close();
        }
    };
    CCPlayer.UpdateAssessmentScore = function (tutorialid, score) {
        //Mark the assessment as attempted. This will determine whether we should store the final assessment outcome:
        CCPlayer.AssessAttempted = true;
        //iterate through the objson objective list to find a matching tutorial id:
        var bFound = false;
        $.each(CCPlayer.objson, function (i, item) {
            
            if (item.tutorialid == tutorialid) {
                //it was correct, so increment the score:
                if (score > 0) { item.myscore = item.myscore + score; } else
                {
                    //it was incorrect, so increment the wrongcount:
                    item.wrongcount = item.wrongcount + 1;
                }
                bFound = true;
            }
        });
        if (bFound == false)
        {
            if (score > 0) { CCPlayer.myscore = CCPlayer.myscore + score; } else
            {
                CCPlayer.wrongcount = CCPlayer.wrongcount + 1;
            }
        }
    };
    CCPlayer.SubmitDiagnosticOutcome = function () {
        if (CCPlayer.ContentType === "diag" && CCPlayer.AssessAttempted === true) {
            //var tempjson = CCPlayer.objson;
            //$.each(tempjson, function (i, item) {
            //    item.tutorialname = 0;
            //});
            var jstring = JSON.stringify(CCPlayer.objson);
            var data = { action: "StoreDiagnosticJson", ProgressID: CCPlayer.ProgressID, DiagnosticOutcome: jstring };
            $.ajax({
                type: "POST",
                url: CCPlayer.TrackURL,
                data: data,
                dataType: String
            });
            CCPlayer.AssessAttempted = false;
        }
    };
    CCPlayer.SubmitPLAssessOutcome = function (pc) {
       
        if (CCPlayer.AssessAttempted === true) {
            var data = { action: "StoreASPAssessNoSession", CandidateID: CCPlayer.CandidateID, CustomisationID: CCPlayer.CustomisationID, Version: CCPlayer.Version, SectionID: CCPlayer.SectionID, Score: parseInt(pc, 10) };
            $.ajax({
                type: "POST",
                url: CCPlayer.TrackURL,
                data: data,
                dataType: String
            });
            CCPlayer.AssessAttempted = false;
        }
    };
    if (CCPlayer.ContentType !== "learn") {
        CCPlayer.AssessAttempted = false;
        CCPlayer.OutcomeAnimation = 0;
        objlist = getp('objlist');
        objlist = objlist.replace('[', '');
        objlist = objlist.replace(']', '');
        CCPlayer.ObjList = objlist.split(',');
        history.pushState(null, null, document.title);
        window.addEventListener('popstate', function () {
            history.pushState(null, null, document.title);
        });
        var ispl = false;
        if (CCPlayer.ContentType === "pl") { ispl = true; }
        var data = { action: "GetObjectiveArrayCC", CustomisationID: CCPlayer.CustomisationID, SectionID: CCPlayer.SectionID, IsPostLearning: ispl };
        $.ajax({
            type: "GET",
            url: CCPlayer.TrackURL,
            data: data,
            success: function (data, textStatus, jqXHR) {
                CCPlayer.objson = data.objectives;
                var deleteObjs = new Array();
                $.each(CCPlayer.objson, function (i, item) {
                    d = true;
                    var iv = item.tutorialid
                    $.each(CCPlayer.ObjList, function (ix, val) {

                        if (val == iv) { d = false; }
                    });
                    
                    if (d) { deleteObjs.push(i); }
                });
                $.each(deleteObjs.reverse(), function (i, v) {
                    CCPlayer.objson.splice(v, 1);
                })
            },
            error: function (jqxhr, stat, err) {
                alert(jqxhr + '     ' + err);
            }
        });
        
    }
}(window.CCPlayer = window.CCPlayer || {}, jQuery));
function StoreProgressStatus(stat) {
    if (startDate !== 0) {
        var currentDate = new Date().getTime();
        fixedtime = ((currentDate - startDate) / 60000);
    }
    if (CCPlayer.TutorialID != null) {
        var data = { action: "StoreASPProgressV2", TutorialStatus: stat, TutorialTime: fixedtime, ProgressID: CCPlayer.ProgressID, CandidateID: CCPlayer.CandidateID, Version: CCPlayer.Version, CustomisationID: CCPlayer.CustomisationID, TutorialID: CCPlayer.TutorialID };
    }
    else
    {
        var data = { action: "StoreASPProgressNoSession", TutorialStatus: stat, TutorialTime: fixedtime, ProgressID: CCPlayer.ProgressID, CandidateID: CCPlayer.CandidateID, Version: CCPlayer.Version, CustomisationID: CCPlayer.CustomisationID };
    }
       $.ajax({
        type: "POST",
        url: CCPlayer.TrackURL,
        data: data,
        dataType: String
    });
}
jQuery.fn.reverse = [].reverse;

