/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace LIV.SDK.Unity
{
	public struct SDKInputFrame // TypeDefIndex: 8592
	{
		// Fields
		public SDKPose pose; // 0x00
		public SDKClipPlane clipPlane; // 0x70
		public SDKTransform stageTransform; // 0xBC
		public FEATURES features; // 0xE8
		public SDKClipPlane groundClipPlane; // 0xF0
		public ulong frameid; // 0x140
		public ulong referenceframe; // 0x148
		public SDKPriority priority; // 0x150
	
		// Properties
		public static SDKInputFrame empty { get => default; } // 0x000000018180B630-0x000000018180B830 
	
		// Methods
		public void ReleaseControl() {} // 0x00000001802036B0-0x00000001802036D0
		public void ObtainControl() {} // 0x0000000180203680-0x00000001802036B0
		public override string ToString() => default; // 0x00000001802036D0-0x00000001802036E0
	}
}
