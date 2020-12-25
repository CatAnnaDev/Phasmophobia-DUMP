/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	[AttributeUsage(AttributeTargets.All)] // 0x00000001801472C0-0x0000000180147310
	// [ComVisible] // 0x00000001801472C0-0x0000000180147310
	public sealed class AttributeUsageAttribute : Attribute // TypeDefIndex: 166
	{
		// Fields
		internal AttributeTargets m_attributeTarget; // 0x10
		internal bool m_allowMultiple; // 0x14
		internal bool m_inherited; // 0x15
		internal static AttributeUsageAttribute Default; // 0x00
	
		// Properties
		public bool AllowMultiple { get => default; set {} } // 0x00000001802D2B60-0x00000001802D2B70 0x000000018030F010-0x000000018030F020
		public bool Inherited { get => default; set {} } // 0x000000018070B010-0x000000018070B020 0x000000018070B020-0x000000018070B030
	
		// Constructors
		public AttributeUsageAttribute() {} // Dummy constructor
		public AttributeUsageAttribute(AttributeTargets validOn) {} // 0x000000018070AFE0-0x000000018070B010
		static AttributeUsageAttribute() {} // 0x000000018070AF70-0x000000018070AFE0
	}
}
