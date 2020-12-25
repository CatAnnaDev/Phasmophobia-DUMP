/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class SteamVR_ExternalCamera : MonoBehaviour // TypeDefIndex: 7278
{
	// Fields
	public Config config; // 0x18
	public string configPath; // 0x68
	private FileSystemWatcher watcher; // 0x70
	private Camera cam; // 0x78
	private Transform target; // 0x80
	private GameObject clipQuad; // 0x88
	private Material clipMaterial; // 0x90
	private Material colorMat; // 0x98
	private Material alphaMat; // 0xA0
	private Camera[] cameras; // 0xA8
	private Rect[] cameraRects; // 0xB0
	private float sceneResolutionScale; // 0xB8

	// Nested types
	[Serializable]
	public struct Config // TypeDefIndex: 7279
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public float rx; // 0x0C
		public float ry; // 0x10
		public float rz; // 0x14
		public float fov; // 0x18
		public float near; // 0x1C
		public float far; // 0x20
		public float sceneResolutionScale; // 0x24
		public float frameSkip; // 0x28
		public float nearOffset; // 0x2C
		public float farOffset; // 0x30
		public float hmdOffset; // 0x34
		public float r; // 0x38
		public float g; // 0x3C
		public float b; // 0x40
		public float a; // 0x44
		public bool disableStandardAssets; // 0x48
	}

	// Constructors
	public SteamVR_ExternalCamera() {} // 0x0000000180276E90-0x0000000180276EA0

	// Methods
	public void ReadConfig() {} // 0x0000000180CBEAC0-0x0000000180CBF2C0
	private void OnChanged(object source, FileSystemEventArgs e) {} // 0x0000000180CBE620-0x0000000180CBE630
	public void AttachToCamera(SteamVR_Camera vrcam) {} // 0x0000000180CBDBD0-0x0000000180CBE260
	public float GetTargetDistance() => default; // 0x0000000180CBE260-0x0000000180CBE620
	public void RenderNear() {} // 0x0000000180CBF3F0-0x0000000180CBFC90
	public void RenderFar() {} // 0x0000000180CBF2C0-0x0000000180CBF3F0
	private void OnGUI() {} // 0x0000000180246DB0-0x0000000180246DC0
	private void OnEnable() {} // 0x0000000180CBE7C0-0x0000000180CBEAC0
	private void OnDisable() {} // 0x0000000180CBE630-0x0000000180CBE7C0
}

