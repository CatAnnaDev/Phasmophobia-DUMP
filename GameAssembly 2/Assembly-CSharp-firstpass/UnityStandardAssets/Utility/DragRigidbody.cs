/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.Utility
{
	public class DragRigidbody : MonoBehaviour // TypeDefIndex: 5858
	{
		// Fields
		private const float k_Spring = 50f; // Metadata: 0x00650764
		private const float k_Damper = 5f; // Metadata: 0x00650768
		private const float k_Drag = 10f; // Metadata: 0x0065076C
		private const float k_AngularDrag = 5f; // Metadata: 0x00650770
		private const float k_Distance = 0.2f; // Metadata: 0x00650774
		private const bool k_AttachToCenterOfMass = false; // Metadata: 0x00650778
		private SpringJoint m_SpringJoint; // 0x18
	
		// Constructors
		public DragRigidbody() {} // 0x0000000180276E90-0x0000000180276EA0
	
		// Methods
		private void Update() {} // 0x0000000180A3D340-0x0000000180A3D760
		// [IteratorStateMachine] // 0x00000001800F40B0-0x00000001800F4100
		private IEnumerator DragObject(float distance) => default; // 0x0000000180A3D230-0x0000000180A3D2B0
		private Camera FindCamera() => default; // 0x0000000180A3D2B0-0x0000000180A3D340
	}
}
