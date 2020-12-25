/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

// [RequireComponent] // 0x0000000180118450-0x00000001801184A0
public class SteamVR_Camera : MonoBehaviour // TypeDefIndex: 7259
{
	// Fields
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Transform _head; // 0x18
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Transform _ears; // 0x28
	public bool wireframe; // 0x30
	private static Hashtable values; // 0x00
	private const string eyeSuffix = " (eye)"; // Metadata: 0x006533CF
	private const string earsSuffix = " (ears)"; // Metadata: 0x006533D9
	private const string headSuffix = " (head)"; // Metadata: 0x006533E4
	private const string originSuffix = " (origin)"; // Metadata: 0x006533EF

	// Properties
	public Transform head { get => default; } // 0x0000000180246BC0-0x0000000180246BD0 
	public Transform offset { get => default; } // 0x0000000180246BC0-0x0000000180246BD0 
	public Transform origin { get => default; } // 0x0000000180CBAB90-0x0000000180CBABB0 
	public Camera camera { get; private set; } // 0x0000000180246FE0-0x0000000180246FF0 0x0000000180249080-0x0000000180249090
	public Transform ears { get => default; } // 0x00000001802470A0-0x00000001802470B0 
	public static float sceneResolutionScale { get => default; set {} } // 0x0000000180CBABB0-0x0000000180CBABC0 0x0000000180CBABC0-0x0000000180CBABD0
	public string baseName { get => default; } // 0x0000000180CBAAE0-0x0000000180CBAB90 

	// Constructors
	public SteamVR_Camera() {} // 0x0000000180276E90-0x0000000180276EA0

	// Methods
	public Ray GetRay() => default; // 0x0000000180CBA540-0x0000000180CBA5F0
	private void OnDisable() {} // 0x0000000180CBA5F0-0x0000000180CBA690
	private void OnEnable() {} // 0x0000000180CBA690-0x0000000180CBAAE0
	private void Awake() {} // 0x0000000180CB9160-0x0000000180CB91C0
	public void ForceLast() {} // 0x0000000180CB9ED0-0x0000000180CBA540
	public void Expand() {} // 0x0000000180CB9600-0x0000000180CB9ED0
	public void Collapse() {} // 0x0000000180CB91C0-0x0000000180CB9600
}

