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
	''' This class represents the ComplexType MarqueeBehaviour
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"MarqueeBehaviour", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class MarqueeBehaviour
		Inherits mstns.ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for MarqueeBehaviour
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
			_elementName = "MarqueeBehaviour"
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
			_BorderStyle = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("solid", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_BorderWidth = LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_BorderColour = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("#000000", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_BorderOpacity = LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_BackGroundColour = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("#CCCCCC", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_BackgGroundOpacity = LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("0.5", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_ObjectsVisibleWhenSelected = ""
			_IsNilObjectsVisibleWhenSelected = False
			_ObjectsVisibleCorrect = ""
			_IsNilObjectsVisibleCorrect = False
			_GoToPageCorrect = ""
			_IsNilGoToPageCorrect = False
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
			Dim newObject As New mstns.MarqueeBehaviour(_elementName)
			Dim o As Object
			newObject._BorderStyle = _BorderStyle
			newObject._BorderWidth = _BorderWidth
			newObject._BorderColour = _BorderColour
			newObject._BorderOpacity = _BorderOpacity
			newObject._BackGroundColour = _BackGroundColour
			newObject._BackgGroundOpacity = _BackgGroundOpacity
			newObject._ObjectsVisibleWhenSelected = _ObjectsVisibleWhenSelected
			newObject._IsNilObjectsVisibleWhenSelected = _IsNilObjectsVisibleWhenSelected
			newObject._ObjectsVisibleCorrect = _ObjectsVisibleCorrect
			newObject._IsNilObjectsVisibleCorrect = _IsNilObjectsVisibleCorrect
			newObject._GoToPageCorrect = _GoToPageCorrect
			newObject._IsNilGoToPageCorrect = _IsNilGoToPageCorrect
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

		#Region "Attribute - BorderStyle"
		''' <summary>
		''' The marquee border line style.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("solid", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("BorderStyle", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property BorderStyle() as String
			Get 
				Return _BorderStyle  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(0, value)
				_BorderStyle = value 
			End Set
		End Property
		Protected _BorderStyle As String

		#End Region
	
		#Region "Attribute - BorderWidth"
		''' <summary>
		''' Pixel width of the marquee border.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("BorderWidth", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property BorderWidth() as Decimal
			Get 
				Return _BorderWidth  
			End Get
			Set(ByVal value As Decimal) 
				CheckElementRestriction(1, value)
				_BorderWidth = value 
			End Set
		End Property
		Protected _BorderWidth As Decimal

		#End Region
	
		#Region "Attribute - BorderColour"
		''' <summary>
		''' Colour of the marquee border.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("#000000", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("BorderColour", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property BorderColour() as String
			Get 
				Return _BorderColour  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(2, value)
				_BorderColour = value 
			End Set
		End Property
		Protected _BorderColour As String

		#End Region
	
		#Region "Attribute - BorderOpacity"
		''' <summary>
		''' Opacity of the marquee border.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("BorderOpacity", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property BorderOpacity() as Decimal
			Get 
				Return _BorderOpacity  
			End Get
			Set(ByVal value As Decimal) 
				CheckElementRestriction(3, value)
				_BorderOpacity = value 
			End Set
		End Property
		Protected _BorderOpacity As Decimal

		#End Region
	
		#Region "Attribute - BackGroundColour"
		''' <summary>
		''' Colour of the marquee background.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("#CCCCCC", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("BackGroundColour", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property BackGroundColour() as String
			Get 
				Return _BackGroundColour  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(4, value)
				_BackGroundColour = value 
			End Set
		End Property
		Protected _BackGroundColour As String

		#End Region
	
		#Region "Attribute - BackgGroundOpacity"
		''' <summary>
		''' Opacity of the marquee background.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("0.5", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("BackgGroundOpacity", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property BackgGroundOpacity() as Decimal
			Get 
				Return _BackgGroundOpacity  
			End Get
			Set(ByVal value As Decimal) 
				CheckElementRestriction(5, value)
				_BackgGroundOpacity = value 
			End Set
		End Property
		Protected _BackgGroundOpacity As Decimal

		#End Region
	
		#Region "Attribute - ObjectsVisibleWhenSelected"
		''' <summary>
		''' List of objects to make visible when they fall within the marquee.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("ObjectsVisibleWhenSelected", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilObjectsVisibleWhenSelected", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property ObjectsVisibleWhenSelected() as String
			Get 
				Return _ObjectsVisibleWhenSelected  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(6, value)
				_ObjectsVisibleWhenSelected = value 
				_IsNilObjectsVisibleWhenSelected = False
			End Set
		End Property
		Protected _ObjectsVisibleWhenSelected As String

		Public Property IsNilObjectsVisibleWhenSelected As Boolean
			Get
				Return _IsNilObjectsVisibleWhenSelected
			End Get
			Set
				_IsNilObjectsVisibleWhenSelected = value
			End Set
		End Property
		Protected _IsNilObjectsVisibleWhenSelected As Boolean
		#End Region
	
		#Region "Attribute - ObjectsVisibleCorrect"
		''' <summary>
		''' List of objects that should be visible for interaction to be considered correct.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("ObjectsVisibleCorrect", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilObjectsVisibleCorrect", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property ObjectsVisibleCorrect() as String
			Get 
				Return _ObjectsVisibleCorrect  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(7, value)
				_ObjectsVisibleCorrect = value 
				_IsNilObjectsVisibleCorrect = False
			End Set
		End Property
		Protected _ObjectsVisibleCorrect As String

		Public Property IsNilObjectsVisibleCorrect As Boolean
			Get
				Return _IsNilObjectsVisibleCorrect
			End Get
			Set
				_IsNilObjectsVisibleCorrect = value
			End Set
		End Property
		Protected _IsNilObjectsVisibleCorrect As Boolean
		#End Region
	
		#Region "Attribute - GoToPageCorrect"
		''' <summary>
		''' Page to navigate to when judged correct.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("GoToPageCorrect", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilGoToPageCorrect", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property GoToPageCorrect() as String
			Get 
				Return _GoToPageCorrect  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(8, value)
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
				CheckElementRestriction(9, value)
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
				CheckElementRestriction(10, value)
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


