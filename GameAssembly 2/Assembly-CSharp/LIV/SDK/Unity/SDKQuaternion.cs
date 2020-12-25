/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace LIV.SDK.Unity
{
	public struct SDKQuaternion // TypeDefIndex: 8587
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public float w; // 0x0C
	
		// Properties
		public static SDKQuaternion identity { get => default; } // 0x00000001811362B0-0x00000001811362C0 
	
		// Methods
		public static implicit operator Quaternion(SDKQuaternion v) => default; // 0x00000001811362C0-0x0000000181136300
		public static implicit operator SDKQuaternion(Quaternion v) => default; // 0x0000000181136300-0x0000000181136340
		public static SDKQuaternion Euler(float pitch, float yaw, float roll) => default; // 0x0000000181135EE0-0x00000001811362B0
		public static SDKQuaternion operator *(SDKQuaternion lhs, SDKQuaternion rhs) => default; // 0x0000000181136340-0x00000001811364E0
		public static SDKVector3 operator *(SDKQuaternion lhs, SDKVector3 rhs) => default; // 0x00000001811364E0-0x00000001811366D0
		public override string ToString() => default; // 0x00000001801EA2B0-0x00000001801EA2C0
	}
}
