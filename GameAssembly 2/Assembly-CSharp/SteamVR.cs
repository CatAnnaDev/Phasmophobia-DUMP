/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class SteamVR : IDisposable // TypeDefIndex: 7258
{
	// Fields
	private static bool _enabled; // 0x00
	private static SteamVR _instance; // 0x08
	public static bool[] connected; // 0x18
	public ETextureType textureType; // 0x50

	// Properties
	public static bool active { get => default; } // 0x0000000180CD9A10-0x0000000180CD9A70 
	public static bool enabled { get => default; set {} } // 0x0000000180CD9AD0-0x0000000180CD9BF0 0x0000000180CDA070-0x0000000180CDA110
	public static SteamVR instance { get => default; } // 0x0000000180CD9D00-0x0000000180CD9F30 
	public static bool usingNativeSupport { get => default; } // 0x0000000180CD9FB0-0x0000000180CDA010 
	public CVRSystem hmd { get; private set; } // 0x0000000180248E10-0x0000000180248E20 0x0000000180248410-0x0000000180248420
	public CVRCompositor compositor { get; private set; } // 0x0000000180246BC0-0x0000000180246BD0 0x0000000180246D40-0x0000000180246D50
	public CVROverlay overlay { get; private set; } // 0x0000000180246FE0-0x0000000180246FF0 0x0000000180249080-0x0000000180249090
	public static bool initializing { get; private set; } // 0x0000000180CD9CA0-0x0000000180CD9D00 0x0000000180CDA110-0x0000000180CDA170
	public static bool calibrating { get; private set; } // 0x0000000180CD9A70-0x0000000180CD9AD0 0x0000000180CDA010-0x0000000180CDA070
	public static bool outOfRange { get; private set; } // 0x0000000180CD9F30-0x0000000180CD9F90 0x0000000180CDA170-0x0000000180CDA1D0
	public float sceneWidth { get; private set; } // 0x000000018036E6C0-0x000000018036E6D0 0x0000000180523C30-0x0000000180523C40
	public float sceneHeight { get; private set; } // 0x000000018036E6B0-0x000000018036E6C0 0x00000001804919A0-0x00000001804919B0
	public float aspect { get; private set; } // 0x00000001802764F0-0x0000000180276500 0x0000000180278410-0x0000000180278420
	public float fieldOfView { get; private set; } // 0x000000018036E6F0-0x000000018036E700 0x0000000180482B00-0x0000000180483410
	public Vector2 tanHalfFov { get; private set; } // 0x0000000180CD9F90-0x0000000180CD9FB0 0x0000000180CDA1D0-0x0000000180CDA1F0
	public VRTextureBounds_t[] textureBounds { get; private set; } // 0x0000000180249A10-0x0000000180249A20 0x0000000180249920-0x0000000180249930
	public SteamVR_Utils.RigidTransform[] eyes { get; private set; } // 0x00000001803F7AF0-0x00000001803F7B00 0x0000000180249C10-0x0000000180249C20
	public string hmd_TrackingSystemName { get => default; } // 0x0000000180CD9C90-0x0000000180CD9CA0 
	public string hmd_ModelNumber { get => default; } // 0x0000000180CD9C30-0x0000000180CD9C40 
	public string hmd_SerialNumber { get => default; } // 0x0000000180CD9C80-0x0000000180CD9C90 
	public float hmd_SecondsFromVsyncToPhotons { get => default; } // 0x0000000180CD9C40-0x0000000180CD9C80 
	public float hmd_DisplayFrequency { get => default; } // 0x0000000180CD9BF0-0x0000000180CD9C30 

	// Constructors
	private SteamVR() {} // 0x0000000180CD8F80-0x0000000180CD9A10
	static SteamVR() {} // 0x0000000180CD8F10-0x0000000180CD8F80

	// Methods
	private static SteamVR CreateInstance() => default; // 0x0000000180CBC560-0x0000000180CBC770
	private static void ReportError(EVRInitError error) {} // 0x0000000180CCDAE0-0x0000000180CCDC20
	public string GetTrackedDeviceString(uint deviceId) => default; // 0x0000000180CC1D30-0x0000000180CC1E20
	public string GetStringProperty(ETrackedDeviceProperty prop, uint deviceId = 0 /* Metadata: 0x006533C7 */) => default; // 0x0000000180CC1BE0-0x0000000180CC1D30
	public float GetFloatProperty(ETrackedDeviceProperty prop, uint deviceId = 0 /* Metadata: 0x006533CB */) => default; // 0x0000000180CC1BA0-0x0000000180CC1BE0
	private void OnInitializing(bool initializing) {} // 0x0000000180CC6A10-0x0000000180CC6AB0
	private void OnCalibrating(bool calibrating) {} // 0x0000000180CC68E0-0x0000000180CC6980
	private void OnOutOfRange(bool outOfRange) {} // 0x0000000180CC6FF0-0x0000000180CC7090
	private void OnDeviceConnected(int i, bool connected) {} // 0x0000000180CC6980-0x0000000180CC6A10
	private void OnNewPoses(TrackedDevicePose_t[] poses) {} // 0x0000000180CC6AB0-0x0000000180CC6FF0
	~SteamVR() {} // 0x0000000180CC0590-0x0000000180CC0630
	public void Dispose() {} // 0x0000000180CBC770-0x0000000180CBC7D0
	private void Dispose(bool disposing) {} // 0x0000000180CBC7D0-0x0000000180CBCA20
	public static void SafeDispose() {} // 0x0000000180CCDC20-0x0000000180CCDD20
}

