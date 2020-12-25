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
	[Serializable]
	public abstract class IKSolver // TypeDefIndex: 6720
	{
		// Fields
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public Vector3 IKPosition; // 0x10
		// [Range] // 0x00000001800DF2F0-0x00000001800DF350
		// [Tooltip] // 0x00000001800DF2F0-0x00000001800DF350
		public float IKPositionWeight; // 0x1C
		public UpdateDelegate OnPreInitiate; // 0x28
		public UpdateDelegate OnPostInitiate; // 0x30
		public UpdateDelegate OnPreUpdate; // 0x38
		public UpdateDelegate OnPostUpdate; // 0x40
		protected bool firstInitiation; // 0x48
		[HideInInspector] // 0x00000001800D5490-0x00000001800D54C0
		[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
		protected Transform root; // 0x50
	
		// Properties
		public bool initiated { get; private set; } // 0x000000018027A6C0-0x000000018027A6D0 0x00000001802840E0-0x00000001802840F0
	
		// Nested types
		[Serializable]
		public class Point // TypeDefIndex: 6721
		{
			// Fields
			public Transform transform; // 0x10
			// [Range] // 0x00000001800D6560-0x00000001800D6580
			public float weight; // 0x18
			public Vector3 solverPosition; // 0x1C
			public Quaternion solverRotation; // 0x28
			public Vector3 defaultLocalPosition; // 0x38
			public Quaternion defaultLocalRotation; // 0x44
	
			// Constructors
			public Point() {} // 0x00000001809C2CE0-0x00000001809C2D50
	
			// Methods
			public void StoreDefaultLocalState() {} // 0x00000001809C37A0-0x00000001809C3800
			public void FixTransform() {} // 0x00000001809C3620-0x00000001809C37A0
			public void UpdateSolverPosition() {} // 0x00000001809C38A0-0x00000001809C38E0
			public void UpdateSolverLocalPosition() {} // 0x00000001809C3800-0x00000001809C3840
			public void UpdateSolverState() {} // 0x00000001809C38E0-0x00000001809C3940
			public void UpdateSolverLocalState() {} // 0x00000001809C3840-0x00000001809C38A0
		}
	
		[Serializable]
		public class Bone : Point // TypeDefIndex: 6722
		{
			// Fields
			public float length; // 0x58
			public float sqrMag; // 0x5C
			public Vector3 axis; // 0x60
			private RotationLimit _rotationLimit; // 0x70
			private bool isLimited; // 0x78
	
			// Properties
			public RotationLimit rotationLimit { get => default; set {} } // 0x00000001809A7E90-0x00000001809A7F80 0x00000001809A7F80-0x00000001809A8000
	
			// Constructors
			public Bone() {} // 0x00000001809A7C80-0x00000001809A7D70
			public Bone(Transform transform) {} // 0x00000001809A7B70-0x00000001809A7C80
			public Bone(Transform transform, float weight) {} // 0x00000001809A7D70-0x00000001809A7E90
	
			// Methods
			public void Swing(Vector3 swingTarget, float weight = 1f /* Metadata: 0x00652E49 */) {} // 0x00000001809A78C0-0x00000001809A7B70
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f /* Metadata: 0x00652E4D */) {} // 0x00000001809A72F0-0x00000001809A7650
			public void Swing2D(Vector3 swingTarget, float weight = 1f /* Metadata: 0x00652E51 */) {} // 0x00000001809A7650-0x00000001809A78C0
			public void SetToSolverPosition() {} // 0x00000001809A72B0-0x00000001809A72F0
		}
	
		[Serializable]
		public class Node : Point // TypeDefIndex: 6723
		{
			// Fields
			public float length; // 0x58
			public float effectorPositionWeight; // 0x5C
			public float effectorRotationWeight; // 0x60
			public Vector3 offset; // 0x64
	
			// Constructors
			public Node() {} // 0x00000001809C2CE0-0x00000001809C2D50
			public Node(Transform transform) {} // 0x00000001809C2DF0-0x00000001809C2E80
			public Node(Transform transform, float weight) {} // 0x00000001809C2D50-0x00000001809C2DF0
		}
	
		public delegate void UpdateDelegate(); // TypeDefIndex: 6724; 0x0000000180533490-0x0000000180533710
	
		public delegate void IterationDelegate(int i); // TypeDefIndex: 6725; 0x0000000180948F50-0x0000000180949220
	
		// Constructors
		protected IKSolver() {} // 0x00000001809C01D0-0x00000001809C01F0
	
		// Methods
		public bool IsValid() => default; // 0x00000001809BFB20-0x00000001809BFB90
		public abstract bool IsValid(ref string message);
		public void Initiate(Transform root) {} // 0x00000001809BF9D0-0x00000001809BFB20
		public void Update() {} // 0x00000001809C0160-0x00000001809C01D0
		public virtual Vector3 GetIKPosition() => default; // 0x0000000180623A70-0x0000000180623A90
		public void SetIKPosition(Vector3 position) {} // 0x000000018062E900-0x000000018062E910
		public float GetIKPositionWeight() => default; // 0x00000001803847E0-0x00000001803847F0
		public void SetIKPositionWeight(float weight) {} // 0x00000001809C00F0-0x00000001809C0160
		public Transform GetRoot() => default; // 0x00000001802505D0-0x00000001802505E0
		public abstract Point[] GetPoints();
		public abstract Point GetPoint(Transform transform);
		public abstract void FixTransforms();
		public abstract void StoreDefaultLocalState();
		protected abstract void OnInitiate();
		protected abstract void OnUpdate();
		protected void LogWarning(string message) {} // 0x00000001809BFB90-0x00000001809BFBB0
		public static Transform ContainsDuplicateBone(Bone[] bones) => default; // 0x00000001809BF7D0-0x00000001809BF920
		public static bool HierarchyIsValid(Bone[] bones) => default; // 0x00000001809BF920-0x00000001809BF9D0
		protected static float PreSolveBones(ref Bone[] bones) => default; // 0x00000001809BFBB0-0x00000001809C00F0
	}
}
