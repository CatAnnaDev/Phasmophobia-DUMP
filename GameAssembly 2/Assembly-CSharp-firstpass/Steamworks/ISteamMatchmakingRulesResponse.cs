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
	public class ISteamMatchmakingRulesResponse // TypeDefIndex: 6113
	{
		// Fields
		private VTable m_VTable; // 0x10
		private IntPtr m_pVTable; // 0x18
		private GCHandle m_pGCHandle; // 0x20
		private RulesResponded m_RulesResponded; // 0x28
		private RulesFailedToRespond m_RulesFailedToRespond; // 0x30
		private RulesRefreshComplete m_RulesRefreshComplete; // 0x38
	
		// Nested types
		public delegate void RulesResponded(string pchRule, string pchValue); // TypeDefIndex: 6114; 0x0000000180252660-0x0000000180252B50
	
		public delegate void RulesFailedToRespond(); // TypeDefIndex: 6115; 0x00000001802D1BD0-0x00000001802D1D60
	
		public delegate void RulesRefreshComplete(); // TypeDefIndex: 6116; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x00000001800F9050-0x00000001800F9070
		public delegate void InternalRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue); // TypeDefIndex: 6117; 0x00000001802A7FC0-0x00000001802A8320
	
		// [UnmanagedFunctionPointer] // 0x00000001800F9050-0x00000001800F9070
		public delegate void InternalRulesFailedToRespond(IntPtr thisptr); // TypeDefIndex: 6118; 0x00000001802A7CC0-0x00000001802A7E90
	
		// [UnmanagedFunctionPointer] // 0x00000001800F9050-0x00000001800F9070
		public delegate void InternalRulesRefreshComplete(IntPtr thisptr); // TypeDefIndex: 6119; 0x00000001802A7CC0-0x00000001802A7E90
	
		private class VTable // TypeDefIndex: 6120
		{
			// Fields
			[NonSerialized]
			public InternalRulesResponded m_VTRulesResponded; // 0x10
			[NonSerialized]
			public InternalRulesFailedToRespond m_VTRulesFailedToRespond; // 0x18
			[NonSerialized]
			public InternalRulesRefreshComplete m_VTRulesRefreshComplete; // 0x20
	
			// Constructors
			public VTable() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		// Constructors
		public ISteamMatchmakingRulesResponse() {} // Dummy constructor
		public ISteamMatchmakingRulesResponse(RulesResponded onRulesResponded, RulesFailedToRespond onRulesFailedToRespond, RulesRefreshComplete onRulesRefreshComplete) {} // 0x00000001802A7060-0x00000001802A72D0
	
		// Methods
		~ISteamMatchmakingRulesResponse() {} // 0x00000001802A6BA0-0x00000001802A6CA0
		private void InternalOnRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue) {} // 0x00000001802A7000-0x00000001802A7060
		private void InternalOnRulesFailedToRespond(IntPtr thisptr) {} // 0x00000001802A6CA0-0x00000001802A6E50
		private void InternalOnRulesRefreshComplete(IntPtr thisptr) {} // 0x00000001802A6E50-0x00000001802A7000
		public static explicit operator IntPtr(ISteamMatchmakingRulesResponse that) => default; // 0x00000001802A72D0-0x00000001802A72F0
	}
}
