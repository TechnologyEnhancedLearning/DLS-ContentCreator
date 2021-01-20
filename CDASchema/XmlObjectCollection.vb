Imports System

' **********************************************************************************************
' * Copyright (c) 2001-2016 Liquid Technologies Limited. All rights reserved.
' * See www.liquid-technologies.com for product details.
' *
' * Please see products End User License Agreement for distribution permissions.
' *
' * WARNING: THIS FILE IS GENERATED
' * Changes made outside of ##HAND_CODED_BLOCK_START blocks will be overwritten
' *
' * Generation  :  by Liquid XML Data Binder 14.1.5.6733
' * Using Schema: C:\Users\admin\Documents\Content Management and Development\CDA\ITSPCDA.xsd
' **********************************************************************************************

Namespace mstns.ITSPCDALib

	''' <summary>
	''' This is the base class for all the generated object collection classes. 
	''' </summary>
	''' <remarks>
	''' You can extend this class to provide common functionality to all
	''' generated collection classes. Be sure to place all you additions inside the
	''' hand coded blocks (or they will be lost when you re-generate the code.	
	''' </remarks>
  Partial Public Class XmlObjectCollection(Of T As {New, LiquidTechnologies.Runtime.Net45.XmlObjectBase})
    Inherits LiquidTechnologies.Runtime.Net45.XmlCollection(Of T)

    Public Sub New(ByVal elementName As String, ByVal targetNamespace As String, ByVal minOccurs As Integer, ByVal maxOccurs As Integer, ByVal isPseudoElement As Boolean)
      MyBase.New(elementName, targetNamespace, minOccurs, maxOccurs, isPseudoElement)
' ##HAND_CODED_BLOCK_START ID="XmlObjectCollection Constructor"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Constructor Code here...

' ##HAND_CODED_BLOCK_END ID="XmlObjectCollection Constructor"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
    End Sub

    ' * You can use the following hand coded section to override the XmlObjectBase FromXml... and ToXml...
    ' * virtual methods to provide custom pre or post processing for all your generated classes,
    ' * or to add your own common methods.
    ' *
    ' * For Example you can add the following here:
    ' *
    ' *	Public Overrides Sub ToXmlFile(FileName As String)
    ' *
    ' *		' Perform Custom Pre Processing
    ' *
    ' *		MyBase.ToXmlFile(FileName);
    ' *
    ' *		' Perform Custom Post Processing
    ' * End Sub

' ##HAND_CODED_BLOCK_START ID="XmlObjectCollection Custom Base Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Custom Base Methods here...

' ##HAND_CODED_BLOCK_END ID="XmlObjectCollection Custom Base Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

  End Class

	''' <summary>
	''' This is the base class for all the generated abstract object collection classes. 
	''' </summary>
	''' <remarks>
	''' You can extend this class to provide common functionality to all
	''' generated collection classes. Be sure to place all you additions inside the
	''' hand coded blocks (or they will be lost when you re-generate the code.	
	''' </remarks>
  Partial Public Class XmlAbstractObjectCollection(Of T As {LiquidTechnologies.Runtime.Net45.XmlObjectInterface})
    Inherits LiquidTechnologies.Runtime.Net45.XmlAbstractCollection(Of T)

    Public Sub New(ByVal elementName As String, ByVal targetNamespace As String, ByVal minOccurs As Integer, ByVal maxOccurs As Integer, ByVal classFactoryType As System.Type, ByVal createObjectMethod As String)
      MyBase.New(elementName, TargetNamespace, MinOccurs, MaxOccurs, classFactoryType, createObjectMethod)
' ##HAND_CODED_BLOCK_START ID="XmlAbstractObjectCollection Constructor"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Constructor Code here...

' ##HAND_CODED_BLOCK_END ID="XmlAbstractObjectCollection Constructor"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
    End Sub

    ' * You can use the following hand coded section to override the XmlObjectBase FromXml... and ToXml...
    ' * virtual methods to provide custom pre or post processing for all your generated classes,
    ' * or to add your own common methods.
    ' *
    ' * For Example you can add the following here:
    ' *
    ' *	Public Overrides Sub ToXmlFile(FileName As String)
    ' *
    ' *		' Perform Custom Pre Processing
    ' *
    ' *		MyBase.ToXmlFile(FileName);
    ' *
    ' *		' Perform Custom Post Processing
    ' * End Sub

' ##HAND_CODED_BLOCK_START ID="XmlAbstractObjectCollection Custom Base Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Custom Base Methods here...

' ##HAND_CODED_BLOCK_END ID="XmlAbstractObjectCollection Custom Base Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

  End Class

  ''' <summary>
  ''' This is the base class for all the generated enum type collection classes. 
  ''' </summary>
  ''' <remarks>
  ''' You can extend this class to provide common functionality to all
  ''' generated collection classes. Be sure to place all you additions inside the
  ''' hand coded blocks (or they will be lost when you re-generate the code.	
  ''' </remarks>
  Partial Public Class XmlEnumTypeCollection(Of T)
    Inherits LiquidTechnologies.Runtime.Net45.XmlEnumCollection(Of T)

    Public Sub New(ByVal elementName As String, ByVal targetNamespace As String, ByVal minOccurs As Integer, ByVal maxOccurs As Integer, ByVal enumClass As System.Type, ByVal fromStringMethod As String, ByVal toStringMethod As String)
      MyBase.new(elementName, targetNamespace, minOccurs, maxOccurs, enumClass, fromStringMethod, toStringMethod)
' ##HAND_CODED_BLOCK_START ID="XmlEnumTypeCollection Constructor"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Constructor Code here...

' ##HAND_CODED_BLOCK_END ID="XmlEnumTypeCollection Constructor"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
    End Sub

    ' * You can use the following hand coded section to override the XmlObjectBase FromXml... and ToXml...
    ' * virtual methods to provide custom pre or post processing for all your generated classes,
    ' * or to add your own common methods.
    ' *
    ' * For Example you can add the following here:
    ' *
    ' *	Public Overrides Sub ToXmlFile(FileName As String)
    ' *
    ' *		' Perform Custom Pre Processing
    ' *
    ' *		MyBase.ToXmlFile(FileName);
    ' *
    ' *		' Perform Custom Post Processing
    ' * End Sub

' ##HAND_CODED_BLOCK_START ID="XmlEnumTypeCollection Custom Base Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Custom Base Methods here...

' ##HAND_CODED_BLOCK_END ID="XmlEnumTypeCollection Custom Base Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

  End Class

  ''' <summary>
  ''' This is the base class for all the generated simple type collection classes. 
  ''' </summary>
  ''' <remarks>
  ''' You can extend this class to provide common functionality to all
  ''' generated collection classes. Be sure to place all you additions inside the
  ''' hand coded blocks (or they will be lost when you re-generate the code.	
  ''' </remarks>
  Partial Public Class XmlSimpleTypeCollection(Of T)
    Inherits LiquidTechnologies.Runtime.Net45.XmlTypeCollection(Of T)

    Public Sub New(ByVal elementName As String, ByVal targetNamespace As String, ByVal dataType As LiquidTechnologies.Runtime.Net45.Conversions.ConversionType, ByVal minOccurs As Integer, ByVal maxOccurs As Integer, ByVal formatOverride As String, ByVal wsRule As LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule, ByVal primValues As LiquidTechnologies.Runtime.Net45.PrimitiveRestrictions)
      MyBase.New(elementName, targetNamespace, dataType, minOccurs, maxOccurs, formatOverride, wsRule, primValues)
' ##HAND_CODED_BLOCK_START ID="XmlSimpleTypeCollection Constructor"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Constructor Code here...

' ##HAND_CODED_BLOCK_END ID="XmlSimpleTypeCollection Constructor"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
    End Sub

    ' * You can use the following hand coded section to override the XmlObjectBase FromXml... and ToXml...
    ' * virtual methods to provide custom pre or post processing for all your generated classes,
    ' * or to add your own common methods.
    ' *
    ' * For Example you can add the following here:
    ' *
    ' *	Public Overrides Sub ToXmlFile(FileName As String)
    ' *
    ' *		' Perform Custom Pre Processing
    ' *
    ' *		MyBase.ToXmlFile(FileName);
    ' *
    ' *		' Perform Custom Post Processing
    ' * End Sub

' ##HAND_CODED_BLOCK_START ID="XmlSimpleTypeCollection Custom Base Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Custom Base Methods here...

' ##HAND_CODED_BLOCK_END ID="XmlSimpleTypeCollection Custom Base Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

  End Class
End Namespace


