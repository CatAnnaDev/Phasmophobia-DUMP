/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamGameServerNetworkingSockets // TypeDefIndex: 6470
	{
		// Methods
		public static HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue_t[] pOptions) => default; // 0x0000000180957610-0x00000001809576D0
		public static HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue_t[] pOptions) => default; // 0x0000000180957220-0x00000001809572E0
		public static HSteamListenSocket CreateListenSocketP2P(int nVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) => default; // 0x00000001809576D0-0x0000000180957790
		public static HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) => default; // 0x00000001809573B0-0x0000000180957480
		public static EResult AcceptConnection(HSteamNetConnection hConn) => default; // 0x0000000180957020-0x0000000180957070
		public static bool CloseConnection(HSteamNetConnection hPeer, int nReason, string pszDebug, bool bEnableLinger) => default; // 0x0000000180957070-0x00000001809571D0
		public static bool CloseListenSocket(HSteamListenSocket hSocket) => default; // 0x00000001809571D0-0x0000000180957220
		public static bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData) => default; // 0x0000000180958580-0x00000001809585E0
		public static long GetConnectionUserData(HSteamNetConnection hPeer) => default; // 0x0000000180957C30-0x0000000180957C80
		public static void SetConnectionName(HSteamNetConnection hPeer, string pszName) {} // 0x0000000180958400-0x0000000180958520
		public static bool GetConnectionName(HSteamNetConnection hPeer, out string pszName, int nMaxLen) {
			pszName = default;
			return default;
		} // 0x0000000180957B10-0x0000000180957C30
		public static EResult SendMessageToConnection(HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber) {
			pOutMessageNumber = default;
			return default;
		} // 0x0000000180958270-0x0000000180958300
		public static void SendMessages(int nMessages, SteamNetworkingMessage_t[] pMessages, long[] pOutMessageNumberOrResult) {} // 0x0000000180958300-0x0000000180958380
		public static EResult FlushMessagesOnConnection(HSteamNetConnection hConn) => default; // 0x0000000180957990-0x00000001809579E0
		public static int ReceiveMessagesOnConnection(HSteamNetConnection hConn, IntPtr[] ppOutMessages, int nMaxMessages) => default; // 0x0000000180958070-0x00000001809580F0
		public static bool GetConnectionInfo(HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo) {
			pInfo = default;
			return default;
		} // 0x0000000180957AB0-0x0000000180957B10
		public static bool GetQuickConnectionStatus(HSteamNetConnection hConn, out SteamNetworkingQuickConnectionStatus pStats) {
			pStats = default;
			return default;
		} // 0x0000000180957FC0-0x0000000180958020
		public static int GetDetailedConnectionStatus(HSteamNetConnection hConn, out string pszBuf, int cbBuf) {
			pszBuf = default;
			return default;
		} // 0x0000000180957C80-0x0000000180957DA0
		public static bool GetListenSocketAddress(HSteamListenSocket hSocket, out SteamNetworkingIPAddr address) {
			address = default;
			return default;
		} // 0x0000000180957F60-0x0000000180957FC0
		public static bool CreateSocketPair(out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2) {
			pOutConnection1 = default;
			pOutConnection2 = default;
			return default;
		} // 0x0000000180957820-0x00000001809578C0
		public static bool GetIdentity(out SteamNetworkingIdentity pIdentity) {
			pIdentity = default;
			return default;
		} // 0x0000000180957F10-0x0000000180957F60
		public static ESteamNetworkingAvailability InitAuthentication() => default; // 0x0000000180958020-0x0000000180958070
		public static ESteamNetworkingAvailability GetAuthenticationStatus(out SteamNetAuthenticationStatus_t pDetails) {
			pDetails = default;
			return default;
		} // 0x00000001809579E0-0x0000000180957A30
		public static HSteamNetPollGroup CreatePollGroup() => default; // 0x0000000180957790-0x0000000180957820
		public static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup) => default; // 0x00000001809578C0-0x0000000180957910
		public static bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup) => default; // 0x0000000180958520-0x0000000180958580
		public static int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr[] ppOutMessages, int nMaxMessages) => default; // 0x00000001809580F0-0x0000000180958170
		public static bool ReceivedRelayAuthTicket(IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket) {
			pOutParsedTicket = default;
			return default;
		} // 0x00000001809581F0-0x0000000180958270
		public static int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket) {
			pOutParsedTicket = default;
			return default;
		} // 0x0000000180957910-0x0000000180957990
		public static HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) => default; // 0x0000000180957480-0x0000000180957550
		public static ushort GetHostedDedicatedServerPort() => default; // 0x0000000180957EC0-0x0000000180957F10
		public static SteamNetworkingPOPID GetHostedDedicatedServerPOPID() => default; // 0x0000000180957E70-0x0000000180957EC0
		public static EResult GetHostedDedicatedServerAddress(out SteamDatagramHostedAddress pRouting) {
			pRouting = default;
			return default;
		} // 0x0000000180957E20-0x0000000180957E70
		public static HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) => default; // 0x0000000180957550-0x0000000180957610
		public static EResult GetGameCoordinatorServerLogin(out SteamDatagramGameCoordinatorServerLogin pLoginInfo, out int pcbSignedBlob, IntPtr pBlob) {
			pLoginInfo = default;
			pcbSignedBlob = default;
			return default;
		} // 0x0000000180957DA0-0x0000000180957E20
		public static HSteamNetConnection ConnectP2PCustomSignaling(out ISteamNetworkingConnectionCustomSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nOptions, SteamNetworkingConfigValue_t[] pOptions) {
			pSignaling = default;
			return default;
		} // 0x00000001809572E0-0x00000001809573B0
		public static bool ReceivedP2PCustomSignal(IntPtr pMsg, int cbMsg, out ISteamNetworkingCustomSignalingRecvContext pContext) {
			pContext = default;
			return default;
		} // 0x0000000180958170-0x00000001809581F0
		public static bool GetCertificateRequest(out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg) {
			pcbBlob = default;
			errMsg = default;
			return default;
		} // 0x0000000180957A30-0x0000000180957AB0
		public static bool SetCertificate(IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg) {
			errMsg = default;
			return default;
		} // 0x0000000180958380-0x0000000180958400
	}
}
