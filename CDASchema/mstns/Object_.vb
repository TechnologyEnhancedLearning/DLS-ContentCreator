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
	''' This class represents the ComplexType Object
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"Object", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class Object_
		Inherits mstns.ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for Object_
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
			_elementName = "Object"
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
			_ObjectName = ""
			_HPos = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_VPos = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_Width = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("120", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_Height = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("120", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_BorderStyle = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("none", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_BorderWidth = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_BorderColour = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("#000000", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_BorderOpacity = LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_BackGroundColour = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("#FFFFFF", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_BackGroundOpacity = LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_Radius = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_StandardImage = ""
			_IsNilStandardImage = False
			_UseMouseEnterImage = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_MouseEnterImage = ""
			_IsNilMouseEnterImage = False
			_UseMouseDownImage = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_MouseDownImage = ""
			_IsNilMouseDownImage = False
			_UseMouseUpImage = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_MouseUpImage = ""
			_IsNilMouseUpImage = False
			_StartVisible = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_StartOpaque = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_VideoFile = ""
			_IsNilVideoFile = False
			_VideoAutoplay = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_VideoFinishGoToPage = ""
			_IsNilVideoFinishGoToPage = False
			_BehaviourCol = new mstns.ITSPCDALib.XmlObjectCollection(Of mstns.Behaviours)("Behaviour", "https://www.itskill.nhs.uk/CDAFile.xsd", 0, -1, false)
			_Rotation = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_EditorVisible = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)



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
			Dim newObject As New mstns.Object_(_elementName)
			Dim o As Object
			newObject._ObjectName = _ObjectName
			newObject._HPos = _HPos
			newObject._VPos = _VPos
			newObject._Width = _Width
			newObject._Height = _Height
			newObject._BorderStyle = _BorderStyle
			newObject._BorderWidth = _BorderWidth
			newObject._BorderColour = _BorderColour
			newObject._BorderOpacity = _BorderOpacity
			newObject._BackGroundColour = _BackGroundColour
			newObject._BackGroundOpacity = _BackGroundOpacity
			newObject._Radius = _Radius
			newObject._StandardImage = _StandardImage
			newObject._IsNilStandardImage = _IsNilStandardImage
			newObject._UseMouseEnterImage = _UseMouseEnterImage
			newObject._MouseEnterImage = _MouseEnterImage
			newObject._IsNilMouseEnterImage = _IsNilMouseEnterImage
			newObject._UseMouseDownImage = _UseMouseDownImage
			newObject._MouseDownImage = _MouseDownImage
			newObject._IsNilMouseDownImage = _IsNilMouseDownImage
			newObject._UseMouseUpImage = _UseMouseUpImage
			newObject._MouseUpImage = _MouseUpImage
			newObject._IsNilMouseUpImage = _IsNilMouseUpImage
			newObject._StartVisible = _StartVisible
			newObject._StartOpaque = _StartOpaque
			newObject._VideoFile = _VideoFile
			newObject._IsNilVideoFile = _IsNilVideoFile
			newObject._VideoAutoplay = _VideoAutoplay
			newObject._VideoFinishGoToPage = _VideoFinishGoToPage
			newObject._IsNilVideoFinishGoToPage = _IsNilVideoFinishGoToPage
			For Each o in _BehaviourCol
				newObject._BehaviourCol.Add(CType(CType(o, mstns.Behaviours).Clone(), mstns.Behaviours))
			Next o
			newObject._Rotation = _Rotation
			newObject._EditorVisible = _EditorVisible

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

		#Region "Attribute - ObjectName"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("ObjectName", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property ObjectName() as String
			Get 
				Return _ObjectName  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(0, value)
				_ObjectName = value 
			End Set
		End Property
		Protected _ObjectName As String

		#End Region
	
		#Region "Attribute - hPos"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("hPos", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property HPos() as Integer
			Get 
				Return _HPos  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(1, value)
				_HPos = value 
			End Set
		End Property
		Protected _HPos As Integer

		#End Region
	
		#Region "Attribute - vPos"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("vPos", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property VPos() as Integer
			Get 
				Return _VPos  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(2, value)
				_VPos = value 
			End Set
		End Property
		Protected _VPos As Integer

		#End Region
	
		#Region "Attribute - Width"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("120", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("Width", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property Width() as Integer
			Get 
				Return _Width  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(3, value)
				_Width = value 
			End Set
		End Property
		Protected _Width As Integer

		#End Region
	
		#Region "Attribute - Height"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("120", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("Height", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property Height() as Integer
			Get 
				Return _Height  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(4, value)
				_Height = value 
			End Set
		End Property
		Protected _Height As Integer

		#End Region
	
		#Region "Attribute - BorderStyle"
		''' <summary>
		''' Valid choices: none, dotted, dashed, solid, groove, ridge, inset, outset
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("none", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("BorderStyle", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property BorderStyle() as String
			Get 
				Return _BorderStyle  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(5, value)
				_BorderStyle = value 
			End Set
		End Property
		Protected _BorderStyle As String

		#End Region
	
		#Region "Attribute - BorderWidth"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("BorderWidth", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property BorderWidth() as Integer
			Get 
				Return _BorderWidth  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(6, value)
				_BorderWidth = value 
			End Set
		End Property
		Protected _BorderWidth As Integer

		#End Region
	
		#Region "Attribute - BorderColour"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("#000000", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("BorderColour", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property BorderColour() as String
			Get 
				Return _BorderColour  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(7, value)
				_BorderColour = value 
			End Set
		End Property
		Protected _BorderColour As String

		#End Region
	
		#Region "Attribute - BorderOpacity"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("BorderOpacity", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property BorderOpacity() as Decimal
			Get 
				Return _BorderOpacity  
			End Get
			Set(ByVal value As Decimal) 
				CheckElementRestriction(8, value)
				_BorderOpacity = value 
			End Set
		End Property
		Protected _BorderOpacity As Decimal

		#End Region
	
		#Region "Attribute - BackGroundColour"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("#FFFFFF", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("BackGroundColour", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property BackGroundColour() as String
			Get 
				Return _BackGroundColour  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(9, value)
				_BackGroundColour = value 
			End Set
		End Property
		Protected _BackGroundColour As String

		#End Region
	
		#Region "Attribute - BackGroundOpacity"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.decimalFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("BackGroundOpacity", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property BackGroundOpacity() as Decimal
			Get 
				Return _BackGroundOpacity  
			End Get
			Set(ByVal value As Decimal) 
				CheckElementRestriction(10, value)
				_BackGroundOpacity = value 
			End Set
		End Property
		Protected _BackGroundOpacity As Decimal

		#End Region
	
		#Region "Attribute - Radius"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("Radius", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property Radius() as Integer
			Get 
				Return _Radius  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(11, value)
				_Radius = value 
			End Set
		End Property
		Protected _Radius As Integer

		#End Region
	
		#Region "Attribute - StandardImage"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("StandardImage", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilStandardImage", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property StandardImage() as String
			Get 
				Return _StandardImage  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value) 
				CheckElementRestriction(12, value)
				_StandardImage = value 
				_IsNilStandardImage = False
			End Set
		End Property
		Protected _StandardImage As String

		Public Property IsNilStandardImage As Boolean
			Get
				Return _IsNilStandardImage
			End Get
			Set
				_IsNilStandardImage = value
			End Set
		End Property
		Protected _IsNilStandardImage As Boolean
		#End Region
	
		#Region "Attribute - UseMouseEnterImage"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("UseMouseEnterImage", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property UseMouseEnterImage() as Boolean
			Get 
				Return _UseMouseEnterImage  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(13, value)
				_UseMouseEnterImage = value 
			End Set
		End Property
		Protected _UseMouseEnterImage As Boolean

		#End Region
	
		#Region "Attribute - MouseEnterImage"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("MouseEnterImage", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilMouseEnterImage", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property MouseEnterImage() as String
			Get 
				Return _MouseEnterImage  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value) 
				CheckElementRestriction(14, value)
				_MouseEnterImage = value 
				_IsNilMouseEnterImage = False
			End Set
		End Property
		Protected _MouseEnterImage As String

		Public Property IsNilMouseEnterImage As Boolean
			Get
				Return _IsNilMouseEnterImage
			End Get
			Set
				_IsNilMouseEnterImage = value
			End Set
		End Property
		Protected _IsNilMouseEnterImage As Boolean
		#End Region
	
		#Region "Attribute - UseMouseDownImage"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("UseMouseDownImage", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property UseMouseDownImage() as Boolean
			Get 
				Return _UseMouseDownImage  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(15, value)
				_UseMouseDownImage = value 
			End Set
		End Property
		Protected _UseMouseDownImage As Boolean

		#End Region
	
		#Region "Attribute - MouseDownImage"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("MouseDownImage", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilMouseDownImage", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property MouseDownImage() as String
			Get 
				Return _MouseDownImage  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value) 
				CheckElementRestriction(16, value)
				_MouseDownImage = value 
				_IsNilMouseDownImage = False
			End Set
		End Property
		Protected _MouseDownImage As String

		Public Property IsNilMouseDownImage As Boolean
			Get
				Return _IsNilMouseDownImage
			End Get
			Set
				_IsNilMouseDownImage = value
			End Set
		End Property
		Protected _IsNilMouseDownImage As Boolean
		#End Region
	
		#Region "Attribute - UseMouseUpImage"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("UseMouseUpImage", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property UseMouseUpImage() as Boolean
			Get 
				Return _UseMouseUpImage  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(17, value)
				_UseMouseUpImage = value 
			End Set
		End Property
		Protected _UseMouseUpImage As Boolean

		#End Region
	
		#Region "Attribute - MouseUpImage"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("MouseUpImage", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilMouseUpImage", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property MouseUpImage() as String
			Get 
				Return _MouseUpImage  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value) 
				CheckElementRestriction(18, value)
				_MouseUpImage = value 
				_IsNilMouseUpImage = False
			End Set
		End Property
		Protected _MouseUpImage As String

		Public Property IsNilMouseUpImage As Boolean
			Get
				Return _IsNilMouseUpImage
			End Get
			Set
				_IsNilMouseUpImage = value
			End Set
		End Property
		Protected _IsNilMouseUpImage As Boolean
		#End Region
	
		#Region "Attribute - StartVisible"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("StartVisible", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property StartVisible() as Boolean
			Get 
				Return _StartVisible  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(19, value)
				_StartVisible = value 
			End Set
		End Property
		Protected _StartVisible As Boolean

		#End Region
	
		#Region "Attribute - StartOpaque"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("StartOpaque", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property StartOpaque() as Boolean
			Get 
				Return _StartOpaque  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(20, value)
				_StartOpaque = value 
			End Set
		End Property
		Protected _StartOpaque As Boolean

		#End Region
	
		#Region "Attribute - VideoFile"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("VideoFile", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilVideoFile", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property VideoFile() as String
			Get 
				Return _VideoFile  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value) 
				CheckElementRestriction(21, value)
				_VideoFile = value 
				_IsNilVideoFile = False
			End Set
		End Property
		Protected _VideoFile As String

		Public Property IsNilVideoFile As Boolean
			Get
				Return _IsNilVideoFile
			End Get
			Set
				_IsNilVideoFile = value
			End Set
		End Property
		Protected _IsNilVideoFile As Boolean
		#End Region
	
		#Region "Attribute - VideoAutoplay"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("VideoAutoplay", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property VideoAutoplay() as Boolean
			Get 
				Return _VideoAutoplay  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(22, value)
				_VideoAutoplay = value 
			End Set
		End Property
		Protected _VideoAutoplay As Boolean

		#End Region
	
		#Region "Attribute - VideoFinishGoToPage"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("VideoFinishGoToPage", "https://www.itskill.nhs.uk/CDAFile.xsd", "IsNilVideoFinishGoToPage", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property VideoFinishGoToPage() as String
			Get 
				Return _VideoFinishGoToPage  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(23, value)
				_VideoFinishGoToPage = value 
				_IsNilVideoFinishGoToPage = False
			End Set
		End Property
		Protected _VideoFinishGoToPage As String

		Public Property IsNilVideoFinishGoToPage As Boolean
			Get
				Return _IsNilVideoFinishGoToPage
			End Get
			Set
				_IsNilVideoFinishGoToPage = value
			End Set
		End Property
		Protected _IsNilVideoFinishGoToPage As Boolean
		#End Region
	
		#Region "Attribute - Behaviour"
		''' <summary>
		''' A collection of BehaviourCols
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' This collection may contain 0 to Many objects.
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("Behaviour", "https://www.itskill.nhs.uk/CDAFile.xsd", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)> _
		Public Readonly Property BehaviourCol() As mstns.ITSPCDALib.XmlObjectCollection(Of mstns.Behaviours)
			Get 
				Return _BehaviourCol 
			End Get
		End Property
		Protected _BehaviourCol As mstns.ITSPCDALib.XmlObjectCollection(Of mstns.Behaviours)
		
		#End Region
	
		#Region "Attribute - Rotation"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("Rotation", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "0", "", "", "359", "-1", "-1", "-1")> _
		Public Property Rotation() as Integer
			Get 
				Return _Rotation  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(25, value)
				_Rotation = value 
			End Set
		End Property
		Protected _Rotation As Integer

		#End Region
	
		#Region "Attribute - EditorVisible"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("EditorVisible", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property EditorVisible() as Boolean
			Get 
				Return _EditorVisible  
			End Get
			Set(ByVal value As Boolean) 
				CheckElementRestriction(26, value)
				_EditorVisible = value 
			End Set
		End Property
		Protected _EditorVisible As Boolean

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


