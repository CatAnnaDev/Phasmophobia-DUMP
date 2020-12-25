/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamRemoteStorage // TypeDefIndex: 6490
	{
		// Methods
		public static bool FileWrite(string pchFile, byte[] pvData, int cubData) => default; // 0x00000001807AC9B0-0x00000001807ACB00
		public static int FileRead(string pchFile, byte[] pvData, int cubDataToRead) => default; // 0x00000001807AC310-0x00000001807AC460
		public static SteamAPICall_t FileWriteAsync(string pchFile, byte[] pvData, uint cubData) => default; // 0x00000001807AC5C0-0x00000001807AC730
		public static SteamAPICall_t FileReadAsync(string pchFile, uint nOffset, uint cubToRead) => default; // 0x00000001807AC1A0-0x00000001807AC310
		public static bool FileReadAsyncComplete(SteamAPICall_t hReadCall, byte[] pvBuffer, uint cubToRead) => default; // 0x00000001807AC120-0x00000001807AC1A0
		public static bool FileForget(string pchFile) => default; // 0x00000001807ABEC0-0x00000001807ABFF0
		public static bool FileDelete(string pchFile) => default; // 0x00000001807ABC60-0x00000001807ABD90
		public static SteamAPICall_t FileShare(string pchFile) => default; // 0x00000001807AC460-0x00000001807AC5C0
		public static bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform) => default; // 0x00000001807ADC10-0x00000001807ADD50
		public static UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile) => default; // 0x00000001807AC7D0-0x00000001807AC930
		public static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData) => default; // 0x00000001807AC930-0x00000001807AC9B0
		public static bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle) => default; // 0x00000001807AC780-0x00000001807AC7D0
		public static bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle) => default; // 0x00000001807AC730-0x00000001807AC780
		public static bool FileExists(string pchFile) => default; // 0x00000001807ABD90-0x00000001807ABEC0
		public static bool FilePersisted(string pchFile) => default; // 0x00000001807ABFF0-0x00000001807AC120
		public static int GetFileSize(string pchFile) => default; // 0x00000001807ACCB0-0x00000001807ACDE0
		public static long GetFileTimestamp(string pchFile) => default; // 0x00000001807ACDE0-0x00000001807ACF10
		public static ERemoteStoragePlatform GetSyncPlatforms(string pchFile) => default; // 0x00000001807AD0C0-0x00000001807AD1F0
		public static int GetFileCount() => default; // 0x00000001807ACBF0-0x00000001807ACC40
		public static string GetFileNameAndSize(int iFile, out int pnFileSizeInBytes) {
			pnFileSizeInBytes = default;
			return default;
		} // 0x00000001807ACC40-0x00000001807ACCB0
		public static bool GetQuota(out ulong pnTotalBytes, out ulong puAvailableBytes) {
			pnTotalBytes = default;
			puAvailableBytes = default;
			return default;
		} // 0x00000001807AD060-0x00000001807AD0C0
		public static bool IsCloudEnabledForAccount() => default; // 0x00000001807AD3D0-0x00000001807AD420
		public static bool IsCloudEnabledForApp() => default; // 0x00000001807AD420-0x00000001807AD470
		public static void SetCloudEnabledForApp(bool bEnabled) {} // 0x00000001807ADBC0-0x00000001807ADC10
		public static SteamAPICall_t UGCDownload(UGCHandle_t hContent, uint unPriority) => default; // 0x00000001807AE010-0x00000001807AE0C0
		public static bool GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected) {
			pnBytesDownloaded = default;
			pnBytesExpected = default;
			return default;
		} // 0x00000001807AD2B0-0x00000001807AD330
		public static bool GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out string ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner) {
			pnAppID = default;
			ppchName = default;
			pnFileSizeInBytes = default;
			pSteamIDOwner = default;
			return default;
		} // 0x00000001807AD1F0-0x00000001807AD2B0
		public static int UGCRead(UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction) => default; // 0x00000001807AE0C0-0x00000001807AE150
		public static int GetCachedUGCCount() => default; // 0x00000001807ACB00-0x00000001807ACB50
		public static UGCHandle_t GetCachedUGCHandle(int iCachedContent) => default; // 0x00000001807ACB50-0x00000001807ACBF0
		public static SteamAPICall_t PublishWorkshopFile(string pchFile, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags, EWorkshopFileType eWorkshopFileType) => default; // 0x00000001807AD860-0x00000001807ADBC0
		public static PublishedFileUpdateHandle_t CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId) => default; // 0x00000001807AB6C0-0x00000001807AB760
		public static bool UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, string pchFile) => default; // 0x00000001807AE330-0x00000001807AE470
		public static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, string pchPreviewFile) => default; // 0x00000001807AE470-0x00000001807AE5B0
		public static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, string pchTitle) => default; // 0x00000001807AE7B0-0x00000001807AE8F0
		public static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, string pchDescription) => default; // 0x00000001807AE1F0-0x00000001807AE330
		public static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility) => default; // 0x00000001807AE8F0-0x00000001807AE950
		public static bool UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IList<string> pTags) => default; // 0x00000001807AE6F0-0x00000001807AE7B0
		public static SteamAPICall_t CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle) => default; // 0x00000001807AB620-0x00000001807AB6C0
		public static SteamAPICall_t GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld) => default; // 0x00000001807ACF10-0x00000001807ACFC0
		public static SteamAPICall_t DeletePublishedFile(PublishedFileId_t unPublishedFileId) => default; // 0x00000001807AB760-0x00000001807AB800
		public static SteamAPICall_t EnumerateUserPublishedFiles(uint unStartIndex) => default; // 0x00000001807AB9F0-0x00000001807ABA90
		public static SteamAPICall_t SubscribePublishedFile(PublishedFileId_t unPublishedFileId) => default; // 0x00000001807ADE00-0x00000001807ADEA0
		public static SteamAPICall_t EnumerateUserSubscribedFiles(uint unStartIndex) => default; // 0x00000001807ABBC0-0x00000001807ABC60
		public static SteamAPICall_t UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId) => default; // 0x00000001807AE150-0x00000001807AE1F0
		public static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, string pchChangeDescription) => default; // 0x00000001807AE5B0-0x00000001807AE6F0
		public static SteamAPICall_t GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId) => default; // 0x00000001807ACFC0-0x00000001807AD060
		public static SteamAPICall_t UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp) => default; // 0x00000001807AE950-0x00000001807AEA00
		public static SteamAPICall_t GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId) => default; // 0x00000001807AD330-0x00000001807AD3D0
		public static SteamAPICall_t EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IList<string> pRequiredTags, IList<string> pExcludedTags) => default; // 0x00000001807ABA90-0x00000001807ABBC0
		public static SteamAPICall_t PublishVideo(EWorkshopVideoProvider eVideoProvider, string pchVideoAccount, string pchVideoIdentifier, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags) => default; // 0x00000001807AD470-0x00000001807AD860
		public static SteamAPICall_t SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction) => default; // 0x00000001807ADD50-0x00000001807ADE00
		public static SteamAPICall_t EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex) => default; // 0x00000001807AB800-0x00000001807AB8A0
		public static SteamAPICall_t EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IList<string> pTags, IList<string> pUserTags) => default; // 0x00000001807AB8A0-0x00000001807AB9F0
		public static SteamAPICall_t UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority) => default; // 0x00000001807ADEA0-0x00000001807AE010
	}
}
