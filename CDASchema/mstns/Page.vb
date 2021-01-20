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
	''' This class represents the ComplexType Page
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"Page", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class Page
		Inherits mstns.ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for Page
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
			_elementName = "Page"
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
			_PageName = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Page 1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_PageType = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Explain", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_InstructionText = ""
			_IsNilInstructionText = False
			_InteractionText = ""
			_IsNilInteractionText = False
			_InstructionWidth = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("220", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_IsNilInstructionWidth = False
			_BackgroundImage = ""
			_IsNilBackgroundImage = False
			_ScoreTutorialID = 0
			_IsNilScoreTutorialID = False
			_PassNextPage = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Next", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_JudgeCorrectNextPage = ""
			_JudgeInCorrectNextPage = ""
			_ScoredInteraction = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_ScoredInteractionIncorrect = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_InstructionHPos = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("402", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_InstructionVPos = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("274", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_IncludeNext = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_QuizQuestion = new mstns.QuizQuestion("QuizQuestion")
			_ObjectCol = new mstns.ITSPCDALib.XmlObjectCollection(Of mstns.Object_)("Object", "https://www.itskill.nhs.uk/CDAFile.xsd", 0, -1, false)



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
			Dim newObject As New mstns.Page(_elementName)
			Dim o As Object
			newObject._PageName = _PageName
			newObject._PageType = _PageType
			newObject._InstructionText = _InstructionText
			newObject._IsNilInstructionText = _IsNilInstructionText
			newObject._InteractionText = _InteractionText
			newObject._IsNilInteractionText = _IsNilInteractionText
			newObject._InstructionWidth = _InstructionWidth
			newObject._IsNilInstructionWidth = _IsNilInstructionWidth
			newObject._BackgroundImage = _BackgroundImage
			newObject._IsNilBackgroundImage = _IsNilBackgroundImage
			newObject._ScoreTutorialID = _ScoreTutorialID
			newObject._IsNilScoreTutorialID = _IsNilScoreTutorialID
			newObject._PassNextPage = _PassNextPage
			newObject._JudgeCorrectNextPage = _JudgeCorrectNextPage
			newObject._JudgeInCorrectNextPage = _JudgeInCorrectNextPage
			newObject._ScoredInteraction = _ScoredInteraction
			newObject._ScoredInteractionIncorrect = _ScoredInteractionIncorrect
			newObject._InstructionHPos = _InstructionHPos
			newObject._InstructionVPos = _InstructionVPos
			newObject._IncludeNext = _IncludeNext
			newObject._QuizQuestion = Nothing
			if (Not _QuizQuestion Is Nothing) Then
				newObject._QuizQuestion = CType(_QuizQuestion.Clone(), mstns.QuizQuestion)
			End If
			For Each o in _ObjectCol
				newObject._ObjectCol.Add(CType(CType(o, mstns.Object_).Clone(), mstns.Object_))
			Next o

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

		#Region "Attribute - PageName"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Page 1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("PageName", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property PageName() as String
			Get 
				Return _PageName  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(0, value)
				_PageName = value 
			End Set
		End Property
		Protected _PageName As String

		#End Region
	
		#Region "Attribute - PageType"
		''' <summary>
		''' Valid choices: Explain, Guide, Demo, Practice, Test
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Explain", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("PageType", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property PageType() as String
			Get 
				Return _PageType  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(1, value)
				_PageType = value 
			End Set
		End Property
		Protected _PageType As String

		#End Region
	
		#Region "Attribute - InstructionText"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("InstructionText", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilInstructionText", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property InstructionText() as String
			Get 
				Return _InstructionText  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(2, value)
				_InstructionText = value 
				_IsNilInstructionText = False
			End Set
		End Property
		Protected _InstructionText As String

		Public Property IsNilInstructionText As Boolean
			Get
				Return _IsNilInstructionText
			End Get
			Set
				_IsNilInstructionText = value
			End Set
		End Property
		Protected _IsNilInstructionText As Boolean
		#End Region
	
		#Region "Attribute - InteractionText"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("InteractionText", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilInteractionText", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property InteractionText() as String
			Get 
				Return _InteractionText  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(3, value)
				_InteractionText = value 
				_IsNilInteractionText = False
			End Set
		End Property
		Protected _InteractionText As String

		Public Property IsNilInteractionText As Boolean
			Get
				Return _IsNilInteractionText
			End Get
			Set
				_IsNilInteractionText = value
			End Set
		End Property
		Protected _IsNilInteractionText As Boolean
		#End Region
	
		#Region "Attribute - InstructionWidth"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("220", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("InstructionWidth", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilInstructionWidth", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property InstructionWidth() as Integer
			Get 
				Return _InstructionWidth  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(4, value)
				_InstructionWidth = value 
				_IsNilInstructionWidth = False
			End Set
		End Property
		Protected _InstructionWidth As Integer

		Public Property IsNilInstructionWidth As Boolean
			Get
				Return _IsNilInstructionWidth
			End Get
			Set
				_IsNilInstructionWidth = value
			End Set
		End Property
		Protected _IsNilInstructionWidth As Boolean
		#End Region
	
		#Region "Attribute - BackgroundImage"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("BackgroundImage", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilBackgroundImage", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property BackgroundImage() as String
			Get 
				Return _BackgroundImage  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value) 
				CheckElementRestriction(5, value)
				_BackgroundImage = value 
				_IsNilBackgroundImage = False
			End Set
		End Property
		Protected _BackgroundImage As String

		Public Property IsNilBackgroundImage As Boolean
			Get
				Return _IsNilBackgroundImage
			End Get
			Set
				_IsNilBackgroundImage = value
			End Set
		End Property
		Protected _IsNilBackgroundImage As Boolean
		#End Region
	
		#Region "Attribute - ScoreTutorialID"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to 0.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("ScoreTutorialID", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilScoreTutorialID", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property ScoreTutorialID() as Integer
			Get 
				Return _ScoreTutorialID  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(6, value)
				_ScoreTutorialID = value 
				_IsNilScoreTutorialID = False
			End Set
		End Property
		Protected _ScoreTutorialID As Integer

		Public Property IsNilScoreTutorialID As Boolean
			Get
				Return _IsNilScoreTutorialID
			End Get
			Set
				_IsNilScoreTutorialID = value
			End Set
		End Property
		Protected _IsNilScoreTutorialID As Boolean
		#End Region
	
		#Region "Attribute - PassNextPage"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("Next", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("PassNextPage", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property PassNextPage() as String
			Get 
				Return _PassNextPage  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(7, value)
				_PassNextPage = value 
			End Set
		End Property
		Protected _PassNextPage As String

		#End Region
	
		#Region "Attribute - JudgeCorrectNextPage"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("JudgeCorrectNextPage", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property JudgeCorrectNextPage() as String
			Get 
				Return _JudgeCorrectNextPage  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(8, value)
				_JudgeCorrectNextPage = value 
			End Set
		End Property
		Protected _JudgeCorrectNextPage As String

		#End Region
	
		#Region "Attribute - JudgeInCorrectNextPage"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("JudgeInCorrectNextPage", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property JudgeInCorrectNextPage() as String
			Get 
				Return _JudgeInCorrectNextPage  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(9, value)
				_JudgeInCorrectNextPage = value 
			End Set
		End Property
		Protected _JudgeInCorrectNextPage As String

		#End Region
	
		#Region "Attribute - ScoredInteraction"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("ScoredInteraction", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property ScoredInteraction() as Boolean
			Get 
				Return _ScoredInteraction  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(10, value)
				_ScoredInteraction = value 
			End Set
		End Property
		Protected _ScoredInteraction As Boolean

		#End Region
	
		#Region "Attribute - ScoredInteractionIncorrect"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("ScoredInteractionIncorrect", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property ScoredInteractionIncorrect() as Boolean
			Get 
				Return _ScoredInteractionIncorrect  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(11, value)
				_ScoredInteractionIncorrect = value 
			End Set
		End Property
		Protected _ScoredInteractionIncorrect As Boolean

		#End Region
	
		#Region "Attribute - InstructionHPos"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("402", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("InstructionHPos", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "0", "2048", "", "", "-1", "-1", "-1")> _
		Public Property InstructionHPos() as Integer
			Get 
				Return _InstructionHPos  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(12, value)
				_InstructionHPos = value 
			End Set
		End Property
		Protected _InstructionHPos As Integer

		#End Region
	
		#Region "Attribute - InstructionVPos"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("274", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("InstructionVPos", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "0", "1440", "", "", "-1", "-1", "-1")> _
		Public Property InstructionVPos() as Integer
			Get 
				Return _InstructionVPos  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(13, value)
				_InstructionVPos = value 
			End Set
		End Property
		Protected _InstructionVPos As Integer

		#End Region
	
		#Region "Attribute - IncludeNext"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("IncludeNext", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property IncludeNext() as Boolean
			Get 
				Return _IncludeNext  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(14, value)
				_IncludeNext = value 
			End Set
		End Property
		Protected _IncludeNext As Boolean

		#End Region
	
		#Region "Attribute - QuizQuestion"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' If this property is set, then the object will be COPIED. If the property is set to null an exception is raised.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("QuizQuestion", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, GetType(mstns.QuizQuestion), true)> _
		Public Property QuizQuestion() As mstns.QuizQuestion
			Get 
				Return _QuizQuestion  
			End Get
			Set(ByVal value As mstns.QuizQuestion)  
				Throw_IfPropertyIsNull(value, "QuizQuestion")
				if (Not value Is Nothing) Then
					SetElementName(value, "QuizQuestion")
				End If
				_QuizQuestion = value 
			End Set
		End Property
		Protected _QuizQuestion As mstns.QuizQuestion
		
		#End Region
	
		#Region "Attribute - Object"
		''' <summary>
		''' A collection of ObjectCols
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' This collection may contain 0 to Many objects.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("Object", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)> _
		Public Readonly Property ObjectCol() As mstns.ITSPCDALib.XmlObjectCollection(Of mstns.Object_)
			Get 
				Return _ObjectCol 
			End Get
		End Property
		Protected _ObjectCol As mstns.ITSPCDALib.XmlObjectCollection(Of mstns.Object_)
		
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


