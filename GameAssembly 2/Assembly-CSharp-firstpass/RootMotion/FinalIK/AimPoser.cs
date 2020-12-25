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
	public class AimPoser : MonoBehaviour // TypeDefIndex: 6790
	{
		// Fields
		public float angleBuffer; // 0x18
		public Pose[] poses; // 0x20
	
		// Nested types
		[Serializable]
		public class Pose // TypeDefIndex: 6791
		{
			// Fields
			public bool visualize; // 0x10
			public string name; // 0x18
			public Vector3 direction; // 0x20
			public float yaw; // 0x2C
			public float pitch; // 0x30
			private float angleBuffer; // 0x34
	
			// Constructors
			public Pose() {} // 0x000000018053AA20-0x000000018053AA40
	
			// Methods
			public bool IsInDirection(Vector3 d) => default; // 0x000000018053A6D0-0x000000018053AA20
			public void SetAngleBuffer(float value) {} // 0x0000000180482B00-0x0000000180483410
		}
	
		// Constructors
		public AimPoser() {} // 0x0000000180520CE0-0x0000000180520D40
	
		// Methods
		public Pose GetPose(Vector3 localDirection) => default; // 0x0000000180520B30-0x0000000180520C50
		public void SetPoseActive(Pose pose) {} // 0x0000000180520C50-0x0000000180520CE0
	}
}
