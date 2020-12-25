/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityStandardAssets.Utility;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.Characters.FirstPerson
{
	public class HeadBob : MonoBehaviour // TypeDefIndex: 6065
	{
		// Fields
		public Camera Camera; // 0x18
		public CurveControlledBob motionBob; // 0x20
		public LerpControlledBob jumpAndLandingBob; // 0x28
		public RigidbodyFirstPersonController rigidbodyFirstPersonController; // 0x30
		public float StrideInterval; // 0x38
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float RunningStrideLengthen; // 0x3C
		private bool m_PreviouslyGrounded; // 0x40
		private Vector3 m_OriginalCameraPosition; // 0x44
	
		// Constructors
		public HeadBob() {} // 0x0000000180832200-0x0000000180832290
	
		// Methods
		private void Start() {} // 0x0000000180831EA0-0x0000000180831F10
		private void Update() {} // 0x0000000180831F10-0x0000000180832200
	}
}
