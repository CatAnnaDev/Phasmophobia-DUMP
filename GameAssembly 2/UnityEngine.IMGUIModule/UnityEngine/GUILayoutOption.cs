/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 13: UnityEngine.IMGUIModule.dll - Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3731-3777

namespace UnityEngine
{
	public sealed class GUILayoutOption // TypeDefIndex: 3750
	{
		// Fields
		internal Type type; // 0x10
		internal object value; // 0x18
	
		// Nested types
		internal enum Type // TypeDefIndex: 3751
		{
			fixedWidth = 0,
			fixedHeight = 1,
			minWidth = 2,
			maxWidth = 3,
			minHeight = 4,
			maxHeight = 5,
			stretchWidth = 6,
			stretchHeight = 7,
			alignStart = 8,
			alignMiddle = 9,
			alignEnd = 10,
			alignJustify = 11,
			equalSize = 12,
			spacing = 13
		}
	
		// Constructors
		public GUILayoutOption() {} // Dummy constructor
		internal GUILayoutOption(Type type, object value) {} // 0x000000018045FB50-0x000000018045FB90
	}
}
