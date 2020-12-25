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
	public class HandPoser : Poser // TypeDefIndex: 6776
	{
		// Fields
		private Transform _poseRoot; // 0x50
		private Transform[] children; // 0x58
		private Transform[] poseChildren; // 0x60
		private Vector3[] defaultLocalPositions; // 0x68
		private Quaternion[] defaultLocalRotations; // 0x70
	
		// Constructors
		public HandPoser() {} // 0x0000000180532030-0x0000000180532040
	
		// Methods
		public override void AutoMapping() {} // 0x00000001809AAC30-0x00000001809AACE0
		protected override void InitiatePoser() {} // 0x00000001809AAE30-0x00000001809AAE90
		protected override void FixPoserTransforms() {} // 0x00000001809AACE0-0x00000001809AAE30
		protected override void UpdatePoser() {} // 0x00000001809AB060-0x00000001809AB4F0
		private void StoreDefaultState() {} // 0x00000001809AAE90-0x00000001809AB060
	}
}
