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
	''' This class represents the ComplexType FontFamily
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"FontFamily", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class FontFamily
		Inherits ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for FontFamily
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
			_elementName = "FontFamily"
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
			_Georgia = Nothing
			_Palatino = Nothing
			_Times = Nothing
			_Arial = Nothing
			_ArialBlack = Nothing
			_ComicSans = Nothing
			_Impact = Nothing
			_LucidaSans = Nothing
			_Tahoma = Nothing
			_Helvetica = Nothing
			_Verdana = Nothing
			_Courier = Nothing
			_LucidaConsol = Nothing



			_validElement = ""
' ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Additional initialization code here...

' ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		End Sub

		Protected Sub ClearChoice(ByVal selectedElement as string)
			_Georgia = Nothing
			_Palatino = Nothing
			_Times = Nothing
			_Arial = Nothing
			_ArialBlack = Nothing
			_ComicSans = Nothing
			_Impact = Nothing
			_LucidaSans = Nothing
			_Tahoma = Nothing
			_Helvetica = Nothing
			_Verdana = Nothing
			_Courier = Nothing
			_LucidaConsol = Nothing
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
			Dim newObject As New mstns.FontFamily(_elementName)
			Dim o As Object
			newObject._Georgia = Nothing
			if (Not _Georgia Is Nothing) Then
				newObject._Georgia = CType(_Georgia.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Palatino = Nothing
			if (Not _Palatino Is Nothing) Then
				newObject._Palatino = CType(_Palatino.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Times = Nothing
			if (Not _Times Is Nothing) Then
				newObject._Times = CType(_Times.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Arial = Nothing
			if (Not _Arial Is Nothing) Then
				newObject._Arial = CType(_Arial.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._ArialBlack = Nothing
			if (Not _ArialBlack Is Nothing) Then
				newObject._ArialBlack = CType(_ArialBlack.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._ComicSans = Nothing
			if (Not _ComicSans Is Nothing) Then
				newObject._ComicSans = CType(_ComicSans.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Impact = Nothing
			if (Not _Impact Is Nothing) Then
				newObject._Impact = CType(_Impact.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._LucidaSans = Nothing
			if (Not _LucidaSans Is Nothing) Then
				newObject._LucidaSans = CType(_LucidaSans.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Tahoma = Nothing
			if (Not _Tahoma Is Nothing) Then
				newObject._Tahoma = CType(_Tahoma.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Helvetica = Nothing
			if (Not _Helvetica Is Nothing) Then
				newObject._Helvetica = CType(_Helvetica.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Verdana = Nothing
			if (Not _Verdana Is Nothing) Then
				newObject._Verdana = CType(_Verdana.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Courier = Nothing
			if (Not _Courier Is Nothing) Then
				newObject._Courier = CType(_Courier.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._LucidaConsol = Nothing
			if (Not _LucidaConsol Is Nothing) Then
				newObject._LucidaConsol = CType(_LucidaConsol.Clone(), LiquidTechnologies.Runtime.Net45.Element)
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

		#Region "Attribute - Georgia"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("Georgia", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Georgia() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Georgia  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Georgia")
				_Georgia = value 
			End Set
		End Property
		Protected _Georgia As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - Palatino"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("Palatino", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Palatino() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Palatino  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Palatino")
				_Palatino = value 
			End Set
		End Property
		Protected _Palatino As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - Times"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("Times", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Times() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Times  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Times")
				_Times = value 
			End Set
		End Property
		Protected _Times As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - Arial"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("Arial", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Arial() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Arial  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Arial")
				_Arial = value 
			End Set
		End Property
		Protected _Arial As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - ArialBlack"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("ArialBlack", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property ArialBlack() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _ArialBlack  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("ArialBlack")
				_ArialBlack = value 
			End Set
		End Property
		Protected _ArialBlack As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - ComicSans"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("ComicSans", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property ComicSans() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _ComicSans  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("ComicSans")
				_ComicSans = value 
			End Set
		End Property
		Protected _ComicSans As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - Impact"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("Impact", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Impact() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Impact  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Impact")
				_Impact = value 
			End Set
		End Property
		Protected _Impact As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - LucidaSans"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("LucidaSans", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property LucidaSans() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _LucidaSans  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("LucidaSans")
				_LucidaSans = value 
			End Set
		End Property
		Protected _LucidaSans As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - Tahoma"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("Tahoma", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Tahoma() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Tahoma  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Tahoma")
				_Tahoma = value 
			End Set
		End Property
		Protected _Tahoma As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - Helvetica"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("Helvetica", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Helvetica() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Helvetica  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Helvetica")
				_Helvetica = value 
			End Set
		End Property
		Protected _Helvetica As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - Verdana"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("Verdana", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Verdana() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Verdana  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Verdana")
				_Verdana = value 
			End Set
		End Property
		Protected _Verdana As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - Courier"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("Courier", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Courier() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Courier  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Courier")
				_Courier = value 
			End Set
		End Property
		Protected _Courier As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - LucidaConsol"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("LucidaConsol", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property LucidaConsol() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _LucidaConsol  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("LucidaConsol")
				_LucidaConsol = value 
			End Set
		End Property
		Protected _LucidaConsol As LiquidTechnologies.Runtime.Net45.Element
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


