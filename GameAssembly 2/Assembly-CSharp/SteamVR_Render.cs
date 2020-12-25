/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class SteamVR_Render : MonoBehaviour // TypeDefIndex: 7292
{
	// Fields
	public bool pauseGameWhenDashboardIsVisible; // 0x18
	public bool lockPhysicsUpdateRateToRenderFrequency; // 0x19
	public SteamVR_ExternalCamera externalCamera; // 0x20
	public string externalCameraConfigPath; // 0x28
	public ETrackingUniverseOrigin trackingSpace; // 0x30
	private static SteamVR_Render _instance; // 0x08
	private static bool isQuitting; // 0x10
	private SteamVR_Camera[] cameras; // 0x38
	public TrackedDevicePose_t[] poses; // 0x40
	public TrackedDevicePose_t[] gamePoses; // 0x48
	private static bool _pauseRendering; // 0x11
	private WaitForEndOfFrame waitForEndOfFrame; // 0x50
	private float sceneResolutionScale; // 0x58
	private float timeScale; // 0x5C

	// Properties
	public static EVREye eye { get; private set; } // 0x0000000180CCD860-0x0000000180CCD8A0 0x0000000180CCDA20-0x0000000180CCDA60
	public static SteamVR_Render instance { get => default; } // 0x0000000180CCD8A0-0x0000000180CCD9E0 
	public static bool pauseRendering { get => default; set {} } // 0x0000000180CCD9E0-0x0000000180CCDA20 0x0000000180CCDA60-0x0000000180CCDAE0

	// Constructors
	public SteamVR_Render() {} // 0x0000000180CCD770-0x0000000180CCD860

	// Methods
	private void OnDestroy() {} // 0x0000000180CCC5B0-0x0000000180CCC600
	private void OnApplicationQuit() {} // 0x0000000180CCC470-0x0000000180CCC4D0
	public static void Add(SteamVR_Camera vrcam) {} // 0x0000000180CCC140-0x0000000180CCC1B0
	public static void Remove(SteamVR_Camera vrcam) {} // 0x0000000180CBA5F0-0x0000000180CBA690
	public static SteamVR_Camera Top() => default; // 0x0000000180CCD210-0x0000000180CCD2A0
	private void AddInternal(SteamVR_Camera vrcam) {} // 0x0000000180CCBEE0-0x0000000180CCC140
	private void RemoveInternal(SteamVR_Camera vrcam) {} // 0x0000000180CCCD20-0x0000000180CCCEF0
	private SteamVR_Camera TopInternal() => default; // 0x0000000180CCD1C0-0x0000000180CCD210
	// [IteratorStateMachine] // 0x000000018011C520-0x000000018011C570
	private IEnumerator RenderLoop() => default; // 0x0000000180CCD150-0x0000000180CCD1C0
	private void RenderExternalCamera() {} // 0x0000000180CCCEF0-0x0000000180CCD150
	private void OnInputFocus(bool hasFocus) {} // 0x0000000180CCCA30-0x0000000180CCCAA0
	private void OnQuit(VREvent_t vrEvent) {} // 0x0000000180C03E70-0x0000000180C03E80
	private string GetScreenshotFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames screenshotPropertyFilename) => default; // 0x0000000180CCC320-0x0000000180CCC470
	private void OnRequestScreenshot(VREvent_t vrEvent) {} // 0x0000000180CCCAA0-0x0000000180CCCD20
	private void OnEnable() {} // 0x0000000180CCC790-0x0000000180CCCA30
	private void OnDisable() {} // 0x0000000180CCC600-0x0000000180CCC790
	private void Awake() {} // 0x0000000180CCC1B0-0x0000000180CCC320
	public void UpdatePoses() {} // 0x0000000180CCC4D0-0x0000000180CCC5B0
	private void OnBeforeRender() {} // 0x0000000180CCC4D0-0x0000000180CCC5B0
	private void Update() {} // 0x0000000180CCD2A0-0x0000000180CCD770
}

