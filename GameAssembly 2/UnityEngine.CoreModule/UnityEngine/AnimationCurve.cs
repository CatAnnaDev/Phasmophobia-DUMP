/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180126FC0-0x0000000180127030
	[RequiredByNativeCode] // 0x0000000180126FC0-0x0000000180127030
	public class AnimationCurve : IEquatable<UnityEngine.AnimationCurve> // TypeDefIndex: 3106
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Properties
		public Keyframe[] keys { get => default; set {} } // 0x000000018095BDD0-0x000000018095BE10 0x000000018095C110-0x000000018095C160
		public Keyframe this[int index] { get => default; } // 0x000000018095BD40-0x000000018095BDD0 
		public int length { [NativeMethod] /* 0x0000000180127580-0x00000001801275C0 */ get => default; } // 0x000000018095C1F0-0x000000018095C230 
	
		// Constructors
		public AnimationCurve(params /* 0x00000001800D4E50-0x00000001800D4E60 */ Keyframe[] keys) {} // 0x000000018095C1A0-0x000000018095C1F0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		public AnimationCurve() {} // 0x000000018095C160-0x000000018095C1A0
	
		// Methods
		[FreeFunction] // 0x00000001801270E0-0x0000000180127120
		private static void Internal_Destroy(IntPtr ptr) {} // 0x000000018095BE50-0x000000018095BE90
		[FreeFunction] // 0x0000000180127170-0x00000001801271B0
		private static IntPtr Internal_Create(Keyframe[] keys) => default; // 0x000000018095BE10-0x000000018095BE50
		[FreeFunction] // 0x00000001801272F0-0x0000000180127330
		private bool Internal_Equals(IntPtr other) => default; // 0x000000018095BE90-0x000000018095BEE0
		~AnimationCurve() {} // 0x000000018095BC20-0x000000018095BCE0
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		public float Evaluate(float time) => default; // 0x000000018095BBD0-0x000000018095BC20
		public int AddKey(Keyframe key) => default; // 0x000000018095B770-0x000000018095B7D0
		[NativeMethod] // 0x0000000180127460-0x00000001801274A0
		private int AddKey_Internal(Keyframe key) => default; // 0x000000018095B720-0x000000018095B770
		[FreeFunction] // 0x0000000180127B00-0x0000000180127B40
		private void SetKeys(Keyframe[] keys) {} // 0x000000018095C110-0x000000018095C160
		[FreeFunction] // 0x0000000180127B40-0x0000000180127B90
		[NativeThrows] // 0x0000000180127B40-0x0000000180127B90
		private Keyframe GetKey(int index) => default; // 0x000000018095BD40-0x000000018095BDD0
		[FreeFunction] // 0x0000000180127C70-0x0000000180127CB0
		private Keyframe[] GetKeys() => default; // 0x000000018095BDD0-0x000000018095BE10
		public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) => default; // 0x000000018095BEE0-0x000000018095C110
		public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) => default; // 0x000000018095B7D0-0x000000018095B9D0
		public override bool Equals(object o) => default; // 0x000000018095B9D0-0x000000018095BB10
		public bool Equals(AnimationCurve other) => default; // 0x000000018095BB10-0x000000018095BBD0
		public override int GetHashCode() => default; // 0x000000018095BCE0-0x000000018095BCF0
		private int AddKey_Internal_Injected(ref Keyframe key) => default; // 0x000000018095B6D0-0x000000018095B720
		private void GetKey_Injected(int index, out Keyframe ret) {
			ret = default;
		} // 0x000000018095BCF0-0x000000018095BD40
	}
}
