/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180134B60-0x0000000180134BB0
	[UsedByNativeCode] // 0x0000000180134B60-0x0000000180134BB0
	public class Display // TypeDefIndex: 3134
	{
		// Fields
		internal IntPtr nativeDisplay; // 0x10
		public static Display[] displays; // 0x00
		private static Display _mainDisplay; // 0x08
	
		// Properties
		public int renderingWidth { get => default; } // 0x0000000180968D90-0x0000000180968E20 
		public int renderingHeight { get => default; } // 0x0000000180968D00-0x0000000180968D90 
		public int systemWidth { get => default; } // 0x0000000180968EB0-0x0000000180968F40 
		public int systemHeight { get => default; } // 0x0000000180968E20-0x0000000180968EB0 
		public RenderBuffer colorBuffer { get => default; } // 0x0000000180968BF0-0x0000000180968CA0 
		public static Display main { get => default; } // 0x0000000180968CA0-0x0000000180968D00 
	
		// Nested types
		public delegate void DisplaysUpdatedDelegate(); // TypeDefIndex: 3135; 0x00000001802D1BD0-0x00000001802D1D60
	
		// Constructors
		internal Display() {} // 0x0000000180968B80-0x0000000180968BC0
		internal Display(IntPtr nativeDisplay) {} // 0x0000000180968BC0-0x0000000180968BF0
		static Display() {} // 0x0000000180968A20-0x0000000180968B80
	
		// Methods
		public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) => default; // 0x0000000180968930-0x0000000180968A20
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static void RecreateDisplayList(IntPtr[] nativeDisplay) {} // 0x0000000180968710-0x00000001809688D0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static void FireDisplaysUpdated() {} // 0x00000001809683C0-0x00000001809685F0
		[FreeFunction] // 0x00000001801350F0-0x0000000180135120
		private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) {
			w = default;
			h = default;
		} // 0x00000001809686B0-0x0000000180968710
		[FreeFunction] // 0x0000000180135210-0x0000000180135240
		private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) {
			w = default;
			h = default;
		} // 0x0000000180968650-0x00000001809686B0
		[FreeFunction] // 0x0000000180135340-0x0000000180135370
		private static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth) {
			color = default;
			depth = default;
		} // 0x00000001809685F0-0x0000000180968650
		[FreeFunction] // 0x00000001801354A0-0x00000001801354D0
		private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) {
			rx = default;
			ry = default;
			return default;
		} // 0x00000001809688D0-0x0000000180968930
	}
}
