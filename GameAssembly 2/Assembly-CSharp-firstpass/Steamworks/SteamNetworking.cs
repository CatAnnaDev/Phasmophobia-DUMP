/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamNetworking // TypeDefIndex: 6485
	{
		// Methods
		public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0 /* Metadata: 0x00652CC0 */) => default; // 0x00000001807AA870-0x00000001807AA900
		public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0 /* Metadata: 0x00652CC4 */) {
			pcubMsgSize = default;
			return default;
		} // 0x00000001807AA5D0-0x00000001807AA630
		public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0 /* Metadata: 0x00652CC8 */) {
			pcubMsgSize = default;
			psteamIDRemote = default;
			return default;
		} // 0x00000001807AA630-0x00000001807AA6C0
		public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote) => default; // 0x00000001807A9F10-0x00000001807A9F60
		public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote) => default; // 0x00000001807AA010-0x00000001807AA060
		public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel) => default; // 0x00000001807A9FB0-0x00000001807AA010
		public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState) {
			pConnectionState = default;
			return default;
		} // 0x00000001807AA3B0-0x00000001807AA410
		public static bool AllowP2PPacketRelay(bool bAllow) => default; // 0x00000001807A9F60-0x00000001807A9FB0
		public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay) => default; // 0x00000001807AA0F0-0x00000001807AA190
		public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay) => default; // 0x00000001807AA190-0x00000001807AA220
		public static SNetSocket_t CreateConnectionSocket(SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec) => default; // 0x00000001807AA060-0x00000001807AA0F0
		public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd) => default; // 0x00000001807AA280-0x00000001807AA2E0
		public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd) => default; // 0x00000001807AA220-0x00000001807AA280
		public static bool SendDataOnSocket(SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable) => default; // 0x00000001807AA7E0-0x00000001807AA870
		public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize) {
			pcubMsgSize = default;
			return default;
		} // 0x00000001807AA4F0-0x00000001807AA550
		public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize) {
			pcubMsgSize = default;
			return default;
		} // 0x00000001807AA6C0-0x00000001807AA750
		public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket) {
			pcubMsgSize = default;
			phSocket = default;
			return default;
		} // 0x00000001807AA550-0x00000001807AA5D0
		public static bool RetrieveData(SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket) {
			pcubMsgSize = default;
			phSocket = default;
			return default;
		} // 0x00000001807AA750-0x00000001807AA7E0
		public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote) {
			pSteamIDRemote = default;
			peSocketStatus = default;
			punIPRemote = default;
			punPortRemote = default;
			return default;
		} // 0x00000001807AA460-0x00000001807AA4F0
		public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort) {
			pnIP = default;
			pnPort = default;
			return default;
		} // 0x00000001807AA2E0-0x00000001807AA360
		public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket) => default; // 0x00000001807AA410-0x00000001807AA460
		public static int GetMaxPacketSize(SNetSocket_t hSocket) => default; // 0x00000001807AA360-0x00000001807AA3B0
	}
}
