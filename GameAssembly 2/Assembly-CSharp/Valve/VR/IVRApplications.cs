/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public struct IVRApplications // TypeDefIndex: 7967
	{
		// Fields
		internal _AddApplicationManifest AddApplicationManifest; // 0x00
		internal _RemoveApplicationManifest RemoveApplicationManifest; // 0x08
		internal _IsApplicationInstalled IsApplicationInstalled; // 0x10
		internal _GetApplicationCount GetApplicationCount; // 0x18
		internal _GetApplicationKeyByIndex GetApplicationKeyByIndex; // 0x20
		internal _GetApplicationKeyByProcessId GetApplicationKeyByProcessId; // 0x28
		internal _LaunchApplication LaunchApplication; // 0x30
		internal _LaunchTemplateApplication LaunchTemplateApplication; // 0x38
		internal _LaunchApplicationFromMimeType LaunchApplicationFromMimeType; // 0x40
		internal _LaunchDashboardOverlay LaunchDashboardOverlay; // 0x48
		internal _CancelApplicationLaunch CancelApplicationLaunch; // 0x50
		internal _IdentifyApplication IdentifyApplication; // 0x58
		internal _GetApplicationProcessId GetApplicationProcessId; // 0x60
		internal _GetApplicationsErrorNameFromEnum GetApplicationsErrorNameFromEnum; // 0x68
		internal _GetApplicationPropertyString GetApplicationPropertyString; // 0x70
		internal _GetApplicationPropertyBool GetApplicationPropertyBool; // 0x78
		internal _GetApplicationPropertyUint64 GetApplicationPropertyUint64; // 0x80
		internal _SetApplicationAutoLaunch SetApplicationAutoLaunch; // 0x88
		internal _GetApplicationAutoLaunch GetApplicationAutoLaunch; // 0x90
		internal _SetDefaultApplicationForMimeType SetDefaultApplicationForMimeType; // 0x98
		internal _GetDefaultApplicationForMimeType GetDefaultApplicationForMimeType; // 0xA0
		internal _GetApplicationSupportedMimeTypes GetApplicationSupportedMimeTypes; // 0xA8
		internal _GetApplicationsThatSupportMimeType GetApplicationsThatSupportMimeType; // 0xB0
		internal _GetApplicationLaunchArguments GetApplicationLaunchArguments; // 0xB8
		internal _GetStartingApplication GetStartingApplication; // 0xC0
		internal _GetTransitionState GetTransitionState; // 0xC8
		internal _PerformApplicationPrelaunchCheck PerformApplicationPrelaunchCheck; // 0xD0
		internal _GetApplicationsTransitionStateNameFromEnum GetApplicationsTransitionStateNameFromEnum; // 0xD8
		internal _IsQuitUserPromptRequested IsQuitUserPromptRequested; // 0xE0
		internal _LaunchInternalProcess LaunchInternalProcess; // 0xE8
		internal _GetCurrentSceneProcessId GetCurrentSceneProcessId; // 0xF0
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRApplicationError _AddApplicationManifest(string pchApplicationManifestFullPath, bool bTemporary); // TypeDefIndex: 7968; 0x00000001811E7E60-0x00000001811E8170
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRApplicationError _RemoveApplicationManifest(string pchApplicationManifestFullPath); // TypeDefIndex: 7969; 0x00000001811ED7B0-0x00000001811EDA30
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _IsApplicationInstalled(string pchAppKey); // TypeDefIndex: 7970; 0x00000001811E8310-0x00000001811E8590
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetApplicationCount(); // TypeDefIndex: 7971; 0x00000001811E8610-0x00000001811E87B0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRApplicationError _GetApplicationKeyByIndex(uint unApplicationIndex, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen); // TypeDefIndex: 7972; 0x00000001811E8850-0x00000001811E8BC0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRApplicationError _GetApplicationKeyByProcessId(uint unProcessId, string pchAppKeyBuffer, uint unAppKeyBufferLen); // TypeDefIndex: 7973; 0x00000001811E8850-0x00000001811E8BC0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRApplicationError _LaunchApplication(string pchAppKey); // TypeDefIndex: 7974; 0x00000001811ED7B0-0x00000001811EDA30
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRApplicationError _LaunchTemplateApplication(string pchTemplateAppKey, string pchNewAppKey, [In, Out] AppOverrideKeys_t[] pKeys, uint unKeys); // TypeDefIndex: 7975; 0x00000001811EDF30-0x00000001811EE480
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRApplicationError _LaunchApplicationFromMimeType(string pchMimeType, string pchArgs); // TypeDefIndex: 7976; 0x00000001811ED4D0-0x00000001811ED7B0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRApplicationError _LaunchDashboardOverlay(string pchAppKey); // TypeDefIndex: 7977; 0x00000001811ED7B0-0x00000001811EDA30
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _CancelApplicationLaunch(string pchAppKey); // TypeDefIndex: 7978; 0x00000001811E8310-0x00000001811E8590
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRApplicationError _IdentifyApplication(uint unProcessId, string pchAppKey); // TypeDefIndex: 7979; 0x00000001811ED1B0-0x00000001811ED4D0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetApplicationProcessId(string pchAppKey); // TypeDefIndex: 7980; 0x00000001811E8D00-0x00000001811E9090
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate IntPtr _GetApplicationsErrorNameFromEnum(EVRApplicationError error); // TypeDefIndex: 7981; 0x00000001811EA830-0x00000001811EAA00
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError); // TypeDefIndex: 7982; 0x00000001811E97D0-0x00000001811E9DF0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError); // TypeDefIndex: 7983; 0x00000001811E9130-0x00000001811E96C0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate ulong _GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError); // TypeDefIndex: 7984; 0x00000001811E9E90-0x00000001811EA420
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRApplicationError _SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch); // TypeDefIndex: 7985; 0x00000001811E7E60-0x00000001811E8170
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetApplicationAutoLaunch(string pchAppKey); // TypeDefIndex: 7986; 0x00000001811E8310-0x00000001811E8590
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRApplicationError _SetDefaultApplicationForMimeType(string pchAppKey, string pchMimeType); // TypeDefIndex: 7987; 0x00000001811ED4D0-0x00000001811ED7B0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetDefaultApplicationForMimeType(string pchMimeType, string pchAppKeyBuffer, uint unAppKeyBufferLen); // TypeDefIndex: 7988; 0x00000001811EA4B0-0x00000001811EA7B0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetApplicationSupportedMimeTypes(string pchAppKey, string pchMimeTypesBuffer, uint unMimeTypesBuffer); // TypeDefIndex: 7989; 0x00000001811EA4B0-0x00000001811EA7B0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetApplicationsThatSupportMimeType(string pchMimeType, string pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer); // TypeDefIndex: 7990; 0x00000001811EAA90-0x00000001811EAFB0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetApplicationLaunchArguments(uint unHandle, string pchArgs, uint unArgs); // TypeDefIndex: 7991; 0x00000001811E8850-0x00000001811E8BC0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRApplicationError _GetStartingApplication(string pchAppKeyBuffer, uint unAppKeyBufferLen); // TypeDefIndex: 7992; 0x00000001811ECBE0-0x00000001811ED120
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRApplicationTransitionState _GetTransitionState(); // TypeDefIndex: 7993; 0x00000001811E8610-0x00000001811E87B0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRApplicationError _PerformApplicationPrelaunchCheck(string pchAppKey); // TypeDefIndex: 7994; 0x00000001811ED7B0-0x00000001811EDA30
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate IntPtr _GetApplicationsTransitionStateNameFromEnum(EVRApplicationTransitionState state); // TypeDefIndex: 7995; 0x00000001811EA830-0x00000001811EAA00
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _IsQuitUserPromptRequested(); // TypeDefIndex: 7996; 0x00000001811E8170-0x00000001811E8310
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRApplicationError _LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory); // TypeDefIndex: 7997; 0x00000001811EDA70-0x00000001811EDE90
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetCurrentSceneProcessId(); // TypeDefIndex: 7998; 0x00000001811E8610-0x00000001811E87B0
	}
}
