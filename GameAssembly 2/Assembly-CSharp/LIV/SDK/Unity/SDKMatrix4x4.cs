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
	public struct SDKMatrix4x4 // TypeDefIndex: 8588
	{
		// Fields
		public float m00; // 0x00
		public float m01; // 0x04
		public float m02; // 0x08
		public float m03; // 0x0C
		public float m10; // 0x10
		public float m11; // 0x14
		public float m12; // 0x18
		public float m13; // 0x1C
		public float m20; // 0x20
		public float m21; // 0x24
		public float m22; // 0x28
		public float m23; // 0x2C
		public float m30; // 0x30
		public float m31; // 0x34
		public float m32; // 0x38
		public float m33; // 0x3C
	
		// Properties
		public static SDKMatrix4x4 identity { get => default; } // 0x000000018180C820-0x000000018180C850 
	
		// Methods
		public static implicit operator Matrix4x4(SDKMatrix4x4 v) => default; // 0x000000018180C850-0x000000018180C9D0
		public static implicit operator SDKMatrix4x4(Matrix4x4 v) => default; // 0x000000018180C9D0-0x000000018180CB40
		public static SDKMatrix4x4 Perspective(float vFov, float aspect, float zNear, float zFar) => default; // 0x000000018180B830-0x000000018180B9A0
		public static SDKMatrix4x4 operator *(SDKMatrix4x4 lhs, SDKMatrix4x4 rhs) => default; // 0x000000018180CC40-0x000000018180D170
		public static SDKVector3 operator *(SDKMatrix4x4 lhs, SDKVector3 rhs) => default; // 0x000000018180CB40-0x000000018180CC40
		public static SDKMatrix4x4 Translate(SDKVector3 value) => default; // 0x000000018180C770-0x000000018180C820
		public static SDKMatrix4x4 Rotate(SDKQuaternion value) => default; // 0x000000018180B9A0-0x000000018180BB70
		public static SDKMatrix4x4 Scale(SDKVector3 value) => default; // 0x000000018180BB70-0x000000018180BC10
		public static SDKMatrix4x4 TRS(SDKVector3 translation, SDKQuaternion rotation, SDKVector3 scale) => default; // 0x000000018180BC10-0x000000018180C770
		public override string ToString() => default; // 0x00000001802036E0-0x0000000180203860
	}
}
