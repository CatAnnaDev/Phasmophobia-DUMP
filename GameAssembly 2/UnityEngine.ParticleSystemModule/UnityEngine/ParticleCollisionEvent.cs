/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 28: UnityEngine.ParticleSystemModule.dll - Assembly: UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3950-3964

namespace UnityEngine
{
	[RequiredByNativeCode] // 0x00000001800D8420-0x00000001800D8450
	public struct ParticleCollisionEvent // TypeDefIndex: 3963
	{
		// Fields
		internal Vector3 m_Intersection; // 0x00
		internal Vector3 m_Normal; // 0x0C
		internal Vector3 m_Velocity; // 0x18
		internal int m_ColliderInstanceID; // 0x24
	
		// Properties
		public Vector3 velocity { get => default; } // 0x000000018004E820-0x000000018004E840 
		public Component colliderComponent { get => default; } // 0x000000018004E7E0-0x000000018004E820 
	
		// Methods
		[FreeFunction] // 0x00000001800F9C10-0x00000001800F9C50
		private static Component InstanceIDToColliderComponent(int instanceID) => default; // 0x0000000180AF23A0-0x0000000180AF2440
	}
}
