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
	''' This class represents the ComplexType MouseCursor
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"MouseCursor", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class MouseCursor
		Inherits ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for MouseCursor
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
			_elementName = "MouseCursor"
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
			_Cell = Nothing
			_Col_resize = Nothing
			_Copy = Nothing
			_Crosshair = Nothing
			_Default = Nothing
			_Help = Nothing
			_Move = Nothing
			_None = Nothing
			_Not_allowed = Nothing
			_Pointer = Nothing
			_Progress = Nothing
			_Ew_resize = Nothing
			_Ne_resize = Nothing
			_Ns_resize = Nothing
			_Nw_resize = Nothing
			_Row_resize = Nothing
			_Text = Nothing
			_URL = Nothing
			_Vertical_text = Nothing
			_Wait = Nothing
			_Zoom_in = Nothing
			_Zoom_out = Nothing



			_validElement = ""
' ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Additional initialization code here...

' ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		End Sub

		Protected Sub ClearChoice(ByVal selectedElement as string)
			_Cell = Nothing
			_Col_resize = Nothing
			_Copy = Nothing
			_Crosshair = Nothing
			_Default = Nothing
			_Help = Nothing
			_Move = Nothing
			_None = Nothing
			_Not_allowed = Nothing
			_Pointer = Nothing
			_Progress = Nothing
			_Ew_resize = Nothing
			_Ne_resize = Nothing
			_Ns_resize = Nothing
			_Nw_resize = Nothing
			_Row_resize = Nothing
			_Text = Nothing
			_URL = Nothing
			_Vertical_text = Nothing
			_Wait = Nothing
			_Zoom_in = Nothing
			_Zoom_out = Nothing
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
			Dim newObject As New mstns.MouseCursor(_elementName)
			Dim o As Object
			newObject._Cell = Nothing
			if (Not _Cell Is Nothing) Then
				newObject._Cell = CType(_Cell.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Col_resize = Nothing
			if (Not _Col_resize Is Nothing) Then
				newObject._Col_resize = CType(_Col_resize.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Copy = Nothing
			if (Not _Copy Is Nothing) Then
				newObject._Copy = CType(_Copy.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Crosshair = Nothing
			if (Not _Crosshair Is Nothing) Then
				newObject._Crosshair = CType(_Crosshair.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Default = Nothing
			if (Not _Default Is Nothing) Then
				newObject._Default = CType(_Default.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Help = Nothing
			if (Not _Help Is Nothing) Then
				newObject._Help = CType(_Help.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Move = Nothing
			if (Not _Move Is Nothing) Then
				newObject._Move = CType(_Move.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._None = Nothing
			if (Not _None Is Nothing) Then
				newObject._None = CType(_None.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Not_allowed = Nothing
			if (Not _Not_allowed Is Nothing) Then
				newObject._Not_allowed = CType(_Not_allowed.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Pointer = Nothing
			if (Not _Pointer Is Nothing) Then
				newObject._Pointer = CType(_Pointer.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Progress = Nothing
			if (Not _Progress Is Nothing) Then
				newObject._Progress = CType(_Progress.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Ew_resize = Nothing
			if (Not _Ew_resize Is Nothing) Then
				newObject._Ew_resize = CType(_Ew_resize.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Ne_resize = Nothing
			if (Not _Ne_resize Is Nothing) Then
				newObject._Ne_resize = CType(_Ne_resize.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Ns_resize = Nothing
			if (Not _Ns_resize Is Nothing) Then
				newObject._Ns_resize = CType(_Ns_resize.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Nw_resize = Nothing
			if (Not _Nw_resize Is Nothing) Then
				newObject._Nw_resize = CType(_Nw_resize.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Row_resize = Nothing
			if (Not _Row_resize Is Nothing) Then
				newObject._Row_resize = CType(_Row_resize.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Text = Nothing
			if (Not _Text Is Nothing) Then
				newObject._Text = CType(_Text.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._URL = Nothing
			if (Not _URL Is Nothing) Then
				newObject._URL = CType(_URL.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Vertical_text = Nothing
			if (Not _Vertical_text Is Nothing) Then
				newObject._Vertical_text = CType(_Vertical_text.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Wait = Nothing
			if (Not _Wait Is Nothing) Then
				newObject._Wait = CType(_Wait.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Zoom_in = Nothing
			if (Not _Zoom_in Is Nothing) Then
				newObject._Zoom_in = CType(_Zoom_in.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Zoom_out = Nothing
			if (Not _Zoom_out Is Nothing) Then
				newObject._Zoom_out = CType(_Zoom_out.Clone(), LiquidTechnologies.Runtime.Net45.Element)
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

		#Region "Attribute - cell"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("cell", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Cell() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Cell  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("cell")
				_Cell = value 
			End Set
		End Property
		Protected _Cell As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - col-resize"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("col-resize", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Col_resize() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Col_resize  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("col_resize")
				_Col_resize = value 
			End Set
		End Property
		Protected _Col_resize As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - copy"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("copy", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Copy() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Copy  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("copy")
				_Copy = value 
			End Set
		End Property
		Protected _Copy As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - crosshair"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("crosshair", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Crosshair() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Crosshair  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("crosshair")
				_Crosshair = value 
			End Set
		End Property
		Protected _Crosshair As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - default"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("default", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Default_() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Default  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Default_")
				_Default = value 
			End Set
		End Property
		Protected _Default As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - help"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("help", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Help() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Help  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("help")
				_Help = value 
			End Set
		End Property
		Protected _Help As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - move"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("move", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Move() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Move  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("move")
				_Move = value 
			End Set
		End Property
		Protected _Move As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - none"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("none", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property None() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _None  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("none")
				_None = value 
			End Set
		End Property
		Protected _None As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - not-allowed"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("not-allowed", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Not_allowed() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Not_allowed  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("not_allowed")
				_Not_allowed = value 
			End Set
		End Property
		Protected _Not_allowed As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - pointer"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("pointer", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Pointer() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Pointer  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("pointer")
				_Pointer = value 
			End Set
		End Property
		Protected _Pointer As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - progress"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("progress", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Progress() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Progress  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("progress")
				_Progress = value 
			End Set
		End Property
		Protected _Progress As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - ew-resize"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("ew-resize", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Ew_resize() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Ew_resize  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("ew_resize")
				_Ew_resize = value 
			End Set
		End Property
		Protected _Ew_resize As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - ne-resize"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("ne-resize", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Ne_resize() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Ne_resize  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("ne_resize")
				_Ne_resize = value 
			End Set
		End Property
		Protected _Ne_resize As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - ns-resize"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("ns-resize", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Ns_resize() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Ns_resize  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("ns_resize")
				_Ns_resize = value 
			End Set
		End Property
		Protected _Ns_resize As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - nw-resize"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("nw-resize", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Nw_resize() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Nw_resize  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("nw_resize")
				_Nw_resize = value 
			End Set
		End Property
		Protected _Nw_resize As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - row-resize"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("row-resize", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Row_resize() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Row_resize  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("row_resize")
				_Row_resize = value 
			End Set
		End Property
		Protected _Row_resize As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - text"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("text", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Text_() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Text  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Text_")
				_Text = value 
			End Set
		End Property
		Protected _Text As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - URL"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("URL", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property URL() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _URL  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("URL")
				_URL = value 
			End Set
		End Property
		Protected _URL As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - vertical-text"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("vertical-text", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Vertical_text() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Vertical_text  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("vertical_text")
				_Vertical_text = value 
			End Set
		End Property
		Protected _Vertical_text As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - wait"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("wait", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Wait() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Wait  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("wait")
				_Wait = value 
			End Set
		End Property
		Protected _Wait As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - zoom-in"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("zoom-in", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Zoom_in() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Zoom_in  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("zoom_in")
				_Zoom_in = value 
			End Set
		End Property
		Protected _Zoom_in As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - zoom-out"
		''' <summary>
		''' Represents an optional untyped element in the XML document
		''' 
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("zoom-out", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Zoom_out() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Zoom_out  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("zoom_out")
				_Zoom_out = value 
			End Set
		End Property
		Protected _Zoom_out As LiquidTechnologies.Runtime.Net45.Element
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


