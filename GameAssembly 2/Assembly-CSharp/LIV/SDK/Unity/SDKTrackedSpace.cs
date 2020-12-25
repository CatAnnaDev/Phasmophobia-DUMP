/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace LIV.SDK.Unity
{
	public struct SDKTrackedSpace // TypeDefIndex: 8594
	{
		// Fields
		public SDKVector3 trackedSpaceWorldPosition; // 0x00
		public SDKQuaternion trackedSpaceWorldRotation; // 0x0C
		public SDKVector3 trackedSpaceLocalScale; // 0x1C
		public SDKMatrix4x4 trackedSpaceLocalToWorldMatrix; // 0x28
		public SDKMatrix4x4 trackedSpaceWorldToLocalMatrix; // 0x68
	
		// Properties
		public static SDKTrackedSpace empty { get => default; } // 0x000000018113BD30-0x000000018113BE70 
	
		// Methods
		public override string ToString() => default; // 0x00000001801EA2D0-0x00000001801EA2E0
	}
}
