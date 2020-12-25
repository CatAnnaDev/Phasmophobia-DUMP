/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamGameServerNetworking // TypeDefIndex: 6469
	{
		// Methods
		public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0 /* Metadata: 0x00652CA7 */) => default; // 0x0000000180959C00-0x0000000180959C90
		public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0 /* Metadata: 0x00652CAB */) {
			pcubMsgSize = default;
			return default;
		} // 0x0000000180959960-0x00000001809599C0
		public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0 /* Metadata: 0x00652CAF */) {
			pcubMsgSize = default;
			psteamIDRemote = default;
			return default;
		} // 0x00000001809599C0-0x0000000180959A50
		public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote) => default; // 0x00000001809592A0-0x00000001809592F0
		public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote) => default; // 0x00000001809593A0-0x00000001809593F0
		public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel) => default; // 0x0000000180959340-0x00000001809593A0
		public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState) {
			pConnectionState = default;
			return default;
		} // 0x0000000180959740-0x00000001809597A0
		public static bool AllowP2PPacketRelay(bool bAllow) => default; // 0x00000001809592F0-0x0000000180959340
		public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay) => default; // 0x0000000180959480-0x0000000180959520
		public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay) => default; // 0x0000000180959520-0x00000001809595B0
		public static SNetSocket_t CreateConnectionSocket(SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec) => default; // 0x00000001809593F0-0x0000000180959480
		public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd) => default; // 0x0000000180959610-0x0000000180959670
		public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd) => default; // 0x00000001809595B0-0x0000000180959610
		public static bool SendDataOnSocket(SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable) => default; // 0x0000000180959B70-0x0000000180959C00
		public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize) {
			pcubMsgSize = default;
			return default;
		} // 0x0000000180959880-0x00000001809598E0
		public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize) {
			pcubMsgSize = default;
			return default;
		} // 0x0000000180959A50-0x0000000180959AE0
		public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket) {
			pcubMsgSize = default;
			phSocket = default;
			return default;
		} // 0x00000001809598E0-0x0000000180959960
		public static bool RetrieveData(SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket) {
			pcubMsgSize = default;
			phSocket = default;
			return default;
		} // 0x0000000180959AE0-0x0000000180959B70
		public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote) {
			pSteamIDRemote = default;
			peSocketStatus = default;
			punIPRemote = default;
			punPortRemote = default;
			return default;
		} // 0x00000001809597F0-0x0000000180959880
		public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort) {
			pnIP = default;
			pnPort = default;
			return default;
		} // 0x0000000180959670-0x00000001809596F0
		public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket) => default; // 0x00000001809597A0-0x00000001809597F0
		public static int GetMaxPacketSize(SNetSocket_t hSocket) => default; // 0x00000001809596F0-0x0000000180959740
	}
}
