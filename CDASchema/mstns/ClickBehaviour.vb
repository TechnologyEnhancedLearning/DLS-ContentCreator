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
'* Using Schema: W:\NHS CfH ICT Contract\2015-2017 Work\Content Management and Development\CDA\ITSPCDA.xsd
'**********************************************************************************************

Namespace mstns

	''' <summary>
	''' The Click behaviour can be added to any Object. The click behaviour can be used to interpret left, right and double click events. These can then be used to trigger navigation, changes to the state of other objects and judgement of assessment interactions.
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"ClickBehaviour", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class ClickBehaviour
		Inherits ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for ClickBehaviour
		''' </summary>
		''' <remarks>
		'''	The class is created with all the mandatory fields populated with the
		'''	default data. 
		'''	All Collection object are created.
		'''	However any 1-n relationships (these are represented as collections) are
		'''	empty. To comply with the schema these must be populated before the xml
		'''	obtained from ToXml is valid against the schema W:\NHS CfH ICT Contract\2015-2017 Work\Content Management and Development\CDA\ITSPCDA.xsd
		''' </remarks>
		Public Sub New()
			_elementName = "ClickBehaviour"
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
		'''	obtained from ToXml is valid against the schema W:\NHS CfH ICT Contract\2015-2017 Work\Content Management and Development\CDA\ITSPCDA.xsd.
		''' </remarks>
		Protected Overrides Sub Init()
			ITSPCDALib.Registration.iRegistrationIndicator = 0 ' causes registration to take place
			_ClickType = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Left", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_GoToPage = ""
			_IsNilGoToPage = False
			_JudgeTask = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_ShowObjects = new mstns.ShowObjectsWhenDragOver_Nillable("ShowObjects")
			_HideObjects = new mstns.ShowObjectsWhenDragOver_Nillable("HideObjects")
			_AnimateObjects = new mstns.ShowObjectsWhenDragOver_Nillable("AnimateObjects")
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
			Dim newObject As New mstns.ClickBehaviour(_elementName)
			Dim o As Object
			newObject._ClickType = _ClickType
			newObject._GoToPage = _GoToPage
			newObject._IsNilGoToPage = _IsNilGoToPage
			newObject._JudgeTask = _JudgeTask
			newObject._ShowObjects = Nothing
			if (Not _ShowObjects Is Nothing) Then
				newObject._ShowObjects = CType(_ShowObjects.Clone(), mstns.ShowObjectsWhenDragOver_Nillable)
			End If
			newObject._HideObjects = Nothing
			if (Not _HideObjects Is Nothing) Then
				newObject._HideObjects = CType(_HideObjects.Clone(), mstns.ShowObjectsWhenDragOver_Nillable)
			End If
			newObject._AnimateObjects = Nothing
			if (Not _AnimateObjects Is Nothing) Then
				newObject._AnimateObjects = CType(_AnimateObjects.Clone(), mstns.ShowObjectsWhenDragOver_Nillable)
			End If
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

		#Region "Attribute - ClickType"
		''' <summary>
		''' Which type of mouse click to detect.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Left", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("ClickType", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property ClickType() as String
			Get 
				Return _ClickType  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(0, value)
				_ClickType = value 
			End Set
		End Property
		Protected _ClickType As String

		#End Region
	
		#Region "Attribute - GoToPage"
		''' <summary>
		''' Which page to go to when the mouse click type specified is detected on the object.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
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
		''' If this property is set, then the object will be COPIED. If the property is set to null an exception is raised.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("ShowObjects", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.ShowObjectsWhenDragOver_Nillable), true)> _
		Public Property ShowObjects() As mstns.ShowObjectsWhenDragOver_Nillable
			Get 
				Return _ShowObjects  
			End Get
			Set(ByVal value As mstns.ShowObjectsWhenDragOver_Nillable)  
				Throw_IfPropertyIsNull(value, "ShowObjects")
				if (Not value Is Nothing) Then
					SetElementName(value, "ShowObjects")
				End If
				_ShowObjects = value 
			End Set
		End Property
		Protected _ShowObjects As mstns.ShowObjectsWhenDragOver_Nillable
		
		#End Region
	
		#Region "Attribute - HideObjects"
		''' <summary>
		''' Objects to hide when a click of the type specified is detected on this object.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' If this property is set, then the object will be COPIED. If the property is set to null an exception is raised.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("HideObjects", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.ShowObjectsWhenDragOver_Nillable), true)> _
		Public Property HideObjects() As mstns.ShowObjectsWhenDragOver_Nillable
			Get 
				Return _HideObjects  
			End Get
			Set(ByVal value As mstns.ShowObjectsWhenDragOver_Nillable)  
				Throw_IfPropertyIsNull(value, "HideObjects")
				if (Not value Is Nothing) Then
					SetElementName(value, "HideObjects")
				End If
				_HideObjects = value 
			End Set
		End Property
		Protected _HideObjects As mstns.ShowObjectsWhenDragOver_Nillable
		
		#End Region
	
		#Region "Attribute - AnimateObjects"
		''' <summary>
		''' Objects to animate when a click of the type specified is detected on this object. These objects need an animate behaviour with AutoStart = False.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' If this property is set, then the object will be COPIED. If the property is set to null an exception is raised.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("AnimateObjects", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.ShowObjectsWhenDragOver_Nillable), true)> _
		Public Property AnimateObjects() As mstns.ShowObjectsWhenDragOver_Nillable
			Get 
				Return _AnimateObjects  
			End Get
			Set(ByVal value As mstns.ShowObjectsWhenDragOver_Nillable)  
				Throw_IfPropertyIsNull(value, "AnimateObjects")
				if (Not value Is Nothing) Then
					SetElementName(value, "AnimateObjects")
				End If
				_AnimateObjects = value 
			End Set
		End Property
		Protected _AnimateObjects As mstns.ShowObjectsWhenDragOver_Nillable
		
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
				CheckElementRestriction(6, value)
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
				CheckElementRestriction(7, value)
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
				CheckElementRestriction(8, value)
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


