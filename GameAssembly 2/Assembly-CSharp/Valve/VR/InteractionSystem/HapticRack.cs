/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	// [RequireComponent] // 0x00000001801392F0-0x0000000180139340
	public class HapticRack : MonoBehaviour // TypeDefIndex: 8367
	{
		// Fields
		// [Tooltip] // 0x00000001801393E0-0x0000000180139410
		public LinearMapping linearMapping; // 0x18
		// [Tooltip] // 0x0000000180139720-0x0000000180139750
		public int teethCount; // 0x20
		// [Tooltip] // 0x0000000180139810-0x0000000180139840
		public int minimumPulseDuration; // 0x24
		// [Tooltip] // 0x00000001801398F0-0x0000000180139920
		public int maximumPulseDuration; // 0x28
		// [Tooltip] // 0x0000000180139950-0x0000000180139980
		public UnityEvent onPulse; // 0x30
		private Hand hand; // 0x38
		private int previousToothIndex; // 0x40
	
		// Constructors
		public HapticRack() {} // 0x0000000180FC4CF0-0x0000000180FC4D20
	
		// Methods
		private void Awake() {} // 0x0000000180FC4A10-0x0000000180FC4AA0
		private void OnHandHoverBegin(Hand hand) {} // 0x0000000180278400-0x0000000180278410
		private void OnHandHoverEnd(Hand hand) {} // 0x0000000180FC4AA0-0x0000000180FC4AC0
		private void Update() {} // 0x0000000180FC4B90-0x0000000180FC4CF0
		private void Pulse() {} // 0x0000000180FC4AC0-0x0000000180FC4B90
	}
}
