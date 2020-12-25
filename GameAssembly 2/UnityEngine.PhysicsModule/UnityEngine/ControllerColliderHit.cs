/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting;

// Image 8: UnityEngine.PhysicsModule.dll - Assembly: UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3646-3679

namespace UnityEngine
{
	[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
	public class ControllerColliderHit // TypeDefIndex: 3654
	{
		// Fields
		internal CharacterController m_Controller; // 0x10
		internal Collider m_Collider; // 0x18
		internal Vector3 m_Point; // 0x20
		internal Vector3 m_Normal; // 0x2C
		internal Vector3 m_MoveDirection; // 0x38
		internal float m_MoveLength; // 0x44
		internal int m_Push; // 0x48
	
		// Properties
		public Collider collider { get => default; } // 0x00000001809302F0-0x0000000180930300 
		public Vector3 point { get => default; } // 0x0000000180ACB0B0-0x0000000180ACB0D0 
	
		// Constructors
		public ControllerColliderHit() {} // Dummy constructor
	}
}
