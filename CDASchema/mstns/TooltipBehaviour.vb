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
	''' This class represents the ComplexType TooltipBehaviour
	''' </summary>
	<LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence, _
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, _
													"TooltipBehaviour", "https://www.itskill.nhs.uk/CDAFile.xsd", true, false, _
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, Nothing, false)> _
	Public Partial Class TooltipBehaviour
		Inherits mstns.ITSPCDALib.XmlCommonBase

		#Region "Constructors"
		''' <summary>
		'''	Constructor for TooltipBehaviour
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
			_elementName = "TooltipBehaviour"
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
			_TooltipTitle = ""
			_SupertipBody = ""
			_SupertipFooter = ""



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
			Dim newObject As New mstns.TooltipBehaviour(_elementName)
			Dim o As Object
			newObject._TooltipTitle = _TooltipTitle
			newObject._SupertipBody = _SupertipBody
			newObject._SupertipFooter = _SupertipFooter

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

		#Region "Attribute - TooltipTitle"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("TooltipTitle", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property TooltipTitle() as String
			Get 
				Return _TooltipTitle  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(0, value)
				_TooltipTitle = value 
			End Set
		End Property
		Protected _TooltipTitle As String

		#End Region
	
		#Region "Attribute - SupertipBody"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("SupertipBody", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property SupertipBody() as String
			Get 
				Return _SupertipBody  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(1, value)
				_SupertipBody = value 
			End Set
		End Property
		Protected _SupertipBody As String

		#End Region
	
		#Region "Attribute - SupertipFooter"
		''' <summary>
		''' Represents a mandatory Element in the XML document
		''' </summary>
		''' <remarks>
		''' This property is represented as an Element in the XML.
		''' It is mandatory and therefore must be populated within the XML.
		''' It is defaulted to "".
		''' </remarks>
        <LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("SupertipFooter", "https://www.itskill.nhs.uk/CDAFile.xsd", Nothing, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, Nothing, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1", "-1", "-1")> _
		Public Property SupertipFooter() as String
			Get 
				Return _SupertipFooter  
			End Get
			Set(ByVal value As String) 
				' Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value) 
				CheckElementRestriction(2, value)
				_SupertipFooter = value 
			End Set
		End Property
		Protected _SupertipFooter As String

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


