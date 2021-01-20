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
	''' This class represents the ComplexType PageType
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"PageType", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class PageType
		Inherits ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for PageType
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
			_elementName = "PageType"
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
			_Explain = Nothing
			_Guide = Nothing
			_Demo = Nothing
			_Practice = Nothing
			_Test = Nothing



			_validElement = ""
' ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Additional initialization code here...

' ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		End Sub

		Protected Sub ClearChoice(ByVal selectedElement as string)
			_Explain = Nothing
			_Guide = Nothing
			_Demo = Nothing
			_Practice = Nothing
			_Test = Nothing
			_validElement = selectedElement
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
			Dim newObject As New mstns.PageType(_elementName)
			Dim o As Object
			newObject._Explain = Nothing
			if (Not _Explain Is Nothing) Then
				newObject._Explain = CType(_Explain.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Guide = Nothing
			if (Not _Guide Is Nothing) Then
				newObject._Guide = CType(_Guide.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Demo = Nothing
			if (Not _Demo Is Nothing) Then
				newObject._Demo = CType(_Demo.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Practice = Nothing
			if (Not _Practice Is Nothing) Then
				newObject._Practice = CType(_Practice.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Test = Nothing
			if (Not _Test Is Nothing) Then
				newObject._Test = CType(_Test.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If

			o = Nothing

			newObject._validElement = _validElement

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

		#Region "Attribute - Explain"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("Explain", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Explain() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Explain  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Explain")
				_Explain = value 
			End Set
		End Property
		Protected _Explain As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - Guide"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("Guide", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Guide() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Guide  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Guide")
				_Guide = value 
			End Set
		End Property
		Protected _Guide As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - Demo"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("Demo", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Demo() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Demo  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Demo")
				_Demo = value 
			End Set
		End Property
		Protected _Demo As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - Practice"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("Practice", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Practice() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Practice  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Practice")
				_Practice = value 
			End Set
		End Property
		Protected _Practice As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - Test"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("Test", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Test() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Test  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Test")
				_Test = value 
			End Set
		End Property
		Protected _Test As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		Public Readonly Property ChoiceSelectedElement() As String 
			get 
				Return _validElement 
			End Get
		End Property
		Protected _validElement As String
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


