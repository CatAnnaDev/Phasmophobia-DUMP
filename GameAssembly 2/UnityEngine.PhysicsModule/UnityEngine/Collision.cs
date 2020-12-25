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
	public class Collision // TypeDefIndex: 3656
	{
		// Fields
		internal Vector3 m_Impulse; // 0x10
		internal Vector3 m_RelativeVelocity; // 0x1C
		internal Rigidbody m_Rigidbody; // 0x28
		internal Collider m_Collider; // 0x30
		internal int m_ContactCount; // 0x38
		internal ContactPoint[] m_ReusedContacts; // 0x40
		internal ContactPoint[] m_LegacyContacts; // 0x48
	
		// Properties
		public Vector3 relativeVelocity { get => default; } // 0x0000000180ACA7C0-0x0000000180ACA7E0 
		public Collider collider { get => default; } // 0x00000001802DEAD0-0x00000001802DEAE0 
		public GameObject gameObject { get => default; } // 0x0000000180ACA730-0x0000000180ACA7C0 
		public ContactPoint[] contacts { get => default; } // 0x0000000180ACA6B0-0x0000000180ACA730 
	
		// Constructors
		public Collision() {} // Dummy constructor
	}
}
