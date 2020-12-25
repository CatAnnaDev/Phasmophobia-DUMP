/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public class CVRApplications // TypeDefIndex: 8210
	{
		// Fields
		private IVRApplications FnTable; // 0x10
	
		// Constructors
		public CVRApplications() {} // Dummy constructor
		internal CVRApplications(IntPtr pInterface) {} // 0x00000001811DC950-0x00000001811DCAD0
	
		// Methods
		public EVRApplicationError AddApplicationManifest(string pchApplicationManifestFullPath, bool bTemporary) => default; // 0x00000001811DC370-0x00000001811DC390
		public EVRApplicationError RemoveApplicationManifest(string pchApplicationManifestFullPath) => default; // 0x00000001811DC8D0-0x00000001811DC8F0
		public bool IsApplicationInstalled(string pchAppKey) => default; // 0x00000001811DC780-0x00000001811DC7A0
		public uint GetApplicationCount() => default; // 0x00000001811DC3E0-0x00000001811DC400
		public EVRApplicationError GetApplicationKeyByIndex(uint unApplicationIndex, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen) => default; // 0x00000001811DC400-0x00000001811DC430
		public EVRApplicationError GetApplicationKeyByProcessId(uint unProcessId, string pchAppKeyBuffer, uint unAppKeyBufferLen) => default; // 0x00000001811DC430-0x00000001811DC460
		public EVRApplicationError LaunchApplication(string pchAppKey) => default; // 0x00000001811DC7F0-0x00000001811DC810
		public EVRApplicationError LaunchTemplateApplication(string pchTemplateAppKey, string pchNewAppKey, AppOverrideKeys_t[] pKeys) => default; // 0x00000001811DC860-0x00000001811DC8A0
		public EVRApplicationError LaunchApplicationFromMimeType(string pchMimeType, string pchArgs) => default; // 0x00000001811DC7D0-0x00000001811DC7F0
		public EVRApplicationError LaunchDashboardOverlay(string pchAppKey) => default; // 0x00000001811DC810-0x00000001811DC830
		public bool CancelApplicationLaunch(string pchAppKey) => default; // 0x00000001811DC390-0x00000001811DC3B0
		public EVRApplicationError IdentifyApplication(uint unProcessId, string pchAppKey) => default; // 0x00000001811DC760-0x00000001811DC780
		public uint GetApplicationProcessId(string pchAppKey) => default; // 0x00000001811DC490-0x00000001811DC4B0
		public string GetApplicationsErrorNameFromEnum(EVRApplicationError error) => default; // 0x00000001811DC570-0x00000001811DC5F0
		public uint GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError) => default; // 0x00000001811DC4E0-0x00000001811DC510
		public bool GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError) => default; // 0x00000001811DC4B0-0x00000001811DC4E0
		public ulong GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError) => default; // 0x00000001811DC510-0x00000001811DC540
		public EVRApplicationError SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch) => default; // 0x00000001811DC8F0-0x00000001811DC920
		public bool GetApplicationAutoLaunch(string pchAppKey) => default; // 0x00000001811DC3B0-0x00000001811DC3E0
		public EVRApplicationError SetDefaultApplicationForMimeType(string pchAppKey, string pchMimeType) => default; // 0x00000001811DC920-0x00000001811DC950
		public bool GetDefaultApplicationForMimeType(string pchMimeType, string pchAppKeyBuffer, uint unAppKeyBufferLen) => default; // 0x00000001811DC6D0-0x00000001811DC700
		public bool GetApplicationSupportedMimeTypes(string pchAppKey, string pchMimeTypesBuffer, uint unMimeTypesBuffer) => default; // 0x00000001811DC540-0x00000001811DC570
		public uint GetApplicationsThatSupportMimeType(string pchMimeType, string pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer) => default; // 0x00000001811DC5F0-0x00000001811DC620
		public uint GetApplicationLaunchArguments(uint unHandle, string pchArgs, uint unArgs) => default; // 0x00000001811DC460-0x00000001811DC490
		public EVRApplicationError GetStartingApplication(string pchAppKeyBuffer, uint unAppKeyBufferLen) => default; // 0x00000001811DC700-0x00000001811DC730
		public EVRApplicationTransitionState GetTransitionState() => default; // 0x00000001811DC730-0x00000001811DC760
		public EVRApplicationError PerformApplicationPrelaunchCheck(string pchAppKey) => default; // 0x00000001811DC8A0-0x00000001811DC8D0
		public string GetApplicationsTransitionStateNameFromEnum(EVRApplicationTransitionState state) => default; // 0x00000001811DC620-0x00000001811DC6A0
		public bool IsQuitUserPromptRequested() => default; // 0x00000001811DC7A0-0x00000001811DC7D0
		public EVRApplicationError LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory) => default; // 0x00000001811DC830-0x00000001811DC860
		public uint GetCurrentSceneProcessId() => default; // 0x00000001811DC6A0-0x00000001811DC6D0
	}
}
