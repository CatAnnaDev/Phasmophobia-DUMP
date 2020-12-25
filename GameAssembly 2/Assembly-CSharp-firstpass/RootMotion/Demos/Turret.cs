/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.Demos
{
	public class Turret : MonoBehaviour // TypeDefIndex: 6649
	{
		// Fields
		public Transform target; // 0x18
		public Part[] parts; // 0x20
	
		// Nested types
		[Serializable]
		public class Part // TypeDefIndex: 6650
		{
			// Fields
			public Transform transform; // 0x10
			private RotationLimit rotationLimit; // 0x18
	
			// Constructors
			public Part() {} // 0x00000001802466A0-0x00000001802466B0
	
			// Methods
			public void AimAt(Transform target) {} // 0x00000001805399D0-0x0000000180539B10
		}
	
		// Constructors
		public Turret() {} // 0x0000000180276E90-0x0000000180276EA0
	
		// Methods
		private void Update() {} // 0x000000018053D130-0x000000018053D2E0
	}
}
