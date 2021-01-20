Imports LiquidTechnologies.Viewer.Net45

'**********************************************************************************************
'* Copyright (c) 2001-2015 Liquid Technologies Limited. All rights reserved.
'* See www.liquid-technologies.com for product details.
'*
'* Please see products End User License Agreement for distribution permissions.
'*
'* WARNING: THIS FILE IS GENERATED
'* Changes made outside of ##HAND_CODED_BLOCK_START blocks will be overwritten
'*
'* Generation  : by Liquid XML Data Binder 13.2.0.5980
'* Using Schema: W:\NHS CfH ICT Contract\2015-2017 Work\Content Management and Development\CDA\ITSPCDA.xsd
'**********************************************************************************************

Public Class SampleApp
    Inherits System.Windows.Forms.Form

	#Region "btnLoad_Click - Opens the selected file - (THIS IS A GOOD PLACE TO START)"
	' When an item is selected from the ListBox, this event handler is called.
	' 
	' If you specified Sample files in the Liquid XML wizard then they will be listed
	' in the switch statement.
	' If you did not specify Samples then there are 2 routes forward. You can either
	' use the "Browse for a File to Load", this will load the sample using a generic load
	' method. Alternatively you can run one of the SimpleTestXXXXX("<filename>") methods
	' This will load the file into the correct object, and display it in the viewer.
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click, lstFiles.DoubleClick
        Me.Cursor = Cursors.WaitCursor

        Select Case lstFiles.SelectedIndex
			Case 0
                If (OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
                    SimpleTest(OpenFileDialog1.FileName)
				End If
            Case 1
				' * ---------------------------------------------------------------------------------
				' * This will load the sample file 
				' * "W:\NHS CfH ICT Contract\2015-2017 Work\Content Management and Development\CDA\ITSPCDASample.xml.testouput.xml"
				' * and demonstrate briefly how to use it.
				' * ---------------------------------------------------------------------------------
				SimpleTestmstnsITSPUnit("W:\NHS CfH ICT Contract\2015-2017 Work\Content Management and Development\CDA\ITSPCDASample.xml.testouput.xml")
			
        End Select

		' * ---------------------------------------------------------------------------------
		' * This function can be used to open an XML document with a document element 
		' * (the first element in the file) named 'ChangeHistory' 
		' * e.g. 
		' *
		' * <?xml version="1.0" encoding="UTF-8"?>
		' * <ChangeHistory>
		' *     ...
		' * </ChangeHistory>
		' * ---------------------------------------------------------------------------------
		' SimpleTestmstnsChangeHistory("<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>")
			
		' * ---------------------------------------------------------------------------------
		' * This function can be used to open an XML document with a document element 
		' * (the first element in the file) named 'ITSPUnit' 
		' * e.g. 
		' *
		' * <?xml version="1.0" encoding="UTF-8"?>
		' * <ITSPUnit>
		' *     ...
		' * </ITSPUnit>
		' * ---------------------------------------------------------------------------------
		' SimpleTestmstnsITSPUnit("<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>")
			
        Me.Cursor = Cursors.Default
	End Sub
	#End Region

	#Region "Sample Functions Demonstrating Reading from an XML File"
	#Region "SimpleTestmstnsChangeHistory - Demo for documents with a root <ChangeHistory>"
	' Shows a simple example of how the class ChangeHistory
	' can be used. This class can be used to load documents whose 
	' root (document) element is <ChangeHistory>.
	Private Sub SimpleTestmstnsChangeHistory(ByVal filename As String)
		Try
			' create an instance of the class to load the XML file into
			Dim elm As mstns.ChangeHistory = New mstns.ChangeHistory()
			
			' load the xml from a file into the object (the root element in the
			' xml document must be <ChangeHistory>.
			elm.FromXmlFile(filename)

			' This will open up a viewer, allowing you to navigate the classes
			' that have been generated. 
			' Note the viewer can be used to modify properties, and provides a listing of
			' the code required to create the document it is displaying.
			Dim sv As LiquidTechnologies.Viewer.Net45.SimpleViewer = New LiquidTechnologies.Viewer.Net45.SimpleViewer(elm)
			sv.ShowDialog()

			' You can then add code to navigate the data held in the class.
			' When navigating this object model you should refer to the documentation
			' generated in the directory:
			' W:\NHS CfH ICT Contract\2015-2017 Work\Content Management and Development\CDA\CDA_Schema_Documentation\.
			' The help should be compiled into a chm before being used, (use build.bat)
			' - HTML Help Workshop is required to perform this,
			' and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
			' may need adjusting in build.bat			
			' ...

			'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''				
			' The Xml can be extracted from the class using one of 3 methods '
			'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
			
			' This method will extract the xml into a string. The string is always encoded 
			' using Unicode, there a number of options allowing the headers, 
			' end of line & indenting to be set.
			Dim strXml As String = elm.ToXml()
			Console.WriteLine(strXml)
			
			' This method will extract the xml into a file. This method provides options
			' for changing the encoding (UTF-8, UTF-16) as well as headers, 
			' end of line and indenting.
			elm.ToXmlFile(filename & ".testouput.xml")
			
			' This method will extract the xml into a stream. This method provides options
			' for changing the encoding (UTF-8, UTF-16) as well as headers, 
			' end of line and indenting.
			' This method is useful when a specific encoding is required (typically
			' UTF-8), in order to transmit it over an 8-bit connection, smtp etc
			' without the need to write the xml to file first.
			Dim stmXml As System.IO.Stream = elm.ToXmlStream()

		Catch ex As Exception 
			DisplayError(ex)
		End Try
	End Sub
	#End Region
	#Region "SimpleTestmstnsITSPUnit - Demo for documents with a root <ITSPUnit>"
	' Shows a simple example of how the class ITSPUnit
	' can be used. This class can be used to load documents whose 
	' root (document) element is <ITSPUnit>.
	Private Sub SimpleTestmstnsITSPUnit(ByVal filename As String)
		Try
			' create an instance of the class to load the XML file into
			Dim elm As mstns.ITSPUnit = New mstns.ITSPUnit()
			
			' load the xml from a file into the object (the root element in the
			' xml document must be <ITSPUnit>.
			elm.FromXmlFile(filename)

			' This will open up a viewer, allowing you to navigate the classes
			' that have been generated. 
			' Note the viewer can be used to modify properties, and provides a listing of
			' the code required to create the document it is displaying.
			Dim sv As LiquidTechnologies.Viewer.Net45.SimpleViewer = New LiquidTechnologies.Viewer.Net45.SimpleViewer(elm)
			sv.ShowDialog()

			' You can then add code to navigate the data held in the class.
			' When navigating this object model you should refer to the documentation
			' generated in the directory:
			' W:\NHS CfH ICT Contract\2015-2017 Work\Content Management and Development\CDA\CDA_Schema_Documentation\.
			' The help should be compiled into a chm before being used, (use build.bat)
			' - HTML Help Workshop is required to perform this,
			' and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
			' may need adjusting in build.bat			
			' ...

			'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''				
			' The Xml can be extracted from the class using one of 3 methods '
			'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
			
			' This method will extract the xml into a string. The string is always encoded 
			' using Unicode, there a number of options allowing the headers, 
			' end of line & indenting to be set.
			Dim strXml As String = elm.ToXml()
			Console.WriteLine(strXml)
			
			' This method will extract the xml into a file. This method provides options
			' for changing the encoding (UTF-8, UTF-16) as well as headers, 
			' end of line and indenting.
			elm.ToXmlFile(filename & ".testouput.xml")
			
			' This method will extract the xml into a stream. This method provides options
			' for changing the encoding (UTF-8, UTF-16) as well as headers, 
			' end of line and indenting.
			' This method is useful when a specific encoding is required (typically
			' UTF-8), in order to transmit it over an 8-bit connection, smtp etc
			' without the need to write the xml to file first.
			Dim stmXml As System.IO.Stream = elm.ToXmlStream()

		Catch ex As Exception 
			DisplayError(ex)
		End Try
	End Sub
	#End Region
	#Region "SimpleTest - Demo for documents with an unknown root element"
	' Shows a simple example of how to load data when you don't know
	' the kind of data that you are loading. 
	Private Sub SimpleTest(ByVal filename As String)
		Try
			' create an instance of the class to load the XML file into
			Dim elm As LiquidTechnologies.Runtime.Net45.XmlObjectBase
			
			' load the xml from a file into the object.
			elm = ITSPCDALib.ClassFactory.FromXmlFile(filename)

			' This will open up a viewer, allowing you to navigate the classes
			' that have been generated. 
			' Note the viewer can be used to modify properties, and provides a listing of
			' the code required to create the document it is displaying.
			Dim sv As LiquidTechnologies.Viewer.Net45.SimpleViewer = New LiquidTechnologies.Viewer.Net45.SimpleViewer(elm)
			sv.ShowDialog()

			' You can then add code to navigate the data held in the class.
			' When navigating this object model you should refer to the documentation
			' generated in the directory:
			' W:\NHS CfH ICT Contract\2015-2017 Work\Content Management and Development\CDA\CDA_Schema_Documentation\.
			' The help should be compiled into a chm before being used, (use build.bat)
			' - HTML Help Workshop is required to perform this,
			' and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
			' may need adjusting in build.bat
			
			' ...

			'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''				
			' The Xml can be extracted from the class using one of 3 methods '
			'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
			
			' This method will extract the xml into a string. The string is always encoded 
			' using Unicode, there a number of options allowing the headers, 
			' end of line & indenting to be set.
			Dim strXml As String = elm.ToXml()
			Console.WriteLine(strXml)
			
			' This method will extract the xml into a file. This method provides options
			' for changing the encoding (UTF-8, UTF-16) as well as headers, 
			' end of line and indenting.
			elm.ToXmlFile(filename & ".testouput.xml")
			
			' This method will extract the xml into a stream. This method provides options
			' for changing the encoding (UTF-8, UTF-16) as well as headers, 
			' end of line and indenting.
			' This method is useful when a specific encoding is required (typically
			' UTF-8), in order to transmit it over an 8-bit connection, smtp etc
			' without the need to write the xml to file first.
			Dim stmXml As System.IO.Stream = elm.ToXmlStream()

		Catch ex As Exception 
			DisplayError(ex)
		End Try
	End Sub
	#End Region
	#End Region

	#Region "Error Handler"
	Private Sub DisplayError(ByVal ex As Exception)
        Dim errText As String = "Error - " & vbCrLf
		' Note : exceptions are likely to contain inner exceptions
		' that provide further detail about the error.
		Do While (Not ex Is Nothing)
            errText = errText & ex.Message & vbCrLf
			ex = ex.InnerException
		Loop
		MessageBox.Show(Me,  errText, "An Error occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error)
	End Sub
	#End Region
        
	#Region "Basic Form Plumbing"
    Private Sub SampleApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblInfo.Text = "All Sample XML Files that you specified in the Wizard will be shown here, see btnLoad_Click(...) method in SampleApp.cs." & vbCrLf & vbCrLf & "Select the file you want to load into the simple viewer and click the 'Load Selected XML File' button:"
		lstFiles.Items.AddRange(New Object() {	"Browse for a File to Load" _
												, "W:\NHS CfH ICT Contract\2015-2017 Work\Content Management and Development\CDA\ITSPCDASample.xml.testouput.xml" _
									})
        lstFiles.SelectedIndex = 0
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub
	#End Region

	#Region "Windows Form Designer generated code"
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        MessageBox.Show(Me, "This Sample Application shows the basic serialization mechanism for reading and writing xml documents using Liquid XML Data Binding." & vbCrLf & vbCrLf & _
                            "A good place to start examining the code is in SampleApp.vb. If you place a breakpoint in the method btnLoad_Click, then you will be able to step through the code looking at the methods that are called." & vbCrLf & vbCrLf & _
                            "After the document loads, a dialog will show the details of what has been loaded. Clicking on nodes in the tree will show the XML data it represents along with example source code (in the code tab) that will help you to understand how to write your real client application." & vbCrLf & vbCrLf & _
                            "NOTE: If you are loading a large XML document, although the serialization will be quick the display in the dialog may be slow as it reflects on the whole object model to display the tree.", "Sample Application Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lstFiles As System.Windows.Forms.ListBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstFiles = New System.Windows.Forms.ListBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(344, 96)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(96, 48)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load Selected XML File"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(344, 216)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 24)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        '
        'lstFiles
        '
        Me.lstFiles.Location = New System.Drawing.Point(8, 96)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.Size = New System.Drawing.Size(328, 134)
        Me.lstFiles.TabIndex = 1
        '
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(16, 16)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(424, 72)
        Me.lblInfo.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "xml"
        Me.OpenFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        '
        'SampleApp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 246)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblInfo, Me.lstFiles, Me.btnClose, Me.btnLoad})
        Me.Name = "SampleApp"
        Me.Text = "Liquid XML Sample"
        Me.ResumeLayout(False)

    End Sub

#End Region
End Class



