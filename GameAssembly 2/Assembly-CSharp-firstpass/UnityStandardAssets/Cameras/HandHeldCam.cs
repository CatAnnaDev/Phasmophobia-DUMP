/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.Cameras
{
	public class HandHeldCam : LookatTarget // TypeDefIndex: 6074
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_SwaySpeed; // 0x68
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_BaseSwayAmount; // 0x6C
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_TrackingSwayAmount; // 0x70
		// [Range] // 0x0000000180116490-0x00000001801164D0
		[SerializeField] // 0x0000000180116490-0x00000001801164D0
		private float m_TrackingBias; // 0x74
	
		// Constructors
		public HandHeldCam() {} // 0x0000000180831E70-0x0000000180831EA0
	
		// Methods
		protected override void FollowTarget(float deltaTime) {} // 0x0000000180831C60-0x0000000180831E70
	}
}
