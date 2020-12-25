/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace LIV.SDK.Unity
{
	public struct SDKPose // TypeDefIndex: 8599
	{
		// Fields
		public SDKMatrix4x4 projectionMatrix; // 0x00
		public SDKVector3 localPosition; // 0x40
		public SDKQuaternion localRotation; // 0x4C
		public float verticalFieldOfView; // 0x5C
		public float nearClipPlane; // 0x60
		public float farClipPlane; // 0x64
		public int width; // 0x68
		public int height; // 0x6C
	
		// Properties
		public static SDKPose empty { get => default; } // 0x0000000181135B10-0x0000000181135EC0 
	
		// Methods
		public override string ToString() => default; // 0x00000001801EA290-0x00000001801EA2A0
	}
}
