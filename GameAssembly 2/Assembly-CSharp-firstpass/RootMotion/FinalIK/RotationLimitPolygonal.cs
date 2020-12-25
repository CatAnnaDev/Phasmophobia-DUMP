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
	// [AddComponentMenu] // 0x00000001800F75A0-0x00000001800F7600
	// [HelpURL] // 0x00000001800F75A0-0x00000001800F7600
	public class RotationLimitPolygonal : RotationLimit // TypeDefIndex: 6785
	{
		// Fields
		// [Range] // 0x00000001800F6E60-0x00000001800F6E80
		public float twistLimit; // 0x38
		// [Range] // 0x00000001800F77C0-0x00000001800F77E0
		public int smoothIterations; // 0x3C
		[HideInInspector] // 0x00000001800D5490-0x00000001800D54C0
		[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
		public LimitPoint[] points; // 0x40
		[HideInInspector] // 0x00000001800D5490-0x00000001800D54C0
		[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
		public Vector3[] P; // 0x48
		[HideInInspector] // 0x00000001800D5490-0x00000001800D54C0
		[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
		public ReachCone[] reachCones; // 0x50
	
		// Nested types
		[Serializable]
		public class ReachCone // TypeDefIndex: 6786
		{
			// Fields
			public Vector3[] tetrahedron; // 0x10
			public float volume; // 0x18
			public Vector3 S; // 0x1C
			public Vector3 B; // 0x28
	
			// Properties
			public Vector3 o { get => default; } // 0x00000001807E9FC0-0x00000001807EA000 
			public Vector3 a { get => default; } // 0x00000001807E9EF0-0x00000001807E9F30 
			public Vector3 b { get => default; } // 0x00000001807E9F30-0x00000001807E9F70 
			public Vector3 c { get => default; } // 0x00000001807E9F70-0x00000001807E9FB0 
			public bool isValid { get => default; } // 0x00000001807E9FB0-0x00000001807E9FC0 
	
			// Constructors
			public ReachCone() {} // Dummy constructor
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c) {} // 0x00000001807E9D20-0x00000001807E9EF0
	
			// Methods
			public void Calculate() {} // 0x00000001807E9A40-0x00000001807E9D20
		}
	
		[Serializable]
		public class LimitPoint // TypeDefIndex: 6787
		{
			// Fields
			public Vector3 point; // 0x10
			public float tangentWeight; // 0x1C
	
			// Constructors
			public LimitPoint() {} // 0x00000001807E6BE0-0x00000001807E6C60
		}
	
		// Constructors
		public RotationLimitPolygonal() {} // 0x00000001807EF3E0-0x00000001807EF490
	
		// Methods
		// [ContextMenu] // 0x00000001800D5050-0x00000001800D5080
		private void OpenUserManual() {} // 0x00000001807EDD00-0x00000001807EDD40
		// [ContextMenu] // 0x00000001800D50F0-0x00000001800D5120
		private void OpenScriptReference() {} // 0x00000001807EDCC0-0x00000001807EDD00
		// [ContextMenu] // 0x00000001800D51F0-0x00000001800D5220
		private void SupportGroup() {} // 0x00000001807EF1A0-0x00000001807EF1E0
		// [ContextMenu] // 0x00000001800D5260-0x00000001800D5290
		private void ASThread() {} // 0x00000001807ECF40-0x00000001807ECF80
		public void SetLimitPoints(LimitPoint[] points) {} // 0x00000001807EE3E0-0x00000001807EE470
		protected override Quaternion LimitRotation(Quaternion rotation) => default; // 0x00000001807ED800-0x00000001807ED920
		private void Start() {} // 0x00000001807EEEC0-0x00000001807EF1A0
		public void ResetToDefault() {} // 0x00000001807EDED0-0x00000001807EE3E0
		public void BuildReachCones() {} // 0x00000001807ECF80-0x00000001807ED540
		private Vector3[] SmoothPoints() => default; // 0x00000001807EE470-0x00000001807EEEC0
		private float GetScalar(int k) => default; // 0x00000001807ED7B0-0x00000001807ED800
		private Vector3 PointToTangentPlane(Vector3 p, float r) => default; // 0x00000001807EDD40-0x00000001807EDED0
		private Vector3 TangentPointToSphere(Vector3 q, float r) => default; // 0x00000001807EF1E0-0x00000001807EF3E0
		private Quaternion LimitSwing(Quaternion rotation) => default; // 0x00000001807ED920-0x00000001807EDCC0
		private int GetReachCone(Vector3 L) => default; // 0x00000001807ED540-0x00000001807ED7B0
	}
}
