/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.Characters.FirstPerson
{
	[Serializable]
	public class MouseLook // TypeDefIndex: 6066
	{
		// Fields
		public float XSensitivity; // 0x10
		public float YSensitivity; // 0x14
		public bool clampVerticalRotation; // 0x18
		public float MinimumX; // 0x1C
		public float MaximumX; // 0x20
		public bool smooth; // 0x24
		public float smoothTime; // 0x28
		public bool lockCursor; // 0x2C
		private Quaternion m_CharacterTargetRot; // 0x30
		private Quaternion m_CameraTargetRot; // 0x40
		private bool m_cursorIsLocked; // 0x50
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public float horizontalLook; // 0x54
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public float verticalLook; // 0x58
	
		// Constructors
		public MouseLook() {} // 0x0000000180834030-0x0000000180834070
	
		// Methods
		public void Init(Transform character, Transform camera) {} // 0x0000000180833C90-0x0000000180833CF0
		public void LookRotation(Transform character, Transform camera) {} // 0x0000000180833CF0-0x0000000180834030
		private Quaternion ClampRotationAroundXAxis(Quaternion q) => default; // 0x0000000180833B90-0x0000000180833C90
	}
}
