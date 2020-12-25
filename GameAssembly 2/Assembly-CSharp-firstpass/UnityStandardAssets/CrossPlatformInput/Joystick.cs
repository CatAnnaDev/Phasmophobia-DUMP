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
	public class Joystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 6051
	{
		// Fields
		public int MovementRange; // 0x18
		public AxisOption axesToUse; // 0x1C
		public string horizontalAxisName; // 0x20
		public string verticalAxisName; // 0x28
		private Vector3 m_StartPos; // 0x30
		private bool m_UseX; // 0x3C
		private bool m_UseY; // 0x3D
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis; // 0x40
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis; // 0x48
	
		// Nested types
		public enum AxisOption // TypeDefIndex: 6052
		{
			Both = 0,
			OnlyHorizontal = 1,
			OnlyVertical = 2
		}
	
		// Constructors
		public Joystick() {} // 0x00000001806230F0-0x0000000180623150
	
		// Methods
		private void OnEnable() {} // 0x0000000180622A90-0x0000000180622BF0
		private void Start() {} // 0x0000000180622F60-0x0000000180622FA0
		private void UpdateVirtualAxes(Vector3 value) {} // 0x0000000180622FA0-0x00000001806230F0
		private void CreateVirtualAxes() {} // 0x0000000180622A90-0x0000000180622BF0
		public void OnDrag(PointerEventData data) {} // 0x0000000180622CC0-0x0000000180622EF0
		public void OnPointerUp(PointerEventData data) {} // 0x0000000180622EF0-0x0000000180622F60
		public void OnPointerDown(PointerEventData data) {} // 0x0000000180246DB0-0x0000000180246DC0
		private void OnDisable() {} // 0x0000000180622BF0-0x0000000180622CC0
	}
}
