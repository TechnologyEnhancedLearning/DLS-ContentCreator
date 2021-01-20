Option Explicit On
Option Strict On

Imports System
Imports System.Xml

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

	Public NotInheritable Class ClassFactory

#Region "Shared New"
		Private Shared _nsMap As System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.Dictionary(Of String, System.Type)) = Nothing
		Shared Sub New()
			_nsMap = New System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.Dictionary(Of String, System.Type))()
			Dim itemMap As System.Collections.Generic.Dictionary(Of String, System.Type) = Nothing
			itemMap = New System.Collections.Generic.Dictionary(Of String, System.Type)()
			itemMap.Add("AnimateBehaviour", GetType(mstns.AnimateBehaviour))
			itemMap.Add("Behaviours", GetType(mstns.Behaviours))
			itemMap.Add("ChangeHistory", GetType(mstns.ChangeHistory))
			itemMap.Add("ChangeMousePointerBehaviour", GetType(mstns.ChangeMousePointerBehaviour))
			itemMap.Add("CustomCssBehaviour", GetType(mstns.CustomCssBehaviour))
			itemMap.Add("CustomJavaScriptBehaviour", GetType(mstns.CustomJavaScriptBehaviour))
			itemMap.Add("DragBehaviour", GetType(mstns.DragBehaviour))
			itemMap.Add("FollowMouseBehaviour", GetType(mstns.FollowMouseBehaviour))
			itemMap.Add("ITSPUnit", GetType(mstns.ITSPUnit))
			itemMap.Add("KeyboardShortcutBehaviour", GetType(mstns.KeyboardShortcutBehaviour))
			itemMap.Add("MarqueeBehaviour", GetType(mstns.MarqueeBehaviour))
			itemMap.Add("MouseInteractionBehaviour", GetType(mstns.MouseInteractionBehaviour))
			itemMap.Add("Object", GetType(mstns.Object_))
			itemMap.Add("Page", GetType(mstns.Page))
			itemMap.Add("PasswordBehaviour", GetType(mstns.PasswordBehaviour))
			itemMap.Add("QuizChoice", GetType(mstns.QuizChoice))
			itemMap.Add("QuizQuestion", GetType(mstns.QuizQuestion))
			itemMap.Add("ResizeBehaviour", GetType(mstns.ResizeBehaviour))
			itemMap.Add("SelectableBehaviour", GetType(mstns.SelectableBehaviour))
			itemMap.Add("SpinnerBehaviour", GetType(mstns.SpinnerBehaviour))
			itemMap.Add("TextBehaviour", GetType(mstns.TextBehaviour))
			itemMap.Add("TooltipBehaviour", GetType(mstns.TooltipBehaviour))
			itemMap.Add("Tutorials", GetType(mstns.Tutorials))
			_nsMap.Add("https://www.itskill.nhs.uk/CDAFile.xsd", itemMap)
		End Sub
#End Region

#Region "FromXml"
		''' <summary>
		''' Creates an object from XML data held in a string.
		''' </summary>
		''' <param name="xmlIn">The data to be loaded</param>
		''' <returns>The wrapper object, loaded with the supplied data</returns>
		''' <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		Public Shared Function FromXml(ByVal xmlIn As String) As LiquidTechnologies.Runtime.Net45.XmlObjectBase 
			Return FromXml(xmlIn, LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default)
        End Function
		''' <summary>
		''' Creates an object from XML data held in a string.
		''' </summary>
		''' <param name="xmlIn">The data to be loaded</param>
		''' <param name="context">The context to use when loading the data</param>
		''' <returns>The wrapper object, loaded with the supplied data</returns>
		''' <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		Public Shared Function FromXml(ByVal xmlIn As String, ByVal context As LiquidTechnologies.Runtime.Net45.XmlSerializationContext) As LiquidTechnologies.Runtime.Net45.XmlObjectBase 
			Dim xmlDoc as XmlDocument = LiquidTechnologies.Runtime.Net45.XmlObjectBase.LoadXmlDocument(xmlIn, context)
			Return FromXmlElement(xmlDoc.DocumentElement, context)
        End Function
#End Region

#Region "FromXmlFile"
		''' <summary>
		''' Creates an object from XML data held in a File
		''' </summary>
		''' <param name="FileName">The file to be loaded</param>
		''' <returns>The wrapper object, loaded with the supplied data</returns>
		''' <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		Public Shared Function FromXmlFile(ByVal FileName As String) As LiquidTechnologies.Runtime.Net45.XmlObjectBase 
			Return FromXmlFile(FileName, LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default)
        End Function
		''' <summary>
		''' Creates an object from XML data held in a File
		''' </summary>
		''' <param name="FileName">The file to be loaded</param>
		''' <param name="context">The context to use when loading the data</param>
		''' <returns>The wrapper object, loaded with the supplied data</returns>
		''' <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		Public Shared Function FromXmlFile(ByVal FileName As String, ByVal context As LiquidTechnologies.Runtime.Net45.XmlSerializationContext) As LiquidTechnologies.Runtime.Net45.XmlObjectBase 
			Using stream As System.IO.Stream = new System.IO.FileStream(FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read,System.IO.FileShare.Read)
				Return FromXmlStream(stream, context)
			End Using
        End Function
#End Region

#Region "FromXmlStream"
		''' <summary>
		''' Creates an object from XML data held in a stream.
		''' </summary>
		''' <param name="stream">The data to be loaded</param>
		''' <returns>The wrapper object, loaded with the supplied data</returns>
		''' <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		Public Shared Function FromXmlStream(ByVal stream As System.IO.Stream) As LiquidTechnologies.Runtime.Net45.XmlObjectBase 
			Return FromXmlStream(stream, LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default)
        End Function
		''' <summary>
		''' Creates an object from XML data held in a stream.
		''' </summary>
		''' <param name="stream">The data to be loaded</param>
		''' <returns>The wrapper object, loaded with the supplied data</returns>
		''' <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		Public Shared Function FromXmlStream(ByVal stream As System.IO.Stream, ByVal context As LiquidTechnologies.Runtime.Net45.XmlSerializationContext) As LiquidTechnologies.Runtime.Net45.XmlObjectBase 
			Dim xmlDoc As XmlDocument = LiquidTechnologies.Runtime.Net45.XmlObjectBase.LoadXmlDocument(stream, context)
			Return FromXmlElement(xmlDoc.DocumentElement, context)
        End Function
#End Region
		
#Region "FromXmlElement"
		''' <summary>
		''' Creates an object from an XML Element.
		''' </summary>
		''' <param name="xmlParent">The data that needs loading</param>
		''' <returns>The wrapper object, loaded with the supplied data</returns>
		''' <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		Public Shared Function FromXmlElement(ByVal xmlParent As XmlElement) As LiquidTechnologies.Runtime.Net45.XmlObjectBase 
			Return FromXmlElement(xmlParent, LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default)
        End Function
			
		''' <summary>
		''' Creates an object from an XML Element.
		''' </summary>
		''' <param name="xmlParent">The data that needs loading</param>
		''' <param name="context">The context to use when loading the data</param>
		''' <returns>The wrapper object, loaded with the supplied data</returns>
		''' <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		Public Shared Function FromXmlElement(ByVal xmlParent As XmlElement, ByVal context As LiquidTechnologies.Runtime.Net45.XmlSerializationContext) As LiquidTechnologies.Runtime.Net45.XmlObjectBase 
			Dim retVal As LiquidTechnologies.Runtime.Net45.XmlObjectBase = Nothing
			Dim elementName As String
			Dim elementNamespaceUri As String 

			' Get the type name this is either 
			' from the element i.e. <Parent>... = Parent
			' or from the type i.e. <Parent xsi:type="someNS:SomeElement">... = SomeElement
			if (LiquidTechnologies.Runtime.Net45.ClassFactoryHelper.GetElementType(xmlParent) = "")
				elementName = xmlParent.LocalName
				elementNamespaceUri = xmlParent.NamespaceURI
			else
				elementName = LiquidTechnologies.Runtime.Net45.ClassFactoryHelper.GetElementType(xmlParent)
				elementNamespaceUri = LiquidTechnologies.Runtime.Net45.ClassFactoryHelper.GetElementTypeNamespaceUri(xmlParent)
			end if 

			' create the appropriate object
			retVal = LiquidTechnologies.Runtime.Net45.ClassFactoryHelper.CreateObject(_nsMap, elementName, elementNamespaceUri, context)
			If retVal Is Nothing Then
				throw new LiquidTechnologies.Runtime.Net45.LtException(string.Format("Failed load the element {0}:{1}. No appropriate class exists to load the data into. Ensure that the XML document complies with the schema.", elementName, elementNamespaceUri))
			End If
			
			' load the data into the object
			retVal.FromXmlElement(xmlParent, context)

			Return retVal
        End Function
#End Region
    End Class
End Namespace
Namespace mstns

	Public NotInheritable Class ClassFactory

#Region "Shared New"
		Private Shared _IITSPUnitMap As System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.Dictionary(Of String, System.Type))
		Shared Sub New()
			Dim itemMap As System.Collections.Generic.Dictionary(Of String, System.Type) = Nothing
			_IITSPUnitMap = New System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.Dictionary(Of String, System.Type))()
			itemMap = New System.Collections.Generic.Dictionary(Of String, System.Type)()
			itemMap.Add("ITSPUnit", GetType(mstns.ITSPUnitA))
			_IITSPUnitMap.Add("https://www.itskill.nhs.uk/CDAFile.xsd", itemMap)
		End Sub
#End Region

		' We are trying to create a class, however it may be any one of the derived 
		' classes that we want, so we need to try to create them, if they fail move on to
		' the next, until we have one that fits.		
		Public Shared Function IITSPUnitCreateObject(ByVal xmlParent As XmlElement, ByVal context As LiquidTechnologies.Runtime.Net45.XmlSerializationContext) As IITSPUnit
			Dim retVal As mstns.IITSPUnit = Nothing

			' Get the type name
			Dim typeName As String = LiquidTechnologies.Runtime.Net45.ClassFactoryHelper.GetElementType(xmlParent)

			If typeName = "" Then
				Return New mstns.ITSPUnitA()
			End If

			If retVal Is Nothing Then
				retVal = CType(LiquidTechnologies.Runtime.Net45.ClassFactoryHelper.CreateObject(_IITSPUnitMap, typeName, LiquidTechnologies.Runtime.Net45.ClassFactoryHelper.GetElementTypeNamespaceUri(xmlParent), context), mstns.IITSPUnit)
			End If

			Return retVal
		End Function
    End Class
End Namespace

