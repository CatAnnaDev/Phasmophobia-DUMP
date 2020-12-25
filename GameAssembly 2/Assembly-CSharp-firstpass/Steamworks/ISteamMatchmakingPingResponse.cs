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
	public class ISteamMatchmakingPingResponse // TypeDefIndex: 6099
	{
		// Fields
		private VTable m_VTable; // 0x10
		private IntPtr m_pVTable; // 0x18
		private GCHandle m_pGCHandle; // 0x20
		private ServerResponded m_ServerResponded; // 0x28
		private ServerFailedToRespond m_ServerFailedToRespond; // 0x30
	
		// Nested types
		public delegate void ServerResponded(gameserveritem_t server); // TypeDefIndex: 6100; 0x000000018070A7F0-0x000000018070AB70
	
		public delegate void ServerFailedToRespond(); // TypeDefIndex: 6101; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x00000001800F9050-0x00000001800F9070
		private delegate void InternalServerResponded(IntPtr thisptr, gameserveritem_t server); // TypeDefIndex: 6102; 0x00000001807CF900-0x00000001807CFC20
	
		// [UnmanagedFunctionPointer] // 0x00000001800F9050-0x00000001800F9070
		private delegate void InternalServerFailedToRespond(IntPtr thisptr); // TypeDefIndex: 6103; 0x00000001802A7CC0-0x00000001802A7E90
	
		private class VTable // TypeDefIndex: 6104
		{
			// Fields
			[NonSerialized]
			public InternalServerResponded m_VTServerResponded; // 0x10
			[NonSerialized]
			public InternalServerFailedToRespond m_VTServerFailedToRespond; // 0x18
	
			// Constructors
			public VTable() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		// Constructors
		public ISteamMatchmakingPingResponse() {} // Dummy constructor
		public ISteamMatchmakingPingResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond) {} // 0x00000001807CEC70-0x00000001807CEE80
	
		// Methods
		~ISteamMatchmakingPingResponse() {} // 0x00000001807CEB40-0x00000001807CEC40
		private void InternalOnServerResponded(IntPtr thisptr, gameserveritem_t server) {} // 0x00000001807CEC40-0x00000001807CEC70
		private void InternalOnServerFailedToRespond(IntPtr thisptr) {} // 0x00000001802A6CA0-0x00000001802A6E50
		public static explicit operator IntPtr(ISteamMatchmakingPingResponse that) => default; // 0x00000001802A72D0-0x00000001802A72F0
	}
}
