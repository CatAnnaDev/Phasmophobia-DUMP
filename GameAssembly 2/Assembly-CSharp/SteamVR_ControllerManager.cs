/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class SteamVR_ControllerManager : MonoBehaviour // TypeDefIndex: 7266
{
	// Fields
	public GameObject left; // 0x18
	public GameObject right; // 0x20
	// [Tooltip] // 0x0000000180119000-0x0000000180119030
	public GameObject[] objects; // 0x28
	// [Tooltip] // 0x00000001801190B0-0x00000001801190E0
	public bool assignAllBeforeIdentified; // 0x30
	private uint[] indices; // 0x38
	private bool[] connected; // 0x40
	private uint leftIndex; // 0x48
	private uint rightIndex; // 0x4C
	private SteamVR_Events.Action inputFocusAction; // 0x50
	private SteamVR_Events.Action deviceConnectedAction; // 0x58
	private SteamVR_Events.Action trackedDeviceRoleChangedAction; // 0x60
	private static string hiddenPrefix; // 0x00
	private static string hiddenPostfix; // 0x08
	private static string[] labels; // 0x10

	// Constructors
	private SteamVR_ControllerManager() {} // 0x0000000180CBBD10-0x0000000180CBBEE0
	static SteamVR_ControllerManager() {} // 0x0000000180CBBBA0-0x0000000180CBBD10

	// Methods
	private void SetUniqueObject(GameObject o, int index) {} // 0x0000000180CBBA70-0x0000000180CBBBA0
	public void UpdateTargets() {} // 0x0000000180CBABD0-0x0000000180CBAD30
	private void Awake() {} // 0x0000000180CBABD0-0x0000000180CBAD30
	private void OnEnable() {} // 0x0000000180CBAEC0-0x0000000180CBB110
	private void OnDisable() {} // 0x0000000180CBAE50-0x0000000180CBAEC0
	private void OnInputFocus(bool hasFocus) {} // 0x0000000180CBB110-0x0000000180CBB430
	private void HideObject(Transform t, string name) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void ShowObject(Transform t, string name) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void SetTrackedDeviceIndex(int objectIndex, uint trackedDeviceIndex) {} // 0x0000000180CBB7E0-0x0000000180CBBA70
	private void OnTrackedDeviceRoleChanged(VREvent_t vrEvent) {} // 0x0000000180CBB430-0x0000000180CBB440
	private void OnDeviceConnected(int index, bool connected) {} // 0x0000000180CBAD30-0x0000000180CBAE50
	public void Refresh() {} // 0x0000000180CBB440-0x0000000180CBB7E0
}

