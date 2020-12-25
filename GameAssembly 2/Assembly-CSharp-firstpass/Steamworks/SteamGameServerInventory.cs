/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamGameServerInventory // TypeDefIndex: 6468
	{
		// Methods
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle) => default; // 0x0000000180956250-0x00000001809562A0
		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) => default; // 0x0000000180956180-0x0000000180956250
		public static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) {
			pchValueBuffer = default;
			return default;
		} // 0x0000000180955FA0-0x0000000180956180
		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle) => default; // 0x00000001809562A0-0x00000001809562F0
		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected) => default; // 0x0000000180955630-0x0000000180955690
		public static void DestroyResult(SteamInventoryResult_t resultHandle) {} // 0x00000001809557A0-0x00000001809557F0
		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle) {
			pResultHandle = default;
			return default;
		} // 0x0000000180955930-0x0000000180955980
		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs) {
			pResultHandle = default;
			return default;
		} // 0x0000000180955D60-0x0000000180955DE0
		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize) {
			punOutBufferSize = default;
			return default;
		} // 0x0000000180956650-0x00000001809566D0
		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false /* Metadata: 0x00652CA6 */) {
			pOutResultHandle = default;
			return default;
		} // 0x0000000180955710-0x00000001809557A0
		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength) {
			pResultHandle = default;
			return default;
		} // 0x00000001809558A0-0x0000000180955930
		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle) {
			pResultHandle = default;
			return default;
		} // 0x00000001809562F0-0x0000000180956340
		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef) {
			pResultHandle = default;
			return default;
		} // 0x0000000180955550-0x00000001809555B0
		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength) {
			pResultHandle = default;
			return default;
		} // 0x00000001809555B0-0x0000000180955630
		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity) {
			pResultHandle = default;
			return default;
		} // 0x0000000180955690-0x0000000180955710
		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength) {
			pResultHandle = default;
			return default;
		} // 0x00000001809557F0-0x00000001809558A0
		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest) {
			pResultHandle = default;
			return default;
		} // 0x0000000180956F30-0x0000000180956FC0
		public static void SendItemDropHeartbeat() {} // 0x0000000180956600-0x0000000180956650
		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition) {
			pResultHandle = default;
			return default;
		} // 0x0000000180956FC0-0x0000000180957020
		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength) {
			pResultHandle = default;
			return default;
		} // 0x0000000180956E70-0x0000000180956F30
		public static bool LoadItemDefinitions() => default; // 0x0000000180956340-0x0000000180956390
		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) => default; // 0x0000000180955A50-0x0000000180955B10
		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) {
			pchValueBuffer = default;
			return default;
		} // 0x0000000180955B10-0x0000000180955CE0
		public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID) => default; // 0x00000001809564E0-0x0000000180956570
		public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) => default; // 0x0000000180955980-0x0000000180955A50
		public static SteamAPICall_t StartPurchase(SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength) => default; // 0x0000000180956CC0-0x0000000180956D80
		public static SteamAPICall_t RequestPrices() => default; // 0x0000000180956570-0x0000000180956600
		public static uint GetNumItemsWithPrices() => default; // 0x0000000180955F50-0x0000000180955FA0
		public static bool GetItemsWithPrices(SteamItemDef_t[] pArrayItemDefs, ulong[] pCurrentPrices, ulong[] pBasePrices, uint unArrayLength) => default; // 0x0000000180955DE0-0x0000000180955F50
		public static bool GetItemPrice(SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice) {
			pCurrentPrice = default;
			pBasePrice = default;
			return default;
		} // 0x0000000180955CE0-0x0000000180955D60
		public static SteamInventoryUpdateHandle_t StartUpdateProperties() => default; // 0x0000000180956D80-0x0000000180956E10
		public static bool RemoveProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName) => default; // 0x0000000180956390-0x00000001809564E0
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, string pchPropertyValue) => default; // 0x00000001809566D0-0x00000001809568A0
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, bool bValue) => default; // 0x0000000180956B60-0x0000000180956CC0
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, long nValue) => default; // 0x00000001809568A0-0x0000000180956A00
		public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, float flValue) => default; // 0x0000000180956A00-0x0000000180956B60
		public static bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle) {
			pResultHandle = default;
			return default;
		} // 0x0000000180956E10-0x0000000180956E70
	}
}
