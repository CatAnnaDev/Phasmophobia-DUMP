/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamParties // TypeDefIndex: 6482
	{
		// Methods
		public static uint GetNumActiveBeacons() => default; // 0x00000001807AB1B0-0x00000001807AB200
		public static PartyBeaconID_t GetBeaconByIndex(uint unIndex) => default; // 0x00000001807AAEA0-0x00000001807AAF40
		public static bool GetBeaconDetails(PartyBeaconID_t ulBeaconID, out CSteamID pSteamIDBeaconOwner, out SteamPartyBeaconLocation_t pLocation, out string pchMetadata, int cchMetadata) {
			pSteamIDBeaconOwner = default;
			pLocation = default;
			pchMetadata = default;
			return default;
		} // 0x00000001807AAF40-0x00000001807AB080
		public static SteamAPICall_t JoinParty(PartyBeaconID_t ulBeaconID) => default; // 0x00000001807AB250-0x00000001807AB2F0
		public static bool GetNumAvailableBeaconLocations(out uint puNumLocations) {
			puNumLocations = default;
			return default;
		} // 0x00000001807AB200-0x00000001807AB250
		public static bool GetAvailableBeaconLocations(SteamPartyBeaconLocation_t[] pLocationList, uint uMaxNumLocations) => default; // 0x00000001807AAE40-0x00000001807AAEA0
		public static SteamAPICall_t CreateBeacon(uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, string pchConnectString, string pchMetadata) => default; // 0x00000001807AABF0-0x00000001807AADF0
		public static void OnReservationCompleted(PartyBeaconID_t ulBeacon, CSteamID steamIDUser) {} // 0x00000001807AB2F0-0x00000001807AB350
		public static void CancelReservation(PartyBeaconID_t ulBeacon, CSteamID steamIDUser) {} // 0x00000001807AAAE0-0x00000001807AAB40
		public static SteamAPICall_t ChangeNumOpenSlots(PartyBeaconID_t ulBeacon, uint unOpenSlots) => default; // 0x00000001807AAB40-0x00000001807AABF0
		public static bool DestroyBeacon(PartyBeaconID_t ulBeacon) => default; // 0x00000001807AADF0-0x00000001807AAE40
		public static bool GetBeaconLocationData(SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, out string pchDataStringOut, int cchDataStringOut) {
			pchDataStringOut = default;
			return default;
		} // 0x00000001807AB080-0x00000001807AB1B0
	}
}
