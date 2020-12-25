/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public struct IVRDriverManager // TypeDefIndex: 8198
	{
		// Fields
		internal _GetDriverCount GetDriverCount; // 0x00
		internal _GetDriverName GetDriverName; // 0x08
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetDriverCount(); // TypeDefIndex: 8199; 0x00000001811E8610-0x00000001811E87B0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetDriverName(uint nDriver, StringBuilder pchValue, uint unBufferSize); // TypeDefIndex: 8200; 0x00000001811E8850-0x00000001811E8BC0
	}
}
