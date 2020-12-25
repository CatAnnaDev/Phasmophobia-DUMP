/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class SteamVR_TrackedObject : MonoBehaviour // TypeDefIndex: 7307
{
	// Fields
	public EIndex index; // 0x18
	// [Tooltip] // 0x00000001801210E0-0x0000000180121110
	public Transform origin; // 0x20
	private SteamVR_Events.Action newPosesAction; // 0x30

	// Properties
	public bool isValid { get; private set; } // 0x0000000180297A00-0x0000000180297A10 0x00000001804554D0-0x00000001804554E0

	// Nested types
	public enum EIndex // TypeDefIndex: 7308
	{
		None = -1,
		Hmd = 0,
		Device1 = 1,
		Device2 = 2,
		Device3 = 3,
		Device4 = 4,
		Device5 = 5,
		Device6 = 6,
		Device7 = 7,
		Device8 = 8,
		Device9 = 9,
		Device10 = 10,
		Device11 = 11,
		Device12 = 12,
		Device13 = 13,
		Device14 = 14,
		Device15 = 15
	}

	// Constructors
	private SteamVR_TrackedObject() {} // 0x0000000181D2BA80-0x0000000181D2BB20

	// Methods
	private void OnNewPoses(TrackedDevicePose_t[] poses) {} // 0x0000000181D2B710-0x0000000181D2B9B0
	private void OnEnable() {} // 0x0000000181D2B670-0x0000000181D2B710
	private void OnDisable() {} // 0x0000000181D2B640-0x0000000181D2B670
	public void SetDeviceIndex(int index) {} // 0x0000000181D2B9B0-0x0000000181D2BA80
}

