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
	''' The Text behaviour can be added to any Object but should ideally be added to an object that doesn't contain other content. It will add an interactive text area to the object. Optionally, the default and required text (or length or selection) can be set An optional "correct". Navigation and scoring options can be set relating to this.
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"TextBehaviour", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class TextBehaviour
		Inherits mstns.ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for TextBehaviour
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
			_elementName = "TextBehaviour"
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
			_StartHtml = ""
			_RetainPreviousText = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_IsEditable = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_HasFocus = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_SendTextTargetObject = ""
			_IsNilSendTextTargetObject = False
			_SelectionStart = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_SelectionEnd = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_RequiredHtml = ""
			_IsNilRequiredHtml = False
			_IgnoreCase = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_RequiredSelectStart = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("-1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_IsNilRequiredSelectStart = False
			_RequiredSelectEnd = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("-1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_IsNilRequiredSelectEnd = False
			_RequiredCharacterCount = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("-1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_IsNilRequiredCharacterCount = False
			_JudgeOnKeyup = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_JudgeOnReturn = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_JudgeOnTab = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_JudgeOnSelectChange = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_GoToPageCorrect = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Next", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_IsNilGoToPageCorrect = False
			_GoToPageIncorrect = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Next", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_IsNilGoToPageIncorrect = False
			_AssessmentCorrect = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_AssessmentIncorrect = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)



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
			Dim newObject As New mstns.TextBehaviour(_elementName)
			Dim o As Object
			newObject._StartHtml = _StartHtml
			newObject._RetainPreviousText = _RetainPreviousText
			newObject._IsEditable = _IsEditable
			newObject._HasFocus = _HasFocus
			newObject._SendTextTargetObject = _SendTextTargetObject
			newObject._IsNilSendTextTargetObject = _IsNilSendTextTargetObject
			newObject._SelectionStart = _SelectionStart
			newObject._SelectionEnd = _SelectionEnd
			newObject._RequiredHtml = _RequiredHtml
			newObject._IsNilRequiredHtml = _IsNilRequiredHtml
			newObject._IgnoreCase = _IgnoreCase
			newObject._RequiredSelectStart = _RequiredSelectStart
			newObject._IsNilRequiredSelectStart = _IsNilRequiredSelectStart
			newObject._RequiredSelectEnd = _RequiredSelectEnd
			newObject._IsNilRequiredSelectEnd = _IsNilRequiredSelectEnd
			newObject._RequiredCharacterCount = _RequiredCharacterCount
			newObject._IsNilRequiredCharacterCount = _IsNilRequiredCharacterCount
			newObject._JudgeOnKeyup = _JudgeOnKeyup
			newObject._JudgeOnReturn = _JudgeOnReturn
			newObject._JudgeOnTab = _JudgeOnTab
			newObject._JudgeOnSelectChange = _JudgeOnSelectChange
			newObject._GoToPageCorrect = _GoToPageCorrect
			newObject._IsNilGoToPageCorrect = _IsNilGoToPageCorrect
			newObject._GoToPageIncorrect = _GoToPageIncorrect
			newObject._IsNilGoToPageIncorrect = _IsNilGoToPageIncorrect
			newObject._AssessmentCorrect = _AssessmentCorrect
			newObject._AssessmentIncorrect = _AssessmentIncorrect

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

		#Region "Attribute - StartHtml"
		''' <summary>
		''' The HTML to include in the text area at the start of the interaction.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("StartHtml", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property StartHtml() as String
			Get 
				Return _StartHtml  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(0, value)
				_StartHtml = value 
			End Set
		End Property
		Protected _StartHtml As String

		#End Region
	
		#Region "Attribute - RetainPreviousText"
		''' <summary>
		''' Bring forward text from previous interaction.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("RetainPreviousText", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property RetainPreviousText() as Boolean
			Get 
				Return _RetainPreviousText  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(1, value)
				_RetainPreviousText = value 
			End Set
		End Property
		Protected _RetainPreviousText As Boolean

		#End Region
	
		#Region "Attribute - IsEditable"
		''' <summary>
		''' If the text is not editable, the interaction settings will be ignored.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("IsEditable", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property IsEditable() as Boolean
			Get 
				Return _IsEditable  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(2, value)
				_IsEditable = value 
			End Set
		End Property
		Protected _IsEditable As Boolean

		#End Region
	
		#Region "Attribute - HasFocus"
		''' <summary>
		''' Whether the object has the keyboard focus when the page is displayed. (Toggles the availability of the selection options).
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("HasFocus", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property HasFocus() as Boolean
			Get 
				Return _HasFocus  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(3, value)
				_HasFocus = value 
			End Set
		End Property
		Protected _HasFocus As Boolean

		#End Region
	
		#Region "Attribute - SendTextTargetObject"
		''' <summary>
		''' Another object to send the text to as the use types.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("SendTextTargetObject", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilSendTextTargetObject", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property SendTextTargetObject() as String
			Get 
				Return _SendTextTargetObject  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(4, value)
				_SendTextTargetObject = value 
				_IsNilSendTextTargetObject = False
			End Set
		End Property
		Protected _SendTextTargetObject As String

		Public Property IsNilSendTextTargetObject As Boolean
			Get
				Return _IsNilSendTextTargetObject
			End Get
			Set
				_IsNilSendTextTargetObject = value
			End Set
		End Property
		Protected _IsNilSendTextTargetObject As Boolean
		#End Region
	
		#Region "Attribute - SelectionStart"
		''' <summary>
		''' The start point for the text that is selected at the start.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("SelectionStart", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property SelectionStart() as Integer
			Get 
				Return _SelectionStart  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(5, value)
				_SelectionStart = value 
			End Set
		End Property
		Protected _SelectionStart As Integer

		#End Region
	
		#Region "Attribute - SelectionEnd"
		''' <summary>
		''' The end point for the text that is selected at the start.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("SelectionEnd", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property SelectionEnd() as Integer
			Get 
				Return _SelectionEnd  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(6, value)
				_SelectionEnd = value 
			End Set
		End Property
		Protected _SelectionEnd As Integer

		#End Region
	
		#Region "Attribute - RequiredHtml"
		''' <summary>
		''' The HTML that is expected on successful completion of the task.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("RequiredHtml", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilRequiredHtml", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property RequiredHtml() as String
			Get 
				Return _RequiredHtml  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(7, value)
				_RequiredHtml = value 
				_IsNilRequiredHtml = False
			End Set
		End Property
		Protected _RequiredHtml As String

		Public Property IsNilRequiredHtml As Boolean
			Get
				Return _IsNilRequiredHtml
			End Get
			Set
				_IsNilRequiredHtml = value
			End Set
		End Property
		Protected _IsNilRequiredHtml As Boolean
		#End Region
	
		#Region "Attribute - IgnoreCase"
		''' <summary>
		''' When ticked, behaviour will ignore upper / lower case when judging interaction.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("IgnoreCase", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property IgnoreCase() as Boolean
			Get 
				Return _IgnoreCase  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(8, value)
				_IgnoreCase = value 
			End Set
		End Property
		Protected _IgnoreCase As Boolean

		#End Region
	
		#Region "Attribute - RequiredSelectStart"
		''' <summary>
		''' The start point of the selection that is required of the user.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("-1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("RequiredSelectStart", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilRequiredSelectStart", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property RequiredSelectStart() as Integer
			Get 
				Return _RequiredSelectStart  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(9, value)
				_RequiredSelectStart = value 
				_IsNilRequiredSelectStart = False
			End Set
		End Property
		Protected _RequiredSelectStart As Integer

		Public Property IsNilRequiredSelectStart As Boolean
			Get
				Return _IsNilRequiredSelectStart
			End Get
			Set
				_IsNilRequiredSelectStart = value
			End Set
		End Property
		Protected _IsNilRequiredSelectStart As Boolean
		#End Region
	
		#Region "Attribute - RequiredSelectEnd"
		''' <summary>
		''' The end point of the selection that is required of the user.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("-1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("RequiredSelectEnd", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilRequiredSelectEnd", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property RequiredSelectEnd() as Integer
			Get 
				Return _RequiredSelectEnd  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(10, value)
				_RequiredSelectEnd = value 
				_IsNilRequiredSelectEnd = False
			End Set
		End Property
		Protected _RequiredSelectEnd As Integer

		Public Property IsNilRequiredSelectEnd As Boolean
			Get
				Return _IsNilRequiredSelectEnd
			End Get
			Set
				_IsNilRequiredSelectEnd = value
			End Set
		End Property
		Protected _IsNilRequiredSelectEnd As Boolean
		#End Region
	
		#Region "Attribute - RequiredCharacterCount"
		''' <summary>
		''' The number of characters required in text area.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("-1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("RequiredCharacterCount", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilRequiredCharacterCount", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property RequiredCharacterCount() as Integer
			Get 
				Return _RequiredCharacterCount  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(11, value)
				_RequiredCharacterCount = value 
				_IsNilRequiredCharacterCount = False
			End Set
		End Property
		Protected _RequiredCharacterCount As Integer

		Public Property IsNilRequiredCharacterCount As Boolean
			Get
				Return _IsNilRequiredCharacterCount
			End Get
			Set
				_IsNilRequiredCharacterCount = value
			End Set
		End Property
		Protected _IsNilRequiredCharacterCount As Boolean
		#End Region
	
		#Region "Attribute - JudgeOnKeyup"
		''' <summary>
		''' Judge the interaction when the user presses a key.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("JudgeOnKeyup", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property JudgeOnKeyup() as Boolean
			Get 
				Return _JudgeOnKeyup  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(12, value)
				_JudgeOnKeyup = value 
			End Set
		End Property
		Protected _JudgeOnKeyup As Boolean

		#End Region
	
		#Region "Attribute - JudgeOnReturn"
		''' <summary>
		''' Judge the interaction when the user presses Return.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("JudgeOnReturn", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property JudgeOnReturn() as Boolean
			Get 
				Return _JudgeOnReturn  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(13, value)
				_JudgeOnReturn = value 
			End Set
		End Property
		Protected _JudgeOnReturn As Boolean

		#End Region
	
		#Region "Attribute - JudgeOnTab"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("JudgeOnTab", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property JudgeOnTab() as Boolean
			Get 
				Return _JudgeOnTab  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(14, value)
				_JudgeOnTab = value 
			End Set
		End Property
		Protected _JudgeOnTab As Boolean

		#End Region
	
		#Region "Attribute - JudgeOnSelectChange"
		''' <summary>
		''' Judge the interaction when the user selects new text.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("JudgeOnSelectChange", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property JudgeOnSelectChange() as Boolean
			Get 
				Return _JudgeOnSelectChange  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(15, value)
				_JudgeOnSelectChange = value 
			End Set
		End Property
		Protected _JudgeOnSelectChange As Boolean

		#End Region
	
		#Region "Attribute - GoToPageCorrect"
		''' <summary>
		''' Page to navigate to when judged correct.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Next", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("GoToPageCorrect", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilGoToPageCorrect", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property GoToPageCorrect() as String
			Get 
				Return _GoToPageCorrect  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(16, value)
				_GoToPageCorrect = value 
				_IsNilGoToPageCorrect = False
			End Set
		End Property
		Protected _GoToPageCorrect As String

		Public Property IsNilGoToPageCorrect As Boolean
			Get
				Return _IsNilGoToPageCorrect
			End Get
			Set
				_IsNilGoToPageCorrect = value
			End Set
		End Property
		Protected _IsNilGoToPageCorrect As Boolean
		#End Region
	
		#Region "Attribute - GoToPageIncorrect"
		''' <summary>
		''' Page to navigate to when judged incorrect.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Next", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("GoToPageIncorrect", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilGoToPageIncorrect", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property GoToPageIncorrect() as String
			Get 
				Return _GoToPageIncorrect  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(17, value)
				_GoToPageIncorrect = value 
				_IsNilGoToPageIncorrect = False
			End Set
		End Property
		Protected _GoToPageIncorrect As String

		Public Property IsNilGoToPageIncorrect As Boolean
			Get
				Return _IsNilGoToPageIncorrect
			End Get
			Set
				_IsNilGoToPageIncorrect = value
			End Set
		End Property
		Protected _IsNilGoToPageIncorrect As Boolean
		#End Region
	
		#Region "Attribute - AssessmentCorrect"
		''' <summary>
		''' If judged correct, score assessment activity correct.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("AssessmentCorrect", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property AssessmentCorrect() as Boolean
			Get 
				Return _AssessmentCorrect  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(18, value)
				_AssessmentCorrect = value 
			End Set
		End Property
		Protected _AssessmentCorrect As Boolean

		#End Region
	
		#Region "Attribute - AssessmentIncorrect"
		''' <summary>
		''' If judged incorrect, score assessment activity incorrect.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("AssessmentIncorrect", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property AssessmentIncorrect() as Boolean
			Get 
				Return _AssessmentIncorrect  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(19, value)
				_AssessmentIncorrect = value 
			End Set
		End Property
		Protected _AssessmentIncorrect As Boolean

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


