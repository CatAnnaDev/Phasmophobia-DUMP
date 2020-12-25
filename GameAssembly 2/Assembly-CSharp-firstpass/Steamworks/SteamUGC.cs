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
	public static class SteamUGC // TypeDefIndex: 6492
	{
		// Methods
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) => default; // 0x00000001808385B0-0x00000001808386A0
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) => default; // 0x0000000180838440-0x0000000180838510
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, string pchCursor = null) => default; // 0x00000001808382C0-0x0000000180838440
		public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) => default; // 0x0000000180838510-0x00000001808385B0
		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle) => default; // 0x0000000180839AF0-0x0000000180839B90
		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails) {
			pDetails = default;
			return default;
		} // 0x00000001808393F0-0x0000000180839470
		public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize) {
			pchURL = default;
			return default;
		} // 0x00000001808392D0-0x00000001808393F0
		public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize) {
			pchMetadata = default;
			return default;
		} // 0x00000001808390F0-0x0000000180839210
		public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) => default; // 0x0000000180838CD0-0x0000000180838D60
		public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue) {
			pStatValue = default;
			return default;
		} // 0x0000000180839470-0x0000000180839500
		public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index) => default; // 0x0000000180839210-0x0000000180839270
		public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType) {
			pchURLOrVideoID = default;
			pchOriginalFileName = default;
			pPreviewType = default;
			return default;
		} // 0x0000000180838B10-0x0000000180838CD0
		public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index) => default; // 0x0000000180839270-0x00000001808392D0
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize) {
			pchKey = default;
			pchValue = default;
			return default;
		} // 0x0000000180838F40-0x00000001808390F0
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue, uint cchValueSize) {
			pchValue = default;
			return default;
		} // 0x0000000180838D60-0x0000000180838F40
		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle) => default; // 0x0000000180839600-0x0000000180839650
		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName) => default; // 0x0000000180837FA0-0x00000001808380E0
		public static bool AddRequiredTagGroup(UGCQueryHandle_t handle, IList<string> pTagGroups) => default; // 0x0000000180837EE0-0x0000000180837FA0
		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName) => default; // 0x00000001808376F0-0x0000000180837830
		public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs) => default; // 0x000000018083AA10-0x000000018083AA70
		public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags) => default; // 0x000000018083A8F0-0x000000018083A950
		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription) => default; // 0x000000018083A950-0x000000018083A9B0
		public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata) => default; // 0x000000018083A9B0-0x000000018083AA10
		public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren) => default; // 0x000000018083A890-0x000000018083A8F0
		public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) => default; // 0x000000018083A830-0x000000018083A890
		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly) => default; // 0x000000018083AAD0-0x000000018083AB30
		public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays) => default; // 0x000000018083AA70-0x000000018083AAD0
		public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage) => default; // 0x000000018083A630-0x000000018083A770
		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds) => default; // 0x0000000180839B90-0x0000000180839BF0
		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName) => default; // 0x0000000180839C50-0x0000000180839D90
		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag) => default; // 0x000000018083A770-0x000000018083A7D0
		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText) => default; // 0x000000018083AB30-0x000000018083AC70
		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays) => default; // 0x000000018083A7D0-0x000000018083A830
		public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue) => default; // 0x0000000180837D20-0x0000000180837EE0
		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds) => default; // 0x0000000180839A40-0x0000000180839AF0
		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType) => default; // 0x0000000180838220-0x00000001808382C0
		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID) => default; // 0x000000018083AD20-0x000000018083ADC0
		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle) => default; // 0x000000018083A350-0x000000018083A490
		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription) => default; // 0x0000000180839ED0-0x000000018083A010
		public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage) => default; // 0x000000018083A490-0x000000018083A5D0
		public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData) => default; // 0x000000018083A010-0x000000018083A150
		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility) => default; // 0x000000018083A5D0-0x000000018083A630
		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags) => default; // 0x000000018083A290-0x000000018083A350
		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder) => default; // 0x0000000180839D90-0x0000000180839ED0
		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile) => default; // 0x000000018083A150-0x000000018083A290
		public static bool SetAllowLegacyUpload(UGCUpdateHandle_t handle, bool bAllowLegacyUpload) => default; // 0x0000000180839BF0-0x0000000180839C50
		public static bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle) => default; // 0x0000000180839650-0x00000001808396A0
		public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey) => default; // 0x00000001808398A0-0x00000001808399E0
		public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue) => default; // 0x0000000180837830-0x00000001808379F0
		public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type) => default; // 0x00000001808379F0-0x0000000180837B40
		public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID) => default; // 0x0000000180837B40-0x0000000180837C80
		public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile) => default; // 0x000000018083B2A0-0x000000018083B3F0
		public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID) => default; // 0x000000018083B3F0-0x000000018083B540
		public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index) => default; // 0x00000001808399E0-0x0000000180839A40
		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote) => default; // 0x000000018083AFB0-0x000000018083B110
		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal) {
			punBytesProcessed = default;
			punBytesTotal = default;
			return default;
		} // 0x0000000180838A40-0x0000000180838AC0
		public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp) => default; // 0x000000018083AC70-0x000000018083AD20
		public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID) => default; // 0x0000000180839560-0x0000000180839600
		public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) => default; // 0x0000000180837C80-0x0000000180837D20
		public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) => default; // 0x0000000180839800-0x00000001808398A0
		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID) => default; // 0x000000018083B110-0x000000018083B1B0
		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID) => default; // 0x000000018083B200-0x000000018083B2A0
		public static uint GetNumSubscribedItems() => default; // 0x0000000180838AC0-0x0000000180838B10
		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) => default; // 0x0000000180839500-0x0000000180839560
		public static uint GetItemState(PublishedFileId_t nPublishedFileID) => default; // 0x00000001808389F0-0x0000000180838A40
		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp) {
			punSizeOnDisk = default;
			pchFolder = default;
			punTimeStamp = default;
			return default;
		} // 0x00000001808388C0-0x00000001808389F0
		public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal) {
			punBytesDownloaded = default;
			punBytesTotal = default;
			return default;
		} // 0x0000000180838840-0x00000001808388C0
		public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority) => default; // 0x0000000180838740-0x00000001808387A0
		public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder) => default; // 0x00000001808380E0-0x0000000180838220
		public static void SuspendDownloads(bool bSuspend) {} // 0x000000018083B1B0-0x000000018083B200
		public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) => default; // 0x000000018083ADC0-0x000000018083AE70
		public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) => default; // 0x000000018083AF00-0x000000018083AFB0
		public static SteamAPICall_t StopPlaytimeTrackingForAllItems() => default; // 0x000000018083AE70-0x000000018083AF00
		public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) => default; // 0x0000000180837640-0x00000001808376F0
		public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) => default; // 0x0000000180839750-0x0000000180839800
		public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) => default; // 0x0000000180837590-0x0000000180837640
		public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) => default; // 0x00000001808396A0-0x0000000180839750
		public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID) => default; // 0x00000001808387A0-0x0000000180838840
		public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID) => default; // 0x00000001808386A0-0x0000000180838740
	}
}
