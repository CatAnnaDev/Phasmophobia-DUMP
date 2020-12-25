/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class SteamVR_IK : MonoBehaviour // TypeDefIndex: 7283
{
	// Fields
	public Transform target; // 0x18
	public Transform start; // 0x20
	public Transform joint; // 0x28
	public Transform end; // 0x30
	public Transform poleVector; // 0x38
	public Transform upVector; // 0x40
	public float blendPct; // 0x48
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public Transform startXform; // 0x50
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public Transform jointXform; // 0x58
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public Transform endXform; // 0x60

	// Constructors
	public SteamVR_IK() {} // 0x0000000180CC3180-0x0000000180CC3190

	// Methods
	private void LateUpdate() {} // 0x0000000180CC1E20-0x0000000180CC2B10
	public static bool Solve(Vector3 start, Vector3 end, Vector3 poleVector, float jointDist, float targetDist, ref Vector3 result, out Vector3 forward, out Vector3 up) {
		forward = default;
		up = default;
		return default;
	} // 0x0000000180CC2B10-0x0000000180CC3180
}

