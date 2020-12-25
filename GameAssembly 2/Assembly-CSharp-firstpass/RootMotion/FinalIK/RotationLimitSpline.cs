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
	// [AddComponentMenu] // 0x00000001800F80E0-0x00000001800F8140
	// [HelpURL] // 0x00000001800F80E0-0x00000001800F8140
	public class RotationLimitSpline : RotationLimit // TypeDefIndex: 6788
	{
		// Fields
		// [Range] // 0x00000001800F6E60-0x00000001800F6E80
		public float twistLimit; // 0x38
		[HideInInspector] // 0x00000001800D5490-0x00000001800D54C0
		[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
		public AnimationCurve spline; // 0x40
	
		// Constructors
		public RotationLimitSpline() {} // 0x00000001807EFB60-0x00000001807EFBE0
	
		// Methods
		// [ContextMenu] // 0x00000001800D5050-0x00000001800D5080
		private void OpenUserManual() {} // 0x00000001807EFAC0-0x00000001807EFB00
		// [ContextMenu] // 0x00000001800D50F0-0x00000001800D5120
		private void OpenScriptReference() {} // 0x00000001807EFA80-0x00000001807EFAC0
		// [ContextMenu] // 0x00000001800D51F0-0x00000001800D5220
		private void SupportGroup() {} // 0x00000001807EFB20-0x00000001807EFB60
		// [ContextMenu] // 0x00000001800D5260-0x00000001800D5290
		private void ASThread() {} // 0x00000001807EF490-0x00000001807EF4D0
		public void SetSpline(Keyframe[] keyframes) {} // 0x00000001807EFB00-0x00000001807EFB20
		protected override Quaternion LimitRotation(Quaternion rotation) => default; // 0x00000001807EF4D0-0x00000001807EF5C0
		public Quaternion LimitSwing(Quaternion rotation) => default; // 0x00000001807EF5C0-0x00000001807EFA80
	}
}
