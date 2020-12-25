/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamInventory // TypeDefIndex: 6478
	{
		// Methods
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle) => default; // 0x00000001807A3140-0x00000001807A3190
		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) => default; // 0x00000001807A3070-0x00000001807A3140
		public static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) {
			pchValueBuffer = default;
			return default;
		} // 0x00000001807A2E80-0x00000001807A3070
		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle) => default; // 0x00000001807A3190-0x00000001807A31E0
		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected) => default; // 0x00000001807A2500-0x00000001807A2560
		public static void DestroyResult(SteamInventoryResult_t resultHandle) {} // 0x00000001807A2670-0x00000001807A26C0
		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle) {
			pResultHandle = default;
			return default;
		} // 0x00000001807A2800-0x00000001807A2850
		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs) {
			pResultHandle = default;
			return default;
		} // 0x00000001807A2C40-0x00000001807A2CC0
		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize) {
			punOutBufferSize = default;
			return default;
		} // 0x00000001807A3550-0x00000001807A35D0
		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false /* Metadata: 0x00652CBF */) {
			pOutResultHandle = default;
			return default;
		} // 0x00000001807A25E0-0x00000001807A2670
		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength) {
			pResultHandle = default;
			return default;
		} // 0x00000001807A2770-0x00000001807A2800
		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle) {
			pResultHandle = default;
			return default;
		} // 0x00000001807A31E0-0x00000001807A3230
		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef) {
			pResultHandle = default;
			return default;
		} // 0x00000001807A2420-0x00000001807A2480
		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength) {
			pResultHandle = default;
			return default;
		} // 0x00000001807A2480-0x00000001807A2500
		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity) {
			pResultHandle = default;
			return default;
		} // 0x00000001807A2560-0x00000001807A25E0
		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength) {
			pResultHandle = default;
			return default;
		} // 0x00000001807A26C0-0x00000001807A2770
		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest) {
			pResultHandle = default;
			return default;
		} // 0x00000001807A3E40-0x00000001807A3ED0
		public static void SendItemDropHeartbeat() {} // 0x00000001807A3500-0x00000001807A3550
		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition) {
			pResultHandle = default;
			return default;
		} // 0x00000001807A3ED0-0x00000001807A4060
		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength) {
			pResultHandle = default;
			return default;
		} // 0x00000001807A3D80-0x00000001807A3E40
		public static bool LoadItemDefinitions() => default; // 0x00000001807A3230-0x00000001807A3280
		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) => default; // 0x00000001807A2930-0x00000001807A29F0
		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) {
			pchValueBuffer = default;
			return default;
		} // 0x00000001807A29F0-0x00000001807A2BC0
		public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID) => default; // 0x00000001807A33D0-0x00000001807A3470
		public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) => default; // 0x00000001807A2850-0x00000001807A2930
		public static SteamAPICall_t StartPurchase(SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength) => default; // 0x00000001807A3BD0-0x00000001807A3C90
		public static SteamAPICall_t RequestPrices() => default; // 0x00000001807A3470-0x00000001807A3500
		public static uint GetNumItemsWithPrices() => default; // 0x00000001807A2E30-0x00000001807A2E80
		public static bool GetItemsWithPrices(SteamItemDef_t[] pArrayItemDefs, ulong[] pCurrentPrices, ulong[] pBasePrices, uint unArrayLength) => default; // 0x00000001807A2CC0-0x00000001807A2E30
		public static bool GetItemPrice(SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice) {
			pCurrentPrice = default;
			pBasePrice = default;
			return default;
		} // 0x00000001807A2BC0-0x00000001807A2C40
		public static SteamInventoryUpdateHandle_t StartUpdateProperties() => default; // 0x00000001807A3C90-0x00000001807A3D20
		public static bool RemoveProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName) => default; // 0x00000001807A3280-0x00000001807A33D0
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, string pchPropertyValue) => default; // 0x00000001807A3730-0x00000001807A3900
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, bool bValue) => default; // 0x00000001807A35D0-0x00000001807A3730
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, long nValue) => default; // 0x00000001807A3900-0x00000001807A3A60
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, float flValue) => default; // 0x00000001807A3A60-0x00000001807A3BD0
		public static bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle) {
			pResultHandle = default;
			return default;
		} // 0x00000001807A3D20-0x00000001807A3D80
	}
}
