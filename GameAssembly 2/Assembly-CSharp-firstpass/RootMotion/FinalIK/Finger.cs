/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.FinalIK
{
	[Serializable]
	public class Finger // TypeDefIndex: 6676
	{
		// Fields
		// [Range] // 0x0000000180138100-0x0000000180138160
		// [Tooltip] // 0x0000000180138100-0x0000000180138160
		public float weight; // 0x10
		// [Range] // 0x00000001801381E0-0x0000000180138240
		// [Tooltip] // 0x00000001801381E0-0x0000000180138240
		public float rotationWeight; // 0x14
		// [Tooltip] // 0x0000000180138730-0x0000000180138760
		public DOF rotationDOF; // 0x18
		// [Tooltip] // 0x0000000180138790-0x00000001801387C0
		public Transform bone1; // 0x20
		// [Tooltip] // 0x0000000180138820-0x0000000180138850
		public Transform bone2; // 0x28
		// [Tooltip] // 0x0000000180138920-0x0000000180138950
		public Transform bone3; // 0x30
		// [Tooltip] // 0x0000000180138B80-0x0000000180138BB0
		public Transform tip; // 0x38
		// [Tooltip] // 0x0000000180138C90-0x0000000180138CC0
		public Transform target; // 0x40
		private IKSolverLimb solver; // 0x50
		private Quaternion bone3RelativeToTarget; // 0x58
		private Vector3 bone3DefaultLocalPosition; // 0x68
		private Quaternion bone3DefaultLocalRotation; // 0x74
		private Vector3 bone1Axis; // 0x84
		private Vector3 tipAxis; // 0x90
	
		// Properties
		public bool initiated { get; private set; } // 0x00000001802968B0-0x00000001802968C0 0x00000001802FF720-0x00000001802FF790
		public Vector3 IKPosition { get => default; set {} } // 0x0000000180530CE0-0x0000000180530D10 0x0000000180530D40-0x0000000180530D70
		public Quaternion IKRotation { get => default; set {} } // 0x0000000180530D10-0x0000000180530D40 0x0000000180530D70-0x0000000180530D90
	
		// Nested types
		[Serializable]
		public enum DOF // TypeDefIndex: 6677
		{
			One = 0,
			Three = 1
		}
	
		// Constructors
		public Finger() {} // 0x0000000180530CC0-0x0000000180530CE0
	
		// Methods
		public bool IsValid(ref string errorMessage) => default; // 0x0000000180530770-0x0000000180530880
		public void Initiate(Transform hand, int index) {} // 0x0000000180530260-0x0000000180530770
		public void FixTransforms() {} // 0x0000000180530180-0x0000000180530260
		public void Update(float masterWeight) {} // 0x0000000180530880-0x0000000180530CC0
	}
}
