/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.XPath;

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1742-2169

namespace MS.Internal.Xml.Cache
{
	internal struct XPathNode // TypeDefIndex: 1747
	{
		// Fields
		private XPathNodeInfoAtom info; // 0x00
		private ushort idxSibling; // 0x08
		private ushort idxParent; // 0x0A
		private ushort idxSimilar; // 0x0C
		private ushort posOffset; // 0x0E
		private uint props; // 0x10
		private string value; // 0x18
	
		// Properties
		public XPathNodeType NodeType { get => default; } // 0x0000000180023D20-0x0000000180023D30 
		public string Prefix { get => default; } // 0x0000000180023D50-0x0000000180023F50 
		public string LocalName { get => default; } // 0x00000001800096E0-0x0000000180009700 
		public string NamespaceUri { get => default; } // 0x0000000180023D00-0x0000000180023D20 
		public XPathDocument Document { get => default; } // 0x0000000180023B90-0x0000000180023BB0 
		public int LineNumber { get => default; } // 0x0000000180023CB0-0x0000000180023CE0 
		public int LinePosition { get => default; } // 0x0000000180023CE0-0x0000000180023D00 
		public int CollapsedLinePosition { get => default; } // 0x0000000180023B60-0x0000000180023B90 
		public XPathNodePageInfo PageInfo { get => default; } // 0x0000000180023D30-0x0000000180023D50 
		public bool IsXmlNamespaceNode { get => default; } // 0x0000000180023C40-0x0000000180023CB0 
		public bool HasSibling { get => default; } // 0x0000000180023BD0-0x0000000180023BE0 
		public bool HasCollapsedText { get => default; } // 0x0000000180023BB0-0x0000000180023BC0 
		public bool IsText { get => default; } // 0x0000000180023BE0-0x0000000180023C40 
		public bool HasNamespaceDecls { get => default; } // 0x0000000180023BC0-0x0000000180023BD0 
		public string Value { get => default; } // 0x00000001800121D0-0x00000001800124D0 
	
		// Methods
		public int GetParent(out XPathNode[] pageNode) {
			pageNode = default;
			return default;
		} // 0x0000000180023AE0-0x0000000180023B20
		public int GetSibling(out XPathNode[] pageNode) {
			pageNode = default;
			return default;
		} // 0x0000000180023B20-0x0000000180023B60
	}
}
