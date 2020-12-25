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
	public class TwistRelaxer : MonoBehaviour // TypeDefIndex: 6754
	{
		// Fields
		public IK ik; // 0x18
		// [Range] // 0x00000001800EDC80-0x00000001800EDCE0
		// [Tooltip] // 0x00000001800EDC80-0x00000001800EDCE0
		public float weight; // 0x20
		// [Range] // 0x00000001800EDDD0-0x00000001800EDE30
		// [Tooltip] // 0x00000001800EDDD0-0x00000001800EDE30
		public float parentChildCrossfade; // 0x24
		// [Range] // 0x00000001800EDEA0-0x00000001800EDF00
		// [Tooltip] // 0x00000001800EDEA0-0x00000001800EDF00
		public float twistAngleOffset; // 0x28
		private Vector3 twistAxis; // 0x2C
		private Vector3 axis; // 0x38
		private Vector3 axisRelativeToParentDefault; // 0x44
		private Vector3 axisRelativeToChildDefault; // 0x50
		private Transform parent; // 0x60
		private Transform child; // 0x68
	
		// Constructors
		public TwistRelaxer() {} // 0x00000001807D56B0-0x00000001807D5750
	
		// Methods
		public void Relax() {} // 0x00000001807D4D20-0x00000001807D51A0
		private void Start() {} // 0x00000001807D51A0-0x00000001807D56B0
		private void OnPostUpdate() {} // 0x00000001807D4CB0-0x00000001807D4D20
		private void LateUpdate() {} // 0x00000001807D4B20-0x00000001807D4B90
		private void OnDestroy() {} // 0x00000001807D4B90-0x00000001807D4CB0
	}
}
