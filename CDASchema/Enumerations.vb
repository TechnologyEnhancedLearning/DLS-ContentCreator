Option Explicit On
Option Strict On

Imports System
Imports System.Collections
Imports System.Xml
Imports System.Diagnostics
Imports System.Collections.Specialized

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

	Public Class Enumerations
		' All the enumerations used within the Schema

' ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Additional Methods and members here...

' ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	End Class
End Namespace 
Namespace mstns 

	Public Class Enumerations
		' All the enumerations used within the Schema

' ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

' Add Additional Methods and members here...

' ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	End Class
End Namespace 
	
Namespace mstns.ITSPCDALib 

	Friend class Registration
	
		Private Shared Function RegisterLicense() as Int32 
			LiquidTechnologies.Runtime.Net45.XmlObjectBase.Register("NHS Digital (1 * Developer Bundle)", "ITSPCDA.xsd", "6RDCK881943T19E8000000AA")
			
' ##HAND_CODED_BLOCK_START ID="Namespace Declarations"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
' Add Additional namespace declarations here...
			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.SchemaType = LiquidTechnologies.Runtime.Net45.SchemaType.XSD
'			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.DefaultNamespaceURI = "http://www.fpml.org/2003/FpML-4-0"
'			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("dsig", "http://www.w3.org/2000/09/xmldsig#")

			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("xs", "http://www.w3.org/2001/XMLSchema-instance")
			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("mstns", "https://www.itskill.nhs.uk/CDAFile.xsd")

' ##HAND_CODED_BLOCK_END ID="Namespace Declarations"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			
			Return 1
		End Function
		Public Shared iRegistrationIndicator as Int32  = RegisterLicense()
	End Class
End Namespace




