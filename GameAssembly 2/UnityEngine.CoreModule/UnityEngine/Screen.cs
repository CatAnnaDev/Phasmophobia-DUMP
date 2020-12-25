/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001801355D0-0x0000000180135650
	// [NativeHeader] // 0x00000001801355D0-0x0000000180135650
	// [StaticAccessor] // 0x00000001801355D0-0x0000000180135650
	public sealed class Screen // TypeDefIndex: 3137
	{
		// Properties
		public static int width { [NativeMethod] /* 0x00000001801358B0-0x00000001801358F0 */ get => default; } // 0x00000001808DAE20-0x00000001808DAE50 
		public static int height { [NativeMethod] /* 0x0000000180135970-0x00000001801359B0 */ get => default; } // 0x00000001808DADC0-0x00000001808DADF0 
		public static float dpi { /* [NativeName] */ /* 0x0000000180135A90-0x0000000180135AC0 */ get => default; } // 0x00000001808DAD60-0x00000001808DAD90 
		public static ScreenOrientation orientation { get => default; } // 0x00000001808DAC00-0x00000001808DAC30 
		public static FullScreenMode fullScreenMode { /* [NativeName] */ /* 0x0000000180135BA0-0x0000000180135BD0 */ get => default; } // 0x00000001808DAD90-0x00000001808DADC0 
		public static Resolution[] resolutions { [FreeFunction] /* 0x0000000180135F20-0x0000000180135F50 */ get => default; } // 0x00000001808DADF0-0x00000001808DAE20 
	
		// Constructors
		public Screen() {} // Dummy constructor
	
		// Methods
		private static ScreenOrientation GetScreenOrientation() => default; // 0x00000001808DAC00-0x00000001808DAC30
		// [NativeName] // 0x0000000180135CB0-0x0000000180135CE0
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, [DefaultValue] /* 0x00000001800DEB90-0x00000001800DEBC0 */ int preferredRefreshRate) {} // 0x00000001808DAC30-0x00000001808DAC90
		public static void SetResolution(int width, int height, bool fullscreen, [DefaultValue] /* 0x00000001800DEB90-0x00000001800DEBC0 */ int preferredRefreshRate) {} // 0x00000001808DAC90-0x00000001808DAD00
		public static void SetResolution(int width, int height, bool fullscreen) {} // 0x00000001808DAD00-0x00000001808DAD60
	}
}
