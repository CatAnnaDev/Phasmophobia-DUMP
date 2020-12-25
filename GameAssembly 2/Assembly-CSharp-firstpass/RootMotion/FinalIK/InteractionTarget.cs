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
	// [AddComponentMenu] // 0x00000001800F2920-0x00000001800F2980
	// [HelpURL] // 0x00000001800F2920-0x00000001800F2980
	public class InteractionTarget : MonoBehaviour // TypeDefIndex: 6767
	{
		// Fields
		// [Tooltip] // 0x00000001800F2A70-0x00000001800F2AA0
		public FullBodyBipedEffector effectorType; // 0x18
		// [Tooltip] // 0x00000001800F2B50-0x00000001800F2B80
		public Multiplier[] multipliers; // 0x20
		// [Tooltip] // 0x00000001800F2BD0-0x00000001800F2C00
		public float interactionSpeedMlp; // 0x28
		// [Tooltip] // 0x00000001800F2C30-0x00000001800F2C60
		public Transform pivot; // 0x30
		// [Tooltip] // 0x00000001800F2D20-0x00000001800F2D50
		public Vector3 twistAxis; // 0x38
		// [Tooltip] // 0x00000001800F4080-0x00000001800F40B0
		public float twistWeight; // 0x44
		// [Tooltip] // 0x00000001800F42C0-0x00000001800F42F0
		public float swingWeight; // 0x48
		// [Tooltip] // 0x00000001800F42F0-0x00000001800F4320
		public bool rotateOnce; // 0x4C
		private Quaternion defaultLocalRotation; // 0x50
		private Transform lastPivot; // 0x60
	
		// Nested types
		[Serializable]
		public class Multiplier // TypeDefIndex: 6768
		{
			// Fields
			// [Tooltip] // 0x00000001800F4A00-0x00000001800F4A30
			public InteractionObject.WeightCurve.Type curve; // 0x10
			// [Tooltip] // 0x00000001800F4AA0-0x00000001800F4AD0
			public float multiplier; // 0x14
	
			// Constructors
			public Multiplier() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		// Constructors
		public InteractionTarget() {} // 0x00000001807E64E0-0x00000001807E6560
	
		// Methods
		// [ContextMenu] // 0x00000001800EEB70-0x00000001800EEBA0
		private void OpenTutorial1() {} // 0x00000001807E5D10-0x00000001807E5D50
		// [ContextMenu] // 0x00000001800EEC60-0x00000001800EEC90
		private void OpenTutorial2() {} // 0x00000001807E5D50-0x00000001807E5D90
		// [ContextMenu] // 0x00000001800EED80-0x00000001800EEDB0
		private void OpenTutorial3() {} // 0x00000001807E5D90-0x00000001807E5DD0
		// [ContextMenu] // 0x00000001800EEEC0-0x00000001800EEEF0
		private void OpenTutorial4() {} // 0x00000001807E5DD0-0x00000001807E5E10
		// [ContextMenu] // 0x00000001800D51F0-0x00000001800D5220
		private void SupportGroup() {} // 0x00000001807E64A0-0x00000001807E64E0
		// [ContextMenu] // 0x00000001800D5260-0x00000001800D5290
		private void ASThread() {} // 0x00000001807E5C00-0x00000001807E5C40
		public float GetValue(InteractionObject.WeightCurve.Type curveType) => default; // 0x00000001807E5C40-0x00000001807E5CD0
		public void ResetRotation() {} // 0x00000001807E5E50-0x00000001807E5EE0
		public void RotateTo(Vector3 position) {} // 0x00000001807E5EE0-0x00000001807E64A0
		// [ContextMenu] // 0x00000001800D5050-0x00000001800D5080
		private void OpenUserManual() {} // 0x00000001807E5E10-0x00000001807E5E50
		// [ContextMenu] // 0x00000001800D50F0-0x00000001800D5120
		private void OpenScriptReference() {} // 0x00000001807E5CD0-0x00000001807E5D10
	}
}
