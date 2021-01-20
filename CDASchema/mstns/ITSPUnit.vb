Option Explicit On
Option Strict On

Imports System
Imports System.Xml

'**********************************************************************************************
'* Copyright (c) 2001-2016 Liquid Technologies Limited. All rights reserved.
'* See www.liquid-technologies.com for product details.
'*
'* Please see products End User License Agreement for distribution permissions.
'*
'* WARNING: THIS FILE IS GENERATED
'* Changes made outside of ##HAND_CODED_BLOCK_START blocks will be overwritten
'*
'* Generation  :  by Liquid XML Data Binder 14.1.5.6733
'* Using Schema: C:\Users\admin\Documents\Content Management and Development\CDA\ITSPCDA.xsd
'**********************************************************************************************

Namespace mstns

	''' <summary>
	''' This class represents the Element ITSPUnit
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"ITSPUnit", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class ITSPUnit
		Inherits mstns.ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for ITSPUnit
		''' </summary>
		''' <remarks>
		'''	The class is created with all the mandatory fields populated with the
		'''	default data. 
		'''	All Collection object are created.
		'''	However any 1-n relationships (these are represented as collections) are
		'''	empty. To comply with the schema these must be populated before the xml
		'''	obtained from ToXml is valid against the schema C:\Users\admin\Documents\Content Management and Development\CDA\ITSPCDA.xsd
		''' </remarks>
		Public Sub New()
			_elementName = "ITSPUnit"
			Init()
		End Sub
		
		Public Sub New(ByVal elementName as String)
			_elementName = elementName
			Init()
		End Sub
		#End Region

		#Region "Initialization methods for the class"
		''' <summary>
		'''	Initializes the class
		''' </summary>
		''' <remarks>
		'''	The Creates all the mandatory fields (populated with the default data) 
		'''	All Collection object are created.
		'''	However any 1-n relationships (these are represented as collections) are
		'''	empty. To comply with the schema these must be populated before the xml
		'''	obtained from ToXml is valid against the schema C:\Users\admin\Documents\Content Management and Development\CDA\ITSPCDA.xsd.
		''' </remarks>
		Protected Overrides Sub Init()
			mstns.ITSPCDALib.Registration.iRegistrationIndicator = 0 ' causes registration to take place
			_UnitName = ""
			_SchemaVersion = LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("1.097", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_Type = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Learning", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_Height = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("768", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_Width = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("1024", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_PageBackgroundColour = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("#FFFFFF", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_BrowserBackgroundColour = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("#11AF52", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_FontFamily = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Calibri", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_FontSize = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("12", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_InstructionStyle = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Default", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_AutoResize = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_DisableMobileZoom = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_AssessXClicksWrong = 0
			_IsNilAssessXClicksWrong = False
			_UseKeyboardNavigation = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_SCOMasteryScore = LiquidTechnologies.Runtime.Net45.Conversions.integerFromString("85", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_SCODescription = ""
			_SCOKeyWords = ""
			_PageCol = new mstns.ITSPCDALib.XmlObjectCollection(Of mstns.Page)("Page", "https://www.itskill.nhs.uk/CDAFile.xsd", 0, 999, false)
			_TutorialList = new mstns.ITSPCDALib.XmlObjectCollection(Of mstns.Tutorials)("TutorialList", "https://www.itskill.nhs.uk/CDAFile.xsd", 0, 999, false)



' ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Additional initialization code here...

' ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		End Sub

		#End Region

		#Region "ICloneable Interface"
		''' <summary>
		'''	Allows the class to be copied
		''' </summary>
		''' <remarks>
		'''	Performs a 'deep copy' of all the data in the class (and its children)
		''' </remarks>
		Public Overrides Function Clone() As Object
			Dim newObject As New mstns.ITSPUnit(_elementName)
			Dim o As Object
			newObject._UnitName = _UnitName
			newObject._SchemaVersion = _SchemaVersion
			newObject._Type = _Type
			newObject._Height = _Height
			newObject._Width = _Width
			newObject._PageBackgroundColour = _PageBackgroundColour
			newObject._BrowserBackgroundColour = _BrowserBackgroundColour
			newObject._FontFamily = _FontFamily
			newObject._FontSize = _FontSize
			newObject._InstructionStyle = _InstructionStyle
			newObject._AutoResize = _AutoResize
			newObject._DisableMobileZoom = _DisableMobileZoom
			newObject._AssessXClicksWrong = _AssessXClicksWrong
			newObject._IsNilAssessXClicksWrong = _IsNilAssessXClicksWrong
			newObject._UseKeyboardNavigation = _UseKeyboardNavigation
			newObject._SCOMasteryScore = _SCOMasteryScore
			newObject._SCODescription = _SCODescription
			newObject._SCOKeyWords = _SCOKeyWords
			For Each o in _PageCol
				newObject._PageCol.Add(CType(CType(o, mstns.Page).Clone(), mstns.Page))
			Next o
			For Each o in _TutorialList
				newObject._TutorialList.Add(CType(CType(o, mstns.Tutorials).Clone(), mstns.Tutorials))
			Next o

			o = Nothing


' ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Additional clone code here...

' ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			Return newObject
		End Function
		#End Region

		#Region "Member variables"

		Protected Overrides Readonly Property TargetNamespace() as String
			Get 
				Return "https://www.itskill.nhs.uk/CDAFile.xsd"
			End Get
		End Property

		#Region "Attribute - UnitName"
		''' <summary>
		''' The name of the unit.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("UnitName", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property UnitName() as String
			Get 
				Return _UnitName  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(0, value)
				_UnitName = value 
			End Set
		End Property
		Protected _UnitName As String

		#End Region
	
		#Region "Attribute - SchemaVersion"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("1.097", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("SchemaVersion", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property SchemaVersion() as Decimal
			Get 
				Return _SchemaVersion  
			End Get
			Set(ByVal value As Decimal) 
				CheckElementRestriction(1, value)
				_SchemaVersion = value 
			End Set
		End Property
		Protected _SchemaVersion As Decimal

		#End Region
	
		#Region "Attribute - Type"
		''' <summary>
		''' Learning, Diagnostic, Post Learning – the type of unit.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Learning", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("Type", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property Type() as String
			Get 
				Return _Type  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(2, value)
				_Type = value 
			End Set
		End Property
		Protected _Type As String

		#End Region
	
		#Region "Attribute - Height"
		''' <summary>
		''' The height of the page on a desktop monitor.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("768", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("Height", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property Height() as Integer
			Get 
				Return _Height  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(3, value)
				_Height = value 
			End Set
		End Property
		Protected _Height As Integer

		#End Region
	
		#Region "Attribute - Width"
		''' <summary>
		''' The width of the page on a desktop monitor.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("1024", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("Width", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property Width() as Integer
			Get 
				Return _Width  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(4, value)
				_Width = value 
			End Set
		End Property
		Protected _Width As Integer

		#End Region
	
		#Region "Attribute - PageBackgroundColour"
		''' <summary>
		''' The background colour of the pages in the unit.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("#FFFFFF", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("PageBackgroundColour", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property PageBackgroundColour() as String
			Get 
				Return _PageBackgroundColour  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(5, value)
				_PageBackgroundColour = value 
			End Set
		End Property
		Protected _PageBackgroundColour As String

		#End Region
	
		#Region "Attribute - BrowserBackgroundColour"
		''' <summary>
		''' The background colour of the browser. This should represent the material level: Entry = #3B1979, Level 1 = #B5006A, Level 2 = #11AF52, Level 3 = #009DCA
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("#11AF52", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("BrowserBackgroundColour", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property BrowserBackgroundColour() as String
			Get 
				Return _BrowserBackgroundColour  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(6, value)
				_BrowserBackgroundColour = value 
			End Set
		End Property
		Protected _BrowserBackgroundColour As String

		#End Region
	
		#Region "Attribute - FontFamily"
		''' <summary>
		''' The default font family for instruction text and other text. Valid choices are: Georgia, Palatino, Times, Arial, ArialBlack, ComicSans, Impact, LucidaSans, Tahoma, Helvetica, Verdana, Courier, LucidaConsol
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Calibri", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("FontFamily", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property FontFamily() as String
			Get 
				Return _FontFamily  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(7, value)
				_FontFamily = value 
			End Set
		End Property
		Protected _FontFamily As String

		#End Region
	
		#Region "Attribute - FontSize"
		''' <summary>
		''' The default font size for instruction text.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("12", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("FontSize", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property FontSize() as Integer
			Get 
				Return _FontSize  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(8, value)
				_FontSize = value 
			End Set
		End Property
		Protected _FontSize As Integer

		#End Region
	
		#Region "Attribute - InstructionStyle"
		''' <summary>
		''' This will default to the standard IT Skill Pathway instruction style but will allow selection of other themes. Valid choices: Default
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Default", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("InstructionStyle", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property InstructionStyle() as String
			Get 
				Return _InstructionStyle  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(9, value)
				_InstructionStyle = value 
			End Set
		End Property
		Protected _InstructionStyle As String

		#End Region
	
		#Region "Attribute - AutoResize"
		''' <summary>
		''' If true, then materials resize rather than employing an alternative stylesheet when screen is too small.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("AutoResize", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property AutoResize() as Boolean
			Get 
				Return _AutoResize  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(10, value)
				_AutoResize = value 
			End Set
		End Property
		Protected _AutoResize As Boolean

		#End Region
	
		#Region "Attribute - DisableMobileZoom"
		''' <summary>
		''' Disable zooming on a small / mobile device.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("DisableMobileZoom", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property DisableMobileZoom() as Boolean
			Get 
				Return _DisableMobileZoom  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(11, value)
				_DisableMobileZoom = value 
			End Set
		End Property
		Protected _DisableMobileZoom As Boolean

		#End Region
	
		#Region "Attribute - AssessXClicksWrong"
		''' <summary>
		''' If an assessment, the number of clicks on the page in the wrong place after which the interaction will be marked incorrect.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to 0.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("AssessXClicksWrong", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilAssessXClicksWrong", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property AssessXClicksWrong() as Integer
			Get 
				Return _AssessXClicksWrong  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(12, value)
				_AssessXClicksWrong = value 
				_IsNilAssessXClicksWrong = False
			End Set
		End Property
		Protected _AssessXClicksWrong As Integer

		Public Property IsNilAssessXClicksWrong As Boolean
			Get
				Return _IsNilAssessXClicksWrong
			End Get
			Set
				_IsNilAssessXClicksWrong = value
			End Set
		End Property
		Protected _IsNilAssessXClicksWrong As Boolean
		#End Region
	
		#Region "Attribute - UseKeyboardNavigation"
		''' <summary>
		''' Whether keyboard navigation is enabled in learning materials when no other object has the keyboard focus.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("UseKeyboardNavigation", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property UseKeyboardNavigation() as Boolean
			Get 
				Return _UseKeyboardNavigation  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(13, value)
				_UseKeyboardNavigation = value 
			End Set
		End Property
		Protected _UseKeyboardNavigation As Boolean

		#End Region
	
		#Region "Attribute - SCOMasteryScore"
		''' <summary>
		''' SCORM Mastery Score - The score required to pass the assessment.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.integerFromString("85", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("SCOMasteryScore", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property SCOMasteryScore() as LiquidTechnologies.Runtime.Net45.BigInteger
			Get 
				Return _SCOMasteryScore  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.BigInteger) 
				CheckElementRestriction(14, value)
				_SCOMasteryScore = value 
			End Set
		End Property
		Protected _SCOMasteryScore As LiquidTechnologies.Runtime.Net45.BigInteger

		#End Region
	
		#Region "Attribute - SCODescription"
		''' <summary>
		''' The description to include in the SCORM manifest xml file.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("SCODescription", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property SCODescription() as String
			Get 
				Return _SCODescription  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(15, value)
				_SCODescription = value 
			End Set
		End Property
		Protected _SCODescription As String

		#End Region
	
		#Region "Attribute - SCOKeyWords"
		''' <summary>
		''' The keywords to include in the SCORM manifest xml file.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("SCOKeyWords", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property SCOKeyWords() as String
			Get 
				Return _SCOKeyWords  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(16, value)
				_SCOKeyWords = value 
			End Set
		End Property
		Protected _SCOKeyWords As String

		#End Region
	
		#Region "Attribute - Page"
		''' <summary>
		''' A collection of PageCols
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' This collection may contain 0 to 999 objects.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("Page", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)> _
		Public Readonly Property PageCol() As mstns.ITSPCDALib.XmlObjectCollection(Of mstns.Page)
			Get 
				Return _PageCol 
			End Get
		End Property
		Protected _PageCol As mstns.ITSPCDALib.XmlObjectCollection(Of mstns.Page)
		
		#End Region
	
		#Region "Attribute - TutorialList"
		''' <summary>
		''' A collection of TutorialLists
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' This collection may contain 0 to 999 objects.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("TutorialList", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)> _
		Public Readonly Property TutorialList() As mstns.ITSPCDALib.XmlObjectCollection(Of mstns.Tutorials)
			Get 
				Return _TutorialList 
			End Get
		End Property
		Protected _TutorialList As mstns.ITSPCDALib.XmlObjectCollection(Of mstns.Tutorials)
		
		#End Region
	
		#Region "Attribute - Namespace"
		Public Overrides Readonly Property [Namespace]() As String
			Get 
				Return "https://www.itskill.nhs.uk/CDAFile.xsd"  
			End Get
		End Property
		#End Region

		#Region "Attribute - GetBase"
		Public Overrides Function GetBase() As LiquidTechnologies.Runtime.Net45.XmlObjectBase
			Return Me
		End Function
		#End Region
		#End Region


' ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Additional Methods and members here...

' ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	End Class
End Namespace


