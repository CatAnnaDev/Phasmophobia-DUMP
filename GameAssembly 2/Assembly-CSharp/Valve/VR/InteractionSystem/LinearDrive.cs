/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	// [RequireComponent] // 0x000000018013B850-0x000000018013B8A0
	public class LinearDrive : MonoBehaviour // TypeDefIndex: 8385
	{
		// Fields
		public Transform startPosition; // 0x18
		public Transform endPosition; // 0x20
		public LinearMapping linearMapping; // 0x28
		public bool repositionGameObject; // 0x30
		public bool maintainMomemntum; // 0x31
		public float momemtumDampenRate; // 0x34
		private float initialMappingOffset; // 0x38
		private int numMappingChangeSamples; // 0x3C
		private float[] mappingChangeSamples; // 0x40
		private float prevMapping; // 0x48
		private float mappingChangeRate; // 0x4C
		private int sampleCount; // 0x50
	
		// Constructors
		public LinearDrive() {} // 0x0000000180FC8220-0x0000000180FC8240
	
		// Methods
		private void Awake() {} // 0x0000000180FC7790-0x0000000180FC77E0
		private void Start() {} // 0x0000000180FC7C80-0x0000000180FC7DB0
		private void HandHoverUpdate(Hand hand) {} // 0x0000000180FC7AA0-0x0000000180FC7C80
		private void CalculateMappingChangeRate() {} // 0x0000000180FC79B0-0x0000000180FC7AA0
		private void UpdateLinearMapping(Transform tr) {} // 0x0000000180FC7DB0-0x0000000180FC8000
		private float CalculateLinearMapping(Transform tr) => default; // 0x0000000180FC77E0-0x0000000180FC79B0
		private void Update() {} // 0x0000000180FC8000-0x0000000180FC8220
	}
}
