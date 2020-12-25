/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.CrossPlatformInput
{
	// [RequireComponent] // 0x0000000180113E30-0x0000000180113E80
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 6058
	{
		// Fields
		public AxisOption axesToUse; // 0x18
		public ControlStyle controlStyle; // 0x1C
		public string horizontalAxisName; // 0x20
		public string verticalAxisName; // 0x28
		public float Xsensitivity; // 0x30
		public float Ysensitivity; // 0x34
		private Vector3 m_StartPos; // 0x38
		private Vector2 m_PreviousDelta; // 0x44
		private Vector3 m_JoytickOutput; // 0x4C
		private bool m_UseX; // 0x58
		private bool m_UseY; // 0x59
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis; // 0x60
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis; // 0x68
		private bool m_Dragging; // 0x70
		private int m_Id; // 0x74
		private Vector2 m_PreviousTouchPos; // 0x78
		private Vector3 m_Center; // 0x80
		private Image m_Image; // 0x90
	
		// Nested types
		public enum AxisOption // TypeDefIndex: 6059
		{
			Both = 0,
			OnlyHorizontal = 1,
			OnlyVertical = 2
		}
	
		public enum ControlStyle // TypeDefIndex: 6060
		{
			Absolute = 0,
			Relative = 1,
			Swipe = 2
		}
	
		// Constructors
		public TouchPad() {} // 0x000000018062CF50-0x000000018062CFC0
	
		// Methods
		private void OnEnable() {} // 0x000000018062C7A0-0x000000018062C900
		private void Start() {} // 0x000000018062CB80-0x000000018062CC20
		private void CreateVirtualAxes() {} // 0x000000018062C7A0-0x000000018062C900
		private void UpdateVirtualAxes(Vector3 value) {} // 0x000000018062CC20-0x000000018062CCB0
		public void OnPointerDown(PointerEventData data) {} // 0x000000018062C9F0-0x000000018062CAB0
		private void Update() {} // 0x000000018062CCB0-0x000000018062CF50
		public void OnPointerUp(PointerEventData data) {} // 0x000000018062CAB0-0x000000018062CB80
		private void OnDisable() {} // 0x000000018062C900-0x000000018062C9F0
	}
}
