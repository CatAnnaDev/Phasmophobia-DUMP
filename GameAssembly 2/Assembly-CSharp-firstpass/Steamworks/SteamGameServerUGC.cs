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
	public static class SteamGameServerUGC // TypeDefIndex: 6473
	{
		// Methods
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) => default; // 0x000000018079A220-0x000000018079A310
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) => default; // 0x000000018079A0A0-0x000000018079A170
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, string pchCursor = null) => default; // 0x0000000180799F10-0x000000018079A0A0
		public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) => default; // 0x000000018079A170-0x000000018079A220
		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle) => default; // 0x000000018079B760-0x000000018079B800
		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails) {
			pDetails = default;
			return default;
		} // 0x000000018079B060-0x000000018079B0E0
		public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize) {
			pchURL = default;
			return default;
		} // 0x000000018079AF40-0x000000018079B060
		public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize) {
			pchMetadata = default;
			return default;
		} // 0x000000018079AD60-0x000000018079AE80
		public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) => default; // 0x000000018079A940-0x000000018079A9D0
		public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue) {
			pStatValue = default;
			return default;
		} // 0x000000018079B0E0-0x000000018079B170
		public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index) => default; // 0x000000018079AE80-0x000000018079AEE0
		public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType) {
			pchURLOrVideoID = default;
			pchOriginalFileName = default;
			pPreviewType = default;
			return default;
		} // 0x000000018079A780-0x000000018079A940
		public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index) => default; // 0x000000018079AEE0-0x000000018079AF40
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize) {
			pchKey = default;
			pchValue = default;
			return default;
		} // 0x000000018079ABB0-0x000000018079AD60
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue, uint cchValueSize) {
			pchValue = default;
			return default;
		} // 0x000000018079A9D0-0x000000018079ABB0
		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle) => default; // 0x000000018079B270-0x000000018079B2C0
		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName) => default; // 0x0000000180799BF0-0x0000000180799D30
		public static bool AddRequiredTagGroup(UGCQueryHandle_t handle, IList<string> pTagGroups) => default; // 0x0000000180799B30-0x0000000180799BF0
		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName) => default; // 0x0000000180799340-0x0000000180799480
		public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs) => default; // 0x000000018079C680-0x000000018079C6E0
		public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags) => default; // 0x000000018079C560-0x000000018079C5C0
		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription) => default; // 0x000000018079C5C0-0x000000018079C620
		public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata) => default; // 0x000000018079C620-0x000000018079C680
		public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren) => default; // 0x000000018079C500-0x000000018079C560
		public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) => default; // 0x000000018079C4A0-0x000000018079C500
		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly) => default; // 0x000000018079C740-0x000000018079C7A0
		public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays) => default; // 0x000000018079C6E0-0x000000018079C740
		public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage) => default; // 0x000000018079C2A0-0x000000018079C3E0
		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds) => default; // 0x000000018079B800-0x000000018079B860
		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName) => default; // 0x000000018079B8C0-0x000000018079BA00
		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag) => default; // 0x000000018079C3E0-0x000000018079C440
		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText) => default; // 0x000000018079C7A0-0x000000018079C8E0
		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays) => default; // 0x000000018079C440-0x000000018079C4A0
		public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue) => default; // 0x0000000180799970-0x0000000180799B30
		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds) => default; // 0x000000018079B6B0-0x000000018079B760
		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType) => default; // 0x0000000180799E70-0x0000000180799F10
		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID) => default; // 0x000000018079C990-0x000000018079CA30
		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle) => default; // 0x000000018079BFC0-0x000000018079C100
		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription) => default; // 0x000000018079BB40-0x000000018079BC80
		public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage) => default; // 0x000000018079C100-0x000000018079C240
		public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData) => default; // 0x000000018079BC80-0x000000018079BDC0
		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility) => default; // 0x000000018079C240-0x000000018079C2A0
		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags) => default; // 0x000000018079BF00-0x000000018079BFC0
		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder) => default; // 0x000000018079BA00-0x000000018079BB40
		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile) => default; // 0x000000018079BDC0-0x000000018079BF00
		public static bool SetAllowLegacyUpload(UGCUpdateHandle_t handle, bool bAllowLegacyUpload) => default; // 0x000000018079B860-0x000000018079B8C0
		public static bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle) => default; // 0x000000018079B2C0-0x000000018079B310
		public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey) => default; // 0x000000018079B510-0x000000018079B650
		public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue) => default; // 0x0000000180799480-0x0000000180799640
		public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type) => default; // 0x0000000180799640-0x0000000180799790
		public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID) => default; // 0x0000000180799790-0x00000001807998D0
		public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile) => default; // 0x000000018079CF10-0x000000018079D060
		public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID) => default; // 0x000000018079D060-0x000000018079D1B0
		public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index) => default; // 0x000000018079B650-0x000000018079B6B0
		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote) => default; // 0x000000018079CC20-0x000000018079CD80
		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal) {
			punBytesProcessed = default;
			punBytesTotal = default;
			return default;
		} // 0x000000018079A6B0-0x000000018079A730
		public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp) => default; // 0x000000018079C8E0-0x000000018079C990
		public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID) => default; // 0x000000018079B1D0-0x000000018079B270
		public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) => default; // 0x00000001807998D0-0x0000000180799970
		public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) => default; // 0x000000018079B470-0x000000018079B510
		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID) => default; // 0x000000018079CD80-0x000000018079CE20
		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID) => default; // 0x000000018079CE70-0x000000018079CF10
		public static uint GetNumSubscribedItems() => default; // 0x000000018079A730-0x000000018079A780
		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) => default; // 0x000000018079B170-0x000000018079B1D0
		public static uint GetItemState(PublishedFileId_t nPublishedFileID) => default; // 0x000000018079A660-0x000000018079A6B0
		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp) {
			punSizeOnDisk = default;
			pchFolder = default;
			punTimeStamp = default;
			return default;
		} // 0x000000018079A530-0x000000018079A660
		public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal) {
			punBytesDownloaded = default;
			punBytesTotal = default;
			return default;
		} // 0x000000018079A4B0-0x000000018079A530
		public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority) => default; // 0x000000018079A3B0-0x000000018079A410
		public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder) => default; // 0x0000000180799D30-0x0000000180799E70
		public static void SuspendDownloads(bool bSuspend) {} // 0x000000018079CE20-0x000000018079CE70
		public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) => default; // 0x000000018079CA30-0x000000018079CAE0
		public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) => default; // 0x000000018079CB70-0x000000018079CC20
		public static SteamAPICall_t StopPlaytimeTrackingForAllItems() => default; // 0x000000018079CAE0-0x000000018079CB70
		public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) => default; // 0x0000000180799290-0x0000000180799340
		public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) => default; // 0x000000018079B3C0-0x000000018079B470
		public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) => default; // 0x00000001807991E0-0x0000000180799290
		public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) => default; // 0x000000018079B310-0x000000018079B3C0
		public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID) => default; // 0x000000018079A410-0x000000018079A4B0
		public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID) => default; // 0x000000018079A310-0x000000018079A3B0
	}
}
