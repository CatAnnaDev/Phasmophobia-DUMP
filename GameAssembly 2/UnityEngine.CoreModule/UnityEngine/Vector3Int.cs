/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [DefaultMember] // 0x00000001800F0FB0-0x00000001800F1000
	[UsedByNativeCode] // 0x00000001800F0FB0-0x00000001800F1000
	public struct Vector3Int : IEquatable<UnityEngine.Vector3Int> // TypeDefIndex: 3227
	{
		// Fields
		private int m_X; // 0x00
		private int m_Y; // 0x04
		private int m_Z; // 0x08
		private static readonly Vector3Int s_Zero; // 0x00
		private static readonly Vector3Int s_One; // 0x0C
		private static readonly Vector3Int s_Up; // 0x18
		private static readonly Vector3Int s_Down; // 0x24
		private static readonly Vector3Int s_Left; // 0x30
		private static readonly Vector3Int s_Right; // 0x3C
	
		// Properties
		public int x { get => default; } // 0x0000000180005FD0-0x0000000180005FE0 
		public int y { get => default; } // 0x0000000180005D40-0x0000000180005D50 
		public int z { get => default; } // 0x0000000180006650-0x0000000180006660 
	
		// Constructors
		public Vector3Int(int x, int y, int z) : this() {
			m_X = default;
			m_Y = default;
			m_Z = default;
		} // 0x00000001800084C0-0x0000000180008520
		static Vector3Int() {
			s_Zero = default;
			s_One = default;
			s_Up = default;
			s_Down = default;
			s_Left = default;
			s_Right = default;
		} // 0x0000000180AC8620-0x0000000180AC8740
	
		// Methods
		public static bool operator ==(Vector3Int lhs, Vector3Int rhs) => default; // 0x0000000180AC8740-0x0000000180AC8AB0
		public override bool Equals(object other) => default; // 0x0000000180049200-0x0000000180049320
		public bool Equals(Vector3Int other) => default; // 0x0000000180049320-0x00000001800493D0
		public override int GetHashCode() => default; // 0x00000001800493D0-0x0000000180049450
		public override string ToString() => default; // 0x0000000180049450-0x0000000180049460
	}
}
