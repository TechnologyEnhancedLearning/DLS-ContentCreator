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
	''' This class represents the ComplexType Behaviours
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"Behaviours", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class Behaviours
		Inherits mstns.ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for Behaviours
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
			_elementName = "Behaviours"
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
			_MouseEvent = Nothing
			_Drag = Nothing
			_Resize = Nothing
			_Text = Nothing
			_Animate = Nothing
			_MousePointer = Nothing
			_FollowMouse = Nothing
			_Marquee = Nothing
			_CustomCSS = Nothing
			_CustomJavaScript = Nothing
			_KeyboardShortcut = Nothing
			_Password = Nothing
			_Spinner = Nothing
			_Tooltip = Nothing
			_Selectable = Nothing



			_validElement = ""
' ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Additional initialization code here...

' ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		End Sub

		Protected Sub ClearChoice(ByVal selectedElement as string)
			_MouseEvent = Nothing
			_Drag = Nothing
			_Resize = Nothing
			_Text = Nothing
			_Animate = Nothing
			_MousePointer = Nothing
			_FollowMouse = Nothing
			_Marquee = Nothing
			_CustomCSS = Nothing
			_CustomJavaScript = Nothing
			_KeyboardShortcut = Nothing
			_Password = Nothing
			_Spinner = Nothing
			_Tooltip = Nothing
			_Selectable = Nothing
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
			Dim newObject As New mstns.Behaviours(_elementName)
			Dim o As Object
			newObject._MouseEvent = Nothing
			if (Not _MouseEvent Is Nothing) then
				newObject._MouseEvent = CType(_MouseEvent.Clone(), mstns.MouseInteractionBehaviour)
			End If
			newObject._Drag = Nothing
			if (Not _Drag Is Nothing) then
				newObject._Drag = CType(_Drag.Clone(), mstns.DragBehaviour)
			End If
			newObject._Resize = Nothing
			if (Not _Resize Is Nothing) then
				newObject._Resize = CType(_Resize.Clone(), mstns.ResizeBehaviour)
			End If
			newObject._Text = Nothing
			if (Not _Text Is Nothing) then
				newObject._Text = CType(_Text.Clone(), mstns.TextBehaviour)
			End If
			newObject._Animate = Nothing
			if (Not _Animate Is Nothing) then
				newObject._Animate = CType(_Animate.Clone(), mstns.AnimateBehaviour)
			End If
			newObject._MousePointer = Nothing
			if (Not _MousePointer Is Nothing) then
				newObject._MousePointer = CType(_MousePointer.Clone(), mstns.ChangeMousePointerBehaviour)
			End If
			newObject._FollowMouse = Nothing
			if (Not _FollowMouse Is Nothing) then
				newObject._FollowMouse = CType(_FollowMouse.Clone(), mstns.FollowMouseBehaviour)
			End If
			newObject._Marquee = Nothing
			if (Not _Marquee Is Nothing) then
				newObject._Marquee = CType(_Marquee.Clone(), mstns.MarqueeBehaviour)
			End If
			newObject._CustomCSS = Nothing
			if (Not _CustomCSS Is Nothing) then
				newObject._CustomCSS = CType(_CustomCSS.Clone(), mstns.CustomCssBehaviour)
			End If
			newObject._CustomJavaScript = Nothing
			if (Not _CustomJavaScript Is Nothing) then
				newObject._CustomJavaScript = CType(_CustomJavaScript.Clone(), mstns.CustomJavaScriptBehaviour)
			End If
			newObject._KeyboardShortcut = Nothing
			if (Not _KeyboardShortcut Is Nothing) then
				newObject._KeyboardShortcut = CType(_KeyboardShortcut.Clone(), mstns.KeyboardShortcutBehaviour)
			End If
			newObject._Password = Nothing
			if (Not _Password Is Nothing) then
				newObject._Password = CType(_Password.Clone(), mstns.PasswordBehaviour)
			End If
			newObject._Spinner = Nothing
			if (Not _Spinner Is Nothing) then
				newObject._Spinner = CType(_Spinner.Clone(), mstns.SpinnerBehaviour)
			End If
			newObject._Tooltip = Nothing
			if (Not _Tooltip Is Nothing) then
				newObject._Tooltip = CType(_Tooltip.Clone(), mstns.TooltipBehaviour)
			End If
			newObject._Selectable = Nothing
			if (Not _Selectable Is Nothing) then
				newObject._Selectable = CType(_Selectable.Clone(), mstns.SelectableBehaviour)
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

		#Region "Attribute - MouseEvent"
		''' <summary>
		''' Represents an optional Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("MouseEvent", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.MouseInteractionBehaviour))> _
		Public Property MouseEvent() As mstns.MouseInteractionBehaviour
			Get 
				Return _MouseEvent  
			End Get
			Set(ByVal value As mstns.MouseInteractionBehaviour) 
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("MouseEvent") ' remove selection
				if (value Is Nothing) Then
					_MouseEvent = Nothing
				else
					SetElementName(value, "MouseEvent")
					_MouseEvent = value 
				End If
			End Set
		End Property
		Protected _MouseEvent As mstns.MouseInteractionBehaviour
		
		#End Region
	
		#Region "Attribute - Drag"
		''' <summary>
		''' Represents an optional Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Drag", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.DragBehaviour))> _
		Public Property Drag() As mstns.DragBehaviour
			Get 
				Return _Drag  
			End Get
			Set(ByVal value As mstns.DragBehaviour) 
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Drag") ' remove selection
				if (value Is Nothing) Then
					_Drag = Nothing
				else
					SetElementName(value, "Drag")
					_Drag = value 
				End If
			End Set
		End Property
		Protected _Drag As mstns.DragBehaviour
		
		#End Region
	
		#Region "Attribute - Resize"
		''' <summary>
		''' Represents an optional Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Resize", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.ResizeBehaviour))> _
		Public Property Resize() As mstns.ResizeBehaviour
			Get 
				Return _Resize  
			End Get
			Set(ByVal value As mstns.ResizeBehaviour) 
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Resize") ' remove selection
				if (value Is Nothing) Then
					_Resize = Nothing
				else
					SetElementName(value, "Resize")
					_Resize = value 
				End If
			End Set
		End Property
		Protected _Resize As mstns.ResizeBehaviour
		
		#End Region
	
		#Region "Attribute - Text"
		''' <summary>
		''' Represents an optional Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Text", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.TextBehaviour))> _
		Public Property Text_() As mstns.TextBehaviour
			Get 
				Return _Text  
			End Get
			Set(ByVal value As mstns.TextBehaviour) 
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Text_") ' remove selection
				if (value Is Nothing) Then
					_Text = Nothing
				else
					SetElementName(value, "Text")
					_Text = value 
				End If
			End Set
		End Property
		Protected _Text As mstns.TextBehaviour
		
		#End Region
	
		#Region "Attribute - Animate"
		''' <summary>
		''' Represents an optional Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Animate", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.AnimateBehaviour))> _
		Public Property Animate() As mstns.AnimateBehaviour
			Get 
				Return _Animate  
			End Get
			Set(ByVal value As mstns.AnimateBehaviour) 
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Animate") ' remove selection
				if (value Is Nothing) Then
					_Animate = Nothing
				else
					SetElementName(value, "Animate")
					_Animate = value 
				End If
			End Set
		End Property
		Protected _Animate As mstns.AnimateBehaviour
		
		#End Region
	
		#Region "Attribute - MousePointer"
		''' <summary>
		''' Represents an optional Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("MousePointer", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.ChangeMousePointerBehaviour))> _
		Public Property MousePointer() As mstns.ChangeMousePointerBehaviour
			Get 
				Return _MousePointer  
			End Get
			Set(ByVal value As mstns.ChangeMousePointerBehaviour) 
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("MousePointer") ' remove selection
				if (value Is Nothing) Then
					_MousePointer = Nothing
				else
					SetElementName(value, "MousePointer")
					_MousePointer = value 
				End If
			End Set
		End Property
		Protected _MousePointer As mstns.ChangeMousePointerBehaviour
		
		#End Region
	
		#Region "Attribute - FollowMouse"
		''' <summary>
		''' Represents an optional Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("FollowMouse", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.FollowMouseBehaviour))> _
		Public Property FollowMouse() As mstns.FollowMouseBehaviour
			Get 
				Return _FollowMouse  
			End Get
			Set(ByVal value As mstns.FollowMouseBehaviour) 
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("FollowMouse") ' remove selection
				if (value Is Nothing) Then
					_FollowMouse = Nothing
				else
					SetElementName(value, "FollowMouse")
					_FollowMouse = value 
				End If
			End Set
		End Property
		Protected _FollowMouse As mstns.FollowMouseBehaviour
		
		#End Region
	
		#Region "Attribute - Marquee"
		''' <summary>
		''' Represents an optional Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Marquee", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.MarqueeBehaviour))> _
		Public Property Marquee() As mstns.MarqueeBehaviour
			Get 
				Return _Marquee  
			End Get
			Set(ByVal value As mstns.MarqueeBehaviour) 
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Marquee") ' remove selection
				if (value Is Nothing) Then
					_Marquee = Nothing
				else
					SetElementName(value, "Marquee")
					_Marquee = value 
				End If
			End Set
		End Property
		Protected _Marquee As mstns.MarqueeBehaviour
		
		#End Region
	
		#Region "Attribute - CustomCSS"
		''' <summary>
		''' Represents an optional Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("CustomCSS", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.CustomCssBehaviour))> _
		Public Property CustomCSS() As mstns.CustomCssBehaviour
			Get 
				Return _CustomCSS  
			End Get
			Set(ByVal value As mstns.CustomCssBehaviour) 
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("CustomCSS") ' remove selection
				if (value Is Nothing) Then
					_CustomCSS = Nothing
				else
					SetElementName(value, "CustomCSS")
					_CustomCSS = value 
				End If
			End Set
		End Property
		Protected _CustomCSS As mstns.CustomCssBehaviour
		
		#End Region
	
		#Region "Attribute - CustomJavaScript"
		''' <summary>
		''' Represents an optional Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("CustomJavaScript", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.CustomJavaScriptBehaviour))> _
		Public Property CustomJavaScript() As mstns.CustomJavaScriptBehaviour
			Get 
				Return _CustomJavaScript  
			End Get
			Set(ByVal value As mstns.CustomJavaScriptBehaviour) 
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("CustomJavaScript") ' remove selection
				if (value Is Nothing) Then
					_CustomJavaScript = Nothing
				else
					SetElementName(value, "CustomJavaScript")
					_CustomJavaScript = value 
				End If
			End Set
		End Property
		Protected _CustomJavaScript As mstns.CustomJavaScriptBehaviour
		
		#End Region
	
		#Region "Attribute - KeyboardShortcut"
		''' <summary>
		''' Represents an optional Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("KeyboardShortcut", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.KeyboardShortcutBehaviour))> _
		Public Property KeyboardShortcut() As mstns.KeyboardShortcutBehaviour
			Get 
				Return _KeyboardShortcut  
			End Get
			Set(ByVal value As mstns.KeyboardShortcutBehaviour) 
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("KeyboardShortcut") ' remove selection
				if (value Is Nothing) Then
					_KeyboardShortcut = Nothing
				else
					SetElementName(value, "KeyboardShortcut")
					_KeyboardShortcut = value 
				End If
			End Set
		End Property
		Protected _KeyboardShortcut As mstns.KeyboardShortcutBehaviour
		
		#End Region
	
		#Region "Attribute - Password"
		''' <summary>
		''' Represents an optional Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Password", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.PasswordBehaviour))> _
		Public Property Password() As mstns.PasswordBehaviour
			Get 
				Return _Password  
			End Get
			Set(ByVal value As mstns.PasswordBehaviour) 
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Password") ' remove selection
				if (value Is Nothing) Then
					_Password = Nothing
				else
					SetElementName(value, "Password")
					_Password = value 
				End If
			End Set
		End Property
		Protected _Password As mstns.PasswordBehaviour
		
		#End Region
	
		#Region "Attribute - Spinner"
		''' <summary>
		''' Represents an optional Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Spinner", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.SpinnerBehaviour))> _
		Public Property Spinner() As mstns.SpinnerBehaviour
			Get 
				Return _Spinner  
			End Get
			Set(ByVal value As mstns.SpinnerBehaviour) 
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Spinner") ' remove selection
				if (value Is Nothing) Then
					_Spinner = Nothing
				else
					SetElementName(value, "Spinner")
					_Spinner = value 
				End If
			End Set
		End Property
		Protected _Spinner As mstns.SpinnerBehaviour
		
		#End Region
	
		#Region "Attribute - Tooltip"
		''' <summary>
		''' Represents an optional Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Tooltip", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.TooltipBehaviour))> _
		Public Property Tooltip() As mstns.TooltipBehaviour
			Get 
				Return _Tooltip  
			End Get
			Set(ByVal value As mstns.TooltipBehaviour) 
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Tooltip") ' remove selection
				if (value Is Nothing) Then
					_Tooltip = Nothing
				else
					SetElementName(value, "Tooltip")
					_Tooltip = value 
				End If
			End Set
		End Property
		Protected _Tooltip As mstns.TooltipBehaviour
		
		#End Region
	
		#Region "Attribute - Selectable"
		''' <summary>
		''' Represents an optional Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is optional, initially it is null.
		''' Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Selectable", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.SelectableBehaviour))> _
		Public Property Selectable() As mstns.SelectableBehaviour
			Get 
				Return _Selectable  
			End Get
			Set(ByVal value As mstns.SelectableBehaviour) 
				' The class represents a choice, so prevent more than one element from being selected
				If value Is Nothing Then ClearChoice("") Else ClearChoice("Selectable") ' remove selection
				if (value Is Nothing) Then
					_Selectable = Nothing
				else
					SetElementName(value, "Selectable")
					_Selectable = value 
				End If
			End Set
		End Property
		Protected _Selectable As mstns.SelectableBehaviour
		
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


