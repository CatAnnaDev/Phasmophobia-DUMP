/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 13: UnityEngine.IMGUIModule.dll - Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3731-3777

namespace UnityEngine
{
	[Serializable]
	// [NativeHeader] // 0x00000001800FB2D0-0x00000001800FB300
	public sealed class GUIStyleState // TypeDefIndex: 3758
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
		private readonly GUIStyle m_SourceStyle; // 0x18
	
		// Properties
		[NativeProperty] // 0x00000001800FB690-0x00000001800FB6D0
		public Color textColor { set {} } // 0x0000000180AA0240-0x0000000180AA0290
	
		// Constructors
		public GUIStyleState() {} // 0x0000000180AA01B0-0x0000000180AA01F0
		private GUIStyleState(GUIStyle sourceStyle, IntPtr source) {} // 0x0000000180943CD0-0x0000000180943D20
	
		// Methods
		[FreeFunction] // 0x00000001800FB3A0-0x00000001800FB3E0
		private static IntPtr Init() => default; // 0x0000000180AA0180-0x0000000180AA01B0
		[FreeFunction] // 0x00000001800FB480-0x00000001800FB4C0
		private void Cleanup() {} // 0x0000000180A9FFF0-0x0000000180AA0030
		internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) => default; // 0x0000000180AA0110-0x0000000180AA0180
		~GUIStyleState() {} // 0x0000000180AA0030-0x0000000180AA0110
		private void set_textColor_Injected(ref Color value) {} // 0x0000000180AA01F0-0x0000000180AA0240
	}
}
