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
	''' This class represents the ComplexType PasswordBehaviour
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"PasswordBehaviour", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class PasswordBehaviour
		Inherits mstns.ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for PasswordBehaviour
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
			_elementName = "PasswordBehaviour"
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
			_RequiredPassword = ""
			_JudgeOnTab = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_JudgeOnEnter = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("true", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_JudgeOnKeyup = false
			_GoToPageCorrect = ""
			_GoToPageIncorrect = ""
			_AssessCorrect = false
			_AssessIncorrect = false
			_HasFocus = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("true", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)



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
			Dim newObject As New mstns.PasswordBehaviour(_elementName)
			Dim o As Object
			newObject._RequiredPassword = _RequiredPassword
			newObject._JudgeOnTab = _JudgeOnTab
			newObject._JudgeOnEnter = _JudgeOnEnter
			newObject._JudgeOnKeyup = _JudgeOnKeyup
			newObject._GoToPageCorrect = _GoToPageCorrect
			newObject._GoToPageIncorrect = _GoToPageIncorrect
			newObject._AssessCorrect = _AssessCorrect
			newObject._AssessIncorrect = _AssessIncorrect
			newObject._HasFocus = _HasFocus

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

		#Region "Attribute - RequiredPassword"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("RequiredPassword", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property RequiredPassword() as String
			Get 
				Return _RequiredPassword  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(0, value)
				_RequiredPassword = value 
			End Set
		End Property
		Protected _RequiredPassword As String

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
				CheckElementRestriction(1, value)
				_JudgeOnTab = value 
			End Set
		End Property
		Protected _JudgeOnTab As Boolean

		#End Region
	
		#Region "Attribute - JudgeOnEnter"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("true", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("JudgeOnEnter", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property JudgeOnEnter() as Boolean
			Get 
				Return _JudgeOnEnter  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(2, value)
				_JudgeOnEnter = value 
			End Set
		End Property
		Protected _JudgeOnEnter As Boolean

		#End Region
	
		#Region "Attribute - JudgeOnKeyup"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to false.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("JudgeOnKeyup", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property JudgeOnKeyup() as Boolean
			Get 
				Return _JudgeOnKeyup  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(3, value)
				_JudgeOnKeyup = value 
			End Set
		End Property
		Protected _JudgeOnKeyup As Boolean

		#End Region
	
		#Region "Attribute - GoToPageCorrect"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("GoToPageCorrect", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property GoToPageCorrect() as String
			Get 
				Return _GoToPageCorrect  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(4, value)
				_GoToPageCorrect = value 
			End Set
		End Property
		Protected _GoToPageCorrect As String

		#End Region
	
		#Region "Attribute - GoToPageIncorrect"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("GoToPageIncorrect", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property GoToPageIncorrect() as String
			Get 
				Return _GoToPageIncorrect  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(5, value)
				_GoToPageIncorrect = value 
			End Set
		End Property
		Protected _GoToPageIncorrect As String

		#End Region
	
		#Region "Attribute - AssessCorrect"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to false.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("AssessCorrect", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property AssessCorrect() as Boolean
			Get 
				Return _AssessCorrect  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(6, value)
				_AssessCorrect = value 
			End Set
		End Property
		Protected _AssessCorrect As Boolean

		#End Region
	
		#Region "Attribute - AssessIncorrect"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to false.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("AssessIncorrect", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property AssessIncorrect() as Boolean
			Get 
				Return _AssessIncorrect  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(7, value)
				_AssessIncorrect = value 
			End Set
		End Property
		Protected _AssessIncorrect As Boolean

		#End Region
	
		#Region "Attribute - HasFocus"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("true", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("HasFocus", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property HasFocus() as Boolean
			Get 
				Return _HasFocus  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(8, value)
				_HasFocus = value 
			End Set
		End Property
		Protected _HasFocus As Boolean

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


