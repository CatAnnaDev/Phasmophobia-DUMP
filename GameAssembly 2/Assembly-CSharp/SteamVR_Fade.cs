/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class SteamVR_Fade : MonoBehaviour // TypeDefIndex: 7280
{
	// Fields
	private Color currentColor; // 0x18
	private Color targetColor; // 0x28
	private Color deltaColor; // 0x38
	private bool fadeOverlay; // 0x48
	private static Material fadeMaterial; // 0x00
	private static int fadeMaterialColorID; // 0x08

	// Constructors
	public SteamVR_Fade() {} // 0x0000000180CC04D0-0x0000000180CC0590
	static SteamVR_Fade() {} // 0x0000000180CC0470-0x0000000180CC04D0

	// Methods
	public static void Start(Color newColor, float duration, bool fadeOverlay = false /* Metadata: 0x00653472 */) {} // 0x0000000180CC0320-0x0000000180CC03D0
	public static void View(Color newColor, float duration) {} // 0x0000000180CC03D0-0x0000000180CC0470
	public void OnStartFade(Color newColor, float duration, bool fadeOverlay) {} // 0x0000000180CC0290-0x0000000180CC0320
	private void OnEnable() {} // 0x0000000180CBFD50-0x0000000180CBFF10
	private void OnDisable() {} // 0x0000000180CBFC90-0x0000000180CBFD50
	private void OnPostRender() {} // 0x0000000180CBFF10-0x0000000180CC0290
}

