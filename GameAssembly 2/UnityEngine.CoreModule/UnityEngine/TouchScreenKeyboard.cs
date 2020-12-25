/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeConditional] // 0x00000001801065A0-0x0000000180106620
	// [NativeHeader] // 0x00000001801065A0-0x0000000180106620
	// [NativeHeader] // 0x00000001801065A0-0x0000000180106620
	public class TouchScreenKeyboard // TypeDefIndex: 3317
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
	
		// Properties
		public static bool isSupported { get => default; } // 0x00000001808E31D0-0x00000001808E3220 
		public static bool isInPlaceEditingAllowed { get => default; } // 0x00000001806C0540-0x00000001806C0550 
		public string text { /* [NativeName] */ /* 0x0000000180106C10-0x0000000180106C40 */ get => default; /* [NativeName] */ /* 0x0000000180106CA0-0x0000000180106CD0 */ set {} } // 0x00000001808E32B0-0x00000001808E32F0 0x00000001808E34B0-0x00000001808E3500
		public static bool hideInput { /* [NativeName] */ /* 0x0000000180106CD0-0x0000000180106D00 */ set {} } // 0x00000001808E3380-0x00000001808E33C0
		public bool active { /* [NativeName] */ /* 0x0000000180106D60-0x0000000180106D90 */ get => default; /* [NativeName] */ /* 0x0000000180106DE0-0x0000000180106E10 */ set {} } // 0x00000001808E3110-0x00000001808E3150 0x00000001808E32F0-0x00000001808E3340
		public Status status { /* [NativeName] */ /* 0x0000000180106E70-0x0000000180106EA0 */ get => default; } // 0x00000001808E3270-0x00000001808E32B0 
		public int characterLimit { /* [NativeName] */ /* 0x0000000180107070-0x00000001801070A0 */ set {} } // 0x00000001808E3340-0x00000001808E3380
		public bool canGetSelection { /* [NativeName] */ /* 0x0000000180107130-0x0000000180107160 */ get => default; } // 0x00000001808E3150-0x00000001808E3190 
		public bool canSetSelection { /* [NativeName] */ /* 0x00000001801071B0-0x00000001801071E0 */ get => default; } // 0x00000001808E3190-0x00000001808E31D0 
		public RangeInt selection { get => default; set {} } // 0x00000001808E3220-0x00000001808E3270 0x00000001808E33C0-0x00000001808E34B0
	
		// Nested types
		public enum Status // TypeDefIndex: 3318
		{
			Visible = 0,
			Done = 1,
			Canceled = 2,
			LostFocus = 3
		}
	
		// Constructors
		public TouchScreenKeyboard() {} // Dummy constructor
		public TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) {} // 0x00000001808E2FE0-0x00000001808E3110
	
		// Methods
		[FreeFunction] // 0x0000000180106780-0x00000001801067C0
		private static void Internal_Destroy(IntPtr ptr) {} // 0x00000001808E2C40-0x00000001808E2C80
		private void Destroy() {} // 0x00000001808E2A40-0x00000001808E2AE0
		~TouchScreenKeyboard() {} // 0x00000001808E2AE0-0x00000001808E2BF0
		[FreeFunction] // 0x0000000180106810-0x0000000180106840
		private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) => default; // 0x00000001808E2F80-0x00000001808E2FE0
		public static TouchScreenKeyboard Open(string text, [DefaultValue] /* 0x00000001801068E0-0x0000000180106910 */ TouchScreenKeyboardType keyboardType, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool autocorrection, [DefaultValue] /* 0x00000001800DFAE0-0x00000001800DFB10 */ bool multiline, [DefaultValue] /* 0x00000001800DFAE0-0x00000001800DFB10 */ bool secure, [DefaultValue] /* 0x00000001800DFAE0-0x00000001800DFB10 */ bool alert, [DefaultValue] /* 0x0000000180106B90-0x0000000180106BC0 */ string textPlaceholder, [DefaultValue] /* 0x00000001800DEB90-0x00000001800DEBC0 */ int characterLimit) => default; // 0x00000001808E2DF0-0x00000001808E2F40
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) => default; // 0x00000001808E2C80-0x00000001808E2DF0
		private static void GetSelection(out int start, out int length) {
			start = default;
			length = default;
		} // 0x00000001808E2BF0-0x00000001808E2C40
		private static void SetSelection(int start, int length) {} // 0x00000001808E2F40-0x00000001808E2F80
	}
}
