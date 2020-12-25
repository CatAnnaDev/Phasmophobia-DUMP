/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamInput // TypeDefIndex: 6477
	{
		// Methods
		public static bool Init() => default; // 0x00000001807A1EA0-0x00000001807A1EF0
		public static bool Shutdown() => default; // 0x00000001807A2030-0x00000001807A2080
		public static void RunFrame() {} // 0x00000001807A1EF0-0x00000001807A1F40
		public static int GetConnectedControllers(InputHandle_t[] handlesOut) => default; // 0x00000001807A1740-0x00000001807A17F0
		public static InputActionSetHandle_t GetActionSetHandle(string pszActionSetName) => default; // 0x00000001807A1290-0x00000001807A13D0
		public static void ActivateActionSet(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle) {} // 0x00000001807A1120-0x00000001807A1180
		public static InputActionSetHandle_t GetCurrentActionSet(InputHandle_t inputHandle) => default; // 0x00000001807A1850-0x00000001807A18B0
		public static void ActivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle) {} // 0x00000001807A10C0-0x00000001807A1120
		public static void DeactivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle) {} // 0x00000001807A1180-0x00000001807A11E0
		public static void DeactivateAllActionSetLayers(InputHandle_t inputHandle) {} // 0x00000001807A11E0-0x00000001807A1230
		public static int GetActiveActionSetLayers(InputHandle_t inputHandle, InputActionSetHandle_t[] handlesOut) => default; // 0x00000001807A13D0-0x00000001807A1490
		public static InputDigitalActionHandle_t GetDigitalActionHandle(string pszActionName) => default; // 0x00000001807A1990-0x00000001807A1AD0
		public static InputDigitalActionData_t GetDigitalActionData(InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle) => default; // 0x00000001807A1930-0x00000001807A1990
		public static int GetDigitalActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, EInputActionOrigin[] originsOut) => default; // 0x00000001807A1AD0-0x00000001807A1BB0
		public static InputAnalogActionHandle_t GetAnalogActionHandle(string pszActionName) => default; // 0x00000001807A1520-0x00000001807A1660
		public static InputAnalogActionData_t GetAnalogActionData(InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle) => default; // 0x00000001807A1490-0x00000001807A1520
		public static int GetAnalogActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, EInputActionOrigin[] originsOut) => default; // 0x00000001807A1660-0x00000001807A1740
		public static string GetGlyphForActionOrigin(EInputActionOrigin eOrigin) => default; // 0x00000001807A1C00-0x00000001807A1C60
		public static string GetStringForActionOrigin(EInputActionOrigin eOrigin) => default; // 0x00000001807A1DE0-0x00000001807A1E40
		public static void StopAnalogActionMomentum(InputHandle_t inputHandle, InputAnalogActionHandle_t eAction) {} // 0x00000001807A2080-0x00000001807A20E0
		public static InputMotionData_t GetMotionData(InputHandle_t inputHandle) => default; // 0x00000001807A1D10-0x00000001807A1D90
		public static void TriggerVibration(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed) {} // 0x00000001807A2260-0x00000001807A22E0
		public static void SetLEDColor(InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags) {} // 0x00000001807A1F40-0x00000001807A1FE0
		public static void TriggerHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec) {} // 0x00000001807A2140-0x00000001807A21C0
		public static void TriggerRepeatedHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags) {} // 0x00000001807A21C0-0x00000001807A2260
		public static bool ShowBindingPanel(InputHandle_t inputHandle) => default; // 0x00000001807A1FE0-0x00000001807A2030
		public static ESteamInputType GetInputTypeForHandle(InputHandle_t inputHandle) => default; // 0x00000001807A1CC0-0x00000001807A1D10
		public static InputHandle_t GetControllerForGamepadIndex(int nIndex) => default; // 0x00000001807A17F0-0x00000001807A1850
		public static int GetGamepadIndexForController(InputHandle_t ulinputHandle) => default; // 0x00000001807A1BB0-0x00000001807A1C00
		public static string GetStringForXboxOrigin(EXboxOrigin eOrigin) => default; // 0x00000001807A1E40-0x00000001807A1EA0
		public static string GetGlyphForXboxOrigin(EXboxOrigin eOrigin) => default; // 0x00000001807A1C60-0x00000001807A1CC0
		public static EInputActionOrigin GetActionOriginFromXboxOrigin(InputHandle_t inputHandle, EXboxOrigin eOrigin) => default; // 0x00000001807A1230-0x00000001807A1290
		public static EInputActionOrigin TranslateActionOrigin(ESteamInputType eDestinationInputType, EInputActionOrigin eSourceOrigin) => default; // 0x00000001807A20E0-0x00000001807A2140
		public static bool GetDeviceBindingRevision(InputHandle_t inputHandle, out int pMajor, out int pMinor) {
			pMajor = default;
			pMinor = default;
			return default;
		} // 0x00000001807A18B0-0x00000001807A1930
		public static uint GetRemotePlaySessionID(InputHandle_t inputHandle) => default; // 0x00000001807A1D90-0x00000001807A1DE0
	}
}
