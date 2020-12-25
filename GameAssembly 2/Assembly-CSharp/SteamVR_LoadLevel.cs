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

public class SteamVR_LoadLevel : MonoBehaviour // TypeDefIndex: 7284
{
	// Fields
	private static SteamVR_LoadLevel _active; // 0x00
	public string levelName; // 0x18
	public string internalProcessPath; // 0x20
	public string internalProcessArgs; // 0x28
	public bool loadAdditive; // 0x30
	public bool loadAsync; // 0x31
	public Texture loadingScreen; // 0x38
	public Texture progressBarEmpty; // 0x40
	public Texture progressBarFull; // 0x48
	public float loadingScreenWidthInMeters; // 0x50
	public float progressBarWidthInMeters; // 0x54
	public float loadingScreenDistance; // 0x58
	public Transform loadingScreenTransform; // 0x60
	public Transform progressBarTransform; // 0x68
	public Texture front; // 0x70
	public Texture back; // 0x78
	public Texture left; // 0x80
	public Texture right; // 0x88
	public Texture top; // 0x90
	public Texture bottom; // 0x98
	public Color backgroundColor; // 0xA0
	public bool showGrid; // 0xB0
	public float fadeOutTime; // 0xB4
	public float fadeInTime; // 0xB8
	public float postLoadSettleTime; // 0xBC
	public float loadingScreenFadeInTime; // 0xC0
	public float loadingScreenFadeOutTime; // 0xC4
	private float fadeRate; // 0xC8
	private float alpha; // 0xCC
	private AsyncOperation async; // 0xD0
	private RenderTexture renderTexture; // 0xD8
	private ulong loadingScreenOverlayHandle; // 0xE0
	private ulong progressBarOverlayHandle; // 0xE8
	public bool autoTriggerOnEnable; // 0xF0

	// Properties
	public static bool loading { get => default; } // 0x0000000180CC4E10-0x0000000180CC4EA0 
	public static float progress { get => default; } // 0x0000000180CC4F80-0x0000000180CC50A0 
	public static Texture progressTexture { get => default; } // 0x0000000180CC4EA0-0x0000000180CC4F80 

	// Constructors
	public SteamVR_LoadLevel() {} // 0x0000000180CC4D90-0x0000000180CC4E10
	static SteamVR_LoadLevel() {} // 0x0000000180246DB0-0x0000000180246DC0

	// Methods
	private void OnEnable() {} // 0x0000000180CC4550-0x0000000180CC4570
	public void Trigger() {} // 0x0000000180CC4AA0-0x0000000180CC4BE0
	public static void Begin(string levelName, bool showGrid = false /* Metadata: 0x00653473 */, float fadeOutTime = 0.5f /* Metadata: 0x00653474 */, float r = 0f /* Metadata: 0x00653478 */, float g = 0f /* Metadata: 0x0065347C */, float b = 0f /* Metadata: 0x00653480 */, float a = 1f /* Metadata: 0x00653484 */) {} // 0x0000000180CC3EF0-0x0000000180CC4010
	private void OnGUI() {} // 0x0000000180CC4570-0x0000000180CC4AA0
	private void Update() {} // 0x0000000180CC4C10-0x0000000180CC4D90
	// [IteratorStateMachine] // 0x000000018011AA20-0x000000018011AA70
	private IEnumerator LoadLevel() => default; // 0x0000000180CC44E0-0x0000000180CC4550
	private ulong GetOverlayHandle(string overlayName, Transform transform, float widthInMeters = 1f /* Metadata: 0x00653488 */) => default; // 0x0000000180CC4010-0x0000000180CC44E0
}

