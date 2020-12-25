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
	public class HitReactionVRIK : OffsetModifierVRIK // TypeDefIndex: 6802
	{
		// Fields
		public AnimationCurve[] offsetCurves; // 0x30
		// [Tooltip] // 0x00000001800FBDE0-0x00000001800FBE10
		public PositionOffset[] positionOffsets; // 0x38
		// [Tooltip] // 0x00000001800FBE70-0x00000001800FBEA0
		public RotationOffset[] rotationOffsets; // 0x40
	
		// Nested types
		[Serializable]
		public abstract class Offset // TypeDefIndex: 6803
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
			protected float crossFader { get; private set; } // 0x00000001807681F0-0x0000000180768200 0x00000001809AC230-0x00000001809AC240
			protected float timer { get; private set; } // 0x000000018036E6C0-0x000000018036E6D0 0x0000000180523C30-0x0000000180523C40
			protected Vector3 force { get; private set; } // 0x00000001809AC1E0-0x00000001809AC200 0x00000001809AC240-0x00000001809AC250
			protected Vector3 point { get; private set; } // 0x00000001809AC210-0x00000001809AC230 0x00000001809AC250-0x00000001809AC260
	
			// Constructors
			protected Offset() {} // 0x00000001809AB990-0x00000001809AB9A0
	
			// Methods
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point) {} // 0x00000001809C3000-0x00000001809C3120
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight) {} // 0x00000001809C2E80-0x00000001809C3000
			protected abstract float GetLength(AnimationCurve[] curves);
			protected abstract void CrossFadeStart();
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);
		}
	
		[Serializable]
		public class PositionOffset : Offset // TypeDefIndex: 6804
		{
			// Fields
			// [Tooltip] // 0x00000001800FC930-0x00000001800FC960
			public int forceDirCurveIndex; // 0x50
			// [Tooltip] // 0x00000001800FC9A0-0x00000001800FC9D0
			public int upDirCurveIndex; // 0x54
			// [Tooltip] // 0x00000001800FF230-0x00000001800FF260
			public PositionOffsetLink[] offsetLinks; // 0x58
	
			// Nested types
			[Serializable]
			public class PositionOffsetLink // TypeDefIndex: 6805
			{
				// Fields
				// [Tooltip] // 0x00000001800FCB80-0x00000001800FCBB0
				public IKSolverVR.PositionOffset positionOffset; // 0x10
				// [Tooltip] // 0x00000001800FCC20-0x00000001800FCC50
				public float weight; // 0x14
				private Vector3 lastValue; // 0x18
				private Vector3 current; // 0x24
	
				// Constructors
				public PositionOffsetLink() {} // 0x00000001802466A0-0x00000001802466B0
	
				// Methods
				public void Apply(VRIK ik, Vector3 offset, float crossFader) {} // 0x00000001809C3940-0x00000001809C3A90
				public void CrossFadeStart() {} // 0x00000001809A8180-0x00000001809A8210
			}
	
			// Constructors
			public PositionOffset() {} // 0x00000001809C4100-0x00000001809C4120
	
			// Methods
			protected override float GetLength(AnimationCurve[] curves) => default; // 0x00000001809C3AF0-0x00000001809C3D50
			protected override void CrossFadeStart() {} // 0x00000001809C3A90-0x00000001809C3AF0
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight) {} // 0x00000001809C3D50-0x00000001809C4100
		}
	
		[Serializable]
		public class RotationOffset : Offset // TypeDefIndex: 6806
		{
			// Fields
			// [Tooltip] // 0x00000001800FCC90-0x00000001800FCCC0
			public int curveIndex; // 0x50
			// [Tooltip] // 0x00000001800FCD20-0x00000001800FCD50
			public RotationOffsetLink[] offsetLinks; // 0x58
			private Rigidbody rigidbody; // 0x60
	
			// Nested types
			[Serializable]
			public class RotationOffsetLink // TypeDefIndex: 6807
			{
				// Fields
				// [Tooltip] // 0x00000001800FCD90-0x00000001800FCDC0
				public IKSolverVR.RotationOffset rotationOffset; // 0x10
				// [Range] // 0x00000001800FCE40-0x00000001800FCEA0
				// [Tooltip] // 0x00000001800FCE40-0x00000001800FCEA0
				public float weight; // 0x14
				private Quaternion lastValue; // 0x18
				private Quaternion current; // 0x28
	
				// Constructors
				public RotationOffsetLink() {} // 0x00000001809C4250-0x00000001809C42D0
	
				// Methods
				public void Apply(VRIK ik, Quaternion offset, float crossFader) {} // 0x00000001809C4120-0x00000001809C4240
				public void CrossFadeStart() {} // 0x00000001809C4240-0x00000001809C4250
			}
	
			// Constructors
			public RotationOffset() {} // 0x00000001809AB990-0x00000001809AB9A0
	
			// Methods
			protected override float GetLength(AnimationCurve[] curves) => default; // 0x00000001809C4330-0x00000001809C4450
			protected override void CrossFadeStart() {} // 0x00000001809C42D0-0x00000001809C4330
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight) {} // 0x00000001809C4450-0x00000001809C4860
		}
	
		// Constructors
		public HitReactionVRIK() {} // 0x00000001804AF900-0x00000001804AF910
	
		// Methods
		protected override void OnModifyOffset() {} // 0x00000001809AC4E0-0x00000001809AC5D0
		public void Hit(Collider collider, Vector3 force, Vector3 point) {} // 0x00000001809AC260-0x00000001809AC4E0
	}
}
