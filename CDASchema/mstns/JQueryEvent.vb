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
	''' This class represents the ComplexType jQueryEvent
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"jQueryEvent", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class JQueryEvent
		Inherits ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for JQueryEvent
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
			_elementName = "jQueryEvent"
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
			_Blur = Nothing
			_Change = Nothing
			_Click = Nothing
			_Dblclick = Nothing
			_Focus = Nothing
			_Focusin = Nothing
			_Focusout = Nothing
			_Hover = Nothing
			_Keydown = Nothing
			_Keypress = Nothing
			_Keyup = Nothing
			_Mousedown = Nothing
			_Mouseenter = Nothing
			_Mouseleave = Nothing
			_Mousemove = Nothing
			_Mouseout = Nothing
			_Mouseover = Nothing
			_Mouseup = Nothing
			_Ready = Nothing
			_Resize = Nothing
			_Scroll = Nothing
			_Select = Nothing



			_validElement = ""
' ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Additional initialization code here...

' ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		End Sub

		Protected Sub ClearChoice(ByVal selectedElement as string)
			_Blur = Nothing
			_Change = Nothing
			_Click = Nothing
			_Dblclick = Nothing
			_Focus = Nothing
			_Focusin = Nothing
			_Focusout = Nothing
			_Hover = Nothing
			_Keydown = Nothing
			_Keypress = Nothing
			_Keyup = Nothing
			_Mousedown = Nothing
			_Mouseenter = Nothing
			_Mouseleave = Nothing
			_Mousemove = Nothing
			_Mouseout = Nothing
			_Mouseover = Nothing
			_Mouseup = Nothing
			_Ready = Nothing
			_Resize = Nothing
			_Scroll = Nothing
			_Select = Nothing
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
			Dim newObject As New mstns.JQueryEvent(_elementName)
			Dim o As Object
			newObject._Blur = Nothing
			if (Not _Blur Is Nothing) Then
				newObject._Blur = CType(_Blur.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Change = Nothing
			if (Not _Change Is Nothing) Then
				newObject._Change = CType(_Change.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Click = Nothing
			if (Not _Click Is Nothing) Then
				newObject._Click = CType(_Click.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Dblclick = Nothing
			if (Not _Dblclick Is Nothing) Then
				newObject._Dblclick = CType(_Dblclick.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Focus = Nothing
			if (Not _Focus Is Nothing) Then
				newObject._Focus = CType(_Focus.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Focusin = Nothing
			if (Not _Focusin Is Nothing) Then
				newObject._Focusin = CType(_Focusin.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Focusout = Nothing
			if (Not _Focusout Is Nothing) Then
				newObject._Focusout = CType(_Focusout.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Hover = Nothing
			if (Not _Hover Is Nothing) Then
				newObject._Hover = CType(_Hover.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Keydown = Nothing
			if (Not _Keydown Is Nothing) Then
				newObject._Keydown = CType(_Keydown.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Keypress = Nothing
			if (Not _Keypress Is Nothing) Then
				newObject._Keypress = CType(_Keypress.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Keyup = Nothing
			if (Not _Keyup Is Nothing) Then
				newObject._Keyup = CType(_Keyup.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Mousedown = Nothing
			if (Not _Mousedown Is Nothing) Then
				newObject._Mousedown = CType(_Mousedown.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Mouseenter = Nothing
			if (Not _Mouseenter Is Nothing) Then
				newObject._Mouseenter = CType(_Mouseenter.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Mouseleave = Nothing
			if (Not _Mouseleave Is Nothing) Then
				newObject._Mouseleave = CType(_Mouseleave.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Mousemove = Nothing
			if (Not _Mousemove Is Nothing) Then
				newObject._Mousemove = CType(_Mousemove.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Mouseout = Nothing
			if (Not _Mouseout Is Nothing) Then
				newObject._Mouseout = CType(_Mouseout.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Mouseover = Nothing
			if (Not _Mouseover Is Nothing) Then
				newObject._Mouseover = CType(_Mouseover.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Mouseup = Nothing
			if (Not _Mouseup Is Nothing) Then
				newObject._Mouseup = CType(_Mouseup.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Ready = Nothing
			if (Not _Ready Is Nothing) Then
				newObject._Ready = CType(_Ready.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Resize = Nothing
			if (Not _Resize Is Nothing) Then
				newObject._Resize = CType(_Resize.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Scroll = Nothing
			if (Not _Scroll Is Nothing) Then
				newObject._Scroll = CType(_Scroll.Clone(), LiquidTechnologies.Runtime.Net45.Element)
			End If
			newObject._Select = Nothing
			if (Not _Select Is Nothing) Then
				newObject._Select = CType(_Select.Clone(), LiquidTechnologies.Runtime.Net45.Element)
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

		#Region "Attribute - blur"
		''' <summary>
		''' The blur event occurs when an element loses focus.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("blur", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Blur() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Blur  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("blur")
				_Blur = value 
			End Set
		End Property
		Protected _Blur As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - change"
		''' <summary>
		''' The change event occurs when the value of an element is changed (only works on form fields).
		'''                         Note: For select menus, the change event occurs when an option is selected. For text fields or text areas, the change event occurs when the field loses focus.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("change", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Change() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Change  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("change")
				_Change = value 
			End Set
		End Property
		Protected _Change As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - click"
		''' <summary>
		''' The click event occurs when an element is clicked.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("click", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Click() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Click  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("click")
				_Click = value 
			End Set
		End Property
		Protected _Click As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - dblclick"
		''' <summary>
		''' The dblclick event occurs when an element is double-clicked.
		'''                         Tip: The dblclick event also generates a click event. This can cause problems if both events are applied to the same element.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("dblclick", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Dblclick() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Dblclick  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("dblclick")
				_Dblclick = value 
			End Set
		End Property
		Protected _Dblclick As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - focus"
		''' <summary>
		''' The focus event occurs when an element gets focus (when selected by a mouse click or by "tab-navigating" to it).
		'''                         Tip: This method is often used together with the blur() method.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("focus", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Focus() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Focus  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("focus")
				_Focus = value 
			End Set
		End Property
		Protected _Focus As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - focusin"
		''' <summary>
		''' The focusin event occurs when an element (or any elements inside it) gets focus.
		'''                         The focusin() method attaches a function to run when a focus event occurs on the element, or any elements inside it.
		'''                         Unlike the focus() method, the focusin() method also triggers if any child elements get focus.
		'''                         Tip: An element gets focus when selected by a mouse click or by "tab-navigating" to it.
		'''                         Tip: This method is often used together with the focusout() method.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("focusin", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Focusin() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Focusin  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("focusin")
				_Focusin = value 
			End Set
		End Property
		Protected _Focusin As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - focusout"
		''' <summary>
		''' The focusout event occurs when an element (or any elements inside it) loses focus.
		'''                         The focusout() method attaches a function to run when a focusout event occurs on the element, or any elements inside it.
		'''                         Unlike the blur() method, the focusout() method also triggers if any child elements lose focus.
		'''                         Tip: This method is often used together with the focusin() method.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("focusout", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Focusout() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Focusout  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("focusout")
				_Focusout = value 
			End Set
		End Property
		Protected _Focusout As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - hover"
		''' <summary>
		''' The hover() method specifies two functions to run when the mouse pointer hovers over the selected elements.
		'''                         This method triggers both the mouseenter and mouseleave events.
		'''                         Note: If only one function is specified, it will be run for both the mouseenter and mouseleave events.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("hover", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Hover() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Hover  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("hover")
				_Hover = value 
			End Set
		End Property
		Protected _Hover As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - keydown"
		''' <summary>
		''' The keydown event occurs when a keyboard key is pressed down.
		'''                         Tip: Use the event.which property to return which keyboard key was pressed.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("keydown", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Keydown() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Keydown  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("keydown")
				_Keydown = value 
			End Set
		End Property
		Protected _Keydown As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - keypress"
		''' <summary>
		''' The keypress event is similar to the keydown event. The event occurs when a button is pressed down.
		'''                         However, the keypress event is not fired for all keys (e.g. ALT, CTRL, SHIFT, ESC). Use the keydown() method to also check these keys.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("keypress", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Keypress() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Keypress  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("keypress")
				_Keypress = value 
			End Set
		End Property
		Protected _Keypress As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - keyup"
		''' <summary>
		''' The keyup event occurs when a keyboard key is released.
		'''                         Tip: Use the event.which property to return which key was pressed.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("keyup", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Keyup() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Keyup  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("keyup")
				_Keyup = value 
			End Set
		End Property
		Protected _Keyup As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - mousedown"
		''' <summary>
		''' The mousedown event occurs when the left mouse button is pressed down over the selected element.
		'''                         Tip: This method is often used together with the mouseup() method.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("mousedown", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Mousedown() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Mousedown  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("mousedown")
				_Mousedown = value 
			End Set
		End Property
		Protected _Mousedown As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - mouseenter"
		''' <summary>
		''' The mouseenter event occurs when the mouse pointer is over (enters) the selected element.
		'''                         Note: Unlike the mouseover event, the mouseenter event only triggers when the mouse pointer enters the selected element. The mouseover event is triggered if a mouse pointer enters any child elements as well. See the example at the end of the page for a demonstration.
		'''                         Tip: This event is often used together with the mouseleave event.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("mouseenter", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Mouseenter() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Mouseenter  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("mouseenter")
				_Mouseenter = value 
			End Set
		End Property
		Protected _Mouseenter As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - mouseleave"
		''' <summary>
		''' The mouseleave event occurs when the mouse pointer leaves the selected element.
		'''                         Note: Unlike the mouseout event, the mouseleave event only triggers when the mouse pointer leaves the selected elements. The mouseout event is triggered if a mouse pointer leaves any child elements as well as the selected element.  See the example at the end of the page for a demonstration.
		'''                         Tip: This event is often used together with the mouseenter event.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("mouseleave", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Mouseleave() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Mouseleave  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("mouseleave")
				_Mouseleave = value 
			End Set
		End Property
		Protected _Mouseleave As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - mousemove"
		''' <summary>
		''' The mouseover event occurs when the mouse pointer is over the selected element.
		'''                         Note: Unlike the mouseenter event, the mouseover event triggers if a mouse pointer enters any child elements as well as the selected element. The mouseenter event is only triggered when the mouse pointer enters the selected element. See the example at the end of the page for a demonstration.
		'''                         Tip: This event is often used together with the mouseout event.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("mousemove", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Mousemove() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Mousemove  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("mousemove")
				_Mousemove = value 
			End Set
		End Property
		Protected _Mousemove As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - mouseout"
		''' <summary>
		''' The mouseout event occurs when the mouse pointer leaves the selected element.
		'''                         Note: Unlike the mouseleave event, the mouseout event is triggered if a mouse pointer leaves any child elements as well as the selected element. The mouseleave event only triggers when the mouse pointer leaves the selected element. See the example at the end of the page for a demonstration.
		'''                         Tip: This event is often used together with the mouseover event.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("mouseout", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Mouseout() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Mouseout  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("mouseout")
				_Mouseout = value 
			End Set
		End Property
		Protected _Mouseout As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - mouseover"
		''' <summary>
		''' The mouseover event occurs when the mouse pointer is over the selected element.
		'''                         Note: Unlike the mouseenter event, the mouseover event triggers if a mouse pointer enters any child elements as well as the selected element. The mouseenter event is only triggered when the mouse pointer enters the selected element. See the example at the end of the page for a demonstration.
		'''                         Tip: This event is often used together with the mouseout event.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("mouseover", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Mouseover() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Mouseover  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("mouseover")
				_Mouseover = value 
			End Set
		End Property
		Protected _Mouseover As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - mouseup"
		''' <summary>
		''' The mouseup event occurs when the left mouse button is released over the selected element.
		'''                         Tip: This method is often used together with the mousedown() method.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("mouseup", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Mouseup() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Mouseup  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("mouseup")
				_Mouseup = value 
			End Set
		End Property
		Protected _Mouseup As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - ready"
		''' <summary>
		''' The ready event occurs when the DOM (document object model) has been loaded.
		'''                         Because this event occurs after the document is ready, it is a good place to have all other jQuery events and functions. Like in the example above.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("ready", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Ready() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Ready  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("ready")
				_Ready = value 
			End Set
		End Property
		Protected _Ready As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - resize"
		''' <summary>
		''' The resize event occurs when the browser window changes size.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("resize", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Resize() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Resize  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("resize")
				_Resize = value 
			End Set
		End Property
		Protected _Resize As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - scroll"
		''' <summary>
		''' The scroll event occurs when the user scrolls in the specified element.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("scroll", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Scroll() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Scroll  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("scroll")
				_Scroll = value 
			End Set
		End Property
		Protected _Scroll As LiquidTechnologies.Runtime.Net45.Element
		#End Region
	
		#Region "Attribute - select"
		''' <summary>
		''' The select event occurs when a text is selected (marked) in a text area or a text field.
		''' </summary>
		''' <remarks>
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("select", "https://www.itskill.nhs.uk/CDAFile.xsd", "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")> _
		Public Property Select_() As LiquidTechnologies.Runtime.Net45.Element 
			Get 
				Return _Select  
			End Get
			Set(ByVal value As LiquidTechnologies.Runtime.Net45.Element)
				if (Not value Is Nothing) Then
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "https://www.itskill.nhs.uk/CDAFile.xsd")
				End If
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Select_")
				_Select = value 
			End Set
		End Property
		Protected _Select As LiquidTechnologies.Runtime.Net45.Element
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


