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

[ExecuteInEditMode] // 0x000000018011B890-0x000000018011B910
// [RequireComponent] // 0x000000018011B890-0x000000018011B910
public class SteamVR_PlayArea : MonoBehaviour // TypeDefIndex: 7289
{
	// Fields
	public float borderThickness; // 0x18
	public float wireframeHeight; // 0x1C
	public bool drawWireframeWhenSelectedOnly; // 0x20
	public bool drawInGame; // 0x21
	public Size size; // 0x24
	public Color color; // 0x28
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public Vector3[] vertices; // 0x38

	// Nested types
	public enum Size // TypeDefIndex: 7290
	{
		Calibrated = 0,
		_400x300 = 1,
		_300x225 = 2,
		_200x150 = 3
	}

	// Constructors
	public SteamVR_PlayArea() {} // 0x0000000180CC9210-0x0000000180CC9250

	// Methods
	public static bool GetBounds(Size size, ref HmdQuad_t pRect) => default; // 0x0000000180CC8D30-0x0000000180CC9090
	public void BuildMesh() {} // 0x0000000180CC7D30-0x0000000180CC8980
	private void OnDrawGizmos() {} // 0x0000000180CC90A0-0x0000000180CC90B0
	private void OnDrawGizmosSelected() {} // 0x0000000180CC9090-0x0000000180CC90A0
	public void DrawWireframe() {} // 0x0000000180CC8980-0x0000000180CC8D30
	public void OnEnable() {} // 0x0000000180CC90B0-0x0000000180CC91A0
	// [IteratorStateMachine] // 0x000000018011BC20-0x000000018011BC70
	private IEnumerator UpdateBounds() => default; // 0x0000000180CC91A0-0x0000000180CC9210
}

