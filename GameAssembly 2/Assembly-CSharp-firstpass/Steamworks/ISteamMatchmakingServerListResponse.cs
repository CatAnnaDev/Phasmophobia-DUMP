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
	public class ISteamMatchmakingServerListResponse // TypeDefIndex: 6091
	{
		// Fields
		private VTable m_VTable; // 0x10
		private IntPtr m_pVTable; // 0x18
		private GCHandle m_pGCHandle; // 0x20
		private ServerResponded m_ServerResponded; // 0x28
		private ServerFailedToRespond m_ServerFailedToRespond; // 0x30
		private RefreshComplete m_RefreshComplete; // 0x38
	
		// Nested types
		public delegate void ServerResponded(HServerListRequest hRequest, int iServer); // TypeDefIndex: 6092; 0x00000001802D1E00-0x00000001802D1FF0
	
		public delegate void ServerFailedToRespond(HServerListRequest hRequest, int iServer); // TypeDefIndex: 6093; 0x00000001802D1E00-0x00000001802D1FF0
	
		public delegate void RefreshComplete(HServerListRequest hRequest, EMatchMakingServerResponse response); // TypeDefIndex: 6094; 0x00000001802D1E00-0x00000001802D1FF0
	
		// [UnmanagedFunctionPointer] // 0x00000001800F9050-0x00000001800F9070
		private delegate void InternalServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer); // TypeDefIndex: 6095; 0x00000001802A7A10-0x00000001802A7C40
	
		// [UnmanagedFunctionPointer] // 0x00000001800F9050-0x00000001800F9070
		private delegate void InternalServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer); // TypeDefIndex: 6096; 0x00000001802A7A10-0x00000001802A7C40
	
		// [UnmanagedFunctionPointer] // 0x00000001800F9050-0x00000001800F9070
		private delegate void InternalRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response); // TypeDefIndex: 6097; 0x00000001802A7A10-0x00000001802A7C40
	
		private class VTable // TypeDefIndex: 6098
		{
			// Fields
			[NonSerialized]
			public InternalServerResponded m_VTServerResponded; // 0x10
			[NonSerialized]
			public InternalServerFailedToRespond m_VTServerFailedToRespond; // 0x18
			[NonSerialized]
			public InternalRefreshComplete m_VTRefreshComplete; // 0x20
	
			// Constructors
			public VTable() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		// Constructors
		public ISteamMatchmakingServerListResponse() {} // Dummy constructor
		public ISteamMatchmakingServerListResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond, RefreshComplete onRefreshComplete) {} // 0x00000001802A75A0-0x00000001802A78A0
	
		// Methods
		~ISteamMatchmakingServerListResponse() {} // 0x00000001802A72F0-0x00000001802A73F0
		private void InternalOnServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer) {} // 0x00000001802A7510-0x00000001802A75A0
		private void InternalOnServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer) {} // 0x00000001802A7480-0x00000001802A7510
		private void InternalOnRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response) {} // 0x00000001802A73F0-0x00000001802A7480
		public static explicit operator IntPtr(ISteamMatchmakingServerListResponse that) => default; // 0x00000001802A72D0-0x00000001802A72F0
	}
}
