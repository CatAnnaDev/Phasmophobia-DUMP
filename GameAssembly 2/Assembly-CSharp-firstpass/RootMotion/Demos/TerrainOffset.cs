/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.Demos
{
	public class TerrainOffset : MonoBehaviour // TypeDefIndex: 6594
	{
		// Fields
		public AimIK aimIK; // 0x18
		public Vector3 raycastOffset; // 0x20
		public LayerMask raycastLayers; // 0x2C
		public float min; // 0x30
		public float max; // 0x34
		public float lerpSpeed; // 0x38
		private RaycastHit hit; // 0x3C
		private Vector3 offset; // 0x68
	
		// Constructors
		public TerrainOffset() {} // 0x000000018053CCF0-0x000000018053CD60
	
		// Methods
		private void LateUpdate() {} // 0x000000018053CA00-0x000000018053CCF0
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition) => default; // 0x000000018053C740-0x000000018053CA00
	}
}
