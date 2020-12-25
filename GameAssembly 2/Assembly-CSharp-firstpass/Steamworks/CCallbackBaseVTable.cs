/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	internal class CCallbackBaseVTable // TypeDefIndex: 6085
	{
		// Fields
		private const CallingConvention cc = CallingConvention.Cdecl; // Metadata: 0x00650B2C
		[NonSerialized]
		public RunCRDel m_RunCallResult; // 0x10
		[NonSerialized]
		public RunCBDel m_RunCallback; // 0x18
		[NonSerialized]
		public GetCallbackSizeBytesDel m_GetCallbackSizeBytes; // 0x20
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x00000001800E8E90-0x00000001800E8EB0
		public delegate void RunCBDel(IntPtr thisptr, IntPtr pvParam); // TypeDefIndex: 6086; 0x00000001807CF900-0x00000001807CFC20
	
		// [UnmanagedFunctionPointer] // 0x00000001800E8E90-0x00000001800E8EB0
		public delegate void RunCRDel(IntPtr thisptr, IntPtr pvParam, bool bIOFailure, ulong hSteamAPICall); // TypeDefIndex: 6087; 0x00000001807D3D50-0x00000001807D40F0
	
		// [UnmanagedFunctionPointer] // 0x00000001800E8E90-0x00000001800E8EB0
		public delegate int GetCallbackSizeBytesDel(IntPtr thisptr); // TypeDefIndex: 6088; 0x00000001807CD390-0x00000001807CD680
	
		// Constructors
		public CCallbackBaseVTable() {} // 0x00000001802466A0-0x00000001802466B0
	}
}
