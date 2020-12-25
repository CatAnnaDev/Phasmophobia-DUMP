/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class SteamVR_GazeTracker : MonoBehaviour // TypeDefIndex: 7247
{
	// Fields
	public bool isInGaze; // 0x18
	public float gazeInCutoff; // 0x30
	public float gazeOutCutoff; // 0x34
	private Transform hmdTrackedObject; // 0x38

	// Events
	public event u0927u0922u0925u0925u0920u0922u0922u091Eu091Bu0928u0921 GazeOn;
	public event u0927u0922u0925u0925u0920u0922u0922u091Eu091Bu0928u0921 GazeOff;

	// Constructors
	public SteamVR_GazeTracker() {} // 0x0000000180CC1900-0x0000000180CC1920

	// Methods
	private void Start() {} // 0x0000000180246DB0-0x0000000180246DC0
	public virtual void OnGazeOn(GazeEventArgs e) {} // 0x0000000180CC14E0-0x0000000180CC1500
	public virtual void OnGazeOff(GazeEventArgs e) {} // 0x0000000180CC14C0-0x0000000180CC14E0
	private void Update() {} // 0x0000000180CC1500-0x0000000180CC1900
}

