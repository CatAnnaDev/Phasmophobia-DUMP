/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class SteamVR_Overlay : MonoBehaviour // TypeDefIndex: 7287
{
	// Fields
	public Texture texture; // 0x18
	public bool curved; // 0x20
	public bool antialias; // 0x21
	public bool highquality; // 0x22
	// [Tooltip] // 0x000000018011B2E0-0x000000018011B310
	public float scale; // 0x24
	// [Tooltip] // 0x000000018011B3F0-0x000000018011B420
	public float distance; // 0x28
	// [Range] // 0x000000018011B490-0x000000018011B4F0
	// [Tooltip] // 0x000000018011B490-0x000000018011B4F0
	public float alpha; // 0x2C
	public Vector4 uvOffset; // 0x30
	public Vector2 mouseScale; // 0x40
	public Vector2 curvedRange; // 0x48
	public VROverlayInputMethod inputMethod; // 0x50
	private ulong handle; // 0x58

	// Properties
	public static SteamVR_Overlay instance { get; private set; } // 0x0000000180CC7C40-0x0000000180CC7C80 0x0000000180CC7CE0-0x0000000180CC7D30
	public static string key { get => default; } // 0x0000000180CC7C80-0x0000000180CC7CE0 

	// Nested types
	public struct IntersectionResults // TypeDefIndex: 7288
	{
		// Fields
		public Vector3 point; // 0x00
		public Vector3 normal; // 0x0C
		public Vector2 UVs; // 0x18
		public float distance; // 0x20
	}

	// Constructors
	public SteamVR_Overlay() {} // 0x0000000180CC7B50-0x0000000180CC7C40

	// Methods
	private void OnEnable() {} // 0x0000000180CC7380-0x0000000180CC7510
	private void OnDisable() {} // 0x0000000180CC72D0-0x0000000180CC7380
	public void UpdateOverlay() {} // 0x0000000180CC7610-0x0000000180CC7B50
	public bool PollNextEvent(ref VREvent_t pEvent) => default; // 0x0000000180CC7510-0x0000000180CC7610
	public bool ComputeIntersection(Vector3 source, Vector3 direction, ref IntersectionResults results) => default; // 0x0000000180CC7090-0x0000000180CC72D0
}

