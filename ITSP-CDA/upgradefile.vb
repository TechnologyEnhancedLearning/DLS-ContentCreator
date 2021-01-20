Public Class upgradefile
    Public Shared Property OldVersion As Decimal = CDec(1.071)

    Public Shared Function UpgradeFile(ByVal xmlstring As String, ByVal sFileName As String) As String
        xmlstring = CheckSchemaVersion(xmlstring, sFileName)
        If OldVersion < My.Settings.CurrentVersion Then
            MsgBox("This file was created in version " & OldVersion.ToString & " of the Content Creator. It has been upgraded to the current version " & My.Settings.CurrentVersion.ToString & ". This upgrade will become permanent once you save the file.", MsgBoxStyle.Information, "File upgraded")
        ElseIf OldVersion > My.Settings.CurrentVersion Then
            MsgBox("This file was created in newer version " & OldVersion.ToString & " of the Content Creator and will not work properly in this one. We recommend that you close the file and update your installed Content Creator before continuing.", MsgBoxStyle.Critical, "Content Creator needs updating")
        End If
        Return xmlstring
    End Function
    Public Shared Function CheckSchemaVersion(ByVal unittext As String, ByVal sFileName As String) As String
        Try
            'Check if the xml document has a schema version, if not assume that the file is version 1.071
            If Not unittext.Contains("<mstns:SchemaVersion>") Then
                unittext = unittext.Replace("<mstns:Type>", "<mstns:SchemaVersion>1.071</mstns:SchemaVersion><mstns:Type>")
                'if it is version 1.071 we need to add the editor visible element to Objects:
                If unittext.Contains("<mstns:Object>") And Not unittext.Contains("<mstns:EditorVisible>") Then
                    unittext = unittext.Replace("</mstns:Rotation>", "</mstns:Rotation><mstns:EditorVisible>True</mstns:EditorVisible>")
                End If
            End If
            Dim MyDoc As New System.Xml.XmlDocument
            MyDoc.LoadXml(unittext)
            Dim nsmgr = New System.Xml.XmlNamespaceManager(MyDoc.NameTable)
            nsmgr.AddNamespace("mstns", "https://www.itskill.nhs.uk/CDAFile.xsd")
            OldVersion = CDec(MyDoc.SelectSingleNode("/mstns:ITSPUnit/mstns:SchemaVersion", nsmgr).InnerText)
            'run through cumulative upgrades to current version:
            If OldVersion < CDec(1.073) Then
                If unittext.Contains("<mstns:StyleString>") Then
                    unittext = unittext.Replace("</mstns:StyleString>", "</mstns:StyleString><mstns:CSSClasses/>")
                End If
            End If
            If OldVersion < CDec(1.074) Then
                If unittext.Contains("<mstns:InstructionHPos>") Then
                    unittext = unittext.Replace("<mstns:InstructionHPos>", "<mstns:JudgeCorrectNextPage/><mstns:JudgeInCorrectNextPage/><mstns:InstructionHPos>")
                End If
            End If
            If OldVersion < CDec(1.082) Then
                unittext = unittext.Replace("<mstns:InstructionHPos>", "<mstns:ScoredInteraction>True</mstns:ScoredInteraction><mstns:InstructionHPos>")
            End If
            If OldVersion < CDec(1.083) Then
                unittext = unittext.Replace("<mstns:InstructionHPos>", "<mstns:ScoredInteractionIncorrect>True</mstns:ScoredInteractionIncorrect><mstns:InstructionHPos>")
            End If
            If OldVersion < CDec(1.087) Then
                unittext = unittext.Replace("<mstns:DragCursor>", "<mstns:SnapToTarget>False</mstns:SnapToTarget><mstns:DragCursor>")
            End If
            If OldVersion < CDec(1.088) Then
                unittext = unittext.Replace("<mstns:ShowObjectsWhenDragOver/>", "<mstns:AnimatedReset>True</mstns:AnimatedReset><mstns:ShowObjectsWhenDragOver/>")
                unittext = unittext.Replace("<mstns:ShowObjectsWhenDragOver>", "<mstns:AnimatedReset>True</mstns:AnimatedReset><mstns:ShowObjectsWhenDragOver>")
            End If
            If OldVersion < CDec(1.09) Then
                unittext = unittext.Replace("<mstns:JudgeOnSelectChange>", "<mstns:JudgeOnTab>False</mstns:JudgeOnTab><mstns:JudgeOnSelectChange>")
                unittext = unittext.Replace("</mstns:RequiredPassword>", "</mstns:RequiredPassword><mstns:JudgeOnTab>False</mstns:JudgeOnTab>")
            End If
            If OldVersion < CDec(1.098) Then
                unittext = unittext.Replace("<mstns:ShowObjects/>", "<mstns:ShowObjects/><mstns:PreventMouseDownFocus>True</mstns:PreventMouseDownFocus>")
                unittext = unittext.Replace("</mstns:ShowObjects>", "</mstns:ShowObjects><mstns:PreventMouseDownFocus>True</mstns:PreventMouseDownFocus>")
            End If
            If OldVersion < CDec(1.108) Then
                unittext = unittext.Replace("<mstns:SpecialKey/>", "<mstns:SpecialKey/><mstns:ShowObjects/><mstns:HideObjects/><mstns:AnimateObjects/><mstns:Toggle>False</mstns:Toggle>")
                unittext = unittext.Replace("</mstns:SpecialKey>", "</mstns:SpecialKey><mstns:ShowObjects/><mstns:HideObjects/><mstns:AnimateObjects/><mstns:Toggle>False</mstns:Toggle>")
            End If
            If OldVersion < CDec(1.112) Then
                unittext = unittext.Replace("</mstns:SnapToTarget>", "</mstns:SnapToTarget><mstns:DropType>Mouse inside target</mstns:DropType>")
            End If
            If OldVersion < CDec(1.113) Then
                unittext = unittext.Replace("<mstns:RequiredHtml/>", "<mstns:RequiredHtml/><mstns:IgnoreCase>False</mstns:IgnoreCase>")
                unittext = unittext.Replace("</mstns:RequiredHtml>", "</mstns:RequiredHtml><mstns:IgnoreCase>False</mstns:IgnoreCase>")
            End If
            If OldVersion < CDec(1.118) Then
                unittext = unittext.Replace("<mstns:ResizeType/>", "<mstns:ResizeType/><mstns:SnapGridWidth>0</mstns:SnapGridWidth><mstns:SnapGridHeight>0</mstns:SnapGridHeight>")
                unittext = unittext.Replace("</mstns:ResizeType>", "</mstns:ResizeType><mstns:SnapGridWidth>0</mstns:SnapGridWidth><mstns:SnapGridHeight>0</mstns:SnapGridHeight>")
            End If
            If OldVersion < CDec(1.119) Then
                unittext = unittext.Replace("<mstns:ResizeType/>", "<mstns:ResizeType/><mstns:CustomCursor/>")
                unittext = unittext.Replace("</mstns:ResizeType>", "</mstns:ResizeType><mstns:CustomCursor/>")
            End If
            If OldVersion < CDec(1.121) Then
                unittext = unittext.Replace("<mstns:SnapToTarget/>", "<mstns:SnapToTarget/><mstns:SnapGridWidth>0</mstns:SnapGridWidth><mstns:SnapGridHeight>0</mstns:SnapGridHeight>")
                unittext = unittext.Replace("</mstns:SnapToTarget>", "</mstns:SnapToTarget><mstns:SnapGridWidth>0</mstns:SnapGridWidth><mstns:SnapGridHeight>0</mstns:SnapGridHeight>")
            End If
            If OldVersion < CDec(1.122) Then
                unittext = unittext.Replace("<mstns:InstructionVPos/>", "<mstns:InstructionVPos/><mstns:IncludeNext>1</mstns:IncludeNext>")
                unittext = unittext.Replace("</mstns:InstructionVPos>", "</mstns:InstructionVPos><mstns:IncludeNext>1</mstns:IncludeNext>")
            End If
            If OldVersion < CDec(1.123) Then
                unittext = unittext.Replace("<mstns:HasFocus/>", "<mstns:HasFocus/><mstns:SendTextTargetObject/>")
                unittext = unittext.Replace("</mstns:HasFocus>", "</mstns:HasFocus><mstns:SendTextTargetObject/>")
            End If
            If OldVersion < CDec(1.137) Then
                unittext = unittext.Replace("<mstns:UseKeyboardNavigation/>", "<mstns:UseKeyboardNavigation/><mstns:SCOMasteryScore>85</mstns:SCOMasteryScore><mstns:SCODescription/><mstns:SCOKeyWords/>")
                unittext = unittext.Replace("</mstns:UseKeyboardNavigation>", "</mstns:UseKeyboardNavigation><mstns:SCOMasteryScore>85</mstns:SCOMasteryScore><mstns:SCODescription/><mstns:SCOKeyWords/>")
            End If
            If OldVersion < CDec(1.23) Then
                'Delete Output directory 
                Dim directoryName As String = IO.Path.GetDirectoryName(sFileName) & "\output"
                If (IO.Directory.Exists(directoryName)) Then
                    My.Computer.FileSystem.DeleteDirectory(directoryName, FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
                unittext = unittext.Replace("<mstns:FontSize>12</mstns:FontSize>", "<mstns:FontSize>16</mstns:FontSize>")
                'Remove pt values and replace with px:
                unittext = utility.ReplacePtsWithPx(unittext)
                'Update schema to include new elements:
                'TO DO
            End If
            Dim thisunit As New mstns.ITSPUnit
            'My.Computer.Clipboard.SetText(unittext)
            thisunit.FromXml(unittext)
            thisunit.SchemaVersion = My.Settings.CurrentVersion
            unittext = thisunit.ToXml
        Catch ex As Exception

        End Try


        Return unittext
    End Function
End Class
