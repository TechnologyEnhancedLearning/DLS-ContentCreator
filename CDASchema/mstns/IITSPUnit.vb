Option Explicit On
Option Strict On

Imports System
Imports System.Xml

' **********************************************************************************************
' * Copyright (c) 2001-2016 Liquid Technologies Limited. All rights reserved.
' * See www.liquid-technologies.com for product details.
' *
' * Please see products End User License Agreement for distribution permissions.
' *
' * WARNING: THIS FILE IS GENERATED
' * Changes made outside of ##HAND_CODED_BLOCK_START blocks will be overwritten
' *
' * Generation  :  by Liquid XML Data Binder 14.1.5.6733
' * Using Schema: C:\Users\admin\Documents\Content Management and Development\CDA\ITSPCDA.xsd
' **********************************************************************************************


Namespace mstns
	''' <summary>
	''' </summary>
    Public Interface IITSPUnit
        Inherits LiquidTechnologies.Runtime.Net45.XmlObjectInterface

		#Region "Member variables"
		#Region "Attribute - UnitName"
		''' <summary>
		''' The name of the unit.
		''' </summary>
		Property UnitName() As String
		#End Region	
		#Region "Attribute - SchemaVersion"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		Property SchemaVersion() As Decimal
		#End Region	
		#Region "Attribute - Type"
		''' <summary>
		''' Learning, Diagnostic, Post Learning – the type of unit.
		''' </summary>
		Property Type() As String
		#End Region	
		#Region "Attribute - Height"
		''' <summary>
		''' The height of the page on a desktop monitor.
		''' </summary>
		Property Height() As Integer
		#End Region	
		#Region "Attribute - Width"
		''' <summary>
		''' The width of the page on a desktop monitor.
		''' </summary>
		Property Width() As Integer
		#End Region	
		#Region "Attribute - PageBackgroundColour"
		''' <summary>
		''' The background colour of the pages in the unit.
		''' </summary>
		Property PageBackgroundColour() As String
		#End Region	
		#Region "Attribute - BrowserBackgroundColour"
		''' <summary>
		''' The background colour of the browser. This should represent the material level: Entry = #3B1979, Level 1 = #B5006A, Level 2 = #11AF52, Level 3 = #009DCA
		''' </summary>
		Property BrowserBackgroundColour() As String
		#End Region	
		#Region "Attribute - FontFamily"
		''' <summary>
		''' The default font family for instruction text and other text. Valid choices are: Georgia, Palatino, Times, Arial, ArialBlack, ComicSans, Impact, LucidaSans, Tahoma, Helvetica, Verdana, Courier, LucidaConsol
		''' </summary>
		Property FontFamily() As String
		#End Region	
		#Region "Attribute - FontSize"
		''' <summary>
		''' The default font size for instruction text.
		''' </summary>
		Property FontSize() As Integer
		#End Region	
		#Region "Attribute - InstructionStyle"
		''' <summary>
		''' This will default to the standard IT Skill Pathway instruction style but will allow selection of other themes. Valid choices: Default
		''' </summary>
		Property InstructionStyle() As String
		#End Region	
		#Region "Attribute - AutoResize"
		''' <summary>
		''' If true, then materials resize rather than employing an alternative stylesheet when screen is too small.
		''' </summary>
		Property AutoResize() As Boolean
		#End Region	
		#Region "Attribute - DisableMobileZoom"
		''' <summary>
		''' Disable zooming on a small / mobile device.
		''' </summary>
		Property DisableMobileZoom() As Boolean
		#End Region	
		#Region "Attribute - AssessXClicksWrong"
		''' <summary>
		''' If an assessment, the number of clicks on the page in the wrong place after which the interaction will be marked incorrect.
		''' </summary>
		Property AssessXClicksWrong() As Integer
		#End Region	
		#Region "Attribute - UseKeyboardNavigation"
		''' <summary>
		''' Whether keyboard navigation is enabled in learning materials when no other object has the keyboard focus.
		''' </summary>
		Property UseKeyboardNavigation() As Boolean
		#End Region	
		#Region "Attribute - SCOMasteryScore"
		''' <summary>
		''' SCORM Mastery Score - The score required to pass the assessment.
		''' </summary>
		Property SCOMasteryScore() As LiquidTechnologies.Runtime.Net45.BigInteger
		#End Region	
		#Region "Attribute - SCODescription"
		''' <summary>
		''' The description to include in the SCORM manifest xml file.
		''' </summary>
		Property SCODescription() As String
		#End Region	
		#Region "Attribute - SCOKeyWords"
		''' <summary>
		''' The keywords to include in the SCORM manifest xml file.
		''' </summary>
		Property SCOKeyWords() As String
		#End Region	
		#Region "Attribute - Page"
		''' <summary>
		''' A collection of PageCols
		''' </summary>
		ReadOnly Property PageCol() As mstns.ITSPCDALib.XmlObjectCollection(Of mstns.Page)
		#End Region	
		#Region "Attribute - TutorialList"
		''' <summary>
		''' A collection of TutorialLists
		''' </summary>
		ReadOnly Property TutorialList() As mstns.ITSPCDALib.XmlObjectCollection(Of mstns.Tutorials)
		#End Region	
	
		#End Region	

' ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Additional Methods and members here...

' ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	End Interface
End Namespace

