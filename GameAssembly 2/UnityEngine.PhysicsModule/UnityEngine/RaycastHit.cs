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
	// [NativeHeader] // 0x0000000180131760-0x00000001801317F0
	// [NativeHeader] // 0x0000000180131760-0x00000001801317F0
	// [NativeHeader] // 0x0000000180131760-0x00000001801317F0
	[UsedByNativeCode] // 0x0000000180131760-0x00000001801317F0
	public struct RaycastHit // TypeDefIndex: 3662
	{
		// Fields
		// [NativeName] // 0x00000001801137D0-0x0000000180113800
		internal Vector3 m_Point; // 0x00
		// [NativeName] // 0x0000000180113890-0x00000001801138C0
		internal Vector3 m_Normal; // 0x0C
		// [NativeName] // 0x0000000180131B80-0x0000000180131BB0
		internal uint m_FaceID; // 0x18
		// [NativeName] // 0x0000000180113F40-0x0000000180113F70
		internal float m_Distance; // 0x1C
		// [NativeName] // 0x0000000180131CE0-0x0000000180131D10
		internal Vector2 m_UV; // 0x20
		// [NativeName] // 0x0000000180113B10-0x0000000180113B40
		internal int m_Collider; // 0x28
	
		// Properties
		public Collider collider { get => default; } // 0x0000000180049DC0-0x0000000180049DD0 
		public Vector3 point { get => default; set {} } // 0x000000018003AEA0-0x000000018003AEE0 0x000000018003BF20-0x000000018003BF30
		public Vector3 normal { get => default; set {} } // 0x000000018003BEB0-0x000000018003BED0 0x00000001800437A0-0x00000001800437B0
		public float distance { get => default; set {} } // 0x0000000180049DD0-0x0000000180049DE0 0x0000000180049EF0-0x0000000180049F40
		public Transform transform { get => default; } // 0x0000000180049DF0-0x0000000180049EF0 
		public Rigidbody rigidbody { get => default; } // 0x0000000180049DE0-0x0000000180049DF0 
	}
}
