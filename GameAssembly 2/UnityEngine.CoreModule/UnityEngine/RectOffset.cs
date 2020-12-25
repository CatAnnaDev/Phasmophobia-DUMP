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
	[Serializable]
	// [NativeHeader] // 0x0000000180132AC0-0x0000000180132B00
	[UsedByNativeCode] // 0x0000000180132AC0-0x0000000180132B00
	public class RectOffset // TypeDefIndex: 3128
	{
		// Fields
		[NonSerialized]
		[VisibleToOtherModules] // 0x0000000180132BA0-0x0000000180132C20
		internal IntPtr m_Ptr; // 0x10
		private readonly object m_SourceStyle; // 0x18
	
		// Properties
		[NativeProperty] // 0x0000000180132F70-0x0000000180132FB0
		public int left { get => default; } // 0x0000000180943DE0-0x0000000180943E20 
		[NativeProperty] // 0x0000000180133020-0x0000000180133060
		public int right { get => default; } // 0x0000000180943E20-0x0000000180943E60 
		[NativeProperty] // 0x0000000180133060-0x00000001801330A0
		public int top { get => default; } // 0x0000000180943E60-0x0000000180943EA0 
		[NativeProperty] // 0x00000001801331B0-0x00000001801331F0
		public int bottom { get => default; } // 0x0000000180943D60-0x0000000180943DA0 
		public int horizontal { get => default; } // 0x0000000180943DA0-0x0000000180943DE0 
		public int vertical { get => default; } // 0x0000000180943EA0-0x0000000180943EE0 
	
		// Constructors
		public RectOffset() {} // 0x0000000180943D20-0x0000000180943D60
		[VisibleToOtherModules] // 0x0000000180132D00-0x0000000180132D80
		internal RectOffset(object sourceStyle, IntPtr source) {} // 0x0000000180943CD0-0x0000000180943D20
	
		// Methods
		~RectOffset() {} // 0x00000001809437E0-0x00000001809438D0
		public override string ToString() => default; // 0x0000000180943A10-0x0000000180943CD0
		private void Destroy() {} // 0x0000000180943760-0x00000001809437E0
		[ThreadAndSerializationSafe] // 0x00000001800D4E50-0x00000001800D4E60
		private static IntPtr InternalCreate() => default; // 0x00000001809438D0-0x0000000180943900
		[ThreadAndSerializationSafe] // 0x00000001800D4E50-0x00000001800D4E60
		private static void InternalDestroy(IntPtr ptr) {} // 0x0000000180943900-0x0000000180943940
		public Rect Add(Rect rect) => default; // 0x00000001809436F0-0x0000000180943760
		public Rect Remove(Rect rect) => default; // 0x00000001809439A0-0x0000000180943A10
		private void Add_Injected(ref Rect rect, out Rect ret) {
			ret = default;
		} // 0x0000000180943690-0x00000001809436F0
		private void Remove_Injected(ref Rect rect, out Rect ret) {
			ret = default;
		} // 0x0000000180943940-0x00000001809439A0
	}
}
