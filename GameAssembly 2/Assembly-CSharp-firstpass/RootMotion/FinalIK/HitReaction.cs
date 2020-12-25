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
	public class HitReaction : OffsetModifier // TypeDefIndex: 6796
	{
		// Fields
		// [Tooltip] // 0x00000001800FBDE0-0x00000001800FBE10
		public HitPointEffector[] effectorHitPoints; // 0x30
		// [Tooltip] // 0x00000001800FBE70-0x00000001800FBEA0
		public HitPointBone[] boneHitPoints; // 0x38
	
		// Properties
		public bool inProgress { get => default; } // 0x00000001809AC950-0x00000001809ACA10 
	
		// Nested types
		[Serializable]
		public abstract class HitPoint // TypeDefIndex: 6797
		{
			// Fields
			// [Tooltip] // 0x00000001800FBF80-0x00000001800FBFB0
			public string name; // 0x10
			// [Tooltip] // 0x00000001800FC010-0x00000001800FC040
			public Collider collider; // 0x18
			[SerializeField] // 0x00000001800FC0E0-0x00000001800FC130
			// [Tooltip] // 0x00000001800FC0E0-0x00000001800FC130
			private float crossFadeTime; // 0x20
			private float length; // 0x44
			private float crossFadeSpeed; // 0x48
			private float lastTime; // 0x4C
	
			// Properties
			public bool inProgress { get; } // 0x00000001809AC200-0x00000001809AC210 
			protected float crossFader { get; private set; } // 0x00000001807681F0-0x0000000180768200 0x00000001809AC230-0x00000001809AC240
			protected float timer { get; private set; } // 0x000000018036E6C0-0x000000018036E6D0 0x0000000180523C30-0x0000000180523C40
			protected Vector3 force { get; private set; } // 0x00000001809AC1E0-0x00000001809AC200 0x00000001809AC240-0x00000001809AC250
			protected Vector3 point { get; private set; } // 0x00000001809AC210-0x00000001809AC230 0x00000001809AC250-0x00000001809AC260
	
			// Constructors
			protected HitPoint() {} // 0x00000001809AB990-0x00000001809AB9A0
	
			// Methods
			public void Hit(Vector3 force, Vector3 point) {} // 0x00000001809AC0D0-0x00000001809AC1E0
			public void Apply(IKSolverFullBodyBiped solver, float weight) {} // 0x00000001809ABF70-0x00000001809AC0D0
			protected abstract float GetLength();
			protected abstract void CrossFadeStart();
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);
		}
	
		[Serializable]
		public class HitPointEffector : HitPoint // TypeDefIndex: 6798
		{
			// Fields
			// [Tooltip] // 0x00000001800FC930-0x00000001800FC960
			public AnimationCurve offsetInForceDirection; // 0x50
			// [Tooltip] // 0x00000001800FC9A0-0x00000001800FC9D0
			public AnimationCurve offsetInUpDirection; // 0x58
			// [Tooltip] // 0x00000001800FCA50-0x00000001800FCA80
			public EffectorLink[] effectorLinks; // 0x60
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 6799
			{
				// Fields
				// [Tooltip] // 0x00000001800FCB80-0x00000001800FCBB0
				public FullBodyBipedEffector effector; // 0x10
				// [Tooltip] // 0x00000001800FCC20-0x00000001800FCC50
				public float weight; // 0x14
				private Vector3 lastValue; // 0x18
				private Vector3 current; // 0x24
	
				// Constructors
				public EffectorLink() {} // 0x00000001802466A0-0x00000001802466B0
	
				// Methods
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader) {} // 0x00000001809A8000-0x00000001809A8180
				public void CrossFadeStart() {} // 0x00000001809A8180-0x00000001809A8210
			}
	
			// Constructors
			public HitPointEffector() {} // 0x00000001809AB990-0x00000001809AB9A0
	
			// Methods
			protected override float GetLength() => default; // 0x00000001809ABA00-0x00000001809ABB90
			protected override void CrossFadeStart() {} // 0x00000001809AB9A0-0x00000001809ABA00
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight) {} // 0x00000001809ABB90-0x00000001809ABF70
		}
	
		[Serializable]
		public class HitPointBone : HitPoint // TypeDefIndex: 6800
		{
			// Fields
			// [Tooltip] // 0x00000001800FCC90-0x00000001800FCCC0
			public AnimationCurve aroundCenterOfMass; // 0x50
			// [Tooltip] // 0x00000001800FCD20-0x00000001800FCD50
			public BoneLink[] boneLinks; // 0x58
			private Rigidbody rigidbody; // 0x60
	
			// Nested types
			[Serializable]
			public class BoneLink // TypeDefIndex: 6801
			{
				// Fields
				// [Tooltip] // 0x00000001800FCD90-0x00000001800FCDC0
				public Transform bone; // 0x10
				// [Range] // 0x00000001800FCE40-0x00000001800FCEA0
				// [Tooltip] // 0x00000001800FCE40-0x00000001800FCEA0
				public float weight; // 0x18
				private Quaternion lastValue; // 0x1C
				private Quaternion current; // 0x2C
	
				// Constructors
				public BoneLink() {} // 0x00000001809A5540-0x00000001809A55C0
	
				// Methods
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader) {} // 0x00000001809A53E0-0x00000001809A5530
				public void CrossFadeStart() {} // 0x00000001809A5530-0x00000001809A5540
			}
	
			// Constructors
			public HitPointBone() {} // 0x00000001809AB990-0x00000001809AB9A0
	
			// Methods
			protected override float GetLength() => default; // 0x00000001809AB550-0x00000001809AB5F0
			protected override void CrossFadeStart() {} // 0x00000001809AB4F0-0x00000001809AB550
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight) {} // 0x00000001809AB5F0-0x00000001809AB990
		}
	
		// Constructors
		public HitReaction() {} // 0x00000001804AF900-0x00000001804AF910
	
		// Methods
		protected override void OnModifyOffset() {} // 0x00000001809AC850-0x00000001809AC950
		public void Hit(Collider collider, Vector3 force, Vector3 point) {} // 0x00000001809AC5D0-0x00000001809AC850
	}
}
