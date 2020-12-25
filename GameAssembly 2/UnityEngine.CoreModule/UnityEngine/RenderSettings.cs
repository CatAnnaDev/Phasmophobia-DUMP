/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001801469B0-0x0000000180146A60
	// [NativeHeader] // 0x00000001801469B0-0x0000000180146A60
	// [NativeHeader] // 0x00000001801469B0-0x0000000180146A60
	// [StaticAccessor] // 0x00000001801469B0-0x0000000180146A60
	public sealed class RenderSettings : Object // TypeDefIndex: 3156
	{
		// Properties
		[NativeProperty] // 0x0000000180146BD0-0x0000000180146C00
		public static bool fog { get => default; set {} } // 0x0000000180946800-0x0000000180946830 0x00000001809468E0-0x0000000180946920
		[NativeProperty] // 0x0000000180146C90-0x0000000180146CC0
		public static float fogStartDistance { get => default; } // 0x00000001809467D0-0x0000000180946800 
		[NativeProperty] // 0x0000000180146E40-0x0000000180146E70
		public static float fogEndDistance { get => default; } // 0x0000000180946770-0x00000001809467A0 
		public static FogMode fogMode { get => default; } // 0x00000001809467A0-0x00000001809467D0 
		public static Color fogColor { get => default; set {} } // 0x00000001809466F0-0x0000000180946740 0x00000001809468A0-0x00000001809468E0
		public static float fogDensity { get => default; } // 0x0000000180946740-0x0000000180946770 
		public static AmbientMode ambientMode { get => default; } // 0x0000000180946510-0x0000000180946540 
		public static Color ambientSkyColor { get => default; } // 0x0000000180946660-0x00000001809466B0 
		public static Color ambientEquatorColor { get => default; } // 0x0000000180946400-0x0000000180946450 
		public static Color ambientGroundColor { get => default; } // 0x0000000180946490-0x00000001809464E0 
		public static float ambientIntensity { get => default; } // 0x00000001809464E0-0x0000000180946510 
		[NativeProperty] // 0x0000000180147020-0x0000000180147050
		public static Material skybox { get => default; } // 0x0000000180946830-0x0000000180946860 
		public static SphericalHarmonicsL2 ambientProbe { get => default; } // 0x0000000180946580-0x0000000180946620 
	
		// Constructors
		public RenderSettings() {} // Dummy constructor
	
		// Methods
		private static void get_fogColor_Injected(out Color ret) {
			ret = default;
		} // 0x00000001809466B0-0x00000001809466F0
		private static void set_fogColor_Injected(ref Color value) {} // 0x0000000180946860-0x00000001809468A0
		private static void get_ambientSkyColor_Injected(out Color ret) {
			ret = default;
		} // 0x0000000180946620-0x0000000180946660
		private static void get_ambientEquatorColor_Injected(out Color ret) {
			ret = default;
		} // 0x00000001809463C0-0x0000000180946400
		private static void get_ambientGroundColor_Injected(out Color ret) {
			ret = default;
		} // 0x0000000180946450-0x0000000180946490
		private static void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret) {
			ret = default;
		} // 0x0000000180946540-0x0000000180946580
	}
}
