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
	// [NativeClass] // 0x0000000180107330-0x0000000180107390
	// [NativeHeader] // 0x0000000180107330-0x0000000180107390
	public sealed class RectTransform : Transform // TypeDefIndex: 3322
	{
		// Properties
		public Rect rect { get => default; } // 0x0000000180944DD0-0x0000000180944E30 
		public Vector2 anchorMin { get => default; set {} } // 0x0000000180944AC0-0x0000000180944B10 0x0000000180945060-0x00000001809450A0
		public Vector2 anchorMax { get => default; set {} } // 0x0000000180944A20-0x0000000180944A70 0x0000000180944FD0-0x0000000180945010
		public Vector2 anchoredPosition { get => default; set {} } // 0x0000000180944B60-0x0000000180944BB0 0x00000001809450F0-0x0000000180945130
		public Vector2 sizeDelta { get => default; set {} } // 0x0000000180944E80-0x0000000180944ED0 0x00000001809456F0-0x0000000180945970
		public Vector2 pivot { get => default; set {} } // 0x0000000180944D30-0x0000000180944D80 0x0000000180945660-0x00000001809456A0
		public Vector2 offsetMin { set {} } // 0x00000001809453A0-0x0000000180945610
		public Vector2 offsetMax { get => default; set {} } // 0x0000000180944BB0-0x0000000180944CE0 0x0000000180945130-0x00000001809453A0
	
		// Events
		public static event ReapplyDrivenProperties reapplyDrivenProperties;
	
		// Nested types
		public enum Axis // TypeDefIndex: 3323
		{
			Horizontal = 0,
			Vertical = 1
		}
	
		public delegate void ReapplyDrivenProperties(RectTransform driven); // TypeDefIndex: 3324; 0x000000018070A7F0-0x000000018070AB70
	
		// Constructors
		public RectTransform() {} // Dummy constructor
	
		// Methods
		public void GetLocalCorners(Vector3[] fourCornersArray) {} // 0x0000000180943EE0-0x0000000180944110
		public void GetWorldCorners(Vector3[] fourCornersArray) {} // 0x00000001809442C0-0x00000001809445B0
		public void SetSizeWithCurrentAnchors(Axis axis, float size) {} // 0x0000000180944600-0x0000000180944920
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void SendReapplyDrivenProperties(RectTransform driven) {} // 0x00000001809445B0-0x0000000180944600
		private Vector2 GetParentSize() => default; // 0x0000000180944110-0x00000001809442C0
		private void get_rect_Injected(out Rect ret) {
			ret = default;
		} // 0x0000000180944D80-0x0000000180944DD0
		private void get_anchorMin_Injected(out Vector2 ret) {
			ret = default;
		} // 0x0000000180944A70-0x0000000180944AC0
		private void set_anchorMin_Injected(ref Vector2 value) {} // 0x0000000180945010-0x0000000180945060
		private void get_anchorMax_Injected(out Vector2 ret) {
			ret = default;
		} // 0x00000001809449D0-0x0000000180944A20
		private void set_anchorMax_Injected(ref Vector2 value) {} // 0x0000000180944F80-0x0000000180944FD0
		private void get_anchoredPosition_Injected(out Vector2 ret) {
			ret = default;
		} // 0x0000000180944B10-0x0000000180944B60
		private void set_anchoredPosition_Injected(ref Vector2 value) {} // 0x00000001809450A0-0x00000001809450F0
		private void get_sizeDelta_Injected(out Vector2 ret) {
			ret = default;
		} // 0x0000000180944E30-0x0000000180944E80
		private void set_sizeDelta_Injected(ref Vector2 value) {} // 0x00000001809456A0-0x00000001809456F0
		private void get_pivot_Injected(out Vector2 ret) {
			ret = default;
		} // 0x0000000180944CE0-0x0000000180944D30
		private void set_pivot_Injected(ref Vector2 value) {} // 0x0000000180945610-0x0000000180945660
	}
}
