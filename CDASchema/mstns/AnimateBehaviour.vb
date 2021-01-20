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
	''' The Animate behaviour can be added to any Object. It will add an interactive text area to the object. Optionally, the default and required text (or length or selection) can be set An optional "correct". Navigation and scoring options can be set relating to this.
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"AnimateBehaviour", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class AnimateBehaviour
		Inherits mstns.ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for AnimateBehaviour
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
			_elementName = "AnimateBehaviour"
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
			_StartHPos = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_StartVPos = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_EndHPos = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_EndVPos = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_StartOpacity = LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_EndOpacity = LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_LoopCount = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_AnimationDuration = LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("3", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_AnimationDelay = LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_AutoStart = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_GoToPageOnFinish = ""
			_IsNilGoToPageOnFinish = False



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
			Dim newObject As New mstns.AnimateBehaviour(_elementName)
			Dim o As Object
			newObject._StartHPos = _StartHPos
			newObject._StartVPos = _StartVPos
			newObject._EndHPos = _EndHPos
			newObject._EndVPos = _EndVPos
			newObject._StartOpacity = _StartOpacity
			newObject._EndOpacity = _EndOpacity
			newObject._LoopCount = _LoopCount
			newObject._AnimationDuration = _AnimationDuration
			newObject._AnimationDelay = _AnimationDelay
			newObject._AutoStart = _AutoStart
			newObject._GoToPageOnFinish = _GoToPageOnFinish
			newObject._IsNilGoToPageOnFinish = _IsNilGoToPageOnFinish

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

		#Region "Attribute - StartHPos"
		''' <summary>
		''' The starting horizontal pixel location, relative to the page.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("StartHPos", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property StartHPos() as Integer
			Get 
				Return _StartHPos  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(0, value)
				_StartHPos = value 
			End Set
		End Property
		Protected _StartHPos As Integer

		#End Region
	
		#Region "Attribute - StartVPos"
		''' <summary>
		''' The starting vertical pixel location, relative to the page.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("StartVPos", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property StartVPos() as Integer
			Get 
				Return _StartVPos  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(1, value)
				_StartVPos = value 
			End Set
		End Property
		Protected _StartVPos As Integer

		#End Region
	
		#Region "Attribute - EndHPos"
		''' <summary>
		''' The ending horizontal pixel location, relative to the page.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("EndHPos", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property EndHPos() as Integer
			Get 
				Return _EndHPos  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(2, value)
				_EndHPos = value 
			End Set
		End Property
		Protected _EndHPos As Integer

		#End Region
	
		#Region "Attribute - EndVPos"
		''' <summary>
		''' The ending vertical pixel location, relative to the page.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("EndVPos", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property EndVPos() as Integer
			Get 
				Return _EndVPos  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(3, value)
				_EndVPos = value 
			End Set
		End Property
		Protected _EndVPos As Integer

		#End Region
	
		#Region "Attribute - StartOpacity"
		''' <summary>
		''' The starting opacity value. 0 = transparent, 1 = opaque.
		'''                         Tip: Can be used with a differing EndOpacity to fade an object in or out.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("StartOpacity", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property StartOpacity() as Decimal
			Get 
				Return _StartOpacity  
			End Get
			Set(ByVal value As Decimal) 
				CheckElementRestriction(4, value)
				_StartOpacity = value 
			End Set
		End Property
		Protected _StartOpacity As Decimal

		#End Region
	
		#Region "Attribute - EndOpacity"
		''' <summary>
		''' The opacity value at the end of the animation. 0 = transparent, 1 = opaque.
		'''                         Tip: Can be used with a differing StartOpacity to fade an object in or out.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("EndOpacity", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property EndOpacity() as Decimal
			Get 
				Return _EndOpacity  
			End Get
			Set(ByVal value As Decimal) 
				CheckElementRestriction(5, value)
				_EndOpacity = value 
			End Set
		End Property
		Protected _EndOpacity As Decimal

		#End Region
	
		#Region "Attribute - LoopCount"
		''' <summary>
		''' Number of loops. 0 = none, -1 = infinite.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("LoopCount", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property LoopCount() as Integer
			Get 
				Return _LoopCount  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(6, value)
				_LoopCount = value 
			End Set
		End Property
		Protected _LoopCount As Integer

		#End Region
	
		#Region "Attribute - AnimationDuration"
		''' <summary>
		''' Number of seconds for one loop of the animation.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("3", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("AnimationDuration", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property AnimationDuration() as Decimal
			Get 
				Return _AnimationDuration  
			End Get
			Set(ByVal value As Decimal) 
				CheckElementRestriction(7, value)
				_AnimationDuration = value 
			End Set
		End Property
		Protected _AnimationDuration As Decimal

		#End Region
	
		#Region "Attribute - AnimationDelay"
		''' <summary>
		''' Number of seconds delay before animation starts.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("AnimationDelay", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property AnimationDelay() as Decimal
			Get 
				Return _AnimationDelay  
			End Get
			Set(ByVal value As Decimal) 
				CheckElementRestriction(8, value)
				_AnimationDelay = value 
			End Set
		End Property
		Protected _AnimationDelay As Decimal

		#End Region
	
		#Region "Attribute - AutoStart"
		''' <summary>
		''' Whether the animation starts automatically or when something is clicked.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("AutoStart", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property AutoStart() as Boolean
			Get 
				Return _AutoStart  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(9, value)
				_AutoStart = value 
			End Set
		End Property
		Protected _AutoStart As Boolean

		#End Region
	
		#Region "Attribute - GoToPageOnFinish"
		''' <summary>
		''' Which page to go to when the animation is complete.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("GoToPageOnFinish", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilGoToPageOnFinish", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property GoToPageOnFinish() as String
			Get 
				Return _GoToPageOnFinish  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(10, value)
				_GoToPageOnFinish = value 
				_IsNilGoToPageOnFinish = False
			End Set
		End Property
		Protected _GoToPageOnFinish As String

		Public Property IsNilGoToPageOnFinish As Boolean
			Get
				Return _IsNilGoToPageOnFinish
			End Get
			Set
				_IsNilGoToPageOnFinish = value
			End Set
		End Property
		Protected _IsNilGoToPageOnFinish As Boolean
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


