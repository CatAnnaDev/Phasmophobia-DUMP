/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class SteamVR_Controller // TypeDefIndex: 7262
{
	// Fields
	private static Device[] devices; // 0x00

	// Nested types
	public class ButtonMask // TypeDefIndex: 7263
	{
		// Fields
		public const ulong System = 1; // Metadata: 0x00653404
		public const ulong ApplicationMenu = 2; // Metadata: 0x0065340C
		public const ulong Grip = 4; // Metadata: 0x00653414
		public const ulong Axis0 = 4294967296; // Metadata: 0x0065341C
		public const ulong Axis1 = 8589934592; // Metadata: 0x00653424
		public const ulong Axis2 = 17179869184; // Metadata: 0x0065342C
		public const ulong Axis3 = 34359738368; // Metadata: 0x00653434
		public const ulong Axis4 = 68719476736; // Metadata: 0x0065343C
		public const ulong Touchpad = 4294967296; // Metadata: 0x00653444
		public const ulong Trigger = 8589934592; // Metadata: 0x0065344C

		// Constructors
		public ButtonMask() {} // 0x00000001802466A0-0x00000001802466B0
	}

	public class Device // TypeDefIndex: 7264
	{
		// Fields
		private VRControllerState_t state; // 0x18
		private VRControllerState_t prevState; // 0x58
		private TrackedDevicePose_t pose; // 0x98
		private int prevFrameCount; // 0xE8
		public float hairTriggerDelta; // 0xEC
		private float hairTriggerLimit; // 0xF0
		private bool hairTriggerState; // 0xF4
		private bool hairTriggerPrevState; // 0xF5

		// Properties
		public uint index { get; private set; } // 0x0000000180245EA0-0x0000000180246600 0x00000001802932E0-0x00000001802932F0
		public bool valid { get; private set; } // 0x00000001802D2B60-0x00000001802D2B70 0x000000018030F010-0x000000018030F020
		public bool connected { get => default; } // 0x0000000180CB8D10-0x0000000180CB8D30 
		public bool hasTracking { get => default; } // 0x0000000180CB8D30-0x0000000180CB8D50 
		public bool outOfRange { get => default; } // 0x0000000180CB8D50-0x0000000180CB8D90 
		public bool calibrating { get => default; } // 0x0000000180CB8CE0-0x0000000180CB8D10 
		public bool uninitialized { get => default; } // 0x0000000180CB8E00-0x0000000180CB8E20 
		public SteamVR_Utils.RigidTransform transform { get => default; } // 0x0000000180CB8D90-0x0000000180CB8E00 
		public Vector3 velocity { get => default; } // 0x0000000180CB8E20-0x0000000180CB8E80 
		public Vector3 angularVelocity { get => default; } // 0x0000000180CB8C70-0x0000000180CB8CE0 

		// Constructors
		public Device() {} // Dummy constructor
		public Device(uint i) {} // 0x0000000180CB8C30-0x0000000180CB8C70

		// Methods
		public VRControllerState_t GetState() => default; // 0x0000000180CB8640-0x0000000180CB8690
		public VRControllerState_t GetPrevState() => default; // 0x0000000180CB85F0-0x0000000180CB8640
		public TrackedDevicePose_t GetPose() => default; // 0x0000000180CB8400-0x0000000180CB8460
		public void Update() {} // 0x0000000180CB89B0-0x0000000180CB8C30
		public bool GetPress(ulong buttonMask) => default; // 0x0000000180CB8580-0x0000000180CB85B0
		public bool GetPressDown(ulong buttonMask) => default; // 0x0000000180CB84B0-0x0000000180CB84F0
		public bool GetPressUp(ulong buttonMask) => default; // 0x0000000180CB8540-0x0000000180CB8580
		public bool GetPress(EVRButtonId buttonId) => default; // 0x0000000180CB85B0-0x0000000180CB85F0
		public bool GetPressDown(EVRButtonId buttonId) => default; // 0x0000000180CB8460-0x0000000180CB84B0
		public bool GetPressUp(EVRButtonId buttonId) => default; // 0x0000000180CB84F0-0x0000000180CB8540
		public bool GetTouch(ulong buttonMask) => default; // 0x0000000180CB87B0-0x0000000180CB87E0
		public bool GetTouchDown(ulong buttonMask) => default; // 0x0000000180CB8690-0x0000000180CB86D0
		public bool GetTouchUp(ulong buttonMask) => default; // 0x0000000180CB8770-0x0000000180CB87B0
		public bool GetTouch(EVRButtonId buttonId) => default; // 0x0000000180CB87E0-0x0000000180CB8820
		public bool GetTouchDown(EVRButtonId buttonId) => default; // 0x0000000180CB86D0-0x0000000180CB8720
		public bool GetTouchUp(EVRButtonId buttonId) => default; // 0x0000000180CB8720-0x0000000180CB8770
		public Vector2 GetAxis(EVRButtonId buttonId = EVRButtonId.k_EButton_Axis0 /* Metadata: 0x00653454 */) => default; // 0x0000000180CB8290-0x0000000180CB8370
		public void TriggerHapticPulse(ushort durationMicroSec = 500 /* Metadata: 0x00653458 */, EVRButtonId buttonId = EVRButtonId.k_EButton_Axis0 /* Metadata: 0x0065345A */) {} // 0x0000000180CB8820-0x0000000180CB88B0
		private void UpdateHairTrigger() {} // 0x0000000180CB88B0-0x0000000180CB89B0
		public bool GetHairTrigger() => default; // 0x0000000180CB83E0-0x0000000180CB8400
		public bool GetHairTriggerDown() => default; // 0x0000000180CB8370-0x0000000180CB83B0
		public bool GetHairTriggerUp() => default; // 0x0000000180CB83B0-0x0000000180CB83E0
	}

	public enum DeviceRelation // TypeDefIndex: 7265
	{
		First = 0,
		Leftmost = 1,
		Rightmost = 2,
		FarthestLeft = 3,
		FarthestRight = 4
	}

	// Constructors
	public SteamVR_Controller() {} // 0x00000001802466A0-0x00000001802466B0

	// Methods
	public static Device Input(int deviceIndex) => default; // 0x0000000180CBC370-0x0000000180CBC520
	public static void Update() {} // 0x0000000180CBC520-0x0000000180CBC560
	public static int GetDeviceIndex(DeviceRelation relation, ETrackedDeviceClass deviceClass = ETrackedDeviceClass.Controller /* Metadata: 0x006533FC */, int relativeTo = 0 /* Metadata: 0x00653400 */) => default; // 0x0000000180CBBEE0-0x0000000180CBC370
}

