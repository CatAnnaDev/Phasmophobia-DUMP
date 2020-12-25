/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 8: UnityEngine.PhysicsModule.dll - Assembly: UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3646-3679

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180134170-0x00000001801341C0
	[UsedByNativeCode] // 0x0000000180134170-0x00000001801341C0
	public struct ContactPoint // TypeDefIndex: 3677
	{
		// Fields
		internal Vector3 m_Point; // 0x00
		internal Vector3 m_Normal; // 0x0C
		internal int m_ThisColliderInstanceID; // 0x18
		internal int m_OtherColliderInstanceID; // 0x1C
		internal float m_Separation; // 0x20
	
		// Properties
		public Vector3 point { get => default; } // 0x000000018003AEA0-0x000000018003AEE0 
		public Vector3 normal { get => default; } // 0x000000018003BEB0-0x000000018003BED0 
		public Collider thisCollider { get => default; } // 0x0000000180049800-0x0000000180049860 
	
		// Methods
		[FreeFunction] // 0x00000001800F2910-0x00000001800F2920
		private static Collider GetColliderByInstanceID(int instanceID) => default; // 0x0000000180ACB030-0x0000000180ACB0B0
	}
}
