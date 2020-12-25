/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.Cameras
{
	public class ProtectCameraFromWallClip : MonoBehaviour // TypeDefIndex: 6077
	{
		// Fields
		public float clipMoveTime; // 0x18
		public float returnTime; // 0x1C
		public float sphereCastRadius; // 0x20
		public bool visualiseInEditor; // 0x24
		public float closestDistance; // 0x28
		public string dontClipTag; // 0x30
		private Transform m_Cam; // 0x38
		private Transform m_Pivot; // 0x40
		private float m_OriginalDist; // 0x48
		private float m_MoveVelocity; // 0x4C
		private float m_CurrentDist; // 0x50
		private Ray m_Ray; // 0x54
		private RaycastHit[] m_Hits; // 0x70
		private RayHitComparer m_RayHitComparer; // 0x78
	
		// Properties
		public bool protecting { get; private set; } // 0x0000000180482A30-0x0000000180482A40 0x0000000180482A90-0x0000000180482AA0
	
		// Nested types
		public class RayHitComparer : IComparer // TypeDefIndex: 6078
		{
			// Constructors
			public RayHitComparer() {} // 0x00000001802466A0-0x00000001802466B0
	
			// Methods
			public int Compare(object x, object y) => default; // 0x00000001808354B0-0x00000001808355E0
		}
	
		// Constructors
		public ProtectCameraFromWallClip() {} // 0x0000000180835330-0x00000001808353A0
	
		// Methods
		private void Start() {} // 0x0000000180835230-0x0000000180835330
		private void LateUpdate() {} // 0x0000000180834940-0x0000000180835230
	}
}
