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
	''' This class represents the ComplexType SpinnerBehaviour
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"SpinnerBehaviour", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class SpinnerBehaviour
		Inherits mstns.ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for SpinnerBehaviour
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
			_elementName = "SpinnerBehaviour"
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
			_Direction = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Up", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_TextAreaObject = ""
			_StepSize = LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_DecimalPoints = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_MinVal = LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_MaxVal = LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("10", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_Units = ""
			_JudgeOnClick = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)



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
			Dim newObject As New mstns.SpinnerBehaviour(_elementName)
			Dim o As Object
			newObject._Direction = _Direction
			newObject._TextAreaObject = _TextAreaObject
			newObject._StepSize = _StepSize
			newObject._DecimalPoints = _DecimalPoints
			newObject._MinVal = _MinVal
			newObject._MaxVal = _MaxVal
			newObject._Units = _Units
			newObject._JudgeOnClick = _JudgeOnClick

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

		#Region "Attribute - Direction"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Up", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("Direction", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property Direction() as String
			Get 
				Return _Direction  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(0, value)
				_Direction = value 
			End Set
		End Property
		Protected _Direction As String

		#End Region
	
		#Region "Attribute - TextAreaObject"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("TextAreaObject", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property TextAreaObject() as String
			Get 
				Return _TextAreaObject  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(1, value)
				_TextAreaObject = value 
			End Set
		End Property
		Protected _TextAreaObject As String

		#End Region
	
		#Region "Attribute - StepSize"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("StepSize", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property StepSize() as Decimal
			Get 
				Return _StepSize  
			End Get
			Set(ByVal value As Decimal) 
				CheckElementRestriction(2, value)
				_StepSize = value 
			End Set
		End Property
		Protected _StepSize As Decimal

		#End Region
	
		#Region "Attribute - DecimalPoints"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("DecimalPoints", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property DecimalPoints() as Integer
			Get 
				Return _DecimalPoints  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(3, value)
				_DecimalPoints = value 
			End Set
		End Property
		Protected _DecimalPoints As Integer

		#End Region
	
		#Region "Attribute - MinVal"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("MinVal", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property MinVal() as Decimal
			Get 
				Return _MinVal  
			End Get
			Set(ByVal value As Decimal) 
				CheckElementRestriction(4, value)
				_MinVal = value 
			End Set
		End Property
		Protected _MinVal As Decimal

		#End Region
	
		#Region "Attribute - MaxVal"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("10", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("MaxVal", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property MaxVal() as Decimal
			Get 
				Return _MaxVal  
			End Get
			Set(ByVal value As Decimal) 
				CheckElementRestriction(5, value)
				_MaxVal = value 
			End Set
		End Property
		Protected _MaxVal As Decimal

		#End Region
	
		#Region "Attribute - Units"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("Units", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property Units() as String
			Get 
				Return _Units  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(6, value)
				_Units = value 
			End Set
		End Property
		Protected _Units As String

		#End Region
	
		#Region "Attribute - JudgeOnClick"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("JudgeOnClick", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property JudgeOnClick() as Boolean
			Get 
				Return _JudgeOnClick  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(7, value)
				_JudgeOnClick = value 
			End Set
		End Property
		Protected _JudgeOnClick As Boolean

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


