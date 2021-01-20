Option Explicit On
Option Strict On

Imports System
Imports System.Xml

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
'* Using Schema: W:\NHS CfH ICT Contract\2015-2016 Work\Content Management and Development\CDA\ITSPCDA.xsd
'**********************************************************************************************

Namespace mstns

	''' <summary>
	''' This class represents the ComplexType Objective
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"Objective", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class Objective
		Inherits ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for Objective
		''' </summary>
		''' <remarks>
		'''	The class is created with all the mandatory fields populated with the
		'''	default data. 
		'''	All Collection object are created.
		'''	However any 1-n relationships (these are represented as collections) are
		'''	empty. To comply with the schema these must be populated before the xml
		'''	obtained from ToXml is valid against the schema W:\NHS CfH ICT Contract\2015-2016 Work\Content Management and Development\CDA\ITSPCDA.xsd
		''' </remarks>
		Public Sub New()
			_elementName = "Objective"
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
		'''	obtained from ToXml is valid against the schema W:\NHS CfH ICT Contract\2015-2016 Work\Content Management and Development\CDA\ITSPCDA.xsd.
		''' </remarks>
		Protected Overrides Sub Init()
			ITSPCDALib.Registration.iRegistrationIndicator = 0 ' causes registration to take place
			_ObjectiveDescription = ""
			_IsValidObjectiveDescription = false
			_ObjectiveID = 0
			_IsValidObjectiveID = false



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
			Dim newObject As New mstns.Objective(_elementName)
			Dim o As Object
			newObject._ObjectiveDescription = _ObjectiveDescription
			newObject._IsValidObjectiveDescription = _IsValidObjectiveDescription
			newObject._ObjectiveID = _ObjectiveID
			newObject._IsValidObjectiveID = _IsValidObjectiveID

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

		#Region "Attribute - ObjectiveDescription"
		''' <summary>
		''' Represents an optional Attribute in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' This property is represented as an Attribute in the XML.
		''' It is optional, initially it is not valid.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("ObjectiveDescription", "", "IsValidObjectiveDescription", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, Nothing, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property ObjectiveDescription() As String
			Get 
				if (_IsValidObjectiveDescription = false) Then
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ObjectiveDescription is not valid. Set ObjectiveDescriptionValid = true")
				End If
				Return _ObjectiveDescription  
			End Get
			Set(ByVal value As String) 
				CheckAttributeRestriction(0, value)
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				_IsValidObjectiveDescription = true
				_ObjectiveDescription = value 
			End Set
		End Property
		''' <summary>
		''' Indicates if ObjectiveDescription contains a valid value.
		''' </summary>
		''' <remarks>
		''' true if the value for ObjectiveDescription is valid, false if not.
		'''	If this is set to true then the property is considered valid, and assigned its
		'''	default value ("").
		'''	If its set to false then its made invalid, and subsequent calls to get ObjectiveDescription
		'''	will raise an exception.
		''' </remarks>
		Public Property IsValidObjectiveDescription() As Boolean 
			Get
				Return _IsValidObjectiveDescription
			End Get
			Set(ByVal value As Boolean) 
				If (value <> _IsValidObjectiveDescription) Then
					ObjectiveDescription = ""
					_IsValidObjectiveDescription = value
				End If
			End Set
		End Property
		Protected _IsValidObjectiveDescription as Boolean
		Protected _ObjectiveDescription as String
		#End Region
	
		#Region "Attribute - ObjectiveID"
		''' <summary>
		''' Represents an optional Attribute in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' This property is represented as an Attribute in the XML.
		''' It is optional, initially it is not valid.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("ObjectiveID", "", "IsValidObjectiveID", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, Nothing, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property ObjectiveID() As Integer
			Get 
				if (_IsValidObjectiveID = false) Then
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ObjectiveID is not valid. Set ObjectiveIDValid = true")
				End If
				Return _ObjectiveID  
			End Get
			Set(ByVal value As Integer) 
				CheckAttributeRestriction(1, value)
				_IsValidObjectiveID = true
				_ObjectiveID = value 
			End Set
		End Property
		''' <summary>
		''' Indicates if ObjectiveID contains a valid value.
		''' </summary>
		''' <remarks>
		''' true if the value for ObjectiveID is valid, false if not.
		'''	If this is set to true then the property is considered valid, and assigned its
		'''	default value (0).
		'''	If its set to false then its made invalid, and subsequent calls to get ObjectiveID
		'''	will raise an exception.
		''' </remarks>
		Public Property IsValidObjectiveID() As Boolean 
			Get
				Return _IsValidObjectiveID
			End Get
			Set(ByVal value As Boolean) 
				If (value <> _IsValidObjectiveID) Then
					ObjectiveID = 0
					_IsValidObjectiveID = value
				End If
			End Set
		End Property
		Protected _IsValidObjectiveID as Boolean
		Protected _ObjectiveID as Integer
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


