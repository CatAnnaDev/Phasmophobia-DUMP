/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 13: UnityEngine.IMGUIModule.dll - Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3731-3777

namespace UnityEngine
{
	[Serializable]
	// [NativeHeader] // 0x00000001800F5E40-0x00000001800F5EA0
	[RequiredByNativeCode] // 0x00000001800F5E40-0x00000001800F5EA0
	public class GUIContent // TypeDefIndex: 3743
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private string m_Text; // 0x10
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Texture m_Image; // 0x18
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private string m_Tooltip; // 0x20
		private static readonly GUIContent s_Text; // 0x00
		private static readonly GUIContent s_Image; // 0x08
		private static readonly GUIContent s_TextImage; // 0x10
		public static GUIContent none; // 0x18
	
		// Properties
		public string text { get => default; set {} } // 0x00000001809302E0-0x00000001809302F0 0x0000000180248410-0x0000000180248420
		public Texture image { set {} } // 0x0000000180246D40-0x0000000180246D50
		public string tooltip { get => default; set {} } // 0x0000000180930300-0x0000000180930310 0x0000000180249080-0x0000000180249090
	
		// Constructors
		public GUIContent() {} // 0x0000000180A1B740-0x0000000180A1B7B0
		public GUIContent(string text) {} // 0x0000000180A1B640-0x0000000180A1B740
		public GUIContent(string text, Texture image, string tooltip) {} // 0x0000000180A1B4A0-0x0000000180A1B570
		public GUIContent(GUIContent src) {} // 0x0000000180A1B570-0x0000000180A1B640
		static GUIContent() {} // 0x0000000180A1B290-0x0000000180A1B4A0
	
		// Methods
		internal static GUIContent Temp(string t) => default; // 0x0000000180A1AFE0-0x0000000180A1B0A0
		internal static GUIContent Temp(Texture i) => default; // 0x0000000180A1B1D0-0x0000000180A1B290
		[VisibleToOtherModules] // 0x00000001800F60D0-0x00000001800F6150
		internal static void ClearStaticCache() {} // 0x0000000180A1AE80-0x0000000180A1AFE0
		internal static GUIContent[] Temp(string[] texts) => default; // 0x0000000180A1B0A0-0x0000000180A1B1D0
	}
}
