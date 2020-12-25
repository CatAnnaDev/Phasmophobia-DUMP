/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.Utility
{
	[Serializable]
	public class CurveControlledBob // TypeDefIndex: 5857
	{
		// Fields
		public float HorizontalBobRange; // 0x10
		public float VerticalBobRange; // 0x14
		public AnimationCurve Bobcurve; // 0x18
		public float VerticaltoHorizontalRatio; // 0x20
		private float m_CyclePositionX; // 0x24
		private float m_CyclePositionY; // 0x28
		private float m_BobBaseInterval; // 0x2C
		private Vector3 m_OriginalCameraPosition; // 0x30
		private float m_Time; // 0x3C
	
		// Constructors
		public CurveControlledBob() {} // 0x0000000180A37FF0-0x0000000180A38290
	
		// Methods
		public void Setup(Camera camera, float bobBaseInterval) {} // 0x0000000180A37F20-0x0000000180A37FF0
		public Vector3 DoHeadBob(float speed) => default; // 0x0000000180A37DC0-0x0000000180A37F20
	}
}
