/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 13: UnityEngine.IMGUIModule.dll - Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3731-3777

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800F4DF0-0x00000001800F4EB0
	// [NativeHeader] // 0x00000001800F4DF0-0x00000001800F4EB0
	[VisibleToOtherModules] // 0x00000001800F4DF0-0x00000001800F4EB0
	internal sealed class GUIClip // TypeDefIndex: 3741
	{
		// Properties
		internal static Rect visibleRect { [FreeFunction] /* 0x00000001800F5070-0x00000001800F50A0 */ get => default; } // 0x0000000180A1AE30-0x0000000180A1AE80 
	
		// Nested types
		[VisibleToOtherModules] // 0x00000001800F5C70-0x00000001800F5CF0
		internal struct ParentClipScope : IDisposable // TypeDefIndex: 3742
		{
			// Fields
			private bool m_Disposed; // 0x00
	
			// Constructors
			public ParentClipScope(Matrix4x4 objectTransform, Rect clipRect) {
				m_Disposed = default;
			} // 0x00000001800449D0-0x0000000180044A40
	
			// Methods
			public void Dispose() {} // 0x0000000180044990-0x00000001800449D0
		}
	
		// Constructors
		public GUIClip() {} // Dummy constructor
	
		// Methods
		[VisibleToOtherModules] // 0x00000001800F5180-0x00000001800F5200
		internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) {} // 0x0000000180A1ACB0-0x0000000180A1AD10
		[VisibleToOtherModules] // 0x00000001800F53A0-0x00000001800F5420
		internal static void Internal_Pop() {} // 0x0000000180A1AB70-0x0000000180A1ABA0
		[FreeFunction] // 0x00000001800F5500-0x00000001800F55A0
		[VisibleToOtherModules] // 0x00000001800F5500-0x00000001800F55A0
		internal static int Internal_GetCount() => default; // 0x0000000180A1AB10-0x0000000180A1AB40
		[FreeFunction] // 0x00000001800F5750-0x00000001800F57F0
		[VisibleToOtherModules] // 0x00000001800F5750-0x00000001800F57F0
		internal static Matrix4x4 GetMatrix() => default; // 0x0000000180A1AA90-0x0000000180A1AB10
		[VisibleToOtherModules] // 0x00000001800F5990-0x00000001800F5A10
		internal static void SetMatrix(Matrix4x4 m) {} // 0x0000000180A1ADB0-0x0000000180A1ADF0
		[VisibleToOtherModules] // 0x00000001800F5B00-0x00000001800F5B80
		internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) {} // 0x0000000180A1ABF0-0x0000000180A1AC40
		[VisibleToOtherModules] // 0x00000001800F5BC0-0x00000001800F5C40
		internal static void Internal_PopParentClip() {} // 0x0000000180A1AB40-0x0000000180A1AB70
		internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) {} // 0x0000000180A1AD10-0x0000000180A1AD70
		internal static void Pop() {} // 0x0000000180A1AB70-0x0000000180A1ABA0
		private static void get_visibleRect_Injected(out Rect ret) {
			ret = default;
		} // 0x0000000180A1ADF0-0x0000000180A1AE30
		private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) {} // 0x0000000180A1AC40-0x0000000180A1ACB0
		private static void GetMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000180A1AA50-0x0000000180A1AA90
		private static void SetMatrix_Injected(ref Matrix4x4 m) {} // 0x0000000180A1AD70-0x0000000180A1ADB0
		private static void Internal_PushParentClip_Injected(ref Matrix4x4 objectTransform, ref Rect clipRect) {} // 0x0000000180A1ABA0-0x0000000180A1ABF0
	}
}
