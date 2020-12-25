/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.CrossPlatformInput
{
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 6044
	{
		// Fields
		public string axisName; // 0x18
		public float axisValue; // 0x20
		public float responseSpeed; // 0x24
		public float returnToCentreSpeed; // 0x28
		private AxisTouchButton m_PairedWith; // 0x30
		private CrossPlatformInputManager.VirtualAxis m_Axis; // 0x38
	
		// Constructors
		public AxisTouchButton() {} // 0x00000001806164B0-0x0000000180616510
	
		// Methods
		private void OnEnable() {} // 0x00000001806160E0-0x00000001806162E0
		private void FindPairedButton() {} // 0x0000000180615ED0-0x0000000180616070
		private void OnDisable() {} // 0x0000000180616070-0x00000001806160E0
		public void OnPointerDown(PointerEventData data) {} // 0x00000001806162E0-0x00000001806163F0
		public void OnPointerUp(PointerEventData data) {} // 0x00000001806163F0-0x00000001806164B0
	}
}
