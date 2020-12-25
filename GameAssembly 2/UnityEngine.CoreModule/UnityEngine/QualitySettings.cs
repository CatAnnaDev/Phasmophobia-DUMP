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
	// [NativeHeader] // 0x000000018013DBA0-0x000000018013DC20
	// [NativeHeader] // 0x000000018013DBA0-0x000000018013DC20
	// [StaticAccessor] // 0x000000018013DBA0-0x000000018013DC20
	public sealed class QualitySettings : Object // TypeDefIndex: 3148
	{
		// Properties
		[NativeProperty] // 0x000000018013F660-0x000000018013F690
		public static ShadowQuality shadows { set {} } // 0x0000000180940BD0-0x0000000180940C10
		public static float shadowDistance { get => default; set {} } // 0x0000000180940A20-0x0000000180940A50 0x0000000180940B50-0x0000000180940B90
		[NativeProperty] // 0x000000018013F880-0x000000018013F8B0
		public static ShadowResolution shadowResolution { set {} } // 0x0000000180940B90-0x0000000180940BD0
		[NativeProperty] // 0x000000018013FA00-0x000000018013FA30
		public static AnisotropicFiltering anisotropicFiltering { set {} } // 0x0000000180940A50-0x0000000180940A90
		public static int masterTextureLimit { set {} } // 0x0000000180940AD0-0x0000000180940B10
		public static int vSyncCount { set {} } // 0x0000000180940C10-0x0000000180940C50
		public static int antiAliasing { get => default; set {} } // 0x00000001809409F0-0x0000000180940A20 0x0000000180940A90-0x0000000180940AD0
		// [StaticAccessor] // 0x000000018013FC00-0x000000018013FC30
		public static int maxQueuedFrames { set {} } // 0x0000000180940B10-0x0000000180940B50
		public static ColorSpace activeColorSpace { /* [StaticAccessor] */ /* 0x000000018013F380-0x000000018013F3E0 */ /* [NativeName] */ /* 0x000000018013F380-0x000000018013F3E0 */ get => default; } // 0x00000001809409C0-0x00000001809409F0 
	
		// Constructors
		public QualitySettings() {} // Dummy constructor
	
		// Methods
		// [NativeName] // 0x000000018013F0A0-0x000000018013F0D0
		public static void SetQualityLevel(int index, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool applyExpensiveChanges) {} // 0x0000000180940980-0x00000001809409C0
	}
}
