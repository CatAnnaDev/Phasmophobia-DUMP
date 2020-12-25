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
	// [NativeHeader] // 0x00000001800EA2B0-0x00000001800EA300
	[RequiredByNativeCode] // 0x00000001800EA2B0-0x00000001800EA300
	public class Gradient : IEquatable<UnityEngine.Gradient> // TypeDefIndex: 3220
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Properties
		public GradientColorKey[] colorKeys { [FreeFunction] /* 0x00000001800EB9F0-0x00000001800EBA30 */ set {} } // 0x000000018096B1D0-0x000000018096B220
	
		// Constructors
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		public Gradient() {} // 0x000000018096B190-0x000000018096B1D0
	
		// Methods
		[FreeFunction] // 0x00000001800EA360-0x00000001800EA3A0
		private static IntPtr Init() => default; // 0x000000018096B110-0x000000018096B140
		[FreeFunction] // 0x00000001800EA490-0x00000001800EA4D0
		private void Cleanup() {} // 0x000000018096AD50-0x000000018096AD90
		[FreeFunction] // 0x00000001800EA530-0x00000001800EA570
		private bool Internal_Equals(IntPtr other) => default; // 0x000000018096B140-0x000000018096B190
		~Gradient() {} // 0x000000018096B060-0x000000018096B110
		[FreeFunction] // 0x00000001800EA6B0-0x00000001800EA6F0
		public Color Evaluate(float time) => default; // 0x000000018096AFF0-0x000000018096B060
		public override bool Equals(object o) => default; // 0x000000018096AD90-0x000000018096AED0
		public bool Equals(Gradient other) => default; // 0x000000018096AED0-0x000000018096AF90
		public override int GetHashCode() => default; // 0x000000018095BCE0-0x000000018095BCF0
		private void Evaluate_Injected(float time, out Color ret) {
			ret = default;
		} // 0x000000018096AF90-0x000000018096AFF0
	}
}
