/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamController // TypeDefIndex: 6462
	{
		// Methods
		public static bool Init() => default; // 0x000000018094D740-0x000000018094D790
		public static bool Shutdown() => default; // 0x000000018094D8D0-0x000000018094D920
		public static void RunFrame() {} // 0x000000018094D790-0x000000018094D7E0
		public static int GetConnectedControllers(ControllerHandle_t[] handlesOut) => default; // 0x000000018094D030-0x000000018094D0E0
		public static ControllerActionSetHandle_t GetActionSetHandle(string pszActionSetName) => default; // 0x000000018094CB80-0x000000018094CCC0
		public static void ActivateActionSet(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle) {} // 0x000000018094CA10-0x000000018094CA70
		public static ControllerActionSetHandle_t GetCurrentActionSet(ControllerHandle_t controllerHandle) => default; // 0x000000018094D1C0-0x000000018094D220
		public static void ActivateActionSetLayer(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle) {} // 0x000000018094C9B0-0x000000018094CA10
		public static void DeactivateActionSetLayer(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle) {} // 0x000000018094CA70-0x000000018094CAD0
		public static void DeactivateAllActionSetLayers(ControllerHandle_t controllerHandle) {} // 0x000000018094CAD0-0x000000018094CB20
		public static int GetActiveActionSetLayers(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t[] handlesOut) => default; // 0x000000018094CCC0-0x000000018094CD80
		public static ControllerDigitalActionHandle_t GetDigitalActionHandle(string pszActionName) => default; // 0x000000018094D280-0x000000018094D3C0
		public static InputDigitalActionData_t GetDigitalActionData(ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle) => default; // 0x000000018094D220-0x000000018094D280
		public static int GetDigitalActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, EControllerActionOrigin[] originsOut) => default; // 0x000000018094D3C0-0x000000018094D4A0
		public static ControllerAnalogActionHandle_t GetAnalogActionHandle(string pszActionName) => default; // 0x000000018094CE10-0x000000018094CF50
		public static InputAnalogActionData_t GetAnalogActionData(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle) => default; // 0x000000018094CD80-0x000000018094CE10
		public static int GetAnalogActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, EControllerActionOrigin[] originsOut) => default; // 0x000000018094CF50-0x000000018094D030
		public static string GetGlyphForActionOrigin(EControllerActionOrigin eOrigin) => default; // 0x000000018094D4F0-0x000000018094D550
		public static string GetStringForActionOrigin(EControllerActionOrigin eOrigin) => default; // 0x000000018094D680-0x000000018094D6E0
		public static void StopAnalogActionMomentum(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction) {} // 0x000000018094D920-0x000000018094D980
		public static InputMotionData_t GetMotionData(ControllerHandle_t controllerHandle) => default; // 0x000000018094D600-0x000000018094D680
		public static void TriggerHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec) {} // 0x000000018094D9E0-0x000000018094DA60
		public static void TriggerRepeatedHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags) {} // 0x000000018094DA60-0x000000018094DB00
		public static void TriggerVibration(ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed) {} // 0x000000018094DB00-0x000000018094DB80
		public static void SetLEDColor(ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags) {} // 0x000000018094D7E0-0x000000018094D880
		public static bool ShowBindingPanel(ControllerHandle_t controllerHandle) => default; // 0x000000018094D880-0x000000018094D8D0
		public static ESteamInputType GetInputTypeForHandle(ControllerHandle_t controllerHandle) => default; // 0x000000018094D5B0-0x000000018094D600
		public static ControllerHandle_t GetControllerForGamepadIndex(int nIndex) => default; // 0x000000018094D160-0x000000018094D1C0
		public static int GetGamepadIndexForController(ControllerHandle_t ulControllerHandle) => default; // 0x000000018094D4A0-0x000000018094D4F0
		public static string GetStringForXboxOrigin(EXboxOrigin eOrigin) => default; // 0x000000018094D6E0-0x000000018094D740
		public static string GetGlyphForXboxOrigin(EXboxOrigin eOrigin) => default; // 0x000000018094D550-0x000000018094D5B0
		public static EControllerActionOrigin GetActionOriginFromXboxOrigin(ControllerHandle_t controllerHandle, EXboxOrigin eOrigin) => default; // 0x000000018094CB20-0x000000018094CB80
		public static EControllerActionOrigin TranslateActionOrigin(ESteamInputType eDestinationInputType, EControllerActionOrigin eSourceOrigin) => default; // 0x000000018094D980-0x000000018094D9E0
		public static bool GetControllerBindingRevision(ControllerHandle_t controllerHandle, out int pMajor, out int pMinor) {
			pMajor = default;
			pMinor = default;
			return default;
		} // 0x000000018094D0E0-0x000000018094D160
	}
}
