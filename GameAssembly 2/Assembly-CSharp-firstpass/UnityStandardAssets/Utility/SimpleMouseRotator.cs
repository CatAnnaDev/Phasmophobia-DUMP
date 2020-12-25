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
	public class SimpleMouseRotator : MonoBehaviour // TypeDefIndex: 5873
	{
		// Fields
		public Vector2 rotationRange; // 0x18
		public float rotationSpeed; // 0x20
		public float dampingTime; // 0x24
		public bool autoZeroVerticalOnMobile; // 0x28
		public bool autoZeroHorizontalOnMobile; // 0x29
		public bool relative; // 0x2A
		private Vector3 m_TargetAngles; // 0x2C
		private Vector3 m_FollowAngles; // 0x38
		private Vector3 m_FollowVelocity; // 0x44
		private Quaternion m_OriginalRotation; // 0x50
	
		// Constructors
		public SimpleMouseRotator() {} // 0x0000000180A467F0-0x0000000180A468C0
	
		// Methods
		private void Start() {} // 0x0000000180A46360-0x0000000180A463A0
		private void Update() {} // 0x0000000180A463A0-0x0000000180A467F0
	}
}
