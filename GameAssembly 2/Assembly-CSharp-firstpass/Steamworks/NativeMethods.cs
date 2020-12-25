/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	[SuppressUnmanagedCodeSecurity] // 0x00000001800D4E50-0x00000001800D4E60
	internal static class NativeMethods // TypeDefIndex: 6134
	{
		// Fields
		internal const string NativeLibraryName = "steam_api64"; // Metadata: 0x00650B5D
		internal const string NativeLibrary_SDKEncryptedAppTicket = "sdkencryptedappticket64"; // Metadata: 0x00650B6C
	
		// Methods
		public static extern bool SteamAPI_Init(); // 0x00000001802CE1A0-0x00000001802CE210
		public static extern void SteamAPI_Shutdown(); // 0x00000001802CE8C0-0x00000001802CE930
		public static extern bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID); // 0x00000001802CE610-0x00000001802CE690
		public static extern void SteamAPI_ReleaseCurrentThreadMemory(); // 0x00000001802CE5A0-0x00000001802CE610
		public static extern void SteamAPI_WriteMiniDump(uint uStructuredExceptionCode, IntPtr pvExceptionInfo, uint uBuildID); // 0x00000001802D0BF0-0x00000001802D0C90
		public static extern void SteamAPI_SetMiniDumpComment(InteropHelp.UTF8StringHandle pchMsg); // 0x00000001802CE780-0x00000001802CE840
		public static extern void SteamAPI_RunCallbacks(); // 0x00000001802CE690-0x00000001802CE700
		public static extern void SteamAPI_RegisterCallback(IntPtr pCallback, int iCallback); // 0x00000001802CE510-0x00000001802CE5A0
		public static extern void SteamAPI_UnregisterCallback(IntPtr pCallback); // 0x00000001802D09B0-0x00000001802D0A30
		public static extern void SteamAPI_RegisterCallResult(IntPtr pCallback, ulong hAPICall); // 0x00000001802CE480-0x00000001802CE510
		public static extern void SteamAPI_UnregisterCallResult(IntPtr pCallback, ulong hAPICall); // 0x00000001802D0920-0x00000001802D09B0
		public static extern bool SteamAPI_IsSteamRunning(); // 0x00000001802CE210-0x00000001802CE280
		public static extern int SteamAPI_GetSteamInstallPath(); // 0x00000001802CDD30-0x00000001802CDDA0
		public static extern int SteamAPI_GetHSteamPipe(); // 0x00000001802CDC50-0x00000001802CDCC0
		public static extern void SteamAPI_SetTryCatchCallbacks(bool bTryCatchCallbacks); // 0x00000001802CE840-0x00000001802CE8C0
		public static extern int SteamAPI_GetHSteamUser(); // 0x00000001802CDCC0-0x00000001802CDD30
		public static extern IntPtr SteamInternal_ContextInit(IntPtr pContextInitData); // 0x00000001802D1790-0x00000001802D1810
		public static extern IntPtr SteamInternal_CreateInterface(InteropHelp.UTF8StringHandle ver); // 0x00000001802D1810-0x00000001802D18E0
		public static extern IntPtr SteamInternal_FindOrCreateUserInterface(HSteamUser hSteamUser, InteropHelp.UTF8StringHandle pszVersion); // 0x00000001802D19B0-0x00000001802D1A80
		public static extern IntPtr SteamInternal_FindOrCreateGameServerInterface(HSteamUser hSteamUser, InteropHelp.UTF8StringHandle pszVersion); // 0x00000001802D18E0-0x00000001802D19B0
		public static extern void SteamAPI_UseBreakpadCrashHandler(InteropHelp.UTF8StringHandle pchVersion, InteropHelp.UTF8StringHandle pchDate, InteropHelp.UTF8StringHandle pchTime, bool bFullMemoryDumps, IntPtr pvContext, IntPtr m_pfnPreMinidumpCallback); // 0x00000001802D0A30-0x00000001802D0BF0
		public static extern void SteamAPI_SetBreakpadAppID(uint unAppID); // 0x00000001802CE700-0x00000001802CE780
		public static extern void SteamAPI_ManualDispatch_Init(); // 0x00000001802CE390-0x00000001802CE400
		public static extern void SteamAPI_ManualDispatch_RunFrame(HSteamPipe hSteamPipe); // 0x00000001802CE400-0x00000001802CE480
		public static extern bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe hSteamPipe, IntPtr pCallbackMsg); // 0x00000001802CE300-0x00000001802CE390
		public static extern void SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe hSteamPipe); // 0x00000001802CE280-0x00000001802CE300
		public static extern bool SteamGameServer_Init(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, InteropHelp.UTF8StringHandle pchVersionString); // 0x00000001802D1520-0x00000001802D1640
		public static extern void SteamGameServer_Shutdown(); // 0x00000001802D1720-0x00000001802D1790
		public static extern void SteamGameServer_RunCallbacks(); // 0x00000001802D16B0-0x00000001802D1720
		public static extern void SteamGameServer_ReleaseCurrentThreadMemory(); // 0x00000001802D1640-0x00000001802D16B0
		public static extern bool SteamGameServer_BSecure(); // 0x00000001802D1360-0x00000001802D13D0
		public static extern ulong SteamGameServer_GetSteamID(); // 0x00000001802D14B0-0x00000001802D1520
		public static extern int SteamGameServer_GetHSteamPipe(); // 0x00000001802D13D0-0x00000001802D1440
		public static extern int SteamGameServer_GetHSteamUser(); // 0x00000001802D1440-0x00000001802D14B0
		public static extern bool SteamInternal_GameServer_Init(uint unIP, ushort usPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, InteropHelp.UTF8StringHandle pchVersionString); // 0x00000001802D1A80-0x00000001802D1BA0
		public static extern IntPtr SteamClient(); // 0x00000001802D0C90-0x00000001802D0D00
		public static extern IntPtr SteamGameServerClient(); // 0x00000001802D12F0-0x00000001802D1360
		public static extern void SteamAPI_SteamNetworkingIPAddr_Clear(ref SteamNetworkingIPAddr self); // 0x00000001802CE930-0x00000001802CEA10
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsIPv6AllZeros(ref SteamNetworkingIPAddr self); // 0x00000001802CED30-0x00000001802CEE20
		public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv6(ref SteamNetworkingIPAddr self, [In, Out] byte[] ipv6, ushort nPort); // 0x00000001802CF260-0x00000001802CF360
		public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv4(ref SteamNetworkingIPAddr self, uint nIP, ushort nPort); // 0x00000001802CF070-0x00000001802CF170
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsIPv4(ref SteamNetworkingIPAddr self); // 0x00000001802CEC40-0x00000001802CED30
		public static extern uint SteamAPI_SteamNetworkingIPAddr_GetIPv4(ref SteamNetworkingIPAddr self); // 0x00000001802CEA10-0x00000001802CEB00
		public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv6LocalHost(ref SteamNetworkingIPAddr self, ushort nPort); // 0x00000001802CF170-0x00000001802CF260
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsLocalHost(ref SteamNetworkingIPAddr self); // 0x00000001802CEE20-0x00000001802CEF10
		public static extern void SteamAPI_SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr self, IntPtr buf, uint cbBuf, bool bWithPort); // 0x00000001802CF360-0x00000001802CF470
		public static extern bool SteamAPI_SteamNetworkingIPAddr_ParseString(ref SteamNetworkingIPAddr self, InteropHelp.UTF8StringHandle pszStr); // 0x00000001802CEF10-0x00000001802CF070
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsEqualTo(ref SteamNetworkingIPAddr self, ref SteamNetworkingIPAddr x); // 0x00000001802CEB00-0x00000001802CEC40
		public static extern void SteamAPI_SteamNetworkingIdentity_Clear(ref SteamNetworkingIdentity self); // 0x00000001802CF470-0x00000001802CF550
		public static extern bool SteamAPI_SteamNetworkingIdentity_IsInvalid(ref SteamNetworkingIdentity self); // 0x00000001802CFC70-0x00000001802CFD60
		public static extern void SteamAPI_SteamNetworkingIdentity_SetSteamID(ref SteamNetworkingIdentity self, ulong steamID); // 0x00000001802D0550-0x00000001802D0640
		public static extern ulong SteamAPI_SteamNetworkingIdentity_GetSteamID(ref SteamNetworkingIdentity self); // 0x00000001802CF920-0x00000001802CFA10
		public static extern void SteamAPI_SteamNetworkingIdentity_SetSteamID64(ref SteamNetworkingIdentity self, ulong steamID); // 0x00000001802D0460-0x00000001802D0550
		public static extern ulong SteamAPI_SteamNetworkingIdentity_GetSteamID64(ref SteamNetworkingIdentity self); // 0x00000001802CF830-0x00000001802CF920
		public static extern bool SteamAPI_SteamNetworkingIdentity_SetXboxPairwiseID(ref SteamNetworkingIdentity self, InteropHelp.UTF8StringHandle pszString); // 0x00000001802D0640-0x00000001802D07A0
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetXboxPairwiseID(ref SteamNetworkingIdentity self); // 0x00000001802CFA10-0x00000001802CFB00
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_SetIPAddr(ref SteamNetworkingIdentity self, ref SteamNetworkingIPAddr addr); // 0x00000001802D0220-0x00000001802D0380
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetIPAddr(ref SteamNetworkingIdentity self); // 0x00000001802CF740-0x00000001802CF830
		public static extern void SteamAPI_SteamNetworkingIdentity_SetLocalHost(ref SteamNetworkingIdentity self); // 0x00000001802D0380-0x00000001802D0460
		public static extern bool SteamAPI_SteamNetworkingIdentity_IsLocalHost(ref SteamNetworkingIdentity self); // 0x00000001802CFD60-0x00000001802CFE50
		public static extern bool SteamAPI_SteamNetworkingIdentity_SetGenericString(ref SteamNetworkingIdentity self, InteropHelp.UTF8StringHandle pszString); // 0x00000001802D00C0-0x00000001802D0220
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetGenericString(ref SteamNetworkingIdentity self); // 0x00000001802CF650-0x00000001802CF740
		public static extern bool SteamAPI_SteamNetworkingIdentity_SetGenericBytes(ref SteamNetworkingIdentity self, [In, Out] byte[] data, uint cbLen); // 0x00000001802CFFB0-0x00000001802D00C0
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetGenericBytes(ref SteamNetworkingIdentity self, out int cbLen); // 0x00000001802CF550-0x00000001802CF650
		public static extern bool SteamAPI_SteamNetworkingIdentity_IsEqualTo(ref SteamNetworkingIdentity self, ref SteamNetworkingIdentity x); // 0x00000001802CFB00-0x00000001802CFC70
		public static extern void SteamAPI_SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity self, IntPtr buf, uint cbBuf); // 0x00000001802D07A0-0x00000001802D08A0
		public static extern bool SteamAPI_SteamNetworkingIdentity_ParseString(ref SteamNetworkingIdentity self, InteropHelp.UTF8StringHandle pszStr); // 0x00000001802CFE50-0x00000001802CFFB0
		public static extern void SteamAPI_SteamNetworkingMessage_t_Release(IntPtr self); // 0x00000001802D08A0-0x00000001802D0920
		public static extern bool SteamAPI_ISteamNetworkingConnectionCustomSignaling_SendSignal(ref ISteamNetworkingConnectionCustomSignaling self, HSteamNetConnection hConn, ref SteamNetConnectionInfo_t info, IntPtr pMsg, int cbMsg); // 0x00000001802CDE20-0x00000001802CDF90
		public static extern void SteamAPI_ISteamNetworkingConnectionCustomSignaling_Release(ref ISteamNetworkingConnectionCustomSignaling self); // 0x00000001802CDDA0-0x00000001802CDE20
		public static extern IntPtr SteamAPI_ISteamNetworkingCustomSignalingRecvContext_OnConnectRequest(ref ISteamNetworkingCustomSignalingRecvContext self, HSteamNetConnection hConn, ref SteamNetworkingIdentity identityPeer); // 0x00000001802CDF90-0x00000001802CE090
		public static extern void SteamAPI_ISteamNetworkingCustomSignalingRecvContext_SendRejectionSignal(ref ISteamNetworkingCustomSignalingRecvContext self, ref SteamNetworkingIdentity identityPeer, IntPtr pMsg, int cbMsg); // 0x00000001802CE090-0x00000001802CE1A0
		public static extern bool SteamEncryptedAppTicket_BDecryptTicket([In, Out] byte[] rgubTicketEncrypted, uint cubTicketEncrypted, [In, Out] byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey); // 0x00000001802D0D00-0x00000001802D0DF0
		public static extern bool SteamEncryptedAppTicket_BIsTicketForApp([In, Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID); // 0x00000001802D0DF0-0x00000001802D0E90
		public static extern uint SteamEncryptedAppTicket_GetTicketIssueTime([In, Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted); // 0x00000001802D1120-0x00000001802D11B0
		public static extern void SteamEncryptedAppTicket_GetTicketSteamID([In, Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID); // 0x00000001802D11B0-0x00000001802D1250
		public static extern uint SteamEncryptedAppTicket_GetTicketAppID([In, Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted); // 0x00000001802D1090-0x00000001802D1120
		public static extern bool SteamEncryptedAppTicket_BUserOwnsAppInTicket([In, Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID); // 0x00000001802D0FF0-0x00000001802D1090
		public static extern bool SteamEncryptedAppTicket_BUserIsVacBanned([In, Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted); // 0x00000001802D0F50-0x00000001802D0FF0
		public static extern IntPtr SteamEncryptedAppTicket_GetUserVariableData([In, Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData); // 0x00000001802D1250-0x00000001802D12F0
		public static extern bool SteamEncryptedAppTicket_BIsTicketSigned([In, Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, [In, Out] byte[] pubRSAKey, uint cubRSAKey); // 0x00000001802D0E90-0x00000001802D0F50
		public static extern uint ISteamAppList_GetNumInstalledApps(IntPtr instancePtr); // 0x00000001802A8D70-0x00000001802A8DF0
		public static extern uint ISteamAppList_GetInstalledApps(IntPtr instancePtr, [In, Out] AppId_t[] pvecAppID, uint unMaxAppIDs); // 0x00000001802A8CD0-0x00000001802A8D70
		public static extern int ISteamAppList_GetAppName(IntPtr instancePtr, AppId_t nAppID, IntPtr pchName, int cchNameMax); // 0x00000001802A8C30-0x00000001802A8CD0
		public static extern int ISteamAppList_GetAppInstallDir(IntPtr instancePtr, AppId_t nAppID, IntPtr pchDirectory, int cchNameMax); // 0x00000001802A8B90-0x00000001802A8C30
		public static extern int ISteamAppList_GetAppBuildId(IntPtr instancePtr, AppId_t nAppID); // 0x00000001802A8B00-0x00000001802A8B90
		public static extern bool ISteamApps_BIsSubscribed(IntPtr instancePtr); // 0x00000001802A9280-0x00000001802A9300
		public static extern bool ISteamApps_BIsLowViolence(IntPtr instancePtr); // 0x00000001802A9070-0x00000001802A90F0
		public static extern bool ISteamApps_BIsCybercafe(IntPtr instancePtr); // 0x00000001802A8F60-0x00000001802A8FE0
		public static extern bool ISteamApps_BIsVACBanned(IntPtr instancePtr); // 0x00000001802A9300-0x00000001802A9380
		public static extern IntPtr ISteamApps_GetCurrentGameLanguage(IntPtr instancePtr); // 0x00000001802A9640-0x00000001802A96C0
		public static extern IntPtr ISteamApps_GetAvailableGameLanguages(IntPtr instancePtr); // 0x00000001802A9520-0x00000001802A95A0
		public static extern bool ISteamApps_BIsSubscribedApp(IntPtr instancePtr, AppId_t appID); // 0x00000001802A90F0-0x00000001802A9180
		public static extern bool ISteamApps_BIsDlcInstalled(IntPtr instancePtr, AppId_t appID); // 0x00000001802A8FE0-0x00000001802A9070
		public static extern uint ISteamApps_GetEarliestPurchaseUnixTime(IntPtr instancePtr, AppId_t nAppID); // 0x00000001802A97F0-0x00000001802A9880
		public static extern bool ISteamApps_BIsSubscribedFromFreeWeekend(IntPtr instancePtr); // 0x00000001802A9200-0x00000001802A9280
		public static extern int ISteamApps_GetDLCCount(IntPtr instancePtr); // 0x00000001802A96C0-0x00000001802A9740
		public static extern bool ISteamApps_BGetDLCDataByIndex(IntPtr instancePtr, int iDLC, out AppId_t pAppID, out bool pbAvailable, IntPtr pchName, int cchNameBufferSize); // 0x00000001802A8DF0-0x00000001802A8ED0
		public static extern void ISteamApps_InstallDLC(IntPtr instancePtr, AppId_t nAppID); // 0x00000001802A9B90-0x00000001802A9C20
		public static extern void ISteamApps_UninstallDLC(IntPtr instancePtr, AppId_t nAppID); // 0x00000001802A9DC0-0x00000001802A9E50
		public static extern void ISteamApps_RequestAppProofOfPurchaseKey(IntPtr instancePtr, AppId_t nAppID); // 0x00000001802A9D30-0x00000001802A9DC0
		public static extern bool ISteamApps_GetCurrentBetaName(IntPtr instancePtr, IntPtr pchName, int cchNameBufferSize); // 0x00000001802A95A0-0x00000001802A9640
		public static extern bool ISteamApps_MarkContentCorrupt(IntPtr instancePtr, bool bMissingFilesOnly); // 0x00000001802A9C20-0x00000001802A9CB0
		public static extern uint ISteamApps_GetInstalledDepots(IntPtr instancePtr, AppId_t appID, [In, Out] DepotId_t[] pvecDepots, uint cMaxDepots); // 0x00000001802A9960-0x00000001802A9A10
		public static extern uint ISteamApps_GetAppInstallDir(IntPtr instancePtr, AppId_t appID, IntPtr pchFolder, uint cchFolderBufferSize); // 0x00000001802A9400-0x00000001802A94A0
		public static extern bool ISteamApps_BIsAppInstalled(IntPtr instancePtr, AppId_t appID); // 0x00000001802A8ED0-0x00000001802A8F60
		public static extern ulong ISteamApps_GetAppOwner(IntPtr instancePtr); // 0x00000001802A94A0-0x00000001802A9520
		public static extern IntPtr ISteamApps_GetLaunchQueryParam(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey); // 0x00000001802A9AB0-0x00000001802A9B90
		public static extern bool ISteamApps_GetDlcDownloadProgress(IntPtr instancePtr, AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal); // 0x00000001802A9740-0x00000001802A97F0
		public static extern int ISteamApps_GetAppBuildId(IntPtr instancePtr); // 0x00000001802A9380-0x00000001802A9400
		public static extern void ISteamApps_RequestAllProofOfPurchaseKeys(IntPtr instancePtr); // 0x00000001802A9CB0-0x00000001802A9D30
		public static extern ulong ISteamApps_GetFileDetails(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszFileName); // 0x00000001802A9880-0x00000001802A9960
		public static extern int ISteamApps_GetLaunchCommandLine(IntPtr instancePtr, IntPtr pszCommandLine, int cubCommandLine); // 0x00000001802A9A10-0x00000001802A9AB0
		public static extern bool ISteamApps_BIsSubscribedFromFamilySharing(IntPtr instancePtr); // 0x00000001802A9180-0x00000001802A9200
		public static extern int ISteamClient_CreateSteamPipe(IntPtr instancePtr); // 0x00000001802AA090-0x00000001802AA110
		public static extern bool ISteamClient_BReleaseSteamPipe(IntPtr instancePtr, HSteamPipe hSteamPipe); // 0x00000001802A9E50-0x00000001802A9EE0
		public static extern int ISteamClient_ConnectToGlobalUser(IntPtr instancePtr, HSteamPipe hSteamPipe); // 0x00000001802A9F60-0x00000001802A9FF0
		public static extern int ISteamClient_CreateLocalUser(IntPtr instancePtr, out HSteamPipe phSteamPipe, EAccountType eAccountType); // 0x00000001802A9FF0-0x00000001802AA090
		public static extern void ISteamClient_ReleaseUser(IntPtr instancePtr, HSteamPipe hSteamPipe, HSteamUser hUser); // 0x00000001802ABAD0-0x00000001802ABB70
		public static extern IntPtr ISteamClient_GetISteamUser(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AB810-0x00000001802AB900
		public static extern IntPtr ISteamClient_GetISteamGameServer(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AA730-0x00000001802AA820
		public static extern void ISteamClient_SetLocalIPBinding(IntPtr instancePtr, ref SteamIPAddress_t unIP, ushort usPort); // 0x00000001802ABB70-0x00000001802ABC10
		public static extern IntPtr ISteamClient_GetISteamFriends(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AA460-0x00000001802AA550
		public static extern IntPtr ISteamClient_GetISteamUtils(IntPtr instancePtr, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AB900-0x00000001802AB9E0
		public static extern IntPtr ISteamClient_GetISteamMatchmaking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AADC0-0x00000001802AAEB0
		public static extern IntPtr ISteamClient_GetISteamMatchmakingServers(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AACD0-0x00000001802AADC0
		public static extern IntPtr ISteamClient_GetISteamGenericInterface(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AA820-0x00000001802AA910
		public static extern IntPtr ISteamClient_GetISteamUserStats(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AB720-0x00000001802AB810
		public static extern IntPtr ISteamClient_GetISteamGameServerStats(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AA640-0x00000001802AA730
		public static extern IntPtr ISteamClient_GetISteamApps(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AA280-0x00000001802AA370
		public static extern IntPtr ISteamClient_GetISteamNetworking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AB090-0x00000001802AB180
		public static extern IntPtr ISteamClient_GetISteamRemoteStorage(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AB450-0x00000001802AB540
		public static extern IntPtr ISteamClient_GetISteamScreenshots(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AB540-0x00000001802AB630
		public static extern IntPtr ISteamClient_GetISteamGameSearch(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AA550-0x00000001802AA640
		public static extern uint ISteamClient_GetIPCCallCount(IntPtr instancePtr); // 0x00000001802AA110-0x00000001802AA190
		public static extern void ISteamClient_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction); // 0x00000001802ABC10-0x00000001802ABCB0
		public static extern bool ISteamClient_BShutdownIfAllPipesClosed(IntPtr instancePtr); // 0x00000001802A9EE0-0x00000001802A9F60
		public static extern IntPtr ISteamClient_GetISteamHTTP(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AAA00-0x00000001802AAAF0
		public static extern IntPtr ISteamClient_GetISteamController(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AA370-0x00000001802AA460
		public static extern IntPtr ISteamClient_GetISteamUGC(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AB630-0x00000001802AB720
		public static extern IntPtr ISteamClient_GetISteamAppList(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AA190-0x00000001802AA280
		public static extern IntPtr ISteamClient_GetISteamMusic(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AAFA0-0x00000001802AB090
		public static extern IntPtr ISteamClient_GetISteamMusicRemote(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AAEB0-0x00000001802AAFA0
		public static extern IntPtr ISteamClient_GetISteamHTMLSurface(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AA910-0x00000001802AAA00
		public static extern IntPtr ISteamClient_GetISteamInventory(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AABE0-0x00000001802AACD0
		public static extern IntPtr ISteamClient_GetISteamVideo(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AB9E0-0x00000001802ABAD0
		public static extern IntPtr ISteamClient_GetISteamParentalSettings(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AB180-0x00000001802AB270
		public static extern IntPtr ISteamClient_GetISteamInput(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AAAF0-0x00000001802AABE0
		public static extern IntPtr ISteamClient_GetISteamParties(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AB270-0x00000001802AB360
		public static extern IntPtr ISteamClient_GetISteamRemotePlay(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion); // 0x00000001802AB360-0x00000001802AB450
		public static extern bool ISteamController_Init(IntPtr instancePtr); // 0x00000001802ACC70-0x00000001802ACCF0
		public static extern bool ISteamController_Shutdown(IntPtr instancePtr); // 0x00000001802ACEC0-0x00000001802ACF40
		public static extern void ISteamController_RunFrame(IntPtr instancePtr); // 0x00000001802ACCF0-0x00000001802ACD70
		public static extern int ISteamController_GetConnectedControllers(IntPtr instancePtr, [In, Out] ControllerHandle_t[] handlesOut); // 0x00000001802AC3A0-0x00000001802AC440
		public static extern ulong ISteamController_GetActionSetHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionSetName); // 0x00000001802ABFC0-0x00000001802AC0A0
		public static extern void ISteamController_ActivateActionSet(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle); // 0x00000001802ABD50-0x00000001802ABDF0
		public static extern ulong ISteamController_GetCurrentActionSet(IntPtr instancePtr, ControllerHandle_t controllerHandle); // 0x00000001802AC580-0x00000001802AC610
		public static extern void ISteamController_ActivateActionSetLayer(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle); // 0x00000001802ABCB0-0x00000001802ABD50
		public static extern void ISteamController_DeactivateActionSetLayer(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle); // 0x00000001802ABDF0-0x00000001802ABE90
		public static extern void ISteamController_DeactivateAllActionSetLayers(IntPtr instancePtr, ControllerHandle_t controllerHandle); // 0x00000001802ABE90-0x00000001802ABF20
		public static extern int ISteamController_GetActiveActionSetLayers(IntPtr instancePtr, ControllerHandle_t controllerHandle, [In, Out] ControllerActionSetHandle_t[] handlesOut); // 0x00000001802AC0A0-0x00000001802AC140
		public static extern ulong ISteamController_GetDigitalActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName); // 0x00000001802AC6B0-0x00000001802AC790
		public static extern InputDigitalActionData_t ISteamController_GetDigitalActionData(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle); // 0x00000001802AC610-0x00000001802AC6B0
		public static extern int ISteamController_GetDigitalActionOrigins(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, [In, Out] EControllerActionOrigin[] originsOut); // 0x00000001802AC790-0x00000001802AC850
		public static extern ulong ISteamController_GetAnalogActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName); // 0x00000001802AC200-0x00000001802AC2E0
		public static extern InputAnalogActionData_t ISteamController_GetAnalogActionData(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle); // 0x00000001802AC140-0x00000001802AC200
		public static extern int ISteamController_GetAnalogActionOrigins(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, [In, Out] EControllerActionOrigin[] originsOut); // 0x00000001802AC2E0-0x00000001802AC3A0
		public static extern IntPtr ISteamController_GetGlyphForActionOrigin(IntPtr instancePtr, EControllerActionOrigin eOrigin); // 0x00000001802AC8E0-0x00000001802AC970
		public static extern IntPtr ISteamController_GetStringForActionOrigin(IntPtr instancePtr, EControllerActionOrigin eOrigin); // 0x00000001802ACB50-0x00000001802ACBE0
		public static extern void ISteamController_StopAnalogActionMomentum(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction); // 0x00000001802ACF40-0x00000001802ACFE0
		public static extern InputMotionData_t ISteamController_GetMotionData(IntPtr instancePtr, ControllerHandle_t controllerHandle); // 0x00000001802ACA90-0x00000001802ACB50
		public static extern void ISteamController_TriggerHapticPulse(IntPtr instancePtr, ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec); // 0x00000001802AD080-0x00000001802AD130
		public static extern void ISteamController_TriggerRepeatedHapticPulse(IntPtr instancePtr, ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags); // 0x00000001802AD130-0x00000001802AD200
		public static extern void ISteamController_TriggerVibration(IntPtr instancePtr, ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed); // 0x00000001802AD200-0x00000001802AD2B0
		public static extern void ISteamController_SetLEDColor(IntPtr instancePtr, ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags); // 0x00000001802ACD70-0x00000001802ACE30
		public static extern bool ISteamController_ShowBindingPanel(IntPtr instancePtr, ControllerHandle_t controllerHandle); // 0x00000001802ACE30-0x00000001802ACEC0
		public static extern ESteamInputType ISteamController_GetInputTypeForHandle(IntPtr instancePtr, ControllerHandle_t controllerHandle); // 0x00000001802ACA00-0x00000001802ACA90
		public static extern ulong ISteamController_GetControllerForGamepadIndex(IntPtr instancePtr, int nIndex); // 0x00000001802AC4F0-0x00000001802AC580
		public static extern int ISteamController_GetGamepadIndexForController(IntPtr instancePtr, ControllerHandle_t ulControllerHandle); // 0x00000001802AC850-0x00000001802AC8E0
		public static extern IntPtr ISteamController_GetStringForXboxOrigin(IntPtr instancePtr, EXboxOrigin eOrigin); // 0x00000001802ACBE0-0x00000001802ACC70
		public static extern IntPtr ISteamController_GetGlyphForXboxOrigin(IntPtr instancePtr, EXboxOrigin eOrigin); // 0x00000001802AC970-0x00000001802ACA00
		public static extern EControllerActionOrigin ISteamController_GetActionOriginFromXboxOrigin(IntPtr instancePtr, ControllerHandle_t controllerHandle, EXboxOrigin eOrigin); // 0x00000001802ABF20-0x00000001802ABFC0
		public static extern EControllerActionOrigin ISteamController_TranslateActionOrigin(IntPtr instancePtr, ESteamInputType eDestinationInputType, EControllerActionOrigin eSourceOrigin); // 0x00000001802ACFE0-0x00000001802AD080
		public static extern bool ISteamController_GetControllerBindingRevision(IntPtr instancePtr, ControllerHandle_t controllerHandle, out int pMajor, out int pMinor); // 0x00000001802AC440-0x00000001802AC4F0
		public static extern IntPtr ISteamFriends_GetPersonaName(IntPtr instancePtr); // 0x00000001802AEFE0-0x00000001802AF060
		public static extern ulong ISteamFriends_SetPersonaName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchPersonaName); // 0x00000001802AFDE0-0x00000001802AFEC0
		public static extern EPersonaState ISteamFriends_GetPersonaState(IntPtr instancePtr); // 0x00000001802AF060-0x00000001802AF0E0
		public static extern int ISteamFriends_GetFriendCount(IntPtr instancePtr, EFriendFlags iFriendFlags); // 0x00000001802AE3E0-0x00000001802AE470
		public static extern ulong ISteamFriends_GetFriendByIndex(IntPtr instancePtr, int iFriend, EFriendFlags iFriendFlags); // 0x00000001802AE190-0x00000001802AE230
		public static extern EFriendRelationship ISteamFriends_GetFriendRelationship(IntPtr instancePtr, CSteamID steamIDFriend); // 0x00000001802AE830-0x00000001802AE8C0
		public static extern EPersonaState ISteamFriends_GetFriendPersonaState(IntPtr instancePtr, CSteamID steamIDFriend); // 0x00000001802AE7A0-0x00000001802AE830
		public static extern IntPtr ISteamFriends_GetFriendPersonaName(IntPtr instancePtr, CSteamID steamIDFriend); // 0x00000001802AE710-0x00000001802AE7A0
		public static extern bool ISteamFriends_GetFriendGamePlayed(IntPtr instancePtr, CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo); // 0x00000001802AE510-0x00000001802AE5B0
		public static extern IntPtr ISteamFriends_GetFriendPersonaNameHistory(IntPtr instancePtr, CSteamID steamIDFriend, int iPersonaName); // 0x00000001802AE670-0x00000001802AE710
		public static extern int ISteamFriends_GetFriendSteamLevel(IntPtr instancePtr, CSteamID steamIDFriend); // 0x00000001802AEAD0-0x00000001802AEB60
		public static extern IntPtr ISteamFriends_GetPlayerNickname(IntPtr instancePtr, CSteamID steamIDPlayer); // 0x00000001802AF0E0-0x00000001802AF170
		public static extern int ISteamFriends_GetFriendsGroupCount(IntPtr instancePtr); // 0x00000001802AEB60-0x00000001802AEBE0
		public static extern short ISteamFriends_GetFriendsGroupIDByIndex(IntPtr instancePtr, int iFG); // 0x00000001802AEBE0-0x00000001802AEC70
		public static extern IntPtr ISteamFriends_GetFriendsGroupName(IntPtr instancePtr, FriendsGroupID_t friendsGroupID); // 0x00000001802AEDB0-0x00000001802AEE40
		public static extern int ISteamFriends_GetFriendsGroupMembersCount(IntPtr instancePtr, FriendsGroupID_t friendsGroupID); // 0x00000001802AEC70-0x00000001802AED00
		public static extern void ISteamFriends_GetFriendsGroupMembersList(IntPtr instancePtr, FriendsGroupID_t friendsGroupID, [In, Out] CSteamID[] pOutSteamIDMembers, int nMembersCount); // 0x00000001802AED00-0x00000001802AEDB0
		public static extern bool ISteamFriends_HasFriend(IntPtr instancePtr, CSteamID steamIDFriend, EFriendFlags iFriendFlags); // 0x00000001802AF280-0x00000001802AF320
		public static extern int ISteamFriends_GetClanCount(IntPtr instancePtr); // 0x00000001802ADC90-0x00000001802ADD10
		public static extern ulong ISteamFriends_GetClanByIndex(IntPtr instancePtr, int iClan); // 0x00000001802ADAA0-0x00000001802ADB30
		public static extern IntPtr ISteamFriends_GetClanName(IntPtr instancePtr, CSteamID steamIDClan); // 0x00000001802ADD10-0x00000001802ADDA0
		public static extern IntPtr ISteamFriends_GetClanTag(IntPtr instancePtr, CSteamID steamIDClan); // 0x00000001802ADF60-0x00000001802ADFF0
		public static extern bool ISteamFriends_GetClanActivityCounts(IntPtr instancePtr, CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting); // 0x00000001802AD9E0-0x00000001802ADAA0
		public static extern ulong ISteamFriends_DownloadClanActivityCounts(IntPtr instancePtr, [In, Out] CSteamID[] psteamIDClans, int cClansToRequest); // 0x00000001802AD810-0x00000001802AD8B0
		public static extern int ISteamFriends_GetFriendCountFromSource(IntPtr instancePtr, CSteamID steamIDSource); // 0x00000001802AE350-0x00000001802AE3E0
		public static extern ulong ISteamFriends_GetFriendFromSourceByIndex(IntPtr instancePtr, CSteamID steamIDSource, int iFriend); // 0x00000001802AE470-0x00000001802AE510
		public static extern bool ISteamFriends_IsUserInSource(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDSource); // 0x00000001802AF6E0-0x00000001802AF780
		public static extern void ISteamFriends_SetInGameVoiceSpeaking(IntPtr instancePtr, CSteamID steamIDUser, bool bSpeaking); // 0x00000001802AFCB0-0x00000001802AFD50
		public static extern void ISteamFriends_ActivateGameOverlay(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog); // 0x00000001802AD630-0x00000001802AD700
		public static extern void ISteamFriends_ActivateGameOverlayToUser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog, CSteamID steamID); // 0x00000001802AD470-0x00000001802AD550
		public static extern void ISteamFriends_ActivateGameOverlayToWebPage(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchURL, EActivateGameOverlayToWebPageMode eMode); // 0x00000001802AD550-0x00000001802AD630
		public static extern void ISteamFriends_ActivateGameOverlayToStore(IntPtr instancePtr, AppId_t nAppID, EOverlayToStoreFlag eFlag); // 0x00000001802AD3D0-0x00000001802AD470
		public static extern void ISteamFriends_SetPlayedWith(IntPtr instancePtr, CSteamID steamIDUserPlayedWith); // 0x00000001802AFEC0-0x00000001802AFF50
		public static extern void ISteamFriends_ActivateGameOverlayInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby); // 0x00000001802AD2B0-0x00000001802AD340
		public static extern int ISteamFriends_GetSmallFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend); // 0x00000001802AF170-0x00000001802AF200
		public static extern int ISteamFriends_GetMediumFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend); // 0x00000001802AEED0-0x00000001802AEF60
		public static extern int ISteamFriends_GetLargeFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend); // 0x00000001802AEE40-0x00000001802AEED0
		public static extern bool ISteamFriends_RequestUserInformation(IntPtr instancePtr, CSteamID steamIDUser, bool bRequireNameOnly); // 0x00000001802AFB30-0x00000001802AFBD0
		public static extern ulong ISteamFriends_RequestClanOfficerList(IntPtr instancePtr, CSteamID steamIDClan); // 0x00000001802AFA10-0x00000001802AFAA0
		public static extern ulong ISteamFriends_GetClanOwner(IntPtr instancePtr, CSteamID steamIDClan); // 0x00000001802ADED0-0x00000001802ADF60
		public static extern int ISteamFriends_GetClanOfficerCount(IntPtr instancePtr, CSteamID steamIDClan); // 0x00000001802ADE40-0x00000001802ADED0
		public static extern ulong ISteamFriends_GetClanOfficerByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iOfficer); // 0x00000001802ADDA0-0x00000001802ADE40
		public static extern uint ISteamFriends_GetUserRestrictions(IntPtr instancePtr); // 0x00000001802AF200-0x00000001802AF280
		public static extern bool ISteamFriends_SetRichPresence(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue); // 0x00000001802AFF50-0x00000001802B0090
		public static extern void ISteamFriends_ClearRichPresence(IntPtr instancePtr); // 0x00000001802AD700-0x00000001802AD780
		public static extern IntPtr ISteamFriends_GetFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchKey); // 0x00000001802AE9F0-0x00000001802AEAD0
		public static extern int ISteamFriends_GetFriendRichPresenceKeyCount(IntPtr instancePtr, CSteamID steamIDFriend); // 0x00000001802AE960-0x00000001802AE9F0
		public static extern IntPtr ISteamFriends_GetFriendRichPresenceKeyByIndex(IntPtr instancePtr, CSteamID steamIDFriend, int iKey); // 0x00000001802AE8C0-0x00000001802AE960
		public static extern void ISteamFriends_RequestFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend); // 0x00000001802AFAA0-0x00000001802AFB30
		public static extern bool ISteamFriends_InviteUserToGame(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchConnectString); // 0x00000001802AF320-0x00000001802AF400
		public static extern int ISteamFriends_GetCoplayFriendCount(IntPtr instancePtr); // 0x00000001802ADFF0-0x00000001802AE070
		public static extern ulong ISteamFriends_GetCoplayFriend(IntPtr instancePtr, int iCoplayFriend); // 0x00000001802AE070-0x00000001802AE100
		public static extern int ISteamFriends_GetFriendCoplayTime(IntPtr instancePtr, CSteamID steamIDFriend); // 0x00000001802AE2C0-0x00000001802AE350
		public static extern uint ISteamFriends_GetFriendCoplayGame(IntPtr instancePtr, CSteamID steamIDFriend); // 0x00000001802AE230-0x00000001802AE2C0
		public static extern ulong ISteamFriends_JoinClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan); // 0x00000001802AF780-0x00000001802AF810
		public static extern bool ISteamFriends_LeaveClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan); // 0x00000001802AF810-0x00000001802AF8A0
		public static extern int ISteamFriends_GetClanChatMemberCount(IntPtr instancePtr, CSteamID steamIDClan); // 0x00000001802ADB30-0x00000001802ADBC0
		public static extern ulong ISteamFriends_GetChatMemberByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iUser); // 0x00000001802AD940-0x00000001802AD9E0
		public static extern bool ISteamFriends_SendClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, InteropHelp.UTF8StringHandle pchText); // 0x00000001802AFBD0-0x00000001802AFCB0
		public static extern int ISteamFriends_GetClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter); // 0x00000001802ADBC0-0x00000001802ADC90
		public static extern bool ISteamFriends_IsClanChatAdmin(IntPtr instancePtr, CSteamID steamIDClanChat, CSteamID steamIDUser); // 0x00000001802AF400-0x00000001802AF4A0
		public static extern bool ISteamFriends_IsClanChatWindowOpenInSteam(IntPtr instancePtr, CSteamID steamIDClanChat); // 0x00000001802AF4A0-0x00000001802AF530
		public static extern bool ISteamFriends_OpenClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat); // 0x00000001802AF8A0-0x00000001802AF930
		public static extern bool ISteamFriends_CloseClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat); // 0x00000001802AD780-0x00000001802AD810
		public static extern bool ISteamFriends_SetListenForFriendsMessages(IntPtr instancePtr, bool bInterceptEnabled); // 0x00000001802AFD50-0x00000001802AFDE0
		public static extern bool ISteamFriends_ReplyToFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchMsgToSend); // 0x00000001802AF930-0x00000001802AFA10
		public static extern int ISteamFriends_GetFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType); // 0x00000001802AE5B0-0x00000001802AE670
		public static extern ulong ISteamFriends_GetFollowerCount(IntPtr instancePtr, CSteamID steamID); // 0x00000001802AE100-0x00000001802AE190
		public static extern ulong ISteamFriends_IsFollowing(IntPtr instancePtr, CSteamID steamID); // 0x00000001802AF650-0x00000001802AF6E0
		public static extern ulong ISteamFriends_EnumerateFollowingList(IntPtr instancePtr, uint unStartIndex); // 0x00000001802AD8B0-0x00000001802AD940
		public static extern bool ISteamFriends_IsClanPublic(IntPtr instancePtr, CSteamID steamIDClan); // 0x00000001802AF5C0-0x00000001802AF650
		public static extern bool ISteamFriends_IsClanOfficialGameGroup(IntPtr instancePtr, CSteamID steamIDClan); // 0x00000001802AF530-0x00000001802AF5C0
		public static extern int ISteamFriends_GetNumChatsWithUnreadPriorityMessages(IntPtr instancePtr); // 0x00000001802AEF60-0x00000001802AEFE0
		public static extern void ISteamFriends_ActivateGameOverlayRemotePlayTogetherInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby); // 0x00000001802AD340-0x00000001802AD3D0
		public static extern void ISteamGameServer_SetProduct(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszProduct); // 0x00000001802B2A50-0x00000001802B2B20
		public static extern void ISteamGameServer_SetGameDescription(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszGameDescription); // 0x00000001802B2430-0x00000001802B2500
		public static extern void ISteamGameServer_SetModDir(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszModDir); // 0x00000001802B28F0-0x00000001802B29C0
		public static extern void ISteamGameServer_SetDedicatedServer(IntPtr instancePtr, bool bDedicated); // 0x00000001802B22D0-0x00000001802B2360
		public static extern void ISteamGameServer_LogOn(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszToken); // 0x00000001802B1F80-0x00000001802B2050
		public static extern void ISteamGameServer_LogOnAnonymous(IntPtr instancePtr); // 0x00000001802B1F00-0x00000001802B1F80
		public static extern void ISteamGameServer_LogOff(IntPtr instancePtr); // 0x00000001802B1E80-0x00000001802B1F00
		public static extern bool ISteamGameServer_BLoggedOn(IntPtr instancePtr); // 0x00000001802B13C0-0x00000001802B1440
		public static extern bool ISteamGameServer_BSecure(IntPtr instancePtr); // 0x00000001802B1440-0x00000001802B14C0
		public static extern ulong ISteamGameServer_GetSteamID(IntPtr instancePtr); // 0x00000001802B1D30-0x00000001802B1DB0
		public static extern bool ISteamGameServer_WasRestartRequested(IntPtr instancePtr); // 0x00000001802B2EC0-0x00000001802B2F40
		public static extern void ISteamGameServer_SetMaxPlayerCount(IntPtr instancePtr, int cPlayersMax); // 0x00000001802B2860-0x00000001802B28F0
		public static extern void ISteamGameServer_SetBotPlayerCount(IntPtr instancePtr, int cBotplayers); // 0x00000001802B2240-0x00000001802B22D0
		public static extern void ISteamGameServer_SetServerName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszServerName); // 0x00000001802B2BF0-0x00000001802B2CC0
		public static extern void ISteamGameServer_SetMapName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszMapName); // 0x00000001802B2790-0x00000001802B2860
		public static extern void ISteamGameServer_SetPasswordProtected(IntPtr instancePtr, bool bPasswordProtected); // 0x00000001802B29C0-0x00000001802B2A50
		public static extern void ISteamGameServer_SetSpectatorPort(IntPtr instancePtr, ushort unSpectatorPort); // 0x00000001802B2CC0-0x00000001802B2D50
		public static extern void ISteamGameServer_SetSpectatorServerName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszSpectatorServerName); // 0x00000001802B2D50-0x00000001802B2E20
		public static extern void ISteamGameServer_ClearAllKeyValues(IntPtr instancePtr); // 0x00000001802B16F0-0x00000001802B1770
		public static extern void ISteamGameServer_SetKeyValue(IntPtr instancePtr, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue); // 0x00000001802B2660-0x00000001802B2790
		public static extern void ISteamGameServer_SetGameTags(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchGameTags); // 0x00000001802B2500-0x00000001802B25D0
		public static extern void ISteamGameServer_SetGameData(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchGameData); // 0x00000001802B2360-0x00000001802B2430
		public static extern void ISteamGameServer_SetRegion(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszRegion); // 0x00000001802B2B20-0x00000001802B2BF0
		public static extern bool ISteamGameServer_SendUserConnectAndAuthenticate(IntPtr instancePtr, uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser); // 0x00000001802B20F0-0x00000001802B21B0
		public static extern ulong ISteamGameServer_CreateUnauthenticatedUserConnection(IntPtr instancePtr); // 0x00000001802B1800-0x00000001802B1880
		public static extern void ISteamGameServer_SendUserDisconnect(IntPtr instancePtr, CSteamID steamIDUser); // 0x00000001802B21B0-0x00000001802B2240
		public static extern bool ISteamGameServer_BUpdateUserData(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchPlayerName, uint uScore); // 0x00000001802B14C0-0x00000001802B15B0
		public static extern uint ISteamGameServer_GetAuthSessionTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket); // 0x00000001802B1A20-0x00000001802B1AD0
		public static extern EBeginAuthSessionResult ISteamGameServer_BeginAuthSession(IntPtr instancePtr, byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID); // 0x00000001802B15B0-0x00000001802B1660
		public static extern void ISteamGameServer_EndAuthSession(IntPtr instancePtr, CSteamID steamID); // 0x00000001802B1910-0x00000001802B19A0
		public static extern void ISteamGameServer_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket); // 0x00000001802B1660-0x00000001802B16F0
		public static extern EUserHasLicenseForAppResult ISteamGameServer_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID); // 0x00000001802B2E20-0x00000001802B2EC0
		public static extern bool ISteamGameServer_RequestUserGroupStatus(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDGroup); // 0x00000001802B2050-0x00000001802B20F0
		public static extern void ISteamGameServer_GetGameplayStats(IntPtr instancePtr); // 0x00000001802B1AD0-0x00000001802B1B50
		public static extern ulong ISteamGameServer_GetServerReputation(IntPtr instancePtr); // 0x00000001802B1CB0-0x00000001802B1D30
		public static extern SteamIPAddress_t ISteamGameServer_GetPublicIP(IntPtr instancePtr); // 0x00000001802B1C10-0x00000001802B1CB0
		public static extern bool ISteamGameServer_HandleIncomingPacket(IntPtr instancePtr, byte[] pData, int cbData, uint srcIP, ushort srcPort); // 0x00000001802B1DB0-0x00000001802B1E80
		public static extern int ISteamGameServer_GetNextOutgoingPacket(IntPtr instancePtr, byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort); // 0x00000001802B1B50-0x00000001802B1C10
		public static extern void ISteamGameServer_EnableHeartbeats(IntPtr instancePtr, bool bActive); // 0x00000001802B1880-0x00000001802B1910
		public static extern void ISteamGameServer_SetHeartbeatInterval(IntPtr instancePtr, int iHeartbeatInterval); // 0x00000001802B25D0-0x00000001802B2660
		public static extern void ISteamGameServer_ForceHeartbeat(IntPtr instancePtr); // 0x00000001802B19A0-0x00000001802B1A20
		public static extern ulong ISteamGameServer_AssociateWithClan(IntPtr instancePtr, CSteamID steamIDClan); // 0x00000001802B1330-0x00000001802B13C0
		public static extern ulong ISteamGameServer_ComputeNewPlayerCompatibility(IntPtr instancePtr, CSteamID steamIDNewPlayer); // 0x00000001802B1770-0x00000001802B1800
		public static extern ulong ISteamGameServerStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser); // 0x00000001802B0E30-0x00000001802B0EC0
		public static extern bool ISteamGameServerStats_GetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData); // 0x00000001802B0D40-0x00000001802B0E30
		public static extern bool ISteamGameServerStats_GetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData); // 0x00000001802B0C50-0x00000001802B0D40
		public static extern bool ISteamGameServerStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved); // 0x00000001802B0B40-0x00000001802B0C50
		public static extern bool ISteamGameServerStats_SetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, int nData); // 0x00000001802B10A0-0x00000001802B1190
		public static extern bool ISteamGameServerStats_SetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float fData); // 0x00000001802B0FA0-0x00000001802B10A0
		public static extern bool ISteamGameServerStats_UpdateUserAvgRateStat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength); // 0x00000001802B1220-0x00000001802B1330
		public static extern bool ISteamGameServerStats_SetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName); // 0x00000001802B0EC0-0x00000001802B0FA0
		public static extern bool ISteamGameServerStats_ClearUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName); // 0x00000001802B0A60-0x00000001802B0B40
		public static extern ulong ISteamGameServerStats_StoreUserStats(IntPtr instancePtr, CSteamID steamIDUser); // 0x00000001802B1190-0x00000001802B1220
		public static extern bool ISteamHTMLSurface_Init(IntPtr instancePtr); // 0x00000001802B3740-0x00000001802B37C0
		public static extern bool ISteamHTMLSurface_Shutdown(IntPtr instancePtr); // 0x00000001802B47B0-0x00000001802B4830
		public static extern ulong ISteamHTMLSurface_CreateBrowser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchUserAgent, InteropHelp.UTF8StringHandle pchUserCSS); // 0x00000001802B31C0-0x00000001802B3300
		public static extern void ISteamHTMLSurface_RemoveBrowser(IntPtr instancePtr, HHTMLBrowser unBrowserHandle); // 0x00000001802B4070-0x00000001802B4100
		public static extern void ISteamHTMLSurface_LoadURL(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchURL, InteropHelp.UTF8StringHandle pchPostData); // 0x00000001802B3A50-0x00000001802B3BA0
		public static extern void ISteamHTMLSurface_SetSize(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight); // 0x00000001802B4670-0x00000001802B4710
		public static extern void ISteamHTMLSurface_StopLoad(IntPtr instancePtr, HHTMLBrowser unBrowserHandle); // 0x00000001802B48C0-0x00000001802B4950
		public static extern void ISteamHTMLSurface_Reload(IntPtr instancePtr, HHTMLBrowser unBrowserHandle); // 0x00000001802B3FE0-0x00000001802B4070
		public static extern void ISteamHTMLSurface_GoBack(IntPtr instancePtr, HHTMLBrowser unBrowserHandle); // 0x00000001802B3620-0x00000001802B36B0
		public static extern void ISteamHTMLSurface_GoForward(IntPtr instancePtr, HHTMLBrowser unBrowserHandle); // 0x00000001802B36B0-0x00000001802B3740
		public static extern void ISteamHTMLSurface_AddHeader(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue); // 0x00000001802B2F40-0x00000001802B3090
		public static extern void ISteamHTMLSurface_ExecuteJavascript(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchScript); // 0x00000001802B3300-0x00000001802B33E0
		public static extern void ISteamHTMLSurface_MouseUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton); // 0x00000001802B3D80-0x00000001802B3E20
		public static extern void ISteamHTMLSurface_MouseDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton); // 0x00000001802B3C40-0x00000001802B3CE0
		public static extern void ISteamHTMLSurface_MouseDoubleClick(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton); // 0x00000001802B3BA0-0x00000001802B3C40
		public static extern void ISteamHTMLSurface_MouseMove(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y); // 0x00000001802B3CE0-0x00000001802B3D80
		public static extern void ISteamHTMLSurface_MouseWheel(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int nDelta); // 0x00000001802B3E20-0x00000001802B3EC0
		public static extern void ISteamHTMLSurface_KeyDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey); // 0x00000001802B3900-0x00000001802B39B0
		public static extern void ISteamHTMLSurface_KeyUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers); // 0x00000001802B39B0-0x00000001802B3A50
		public static extern void ISteamHTMLSurface_KeyChar(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers); // 0x00000001802B3860-0x00000001802B3900
		public static extern void ISteamHTMLSurface_SetHorizontalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll); // 0x00000001802B4480-0x00000001802B4520
		public static extern void ISteamHTMLSurface_SetVerticalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll); // 0x00000001802B4710-0x00000001802B47B0
		public static extern void ISteamHTMLSurface_SetKeyFocus(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bHasKeyFocus); // 0x00000001802B4520-0x00000001802B45C0
		public static extern void ISteamHTMLSurface_ViewSource(IntPtr instancePtr, HHTMLBrowser unBrowserHandle); // 0x00000001802B4950-0x00000001802B49E0
		public static extern void ISteamHTMLSurface_CopyToClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle); // 0x00000001802B3130-0x00000001802B31C0
		public static extern void ISteamHTMLSurface_PasteFromClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle); // 0x00000001802B3F50-0x00000001802B3FE0
		public static extern void ISteamHTMLSurface_Find(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchSearchStr, bool bCurrentlyInFind, bool bReverse); // 0x00000001802B3480-0x00000001802B3580
		public static extern void ISteamHTMLSurface_StopFind(IntPtr instancePtr, HHTMLBrowser unBrowserHandle); // 0x00000001802B4830-0x00000001802B48C0
		public static extern void ISteamHTMLSurface_GetLinkAtPosition(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y); // 0x00000001802B3580-0x00000001802B3620
		public static extern void ISteamHTMLSurface_SetCookie(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchHostname, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue, InteropHelp.UTF8StringHandle pchPath, uint nExpires, bool bSecure, bool bHTTPOnly); // 0x00000001802B41A0-0x00000001802B43E0
		public static extern void ISteamHTMLSurface_SetPageScaleFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY); // 0x00000001802B45C0-0x00000001802B4670
		public static extern void ISteamHTMLSurface_SetBackgroundMode(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bBackgroundMode); // 0x00000001802B4100-0x00000001802B41A0
		public static extern void ISteamHTMLSurface_SetDPIScalingFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flDPIScaling); // 0x00000001802B43E0-0x00000001802B4480
		public static extern void ISteamHTMLSurface_OpenDeveloperTools(IntPtr instancePtr, HHTMLBrowser unBrowserHandle); // 0x00000001802B3EC0-0x00000001802B3F50
		public static extern void ISteamHTMLSurface_AllowStartRequest(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bAllowed); // 0x00000001802B3090-0x00000001802B3130
		public static extern void ISteamHTMLSurface_JSDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bResult); // 0x00000001802B37C0-0x00000001802B3860
		public static extern void ISteamHTMLSurface_FileLoadDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles); // 0x00000001802B33E0-0x00000001802B3480
		public static extern uint ISteamHTTP_CreateHTTPRequest(IntPtr instancePtr, EHTTPMethod eHTTPRequestMethod, InteropHelp.UTF8StringHandle pchAbsoluteURL); // 0x00000001802B4A70-0x00000001802B4B50
		public static extern bool ISteamHTTP_SetHTTPRequestContextValue(IntPtr instancePtr, HTTPRequestHandle hRequest, ulong ulContextValue); // 0x00000001802B5690-0x00000001802B5730
		public static extern bool ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unTimeoutSeconds); // 0x00000001802B5A70-0x00000001802B5B10
		public static extern bool ISteamHTTP_SetHTTPRequestHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, InteropHelp.UTF8StringHandle pchHeaderValue); // 0x00000001802B5920-0x00000001802B5A70
		public static extern bool ISteamHTTP_SetHTTPRequestGetOrPostParameter(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchParamName, InteropHelp.UTF8StringHandle pchParamValue); // 0x00000001802B57D0-0x00000001802B5920
		public static extern bool ISteamHTTP_SendHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle); // 0x00000001802B5390-0x00000001802B5430
		public static extern bool ISteamHTTP_SendHTTPRequestAndStreamResponse(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle); // 0x00000001802B52F0-0x00000001802B5390
		public static extern bool ISteamHTTP_DeferHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest); // 0x00000001802B4B50-0x00000001802B4BE0
		public static extern bool ISteamHTTP_PrioritizeHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest); // 0x00000001802B5140-0x00000001802B51D0
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderSize(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, out uint unResponseHeaderSize); // 0x00000001802B4E80-0x00000001802B4F70
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize); // 0x00000001802B4F70-0x00000001802B5080
		public static extern bool ISteamHTTP_GetHTTPResponseBodySize(IntPtr instancePtr, HTTPRequestHandle hRequest, out uint unBodySize); // 0x00000001802B4DE0-0x00000001802B4E80
		public static extern bool ISteamHTTP_GetHTTPResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize); // 0x00000001802B4D30-0x00000001802B4DE0
		public static extern bool ISteamHTTP_GetHTTPStreamingResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize); // 0x00000001802B5080-0x00000001802B5140
		public static extern bool ISteamHTTP_ReleaseHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest); // 0x00000001802B5260-0x00000001802B52F0
		public static extern bool ISteamHTTP_GetHTTPDownloadProgressPct(IntPtr instancePtr, HTTPRequestHandle hRequest, out float pflPercentOut); // 0x00000001802B4BE0-0x00000001802B4C80
		public static extern bool ISteamHTTP_SetHTTPRequestRawPostBody(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchContentType, byte[] pubBody, uint unBodyLen); // 0x00000001802B5B10-0x00000001802B5C20
		public static extern uint ISteamHTTP_CreateCookieContainer(IntPtr instancePtr, bool bAllowResponsesToModify); // 0x00000001802B49E0-0x00000001802B4A70
		public static extern bool ISteamHTTP_ReleaseCookieContainer(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer); // 0x00000001802B51D0-0x00000001802B5260
		public static extern bool ISteamHTTP_SetCookie(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer, InteropHelp.UTF8StringHandle pchHost, InteropHelp.UTF8StringHandle pchUrl, InteropHelp.UTF8StringHandle pchCookie); // 0x00000001802B5430-0x00000001802B55F0
		public static extern bool ISteamHTTP_SetHTTPRequestCookieContainer(IntPtr instancePtr, HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer); // 0x00000001802B5730-0x00000001802B57D0
		public static extern bool ISteamHTTP_SetHTTPRequestUserAgentInfo(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchUserAgentInfo); // 0x00000001802B5CC0-0x00000001802B5DA0
		public static extern bool ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(IntPtr instancePtr, HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate); // 0x00000001802B5C20-0x00000001802B5CC0
		public static extern bool ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unMilliseconds); // 0x00000001802B55F0-0x00000001802B5690
		public static extern bool ISteamHTTP_GetHTTPRequestWasTimedOut(IntPtr instancePtr, HTTPRequestHandle hRequest, out bool pbWasTimedOut); // 0x00000001802B4C80-0x00000001802B4D30
		public static extern bool ISteamInput_Init(IntPtr instancePtr); // 0x00000001802B6DF0-0x00000001802B6E70
		public static extern bool ISteamInput_Shutdown(IntPtr instancePtr); // 0x00000001802B7040-0x00000001802B70C0
		public static extern void ISteamInput_RunFrame(IntPtr instancePtr); // 0x00000001802B6E70-0x00000001802B6EF0
		public static extern int ISteamInput_GetConnectedControllers(IntPtr instancePtr, [In, Out] InputHandle_t[] handlesOut); // 0x00000001802B6490-0x00000001802B6530
		public static extern ulong ISteamInput_GetActionSetHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionSetName); // 0x00000001802B60B0-0x00000001802B6190
		public static extern void ISteamInput_ActivateActionSet(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle); // 0x00000001802B5E40-0x00000001802B5EE0
		public static extern ulong ISteamInput_GetCurrentActionSet(IntPtr instancePtr, InputHandle_t inputHandle); // 0x00000001802B65C0-0x00000001802B6650
		public static extern void ISteamInput_ActivateActionSetLayer(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle); // 0x00000001802B5DA0-0x00000001802B5E40
		public static extern void ISteamInput_DeactivateActionSetLayer(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle); // 0x00000001802B5EE0-0x00000001802B5F80
		public static extern void ISteamInput_DeactivateAllActionSetLayers(IntPtr instancePtr, InputHandle_t inputHandle); // 0x00000001802B5F80-0x00000001802B6010
		public static extern int ISteamInput_GetActiveActionSetLayers(IntPtr instancePtr, InputHandle_t inputHandle, [In, Out] InputActionSetHandle_t[] handlesOut); // 0x00000001802B6190-0x00000001802B6230
		public static extern ulong ISteamInput_GetDigitalActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName); // 0x00000001802B67A0-0x00000001802B6880
		public static extern InputDigitalActionData_t ISteamInput_GetDigitalActionData(IntPtr instancePtr, InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle); // 0x00000001802B6700-0x00000001802B67A0
		public static extern int ISteamInput_GetDigitalActionOrigins(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, [In, Out] EInputActionOrigin[] originsOut); // 0x00000001802B6880-0x00000001802B6940
		public static extern ulong ISteamInput_GetAnalogActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName); // 0x00000001802B62F0-0x00000001802B63D0
		public static extern InputAnalogActionData_t ISteamInput_GetAnalogActionData(IntPtr instancePtr, InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle); // 0x00000001802B6230-0x00000001802B62F0
		public static extern int ISteamInput_GetAnalogActionOrigins(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, [In, Out] EInputActionOrigin[] originsOut); // 0x00000001802B63D0-0x00000001802B6490
		public static extern IntPtr ISteamInput_GetGlyphForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin); // 0x00000001802B69D0-0x00000001802B6A60
		public static extern IntPtr ISteamInput_GetStringForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin); // 0x00000001802B6CD0-0x00000001802B6D60
		public static extern void ISteamInput_StopAnalogActionMomentum(IntPtr instancePtr, InputHandle_t inputHandle, InputAnalogActionHandle_t eAction); // 0x00000001802B70C0-0x00000001802B7160
		public static extern InputMotionData_t ISteamInput_GetMotionData(IntPtr instancePtr, InputHandle_t inputHandle); // 0x00000001802B6B80-0x00000001802B6C40
		public static extern void ISteamInput_TriggerVibration(IntPtr instancePtr, InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed); // 0x00000001802B7380-0x00000001802B7430
		public static extern void ISteamInput_SetLEDColor(IntPtr instancePtr, InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags); // 0x00000001802B6EF0-0x00000001802B6FB0
		public static extern void ISteamInput_TriggerHapticPulse(IntPtr instancePtr, InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec); // 0x00000001802B7200-0x00000001802B72B0
		public static extern void ISteamInput_TriggerRepeatedHapticPulse(IntPtr instancePtr, InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags); // 0x00000001802B72B0-0x00000001802B7380
		public static extern bool ISteamInput_ShowBindingPanel(IntPtr instancePtr, InputHandle_t inputHandle); // 0x00000001802B6FB0-0x00000001802B7040
		public static extern ESteamInputType ISteamInput_GetInputTypeForHandle(IntPtr instancePtr, InputHandle_t inputHandle); // 0x00000001802B6AF0-0x00000001802B6B80
		public static extern ulong ISteamInput_GetControllerForGamepadIndex(IntPtr instancePtr, int nIndex); // 0x00000001802B6530-0x00000001802B65C0
		public static extern int ISteamInput_GetGamepadIndexForController(IntPtr instancePtr, InputHandle_t ulinputHandle); // 0x00000001802B6940-0x00000001802B69D0
		public static extern IntPtr ISteamInput_GetStringForXboxOrigin(IntPtr instancePtr, EXboxOrigin eOrigin); // 0x00000001802B6D60-0x00000001802B6DF0
		public static extern IntPtr ISteamInput_GetGlyphForXboxOrigin(IntPtr instancePtr, EXboxOrigin eOrigin); // 0x00000001802B6A60-0x00000001802B6AF0
		public static extern EInputActionOrigin ISteamInput_GetActionOriginFromXboxOrigin(IntPtr instancePtr, InputHandle_t inputHandle, EXboxOrigin eOrigin); // 0x00000001802B6010-0x00000001802B60B0
		public static extern EInputActionOrigin ISteamInput_TranslateActionOrigin(IntPtr instancePtr, ESteamInputType eDestinationInputType, EInputActionOrigin eSourceOrigin); // 0x00000001802B7160-0x00000001802B7200
		public static extern bool ISteamInput_GetDeviceBindingRevision(IntPtr instancePtr, InputHandle_t inputHandle, out int pMajor, out int pMinor); // 0x00000001802B6650-0x00000001802B6700
		public static extern uint ISteamInput_GetRemotePlaySessionID(IntPtr instancePtr, InputHandle_t inputHandle); // 0x00000001802B6C40-0x00000001802B6CD0
		public static extern EResult ISteamInventory_GetResultStatus(IntPtr instancePtr, SteamInventoryResult_t resultHandle); // 0x00000001802B81C0-0x00000001802B8250
		public static extern bool ISteamInventory_GetResultItems(IntPtr instancePtr, SteamInventoryResult_t resultHandle, [In, Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize); // 0x00000001802B8110-0x00000001802B81C0
		public static extern bool ISteamInventory_GetResultItemProperty(IntPtr instancePtr, SteamInventoryResult_t resultHandle, uint unItemIndex, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut); // 0x00000001802B7FF0-0x00000001802B8110
		public static extern uint ISteamInventory_GetResultTimestamp(IntPtr instancePtr, SteamInventoryResult_t resultHandle); // 0x00000001802B8250-0x00000001802B82E0
		public static extern bool ISteamInventory_CheckResultSteamID(IntPtr instancePtr, SteamInventoryResult_t resultHandle, CSteamID steamIDExpected); // 0x00000001802B7590-0x00000001802B7630
		public static extern void ISteamInventory_DestroyResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle); // 0x00000001802B77A0-0x00000001802B7830
		public static extern bool ISteamInventory_GetAllItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle); // 0x00000001802B7A10-0x00000001802B7AA0
		public static extern bool ISteamInventory_GetItemsByID(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In, Out] SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs); // 0x00000001802B7DD0-0x00000001802B7E90
		public static extern bool ISteamInventory_SerializeResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize); // 0x00000001802B8670-0x00000001802B8720
		public static extern bool ISteamInventory_DeserializeResult(IntPtr instancePtr, out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE); // 0x00000001802B76E0-0x00000001802B77A0
		public static extern bool ISteamInventory_GenerateItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In, Out] SteamItemDef_t[] pArrayItemDefs, [In, Out] uint[] punArrayQuantity, uint unArrayLength); // 0x00000001802B7940-0x00000001802B7A10
		public static extern bool ISteamInventory_GrantPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle); // 0x00000001802B82E0-0x00000001802B8370
		public static extern bool ISteamInventory_AddPromoItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef); // 0x00000001802B7430-0x00000001802B74D0
		public static extern bool ISteamInventory_AddPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In, Out] SteamItemDef_t[] pArrayItemDefs, uint unArrayLength); // 0x00000001802B74D0-0x00000001802B7590
		public static extern bool ISteamInventory_ConsumeItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity); // 0x00000001802B7630-0x00000001802B76E0
		public static extern bool ISteamInventory_ExchangeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In, Out] SteamItemDef_t[] pArrayGenerate, [In, Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In, Out] SteamItemInstanceID_t[] pArrayDestroy, [In, Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength); // 0x00000001802B7830-0x00000001802B7940
		public static extern bool ISteamInventory_TransferItemQuantity(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest); // 0x00000001802B8EC0-0x00000001802B8F80
		public static extern void ISteamInventory_SendItemDropHeartbeat(IntPtr instancePtr); // 0x00000001802B85F0-0x00000001802B8670
		public static extern bool ISteamInventory_TriggerItemDrop(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition); // 0x00000001802B8F80-0x00000001802B9020
		public static extern bool ISteamInventory_TradeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, [In, Out] SteamItemInstanceID_t[] pArrayGive, [In, Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In, Out] SteamItemInstanceID_t[] pArrayGet, [In, Out] uint[] pArrayGetQuantity, uint nArrayGetLength); // 0x00000001802B8DA0-0x00000001802B8EC0
		public static extern bool ISteamInventory_LoadItemDefinitions(IntPtr instancePtr); // 0x00000001802B8370-0x00000001802B83F0
		public static extern bool ISteamInventory_GetItemDefinitionIDs(IntPtr instancePtr, [In, Out] SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize); // 0x00000001802B7B60-0x00000001802B7C10
		public static extern bool ISteamInventory_GetItemDefinitionProperty(IntPtr instancePtr, SteamItemDef_t iDefinition, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut); // 0x00000001802B7C10-0x00000001802B7D20
		public static extern ulong ISteamInventory_RequestEligiblePromoItemDefinitionsIDs(IntPtr instancePtr, CSteamID steamID); // 0x00000001802B84E0-0x00000001802B8570
		public static extern bool ISteamInventory_GetEligiblePromoItemDefinitionIDs(IntPtr instancePtr, CSteamID steamID, [In, Out] SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize); // 0x00000001802B7AA0-0x00000001802B7B60
		public static extern ulong ISteamInventory_StartPurchase(IntPtr instancePtr, [In, Out] SteamItemDef_t[] pArrayItemDefs, [In, Out] uint[] punArrayQuantity, uint unArrayLength); // 0x00000001802B8BC0-0x00000001802B8C80
		public static extern ulong ISteamInventory_RequestPrices(IntPtr instancePtr); // 0x00000001802B8570-0x00000001802B85F0
		public static extern uint ISteamInventory_GetNumItemsWithPrices(IntPtr instancePtr); // 0x00000001802B7F70-0x00000001802B7FF0
		public static extern bool ISteamInventory_GetItemsWithPrices(IntPtr instancePtr, [In, Out] SteamItemDef_t[] pArrayItemDefs, [In, Out] ulong[] pCurrentPrices, [In, Out] ulong[] pBasePrices, uint unArrayLength); // 0x00000001802B7E90-0x00000001802B7F70
		public static extern bool ISteamInventory_GetItemPrice(IntPtr instancePtr, SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice); // 0x00000001802B7D20-0x00000001802B7DD0
		public static extern ulong ISteamInventory_StartUpdateProperties(IntPtr instancePtr); // 0x00000001802B8C80-0x00000001802B8D00
		public static extern bool ISteamInventory_RemoveProperty(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName); // 0x00000001802B83F0-0x00000001802B84E0
		public static extern bool ISteamInventory_SetPropertyString(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, InteropHelp.UTF8StringHandle pchPropertyValue); // 0x00000001802B8A50-0x00000001802B8BC0
		public static extern bool ISteamInventory_SetPropertyBool(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, bool bValue); // 0x00000001802B8720-0x00000001802B8830
		public static extern bool ISteamInventory_SetPropertyInt64(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, long nValue); // 0x00000001802B8940-0x00000001802B8A50
		public static extern bool ISteamInventory_SetPropertyFloat(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, float flValue); // 0x00000001802B8830-0x00000001802B8940
		public static extern bool ISteamInventory_SubmitUpdateProperties(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle); // 0x00000001802B8D00-0x00000001802B8DA0
		public static extern int ISteamMatchmaking_GetFavoriteGameCount(IntPtr instancePtr); // 0x00000001802BA290-0x00000001802BA310
		public static extern bool ISteamMatchmaking_GetFavoriteGame(IntPtr instancePtr, int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer); // 0x00000001802BA310-0x00000001802BA3F0
		public static extern int ISteamMatchmaking_AddFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer); // 0x00000001802B9AE0-0x00000001802B9BB0
		public static extern bool ISteamMatchmaking_RemoveFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags); // 0x00000001802BAD60-0x00000001802BAE30
		public static extern ulong ISteamMatchmaking_RequestLobbyList(IntPtr instancePtr); // 0x00000001802BAEC0-0x00000001802BAF40
		public static extern void ISteamMatchmaking_AddRequestLobbyListStringFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, InteropHelp.UTF8StringHandle pchValueToMatch, ELobbyComparison eComparisonType); // 0x00000001802B9FC0-0x00000001802BA110
		public static extern void ISteamMatchmaking_AddRequestLobbyListNumericalFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType); // 0x00000001802B9E40-0x00000001802B9F30
		public static extern void ISteamMatchmaking_AddRequestLobbyListNearValueFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToBeCloseTo); // 0x00000001802B9D60-0x00000001802B9E40
		public static extern void ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(IntPtr instancePtr, int nSlotsAvailable); // 0x00000001802B9CD0-0x00000001802B9D60
		public static extern void ISteamMatchmaking_AddRequestLobbyListDistanceFilter(IntPtr instancePtr, ELobbyDistanceFilter eLobbyDistanceFilter); // 0x00000001802B9C40-0x00000001802B9CD0
		public static extern void ISteamMatchmaking_AddRequestLobbyListResultCountFilter(IntPtr instancePtr, int cMaxResults); // 0x00000001802B9F30-0x00000001802B9FC0
		public static extern void ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(IntPtr instancePtr, CSteamID steamIDLobby); // 0x00000001802B9BB0-0x00000001802B9C40
		public static extern ulong ISteamMatchmaking_GetLobbyByIndex(IntPtr instancePtr, int iLobby); // 0x00000001802BA3F0-0x00000001802BA480
		public static extern ulong ISteamMatchmaking_CreateLobby(IntPtr instancePtr, ELobbyType eLobbyType, int cMaxMembers); // 0x00000001802BA110-0x00000001802BA1B0
		public static extern ulong ISteamMatchmaking_JoinLobby(IntPtr instancePtr, CSteamID steamIDLobby); // 0x00000001802BAC40-0x00000001802BACD0
		public static extern void ISteamMatchmaking_LeaveLobby(IntPtr instancePtr, CSteamID steamIDLobby); // 0x00000001802BACD0-0x00000001802BAD60
		public static extern bool ISteamMatchmaking_InviteUserToLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDInvitee); // 0x00000001802BABA0-0x00000001802BAC40
		public static extern int ISteamMatchmaking_GetNumLobbyMembers(IntPtr instancePtr, CSteamID steamIDLobby); // 0x00000001802BAB10-0x00000001802BABA0
		public static extern ulong ISteamMatchmaking_GetLobbyMemberByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iMember); // 0x00000001802BA860-0x00000001802BA900
		public static extern IntPtr ISteamMatchmaking_GetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey); // 0x00000001802BA6C0-0x00000001802BA7A0
		public static extern bool ISteamMatchmaking_SetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue); // 0x00000001802BB0A0-0x00000001802BB1F0
		public static extern int ISteamMatchmaking_GetLobbyDataCount(IntPtr instancePtr, CSteamID steamIDLobby); // 0x00000001802BA630-0x00000001802BA6C0
		public static extern bool ISteamMatchmaking_GetLobbyDataByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iLobbyData, IntPtr pchKey, int cchKeyBufferSize, IntPtr pchValue, int cchValueBufferSize); // 0x00000001802BA560-0x00000001802BA630
		public static extern bool ISteamMatchmaking_DeleteLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey); // 0x00000001802BA1B0-0x00000001802BA290
		public static extern IntPtr ISteamMatchmaking_GetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchKey); // 0x00000001802BA900-0x00000001802BA9F0
		public static extern void ISteamMatchmaking_SetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue); // 0x00000001802BB350-0x00000001802BB4A0
		public static extern bool ISteamMatchmaking_SendLobbyChatMsg(IntPtr instancePtr, CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody); // 0x00000001802BAF40-0x00000001802BB000
		public static extern int ISteamMatchmaking_GetLobbyChatEntry(IntPtr instancePtr, CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType); // 0x00000001802BA480-0x00000001802BA560
		public static extern bool ISteamMatchmaking_RequestLobbyData(IntPtr instancePtr, CSteamID steamIDLobby); // 0x00000001802BAE30-0x00000001802BAEC0
		public static extern void ISteamMatchmaking_SetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer); // 0x00000001802BB1F0-0x00000001802BB2B0
		public static extern bool ISteamMatchmaking_GetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer); // 0x00000001802BA7A0-0x00000001802BA860
		public static extern bool ISteamMatchmaking_SetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby, int cMaxMembers); // 0x00000001802BB4A0-0x00000001802BB540
		public static extern int ISteamMatchmaking_GetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby); // 0x00000001802BA9F0-0x00000001802BAA80
		public static extern bool ISteamMatchmaking_SetLobbyType(IntPtr instancePtr, CSteamID steamIDLobby, ELobbyType eLobbyType); // 0x00000001802BB5E0-0x00000001802BB680
		public static extern bool ISteamMatchmaking_SetLobbyJoinable(IntPtr instancePtr, CSteamID steamIDLobby, bool bLobbyJoinable); // 0x00000001802BB2B0-0x00000001802BB350
		public static extern ulong ISteamMatchmaking_GetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby); // 0x00000001802BAA80-0x00000001802BAB10
		public static extern bool ISteamMatchmaking_SetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDNewOwner); // 0x00000001802BB540-0x00000001802BB5E0
		public static extern bool ISteamMatchmaking_SetLinkedLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDLobbyDependent); // 0x00000001802BB000-0x00000001802BB0A0
		public static extern IntPtr ISteamMatchmakingServers_RequestInternetServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse); // 0x00000001802B9830-0x00000001802B98E0
		public static extern IntPtr ISteamMatchmakingServers_RequestLANServerList(IntPtr instancePtr, AppId_t iApp, IntPtr pRequestServersResponse); // 0x00000001802B98E0-0x00000001802B9980
		public static extern IntPtr ISteamMatchmakingServers_RequestFriendsServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse); // 0x00000001802B96D0-0x00000001802B9780
		public static extern IntPtr ISteamMatchmakingServers_RequestFavoritesServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse); // 0x00000001802B9620-0x00000001802B96D0
		public static extern IntPtr ISteamMatchmakingServers_RequestHistoryServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse); // 0x00000001802B9780-0x00000001802B9830
		public static extern IntPtr ISteamMatchmakingServers_RequestSpectatorServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse); // 0x00000001802B9980-0x00000001802B9A30
		public static extern void ISteamMatchmakingServers_ReleaseRequest(IntPtr instancePtr, HServerListRequest hServerListRequest); // 0x00000001802B9590-0x00000001802B9620
		public static extern IntPtr ISteamMatchmakingServers_GetServerDetails(IntPtr instancePtr, HServerListRequest hRequest, int iServer); // 0x00000001802B91D0-0x00000001802B9270
		public static extern void ISteamMatchmakingServers_CancelQuery(IntPtr instancePtr, HServerListRequest hRequest); // 0x00000001802B9020-0x00000001802B90B0
		public static extern void ISteamMatchmakingServers_RefreshQuery(IntPtr instancePtr, HServerListRequest hRequest); // 0x00000001802B9460-0x00000001802B94F0
		public static extern bool ISteamMatchmakingServers_IsRefreshing(IntPtr instancePtr, HServerListRequest hRequest); // 0x00000001802B9270-0x00000001802B9300
		public static extern int ISteamMatchmakingServers_GetServerCount(IntPtr instancePtr, HServerListRequest hRequest); // 0x00000001802B9140-0x00000001802B91D0
		public static extern void ISteamMatchmakingServers_RefreshServer(IntPtr instancePtr, HServerListRequest hRequest, int iServer); // 0x00000001802B94F0-0x00000001802B9590
		public static extern int ISteamMatchmakingServers_PingServer(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse); // 0x00000001802B9300-0x00000001802B93B0
		public static extern int ISteamMatchmakingServers_PlayerDetails(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse); // 0x00000001802B93B0-0x00000001802B9460
		public static extern int ISteamMatchmakingServers_ServerRules(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse); // 0x00000001802B9A30-0x00000001802B9AE0
		public static extern void ISteamMatchmakingServers_CancelServerQuery(IntPtr instancePtr, HServerQuery hServerQuery); // 0x00000001802B90B0-0x00000001802B9140
		public static extern EGameSearchErrorCode_t ISteamGameSearch_AddGameSearchParams(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToFind, InteropHelp.UTF8StringHandle pchValuesToFind); // 0x00000001802B0110-0x00000001802B0250
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SearchForGameWithLobby(IntPtr instancePtr, CSteamID steamIDLobby, int nPlayerMin, int nPlayerMax); // 0x00000001802B06E0-0x00000001802B0790
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SearchForGameSolo(IntPtr instancePtr, int nPlayerMin, int nPlayerMax); // 0x00000001802B0640-0x00000001802B06E0
		public static extern EGameSearchErrorCode_t ISteamGameSearch_AcceptGame(IntPtr instancePtr); // 0x00000001802B0090-0x00000001802B0110
		public static extern EGameSearchErrorCode_t ISteamGameSearch_DeclineGame(IntPtr instancePtr); // 0x00000001802B02D0-0x00000001802B0350
		public static extern EGameSearchErrorCode_t ISteamGameSearch_RetrieveConnectionDetails(IntPtr instancePtr, CSteamID steamIDHost, IntPtr pchConnectionDetails, int cubConnectionDetails); // 0x00000001802B0590-0x00000001802B0640
		public static extern EGameSearchErrorCode_t ISteamGameSearch_EndGameSearch(IntPtr instancePtr); // 0x00000001802B0350-0x00000001802B03D0
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SetGameHostParams(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue); // 0x00000001802B0870-0x00000001802B09B0
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SetConnectionDetails(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchConnectionDetails, int cubConnectionDetails); // 0x00000001802B0790-0x00000001802B0870
		public static extern EGameSearchErrorCode_t ISteamGameSearch_RequestPlayersForGame(IntPtr instancePtr, int nPlayerMin, int nPlayerMax, int nMaxTeamSize); // 0x00000001802B04F0-0x00000001802B0590
		public static extern EGameSearchErrorCode_t ISteamGameSearch_HostConfirmGameStart(IntPtr instancePtr, ulong ullUniqueGameID); // 0x00000001802B0460-0x00000001802B04F0
		public static extern EGameSearchErrorCode_t ISteamGameSearch_CancelRequestPlayersForGame(IntPtr instancePtr); // 0x00000001802B0250-0x00000001802B02D0
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SubmitPlayerResult(IntPtr instancePtr, ulong ullUniqueGameID, CSteamID steamIDPlayer, EPlayerResult_t EPlayerResult); // 0x00000001802B09B0-0x00000001802B0A60
		public static extern EGameSearchErrorCode_t ISteamGameSearch_EndGame(IntPtr instancePtr, ulong ullUniqueGameID); // 0x00000001802B03D0-0x00000001802B0460
		public static extern uint ISteamParties_GetNumActiveBeacons(IntPtr instancePtr); // 0x00000001802C1D30-0x00000001802C1DB0
		public static extern ulong ISteamParties_GetBeaconByIndex(IntPtr instancePtr, uint unIndex); // 0x00000001802C1B10-0x00000001802C1BA0
		public static extern bool ISteamParties_GetBeaconDetails(IntPtr instancePtr, PartyBeaconID_t ulBeaconID, out CSteamID pSteamIDBeaconOwner, out SteamPartyBeaconLocation_t pLocation, IntPtr pchMetadata, int cchMetadata); // 0x00000001802C1BA0-0x00000001802C1C70
		public static extern ulong ISteamParties_JoinParty(IntPtr instancePtr, PartyBeaconID_t ulBeaconID); // 0x00000001802C1E40-0x00000001802C1ED0
		public static extern bool ISteamParties_GetNumAvailableBeaconLocations(IntPtr instancePtr, out uint puNumLocations); // 0x00000001802C1DB0-0x00000001802C1E40
		public static extern bool ISteamParties_GetAvailableBeaconLocations(IntPtr instancePtr, [In, Out] SteamPartyBeaconLocation_t[] pLocationList, uint uMaxNumLocations); // 0x00000001802C1A60-0x00000001802C1B10
		public static extern ulong ISteamParties_CreateBeacon(IntPtr instancePtr, uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, InteropHelp.UTF8StringHandle pchConnectString, InteropHelp.UTF8StringHandle pchMetadata); // 0x00000001802C1860-0x00000001802C19D0
		public static extern void ISteamParties_OnReservationCompleted(IntPtr instancePtr, PartyBeaconID_t ulBeacon, CSteamID steamIDUser); // 0x00000001802C1ED0-0x00000001802C1F70
		public static extern void ISteamParties_CancelReservation(IntPtr instancePtr, PartyBeaconID_t ulBeacon, CSteamID steamIDUser); // 0x00000001802C1720-0x00000001802C17C0
		public static extern ulong ISteamParties_ChangeNumOpenSlots(IntPtr instancePtr, PartyBeaconID_t ulBeacon, uint unOpenSlots); // 0x00000001802C17C0-0x00000001802C1860
		public static extern bool ISteamParties_DestroyBeacon(IntPtr instancePtr, PartyBeaconID_t ulBeacon); // 0x00000001802C19D0-0x00000001802C1A60
		public static extern bool ISteamParties_GetBeaconLocationData(IntPtr instancePtr, SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, IntPtr pchDataStringOut, int cchDataStringOut); // 0x00000001802C1C70-0x00000001802C1D30
		public static extern bool ISteamMusic_BIsEnabled(IntPtr instancePtr); // 0x00000001802BC9D0-0x00000001802BCA50
		public static extern bool ISteamMusic_BIsPlaying(IntPtr instancePtr); // 0x00000001802BCA50-0x00000001802BCAD0
		public static extern AudioPlayback_Status ISteamMusic_GetPlaybackStatus(IntPtr instancePtr); // 0x00000001802BCAD0-0x00000001802BCB50
		public static extern void ISteamMusic_Play(IntPtr instancePtr); // 0x00000001802BCD50-0x00000001802BCDD0
		public static extern void ISteamMusic_Pause(IntPtr instancePtr); // 0x00000001802BCBD0-0x00000001802BCC50
		public static extern void ISteamMusic_PlayPrevious(IntPtr instancePtr); // 0x00000001802BCCD0-0x00000001802BCD50
		public static extern void ISteamMusic_PlayNext(IntPtr instancePtr); // 0x00000001802BCC50-0x00000001802BCCD0
		public static extern void ISteamMusic_SetVolume(IntPtr instancePtr, float flVolume); // 0x00000001802BCDD0-0x00000001802BCE60
		public static extern float ISteamMusic_GetVolume(IntPtr instancePtr); // 0x00000001802BCB50-0x00000001802BCBD0
		public static extern bool ISteamMusicRemote_RegisterSteamMusicRemote(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName); // 0x00000001802BBF00-0x00000001802BBFE0
		public static extern bool ISteamMusicRemote_DeregisterSteamMusicRemote(IntPtr instancePtr); // 0x00000001802BB920-0x00000001802BB9A0
		public static extern bool ISteamMusicRemote_BIsCurrentMusicRemote(IntPtr instancePtr); // 0x00000001802BB710-0x00000001802BB790
		public static extern bool ISteamMusicRemote_BActivationSuccess(IntPtr instancePtr, bool bValue); // 0x00000001802BB680-0x00000001802BB710
		public static extern bool ISteamMusicRemote_SetDisplayName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDisplayName); // 0x00000001802BC200-0x00000001802BC2E0
		public static extern bool ISteamMusicRemote_SetPNGIcon_64x64(IntPtr instancePtr, byte[] pvBuffer, uint cbBufferLength); // 0x00000001802BC2E0-0x00000001802BC390
		public static extern bool ISteamMusicRemote_EnablePlayPrevious(IntPtr instancePtr, bool bValue); // 0x00000001802BBAC0-0x00000001802BBB50
		public static extern bool ISteamMusicRemote_EnablePlayNext(IntPtr instancePtr, bool bValue); // 0x00000001802BBA30-0x00000001802BBAC0
		public static extern bool ISteamMusicRemote_EnableShuffled(IntPtr instancePtr, bool bValue); // 0x00000001802BBC70-0x00000001802BBD00
		public static extern bool ISteamMusicRemote_EnableLooped(IntPtr instancePtr, bool bValue); // 0x00000001802BB9A0-0x00000001802BBA30
		public static extern bool ISteamMusicRemote_EnableQueue(IntPtr instancePtr, bool bValue); // 0x00000001802BBBE0-0x00000001802BBC70
		public static extern bool ISteamMusicRemote_EnablePlaylists(IntPtr instancePtr, bool bValue); // 0x00000001802BBB50-0x00000001802BBBE0
		public static extern bool ISteamMusicRemote_UpdatePlaybackStatus(IntPtr instancePtr, AudioPlayback_Status nStatus); // 0x00000001802BC820-0x00000001802BC8B0
		public static extern bool ISteamMusicRemote_UpdateShuffled(IntPtr instancePtr, bool bValue); // 0x00000001802BC8B0-0x00000001802BC940
		public static extern bool ISteamMusicRemote_UpdateLooped(IntPtr instancePtr, bool bValue); // 0x00000001802BC790-0x00000001802BC820
		public static extern bool ISteamMusicRemote_UpdateVolume(IntPtr instancePtr, float flValue); // 0x00000001802BC940-0x00000001802BC9D0
		public static extern bool ISteamMusicRemote_CurrentEntryWillChange(IntPtr instancePtr); // 0x00000001802BB8A0-0x00000001802BB920
		public static extern bool ISteamMusicRemote_CurrentEntryIsAvailable(IntPtr instancePtr, bool bAvailable); // 0x00000001802BB810-0x00000001802BB8A0
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryText(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchText); // 0x00000001802BC6B0-0x00000001802BC790
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(IntPtr instancePtr, int nValue); // 0x00000001802BC620-0x00000001802BC6B0
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryCoverArt(IntPtr instancePtr, byte[] pvBuffer, uint cbBufferLength); // 0x00000001802BC570-0x00000001802BC620
		public static extern bool ISteamMusicRemote_CurrentEntryDidChange(IntPtr instancePtr); // 0x00000001802BB790-0x00000001802BB810
		public static extern bool ISteamMusicRemote_QueueWillChange(IntPtr instancePtr); // 0x00000001802BBE80-0x00000001802BBF00
		public static extern bool ISteamMusicRemote_ResetQueueEntries(IntPtr instancePtr); // 0x00000001802BC060-0x00000001802BC0E0
		public static extern bool ISteamMusicRemote_SetQueueEntry(IntPtr instancePtr, int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText); // 0x00000001802BC480-0x00000001802BC570
		public static extern bool ISteamMusicRemote_SetCurrentQueueEntry(IntPtr instancePtr, int nID); // 0x00000001802BC170-0x00000001802BC200
		public static extern bool ISteamMusicRemote_QueueDidChange(IntPtr instancePtr); // 0x00000001802BBE00-0x00000001802BBE80
		public static extern bool ISteamMusicRemote_PlaylistWillChange(IntPtr instancePtr); // 0x00000001802BBD80-0x00000001802BBE00
		public static extern bool ISteamMusicRemote_ResetPlaylistEntries(IntPtr instancePtr); // 0x00000001802BBFE0-0x00000001802BC060
		public static extern bool ISteamMusicRemote_SetPlaylistEntry(IntPtr instancePtr, int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText); // 0x00000001802BC390-0x00000001802BC480
		public static extern bool ISteamMusicRemote_SetCurrentPlaylistEntry(IntPtr instancePtr, int nID); // 0x00000001802BC0E0-0x00000001802BC170
		public static extern bool ISteamMusicRemote_PlaylistDidChange(IntPtr instancePtr); // 0x00000001802BBD00-0x00000001802BBD80
		public static extern bool ISteamNetworking_SendP2PPacket(IntPtr instancePtr, CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel); // 0x00000001802C1310-0x00000001802C13E0
		public static extern bool ISteamNetworking_IsP2PPacketAvailable(IntPtr instancePtr, out uint pcubMsgSize, int nChannel); // 0x00000001802C0F50-0x00000001802C0FF0
		public static extern bool ISteamNetworking_ReadP2PPacket(IntPtr instancePtr, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel); // 0x00000001802C0FF0-0x00000001802C10C0
		public static extern bool ISteamNetworking_AcceptP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote); // 0x00000001802C04E0-0x00000001802C0570
		public static extern bool ISteamNetworking_CloseP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote); // 0x00000001802C06A0-0x00000001802C0730
		public static extern bool ISteamNetworking_CloseP2PChannelWithUser(IntPtr instancePtr, CSteamID steamIDRemote, int nChannel); // 0x00000001802C0600-0x00000001802C06A0
		public static extern bool ISteamNetworking_GetP2PSessionState(IntPtr instancePtr, CSteamID steamIDRemote, out P2PSessionState_t pConnectionState); // 0x00000001802C0C00-0x00000001802C0CA0
		public static extern bool ISteamNetworking_AllowP2PPacketRelay(IntPtr instancePtr, bool bAllow); // 0x00000001802C0570-0x00000001802C0600
		public static extern uint ISteamNetworking_CreateListenSocket(IntPtr instancePtr, int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay); // 0x00000001802C07F0-0x00000001802C08C0
		public static extern uint ISteamNetworking_CreateP2PConnectionSocket(IntPtr instancePtr, CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay); // 0x00000001802C08C0-0x00000001802C0980
		public static extern uint ISteamNetworking_CreateConnectionSocket(IntPtr instancePtr, SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec); // 0x00000001802C0730-0x00000001802C07F0
		public static extern bool ISteamNetworking_DestroySocket(IntPtr instancePtr, SNetSocket_t hSocket, bool bNotifyRemoteEnd); // 0x00000001802C0A20-0x00000001802C0AC0
		public static extern bool ISteamNetworking_DestroyListenSocket(IntPtr instancePtr, SNetListenSocket_t hSocket, bool bNotifyRemoteEnd); // 0x00000001802C0980-0x00000001802C0A20
		public static extern bool ISteamNetworking_SendDataOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable); // 0x00000001802C1250-0x00000001802C1310
		public static extern bool ISteamNetworking_IsDataAvailableOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, out uint pcubMsgSize); // 0x00000001802C0E00-0x00000001802C0EA0
		public static extern bool ISteamNetworking_RetrieveDataFromSocket(IntPtr instancePtr, SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize); // 0x00000001802C10C0-0x00000001802C1180
		public static extern bool ISteamNetworking_IsDataAvailable(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket); // 0x00000001802C0EA0-0x00000001802C0F50
		public static extern bool ISteamNetworking_RetrieveData(IntPtr instancePtr, SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket); // 0x00000001802C1180-0x00000001802C1250
		public static extern bool ISteamNetworking_GetSocketInfo(IntPtr instancePtr, SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote); // 0x00000001802C0D30-0x00000001802C0E00
		public static extern bool ISteamNetworking_GetListenSocketInfo(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort); // 0x00000001802C0AC0-0x00000001802C0B70
		public static extern ESNetSocketConnectionType ISteamNetworking_GetSocketConnectionType(IntPtr instancePtr, SNetSocket_t hSocket); // 0x00000001802C0CA0-0x00000001802C0D30
		public static extern int ISteamNetworking_GetMaxPacketSize(IntPtr instancePtr, SNetSocket_t hSocket); // 0x00000001802C0B70-0x00000001802C0C00
		public static extern uint ISteamNetworkingSockets_CreateListenSocketIP(IntPtr instancePtr, ref SteamNetworkingIPAddr localAddress, int nOptions, [In, Out] SteamNetworkingConfigValue_t[] pOptions); // 0x00000001802BD5E0-0x00000001802BD6F0
		public static extern uint ISteamNetworkingSockets_ConnectByIPAddress(IntPtr instancePtr, ref SteamNetworkingIPAddr address, int nOptions, [In, Out] SteamNetworkingConfigValue_t[] pOptions); // 0x00000001802BD090-0x00000001802BD1A0
		public static extern uint ISteamNetworkingSockets_CreateListenSocketP2P(IntPtr instancePtr, int nVirtualPort, int nOptions, [In, Out] SteamNetworkingConfigValue_t[] pOptions); // 0x00000001802BD6F0-0x00000001802BD7A0
		public static extern uint ISteamNetworkingSockets_ConnectP2P(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, int nVirtualPort, int nOptions, [In, Out] SteamNetworkingConfigValue_t[] pOptions); // 0x00000001802BD2D0-0x00000001802BD400
		public static extern EResult ISteamNetworkingSockets_AcceptConnection(IntPtr instancePtr, HSteamNetConnection hConn); // 0x00000001802BCE60-0x00000001802BCEF0
		public static extern bool ISteamNetworkingSockets_CloseConnection(IntPtr instancePtr, HSteamNetConnection hPeer, int nReason, InteropHelp.UTF8StringHandle pszDebug, bool bEnableLinger); // 0x00000001802BCEF0-0x00000001802BD000
		public static extern bool ISteamNetworkingSockets_CloseListenSocket(IntPtr instancePtr, HSteamListenSocket hSocket); // 0x00000001802BD000-0x00000001802BD090
		public static extern bool ISteamNetworkingSockets_SetConnectionUserData(IntPtr instancePtr, HSteamNetConnection hPeer, long nUserData); // 0x00000001802BF150-0x00000001802BF1F0
		public static extern long ISteamNetworkingSockets_GetConnectionUserData(IntPtr instancePtr, HSteamNetConnection hPeer); // 0x00000001802BE070-0x00000001802BE100
		public static extern void ISteamNetworkingSockets_SetConnectionName(IntPtr instancePtr, HSteamNetConnection hPeer, InteropHelp.UTF8StringHandle pszName); // 0x00000001802BEFD0-0x00000001802BF0B0
		public static extern bool ISteamNetworkingSockets_GetConnectionName(IntPtr instancePtr, HSteamNetConnection hPeer, IntPtr pszName, int nMaxLen); // 0x00000001802BDFC0-0x00000001802BE070
		public static extern EResult ISteamNetworkingSockets_SendMessageToConnection(IntPtr instancePtr, HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber); // 0x00000001802BEBD0-0x00000001802BEC90
		public static extern void ISteamNetworkingSockets_SendMessages(IntPtr instancePtr, int nMessages, [In, Out] SteamNetworkingMessage_t[] pMessages, [In, Out] long[] pOutMessageNumberOrResult); // 0x00000001802BEC90-0x00000001802BEEC0
		public static extern EResult ISteamNetworkingSockets_FlushMessagesOnConnection(IntPtr instancePtr, HSteamNetConnection hConn); // 0x00000001802BDBE0-0x00000001802BDC70
		public static extern int ISteamNetworkingSockets_ReceiveMessagesOnConnection(IntPtr instancePtr, HSteamNetConnection hConn, [In, Out] IntPtr[] ppOutMessages, int nMaxMessages); // 0x00000001802BE870-0x00000001802BE920
		public static extern bool ISteamNetworkingSockets_GetConnectionInfo(IntPtr instancePtr, HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo); // 0x00000001802BDE70-0x00000001802BDFC0
		public static extern bool ISteamNetworkingSockets_GetQuickConnectionStatus(IntPtr instancePtr, HSteamNetConnection hConn, out SteamNetworkingQuickConnectionStatus pStats); // 0x00000001802BE6B0-0x00000001802BE7F0
		public static extern int ISteamNetworkingSockets_GetDetailedConnectionStatus(IntPtr instancePtr, HSteamNetConnection hConn, IntPtr pszBuf, int cbBuf); // 0x00000001802BE100-0x00000001802BE1A0
		public static extern bool ISteamNetworkingSockets_GetListenSocketAddress(IntPtr instancePtr, HSteamListenSocket hSocket, out SteamNetworkingIPAddr address); // 0x00000001802BE5C0-0x00000001802BE6B0
		public static extern bool ISteamNetworkingSockets_CreateSocketPair(IntPtr instancePtr, out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2); // 0x00000001802BD820-0x00000001802BD9C0
		public static extern bool ISteamNetworkingSockets_GetIdentity(IntPtr instancePtr, out SteamNetworkingIdentity pIdentity); // 0x00000001802BE4D0-0x00000001802BE5C0
		public static extern ESteamNetworkingAvailability ISteamNetworkingSockets_InitAuthentication(IntPtr instancePtr); // 0x00000001802BE7F0-0x00000001802BE870
		public static extern ESteamNetworkingAvailability ISteamNetworkingSockets_GetAuthenticationStatus(IntPtr instancePtr, out SteamNetAuthenticationStatus_t pDetails); // 0x00000001802BDC70-0x00000001802BDD60
		public static extern uint ISteamNetworkingSockets_CreatePollGroup(IntPtr instancePtr); // 0x00000001802BD7A0-0x00000001802BD820
		public static extern bool ISteamNetworkingSockets_DestroyPollGroup(IntPtr instancePtr, HSteamNetPollGroup hPollGroup); // 0x00000001802BD9C0-0x00000001802BDA50
		public static extern bool ISteamNetworkingSockets_SetConnectionPollGroup(IntPtr instancePtr, HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup); // 0x00000001802BF0B0-0x00000001802BF150
		public static extern int ISteamNetworkingSockets_ReceiveMessagesOnPollGroup(IntPtr instancePtr, HSteamNetPollGroup hPollGroup, [In, Out] IntPtr[] ppOutMessages, int nMaxMessages); // 0x00000001802BE920-0x00000001802BE9D0
		public static extern bool ISteamNetworkingSockets_ReceivedRelayAuthTicket(IntPtr instancePtr, IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket); // 0x00000001802BEA80-0x00000001802BEBD0
		public static extern int ISteamNetworkingSockets_FindRelayAuthTicketForServer(IntPtr instancePtr, ref SteamNetworkingIdentity identityGameServer, int nVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket); // 0x00000001802BDA50-0x00000001802BDBE0
		public static extern uint ISteamNetworkingSockets_ConnectToHostedDedicatedServer(IntPtr instancePtr, ref SteamNetworkingIdentity identityTarget, int nVirtualPort, int nOptions, [In, Out] SteamNetworkingConfigValue_t[] pOptions); // 0x00000001802BD400-0x00000001802BD530
		public static extern ushort ISteamNetworkingSockets_GetHostedDedicatedServerPort(IntPtr instancePtr); // 0x00000001802BE450-0x00000001802BE4D0
		public static extern uint ISteamNetworkingSockets_GetHostedDedicatedServerPOPID(IntPtr instancePtr); // 0x00000001802BE3D0-0x00000001802BE450
		public static extern EResult ISteamNetworkingSockets_GetHostedDedicatedServerAddress(IntPtr instancePtr, out SteamDatagramHostedAddress pRouting); // 0x00000001802BE2E0-0x00000001802BE3D0
		public static extern uint ISteamNetworkingSockets_CreateHostedDedicatedServerListenSocket(IntPtr instancePtr, int nVirtualPort, int nOptions, [In, Out] SteamNetworkingConfigValue_t[] pOptions); // 0x00000001802BD530-0x00000001802BD5E0
		public static extern EResult ISteamNetworkingSockets_GetGameCoordinatorServerLogin(IntPtr instancePtr, out SteamDatagramGameCoordinatorServerLogin pLoginInfo, out int pcbSignedBlob, IntPtr pBlob); // 0x00000001802BE1A0-0x00000001802BE2E0
		public static extern uint ISteamNetworkingSockets_ConnectP2PCustomSignaling(IntPtr instancePtr, out ISteamNetworkingConnectionCustomSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nOptions, [In, Out] SteamNetworkingConfigValue_t[] pOptions); // 0x00000001802BD1A0-0x00000001802BD2D0
		public static extern bool ISteamNetworkingSockets_ReceivedP2PCustomSignal(IntPtr instancePtr, IntPtr pMsg, int cbMsg, out ISteamNetworkingCustomSignalingRecvContext pContext); // 0x00000001802BE9D0-0x00000001802BEA80
		public static extern bool ISteamNetworkingSockets_GetCertificateRequest(IntPtr instancePtr, out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg); // 0x00000001802BDD60-0x00000001802BDE70
		public static extern bool ISteamNetworkingSockets_SetCertificate(IntPtr instancePtr, IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg); // 0x00000001802BEEC0-0x00000001802BEFD0
		public static extern IntPtr ISteamNetworkingUtils_AllocateMessage(IntPtr instancePtr, int cbAllocateBuffer); // 0x00000001802BF1F0-0x00000001802BF280
		public static extern ESteamNetworkingAvailability ISteamNetworkingUtils_GetRelayNetworkStatus(IntPtr instancePtr, out SteamRelayNetworkStatus_t pDetails); // 0x00000001802BFC80-0x00000001802BFD80
		public static extern float ISteamNetworkingUtils_GetLocalPingLocation(IntPtr instancePtr, out SteamNetworkPingLocation_t result); // 0x00000001802BF940-0x00000001802BFA40
		public static extern int ISteamNetworkingUtils_EstimatePingTimeBetweenTwoLocations(IntPtr instancePtr, ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2); // 0x00000001802BF420-0x00000001802BF590
		public static extern int ISteamNetworkingUtils_EstimatePingTimeFromLocalHost(IntPtr instancePtr, ref SteamNetworkPingLocation_t remoteLocation); // 0x00000001802BF590-0x00000001802BF690
		public static extern void ISteamNetworkingUtils_ConvertPingLocationToString(IntPtr instancePtr, ref SteamNetworkPingLocation_t location, IntPtr pszBuf, int cchBufSize); // 0x00000001802BF310-0x00000001802BF420
		public static extern bool ISteamNetworkingUtils_ParsePingLocationString(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszString, out SteamNetworkPingLocation_t result); // 0x00000001802BFD80-0x00000001802BFED0
		public static extern bool ISteamNetworkingUtils_CheckPingDataUpToDate(IntPtr instancePtr, float flMaxAgeSeconds); // 0x00000001802BF280-0x00000001802BF310
		public static extern int ISteamNetworkingUtils_GetPingToDataCenter(IntPtr instancePtr, SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP); // 0x00000001802BFBE0-0x00000001802BFC80
		public static extern int ISteamNetworkingUtils_GetDirectPingToPOP(IntPtr instancePtr, SteamNetworkingPOPID popID); // 0x00000001802BF830-0x00000001802BF8C0
		public static extern int ISteamNetworkingUtils_GetPOPCount(IntPtr instancePtr); // 0x00000001802BFAC0-0x00000001802BFB40
		public static extern int ISteamNetworkingUtils_GetPOPList(IntPtr instancePtr, out SteamNetworkingPOPID list, int nListSz); // 0x00000001802BFB40-0x00000001802BFBE0
		public static extern long ISteamNetworkingUtils_GetLocalTimestamp(IntPtr instancePtr); // 0x00000001802BFA40-0x00000001802BFAC0
		public static extern void ISteamNetworkingUtils_SetDebugOutputFunction(IntPtr instancePtr, ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc); // 0x00000001802BFF90-0x00000001802C0030
		public static extern bool ISteamNetworkingUtils_SetConfigValue(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg); // 0x00000001802BFED0-0x00000001802BFF90
		public static extern ESteamNetworkingGetConfigValueResult ISteamNetworkingUtils_GetConfigValue(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, out ulong cbResult); // 0x00000001802BF760-0x00000001802BF830
		public static extern bool ISteamNetworkingUtils_GetConfigValueInfo(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, IntPtr pOutName, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope, out ESteamNetworkingConfigValue pOutNextValue); // 0x00000001802BF690-0x00000001802BF760
		public static extern ESteamNetworkingConfigValue ISteamNetworkingUtils_GetFirstConfigValue(IntPtr instancePtr); // 0x00000001802BF8C0-0x00000001802BF940
		public static extern void ISteamNetworkingUtils_SteamNetworkingIPAddr_ToString(IntPtr instancePtr, ref SteamNetworkingIPAddr addr, IntPtr buf, uint cbBuf, bool bWithPort); // 0x00000001802C0170-0x00000001802C0280
		public static extern bool ISteamNetworkingUtils_SteamNetworkingIPAddr_ParseString(IntPtr instancePtr, out SteamNetworkingIPAddr pAddr, InteropHelp.UTF8StringHandle pszStr); // 0x00000001802C0030-0x00000001802C0170
		public static extern void ISteamNetworkingUtils_SteamNetworkingIdentity_ToString(IntPtr instancePtr, ref SteamNetworkingIdentity identity, IntPtr buf, uint cbBuf); // 0x00000001802C03D0-0x00000001802C04E0
		public static extern bool ISteamNetworkingUtils_SteamNetworkingIdentity_ParseString(IntPtr instancePtr, out SteamNetworkingIdentity pIdentity, InteropHelp.UTF8StringHandle pszStr); // 0x00000001802C0280-0x00000001802C03D0
		public static extern bool ISteamParentalSettings_BIsParentalLockEnabled(IntPtr instancePtr); // 0x00000001802C1620-0x00000001802C16A0
		public static extern bool ISteamParentalSettings_BIsParentalLockLocked(IntPtr instancePtr); // 0x00000001802C16A0-0x00000001802C1720
		public static extern bool ISteamParentalSettings_BIsAppBlocked(IntPtr instancePtr, AppId_t nAppID); // 0x00000001802C13E0-0x00000001802C1470
		public static extern bool ISteamParentalSettings_BIsAppInBlockList(IntPtr instancePtr, AppId_t nAppID); // 0x00000001802C1470-0x00000001802C1500
		public static extern bool ISteamParentalSettings_BIsFeatureBlocked(IntPtr instancePtr, EParentalFeature eFeature); // 0x00000001802C1500-0x00000001802C1590
		public static extern bool ISteamParentalSettings_BIsFeatureInBlockList(IntPtr instancePtr, EParentalFeature eFeature); // 0x00000001802C1590-0x00000001802C1620
		public static extern uint ISteamRemotePlay_GetSessionCount(IntPtr instancePtr); // 0x00000001802C21D0-0x00000001802C2250
		public static extern uint ISteamRemotePlay_GetSessionID(IntPtr instancePtr, int iSessionIndex); // 0x00000001802C2250-0x00000001802C22E0
		public static extern ulong ISteamRemotePlay_GetSessionSteamID(IntPtr instancePtr, RemotePlaySessionID_t unSessionID); // 0x00000001802C22E0-0x00000001802C2370
		public static extern IntPtr ISteamRemotePlay_GetSessionClientName(IntPtr instancePtr, RemotePlaySessionID_t unSessionID); // 0x00000001802C2140-0x00000001802C21D0
		public static extern ESteamDeviceFormFactor ISteamRemotePlay_GetSessionClientFormFactor(IntPtr instancePtr, RemotePlaySessionID_t unSessionID); // 0x00000001802C20B0-0x00000001802C2140
		public static extern bool ISteamRemotePlay_BGetSessionClientResolution(IntPtr instancePtr, RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY); // 0x00000001802C1F70-0x00000001802C2020
		public static extern bool ISteamRemotePlay_BSendRemotePlayTogetherInvite(IntPtr instancePtr, CSteamID steamIDFriend); // 0x00000001802C2020-0x00000001802C20B0
		public static extern bool ISteamRemoteStorage_FileWrite(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubData); // 0x00000001802C3340-0x00000001802C3440
		public static extern int ISteamRemoteStorage_FileRead(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubDataToRead); // 0x00000001802C2DA0-0x00000001802C2EA0
		public static extern ulong ISteamRemoteStorage_FileWriteAsync(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, uint cubData); // 0x00000001802C2F80-0x00000001802C3080
		public static extern ulong ISteamRemoteStorage_FileReadAsync(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, uint nOffset, uint cubToRead); // 0x00000001802C2CB0-0x00000001802C2DA0
		public static extern bool ISteamRemoteStorage_FileReadAsyncComplete(IntPtr instancePtr, SteamAPICall_t hReadCall, byte[] pvBuffer, uint cubToRead); // 0x00000001802C2BF0-0x00000001802C2CB0
		public static extern bool ISteamRemoteStorage_FileForget(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile); // 0x00000001802C2A30-0x00000001802C2B10
		public static extern bool ISteamRemoteStorage_FileDelete(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile); // 0x00000001802C2870-0x00000001802C2950
		public static extern ulong ISteamRemoteStorage_FileShare(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile); // 0x00000001802C2EA0-0x00000001802C2F80
		public static extern bool ISteamRemoteStorage_SetSyncPlatforms(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, ERemoteStoragePlatform eRemoteStoragePlatform); // 0x00000001802C4350-0x00000001802C4440
		public static extern ulong ISteamRemoteStorage_FileWriteStreamOpen(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile); // 0x00000001802C31A0-0x00000001802C3280
		public static extern bool ISteamRemoteStorage_FileWriteStreamWriteChunk(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData); // 0x00000001802C3280-0x00000001802C3340
		public static extern bool ISteamRemoteStorage_FileWriteStreamClose(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle); // 0x00000001802C3110-0x00000001802C31A0
		public static extern bool ISteamRemoteStorage_FileWriteStreamCancel(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle); // 0x00000001802C3080-0x00000001802C3110
		public static extern bool ISteamRemoteStorage_FileExists(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile); // 0x00000001802C2950-0x00000001802C2A30
		public static extern bool ISteamRemoteStorage_FilePersisted(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile); // 0x00000001802C2B10-0x00000001802C2BF0
		public static extern int ISteamRemoteStorage_GetFileSize(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile); // 0x00000001802C3670-0x00000001802C3740
		public static extern long ISteamRemoteStorage_GetFileTimestamp(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile); // 0x00000001802C3740-0x00000001802C3820
		public static extern ERemoteStoragePlatform ISteamRemoteStorage_GetSyncPlatforms(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile); // 0x00000001802C39F0-0x00000001802C3AC0
		public static extern int ISteamRemoteStorage_GetFileCount(IntPtr instancePtr); // 0x00000001802C3550-0x00000001802C35D0
		public static extern IntPtr ISteamRemoteStorage_GetFileNameAndSize(IntPtr instancePtr, int iFile, out int pnFileSizeInBytes); // 0x00000001802C35D0-0x00000001802C3670
		public static extern bool ISteamRemoteStorage_GetQuota(IntPtr instancePtr, out ulong pnTotalBytes, out ulong puAvailableBytes); // 0x00000001802C3950-0x00000001802C39F0
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForAccount(IntPtr instancePtr); // 0x00000001802C3CD0-0x00000001802C3D50
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForApp(IntPtr instancePtr); // 0x00000001802C3D50-0x00000001802C3DD0
		public static extern void ISteamRemoteStorage_SetCloudEnabledForApp(IntPtr instancePtr, bool bEnabled); // 0x00000001802C42C0-0x00000001802C4350
		public static extern ulong ISteamRemoteStorage_UGCDownload(IntPtr instancePtr, UGCHandle_t hContent, uint unPriority); // 0x00000001802C4660-0x00000001802C4700
		public static extern bool ISteamRemoteStorage_GetUGCDownloadProgress(IntPtr instancePtr, UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected); // 0x00000001802C3B90-0x00000001802C3C40
		public static extern bool ISteamRemoteStorage_GetUGCDetails(IntPtr instancePtr, UGCHandle_t hContent, out AppId_t pnAppID, out IntPtr ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner); // 0x00000001802C3AC0-0x00000001802C3B90
		public static extern int ISteamRemoteStorage_UGCRead(IntPtr instancePtr, UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction); // 0x00000001802C4700-0x00000001802C47D0
		public static extern int ISteamRemoteStorage_GetCachedUGCCount(IntPtr instancePtr); // 0x00000001802C3440-0x00000001802C34C0
		public static extern ulong ISteamRemoteStorage_GetCachedUGCHandle(IntPtr instancePtr, int iCachedContent); // 0x00000001802C34C0-0x00000001802C3550
		public static extern ulong ISteamRemoteStorage_PublishWorkshopFile(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags, EWorkshopFileType eWorkshopFileType); // 0x00000001802C4060-0x00000001802C42C0
		public static extern ulong ISteamRemoteStorage_CreatePublishedFileUpdateRequest(IntPtr instancePtr, PublishedFileId_t unPublishedFileId); // 0x00000001802C2400-0x00000001802C2490
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchFile); // 0x00000001802C4940-0x00000001802C4A20
		public static extern bool ISteamRemoteStorage_UpdatePublishedFilePreviewFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchPreviewFile); // 0x00000001802C4A20-0x00000001802C4B00
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTitle(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchTitle); // 0x00000001802C4C80-0x00000001802C4D60
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchDescription); // 0x00000001802C4860-0x00000001802C4940
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileVisibility(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility); // 0x00000001802C4D60-0x00000001802C4E00
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTags(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, IntPtr pTags); // 0x00000001802C4BE0-0x00000001802C4C80
		public static extern ulong ISteamRemoteStorage_CommitPublishedFileUpdate(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle); // 0x00000001802C2370-0x00000001802C2400
		public static extern ulong ISteamRemoteStorage_GetPublishedFileDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld); // 0x00000001802C3820-0x00000001802C38C0
		public static extern ulong ISteamRemoteStorage_DeletePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId); // 0x00000001802C2490-0x00000001802C2520
		public static extern ulong ISteamRemoteStorage_EnumerateUserPublishedFiles(IntPtr instancePtr, uint unStartIndex); // 0x00000001802C2690-0x00000001802C2720
		public static extern ulong ISteamRemoteStorage_SubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId); // 0x00000001802C44E0-0x00000001802C4570
		public static extern ulong ISteamRemoteStorage_EnumerateUserSubscribedFiles(IntPtr instancePtr, uint unStartIndex); // 0x00000001802C27E0-0x00000001802C2870
		public static extern ulong ISteamRemoteStorage_UnsubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId); // 0x00000001802C47D0-0x00000001802C4860
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchChangeDescription); // 0x00000001802C4B00-0x00000001802C4BE0
		public static extern ulong ISteamRemoteStorage_GetPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId); // 0x00000001802C38C0-0x00000001802C3950
		public static extern ulong ISteamRemoteStorage_UpdateUserPublishedItemVote(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, bool bVoteUp); // 0x00000001802C4E00-0x00000001802C4EA0
		public static extern ulong ISteamRemoteStorage_GetUserPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId); // 0x00000001802C3C40-0x00000001802C3CD0
		public static extern ulong ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(IntPtr instancePtr, CSteamID steamId, uint unStartIndex, IntPtr pRequiredTags, IntPtr pExcludedTags); // 0x00000001802C2720-0x00000001802C27E0
		public static extern ulong ISteamRemoteStorage_PublishVideo(IntPtr instancePtr, EWorkshopVideoProvider eVideoProvider, InteropHelp.UTF8StringHandle pchVideoAccount, InteropHelp.UTF8StringHandle pchVideoIdentifier, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags); // 0x00000001802C3DD0-0x00000001802C4060
		public static extern ulong ISteamRemoteStorage_SetUserPublishedFileAction(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction); // 0x00000001802C4440-0x00000001802C44E0
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(IntPtr instancePtr, EWorkshopFileAction eAction, uint unStartIndex); // 0x00000001802C2520-0x00000001802C25C0
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(IntPtr instancePtr, EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IntPtr pTags, IntPtr pUserTags); // 0x00000001802C25C0-0x00000001802C2690
		public static extern ulong ISteamRemoteStorage_UGCDownloadToLocation(IntPtr instancePtr, UGCHandle_t hContent, InteropHelp.UTF8StringHandle pchLocation, uint unPriority); // 0x00000001802C4570-0x00000001802C4660
		public static extern uint ISteamScreenshots_WriteScreenshot(IntPtr instancePtr, byte[] pubRGB, uint cubRGB, int nWidth, int nHeight); // 0x00000001802C5500-0x00000001802C55C0
		public static extern uint ISteamScreenshots_AddScreenshotToLibrary(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchThumbnailFilename, int nWidth, int nHeight); // 0x00000001802C4EA0-0x00000001802C5000
		public static extern void ISteamScreenshots_TriggerScreenshot(IntPtr instancePtr); // 0x00000001802C5480-0x00000001802C5500
		public static extern void ISteamScreenshots_HookScreenshots(IntPtr instancePtr, bool bHook); // 0x00000001802C5150-0x00000001802C51E0
		public static extern bool ISteamScreenshots_SetLocation(IntPtr instancePtr, ScreenshotHandle hScreenshot, InteropHelp.UTF8StringHandle pchLocation); // 0x00000001802C5260-0x00000001802C5340
		public static extern bool ISteamScreenshots_TagUser(IntPtr instancePtr, ScreenshotHandle hScreenshot, CSteamID steamID); // 0x00000001802C53E0-0x00000001802C5480
		public static extern bool ISteamScreenshots_TagPublishedFile(IntPtr instancePtr, ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID); // 0x00000001802C5340-0x00000001802C53E0
		public static extern bool ISteamScreenshots_IsScreenshotsHooked(IntPtr instancePtr); // 0x00000001802C51E0-0x00000001802C5260
		public static extern uint ISteamScreenshots_AddVRScreenshotToLibrary(IntPtr instancePtr, EVRScreenshotType eType, InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchVRFilename); // 0x00000001802C5000-0x00000001802C5150
		public static extern ulong ISteamUGC_CreateQueryUserUGCRequest(IntPtr instancePtr, AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage); // 0x00000001802C6270-0x00000001802C6340
		public static extern ulong ISteamUGC_CreateQueryAllUGCRequestPage(IntPtr instancePtr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage); // 0x00000001802C6110-0x00000001802C61D0
		public static extern ulong ISteamUGC_CreateQueryAllUGCRequestCursor(IntPtr instancePtr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, InteropHelp.UTF8StringHandle pchCursor); // 0x00000001802C5FF0-0x00000001802C6110
		public static extern ulong ISteamUGC_CreateQueryUGCDetailsRequest(IntPtr instancePtr, [In, Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs); // 0x00000001802C61D0-0x00000001802C6270
		public static extern ulong ISteamUGC_SendQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle); // 0x00000001802C7730-0x00000001802C77C0
		public static extern bool ISteamUGC_GetQueryUGCResult(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails); // 0x00000001802C6EB0-0x00000001802C7020
		public static extern bool ISteamUGC_GetQueryUGCPreviewURL(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize); // 0x00000001802C6DF0-0x00000001802C6EB0
		public static extern bool ISteamUGC_GetQueryUGCMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize); // 0x00000001802C6BF0-0x00000001802C6CB0
		public static extern bool ISteamUGC_GetQueryUGCChildren(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, [In, Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries); // 0x00000001802C6A50-0x00000001802C6B10
		public static extern bool ISteamUGC_GetQueryUGCStatistic(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue); // 0x00000001802C7020-0x00000001802C70E0
		public static extern uint ISteamUGC_GetQueryUGCNumAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, uint index); // 0x00000001802C6CB0-0x00000001802C6D50
		public static extern bool ISteamUGC_GetQueryUGCAdditionalPreview(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType); // 0x00000001802C6960-0x00000001802C6A50
		public static extern uint ISteamUGC_GetQueryUGCNumKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, uint index); // 0x00000001802C6D50-0x00000001802C6DF0
		public static extern bool ISteamUGC_GetQueryUGCKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize); // 0x00000001802C6B10-0x00000001802C6BF0
		public static extern bool ISteamUGC_GetQueryFirstUGCKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, InteropHelp.UTF8StringHandle pchKey, IntPtr pchValue, uint cchValueSize); // 0x00000001802C6840-0x00000001802C6960
		public static extern bool ISteamUGC_ReleaseQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle); // 0x00000001802C7210-0x00000001802C72A0
		public static extern bool ISteamUGC_AddRequiredTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName); // 0x00000001802C5D90-0x00000001802C5E70
		public static extern bool ISteamUGC_AddRequiredTagGroup(IntPtr instancePtr, UGCQueryHandle_t handle, IntPtr pTagGroups); // 0x00000001802C5CF0-0x00000001802C5D90
		public static extern bool ISteamUGC_AddExcludedTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName); // 0x00000001802C5700-0x00000001802C57E0
		public static extern bool ISteamUGC_SetReturnOnlyIDs(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnOnlyIDs); // 0x00000001802C85A0-0x00000001802C8640
		public static extern bool ISteamUGC_SetReturnKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnKeyValueTags); // 0x00000001802C83C0-0x00000001802C8460
		public static extern bool ISteamUGC_SetReturnLongDescription(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnLongDescription); // 0x00000001802C8460-0x00000001802C8500
		public static extern bool ISteamUGC_SetReturnMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnMetadata); // 0x00000001802C8500-0x00000001802C85A0
		public static extern bool ISteamUGC_SetReturnChildren(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnChildren); // 0x00000001802C8320-0x00000001802C83C0
		public static extern bool ISteamUGC_SetReturnAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnAdditionalPreviews); // 0x00000001802C8280-0x00000001802C8320
		public static extern bool ISteamUGC_SetReturnTotalOnly(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnTotalOnly); // 0x00000001802C86E0-0x00000001802C8780
		public static extern bool ISteamUGC_SetReturnPlaytimeStats(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays); // 0x00000001802C8640-0x00000001802C86E0
		public static extern bool ISteamUGC_SetLanguage(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage); // 0x00000001802C8060-0x00000001802C8140
		public static extern bool ISteamUGC_SetAllowCachedResponse(IntPtr instancePtr, UGCQueryHandle_t handle, uint unMaxAgeSeconds); // 0x00000001802C77C0-0x00000001802C7860
		public static extern bool ISteamUGC_SetCloudFileNameFilter(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pMatchCloudFileName); // 0x00000001802C7900-0x00000001802C79E0
		public static extern bool ISteamUGC_SetMatchAnyTag(IntPtr instancePtr, UGCQueryHandle_t handle, bool bMatchAnyTag); // 0x00000001802C8140-0x00000001802C81E0
		public static extern bool ISteamUGC_SetSearchText(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pSearchText); // 0x00000001802C8780-0x00000001802C8860
		public static extern bool ISteamUGC_SetRankedByTrendDays(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays); // 0x00000001802C81E0-0x00000001802C8280
		public static extern bool ISteamUGC_AddRequiredKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue); // 0x00000001802C5BA0-0x00000001802C5CF0
		public static extern ulong ISteamUGC_RequestUGCDetails(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds); // 0x00000001802C7690-0x00000001802C7730
		public static extern ulong ISteamUGC_CreateItem(IntPtr instancePtr, AppId_t nConsumerAppId, EWorkshopFileType eFileType); // 0x00000001802C5F50-0x00000001802C5FF0
		public static extern ulong ISteamUGC_StartItemUpdate(IntPtr instancePtr, AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID); // 0x00000001802C8900-0x00000001802C89A0
		public static extern bool ISteamUGC_SetItemTitle(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchTitle); // 0x00000001802C7E00-0x00000001802C7EE0
		public static extern bool ISteamUGC_SetItemDescription(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchDescription); // 0x00000001802C7AC0-0x00000001802C7BA0
		public static extern bool ISteamUGC_SetItemUpdateLanguage(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage); // 0x00000001802C7EE0-0x00000001802C7FC0
		public static extern bool ISteamUGC_SetItemMetadata(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchMetaData); // 0x00000001802C7BA0-0x00000001802C7C80
		public static extern bool ISteamUGC_SetItemVisibility(IntPtr instancePtr, UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility); // 0x00000001802C7FC0-0x00000001802C8060
		public static extern bool ISteamUGC_SetItemTags(IntPtr instancePtr, UGCUpdateHandle_t updateHandle, IntPtr pTags); // 0x00000001802C7D60-0x00000001802C7E00
		public static extern bool ISteamUGC_SetItemContent(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszContentFolder); // 0x00000001802C79E0-0x00000001802C7AC0
		public static extern bool ISteamUGC_SetItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile); // 0x00000001802C7C80-0x00000001802C7D60
		public static extern bool ISteamUGC_SetAllowLegacyUpload(IntPtr instancePtr, UGCUpdateHandle_t handle, bool bAllowLegacyUpload); // 0x00000001802C7860-0x00000001802C7900
		public static extern bool ISteamUGC_RemoveAllItemKeyValueTags(IntPtr instancePtr, UGCUpdateHandle_t handle); // 0x00000001802C72A0-0x00000001802C7330
		public static extern bool ISteamUGC_RemoveItemKeyValueTags(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey); // 0x00000001802C7510-0x00000001802C75F0
		public static extern bool ISteamUGC_AddItemKeyValueTag(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue); // 0x00000001802C57E0-0x00000001802C5930
		public static extern bool ISteamUGC_AddItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile, EItemPreviewType type); // 0x00000001802C5930-0x00000001802C5A20
		public static extern bool ISteamUGC_AddItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszVideoID); // 0x00000001802C5A20-0x00000001802C5B00
		public static extern bool ISteamUGC_UpdateItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszPreviewFile); // 0x00000001802C8DF0-0x00000001802C8EE0
		public static extern bool ISteamUGC_UpdateItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszVideoID); // 0x00000001802C8EE0-0x00000001802C8FD0
		public static extern bool ISteamUGC_RemoveItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index); // 0x00000001802C75F0-0x00000001802C7690
		public static extern ulong ISteamUGC_SubmitItemUpdate(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchChangeNote); // 0x00000001802C8B60-0x00000001802C8C40
		public static extern EItemUpdateStatus ISteamUGC_GetItemUpdateProgress(IntPtr instancePtr, UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal); // 0x00000001802C6710-0x00000001802C67C0
		public static extern ulong ISteamUGC_SetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, bool bVoteUp); // 0x00000001802C8860-0x00000001802C8900
		public static extern ulong ISteamUGC_GetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID); // 0x00000001802C7180-0x00000001802C7210
		public static extern ulong ISteamUGC_AddItemToFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID); // 0x00000001802C5B00-0x00000001802C5BA0
		public static extern ulong ISteamUGC_RemoveItemFromFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID); // 0x00000001802C7470-0x00000001802C7510
		public static extern ulong ISteamUGC_SubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID); // 0x00000001802C8C40-0x00000001802C8CD0
		public static extern ulong ISteamUGC_UnsubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID); // 0x00000001802C8D60-0x00000001802C8DF0
		public static extern uint ISteamUGC_GetNumSubscribedItems(IntPtr instancePtr); // 0x00000001802C67C0-0x00000001802C6840
		public static extern uint ISteamUGC_GetSubscribedItems(IntPtr instancePtr, [In, Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries); // 0x00000001802C70E0-0x00000001802C7180
		public static extern uint ISteamUGC_GetItemState(IntPtr instancePtr, PublishedFileId_t nPublishedFileID); // 0x00000001802C6680-0x00000001802C6710
		public static extern bool ISteamUGC_GetItemInstallInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, out uint punTimeStamp); // 0x00000001802C65B0-0x00000001802C6680
		public static extern bool ISteamUGC_GetItemDownloadInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal); // 0x00000001802C6500-0x00000001802C65B0
		public static extern bool ISteamUGC_DownloadItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, bool bHighPriority); // 0x00000001802C63D0-0x00000001802C6470
		public static extern bool ISteamUGC_BInitWorkshopForGameServer(IntPtr instancePtr, DepotId_t unWorkshopDepotID, InteropHelp.UTF8StringHandle pszFolder); // 0x00000001802C5E70-0x00000001802C5F50
		public static extern void ISteamUGC_SuspendDownloads(IntPtr instancePtr, bool bSuspend); // 0x00000001802C8CD0-0x00000001802C8D60
		public static extern ulong ISteamUGC_StartPlaytimeTracking(IntPtr instancePtr, [In, Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs); // 0x00000001802C89A0-0x00000001802C8A40
		public static extern ulong ISteamUGC_StopPlaytimeTracking(IntPtr instancePtr, [In, Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs); // 0x00000001802C8AC0-0x00000001802C8B60
		public static extern ulong ISteamUGC_StopPlaytimeTrackingForAllItems(IntPtr instancePtr); // 0x00000001802C8A40-0x00000001802C8AC0
		public static extern ulong ISteamUGC_AddDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID); // 0x00000001802C5660-0x00000001802C5700
		public static extern ulong ISteamUGC_RemoveDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID); // 0x00000001802C73D0-0x00000001802C7470
		public static extern ulong ISteamUGC_AddAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID); // 0x00000001802C55C0-0x00000001802C5660
		public static extern ulong ISteamUGC_RemoveAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID); // 0x00000001802C7330-0x00000001802C73D0
		public static extern ulong ISteamUGC_GetAppDependencies(IntPtr instancePtr, PublishedFileId_t nPublishedFileID); // 0x00000001802C6470-0x00000001802C6500
		public static extern ulong ISteamUGC_DeleteItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID); // 0x00000001802C6340-0x00000001802C63D0
		public static extern int ISteamUser_GetHSteamUser(IntPtr instancePtr); // 0x00000001802CBC10-0x00000001802CBC90
		public static extern bool ISteamUser_BLoggedOn(IntPtr instancePtr); // 0x00000001802CB5A0-0x00000001802CB620
		public static extern ulong ISteamUser_GetSteamID(IntPtr instancePtr); // 0x00000001802CBD90-0x00000001802CBE10
		public static extern int ISteamUser_InitiateGameConnection(IntPtr instancePtr, byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure); // 0x00000001802CC040-0x00000001802CC120
		public static extern void ISteamUser_TerminateGameConnection(IntPtr instancePtr, uint unIPServer, ushort usPortServer); // 0x00000001802CC3A0-0x00000001802CC440
		public static extern void ISteamUser_TrackAppUsageEvent(IntPtr instancePtr, CGameID gameID, int eAppUsageEvent, InteropHelp.UTF8StringHandle pchExtraInfo); // 0x00000001802CC440-0x00000001802CC530
		public static extern bool ISteamUser_GetUserDataFolder(IntPtr instancePtr, IntPtr pchBuffer, int cubBuffer); // 0x00000001802CBE10-0x00000001802CBEB0
		public static extern void ISteamUser_StartVoiceRecording(IntPtr instancePtr); // 0x00000001802CC2A0-0x00000001802CC320
		public static extern void ISteamUser_StopVoiceRecording(IntPtr instancePtr); // 0x00000001802CC320-0x00000001802CC3A0
		public static extern EVoiceResult ISteamUser_GetAvailableVoice(IntPtr instancePtr, out uint pcbCompressed, IntPtr pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated); // 0x00000001802CB980-0x00000001802CBA30
		public static extern EVoiceResult ISteamUser_GetVoice(IntPtr instancePtr, bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, IntPtr nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated); // 0x00000001802CBF30-0x00000001802CC040
		public static extern EVoiceResult ISteamUser_DecompressVoice(IntPtr instancePtr, byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate); // 0x00000001802CB760-0x00000001802CB840
		public static extern uint ISteamUser_GetVoiceOptimalSampleRate(IntPtr instancePtr); // 0x00000001802CBEB0-0x00000001802CBF30
		public static extern uint ISteamUser_GetAuthSessionTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket); // 0x00000001802CB8D0-0x00000001802CB980
		public static extern EBeginAuthSessionResult ISteamUser_BeginAuthSession(IntPtr instancePtr, byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID); // 0x00000001802CB620-0x00000001802CB6D0
		public static extern void ISteamUser_EndAuthSession(IntPtr instancePtr, CSteamID steamID); // 0x00000001802CB840-0x00000001802CB8D0
		public static extern void ISteamUser_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket); // 0x00000001802CB6D0-0x00000001802CB760
		public static extern EUserHasLicenseForAppResult ISteamUser_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID); // 0x00000001802CC530-0x00000001802CC5D0
		public static extern bool ISteamUser_BIsBehindNAT(IntPtr instancePtr); // 0x00000001802CB320-0x00000001802CB3A0
		public static extern void ISteamUser_AdvertiseGame(IntPtr instancePtr, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer); // 0x00000001802CB270-0x00000001802CB320
		public static extern ulong ISteamUser_RequestEncryptedAppTicket(IntPtr instancePtr, byte[] pDataToInclude, int cbDataToInclude); // 0x00000001802CC120-0x00000001802CC1C0
		public static extern bool ISteamUser_GetEncryptedAppTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket); // 0x00000001802CBAB0-0x00000001802CBB70
		public static extern int ISteamUser_GetGameBadgeLevel(IntPtr instancePtr, int nSeries, bool bFoil); // 0x00000001802CBB70-0x00000001802CBC10
		public static extern int ISteamUser_GetPlayerSteamLevel(IntPtr instancePtr); // 0x00000001802CBD10-0x00000001802CBD90
		public static extern ulong ISteamUser_RequestStoreAuthURL(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchRedirectURL); // 0x00000001802CC1C0-0x00000001802CC2A0
		public static extern bool ISteamUser_BIsPhoneVerified(IntPtr instancePtr); // 0x00000001802CB4A0-0x00000001802CB520
		public static extern bool ISteamUser_BIsTwoFactorEnabled(IntPtr instancePtr); // 0x00000001802CB520-0x00000001802CB5A0
		public static extern bool ISteamUser_BIsPhoneIdentifying(IntPtr instancePtr); // 0x00000001802CB3A0-0x00000001802CB420
		public static extern bool ISteamUser_BIsPhoneRequiringVerification(IntPtr instancePtr); // 0x00000001802CB420-0x00000001802CB4A0
		public static extern ulong ISteamUser_GetMarketEligibility(IntPtr instancePtr); // 0x00000001802CBC90-0x00000001802CBD10
		public static extern ulong ISteamUser_GetDurationControl(IntPtr instancePtr); // 0x00000001802CBA30-0x00000001802CBAB0
		public static extern bool ISteamUserStats_RequestCurrentStats(IntPtr instancePtr); // 0x00000001802CAAA0-0x00000001802CAB20
		public static extern bool ISteamUserStats_GetStatInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out int pData); // 0x00000001802CA4B0-0x00000001802CA5A0
		public static extern bool ISteamUserStats_GetStatFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pData); // 0x00000001802CA3C0-0x00000001802CA4B0
		public static extern bool ISteamUserStats_SetStatInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, int nData); // 0x00000001802CAF20-0x00000001802CB010
		public static extern bool ISteamUserStats_SetStatFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float fData); // 0x00000001802CAE30-0x00000001802CAF20
		public static extern bool ISteamUserStats_UpdateAvgRateStat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength); // 0x00000001802CB090-0x00000001802CB1A0
		public static extern bool ISteamUserStats_GetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved); // 0x00000001802C9920-0x00000001802C9A20
		public static extern bool ISteamUserStats_SetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName); // 0x00000001802CAD50-0x00000001802CAE30
		public static extern bool ISteamUserStats_ClearAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName); // 0x00000001802C9070-0x00000001802C9150
		public static extern bool ISteamUserStats_GetAchievementAndUnlockTime(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime); // 0x00000001802C9570-0x00000001802C9680
		public static extern bool ISteamUserStats_StoreStats(IntPtr instancePtr); // 0x00000001802CB010-0x00000001802CB090
		public static extern int ISteamUserStats_GetAchievementIcon(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName); // 0x00000001802C97C0-0x00000001802C9890
		public static extern IntPtr ISteamUserStats_GetAchievementDisplayAttribute(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, InteropHelp.UTF8StringHandle pchKey); // 0x00000001802C9680-0x00000001802C97C0
		public static extern bool ISteamUserStats_IndicateAchievementProgress(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, uint nCurProgress, uint nMaxProgress); // 0x00000001802CA9B0-0x00000001802CAAA0
		public static extern uint ISteamUserStats_GetNumAchievements(IntPtr instancePtr); // 0x00000001802CA2C0-0x00000001802CA340
		public static extern IntPtr ISteamUserStats_GetAchievementName(IntPtr instancePtr, uint iAchievement); // 0x00000001802C9890-0x00000001802C9920
		public static extern ulong ISteamUserStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser); // 0x00000001802CAC30-0x00000001802CACC0
		public static extern bool ISteamUserStats_GetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData); // 0x00000001802CA8C0-0x00000001802CA9B0
		public static extern bool ISteamUserStats_GetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData); // 0x00000001802CA7D0-0x00000001802CA8C0
		public static extern bool ISteamUserStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved); // 0x00000001802CA6C0-0x00000001802CA7D0
		public static extern bool ISteamUserStats_GetUserAchievementAndUnlockTime(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime); // 0x00000001802CA5A0-0x00000001802CA6C0
		public static extern bool ISteamUserStats_ResetAllStats(IntPtr instancePtr, bool bAchievementsToo); // 0x00000001802CACC0-0x00000001802CAD50
		public static extern ulong ISteamUserStats_FindOrCreateLeaderboard(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType); // 0x00000001802C9390-0x00000001802C9480
		public static extern ulong ISteamUserStats_FindLeaderboard(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchLeaderboardName); // 0x00000001802C92B0-0x00000001802C9390
		public static extern IntPtr ISteamUserStats_GetLeaderboardName(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard); // 0x00000001802C9FF0-0x00000001802CA080
		public static extern int ISteamUserStats_GetLeaderboardEntryCount(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard); // 0x00000001802C9F60-0x00000001802C9FF0
		public static extern ELeaderboardSortMethod ISteamUserStats_GetLeaderboardSortMethod(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard); // 0x00000001802CA080-0x00000001802CA110
		public static extern ELeaderboardDisplayType ISteamUserStats_GetLeaderboardDisplayType(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard); // 0x00000001802C9ED0-0x00000001802C9F60
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntries(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd); // 0x00000001802C9200-0x00000001802C92B0
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntriesForUsers(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, [In, Out] CSteamID[] prgUsers, int cUsers); // 0x00000001802C9150-0x00000001802C9200
		public static extern bool ISteamUserStats_GetDownloadedLeaderboardEntry(IntPtr instancePtr, SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, [In, Out] int[] pDetails, int cDetailsMax); // 0x00000001802C9A20-0x00000001802C9AF0
		public static extern ulong ISteamUserStats_UploadLeaderboardScore(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In, Out] int[] pScoreDetails, int cScoreDetailsCount); // 0x00000001802CB1A0-0x00000001802CB270
		public static extern ulong ISteamUserStats_AttachLeaderboardUGC(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC); // 0x00000001802C8FD0-0x00000001802C9070
		public static extern ulong ISteamUserStats_GetNumberOfCurrentPlayers(IntPtr instancePtr); // 0x00000001802CA340-0x00000001802CA3C0
		public static extern ulong ISteamUserStats_RequestGlobalAchievementPercentages(IntPtr instancePtr); // 0x00000001802CAB20-0x00000001802CABA0
		public static extern int ISteamUserStats_GetMostAchievedAchievementInfo(IntPtr instancePtr, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved); // 0x00000001802CA110-0x00000001802CA1E0
		public static extern int ISteamUserStats_GetNextMostAchievedAchievementInfo(IntPtr instancePtr, int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved); // 0x00000001802CA1E0-0x00000001802CA2C0
		public static extern bool ISteamUserStats_GetAchievementAchievedPercent(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pflPercent); // 0x00000001802C9480-0x00000001802C9570
		public static extern ulong ISteamUserStats_RequestGlobalStats(IntPtr instancePtr, int nHistoryDays); // 0x00000001802CABA0-0x00000001802CAC30
		public static extern bool ISteamUserStats_GetGlobalStatInt64(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, out long pData); // 0x00000001802C9DE0-0x00000001802C9ED0
		public static extern bool ISteamUserStats_GetGlobalStatDouble(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, out double pData); // 0x00000001802C9AF0-0x00000001802C9BE0
		public static extern int ISteamUserStats_GetGlobalStatHistoryInt64(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, [In, Out] long[] pData, uint cubData); // 0x00000001802C9CE0-0x00000001802C9DE0
		public static extern int ISteamUserStats_GetGlobalStatHistoryDouble(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, [In, Out] double[] pData, uint cubData); // 0x00000001802C9BE0-0x00000001802C9CE0
		public static extern uint ISteamUtils_GetSecondsSinceAppActive(IntPtr instancePtr); // 0x00000001802CCFE0-0x00000001802CD060
		public static extern uint ISteamUtils_GetSecondsSinceComputerActive(IntPtr instancePtr); // 0x00000001802CD060-0x00000001802CD0E0
		public static extern EUniverse ISteamUtils_GetConnectedUniverse(IntPtr instancePtr); // 0x00000001802CCAD0-0x00000001802CCB50
		public static extern uint ISteamUtils_GetServerRealTime(IntPtr instancePtr); // 0x00000001802CD0E0-0x00000001802CD160
		public static extern IntPtr ISteamUtils_GetIPCountry(IntPtr instancePtr); // 0x00000001802CCD70-0x00000001802CCDF0
		public static extern bool ISteamUtils_GetImageSize(IntPtr instancePtr, int iImage, out uint pnWidth, out uint pnHeight); // 0x00000001802CCF30-0x00000001802CCFE0
		public static extern bool ISteamUtils_GetImageRGBA(IntPtr instancePtr, int iImage, byte[] pubDest, int nDestBufferSize); // 0x00000001802CCE80-0x00000001802CCF30
		public static extern bool ISteamUtils_GetCSERIPPort(IntPtr instancePtr, out uint unIP, out ushort usPort); // 0x00000001802CCA30-0x00000001802CCAD0
		public static extern byte ISteamUtils_GetCurrentBatteryPower(IntPtr instancePtr); // 0x00000001802CCB50-0x00000001802CCBD0
		public static extern uint ISteamUtils_GetAppID(IntPtr instancePtr); // 0x00000001802CC9B0-0x00000001802CCA30
		public static extern void ISteamUtils_SetOverlayNotificationPosition(IntPtr instancePtr, ENotificationPosition eNotificationPosition); // 0x00000001802CD630-0x00000001802CD6C0
		public static extern bool ISteamUtils_IsAPICallCompleted(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, out bool pbFailed); // 0x00000001802CD260-0x00000001802CD310
		public static extern ESteamAPICallFailure ISteamUtils_GetAPICallFailureReason(IntPtr instancePtr, SteamAPICall_t hSteamAPICall); // 0x00000001802CC840-0x00000001802CC8D0
		public static extern bool ISteamUtils_GetAPICallResult(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed); // 0x00000001802CC8D0-0x00000001802CC9B0
		public static extern uint ISteamUtils_GetIPCCallCount(IntPtr instancePtr); // 0x00000001802CCCF0-0x00000001802CCD70
		public static extern void ISteamUtils_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction); // 0x00000001802CD750-0x00000001802CD7F0
		public static extern bool ISteamUtils_IsOverlayEnabled(IntPtr instancePtr); // 0x00000001802CD310-0x00000001802CD390
		public static extern bool ISteamUtils_BOverlayNeedsPresent(IntPtr instancePtr); // 0x00000001802CC5D0-0x00000001802CC650
		public static extern ulong ISteamUtils_CheckFileSignature(IntPtr instancePtr, InteropHelp.UTF8StringHandle szFileName); // 0x00000001802CC650-0x00000001802CC730
		public static extern bool ISteamUtils_ShowGamepadTextInput(IntPtr instancePtr, EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, InteropHelp.UTF8StringHandle pchDescription, uint unCharMax, InteropHelp.UTF8StringHandle pchExistingText); // 0x00000001802CD7F0-0x00000001802CD970
		public static extern uint ISteamUtils_GetEnteredGamepadTextLength(IntPtr instancePtr); // 0x00000001802CCC70-0x00000001802CCCF0
		public static extern bool ISteamUtils_GetEnteredGamepadTextInput(IntPtr instancePtr, IntPtr pchText, uint cchText); // 0x00000001802CCBD0-0x00000001802CCC70
		public static extern IntPtr ISteamUtils_GetSteamUILanguage(IntPtr instancePtr); // 0x00000001802CD160-0x00000001802CD1E0
		public static extern bool ISteamUtils_IsSteamRunningInVR(IntPtr instancePtr); // 0x00000001802CD490-0x00000001802CD510
		public static extern void ISteamUtils_SetOverlayNotificationInset(IntPtr instancePtr, int nHorizontalInset, int nVerticalInset); // 0x00000001802CD590-0x00000001802CD630
		public static extern bool ISteamUtils_IsSteamInBigPictureMode(IntPtr instancePtr); // 0x00000001802CD410-0x00000001802CD490
		public static extern void ISteamUtils_StartVRDashboard(IntPtr instancePtr); // 0x00000001802CD970-0x00000001802CD9F0
		public static extern bool ISteamUtils_IsVRHeadsetStreamingEnabled(IntPtr instancePtr); // 0x00000001802CD510-0x00000001802CD590
		public static extern void ISteamUtils_SetVRHeadsetStreamingEnabled(IntPtr instancePtr, bool bEnabled); // 0x00000001802CD6C0-0x00000001802CD750
		public static extern bool ISteamUtils_IsSteamChinaLauncher(IntPtr instancePtr); // 0x00000001802CD390-0x00000001802CD410
		public static extern bool ISteamUtils_InitFilterText(IntPtr instancePtr); // 0x00000001802CD1E0-0x00000001802CD260
		public static extern int ISteamUtils_FilterText(IntPtr instancePtr, IntPtr pchOutFilteredText, uint nByteSizeOutFilteredText, InteropHelp.UTF8StringHandle pchInputMessage, bool bLegalOnly); // 0x00000001802CC730-0x00000001802CC840
		public static extern ESteamIPv6ConnectivityState ISteamUtils_GetIPv6ConnectivityState(IntPtr instancePtr, ESteamIPv6ConnectivityProtocol eProtocol); // 0x00000001802CCDF0-0x00000001802CCE80
		public static extern void ISteamVideo_GetVideoURL(IntPtr instancePtr, AppId_t unVideoAppID); // 0x00000001802CDB30-0x00000001802CDBC0
		public static extern bool ISteamVideo_IsBroadcasting(IntPtr instancePtr, out int pnNumViewers); // 0x00000001802CDBC0-0x00000001802CDC50
		public static extern void ISteamVideo_GetOPFSettings(IntPtr instancePtr, AppId_t unVideoAppID); // 0x00000001802CD9F0-0x00000001802CDA80
		public static extern bool ISteamVideo_GetOPFStringForApp(IntPtr instancePtr, AppId_t unVideoAppID, IntPtr pchBuffer, ref int pnBufferSize); // 0x00000001802CDA80-0x00000001802CDB30
	}
}
