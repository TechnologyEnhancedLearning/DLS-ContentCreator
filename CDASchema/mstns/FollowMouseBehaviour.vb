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
	''' The Follow Mouse behaviour can be attached to any object. When an object has this behaviour attached, it will follow the mouse pointer around the page. The offset values can be used to position the object under the mouse away from the top left corner.
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"FollowMouseBehaviour", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class FollowMouseBehaviour
		Inherits mstns.ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for FollowMouseBehaviour
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
			_elementName = "FollowMouseBehaviour"
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
			_OffsetHPixels = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)
			_OffsetVPixels = LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)



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
			Dim newObject As New mstns.FollowMouseBehaviour(_elementName)
			Dim o As Object
			newObject._OffsetHPixels = _OffsetHPixels
			newObject._OffsetVPixels = _OffsetVPixels

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

		#Region "Attribute - OffsetHPixels"
		''' <summary>
		''' The number of pixels to offset the image by horizontally from the mouse location.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("OffsetHPixels", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property OffsetHPixels() as Integer
			Get 
				Return _OffsetHPixels  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(0, value)
				_OffsetHPixels = value 
			End Set
		End Property
		Protected _OffsetHPixels As Integer

		#End Region
	
		#Region "Attribute - OffsetVPixels"
		''' <summary>
		''' The number of pixels to offset the image by vertically from the mouse location.
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.i4FromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("OffsetVPixels", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_i4, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property OffsetVPixels() as Integer
			Get 
				Return _OffsetVPixels  
			End Get
			Set(ByVal value As Integer) 
				CheckElementRestriction(1, value)
				_OffsetVPixels = value 
			End Set
		End Property
		Protected _OffsetVPixels As Integer

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


