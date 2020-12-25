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
	// [NativeHeader] // 0x00000001801401D0-0x0000000180140230
	// [NativeHeader] // 0x00000001801401D0-0x0000000180140230
	public sealed class LineRenderer : Renderer // TypeDefIndex: 3153
	{
		// Properties
		public float startWidth { set {} } // 0x0000000180930740-0x0000000180930790
		public float endWidth { set {} } // 0x0000000180930610-0x0000000180930660
		public bool useWorldSpace { set {} } // 0x0000000180930790-0x00000001809307E0
		public Color startColor { set {} } // 0x00000001809306F0-0x0000000180930740
		public Color endColor { set {} } // 0x00000001809305C0-0x0000000180930610
		[NativeProperty] // 0x0000000180140440-0x0000000180140470
		public int positionCount { get => default; set {} } // 0x0000000180930530-0x0000000180930570 0x0000000180930660-0x00000001809306A0
	
		// Constructors
		public LineRenderer() {} // Dummy constructor
	
		// Methods
		public void SetPosition(int index, Vector3 position) {} // 0x00000001809304E0-0x0000000180930530
		public Vector3 GetPosition(int index) => default; // 0x0000000180930410-0x0000000180930490
		private void set_startColor_Injected(ref Color value) {} // 0x00000001809306A0-0x00000001809306F0
		private void set_endColor_Injected(ref Color value) {} // 0x0000000180930570-0x00000001809305C0
		private void SetPosition_Injected(int index, ref Vector3 position) {} // 0x0000000180930490-0x00000001809304E0
		private void GetPosition_Injected(int index, out Vector3 ret) {
			ret = default;
		} // 0x00000001809303C0-0x0000000180930410
	}
}
