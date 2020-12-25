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
	public class Constraints // TypeDefIndex: 6675
	{
		// Fields
		public Transform transform; // 0x10
		public Transform target; // 0x18
		public Vector3 positionOffset; // 0x20
		public Vector3 position; // 0x2C
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float positionWeight; // 0x38
		public Vector3 rotationOffset; // 0x3C
		public Vector3 rotation; // 0x48
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float rotationWeight; // 0x54
	
		// Constructors
		public Constraints() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		public bool IsValid() => default; // 0x0000000180524710-0x0000000180524770
		public void Initiate(Transform transform) {} // 0x0000000180524690-0x0000000180524710
		public void Update() {} // 0x0000000180524770-0x0000000180524BC0
	}
}
