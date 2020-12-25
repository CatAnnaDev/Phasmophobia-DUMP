/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public class OpenVR // TypeDefIndex: 8338
	{
		// Fields
		public const uint k_nDriverNone = 4294967295; // Metadata: 0x00654C88
		public const uint k_unMaxDriverDebugResponseSize = 32768; // Metadata: 0x00654C8C
		public const uint k_unTrackedDeviceIndex_Hmd = 0; // Metadata: 0x00654C90
		public const uint k_unMaxTrackedDeviceCount = 16; // Metadata: 0x00654C94
		public const uint k_unTrackedDeviceIndexOther = 4294967294; // Metadata: 0x00654C98
		public const uint k_unTrackedDeviceIndexInvalid = 4294967295; // Metadata: 0x00654C9C
		public const ulong k_ulInvalidPropertyContainer = 0; // Metadata: 0x00654CA0
		public const uint k_unInvalidPropertyTag = 0; // Metadata: 0x00654CA8
		public const uint k_unFloatPropertyTag = 1; // Metadata: 0x00654CAC
		public const uint k_unInt32PropertyTag = 2; // Metadata: 0x00654CB0
		public const uint k_unUint64PropertyTag = 3; // Metadata: 0x00654CB4
		public const uint k_unBoolPropertyTag = 4; // Metadata: 0x00654CB8
		public const uint k_unStringPropertyTag = 5; // Metadata: 0x00654CBC
		public const uint k_unHmdMatrix34PropertyTag = 20; // Metadata: 0x00654CC0
		public const uint k_unHmdMatrix44PropertyTag = 21; // Metadata: 0x00654CC4
		public const uint k_unHmdVector3PropertyTag = 22; // Metadata: 0x00654CC8
		public const uint k_unHmdVector4PropertyTag = 23; // Metadata: 0x00654CCC
		public const uint k_unHiddenAreaPropertyTag = 30; // Metadata: 0x00654CD0
		public const uint k_unOpenVRInternalReserved_Start = 1000; // Metadata: 0x00654CD4
		public const uint k_unOpenVRInternalReserved_End = 10000; // Metadata: 0x00654CD8
		public const uint k_unMaxPropertyStringSize = 32768; // Metadata: 0x00654CDC
		public const uint k_unControllerStateAxisCount = 5; // Metadata: 0x00654CE0
		public const ulong k_ulOverlayHandleInvalid = 0; // Metadata: 0x00654CE4
		public const uint k_unScreenshotHandleInvalid = 0; // Metadata: 0x00654CEC
		public const string IVRSystem_Version = "IVRSystem_016"; // Metadata: 0x00654CF0
		public const string IVRExtendedDisplay_Version = "IVRExtendedDisplay_001"; // Metadata: 0x00654D01
		public const string IVRTrackedCamera_Version = "IVRTrackedCamera_003"; // Metadata: 0x00654D1B
		public const uint k_unMaxApplicationKeyLength = 128; // Metadata: 0x00654D33
		public const string k_pch_MimeType_HomeApp = "vr/home"; // Metadata: 0x00654D37
		public const string k_pch_MimeType_GameTheater = "vr/game_theater"; // Metadata: 0x00654D42
		public const string IVRApplications_Version = "IVRApplications_006"; // Metadata: 0x00654D55
		public const string IVRChaperone_Version = "IVRChaperone_003"; // Metadata: 0x00654D6C
		public const string IVRChaperoneSetup_Version = "IVRChaperoneSetup_005"; // Metadata: 0x00654D80
		public const string IVRCompositor_Version = "IVRCompositor_020"; // Metadata: 0x00654D99
		public const uint k_unVROverlayMaxKeyLength = 128; // Metadata: 0x00654DAE
		public const uint k_unVROverlayMaxNameLength = 128; // Metadata: 0x00654DB2
		public const uint k_unMaxOverlayCount = 64; // Metadata: 0x00654DB6
		public const uint k_unMaxOverlayIntersectionMaskPrimitivesCount = 32; // Metadata: 0x00654DBA
		public const string IVROverlay_Version = "IVROverlay_016"; // Metadata: 0x00654DBE
		public const string k_pch_Controller_Component_GDC2015 = "gdc2015"; // Metadata: 0x00654DD0
		public const string k_pch_Controller_Component_Base = "base"; // Metadata: 0x00654DDB
		public const string k_pch_Controller_Component_Tip = "tip"; // Metadata: 0x00654DE3
		public const string k_pch_Controller_Component_HandGrip = "handgrip"; // Metadata: 0x00654DEA
		public const string k_pch_Controller_Component_Status = "status"; // Metadata: 0x00654DF6
		public const string IVRRenderModels_Version = "IVRRenderModels_005"; // Metadata: 0x00654E00
		public const uint k_unNotificationTextMaxSize = 256; // Metadata: 0x00654E17
		public const string IVRNotifications_Version = "IVRNotifications_002"; // Metadata: 0x00654E1B
		public const uint k_unMaxSettingsKeyLength = 128; // Metadata: 0x00654E33
		public const string IVRSettings_Version = "IVRSettings_002"; // Metadata: 0x00654E37
		public const string k_pch_SteamVR_Section = "steamvr"; // Metadata: 0x00654E4A
		public const string k_pch_SteamVR_RequireHmd_String = "requireHmd"; // Metadata: 0x00654E55
		public const string k_pch_SteamVR_ForcedDriverKey_String = "forcedDriver"; // Metadata: 0x00654E63
		public const string k_pch_SteamVR_ForcedHmdKey_String = "forcedHmd"; // Metadata: 0x00654E73
		public const string k_pch_SteamVR_DisplayDebug_Bool = "displayDebug"; // Metadata: 0x00654E80
		public const string k_pch_SteamVR_DebugProcessPipe_String = "debugProcessPipe"; // Metadata: 0x00654E90
		public const string k_pch_SteamVR_DisplayDebugX_Int32 = "displayDebugX"; // Metadata: 0x00654EA4
		public const string k_pch_SteamVR_DisplayDebugY_Int32 = "displayDebugY"; // Metadata: 0x00654EB5
		public const string k_pch_SteamVR_SendSystemButtonToAllApps_Bool = "sendSystemButtonToAllApps"; // Metadata: 0x00654EC6
		public const string k_pch_SteamVR_LogLevel_Int32 = "loglevel"; // Metadata: 0x00654EE3
		public const string k_pch_SteamVR_IPD_Float = "ipd"; // Metadata: 0x00654EEF
		public const string k_pch_SteamVR_Background_String = "background"; // Metadata: 0x00654EF6
		public const string k_pch_SteamVR_BackgroundUseDomeProjection_Bool = "backgroundUseDomeProjection"; // Metadata: 0x00654F04
		public const string k_pch_SteamVR_BackgroundCameraHeight_Float = "backgroundCameraHeight"; // Metadata: 0x00654F23
		public const string k_pch_SteamVR_BackgroundDomeRadius_Float = "backgroundDomeRadius"; // Metadata: 0x00654F3D
		public const string k_pch_SteamVR_GridColor_String = "gridColor"; // Metadata: 0x00654F55
		public const string k_pch_SteamVR_PlayAreaColor_String = "playAreaColor"; // Metadata: 0x00654F62
		public const string k_pch_SteamVR_ShowStage_Bool = "showStage"; // Metadata: 0x00654F73
		public const string k_pch_SteamVR_ActivateMultipleDrivers_Bool = "activateMultipleDrivers"; // Metadata: 0x00654F80
		public const string k_pch_SteamVR_DirectMode_Bool = "directMode"; // Metadata: 0x00654F9B
		public const string k_pch_SteamVR_DirectModeEdidVid_Int32 = "directModeEdidVid"; // Metadata: 0x00654FA9
		public const string k_pch_SteamVR_DirectModeEdidPid_Int32 = "directModeEdidPid"; // Metadata: 0x00654FBE
		public const string k_pch_SteamVR_UsingSpeakers_Bool = "usingSpeakers"; // Metadata: 0x00654FD3
		public const string k_pch_SteamVR_SpeakersForwardYawOffsetDegrees_Float = "speakersForwardYawOffsetDegrees"; // Metadata: 0x00654FE4
		public const string k_pch_SteamVR_BaseStationPowerManagement_Bool = "basestationPowerManagement"; // Metadata: 0x00655007
		public const string k_pch_SteamVR_NeverKillProcesses_Bool = "neverKillProcesses"; // Metadata: 0x00655025
		public const string k_pch_SteamVR_SupersampleScale_Float = "supersampleScale"; // Metadata: 0x0065503B
		public const string k_pch_SteamVR_AllowAsyncReprojection_Bool = "allowAsyncReprojection"; // Metadata: 0x0065504F
		public const string k_pch_SteamVR_AllowReprojection_Bool = "allowInterleavedReprojection"; // Metadata: 0x00655069
		public const string k_pch_SteamVR_ForceReprojection_Bool = "forceReprojection"; // Metadata: 0x00655089
		public const string k_pch_SteamVR_ForceFadeOnBadTracking_Bool = "forceFadeOnBadTracking"; // Metadata: 0x0065509E
		public const string k_pch_SteamVR_DefaultMirrorView_Int32 = "defaultMirrorView"; // Metadata: 0x006550B8
		public const string k_pch_SteamVR_ShowMirrorView_Bool = "showMirrorView"; // Metadata: 0x006550CD
		public const string k_pch_SteamVR_MirrorViewGeometry_String = "mirrorViewGeometry"; // Metadata: 0x006550DF
		public const string k_pch_SteamVR_StartMonitorFromAppLaunch = "startMonitorFromAppLaunch"; // Metadata: 0x006550F5
		public const string k_pch_SteamVR_StartCompositorFromAppLaunch_Bool = "startCompositorFromAppLaunch"; // Metadata: 0x00655112
		public const string k_pch_SteamVR_StartDashboardFromAppLaunch_Bool = "startDashboardFromAppLaunch"; // Metadata: 0x00655132
		public const string k_pch_SteamVR_StartOverlayAppsFromDashboard_Bool = "startOverlayAppsFromDashboard"; // Metadata: 0x00655151
		public const string k_pch_SteamVR_EnableHomeApp = "enableHomeApp"; // Metadata: 0x00655172
		public const string k_pch_SteamVR_CycleBackgroundImageTimeSec_Int32 = "CycleBackgroundImageTimeSec"; // Metadata: 0x00655183
		public const string k_pch_SteamVR_RetailDemo_Bool = "retailDemo"; // Metadata: 0x006551A2
		public const string k_pch_SteamVR_IpdOffset_Float = "ipdOffset"; // Metadata: 0x006551B0
		public const string k_pch_SteamVR_AllowSupersampleFiltering_Bool = "allowSupersampleFiltering"; // Metadata: 0x006551BD
		public const string k_pch_Lighthouse_Section = "driver_lighthouse"; // Metadata: 0x006551DA
		public const string k_pch_Lighthouse_DisableIMU_Bool = "disableimu"; // Metadata: 0x006551EF
		public const string k_pch_Lighthouse_UseDisambiguation_String = "usedisambiguation"; // Metadata: 0x006551FD
		public const string k_pch_Lighthouse_DisambiguationDebug_Int32 = "disambiguationdebug"; // Metadata: 0x00655212
		public const string k_pch_Lighthouse_PrimaryBasestation_Int32 = "primarybasestation"; // Metadata: 0x00655229
		public const string k_pch_Lighthouse_DBHistory_Bool = "dbhistory"; // Metadata: 0x0065523F
		public const string k_pch_Null_Section = "driver_null"; // Metadata: 0x0065524C
		public const string k_pch_Null_SerialNumber_String = "serialNumber"; // Metadata: 0x0065525B
		public const string k_pch_Null_ModelNumber_String = "modelNumber"; // Metadata: 0x0065526B
		public const string k_pch_Null_WindowX_Int32 = "windowX"; // Metadata: 0x0065527A
		public const string k_pch_Null_WindowY_Int32 = "windowY"; // Metadata: 0x00655285
		public const string k_pch_Null_WindowWidth_Int32 = "windowWidth"; // Metadata: 0x00655290
		public const string k_pch_Null_WindowHeight_Int32 = "windowHeight"; // Metadata: 0x0065529F
		public const string k_pch_Null_RenderWidth_Int32 = "renderWidth"; // Metadata: 0x006552AF
		public const string k_pch_Null_RenderHeight_Int32 = "renderHeight"; // Metadata: 0x006552BE
		public const string k_pch_Null_SecondsFromVsyncToPhotons_Float = "secondsFromVsyncToPhotons"; // Metadata: 0x006552CE
		public const string k_pch_Null_DisplayFrequency_Float = "displayFrequency"; // Metadata: 0x006552EB
		public const string k_pch_UserInterface_Section = "userinterface"; // Metadata: 0x006552FF
		public const string k_pch_UserInterface_StatusAlwaysOnTop_Bool = "StatusAlwaysOnTop"; // Metadata: 0x00655310
		public const string k_pch_UserInterface_MinimizeToTray_Bool = "MinimizeToTray"; // Metadata: 0x00655325
		public const string k_pch_UserInterface_Screenshots_Bool = "screenshots"; // Metadata: 0x00655337
		public const string k_pch_UserInterface_ScreenshotType_Int = "screenshotType"; // Metadata: 0x00655346
		public const string k_pch_Notifications_Section = "notifications"; // Metadata: 0x00655358
		public const string k_pch_Notifications_DoNotDisturb_Bool = "DoNotDisturb"; // Metadata: 0x00655369
		public const string k_pch_Keyboard_Section = "keyboard"; // Metadata: 0x00655379
		public const string k_pch_Keyboard_TutorialCompletions = "TutorialCompletions"; // Metadata: 0x00655385
		public const string k_pch_Keyboard_ScaleX = "ScaleX"; // Metadata: 0x0065539C
		public const string k_pch_Keyboard_ScaleY = "ScaleY"; // Metadata: 0x006553A6
		public const string k_pch_Keyboard_OffsetLeftX = "OffsetLeftX"; // Metadata: 0x006553B0
		public const string k_pch_Keyboard_OffsetRightX = "OffsetRightX"; // Metadata: 0x006553BF
		public const string k_pch_Keyboard_OffsetY = "OffsetY"; // Metadata: 0x006553CF
		public const string k_pch_Keyboard_Smoothing = "Smoothing"; // Metadata: 0x006553DA
		public const string k_pch_Perf_Section = "perfcheck"; // Metadata: 0x006553E7
		public const string k_pch_Perf_HeuristicActive_Bool = "heuristicActive"; // Metadata: 0x006553F4
		public const string k_pch_Perf_NotifyInHMD_Bool = "warnInHMD"; // Metadata: 0x00655407
		public const string k_pch_Perf_NotifyOnlyOnce_Bool = "warnOnlyOnce"; // Metadata: 0x00655414
		public const string k_pch_Perf_AllowTimingStore_Bool = "allowTimingStore"; // Metadata: 0x00655424
		public const string k_pch_Perf_SaveTimingsOnExit_Bool = "saveTimingsOnExit"; // Metadata: 0x00655438
		public const string k_pch_Perf_TestData_Float = "perfTestData"; // Metadata: 0x0065544D
		public const string k_pch_Perf_LinuxGPUProfiling_Bool = "linuxGPUProfiling"; // Metadata: 0x0065545D
		public const string k_pch_CollisionBounds_Section = "collisionBounds"; // Metadata: 0x00655472
		public const string k_pch_CollisionBounds_Style_Int32 = "CollisionBoundsStyle"; // Metadata: 0x00655485
		public const string k_pch_CollisionBounds_GroundPerimeterOn_Bool = "CollisionBoundsGroundPerimeterOn"; // Metadata: 0x0065549D
		public const string k_pch_CollisionBounds_CenterMarkerOn_Bool = "CollisionBoundsCenterMarkerOn"; // Metadata: 0x006554C1
		public const string k_pch_CollisionBounds_PlaySpaceOn_Bool = "CollisionBoundsPlaySpaceOn"; // Metadata: 0x006554E2
		public const string k_pch_CollisionBounds_FadeDistance_Float = "CollisionBoundsFadeDistance"; // Metadata: 0x00655500
		public const string k_pch_CollisionBounds_ColorGammaR_Int32 = "CollisionBoundsColorGammaR"; // Metadata: 0x0065551F
		public const string k_pch_CollisionBounds_ColorGammaG_Int32 = "CollisionBoundsColorGammaG"; // Metadata: 0x0065553D
		public const string k_pch_CollisionBounds_ColorGammaB_Int32 = "CollisionBoundsColorGammaB"; // Metadata: 0x0065555B
		public const string k_pch_CollisionBounds_ColorGammaA_Int32 = "CollisionBoundsColorGammaA"; // Metadata: 0x00655579
		public const string k_pch_Camera_Section = "camera"; // Metadata: 0x00655597
		public const string k_pch_Camera_EnableCamera_Bool = "enableCamera"; // Metadata: 0x006555A1
		public const string k_pch_Camera_EnableCameraInDashboard_Bool = "enableCameraInDashboard"; // Metadata: 0x006555B1
		public const string k_pch_Camera_EnableCameraForCollisionBounds_Bool = "enableCameraForCollisionBounds"; // Metadata: 0x006555CC
		public const string k_pch_Camera_EnableCameraForRoomView_Bool = "enableCameraForRoomView"; // Metadata: 0x006555EE
		public const string k_pch_Camera_BoundsColorGammaR_Int32 = "cameraBoundsColorGammaR"; // Metadata: 0x00655609
		public const string k_pch_Camera_BoundsColorGammaG_Int32 = "cameraBoundsColorGammaG"; // Metadata: 0x00655624
		public const string k_pch_Camera_BoundsColorGammaB_Int32 = "cameraBoundsColorGammaB"; // Metadata: 0x0065563F
		public const string k_pch_Camera_BoundsColorGammaA_Int32 = "cameraBoundsColorGammaA"; // Metadata: 0x0065565A
		public const string k_pch_Camera_BoundsStrength_Int32 = "cameraBoundsStrength"; // Metadata: 0x00655675
		public const string k_pch_audio_Section = "audio"; // Metadata: 0x0065568D
		public const string k_pch_audio_OnPlaybackDevice_String = "onPlaybackDevice"; // Metadata: 0x00655696
		public const string k_pch_audio_OnRecordDevice_String = "onRecordDevice"; // Metadata: 0x006556AA
		public const string k_pch_audio_OnPlaybackMirrorDevice_String = "onPlaybackMirrorDevice"; // Metadata: 0x006556BC
		public const string k_pch_audio_OffPlaybackDevice_String = "offPlaybackDevice"; // Metadata: 0x006556D6
		public const string k_pch_audio_OffRecordDevice_String = "offRecordDevice"; // Metadata: 0x006556EB
		public const string k_pch_audio_VIVEHDMIGain = "viveHDMIGain"; // Metadata: 0x006556FE
		public const string k_pch_Power_Section = "power"; // Metadata: 0x0065570E
		public const string k_pch_Power_PowerOffOnExit_Bool = "powerOffOnExit"; // Metadata: 0x00655717
		public const string k_pch_Power_TurnOffScreensTimeout_Float = "turnOffScreensTimeout"; // Metadata: 0x00655729
		public const string k_pch_Power_TurnOffControllersTimeout_Float = "turnOffControllersTimeout"; // Metadata: 0x00655742
		public const string k_pch_Power_ReturnToWatchdogTimeout_Float = "returnToWatchdogTimeout"; // Metadata: 0x0065575F
		public const string k_pch_Power_AutoLaunchSteamVROnButtonPress = "autoLaunchSteamVROnButtonPress"; // Metadata: 0x0065577A
		public const string k_pch_Dashboard_Section = "dashboard"; // Metadata: 0x0065579C
		public const string k_pch_Dashboard_EnableDashboard_Bool = "enableDashboard"; // Metadata: 0x006557A9
		public const string k_pch_Dashboard_ArcadeMode_Bool = "arcadeMode"; // Metadata: 0x006557BC
		public const string k_pch_modelskin_Section = "modelskins"; // Metadata: 0x006557CA
		public const string k_pch_Driver_Enable_Bool = "enable"; // Metadata: 0x006557D8
		public const string IVRScreenshots_Version = "IVRScreenshots_001"; // Metadata: 0x006557E2
		public const string IVRResources_Version = "IVRResources_001"; // Metadata: 0x006557F8
		public const string IVRDriverManager_Version = "IVRDriverManager_001"; // Metadata: 0x0065580C
		private const string FnTable_Prefix = "FnTable:"; // Metadata: 0x00655824
		private static COpenVRContext _OpenVRInternal_ModuleContext; // 0x08
	
		// Properties
		private static uint VRToken { get; set; } // 0x0000000180EE8FA0-0x0000000180EE9000 0x0000000180EE9000-0x0000000180EE90B0
		private static COpenVRContext OpenVRInternal_ModuleContext { get => default; } // 0x0000000180EE8590-0x0000000180EE86A0 
		public static CVRSystem System { get => default; } // 0x0000000180EE8CA0-0x0000000180EE8E20 
		public static CVRChaperone Chaperone { get => default; } // 0x0000000180EE8110-0x0000000180EE8290 
		public static CVRChaperoneSetup ChaperoneSetup { get => default; } // 0x0000000180EE7F90-0x0000000180EE8110 
		public static CVRCompositor Compositor { get => default; } // 0x0000000180EE8290-0x0000000180EE8410 
		public static CVROverlay Overlay { get => default; } // 0x0000000180EE86A0-0x0000000180EE8820 
		public static CVRRenderModels RenderModels { get => default; } // 0x0000000180EE8820-0x0000000180EE89A0 
		public static CVRExtendedDisplay ExtendedDisplay { get => default; } // 0x0000000180EE8410-0x0000000180EE8590 
		public static CVRSettings Settings { get => default; } // 0x0000000180EE8B20-0x0000000180EE8CA0 
		public static CVRApplications Applications { get => default; } // 0x0000000180EE7E10-0x0000000180EE7F90 
		public static CVRScreenshots Screenshots { get => default; } // 0x0000000180EE89A0-0x0000000180EE8B20 
		public static CVRTrackedCamera TrackedCamera { get => default; } // 0x0000000180EE8E20-0x0000000180EE8FA0 
	
		// Nested types
		private class COpenVRContext // TypeDefIndex: 8339
		{
			// Fields
			private CVRSystem m_pVRSystem; // 0x10
			private CVRChaperone m_pVRChaperone; // 0x18
			private CVRChaperoneSetup m_pVRChaperoneSetup; // 0x20
			private CVRCompositor m_pVRCompositor; // 0x28
			private CVROverlay m_pVROverlay; // 0x30
			private CVRRenderModels m_pVRRenderModels; // 0x38
			private CVRExtendedDisplay m_pVRExtendedDisplay; // 0x40
			private CVRSettings m_pVRSettings; // 0x48
			private CVRApplications m_pVRApplications; // 0x50
			private CVRScreenshots m_pVRScreenshots; // 0x58
			private CVRTrackedCamera m_pVRTrackedCamera; // 0x60
	
			// Constructors
			public COpenVRContext() {} // 0x0000000180EE7530-0x0000000180EE7550
	
			// Methods
			public void Clear() {} // 0x0000000180EE66B0-0x0000000180EE6770
			private void CheckClear() {} // 0x0000000180EE6580-0x0000000180EE66B0
			public CVRSystem VRSystem() => default; // 0x0000000180EE72B0-0x0000000180EE73F0
			public CVRChaperone VRChaperone() => default; // 0x0000000180EE69F0-0x0000000180EE6B30
			public CVRChaperoneSetup VRChaperoneSetup() => default; // 0x0000000180EE68B0-0x0000000180EE69F0
			public CVRCompositor VRCompositor() => default; // 0x0000000180EE6B30-0x0000000180EE6C70
			public CVROverlay VROverlay() => default; // 0x0000000180EE6DB0-0x0000000180EE6EF0
			public CVRRenderModels VRRenderModels() => default; // 0x0000000180EE6EF0-0x0000000180EE7030
			public CVRExtendedDisplay VRExtendedDisplay() => default; // 0x0000000180EE6C70-0x0000000180EE6DB0
			public CVRSettings VRSettings() => default; // 0x0000000180EE7170-0x0000000180EE72B0
			public CVRApplications VRApplications() => default; // 0x0000000180EE6770-0x0000000180EE68B0
			public CVRScreenshots VRScreenshots() => default; // 0x0000000180EE7030-0x0000000180EE7170
			public CVRTrackedCamera VRTrackedCamera() => default; // 0x0000000180EE73F0-0x0000000180EE7530
		}
	
		// Constructors
		public OpenVR() {} // 0x00000001802466A0-0x00000001802466B0
		static OpenVR() {} // 0x0000000180246DB0-0x0000000180246DC0
	
		// Methods
		public static uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType) => default; // 0x0000000180EE76F0-0x0000000180EE7780
		public static void ShutdownInternal() {} // 0x0000000180EE7900-0x0000000180EE7970
		public static bool IsHmdPresent() => default; // 0x0000000180EE7780-0x0000000180EE77F0
		public static bool IsRuntimeInstalled() => default; // 0x0000000180EE7890-0x0000000180EE7900
		public static string GetStringForHmdError(EVRInitError error) => default; // 0x0000000180EE7980-0x0000000180EE7A40
		public static IntPtr GetGenericInterface(string pchInterfaceVersion, ref EVRInitError peError) => default; // 0x0000000180EE7970-0x0000000180EE7980
		public static bool IsInterfaceVersionValid(string pchInterfaceVersion) => default; // 0x0000000180EE77F0-0x0000000180EE7890
		public static uint GetInitToken() => default; // 0x0000000180EE7600-0x0000000180EE7670
		public static CVRSystem Init(ref EVRInitError peError, EVRApplicationType eApplicationType = EVRApplicationType.VRApplication_Scene /* Metadata: 0x00654C84 */) => default; // 0x0000000180EE7A40-0x0000000180EE7DC0
		public static void Shutdown() {} // 0x0000000180EE7DC0-0x0000000180EE7E10
	}
}
