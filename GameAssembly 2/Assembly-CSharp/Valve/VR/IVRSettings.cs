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
	public struct IVRSettings // TypeDefIndex: 8174
	{
		// Fields
		internal _GetSettingsErrorNameFromEnum GetSettingsErrorNameFromEnum; // 0x00
		internal _Sync Sync; // 0x08
		internal _SetBool SetBool; // 0x10
		internal _SetInt32 SetInt32; // 0x18
		internal _SetFloat SetFloat; // 0x20
		internal _SetString SetString; // 0x28
		internal _GetBool GetBool; // 0x30
		internal _GetInt32 GetInt32; // 0x38
		internal _GetFloat GetFloat; // 0x40
		internal _GetString GetString; // 0x48
		internal _RemoveSection RemoveSection; // 0x50
		internal _RemoveKeyInSection RemoveKeyInSection; // 0x58
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate IntPtr _GetSettingsErrorNameFromEnum(EVRSettingsError eError); // TypeDefIndex: 8175; 0x00000001811EA830-0x00000001811EAA00
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _Sync(bool bForce, ref EVRSettingsError peError); // TypeDefIndex: 8176; 0x0000000181F43BB0-0x0000000181F43EE0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _SetBool(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError); // TypeDefIndex: 8177; 0x0000000181F404F0-0x0000000181F40A50
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _SetInt32(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError); // TypeDefIndex: 8178; 0x0000000181F41190-0x0000000181F416D0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _SetFloat(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError); // TypeDefIndex: 8179; 0x0000000181F40B90-0x0000000181F410E0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _SetString(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError); // TypeDefIndex: 8180; 0x000000018140B380-0x000000018140B7D0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetBool(string pchSection, string pchSettingsKey, ref EVRSettingsError peError); // TypeDefIndex: 8181; 0x0000000181F36BB0-0x0000000181F370D0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate int _GetInt32(string pchSection, string pchSettingsKey, ref EVRSettingsError peError); // TypeDefIndex: 8182; 0x0000000181F3A780-0x0000000181F3ACA0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate float _GetFloat(string pchSection, string pchSettingsKey, ref EVRSettingsError peError); // TypeDefIndex: 8183; 0x0000000181F39960-0x0000000181F39E80
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _GetString(string pchSection, string pchSettingsKey, StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError); // TypeDefIndex: 8184; 0x0000000181F3D210-0x0000000181F3D7A0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _RemoveSection(string pchSection, ref EVRSettingsError peError); // TypeDefIndex: 8185; 0x0000000180848E40-0x0000000180849110
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _RemoveKeyInSection(string pchSection, string pchSettingsKey, ref EVRSettingsError peError); // TypeDefIndex: 8186; 0x000000018140AF10-0x000000018140B200
	}
}
