Public Class jsgenerate
#Region "JavaScript"
    Public Shared Function GenerateAnimateBehaviourJS(ByVal bhAnimate As mstns.AnimateBehaviour, ByVal obj As mstns.Object_, ByVal pg As mstns.Page) As String
        'setup function name
        Dim sFunctionName As String = Replace("Animate" & CDAMain.TidyObjectName(obj.ObjectName), "-", "") & utility.RandomString()
        CDAMain.objectAnimateFunctionList.Add(sFunctionName)
        Dim sLoopcountVar As String = "loopcount" & utility.RandomString()
        Dim returnJS As String = "var " & sLoopcountVar & " = 0;"
        'setup start function (in case a delay has been set):
        returnJS = returnJS & "function " & sFunctionName & "Start(){"
        returnJS = returnJS & "$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "')"
        'Check for different start positions and adjust:
        If bhAnimate.StartHPos <> 0 Then
            returnJS = returnJS & ".css('left', " & obj.HPos + bhAnimate.StartHPos & ")"
        End If
        If bhAnimate.StartVPos <> 0 Then
            returnJS = returnJS & ".css('top', " & obj.VPos + bhAnimate.StartVPos & ")"
        End If
        'set the start opacity:
        returnJS = returnJS & ".css('opacity', " & CStr(bhAnimate.StartOpacity) & ")"
        returnJS = returnJS & ";"
        If bhAnimate.AnimationDelay > 0 Then
            'add a delay method:
            returnJS = returnJS & "$(function() {setTimeout(" & sFunctionName & ", " & CStr(CInt(bhAnimate.AnimationDelay * 1000.0)) & ");});"
        Else
            returnJS = returnJS & sFunctionName & "();"
        End If
        returnJS = returnJS & "};"
        'setup outer function:

        returnJS = returnJS & "function " & sFunctionName & "(){"

        'If bhAnimate.AnimationDelay > 0 Then
        '    'add a delay method:
        '    returnJS = returnJS & ".delay( " & CStr(CInt(bhAnimate.AnimationDelay * 1000.0)) & ")"
        'End If
        returnJS = returnJS & "$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "')"
        'open the animate method:
        returnJS = returnJS & ".animate("
        'process horizontal movement animation:
        returnJS = returnJS & "{left: '+=" & bhAnimate.EndHPos - bhAnimate.StartHPos & "',"
        'process vertical movement animation:
        returnJS = returnJS & "top: '+=" & bhAnimate.EndVPos - bhAnimate.StartVPos & "',"
        'process opacity animation:
        returnJS = returnJS & "opacity: " & CStr(bhAnimate.EndOpacity) & ","

        'close the animate method:
        returnJS = returnJS & "}, " & CStr(CInt(bhAnimate.AnimationDuration * 1000.0)) & ", function() {"
        Dim sPage As String = bhAnimate.GoToPageOnFinish
        If sPage = "Next" Then
            sPage = CDAMain.GetNextPage(pg.PageName)
        ElseIf sPage = "Previous" Then
            sPage = CDAMain.GetPreviousPage(pg.PageName)
        ElseIf sPage = "Last" Then
            sPage = CDAMain.GetLastPage()
        End If
        If sPage = "" Then
            returnJS = returnJS & sLoopcountVar & " += 1; if(" & sLoopcountVar & " < " & bhAnimate.LoopCount & " || " & bhAnimate.LoopCount & " === -1 ){" & sFunctionName & "Return();};});"
        Else
            returnJS = returnJS & sLoopcountVar & " += 1; if(" & sLoopcountVar & " < " & bhAnimate.LoopCount & " || " & bhAnimate.LoopCount & " === -1 ){" & sFunctionName & "Return();} else {window.location.href = '" & utility.TidyFileName(sPage) & ".html';};});"
        End If
        'close outer function:
        returnJS = returnJS & "};"


        'setup  return outer function:

        returnJS = returnJS & "function " & sFunctionName & "Return(){"
        returnJS = returnJS & "$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "')"
        'Check for different start positions and adjust:
        If bhAnimate.StartHPos <> 0 Then
            returnJS = returnJS & ".css('left', " & obj.HPos + bhAnimate.EndHPos & ")"
        End If
        If bhAnimate.StartVPos <> 0 Then
            returnJS = returnJS & ".css('top', " & obj.VPos + bhAnimate.EndVPos & ")"
        End If
        'set the start opacity:
        returnJS = returnJS & ".css('opacity', " & CStr(bhAnimate.EndOpacity) & ")"
        'If bhAnimate.AnimationDelay > 0 Then
        '    'add a delay method:
        '    returnJS = returnJS & ".delay( " & CStr(CInt(bhAnimate.AnimationDelay * 1000.0)) & ")"
        'End If

        'open the animate method:
        returnJS = returnJS & ".animate("
        'process horizontal movement animation:
        returnJS = returnJS & "{left: '+=" & bhAnimate.StartHPos & "',"
        'process vertical movement animation:
        returnJS = returnJS & "top: '+=" & bhAnimate.StartVPos & "',"
        'process opacity animation:
        returnJS = returnJS & "opacity: " & CStr(bhAnimate.StartOpacity) & ","

        'close the animate method:
        returnJS = returnJS & "}, " & CStr(CInt(bhAnimate.AnimationDuration * 1000.0)) & ", function() {"
        If sPage = "" Then
            returnJS = returnJS & sLoopcountVar & " += 1; if(" & sLoopcountVar & " < " & bhAnimate.LoopCount & " || " & bhAnimate.LoopCount & " === -1 ){" & sFunctionName & "();};});"
        Else
            returnJS = returnJS & sLoopcountVar & " += 1; if(" & sLoopcountVar & " < " & bhAnimate.LoopCount & " || " & bhAnimate.LoopCount & " === -1 ){" & sFunctionName & "();} else {window.location.href = '" & utility.TidyFileName(sPage) & ".html';};});"
        End If
        'close outer function:
        returnJS = returnJS & "};"
        If bhAnimate.AutoStart Then
            returnJS = returnJS & sFunctionName & "Start();"
        End If
        'setup generic animate function that calls the specific animation function (this will result in multiple identical function names 
        Return returnJS
    End Function
    Public Shared Function GenerateMouseEventBehaviourJS(ByVal bhMouseInt As mstns.MouseInteractionBehaviour, ByVal obj As mstns.Object_, ByVal pg As mstns.Page) As String
        'setup function name
        Dim sFunctionName As String = Replace("MouseEvent" & CDAMain.TidyObjectName(obj.ObjectName), "-", "") & utility.RandomString()
        Dim sPage As String = utility.TidyFileName(bhMouseInt.GoToPage)
        If sPage = "" Then sPage = pg.JudgeCorrectNextPage
        If sPage = "Next" Then
            sPage = CDAMain.GetNextPage(pg.PageName)
        ElseIf sPage = "Previous" Then
            sPage = CDAMain.GetPreviousPage(pg.PageName)
        ElseIf sPage = "Last" Then
            sPage = CDAMain.GetLastPage()
        End If
        Dim returnJS As String = ""
        'if animate objects is set then add a boolean flag to say whether animation has been triggered:
        If bhMouseInt.AnimateObjects <> "" Then
            returnJS = returnJS & "var bAnimated = false;"
        End If
        'setup outer function:
        returnJS = returnJS & "function " & sFunctionName & "(){"
        returnJS = returnJS & "$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "')"
        Select Case bhMouseInt.MouseEvent
            Case "MouseEnter"
                returnJS = returnJS & ".mouseenter(function() {if (1>0){"
            Case "MouseLeave"
                returnJS = returnJS & ".mouseleave(function() {if (1>0){"
            Case "LeftMouseDown"
                returnJS = returnJS & ".mousedown(function(e) {"
                If bhMouseInt.PreventMouseDownFocus Then
                    returnJS = returnJS & "e.preventDefault();"
                End If
                returnJS = returnJS & "if (e.which === 1) {"
            Case "LeftMouseUp"
                If bhMouseInt.PreventMouseDownFocus Then
                    returnJS = returnJS & ".mousedown(function(e) {e.preventDefault();})"
                End If
                returnJS = returnJS & ".mouseup(function(e) {if (e.which === 1) {"
            Case "RightClick"
                If bhMouseInt.PreventMouseDownFocus Then
                    returnJS = returnJS & ".mousedown(function(e) {e.preventDefault();})"
                End If
                returnJS = returnJS & ".mousedown(function(e) {if (e.which === 3) {"
            Case "DoubleClick"
                If bhMouseInt.PreventMouseDownFocus Then
                    returnJS = returnJS & ".mousedown(function(e) {e.preventDefault();})"
                End If
                returnJS = returnJS & ".dblclick(function() {if (1>0){"
        End Select
        'Handle assessment correct:
        If bhMouseInt.AssessmentCorrect Then
            If CDAMain.itspunit.Type <> "Learning" And pg.ScoredInteraction Then
                returnJS = returnJS & "AssessmentOutcome(true, " & pg.ScoreTutorialID & ");"
            End If
            'Handle assessment incorrect:
        ElseIf bhMouseInt.AssessmentIncorrect Then
            If CDAMain.itspunit.Type <> "Learning" And pg.ScoredInteractionIncorrect Then
                returnJS = returnJS & "AssessmentOutcome(false, " & pg.ScoreTutorialID & ");"
            End If
            If CDAMain.itspunit.Type <> "Learning" And pg.PassNextPage <> "" Then
                sPage = utility.TidyFileName(pg.PassNextPage)
                If sPage = "Next" Then
                    sPage = CDAMain.GetNextPage(pg.PageName)
                ElseIf sPage = "Previous" Then
                    sPage = CDAMain.GetPreviousPage(pg.PageName)
                ElseIf sPage = "Last" Then
                    sPage = CDAMain.GetLastPage()
                End If
                returnJS = returnJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
            End If

            'Handle judge interaction check:
        ElseIf bhMouseInt.JudgeTask Then
            returnJS = returnJS & "JudgeInteraction();"
        End If
        'If go to page is set, sort out navigation:
        If Not utility.TidyFileName(bhMouseInt.GoToPage) = "" Or (bhMouseInt.AssessmentCorrect And sPage <> "") Then

            returnJS = returnJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
        End If
        'Check for objects to show on mouse event:
        If Not bhMouseInt.ShowObjects = "" Then
            Dim sObjs As String() = (Replace(bhMouseInt.ShowObjects, " ", "")).Split(New Char() {","c})
            For Each objName As String In sObjs
                If bhMouseInt.Toggle And bhMouseInt.MouseEvent <> "MouseEnter" And bhMouseInt.MouseEvent <> "MouseLeave" Then
                    returnJS = returnJS & "if ($('#" & objName & "').hasClass('object-hidden')){$('#" & objName & "').removeClass('object-hidden');}else{$('#" & objName & "').addClass('object-hidden');};"
                Else
                    returnJS = returnJS & "$('#" & objName & "').removeClass('object-hidden');"
                End If
                If bhMouseInt.Toggle And bhMouseInt.MouseEvent <> "MouseEnter" And bhMouseInt.MouseEvent <> "MouseLeave" Then
                    returnJS = returnJS & "if ($('#" & objName & "').hasClass('hiddenobj')){$('#" & objName & "').removeClass('hiddenobj');}else{$('#" & objName & "').addClass('hiddenobj');};"
                Else
                    returnJS = returnJS & "$('#" & objName & "').removeClass('hiddenobj');"
                End If
            Next
        End If
        'Check for objects to hide on mouse event:
        If Not bhMouseInt.HideObjects = "" Then
            Dim sObjs As String() = (Replace(bhMouseInt.HideObjects, " ", "")).Split(New Char() {","c})
            For Each objName As String In sObjs
                If bhMouseInt.Toggle And bhMouseInt.MouseEvent <> "MouseEnter" And bhMouseInt.MouseEvent <> "MouseLeave" Then
                    returnJS = returnJS & "if ($('#" & objName & "').hasClass('object-hidden')){$('#" & objName & "').removeClass('object-hidden');}else{$('#" & objName & "').addClass('object-hidden');};"
                Else
                    returnJS = returnJS & "$('#" & objName & "').addClass('object-hidden');"
                End If
                If bhMouseInt.Toggle And bhMouseInt.MouseEvent <> "MouseEnter" And bhMouseInt.MouseEvent <> "MouseLeave" Then
                    returnJS = returnJS & "if ($('#" & objName & "').hasClass('hiddenobj')){$('#" & objName & "').removeClass('hiddenobj');}else{$('#" & objName & "').addClass('hiddenobj');};"
                Else
                    returnJS = returnJS & "$('#" & objName & "').addClass('hiddenobj');"
                End If
            Next
        End If
        'Check for objects to animate on mouse event:
        If Not bhMouseInt.AnimateObjects = "" Then
            Dim sObjs As String() = (Replace(bhMouseInt.AnimateObjects, " ", "")).Split(New Char() {","c})
            For Each objName As String In sObjs
                returnJS = returnJS & "if (typeof " & Replace("AnimateAll" & CDAMain.TidyObjectName(objName), "-", "") & " !== 'undefined' && bAnimated === false) { "
                returnJS = returnJS & Replace("AnimateAll" & CDAMain.TidyObjectName(objName), "-", "") & "();"
                returnJS = returnJS & "}"
            Next
            returnJS = returnJS & "bAnimated = true;"
        End If
        'close event handler:
        returnJS = returnJS & "};})"
        'Check for objects to show on mouse event:
        If Not bhMouseInt.ShowObjects = "" Then
            Dim sObjs As String() = (Replace(bhMouseInt.ShowObjects, " ", "")).Split(New Char() {","c})
            For Each objName As String In sObjs
                If bhMouseInt.Toggle And bhMouseInt.MouseEvent = "MouseEnter" Then
                    returnJS = returnJS & ".mouseleave(function() {"
                    returnJS = returnJS & "$('#" & objName & "').addClass('object-hidden');})"
                ElseIf bhMouseInt.Toggle And bhMouseInt.MouseEvent = "MouseLeave" Then
                    returnJS = returnJS & ".mouseenter(function() {"
                    returnJS = returnJS & "$('#" & objName & "').addClass('object-hidden');})"
                End If
            Next
        End If
        'Check for objects to hide on mouse event:
        If Not bhMouseInt.HideObjects = "" Then
            Dim sObjs As String() = (Replace(bhMouseInt.HideObjects, " ", "")).Split(New Char() {","c})
            For Each objName As String In sObjs
                If bhMouseInt.Toggle And bhMouseInt.MouseEvent = "MouseEnter" Then
                    returnJS = returnJS & ".mouseleave(function() {"
                    returnJS = returnJS & "$('#" & objName & "').removeClass('object-hidden');})"
                ElseIf bhMouseInt.Toggle And bhMouseInt.MouseEvent = "MouseLeave" Then
                    returnJS = returnJS & ".mouseenter(function() {"
                    returnJS = returnJS & "$('#" & objName & "').removeClass('object-hidden');})"
                End If
            Next
        End If

        'close outer function:
        returnJS = returnJS & ";};"
        returnJS = returnJS & sFunctionName & "();"
        Return returnJS
    End Function
    Public Shared Function GenerateCustomJSBehaviourJS(ByVal bhCustomJS As mstns.CustomJavaScriptBehaviour, ByVal obj As mstns.Object_, ByVal pg As mstns.Page) As String
        Dim returnJS As String = ""
        returnJS = bhCustomJS.JavaScriptString
        Return returnJS
    End Function
    Public Shared Function GenerateDragBehaviourJS(ByVal bhDrag As mstns.DragBehaviour, ByVal obj As mstns.Object_, ByVal pg As mstns.Page) As String
        Dim returnJS As String = ""
        'Dim sFunctionName As String = Replace("Drag" & obj.ObjectName, "-", "") & utility.RandomString()
        'Set up a javascript variable to flag whether dragging is active
        Dim flagDragActive As String = Replace("DragFlag" & CDAMain.TidyObjectName(obj.ObjectName), "-", "") & utility.RandomString()
        returnJS = returnJS + "var " & flagDragActive & " = false;"
        'Set up a javascript variable to flag whether mouse is over correct drop target:
        Dim flagDropCorrect As String = Replace("DropCorrectFlag" & CDAMain.TidyObjectName(obj.ObjectName), "-", "") & utility.RandomString()
        returnJS = returnJS + "var " & flagDropCorrect & " = false;"
        'setup a judge drag interaction function:
        CDAMain.JudgeFunctionList.Add("judgeDrag" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", ""))
        returnJS = returnJS + "function judgeDrag" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", "") & " () {return " + flagDropCorrect + ";}"
        'Make the object draggable:
        returnJS = returnJS + "$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "').draggable({drag:function(o,i){var t=i.position.left-i.originalPosition.left,n=i.position.top-i.originalPosition.top;i.position.left=i.originalPosition.left/scale+t/scale,i.position.top=i.originalPosition.top/scale+n/scale},cursor: '" & bhDrag.DragCursor & "'"
        'check if a direction has been specified and add option if so
        If bhDrag.Direction = "Horizontal" Then
            returnJS = returnJS + ",axis:'x'"
        ElseIf bhDrag.Direction = "Vertical" Then
            returnJS = returnJS + ",axis:'y'"
        End If
        'check if limit to object has been set and contain if so:
        If bhDrag.LimitToObject <> "" Then
            returnJS = returnJS + ",containment:'#" & bhDrag.LimitToObject & "'"
        End If
        'check if we should return to start position (and do so) if not dropped correctly:
        If bhDrag.ResetOnMouseUp Then
            returnJS = returnJS + ",revert: 'invalid'"
            If Not bhDrag.AnimatedReset Then
                returnJS = returnJS + ",revertDuration: 0"
            End If
        End If
        'handle snap to grid settings:
        If bhDrag.SnapGridWidth > 0 Or bhDrag.SnapGridHeight > 0 Then
            returnJS = returnJS + ",grid: [ " & bhDrag.SnapGridWidth & ", " & bhDrag.SnapGridHeight & " ]"
        End If
        'Close the draggable method
        returnJS = returnJS + "});"
        'Flag dragging as active when drag starts:
        returnJS = returnJS + "$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "').on('dragstart', function (event, ui) { " & flagDragActive & " = true;});"
        'Set up target mouse enter and mouse leave functions to mark drop correct flag as true / false:
        If bhDrag.TargetObject <> "" Then
            Dim sTolerance As String = "touch"
            Select Case bhDrag.DropType
                Case "Mouse inside target"
                    sTolerance = "pointer"
                Case "Object inside target"
                    sTolerance = "fit"
            End Select
            returnJS = returnJS + "$('#" & bhDrag.TargetObject & "').droppable({tolerance: '" & sTolerance & "', drop: function( event, ui ) {"
            If bhDrag.SnapToTarget Then
                returnJS = returnJS + "dt = $('#" & bhDrag.TargetObject & "').css('top');"
                returnJS = returnJS + "dl = $('#" & bhDrag.TargetObject & "').css('left');"
                returnJS = returnJS + "$(ui.draggable.context).css({left: dl, top: dt}); "
            End If
            returnJS = returnJS + " if (ui.draggable.context.id == '" + CDAMain.TidyObjectName(obj.ObjectName) + "'){" & flagDropCorrect & " = true;"

            If bhDrag.GoToPageCorrect <> "" Then
                'CHECK FOR ASSESSMENT CORRECT HERE!!!!!
                returnJS = returnJS + "JudgeInteraction();"
                Dim sPage As String = utility.TidyFileName(bhDrag.GoToPageCorrect)
                If sPage = "Next" Then
                    sPage = CDAMain.GetNextPage(pg.PageName)
                ElseIf sPage = "Previous" Then
                    sPage = CDAMain.GetPreviousPage(pg.PageName)
                ElseIf sPage = "Last" Then
                    sPage = CDAMain.GetLastPage()
                End If
                returnJS = returnJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
            End If
            If bhDrag.AssessmentCorrect And pg.JudgeCorrectNextPage <> "" Then
                returnJS = returnJS + "JudgeInteraction();"
                Dim sPage As String = utility.TidyFileName(pg.JudgeCorrectNextPage)
                If sPage = "Next" Then
                    sPage = CDAMain.GetNextPage(pg.PageName)
                ElseIf sPage = "Previous" Then
                    sPage = CDAMain.GetPreviousPage(pg.PageName)
                ElseIf sPage = "Last" Then
                    sPage = CDAMain.GetLastPage()
                End If
                returnJS = returnJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
            End If
            returnJS = returnJS + "}else{" & flagDropCorrect & " = false;"
            If CDAMain.itspunit.Type <> "Learning" And pg.PassNextPage <> "" And bhDrag.AssessmentCorrect Then
                Dim sPage As String = utility.TidyFileName(pg.PassNextPage)
                If sPage = "Next" Then
                    sPage = CDAMain.GetNextPage(pg.PageName)
                ElseIf sPage = "Previous" Then
                    sPage = CDAMain.GetPreviousPage(pg.PageName)
                ElseIf sPage = "Last" Then
                    sPage = CDAMain.GetLastPage()
                End If
                returnJS = returnJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
            End If
            returnJS = returnJS + "}}});"
            If bhDrag.NavigateMouseDown And bhDrag.GoToPageCorrect <> "" Then
                'CHECK FOR ASSESSMENT CORRECT HERE!!!!!
                Dim sPage As String = utility.TidyFileName(bhDrag.GoToPageCorrect)
                If sPage = "Next" Then
                    sPage = CDAMain.GetNextPage(pg.PageName)
                ElseIf sPage = "Previous" Then
                    sPage = CDAMain.GetPreviousPage(pg.PageName)
                ElseIf sPage = "Last" Then
                    sPage = CDAMain.GetLastPage()
                End If
                returnJS = returnJS & "$('#" & bhDrag.TargetObject & "').on( 'dropover', function( event, ui ) {window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;});"

            End If
        End If
        'Set up show objects when dragging over (if set):
        If Not bhDrag.ShowObjectsWhenDragOver = "" Then
            Dim sObjs As String() = (Replace(bhDrag.ShowObjectsWhenDragOver, " ", "")).Split(New Char() {","c})
            For Each objName As String In sObjs
                'check if this isn't the target object and setup droppable and mark wrong code accordingly:
                If objName <> bhDrag.TargetObject Then
                    returnJS = returnJS + "if(!$('#" & objName & "').data('ui-draggable')){"
                    returnJS = returnJS + "$('#" & objName & "').droppable();};"
                End If
                returnJS = returnJS & "$('#" & objName & "').on( 'dropover', function( event, ui ) {$('#" & objName & "').removeClass('object-hidden');});"
                'if toggle then switch off on mouseleave:
                If bhDrag.Toggle Then
                    returnJS = returnJS + "$('#" & objName & "').on( 'dropout', function( event, ui ) {$('#" & objName & "').addClass('object-hidden');} );"
                    'returnJS = returnJS & ".mouseleave(function() {if (" & flagDragActive & " === true){"
                    'returnJS = returnJS & "$('#" & objName & "').addClass('object-hidden');}})"
                End If
            Next
        End If
        Return returnJS
    End Function
    Public Shared Function GenerateResizeBehaviourJS(ByVal bhResize As mstns.ResizeBehaviour, ByVal obj As mstns.Object_, ByVal pg As mstns.Page) As String
        Dim returnJS As String = ""
        'Set up a javascript variable to flag whether resizing is active
        Dim flagResizeActive As String = Replace("ResizeFlag" & CDAMain.TidyObjectName(obj.ObjectName), "-", "") & utility.RandomString()
        returnJS = returnJS + "var " & flagResizeActive & " = false;"
        'Make the object draggable:
        returnJS = returnJS + "$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "').resizable({minWidth:10*-$content.width(),minHeight:10*-$content.height(),resize:function(i,e){var t=e.size.width-e.originalSize.width,h=e.originalSize.width+t/scale,n=e.size.height-e.originalSize.height,g=e.originalSize.height+n/scale;e.size.width=h,e.size.height=g},"

        'set options according to the resize type:

        Select Case bhResize.ResizeType
            Case "Both"
                returnJS = returnJS + "aspectRatio: false"
            Case "Both - maintain ratio"
                returnJS = returnJS + "aspectRatio: true"
            Case "Horizontal"
                returnJS = returnJS + "handles: 'e, w'"
            Case "Vertical"
                returnJS = returnJS + "handles: 'n, s'"
        End Select
        'handle snap to grid settings:
        If bhResize.SnapGridWidth > 0 Or bhResize.SnapGridHeight > 0 Then
            returnJS = returnJS + ",grid: [ " & bhResize.SnapGridWidth & ", " & bhResize.SnapGridHeight & " ]"
        End If
        'handle max width setting:
        If bhResize.MaxWidth > 0 Then
            returnJS = returnJS + ",maxWidth: " & bhResize.MaxWidth
        End If
        'handle max height setting:
        If bhResize.MaxHeight > 0 Then
            returnJS = returnJS + ",maxHeight: " & bhResize.MaxHeight
        End If
        returnJS = returnJS + "});"
        'handle final size judgement:
        returnJS = returnJS + "if (typeof parent.CCPlayer == 'undefined') {$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "').on('resize', function (event, ui) { window.status = 'Object width: ' + $(this).outerWidth().toString() + ' height: ' + $(this).outerHeight().toString(); })};"
        returnJS = returnJS + "$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "').on('resizestop', function (event, ui) { if ($(this).outerWidth() >= " & bhResize.MinRequiredWidth & " && $(this).outerWidth() <= " & bhResize.MaxRequiredWidth & " && $(this).outerHeight() >= " & bhResize.MinRequiredHeight & " && $(this).outerHeight() <= " & bhResize.MaxRequiredHeight & " )"
        'the resize size is right - handle it:
        returnJS = returnJS + "{"
        'CHECK FOR ASSESSMENT CORRECT HERE!!!!!
        If CDAMain.itspunit.Type <> "Learning" And pg.ScoredInteraction Then
            returnJS = returnJS & "AssessmentOutcome(true, " & pg.ScoreTutorialID & ");"
            If pg.JudgeCorrectNextPage <> "" Then
                Dim sPage As String = utility.TidyFileName(pg.JudgeCorrectNextPage)
                If sPage = "Next" Then
                    sPage = CDAMain.GetNextPage(pg.PageName)
                ElseIf sPage = "Previous" Then
                    sPage = CDAMain.GetPreviousPage(pg.PageName)
                ElseIf sPage = "Last" Then
                    sPage = CDAMain.GetLastPage()
                End If
                returnJS = returnJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
            End If
        Else
            If bhResize.GoToPageCorrect <> "" Then
                Dim sPage As String = utility.TidyFileName(bhResize.GoToPageCorrect)
                If sPage = "Next" Then
                    sPage = CDAMain.GetNextPage(pg.PageName)
                ElseIf sPage = "Previous" Then
                    sPage = CDAMain.GetPreviousPage(pg.PageName)
                ElseIf sPage = "Last" Then
                    sPage = CDAMain.GetLastPage()
                End If
                returnJS = returnJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
            End If
        End If



        returnJS = returnJS + "}"
        'the resize size is wrong - handle it:
        returnJS = returnJS + "else{"
        'CHECK FOR ASSESSMENT INCORRECT HERE!!!!!
        If CDAMain.itspunit.Type <> "Learning" And pg.ScoredInteractionIncorrect Then
            returnJS = returnJS & "AssessmentOutcome(false, " & pg.ScoreTutorialID & ");"
        End If
        If CDAMain.itspunit.Type <> "Learning" And pg.PassNextPage <> "" Then
            Dim sPage As String = utility.TidyFileName(pg.PassNextPage)
            If sPage = "Next" Then
                sPage = CDAMain.GetNextPage(pg.PageName)
            ElseIf sPage = "Previous" Then
                sPage = CDAMain.GetPreviousPage(pg.PageName)
            ElseIf sPage = "Last" Then
                sPage = CDAMain.GetLastPage()
            End If
            returnJS = returnJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
        End If

        returnJS = returnJS + "}"
        returnJS = returnJS + "});"
        Return returnJS
    End Function
    Public Shared Function GenerateTextBehaviourJS(ByVal bhText As mstns.TextBehaviour, ByVal obj As mstns.Object_, ByVal pg As mstns.Page) As String
        Dim returnJS As String = ""
        Dim rs As String = utility.RandomString()
        returnJS = returnJS + "var txtDiv" + rs + " = document.getElementById('" & CDAMain.TidyObjectName(obj.ObjectName) & "-content');"
        returnJS = returnJS + "var reqDiv" + rs + " = document.getElementById('" & CDAMain.TidyObjectName(obj.ObjectName) & "-required');"
        If bhText.HasFocus Then
            'If bhText.SelectionStart = 0 And bhText.SelectionEnd = 0 Then
            returnJS = returnJS + "txtDiv" + rs + ".focus();"
            'Else
            If bhText.SelectionStart <> 0 Or bhText.SelectionEnd <> 0 Then
                returnJS = returnJS + "$(function() {"
                returnJS = returnJS + "setSelection(txtDiv" + rs + ", " & bhText.SelectionStart & ", " & bhText.SelectionEnd & ");"
                returnJS = returnJS + "});"
            End If
            'End If
        End If
        If bhText.SendTextTargetObject <> "" Then

            returnJS = returnJS + "$(function() {"
            returnJS = returnJS + "$('#" & bhText.SendTextTargetObject & "').html(stripSpanClass($('#" & CDAMain.TidyObjectName(obj.ObjectName) & "-content')[0].innerHTML));"
            returnJS = returnJS + "});"
        End If
        'check if a judge interaction function is required:
        If CDAMain.itspunit.Type = "Learning" Then
            CDAMain.JudgeFunctionList.Add("judge" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", ""))
        Else
            CDAMain.JudgeFunctionList.Add("judgeFunc" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", ""))
        End If
        If bhText.RequiredCharacterCount > -1 Or utility.StripHTML(bhText.RequiredHtml).Trim() <> "" Or (bhText.RequiredSelectStart >= 0 And bhText.RequiredSelectEnd >= 0) Then
            'setup a judge text interaction function:

            returnJS = returnJS + "function judgeFunc" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", "") & " () {var requirementsMet = false;"
            'CHECK IF THE CHARACTER COUNT REQUIRED HAS BEEN MET:
            If bhText.RequiredCharacterCount > -1 Then
                returnJS = returnJS + "if (getCharCount(txtDiv" + rs + ")==" & bhText.RequiredCharacterCount.ToString() & "){requirementsMet = true;} else {requirementsMet = false;};"
            End If
            'Check if the required text has been entered:
            Dim sReq As String = utility.StripHTML(bhText.RequiredHtml).Trim()
            If sReq <> "" Then
                'Now check if we should ignore case:
                returnJS = returnJS + "var myText = replaceNbsps(getText(txtDiv" + rs + "));"
                returnJS = returnJS + "var requiredText = replaceNbsps(getText(reqDiv" + rs + "));"
                If bhText.IgnoreCase Then
                    returnJS = returnJS + "if (myText.toLowerCase()==requiredText.toLowerCase()){requirementsMet = true;} else {requirementsMet = false;};"
                Else
                    returnJS = returnJS + "if (myText==requiredText){requirementsMet = true;} else {requirementsMet = false;};"
                End If

            End If
            'Check if the selection is correct:
            If bhText.RequiredSelectStart >= 0 And bhText.RequiredSelectEnd >= 0 Then
                returnJS = returnJS + "if (vSelectionStart >= " & bhText.RequiredSelectStart.ToString & "-1 && vSelectionStart <= " & bhText.RequiredSelectStart.ToString & "+1 && vSelectionEnd >= " & bhText.RequiredSelectEnd.ToString & "-1 && vSelectionEnd <= " & bhText.RequiredSelectEnd.ToString & "+1){requirementsMet = true;} else {requirementsMet = false;};"
            End If
            'handle the outcome:
            returnJS = returnJS + "return requirementsMet;};"
        Else
            returnJS = returnJS + "function judgeFunc" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", "") & " () {var requirementsMet = true;"
            returnJS = returnJS + "return requirementsMet;};"
        End If
        returnJS = returnJS + "function judge" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", "") & " () {"
        returnJS = returnJS + "if (judgeFunc" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", "") & "()===true){"
        Dim sPage As String = ""
        If CDAMain.itspunit.Type = "Learning" Then
            If bhText.GoToPageCorrect <> "" Then
                sPage = utility.TidyFileName(bhText.GoToPageCorrect)
                If sPage = "Next" Then
                    sPage = CDAMain.GetNextPage(pg.PageName)
                ElseIf sPage = "Previous" Then
                    sPage = CDAMain.GetPreviousPage(pg.PageName)
                ElseIf sPage = "Last" Then
                    sPage = CDAMain.GetLastPage()
                End If
                returnJS = returnJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
            End If
        Else
            'HANDLE ASSESSMENT CORRECT HERE!!!!
            If CDAMain.itspunit.Type <> "Learning" And pg.ScoredInteraction Then
                returnJS = returnJS & "AssessmentOutcome(true, " & pg.ScoreTutorialID & ");"
            End If
            If CDAMain.itspunit.Type <> "Learning" And pg.JudgeCorrectNextPage <> "" Then
                sPage = utility.TidyFileName(pg.JudgeCorrectNextPage)
                If sPage = "Next" Then
                    sPage = CDAMain.GetNextPage(pg.PageName)
                ElseIf sPage = "Previous" Then
                    sPage = CDAMain.GetPreviousPage(pg.PageName)
                ElseIf sPage = "Last" Then
                    sPage = CDAMain.GetLastPage()
                End If
                returnJS = returnJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
            End If
        End If



        returnJS = returnJS + "} else {"
        'HANDLE ASSSESSMENT INCORRECT HERE!!!
        If bhText.JudgeOnKeyup = False And bhText.JudgeOnSelectChange = False Then
            If CDAMain.itspunit.Type = "Learning" Then
                If bhText.GoToPageIncorrect <> "" Then
                    sPage = utility.TidyFileName(bhText.GoToPageIncorrect)
                    If sPage = "Next" Then
                        sPage = CDAMain.GetNextPage(pg.PageName)
                    ElseIf sPage = "Previous" Then
                        sPage = CDAMain.GetPreviousPage(pg.PageName)
                    ElseIf sPage = "Last" Then
                        sPage = CDAMain.GetLastPage()
                    End If
                    returnJS = returnJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
                End If
            Else
                If CDAMain.itspunit.Type <> "Learning" And pg.ScoredInteractionIncorrect Then
                    returnJS = returnJS & "AssessmentOutcome(false, " & pg.ScoreTutorialID & ");"
                End If
                If CDAMain.itspunit.Type <> "Learning" And pg.PassNextPage <> "" Then
                    sPage = utility.TidyFileName(pg.PassNextPage)
                    If sPage = "Next" Then
                        sPage = CDAMain.GetNextPage(pg.PageName)
                    ElseIf sPage = "Previous" Then
                        sPage = CDAMain.GetPreviousPage(pg.PageName)
                    ElseIf sPage = "Last" Then
                        sPage = CDAMain.GetLastPage()
                    End If
                    returnJS = returnJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
                End If
            End If
        End If

        'close the function:
        returnJS = returnJS + "};}"
        'handle various judge on events:
        returnJS = returnJS + "$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "-content').keyup(function( event ) {"
        If bhText.JudgeOnKeyup Then
            If bhText.RequiredCharacterCount > -1 Or bhText.RequiredHtml <> "" Or (bhText.RequiredSelectStart >= 0 And bhText.RequiredSelectEnd >= 0) Then
                returnJS = returnJS + "judge" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", "") & "();"
            End If
        End If
        'If bhText.SendTextTargetObject <> "" Then
        '    returnJS = returnJS + "var $content = $('#" & CDAMain.TidyObjectName(obj.ObjectName) & "').clone();$('#" & bhText.SendTextTargetObject & "').html($content);"
        'End If
        returnJS = returnJS + "if (typeof sessionStorage == 'undefined'){window.name = $('#" & CDAMain.TidyObjectName(obj.ObjectName) & "-content')[0].innerHTML;}else"
        returnJS = returnJS + "{sessionStorage.setItem('storedTextHTML', $('#" & CDAMain.TidyObjectName(obj.ObjectName) & "-content')[0].innerHTML);};"
        If bhText.SendTextTargetObject <> "" Then
            returnJS = returnJS + "if (typeof sessionStorage == 'undefined'){$('#" & bhText.SendTextTargetObject & "').html(stripSpanClass(window.name));}else"
            returnJS = returnJS + "{$('#" & bhText.SendTextTargetObject & "').html(stripSpanClass(sessionStorage.getItem('storedTextHTML')));};"
        End If
        returnJS = returnJS + "SelectionChanged(txtDiv" + rs + ");"
        returnJS = returnJS + "if ( event.which == 37 || event.which == 38 || event.which == 39 || event.which == 40  ) { if(event.shiftKey == true){"
        If bhText.JudgeOnSelectChange Then
            returnJS = returnJS + "judge" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", "") & "();"
        End If
        returnJS = returnJS + "}};;});"
        returnJS = returnJS + "$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "-content').mouseup(function() {SelectionChanged(txtDiv" + rs + ");"
        If bhText.JudgeOnSelectChange Then
            returnJS = returnJS + "judge" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", "") & "();"
        End If

        returnJS = returnJS + "});"
        If bhText.JudgeOnReturn Or bhText.JudgeOnTab Then
            If bhText.RequiredCharacterCount > -1 Or bhText.RequiredHtml <> "" Or (bhText.RequiredSelectStart >= 0 And bhText.RequiredSelectEnd >= 0) Then
                returnJS = returnJS + "$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "-content').keydown(function( event ) {"
                If bhText.JudgeOnReturn Then
                    returnJS = returnJS + "if ( event.which == 13 ) {judge" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", "") & "();};"
                End If
                If bhText.JudgeOnTab Then
                    returnJS = returnJS + "if ( event.which == 9 ) {judge" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", "") & "();};"
                End If
            End If
            returnJS = returnJS + "});"
        End If
        If bhText.JudgeOnTab Then
            If bhText.RequiredCharacterCount > -1 Or bhText.RequiredHtml <> "" Or (bhText.RequiredSelectStart >= 0 And bhText.RequiredSelectEnd >= 0) Then
                returnJS = returnJS + "$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "-content').keydown(function( event ) {"
                returnJS = returnJS + "if ( event.which == 13 ) {judge" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", "") & "();};});"
            End If
        End If
        'Load in the retained text if set:
        If bhText.RetainPreviousText Then
            returnJS = returnJS + "if (typeof sessionStorage == 'undefined'){$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "-content').html(window.name);}else"
            returnJS = returnJS + "{$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "-content').html(sessionStorage.getItem('storedTextHTML'));};"
            returnJS = returnJS + "if (typeof parent.CCPlayer !== 'undefined') {setSelection(txtDiv" + rs + ", parent.CCPlayer.SelectionStart, parent.CCPlayer.SelectionEnd);}"
        End If

        Return returnJS
    End Function
    Public Shared Function GenerateFollowMouseBehaviourJS(ByVal bhFollow As mstns.FollowMouseBehaviour, ByVal obj As mstns.Object_, ByVal pg As mstns.Page) As String
        Dim returnJS As String = ""
        returnJS = returnJS + "$(document).on('mousemove', function(e){$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "').css({left:  e.pageX + " & bhFollow.OffsetHPixels & ", top:   e.pageY + " & bhFollow.OffsetVPixels & "});});"
        Return returnJS
    End Function
    Public Shared Function GenerateKeyboardShortcutBehaviourJS(ByVal bhKeyboard As mstns.KeyboardShortcutBehaviour, ByVal obj As mstns.Object_, ByVal pg As mstns.Page) As String
        Dim returnJS As String = ""
        Dim sKBReq As String = ""
        If bhKeyboard.AltDown Then
            sKBReq = sKBReq & "alt+"
        End If
        If bhKeyboard.CtrlDown Then
            sKBReq = sKBReq & "ctrl+"
        End If
        If bhKeyboard.ShiftDown Then
            sKBReq = sKBReq & "shift+"
        End If
        If bhKeyboard.SpecialKey <> "" Then
            sKBReq = sKBReq & bhKeyboard.SpecialKey

        ElseIf bhKeyboard.KeyToPress <> "" And bhKeyboard.KeyToPress <> "ANY" Then

            sKBReq = sKBReq & bhKeyboard.KeyToPress
        End If

        If sKBReq <> "" Then
            'returnJS = returnJS + "$(document, '#" & CDAMain.TidyObjectName(obj.ObjectName) & "-content').on('keydown', null, '" & sKBReq & "', function(){"
            returnJS = returnJS + "$(document, '#" & CDAMain.TidyObjectName(obj.ObjectName) & "-content').bind('keyup', '" & sKBReq & "', function(){"
        Else
            returnJS = returnJS + "$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "-content').keypress( function(){"
        End If
        'check object is visible first:

        returnJS = returnJS + "if ($('#" & CDAMain.TidyObjectName(obj.ObjectName) & "').hasClass('hiddenobj') == false && $('#" & CDAMain.TidyObjectName(obj.ObjectName) & "').hasClass('object-hidden') == false){"
        'HANDLE ASSESSMENT CORRECT HERE!!!!
        If CDAMain.itspunit.Type <> "Learning" And pg.ScoredInteraction And bhKeyboard.AssessCorrect Then
            returnJS = returnJS & "AssessmentOutcome(true, " & pg.ScoreTutorialID & ");"
        End If
        'They pressed it, what next?
        Dim sPage As String = utility.TidyFileName(bhKeyboard.GoToPage)
        If sPage = "" And bhKeyboard.AssessCorrect Then sPage = utility.TidyFileName(pg.JudgeCorrectNextPage)
        If sPage <> "" Then
            If sPage = "Next" Then
                sPage = CDAMain.GetNextPage(pg.PageName)
            ElseIf sPage = "Previous" Then
                sPage = CDAMain.GetPreviousPage(pg.PageName)
            ElseIf sPage = "Last" Then
                sPage = CDAMain.GetLastPage()
            End If
            returnJS = returnJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
        End If
        'Check for objects to show on mouse event:

        If Not bhKeyboard.ShowObjects = "" Then
            Dim sObjs As String() = (Replace(bhKeyboard.ShowObjects, " ", "")).Split(New Char() {","c})
            For Each objName As String In sObjs
                If bhKeyboard.Toggle Then
                    returnJS = returnJS & "if ($('#" & objName & "').hasClass('object-hidden')){$('#" & objName & "').removeClass('object-hidden');}else{$('#" & objName & "').addClass('object-hidden');};"
                    returnJS = returnJS & "if ($('#" & objName & "').hasClass('hiddenobj')){$('#" & objName & "').removeClass('hiddenobj');}else{$('#" & objName & "').addClass('hiddenobj');};"
                Else
                    returnJS = returnJS & "$('#" & objName & "').removeClass('object-hidden');"
                    returnJS = returnJS & "$('#" & objName & "').removeClass('hiddenobj');"
                End If
            Next
        End If
        'Check for objects to hide on mouse event:
        If Not bhKeyboard.HideObjects = "" Then
            Dim sObjs As String() = (Replace(bhKeyboard.HideObjects, " ", "")).Split(New Char() {","c})
            For Each objName As String In sObjs
                If bhKeyboard.Toggle Then
                    returnJS = returnJS & "if ($('#" & objName & "').hasClass('object-hidden')){$('#" & objName & "').removeClass('object-hidden');}else{$('#" & objName & "').addClass('object-hidden');};"
                Else
                    returnJS = returnJS & "$('#" & objName & "').addClass('hiddenobj');"
                    returnJS = returnJS & "$('#" & objName & "').addClass('object-hidden');"
                End If

            Next
        End If
        returnJS = returnJS + "}});"
        'Add set focus to element using jquery:
        returnJS = returnJS + "$( '#" & CDAMain.TidyObjectName(obj.ObjectName) & "' ).focus();"
        Return returnJS
    End Function
    Public Shared Function GeneratePasswordBehaviourJS(ByVal bhPassword As mstns.PasswordBehaviour, ByVal obj As mstns.Object_, ByVal pg As mstns.Page) As String
        Dim returnJS As String = ""
        'Set up judge password function:
        If bhPassword.RequiredPassword.Length > 0 Then
            returnJS = returnJS + "function pwjudge" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", "") & " () {var requirementsMet = false;if($('#pwd-" & CDAMain.TidyObjectName(obj.ObjectName) & "').val() == '" & bhPassword.RequiredPassword & "'){requirementsMet = true;};"
        End If
        'add required judge event handlers:
        'handle the outcome:
        returnJS = returnJS + "if (requirementsMet===true){"
        'HANDLE ASSESSMENT CORRECT HERE!!!!
        If CDAMain.itspunit.Type <> "Learning" And pg.ScoredInteraction Then
            returnJS = returnJS & "AssessmentOutcome(true, " & pg.ScoreTutorialID & ");"
        End If

        If bhPassword.GoToPageCorrect <> "" Then
            Dim sPage As String = utility.TidyFileName(bhPassword.GoToPageCorrect)
            If sPage = "Next" Then
                sPage = CDAMain.GetNextPage(pg.PageName)
            ElseIf sPage = "Previous" Then
                sPage = CDAMain.GetPreviousPage(pg.PageName)
            ElseIf sPage = "Last" Then
                sPage = CDAMain.GetLastPage()
            End If
            returnJS = returnJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
        Else
            If CDAMain.itspunit.Type <> "Learning" And pg.JudgeCorrectNextPage <> "" Then
                Dim sPage As String = utility.TidyFileName(pg.JudgeCorrectNextPage)
                If sPage = "Next" Then
                    sPage = CDAMain.GetNextPage(pg.PageName)
                ElseIf sPage = "Previous" Then
                    sPage = CDAMain.GetPreviousPage(pg.PageName)
                ElseIf sPage = "Last" Then
                    sPage = CDAMain.GetLastPage()
                End If
                returnJS = returnJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
            End If
        End If
        returnJS = returnJS + "} else {"
        'HANDLE ASSSESSMENT INCORRECT HERE!!!
        If CDAMain.itspunit.Type <> "Learning" And pg.ScoredInteractionIncorrect Then
            returnJS = returnJS & "AssessmentOutcome(false, " & pg.ScoreTutorialID & ");"
        End If
        If CDAMain.itspunit.Type <> "Learning" And pg.PassNextPage <> "" Then
            Dim sPage As String = utility.TidyFileName(pg.PassNextPage)
            If sPage = "Next" Then
                sPage = CDAMain.GetNextPage(pg.PageName)
            ElseIf sPage = "Previous" Then
                sPage = CDAMain.GetPreviousPage(pg.PageName)
            ElseIf sPage = "Last" Then
                sPage = CDAMain.GetLastPage()
            End If
            returnJS = returnJS & "window.location.href = '" & utility.TidyFileName(sPage) & ".html' + qs;"
        End If

        'close the function:
        returnJS = returnJS + "};return requirementsMet;};"
        'handle various judge on events:

        If bhPassword.JudgeOnKeyup Then
            returnJS = returnJS + "$('#pwd-" & CDAMain.TidyObjectName(obj.ObjectName) & "').keyup(function() {"
            returnJS = returnJS + "pwjudge" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", "") & "();});"
        End If
        'check if a judge interaction function is required:

        CDAMain.JudgeFunctionList.Add("pwjudge" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", ""))

        If bhPassword.JudgeOnEnter Or bhPassword.JudgeOnTab Then
            returnJS = returnJS + "$('#pwd-" & CDAMain.TidyObjectName(obj.ObjectName) & "').keydown(function( event ) {"
            If bhPassword.JudgeOnEnter Then
                returnJS = returnJS + "if ( event.which == 13 ) {pwjudge" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", "") & "();};"
            End If
            If bhPassword.JudgeOnTab Then
                returnJS = returnJS + "if ( event.which == 9 ) {pwjudge" & Replace(Replace(CDAMain.TidyObjectName(obj.ObjectName), "-", ""), " ", "") & "();};"
            End If
            returnJS = returnJS + "});"
        End If
        If bhPassword.HasFocus Then
            returnJS = returnJS + "$( '#pwd-" & CDAMain.TidyObjectName(obj.ObjectName) & "' ).focus();"
        End If
        Return returnJS
    End Function
    Public Shared Function GenerateSpinnerBehaviourJS(ByVal bhSpinner As mstns.SpinnerBehaviour, ByVal obj As mstns.Object_, ByVal pg As mstns.Page) As String
        Dim returnJS As String = ""
        'setup function name
        Dim sFunctionName As String = Replace("SpinnerEvent" & CDAMain.TidyObjectName(obj.ObjectName), "-", "") & utility.RandomString()
        'setup outer function
        returnJS = returnJS & "function " & sFunctionName & "(){"
        returnJS = returnJS & "$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "')"
        returnJS = returnJS & ".mouseup(function(e) {if (e.which === 1) {"
        'do the spinner stuff:
        returnJS = returnJS & "var t = getText(document.getElementById('" & bhSpinner.TextAreaObject & "-content'));"
        returnJS = returnJS & "if (t.indexOf(' ') !== -1) {t = t.substr(0, t.indexOf(' '));}"
        'parse the number appropriately:
        If bhSpinner.DecimalPoints = 0 Then
            returnJS = returnJS & "t = parseInt(t);"
        Else
            returnJS = returnJS & "t = parseFloat(t).toFixed(" & bhSpinner.DecimalPoints & ");"
        End If
        returnJS = returnJS & "if (isNaN(t)){t=0;};"
        'increment or decrement the number appropriately:
        If bhSpinner.Direction = "Up" Then
            If bhSpinner.DecimalPoints = 0 Then
                returnJS = returnJS & "t = t + " & bhSpinner.StepSize & ";"
            Else
                returnJS = returnJS & "t = parseFloat(t) + parseFloat(" & bhSpinner.StepSize & ");"
            End If
        Else
            If bhSpinner.DecimalPoints = 0 Then
                returnJS = returnJS & "t = t - " & bhSpinner.StepSize & ";"
            Else
                returnJS = returnJS & "t = parseFloat(t) - parseFloat(" & bhSpinner.StepSize & ");"
            End If
        End If
        'check if max or min exceeded and correct if so:
        returnJS = returnJS & "if (t < " & bhSpinner.MinVal & "){t = " & bhSpinner.MinVal & ";};"
        returnJS = returnJS & "if (t > " & bhSpinner.MaxVal & "){t = " & bhSpinner.MaxVal & ";};"
        'parse the number appropriately again:
        If bhSpinner.DecimalPoints = 0 Then
            returnJS = returnJS & "t = parseInt(t);"
        Else
            returnJS = returnJS & "t = parseFloat(t).toFixed(" & bhSpinner.DecimalPoints & ");"
        End If
        returnJS = returnJS & "str = t.toString();"
        If bhSpinner.Units <> "" Then
            returnJS = returnJS & "str = str + ' " & bhSpinner.Units & "';"
        End If
        'returnJS = returnJS & "var orignalstring = document.getElementById('" & bhSpinner.TextAreaObject & "-content').innerHTML;"
        'returnJS = returnJS & "var newstring = orignalstring.replace(getText(document.getElementById('" & bhSpinner.TextAreaObject & "-content')),str);"
        'returnJS = returnJS & "document.getElementById('" & bhSpinner.TextAreaObject & "-content').innerHTML = newstring;"
        returnJS = returnJS & "setText(document.getElementById('" & bhSpinner.TextAreaObject & "-content'), str);"
        'handle judge check:
        If bhSpinner.JudgeOnClick Then
            '  If CDAMain.itspunit.Type = "Learning" Then
            returnJS = returnJS + "judge" & Replace(Replace(bhSpinner.TextAreaObject, "-", ""), " ", "") & " ();"
            'Else
            '      returnJS = returnJS & "JudgeInteraction();"
            '   End If
        End If
        'close event handler:
        returnJS = returnJS & "};})"
        'close outer function:
        returnJS = returnJS & ";};"
        returnJS = returnJS & sFunctionName & "();"
        Return returnJS
    End Function
    Public Shared Function GenerateSelectableBehaviourJS(ByVal bhSelectable As mstns.SelectableBehaviour, ByVal obj As mstns.Object_, ByVal pg As mstns.Page) As String
        Dim returnJS As String = ""
        returnJS = returnJS & "$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "').addClass('q-choice');"
        returnJS = returnJS & "$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "').mouseup(function(e) {"
        If Not bhSelectable.MultiSelectEnabled Then
            returnJS = returnJS & "$('.object').removeClass('object-selected');"
        End If
        returnJS = returnJS & "if ($('#" & CDAMain.TidyObjectName(obj.ObjectName) & "').hasClass('object-selected')){$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "').removeClass('object-selected');}else{$('#" & CDAMain.TidyObjectName(obj.ObjectName) & "').addClass('object-selected');}"
        returnJS = returnJS & "});"
        CDAMain.JudgeFunctionList.Add("getQuizResult")
        Return returnJS
    End Function
#End Region
#Region "CSS"
    Public Shared Function GenerateCustomCSSBehaviourCSS(ByVal bhCustomCSS As mstns.CustomCssBehaviour, ByVal obj As mstns.Object_, ByVal pg As mstns.Page) As String
        Dim returnCSS As String = ""
        'replace ; with !important; to make sure all CSS styles are applied, also remove any existing !important s before we do this, just in case:
        returnCSS = returnCSS + Replace(Replace(bhCustomCSS.StyleString, "!important", ""), ";", " !important;")
        Return returnCSS
    End Function
    Public Shared Function GenerateMousePointerBehaviourCSS(ByVal bhMousePointer As mstns.ChangeMousePointerBehaviour, ByVal obj As mstns.Object_, ByVal pg As mstns.Page, ByVal imgfolder As String) As String
        Dim returnCSS As String = ""
        If bhMousePointer.CustomPointerImage <> "" Then
            Dim imgPath As String = imgfolder & bhMousePointer.CustomPointerImage & ".cur"
            returnCSS = returnCSS + "#" & CDAMain.TidyObjectName(obj.ObjectName) & "{cursor: url(" & imgPath & "), default !important;}"
        ElseIf bhMousePointer.MouseInPointer <> "" Then
            returnCSS = returnCSS + "#" & CDAMain.TidyObjectName(obj.ObjectName) & ":hover{cursor:" & bhMousePointer.MouseInPointer & " !important;}"
            If bhMousePointer.MouseDownPointer <> "" Then
                returnCSS = returnCSS + "#" & CDAMain.TidyObjectName(obj.ObjectName) & ":active{cursor:" & bhMousePointer.MouseDownPointer & " !important;}"
            End If
        End If
        Return returnCSS
    End Function
    Public Shared Function GenerateSelectableCSS(ByVal bhSelectable As mstns.SelectableBehaviour, ByVal obj As mstns.Object_, ByVal pg As mstns.Page) As String
        Dim returnCSS As String = ""
        'replace ; with !important; to make sure all CSS styles are applied, also remove any existing !important s before we do this, just in case:
        returnCSS = returnCSS + Replace(Replace(bhSelectable.SelectedCSS, "!important", ""), ";", " !important;")
        returnCSS = "#" & CDAMain.TidyObjectName(obj.ObjectName) & ".object-selected{" & returnCSS & "}"
        Return returnCSS
    End Function
    Public Shared Function GenerateResizeBehaviourCSS(ByVal bhResize As mstns.ResizeBehaviour, ByVal imgfolder As String) As String
        Dim imgPath As String = imgfolder & bhResize.CustomCursor & ".cur"
        Dim sCursor As String = "url(" & imgPath & "), default"
        Dim returnCSS As String = ".ui-resizable-n{cursor:mycursor}.ui-resizable-s{cursor:mycursor}.ui-resizable-e{cursor:mycursor}.ui-resizable-w{cursor:mycursor}.ui-resizable-se{cursor:mycursor}.ui-resizable-sw{cursor:mycursor}.ui-resizable-nw{cursor:mycursor}.ui-resizable-ne{cursor:mycursor}"
        'replace ; with !important; to make sure all CSS styles are applied, also remove any existing !important s before we do this, just in case:
        returnCSS = Replace(returnCSS, "mycursor", sCursor & " !important")
        Return returnCSS
    End Function
#End Region

End Class