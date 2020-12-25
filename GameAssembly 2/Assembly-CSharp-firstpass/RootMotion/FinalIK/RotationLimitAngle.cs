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
	// [AddComponentMenu] // 0x00000001800F6D50-0x00000001800F6DB0
	// [HelpURL] // 0x00000001800F6D50-0x00000001800F6DB0
	public class RotationLimitAngle : RotationLimit // TypeDefIndex: 6783
	{
		// Fields
		// [Range] // 0x00000001800F6E60-0x00000001800F6E80
		public float limit; // 0x38
		// [Range] // 0x00000001800F6E60-0x00000001800F6E80
		public float twistLimit; // 0x3C
	
		// Constructors
		public RotationLimitAngle() {} // 0x00000001807EC8C0-0x00000001807EC940
	
		// Methods
		// [ContextMenu] // 0x00000001800D5050-0x00000001800D5080
		private void OpenUserManual() {} // 0x00000001807EC840-0x00000001807EC880
		// [ContextMenu] // 0x00000001800D50F0-0x00000001800D5120
		private void OpenScriptReference() {} // 0x00000001807EC800-0x00000001807EC840
		// [ContextMenu] // 0x00000001800D51F0-0x00000001800D5220
		private void SupportGroup() {} // 0x00000001807EC880-0x00000001807EC8C0
		// [ContextMenu] // 0x00000001800D5260-0x00000001800D5290
		private void ASThread() {} // 0x00000001807EC450-0x00000001807EC490
		protected override Quaternion LimitRotation(Quaternion rotation) => default; // 0x00000001807EC490-0x00000001807EC580
		private Quaternion LimitSwing(Quaternion rotation) => default; // 0x00000001807EC580-0x00000001807EC800
	}
}
