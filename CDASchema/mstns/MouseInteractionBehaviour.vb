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
	''' The Click behaviour can be added to any Object. The click behaviour can be used to interpret left, right and double click events. These can then be used to trigger navigation, changes to the state of other objects and judgement of assessment interactions.
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"MouseInteractionBehaviour", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class MouseInteractionBehaviour
		Inherits mstns.ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for MouseInteractionBehaviour
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
			_elementName = "MouseInteractionBehaviour"
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
			_MouseEvent = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("LeftMouseUp", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_GoToPage = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Next", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_IsNilGoToPage = False
			_JudgeTask = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_ShowObjects = ""
			_IsNilShowObjects = False
			_PreventMouseDownFocus = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_HideObjects = ""
			_IsNilHideObjects = False
			_AnimateObjects = ""
			_IsNilAnimateObjects = False
			_Toggle = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
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
			Dim newObject As New mstns.MouseInteractionBehaviour(_elementName)
			Dim o As Object
			newObject._MouseEvent = _MouseEvent
			newObject._GoToPage = _GoToPage
			newObject._IsNilGoToPage = _IsNilGoToPage
			newObject._JudgeTask = _JudgeTask
			newObject._ShowObjects = _ShowObjects
			newObject._IsNilShowObjects = _IsNilShowObjects
			newObject._PreventMouseDownFocus = _PreventMouseDownFocus
			newObject._HideObjects = _HideObjects
			newObject._IsNilHideObjects = _IsNilHideObjects
			newObject._AnimateObjects = _AnimateObjects
			newObject._IsNilAnimateObjects = _IsNilAnimateObjects
			newObject._Toggle = _Toggle
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

		#Region "Attribute - MouseEvent"
		''' <summary>
		''' Which type of mouse click to detect.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("LeftMouseUp", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("MouseEvent", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property MouseEvent() as String
			Get 
				Return _MouseEvent  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(0, value)
				_MouseEvent = value 
			End Set
		End Property
		Protected _MouseEvent As String

		#End Region
	
		#Region "Attribute - GoToPage"
		''' <summary>
		''' Which page to go to when the mouse click type specified is detected on the object.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Next", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("GoToPage", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilGoToPage", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property GoToPage() as String
			Get 
				Return _GoToPage  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(1, value)
				_GoToPage = value 
				_IsNilGoToPage = False
			End Set
		End Property
		Protected _GoToPage As String

		Public Property IsNilGoToPage As Boolean
			Get
				Return _IsNilGoToPage
			End Get
			Set
				_IsNilGoToPage = value
			End Set
		End Property
		Protected _IsNilGoToPage As Boolean
		#End Region
	
		#Region "Attribute - JudgeTask"
		''' <summary>
		''' Check the status of any interaction that is judged on the current page when a click is detected.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("JudgeTask", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property JudgeTask() as Boolean
			Get 
				Return _JudgeTask  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(2, value)
				_JudgeTask = value 
			End Set
		End Property
		Protected _JudgeTask As Boolean

		#End Region
	
		#Region "Attribute - ShowObjects"
		''' <summary>
		''' Objects to show when a click of the type specified is detected on this object.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("ShowObjects", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilShowObjects", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property ShowObjects() as String
			Get 
				Return _ShowObjects  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(3, value)
				_ShowObjects = value 
				_IsNilShowObjects = False
			End Set
		End Property
		Protected _ShowObjects As String

		Public Property IsNilShowObjects As Boolean
			Get
				Return _IsNilShowObjects
			End Get
			Set
				_IsNilShowObjects = value
			End Set
		End Property
		Protected _IsNilShowObjects As Boolean
		#End Region
	
		#Region "Attribute - PreventMouseDownFocus"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("PreventMouseDownFocus", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property PreventMouseDownFocus() as Boolean
			Get 
				Return _PreventMouseDownFocus  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(4, value)
				_PreventMouseDownFocus = value 
			End Set
		End Property
		Protected _PreventMouseDownFocus As Boolean

		#End Region
	
		#Region "Attribute - HideObjects"
		''' <summary>
		''' Objects to hide when a click of the type specified is detected on this object.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("HideObjects", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilHideObjects", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property HideObjects() as String
			Get 
				Return _HideObjects  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(5, value)
				_HideObjects = value 
				_IsNilHideObjects = False
			End Set
		End Property
		Protected _HideObjects As String

		Public Property IsNilHideObjects As Boolean
			Get
				Return _IsNilHideObjects
			End Get
			Set
				_IsNilHideObjects = value
			End Set
		End Property
		Protected _IsNilHideObjects As Boolean
		#End Region
	
		#Region "Attribute - AnimateObjects"
		''' <summary>
		''' Objects to animate when a click of the type specified is detected on this object. These objects need an animate behaviour with AutoStart = False.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("AnimateObjects", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilAnimateObjects", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property AnimateObjects() as String
			Get 
				Return _AnimateObjects  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(6, value)
				_AnimateObjects = value 
				_IsNilAnimateObjects = False
			End Set
		End Property
		Protected _AnimateObjects As String

		Public Property IsNilAnimateObjects As Boolean
			Get
				Return _IsNilAnimateObjects
			End Get
			Set
				_IsNilAnimateObjects = value
			End Set
		End Property
		Protected _IsNilAnimateObjects As Boolean
		#End Region
	
		#Region "Attribute - Toggle"
		''' <summary>
		''' If toggle is "true", showing, hiding and animating objects will be toggled (a shown object will be hidden, an animation will be stopped, a hidden object will be shown etc).
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("Toggle", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property Toggle() as Boolean
			Get 
				Return _Toggle  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(7, value)
				_Toggle = value 
			End Set
		End Property
		Protected _Toggle As Boolean

		#End Region
	
		#Region "Attribute - AssessmentCorrect"
		''' <summary>
		''' If specified click type is detected on object, score the assessment task correct.
		'''                         Assessment only.
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
				CheckElementRestriction(8, value)
				_AssessmentCorrect = value 
			End Set
		End Property
		Protected _AssessmentCorrect As Boolean

		#End Region
	
		#Region "Attribute - AssessmentIncorrect"
		''' <summary>
		''' If specified click type is detected on object, score the assessment task incorrect.
		'''                         Assessment only.
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
				CheckElementRestriction(9, value)
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


