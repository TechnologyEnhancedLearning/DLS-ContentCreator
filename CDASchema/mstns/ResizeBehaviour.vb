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
	''' The Resize behaviour can be added to any Object. It will have the affect of making the object resizable. An optional "correct" resize range can be set with navigation and scoring options relating to this. Note that resizing is standard CSS resizing and will distort image objects.
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"ResizeBehaviour", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class ResizeBehaviour
		Inherits mstns.ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for ResizeBehaviour
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
			_elementName = "ResizeBehaviour"
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
			_ResizeType = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Both", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_CustomCursor = ""
			_SnapGridWidth = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_SnapGridHeight = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_MaxWidth = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("500", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_MaxHeight = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("500", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_MinRequiredHeight = 0
			_IsNilMinRequiredHeight = False
			_MinRequiredWidth = 0
			_IsNilMinRequiredWidth = False
			_MaxRequiredHeight = 0
			_IsNilMaxRequiredHeight = False
			_MaxRequiredWidth = 0
			_IsNilMaxRequiredWidth = False
			_GoToPageCorrect = ""
			_IsNilGoToPageCorrect = False
			_GoToPageIncorrect = ""
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
			Dim newObject As New mstns.ResizeBehaviour(_elementName)
			Dim o As Object
			newObject._ResizeType = _ResizeType
			newObject._CustomCursor = _CustomCursor
			newObject._SnapGridWidth = _SnapGridWidth
			newObject._SnapGridHeight = _SnapGridHeight
			newObject._MaxWidth = _MaxWidth
			newObject._MaxHeight = _MaxHeight
			newObject._MinRequiredHeight = _MinRequiredHeight
			newObject._IsNilMinRequiredHeight = _IsNilMinRequiredHeight
			newObject._MinRequiredWidth = _MinRequiredWidth
			newObject._IsNilMinRequiredWidth = _IsNilMinRequiredWidth
			newObject._MaxRequiredHeight = _MaxRequiredHeight
			newObject._IsNilMaxRequiredHeight = _IsNilMaxRequiredHeight
			newObject._MaxRequiredWidth = _MaxRequiredWidth
			newObject._IsNilMaxRequiredWidth = _IsNilMaxRequiredWidth
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

		#Region "Attribute - ResizeType"
		''' <summary>
		''' Whether the object can be resized horizontally, vertically or both ways.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Both", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("ResizeType", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property ResizeType() as String
			Get 
				Return _ResizeType  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(0, value)
				_ResizeType = value 
			End Set
		End Property
		Protected _ResizeType As String

		#End Region
	
		#Region "Attribute - CustomCursor"
		''' <summary>
		''' A custom resize handle cursor (applies to all handles).
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("CustomCursor", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property CustomCursor() as String
			Get 
				Return _CustomCursor  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(1, value)
				_CustomCursor = value 
			End Set
		End Property
		Protected _CustomCursor As String

		#End Region
	
		#Region "Attribute - SnapGridWidth"
		''' <summary>
		''' Width of grid cell to snap to during resizing (0 = none).
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("SnapGridWidth", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property SnapGridWidth() as Integer
			Get 
				Return _SnapGridWidth  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(2, value)
				_SnapGridWidth = value 
			End Set
		End Property
		Protected _SnapGridWidth As Integer

		#End Region
	
		#Region "Attribute - SnapGridHeight"
		''' <summary>
		''' Height of grid cell to snap to during resizing (0 = none).
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("SnapGridHeight", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property SnapGridHeight() as Integer
			Get 
				Return _SnapGridHeight  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(3, value)
				_SnapGridHeight = value 
			End Set
		End Property
		Protected _SnapGridHeight As Integer

		#End Region
	
		#Region "Attribute - MaxWidth"
		''' <summary>
		''' Maximum pixel width possible.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("500", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("MaxWidth", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "1", "3000", "-1", "4", "-1")> _
		Public Property MaxWidth() as Integer
			Get 
				Return _MaxWidth  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(4, value)
				_MaxWidth = value 
			End Set
		End Property
		Protected _MaxWidth As Integer

		#End Region
	
		#Region "Attribute - MaxHeight"
		''' <summary>
		''' Maximum pixel height possible.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("500", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("MaxHeight", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "1", "3000", "-1", "4", "-1")> _
		Public Property MaxHeight() as Integer
			Get 
				Return _MaxHeight  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(5, value)
				_MaxHeight = value 
			End Set
		End Property
		Protected _MaxHeight As Integer

		#End Region
	
		#Region "Attribute - MinRequiredHeight"
		''' <summary>
		''' Minimum required pixel height to complete interaction.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to 0.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("MinRequiredHeight", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilMinRequiredHeight", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property MinRequiredHeight() as Integer
			Get 
				Return _MinRequiredHeight  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(6, value)
				_MinRequiredHeight = value 
				_IsNilMinRequiredHeight = False
			End Set
		End Property
		Protected _MinRequiredHeight As Integer

		Public Property IsNilMinRequiredHeight As Boolean
			Get
				Return _IsNilMinRequiredHeight
			End Get
			Set
				_IsNilMinRequiredHeight = value
			End Set
		End Property
		Protected _IsNilMinRequiredHeight As Boolean
		#End Region
	
		#Region "Attribute - MinRequiredWidth"
		''' <summary>
		''' Minimum required pixel width to complete interaction.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to 0.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("MinRequiredWidth", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilMinRequiredWidth", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property MinRequiredWidth() as Integer
			Get 
				Return _MinRequiredWidth  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(7, value)
				_MinRequiredWidth = value 
				_IsNilMinRequiredWidth = False
			End Set
		End Property
		Protected _MinRequiredWidth As Integer

		Public Property IsNilMinRequiredWidth As Boolean
			Get
				Return _IsNilMinRequiredWidth
			End Get
			Set
				_IsNilMinRequiredWidth = value
			End Set
		End Property
		Protected _IsNilMinRequiredWidth As Boolean
		#End Region
	
		#Region "Attribute - MaxRequiredHeight"
		''' <summary>
		''' Maximum required pixel height to complete interaction.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to 0.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("MaxRequiredHeight", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilMaxRequiredHeight", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property MaxRequiredHeight() as Integer
			Get 
				Return _MaxRequiredHeight  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(8, value)
				_MaxRequiredHeight = value 
				_IsNilMaxRequiredHeight = False
			End Set
		End Property
		Protected _MaxRequiredHeight As Integer

		Public Property IsNilMaxRequiredHeight As Boolean
			Get
				Return _IsNilMaxRequiredHeight
			End Get
			Set
				_IsNilMaxRequiredHeight = value
			End Set
		End Property
		Protected _IsNilMaxRequiredHeight As Boolean
		#End Region
	
		#Region "Attribute - MaxRequiredWidth"
		''' <summary>
		''' Maximum required pixel width to complete interaction.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to 0.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("MaxRequiredWidth", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilMaxRequiredWidth", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property MaxRequiredWidth() as Integer
			Get 
				Return _MaxRequiredWidth  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(9, value)
				_MaxRequiredWidth = value 
				_IsNilMaxRequiredWidth = False
			End Set
		End Property
		Protected _MaxRequiredWidth As Integer

		Public Property IsNilMaxRequiredWidth As Boolean
			Get
				Return _IsNilMaxRequiredWidth
			End Get
			Set
				_IsNilMaxRequiredWidth = value
			End Set
		End Property
		Protected _IsNilMaxRequiredWidth As Boolean
		#End Region
	
		#Region "Attribute - GoToPageCorrect"
		''' <summary>
		''' Which page to go to when resized correctly.
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
				CheckElementRestriction(10, value)
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
		''' Which page to go to when resized incorrectly.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("GoToPageIncorrect", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilGoToPageIncorrect", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property GoToPageIncorrect() as String
			Get 
				Return _GoToPageIncorrect  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(11, value)
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
		''' If resized to correct target size, score assessment activity correct.
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
				CheckElementRestriction(12, value)
				_AssessmentCorrect = value 
			End Set
		End Property
		Protected _AssessmentCorrect As Boolean

		#End Region
	
		#Region "Attribute - AssessmentIncorrect"
		''' <summary>
		''' If resized to incorrect target size, score assessment activity incorrect.
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
				CheckElementRestriction(13, value)
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


