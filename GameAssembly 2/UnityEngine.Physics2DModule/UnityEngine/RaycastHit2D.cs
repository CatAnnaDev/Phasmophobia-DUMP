/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 16: UnityEngine.Physics2DModule.dll - Assembly: UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3789-3798

namespace UnityEngine
{
	// [NativeClass] // 0x0000000180113D60-0x0000000180113DF0
	// [NativeHeader] // 0x0000000180113D60-0x0000000180113DF0
	[RequiredByNativeCode] // 0x0000000180113D60-0x0000000180113DF0
	public struct RaycastHit2D // TypeDefIndex: 3796
	{
		// Fields
		// [NativeName] // 0x0000000180113E80-0x0000000180113EB0
		private Vector2 m_Centroid; // 0x00
		// [NativeName] // 0x00000001801137D0-0x0000000180113800
		private Vector2 m_Point; // 0x08
		// [NativeName] // 0x0000000180113890-0x00000001801138C0
		private Vector2 m_Normal; // 0x10
		// [NativeName] // 0x0000000180113F40-0x0000000180113F70
		private float m_Distance; // 0x18
		// [NativeName] // 0x0000000180113FE0-0x0000000180114010
		private float m_Fraction; // 0x1C
		// [NativeName] // 0x0000000180113B10-0x0000000180113B40
		private int m_Collider; // 0x20
	
		// Properties
		public Vector2 point { get => default; } // 0x000000018004E110-0x000000018004E130 
		public Vector2 normal { get => default; } // 0x000000018004E0F0-0x000000018004E110 
		public float distance { get => default; } // 0x000000018004E0E0-0x000000018004E0F0 
		public float fraction { get => default; } // 0x0000000180049DD0-0x0000000180049DE0 
		public Collider2D collider { get => default; } // 0x000000018004E030-0x000000018004E0E0 
	}
}
