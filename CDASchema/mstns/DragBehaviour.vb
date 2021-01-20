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
	''' The Drag behaviour can be added to any Object. It will have the affect of making the object draggable. An optional "correct" drag target can be set with navigation and scoring options relating to this.
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"DragBehaviour", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class DragBehaviour
		Inherits mstns.ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for DragBehaviour
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
			_elementName = "DragBehaviour"
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
			_Direction = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Any", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_LimitToObject = ""
			_TargetObject = ""
			_IsNilTargetObject = False
			_SnapToTarget = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_SnapGridWidth = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_SnapGridHeight = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_DropType = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Mouse inside target", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_DragCursor = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("move", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_GoToPageCorrect = ""
			_IsNilGoToPageCorrect = False
			_NavigateMouseDown = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("false", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_GoToPageIncorrect = ""
			_IsNilGoToPageIncorrect = False
			_ResetOnMouseUp = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_AnimatedReset = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_ShowObjectsWhenDragOver = ""
			_IsNilShowObjectsWhenDragOver = False
			_Toggle = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
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
			Dim newObject As New mstns.DragBehaviour(_elementName)
			Dim o As Object
			newObject._Direction = _Direction
			newObject._LimitToObject = _LimitToObject
			newObject._TargetObject = _TargetObject
			newObject._IsNilTargetObject = _IsNilTargetObject
			newObject._SnapToTarget = _SnapToTarget
			newObject._SnapGridWidth = _SnapGridWidth
			newObject._SnapGridHeight = _SnapGridHeight
			newObject._DropType = _DropType
			newObject._DragCursor = _DragCursor
			newObject._GoToPageCorrect = _GoToPageCorrect
			newObject._IsNilGoToPageCorrect = _IsNilGoToPageCorrect
			newObject._NavigateMouseDown = _NavigateMouseDown
			newObject._GoToPageIncorrect = _GoToPageIncorrect
			newObject._IsNilGoToPageIncorrect = _IsNilGoToPageIncorrect
			newObject._ResetOnMouseUp = _ResetOnMouseUp
			newObject._AnimatedReset = _AnimatedReset
			newObject._ShowObjectsWhenDragOver = _ShowObjectsWhenDragOver
			newObject._IsNilShowObjectsWhenDragOver = _IsNilShowObjectsWhenDragOver
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

		#Region "Attribute - Direction"
		''' <summary>
		''' Which direction the object can be dragged in: Any, horizontal or vertical.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Any", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
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
	
		#Region "Attribute - LimitToObject"
		''' <summary>
		''' The object within the bounds of which the draggable object can be dragged.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("LimitToObject", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property LimitToObject() as String
			Get 
				Return _LimitToObject  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(1, value)
				_LimitToObject = value 
			End Set
		End Property
		Protected _LimitToObject As String

		#End Region
	
		#Region "Attribute - TargetObject"
		''' <summary>
		''' The intended destination for the draggable object. The object it should be dropped on.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("TargetObject", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilTargetObject", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property TargetObject() as String
			Get 
				Return _TargetObject  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(2, value)
				_TargetObject = value 
				_IsNilTargetObject = False
			End Set
		End Property
		Protected _TargetObject As String

		Public Property IsNilTargetObject As Boolean
			Get
				Return _IsNilTargetObject
			End Get
			Set
				_IsNilTargetObject = value
			End Set
		End Property
		Protected _IsNilTargetObject As Boolean
		#End Region
	
		#Region "Attribute - SnapToTarget"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("SnapToTarget", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property SnapToTarget() as Boolean
			Get 
				Return _SnapToTarget  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(3, value)
				_SnapToTarget = value 
			End Set
		End Property
		Protected _SnapToTarget As Boolean

		#End Region
	
		#Region "Attribute - SnapGridWidth"
		''' <summary>
		''' Width of grid cell to snap to during dragging (0 = none).
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
				CheckElementRestriction(4, value)
				_SnapGridWidth = value 
			End Set
		End Property
		Protected _SnapGridWidth As Integer

		#End Region
	
		#Region "Attribute - SnapGridHeight"
		''' <summary>
		''' Height of grid cell to snap to during dragging (0 = none).
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
				CheckElementRestriction(5, value)
				_SnapGridHeight = value 
			End Set
		End Property
		Protected _SnapGridHeight As Integer

		#End Region
	
		#Region "Attribute - DropType"
		''' <summary>
		''' How to judge whether the object has been dropped on the target correctly.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Mouse inside target", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("DropType", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property DropType() as String
			Get 
				Return _DropType  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(6, value)
				_DropType = value 
			End Set
		End Property
		Protected _DropType As String

		#End Region
	
		#Region "Attribute - DragCursor"
		''' <summary>
		''' The cursor to display whilst dragging.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("move", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("DragCursor", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property DragCursor() as String
			Get 
				Return _DragCursor  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(7, value)
				_DragCursor = value 
			End Set
		End Property
		Protected _DragCursor As String

		#End Region
	
		#Region "Attribute - GoToPageCorrect"
		''' <summary>
		''' Which page to go to when dropped correctly.
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
				CheckElementRestriction(8, value)
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
	
		#Region "Attribute - NavigateMouseDown"
		''' <summary>
		''' Navigate to above as soon as mouse enters.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("false", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("NavigateMouseDown", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property NavigateMouseDown() as Boolean
			Get 
				Return _NavigateMouseDown  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(9, value)
				_NavigateMouseDown = value 
			End Set
		End Property
		Protected _NavigateMouseDown As Boolean

		#End Region
	
		#Region "Attribute - GoToPageIncorrect"
		''' <summary>
		''' Which page to go to when dropped incorrectly.
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
				CheckElementRestriction(10, value)
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
	
		#Region "Attribute - ResetOnMouseUp"
		''' <summary>
		''' If True, object returned to start position when released.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("ResetOnMouseUp", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property ResetOnMouseUp() as Boolean
			Get 
				Return _ResetOnMouseUp  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(11, value)
				_ResetOnMouseUp = value 
			End Set
		End Property
		Protected _ResetOnMouseUp As Boolean

		#End Region
	
		#Region "Attribute - AnimatedReset"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("AnimatedReset", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property AnimatedReset() as Boolean
			Get 
				Return _AnimatedReset  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(12, value)
				_AnimatedReset = value 
			End Set
		End Property
		Protected _AnimatedReset As Boolean

		#End Region
	
		#Region "Attribute - ShowObjectsWhenDragOver"
		''' <summary>
		''' Objects to show when this object is dragged over them.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("ShowObjectsWhenDragOver", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilShowObjectsWhenDragOver", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property ShowObjectsWhenDragOver() as String
			Get 
				Return _ShowObjectsWhenDragOver  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(13, value)
				_ShowObjectsWhenDragOver = value 
				_IsNilShowObjectsWhenDragOver = False
			End Set
		End Property
		Protected _ShowObjectsWhenDragOver As String

		Public Property IsNilShowObjectsWhenDragOver As Boolean
			Get
				Return _IsNilShowObjectsWhenDragOver
			End Get
			Set
				_IsNilShowObjectsWhenDragOver = value
			End Set
		End Property
		Protected _IsNilShowObjectsWhenDragOver As Boolean
		#End Region
	
		#Region "Attribute - Toggle"
		''' <summary>
		''' Whether the above ShowObjectsWhenDragOver is toggled on mouse leaving objects.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("Toggle", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property Toggle() as Boolean
			Get 
				Return _Toggle  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(14, value)
				_Toggle = value 
			End Set
		End Property
		Protected _Toggle As Boolean

		#End Region
	
		#Region "Attribute - AssessmentCorrect"
		''' <summary>
		''' If dragged to correct target, score assessment activity correct.
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
				CheckElementRestriction(15, value)
				_AssessmentCorrect = value 
			End Set
		End Property
		Protected _AssessmentCorrect As Boolean

		#End Region
	
		#Region "Attribute - AssessmentIncorrect"
		''' <summary>
		''' If dragged to incorrect target, score assessment activity incorrect.
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
				CheckElementRestriction(16, value)
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


