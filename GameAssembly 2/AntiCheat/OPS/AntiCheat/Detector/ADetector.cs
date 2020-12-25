/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 49: AntiCheat.dll - Assembly: AntiCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5277-5290

namespace OPS.AntiCheat.Detector
{
	public abstract class ADetector : MonoBehaviour // TypeDefIndex: 5288
	{
		// Fields
		private int cheatDetectedAmount; // 0x18
		private bool cheatDetected; // 0x1C
	
		// Properties
		public abstract int FalsePositiveAmount { get; }
		public bool CheatDetected { get; protected set; } // 0x0000000180568740-0x0000000180568750 0x0000000180ADAE90-0x0000000180ADAEF0
	
		// Constructors
		protected ADetector() {} // 0x0000000180276E90-0x0000000180276EA0
	
		// Methods
		protected virtual void OnCheatDetected() {} // 0x0000000180246DB0-0x0000000180246DC0
	}
}
