/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public struct IVRResources // TypeDefIndex: 8195
	{
		// Fields
		internal _LoadSharedResource LoadSharedResource; // 0x00
		internal _GetResourceFullPath GetResourceFullPath; // 0x08
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _LoadSharedResource(string pchResourceName, string pchBuffer, uint unBufferLen); // TypeDefIndex: 8196; 0x0000000181F3F170-0x0000000181F3F580
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetResourceFullPath(string pchResourceName, string pchResourceTypeDirectory, string pchPathBuffer, uint unBufferLen); // TypeDefIndex: 8197; 0x0000000181F3C330-0x0000000181F3C790
	}
}
