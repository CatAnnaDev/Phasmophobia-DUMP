/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.FinalIK
{
	// [AddComponentMenu] // 0x00000001800F70E0-0x00000001800F7140
	// [HelpURL] // 0x00000001800F70E0-0x00000001800F7140
	public class RotationLimitHinge : RotationLimit // TypeDefIndex: 6784
	{
		// Fields
		public bool useLimits; // 0x38
		public float min; // 0x3C
		public float max; // 0x40
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public float zeroAxisDisplayOffset; // 0x44
		private Quaternion lastRotation; // 0x48
		private float lastAngle; // 0x58
	
		// Constructors
		public RotationLimitHinge() {} // 0x00000001807ECE70-0x00000001807ECF40
	
		// Methods
		// [ContextMenu] // 0x00000001800D5050-0x00000001800D5080
		private void OpenUserManual() {} // 0x00000001807ECDF0-0x00000001807ECE30
		// [ContextMenu] // 0x00000001800D50F0-0x00000001800D5120
		private void OpenScriptReference() {} // 0x00000001807ECDB0-0x00000001807ECDF0
		// [ContextMenu] // 0x00000001800D51F0-0x00000001800D5220
		private void SupportGroup() {} // 0x00000001807ECE30-0x00000001807ECE70
		// [ContextMenu] // 0x00000001800D5260-0x00000001800D5290
		private void ASThread() {} // 0x00000001807EC940-0x00000001807EC980
		protected override Quaternion LimitRotation(Quaternion rotation) => default; // 0x00000001807ECD60-0x00000001807ECDB0
		private Quaternion LimitHinge(Quaternion rotation) => default; // 0x00000001807EC980-0x00000001807ECD60
	}
}
