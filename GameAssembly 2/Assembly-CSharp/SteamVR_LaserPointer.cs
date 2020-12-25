/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class SteamVR_LaserPointer : MonoBehaviour // TypeDefIndex: 7250
{
	// Fields
	public bool active; // 0x18
	public Color color; // 0x1C
	public float thickness; // 0x2C
	public GameObject holder; // 0x30
	public GameObject pointer; // 0x38
	private bool isActive; // 0x40
	public bool addRigidBody; // 0x41
	public Transform reference; // 0x48
	private Transform previousContact; // 0x60

	// Events
	public event u091Bu091Cu091Du091Du0924u0922u0927u0929u0926u0925u0926 PointerIn;
	public event u091Bu091Cu091Du091Du0924u0922u0927u0929u0926u0925u0926 PointerOut;

	// Constructors
	public SteamVR_LaserPointer() {} // 0x0000000180CC3C50-0x0000000180CC3C70

	// Methods
	private void Start() {} // 0x0000000180CC3210-0x0000000180CC3670
	public virtual void OnPointerIn(PointerEventArgs e) {} // 0x0000000180CC3190-0x0000000180CC31D0
	public virtual void OnPointerOut(PointerEventArgs e) {} // 0x0000000180CC31D0-0x0000000180CC3210
	private void Update() {} // 0x0000000180CC3670-0x0000000180CC3C50
}

