/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.XPath;

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1742-2169

namespace MS.Internal.Xml.Cache
{
	internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo // TypeDefIndex: 1746
	{
		// Fields
		private XPathNode[] pageCurrent; // 0x10
		private XPathNode[] pageParent; // 0x18
		private int idxCurrent; // 0x20
		private int idxParent; // 0x24
	
		// Properties
		public override string Value { get => default; } // 0x0000000180613E10-0x0000000180614110 
		public override XPathNodeType NodeType { get => default; } // 0x0000000180613D80-0x0000000180613DC0 
		public override string LocalName { get => default; } // 0x0000000180613C90-0x0000000180613CE0 
		public override string NamespaceURI { get => default; } // 0x0000000180613D30-0x0000000180613D80 
		public override string Prefix { get => default; } // 0x0000000180613DC0-0x0000000180613E10 
		public override XmlNameTable NameTable { get => default; } // 0x0000000180613CE0-0x0000000180613D30 
		public override object UnderlyingObject { get => default; } // 0x00000001803E8980-0x00000001803E89A0 
		public int LineNumber { get => default; } // 0x0000000180613B30-0x0000000180613BD0 
		public int LinePosition { get => default; } // 0x0000000180613BD0-0x0000000180613C90 
	
		// Constructors
		public XPathDocumentNavigator() {} // Dummy constructor
		public XPathDocumentNavigator(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) {} // 0x0000000180613A90-0x0000000180613B30
	
		// Methods
		public override XPathNavigator Clone() => default; // 0x0000000180613360-0x0000000180613440
		public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) => default; // 0x00000001806134E0-0x0000000180613780
		public override bool MoveToNextNamespace(XPathNamespaceScope scope) => default; // 0x0000000180613780-0x0000000180613990
		public override bool MoveToParent() => default; // 0x0000000180613990-0x0000000180613A90
		public override bool IsSamePosition(XPathNavigator other) => default; // 0x0000000180613450-0x00000001806134E0
		public int GetPositionHashCode() => default; // 0x0000000180613440-0x0000000180613450
	}
}
