/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class SteamVR_Menu : MonoBehaviour // TypeDefIndex: 7286
{
	// Fields
	public Texture cursor; // 0x18
	public Texture background; // 0x20
	public Texture logo; // 0x28
	public float logoHeight; // 0x30
	public float menuOffset; // 0x34
	public Vector2 scaleLimits; // 0x38
	public float scaleRate; // 0x40
	private SteamVR_Overlay overlay; // 0x48
	private Camera overlayCam; // 0x50
	private Vector4 uvOffset; // 0x58
	private float distance; // 0x68
	private string scaleLimitX; // 0x70
	private string scaleLimitY; // 0x78
	private string scaleRateText; // 0x80
	private CursorLockMode savedCursorLockState; // 0x88
	private bool savedCursorVisible; // 0x8C

	// Properties
	public RenderTexture texture { get => default; } // 0x0000000180CC67F0-0x0000000180CC68D0 
	public float scale { get; private set; } // 0x0000000180CC67E0-0x0000000180CC67F0 0x0000000180CC68D0-0x0000000180CC68E0

	// Constructors
	public SteamVR_Menu() {} // 0x0000000180CC6780-0x0000000180CC67E0

	// Methods
	private void Awake() {} // 0x0000000180CC50A0-0x0000000180CC5210
	private void OnGUI() {} // 0x0000000180CC5320-0x0000000180CC6100
	public void ShowMenu() {} // 0x0000000180CC6240-0x0000000180CC6590
	public void HideMenu() {} // 0x0000000180CC5210-0x0000000180CC5320
	private void Update() {} // 0x0000000180CC6590-0x0000000180CC6780
	private void SetScale(float scale) {} // 0x0000000180CC6160-0x0000000180CC6240
	private void SaveCursorState() {} // 0x0000000180CC6130-0x0000000180CC6160
	private void RestoreCursorState() {} // 0x0000000180CC6100-0x0000000180CC6130
}

