/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class SteamVR_Teleporter : MonoBehaviour // TypeDefIndex: 7251
{
	// Fields
	public bool teleportOnClick; // 0x18
	public TeleportType teleportType; // 0x1C

	// Properties
	private Transform reference { get => default; } // 0x0000000180CCF460-0x0000000180CCF4F0 

	// Nested types
	public enum TeleportType // TypeDefIndex: 7252
	{
		TeleportTypeUseTerrain = 0,
		TeleportTypeUseCollider = 1,
		TeleportTypeUseZeroY = 2
	}

	// Constructors
	public SteamVR_Teleporter() {} // 0x0000000180CCF450-0x0000000180CCF460

	// Methods
	private void Start() {} // 0x0000000180CCF220-0x0000000180CCF450
	private void DoClick(object sender, u091Au091Du0922u0924u0928u091Au0926u091Au0927u0923u091F e) {} // 0x0000000180CCED10-0x0000000180CCF220
}

