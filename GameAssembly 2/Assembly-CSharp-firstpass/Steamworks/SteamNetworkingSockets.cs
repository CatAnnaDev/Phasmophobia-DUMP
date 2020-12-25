/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamNetworkingSockets // TypeDefIndex: 6486
	{
		// Methods
		public static HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue_t[] pOptions) => default; // 0x00000001807A8270-0x00000001807A8330
		public static HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue_t[] pOptions) => default; // 0x00000001807A7E80-0x00000001807A7F40
		public static HSteamListenSocket CreateListenSocketP2P(int nVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) => default; // 0x00000001807A8330-0x00000001807A83F0
		public static HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) => default; // 0x00000001807A8010-0x00000001807A80E0
		public static EResult AcceptConnection(HSteamNetConnection hConn) => default; // 0x00000001807A7C80-0x00000001807A7CD0
		public static bool CloseConnection(HSteamNetConnection hPeer, int nReason, string pszDebug, bool bEnableLinger) => default; // 0x00000001807A7CD0-0x00000001807A7E30
		public static bool CloseListenSocket(HSteamListenSocket hSocket) => default; // 0x00000001807A7E30-0x00000001807A7E80
		public static bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData) => default; // 0x00000001807A91F0-0x00000001807A9250
		public static long GetConnectionUserData(HSteamNetConnection hPeer) => default; // 0x00000001807A8890-0x00000001807A88E0
		public static void SetConnectionName(HSteamNetConnection hPeer, string pszName) {} // 0x00000001807A9060-0x00000001807A9190
		public static bool GetConnectionName(HSteamNetConnection hPeer, out string pszName, int nMaxLen) {
			pszName = default;
			return default;
		} // 0x00000001807A8770-0x00000001807A8890
		public static EResult SendMessageToConnection(HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber) {
			pOutMessageNumber = default;
			return default;
		} // 0x00000001807A8ED0-0x00000001807A8F60
		public static void SendMessages(int nMessages, SteamNetworkingMessage_t[] pMessages, long[] pOutMessageNumberOrResult) {} // 0x00000001807A8F60-0x00000001807A8FE0
		public static EResult FlushMessagesOnConnection(HSteamNetConnection hConn) => default; // 0x00000001807A85F0-0x00000001807A8640
		public static int ReceiveMessagesOnConnection(HSteamNetConnection hConn, IntPtr[] ppOutMessages, int nMaxMessages) => default; // 0x00000001807A8CD0-0x00000001807A8D50
		public static bool GetConnectionInfo(HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo) {
			pInfo = default;
			return default;
		} // 0x00000001807A8710-0x00000001807A8770
		public static bool GetQuickConnectionStatus(HSteamNetConnection hConn, out SteamNetworkingQuickConnectionStatus pStats) {
			pStats = default;
			return default;
		} // 0x00000001807A8C20-0x00000001807A8C80
		public static int GetDetailedConnectionStatus(HSteamNetConnection hConn, out string pszBuf, int cbBuf) {
			pszBuf = default;
			return default;
		} // 0x00000001807A88E0-0x00000001807A8A00
		public static bool GetListenSocketAddress(HSteamListenSocket hSocket, out SteamNetworkingIPAddr address) {
			address = default;
			return default;
		} // 0x00000001807A8BC0-0x00000001807A8C20
		public static bool CreateSocketPair(out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2) {
			pOutConnection1 = default;
			pOutConnection2 = default;
			return default;
		} // 0x00000001807A8480-0x00000001807A8520
		public static bool GetIdentity(out SteamNetworkingIdentity pIdentity) {
			pIdentity = default;
			return default;
		} // 0x00000001807A8B70-0x00000001807A8BC0
		public static ESteamNetworkingAvailability InitAuthentication() => default; // 0x00000001807A8C80-0x00000001807A8CD0
		public static ESteamNetworkingAvailability GetAuthenticationStatus(out SteamNetAuthenticationStatus_t pDetails) {
			pDetails = default;
			return default;
		} // 0x00000001807A8640-0x00000001807A8690
		public static HSteamNetPollGroup CreatePollGroup() => default; // 0x00000001807A83F0-0x00000001807A8480
		public static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup) => default; // 0x00000001807A8520-0x00000001807A8570
		public static bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup) => default; // 0x00000001807A9190-0x00000001807A91F0
		public static int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr[] ppOutMessages, int nMaxMessages) => default; // 0x00000001807A8D50-0x00000001807A8DD0
		public static bool ReceivedRelayAuthTicket(IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket) {
			pOutParsedTicket = default;
			return default;
		} // 0x00000001807A8E50-0x00000001807A8ED0
		public static int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket) {
			pOutParsedTicket = default;
			return default;
		} // 0x00000001807A8570-0x00000001807A85F0
		public static HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) => default; // 0x00000001807A80E0-0x00000001807A81B0
		public static ushort GetHostedDedicatedServerPort() => default; // 0x00000001807A8B20-0x00000001807A8B70
		public static SteamNetworkingPOPID GetHostedDedicatedServerPOPID() => default; // 0x00000001807A8AD0-0x00000001807A8B20
		public static EResult GetHostedDedicatedServerAddress(out SteamDatagramHostedAddress pRouting) {
			pRouting = default;
			return default;
		} // 0x00000001807A8A80-0x00000001807A8AD0
		public static HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) => default; // 0x00000001807A81B0-0x00000001807A8270
		public static EResult GetGameCoordinatorServerLogin(out SteamDatagramGameCoordinatorServerLogin pLoginInfo, out int pcbSignedBlob, IntPtr pBlob) {
			pLoginInfo = default;
			pcbSignedBlob = default;
			return default;
		} // 0x00000001807A8A00-0x00000001807A8A80
		public static HSteamNetConnection ConnectP2PCustomSignaling(out ISteamNetworkingConnectionCustomSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nOptions, SteamNetworkingConfigValue_t[] pOptions) {
			pSignaling = default;
			return default;
		} // 0x00000001807A7F40-0x00000001807A8010
		public static bool ReceivedP2PCustomSignal(IntPtr pMsg, int cbMsg, out ISteamNetworkingCustomSignalingRecvContext pContext) {
			pContext = default;
			return default;
		} // 0x00000001807A8DD0-0x00000001807A8E50
		public static bool GetCertificateRequest(out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg) {
			pcbBlob = default;
			errMsg = default;
			return default;
		} // 0x00000001807A8690-0x00000001807A8710
		public static bool SetCertificate(IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg) {
			errMsg = default;
			return default;
		} // 0x00000001807A8FE0-0x00000001807A9060
	}
}
