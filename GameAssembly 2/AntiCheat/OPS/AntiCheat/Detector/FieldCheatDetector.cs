/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 49: AntiCheat.dll - Assembly: AntiCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5277-5290

namespace OPS.AntiCheat.Detector
{
	public sealed class FieldCheatDetector : ADetector // TypeDefIndex: 5290
	{
		// Properties
		public static FieldCheatDetector Singleton { get; private set; } // 0x0000000180ADB120-0x0000000180ADB160 0x0000000180ADB210-0x0000000180ADB260
		public override int FalsePositiveAmount { get => default; } // 0x0000000180248DE0-0x0000000180248DF0 
	
		// Events
		public static event OnFieldCheatDetected OnFieldCheatDetected;
	
		// Constructors
		public FieldCheatDetector() {} // 0x0000000180276E90-0x0000000180276EA0
	
		// Methods
		private void Awake() {} // 0x0000000180ADAEF0-0x0000000180ADAF40
		public static void FieldCheatDetected() {} // 0x0000000180ADAF40-0x0000000180ADAFD0
		protected override void OnCheatDetected() {} // 0x0000000180ADAFD0-0x0000000180ADB020
		private void OnDestroy() {} // 0x0000000180ADB020-0x0000000180ADB070
	}
}
