/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.Utility
{
	public class CameraRefocus // TypeDefIndex: 5856
	{
		// Fields
		public Camera Camera; // 0x10
		public Vector3 Lookatpoint; // 0x18
		public Transform Parent; // 0x28
		private Vector3 m_OrigCameraPos; // 0x30
		private bool m_Refocus; // 0x3C
	
		// Constructors
		public CameraRefocus() {} // Dummy constructor
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos) {} // 0x0000000180A37870-0x0000000180A378E0
	
		// Methods
		public void ChangeCamera(Camera camera) {} // 0x0000000180248410-0x0000000180248420
		public void ChangeParent(Transform parent) {} // 0x0000000180249810-0x0000000180249820
		public void GetFocusPoint() {} // 0x0000000180A37650-0x0000000180A37810
		public void SetFocusPoint() {} // 0x0000000180A37810-0x0000000180A37870
	}
}
