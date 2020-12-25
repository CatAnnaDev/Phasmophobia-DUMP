/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverVR : IKSolver // TypeDefIndex: 6743
	{
		// Fields
		private Transform[] solverTransforms; // 0x58
		private bool hasChest; // 0x60
		private bool hasNeck; // 0x61
		private bool hasShoulders; // 0x62
		private bool hasToes; // 0x63
		private Vector3[] readPositions; // 0x68
		private Quaternion[] readRotations; // 0x70
		private Vector3[] solvedPositions; // 0x78
		private Quaternion[] solvedRotations; // 0x80
		private Quaternion[] defaultLocalRotations; // 0x88
		private Vector3[] defaultLocalPositions; // 0x90
		private Vector3 rootV; // 0x98
		private Vector3 rootVelocity; // 0xA4
		private Vector3 bodyOffset; // 0xB0
		private int supportLegIndex; // 0xBC
		// [Tooltip] // 0x00000001800E0150-0x00000001800E0180
		public bool plantFeet; // 0xC0
		// [Tooltip] // 0x00000001800E0450-0x00000001800E0480
		public Spine spine; // 0xD0
		// [Tooltip] // 0x00000001800E18A0-0x00000001800E18D0
		public Arm leftArm; // 0xD8
		// [Tooltip] // 0x00000001800E1990-0x00000001800E19C0
		public Arm rightArm; // 0xE0
		// [Tooltip] // 0x00000001800E1AC0-0x00000001800E1AF0
		public Leg leftLeg; // 0xE8
		// [Tooltip] // 0x00000001800E1C50-0x00000001800E1C80
		public Leg rightLeg; // 0xF0
		// [Tooltip] // 0x00000001800E1D10-0x00000001800E1D40
		public Locomotion locomotion; // 0xF8
		private Leg[] legs; // 0x100
		private Arm[] arms; // 0x108
		private Vector3 headPosition; // 0x110
		private Vector3 headDeltaPosition; // 0x11C
		private Vector3 raycastOriginPelvis; // 0x128
		private Vector3 lastOffset; // 0x134
		private Vector3 debugPos1; // 0x140
		private Vector3 debugPos2; // 0x14C
		private Vector3 debugPos3; // 0x158
		private Vector3 debugPos4; // 0x164
	
		// Properties
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public VirtualBone rootBone { get; private set; } // 0x00000001806A1150-0x00000001806A1160 0x00000001806F9D30-0x00000001806F9D40
	
		// Nested types
		[Serializable]
		public class Arm : BodyPart // TypeDefIndex: 6744
		{
			// Fields
			// [Tooltip] // 0x00000001800E1F30-0x00000001800E1F60
			public Transform target; // 0x48
			// [Tooltip] // 0x00000001800E2060-0x00000001800E2090
			public Transform bendGoal; // 0x50
			// [Range] // 0x00000001800E2180-0x00000001800E21E0
			// [Tooltip] // 0x00000001800E2180-0x00000001800E21E0
			public float positionWeight; // 0x58
			// [Range] // 0x00000001800E2290-0x00000001800E22F0
			// [Tooltip] // 0x00000001800E2290-0x00000001800E22F0
			public float rotationWeight; // 0x5C
			// [Tooltip] // 0x00000001800E23F0-0x00000001800E2420
			public ShoulderRotationMode shoulderRotationMode; // 0x60
			// [Range] // 0x00000001800E24A0-0x00000001800E2500
			// [Tooltip] // 0x00000001800E24A0-0x00000001800E2500
			public float shoulderRotationWeight; // 0x64
			// [Range] // 0x00000001800E26C0-0x00000001800E2720
			// [Tooltip] // 0x00000001800E26C0-0x00000001800E2720
			public float bendGoalWeight; // 0x68
			// [Range] // 0x00000001800E27D0-0x00000001800E2830
			// [Tooltip] // 0x00000001800E27D0-0x00000001800E2830
			public float swivelOffset; // 0x6C
			// [Tooltip] // 0x00000001800E2860-0x00000001800E2890
			public Vector3 wristToPalmAxis; // 0x70
			// [Tooltip] // 0x00000001800E28E0-0x00000001800E2910
			public Vector3 palmToThumbAxis; // 0x7C
			// [Range] // 0x00000001800E2910-0x00000001800E2970
			// [Tooltip] // 0x00000001800E2910-0x00000001800E2970
			public float armLengthMlp; // 0x88
			// [Tooltip] // 0x00000001800E3C60-0x00000001800E3C90
			public AnimationCurve stretchCurve; // 0x90
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Vector3 IKPosition; // 0x98
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Quaternion IKRotation; // 0xA4
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Vector3 bendDirection; // 0xB4
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Vector3 handPositionOffset; // 0xC0
			private bool hasShoulder; // 0xE8
			private Vector3 chestForwardAxis; // 0xEC
			private Vector3 chestUpAxis; // 0xF8
			private Quaternion chestRotation; // 0x104
			private Vector3 chestForward; // 0x114
			private Vector3 chestUp; // 0x120
			private Quaternion forearmRelToUpperArm; // 0x12C
			private const float yawOffsetAngle = 45f; // Metadata: 0x00652EBD
			private const float pitchOffsetAngle = -30f; // Metadata: 0x00652EC1
	
			// Properties
			public Vector3 position { get; private set; } // 0x00000001809E1B40-0x00000001809E1B60 0x00000001809E1BF0-0x00000001809E1C10
			public Quaternion rotation { get; private set; } // 0x00000001809E1B60-0x00000001809E1B70 0x00000001809E1C10-0x00000001809E1C20
			private VirtualBone shoulder { get => default; } // 0x00000001809E1B70-0x00000001809E1BB0 
			private VirtualBone upperArm { get => default; } // 0x00000001809E1BB0-0x00000001809E1BF0 
			private VirtualBone forearm { get => default; } // 0x00000001809E1AC0-0x00000001809E1B00 
			private VirtualBone hand { get => default; } // 0x00000001809E1B00-0x00000001809E1B40 
	
			// Nested types
			[Serializable]
			public enum ShoulderRotationMode // TypeDefIndex: 6745
			{
				YawPitch = 0,
				FromTo = 1
			}
	
			// Constructors
			public Arm() {} // 0x00000001809E1990-0x00000001809E1AC0
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index) {} // 0x00000001809DDFF0-0x00000001809DEB10
			public override void PreSolve() {} // 0x00000001809DEB10-0x00000001809DEE10
			public override void ApplyOffsets() {} // 0x00000001809DD700-0x00000001809DD7D0
			private void Stretching() {} // 0x00000001809E0D80-0x00000001809E14A0
			public void Solve(bool isLeft) {} // 0x00000001809DEE80-0x00000001809E0D80
			public override void ResetOffsets() {} // 0x00000001809DEE10-0x00000001809DEE80
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations) {} // 0x00000001809E15E0-0x00000001809E1990
			private float DamperValue(float value, float min, float max, float weight = 1f /* Metadata: 0x00652EB9 */) => default; // 0x00000001809DD7D0-0x00000001809DD8D0
			private Vector3 GetBendNormal(Vector3 dir) => default; // 0x00000001809DD8D0-0x00000001809DDFF0
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color) {} // 0x00000001809E14A0-0x00000001809E15E0
		}
	
		[Serializable]
		public abstract class BodyPart // TypeDefIndex: 6746
		{
			// Fields
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public VirtualBone[] bones; // 0x18
			protected bool initiated; // 0x20
			protected Vector3 rootPosition; // 0x24
			protected Quaternion rootRotation; // 0x30
			protected int index; // 0x40
	
			// Properties
			public float sqrMag { get; private set; } // 0x00000001803847C0-0x00000001803847D0 0x0000000180384800-0x0000000180384810
			public float mag { get; private set; } // 0x000000018036CBE0-0x000000018036CBF0 0x00000001803847F0-0x0000000180384800
	
			// Constructors
			protected BodyPart() {} // 0x00000001809E2900-0x00000001809E2990
	
			// Methods
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);
			public abstract void PreSolve();
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);
			public abstract void ApplyOffsets();
			public abstract void ResetOffsets();
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index) {} // 0x00000001809E1EC0-0x00000001809E1FC0
			public void MovePosition(Vector3 position) {} // 0x00000001809E1C20-0x00000001809E1DF0
			public void MoveRotation(Quaternion rotation) {} // 0x00000001809E1DF0-0x00000001809E1EC0
			public void Translate(Vector3 position, Quaternion rotation) {} // 0x00000001809E2370-0x00000001809E2600
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot) {} // 0x00000001809E2160-0x00000001809E2370
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f /* Metadata: 0x00652ECD */) {} // 0x00000001809E1FC0-0x00000001809E2160
			public void Visualize(Color color) {} // 0x00000001809E2600-0x00000001809E2770
			public void Visualize() {} // 0x00000001809E2770-0x00000001809E2900
		}
	
		[Serializable]
		public class Footstep // TypeDefIndex: 6747
		{
			// Fields
			public float stepSpeed; // 0x10
			public Vector3 characterSpaceOffset; // 0x14
			public Vector3 position; // 0x20
			public Quaternion rotation; // 0x2C
			public Quaternion stepToRootRot; // 0x3C
			public bool isSupportLeg; // 0x4C
			public Vector3 stepFrom; // 0x54
			public Vector3 stepTo; // 0x60
			public Quaternion stepFromRot; // 0x6C
			public Quaternion stepToRot; // 0x7C
			private Quaternion footRelativeToRoot; // 0x8C
			private float supportLegW; // 0x9C
			private float supportLegWV; // 0xA0
	
			// Properties
			public bool isStepping { get => default; } // 0x00000001809E3340-0x00000001809E3350 
			public float stepProgress { get; private set; } // 0x0000000180274990-0x00000001802749A0 0x0000000180274EE0-0x0000000180274EF0
	
			// Constructors
			public Footstep() {} // Dummy constructor
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset) {} // 0x00000001809E3170-0x00000001809E3340
	
			// Methods
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation) {} // 0x00000001809E2990-0x00000001809E2A90
			public void StepTo(Vector3 p, Quaternion rootRotation) {} // 0x00000001809E2A90-0x00000001809E2B70
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed) {} // 0x00000001809E2D70-0x00000001809E2F30
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed) {} // 0x00000001809E2B70-0x00000001809E2D70
			public void Update(InterpolationMode interpolation, UnityEvent onStep) {} // 0x00000001809E2F30-0x00000001809E3170
		}
	
		[Serializable]
		public class Leg : BodyPart // TypeDefIndex: 6748
		{
			// Fields
			// [Tooltip] // 0x00000001800E47C0-0x00000001800E47F0
			public Transform target; // 0x48
			// [Tooltip] // 0x00000001800E47F0-0x00000001800E4820
			public Transform bendGoal; // 0x50
			// [Range] // 0x00000001800E48F0-0x00000001800E4950
			// [Tooltip] // 0x00000001800E48F0-0x00000001800E4950
			public float positionWeight; // 0x58
			// [Range] // 0x00000001800E4AC0-0x00000001800E4B20
			// [Tooltip] // 0x00000001800E4AC0-0x00000001800E4B20
			public float rotationWeight; // 0x5C
			// [Range] // 0x00000001800E4D40-0x00000001800E4DA0
			// [Tooltip] // 0x00000001800E4D40-0x00000001800E4DA0
			public float bendGoalWeight; // 0x60
			// [Range] // 0x00000001800E4FF0-0x00000001800E5050
			// [Tooltip] // 0x00000001800E4FF0-0x00000001800E5050
			public float swivelOffset; // 0x64
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Vector3 IKPosition; // 0x68
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Quaternion IKRotation; // 0x74
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Vector3 footPositionOffset; // 0x84
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Vector3 heelPositionOffset; // 0x90
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Quaternion footRotationOffset; // 0x9C
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public float currentMag; // 0xAC
			private Vector3 footPosition; // 0xDC
			private Quaternion footRotation; // 0xE8
			private Vector3 bendNormal; // 0xF8
			private Quaternion calfRelToThigh; // 0x104
	
			// Properties
			public Vector3 position { get; private set; } // 0x00000001809FA860-0x00000001809FA880 0x00000001809FA8C0-0x00000001809FA8E0
			public Quaternion rotation { get; private set; } // 0x00000001809FA880-0x00000001809FA890 0x00000001809FA8E0-0x00000001809FA8F0
			public bool hasToes { get; private set; } // 0x00000001809FA810-0x00000001809FA820 0x00000001809FA8B0-0x00000001809FA8C0
			public VirtualBone thigh { get => default; } // 0x00000001809E1B70-0x00000001809E1BB0 
			private VirtualBone calf { get => default; } // 0x00000001809E1BB0-0x00000001809E1BF0 
			private VirtualBone foot { get => default; } // 0x00000001809E1AC0-0x00000001809E1B00 
			private VirtualBone toes { get => default; } // 0x00000001809E1B00-0x00000001809E1B40 
			public VirtualBone lastBone { get => default; } // 0x00000001809FA820-0x00000001809FA860 
			public Vector3 thighRelativeToPelvis { get; private set; } // 0x00000001809FA890-0x00000001809FA8B0 0x00000001809FA8F0-0x00000001809FA910
	
			// Constructors
			public Leg() {} // 0x00000001809FA760-0x00000001809FA810
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index) {} // 0x00000001809F90A0-0x00000001809F99E0
			public override void PreSolve() {} // 0x00000001809F99E0-0x00000001809F9FB0
			public override void ApplyOffsets() {} // 0x00000001809F8480-0x00000001809F8CB0
			private void ApplyPositionOffset(Vector3 offset, float weight) {} // 0x00000001809F8CB0-0x00000001809F8E00
			private void ApplyRotationOffset(Quaternion offset, float weight) {} // 0x00000001809F8E00-0x00000001809F90A0
			public void Solve() {} // 0x00000001809FA070-0x00000001809FA590
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations) {} // 0x00000001809FA590-0x00000001809FA760
			public override void ResetOffsets() {} // 0x00000001809F9FB0-0x00000001809FA070
		}
	
		[Serializable]
		public class Locomotion // TypeDefIndex: 6749
		{
			// Fields
			// [Range] // 0x00000001800E8540-0x00000001800E85A0
			// [Tooltip] // 0x00000001800E8540-0x00000001800E85A0
			public float weight; // 0x10
			// [Tooltip] // 0x00000001800E86B0-0x00000001800E86E0
			public float footDistance; // 0x14
			// [Tooltip] // 0x00000001800E87D0-0x00000001800E8800
			public float stepThreshold; // 0x18
			// [Tooltip] // 0x00000001800E8880-0x00000001800E88B0
			public float angleThreshold; // 0x1C
			// [Tooltip] // 0x00000001800E88E0-0x00000001800E8910
			public float comAngleMlp; // 0x20
			// [Tooltip] // 0x00000001800E8A80-0x00000001800E8AB0
			public float maxVelocity; // 0x24
			// [Tooltip] // 0x00000001800E8C60-0x00000001800E8C90
			public float velocityFactor; // 0x28
			// [Range] // 0x00000001800E8D20-0x00000001800E8D80
			// [Tooltip] // 0x00000001800E8D20-0x00000001800E8D80
			public float maxLegStretch; // 0x2C
			// [Tooltip] // 0x00000001800E8E30-0x00000001800E8E60
			public float rootSpeed; // 0x30
			// [Tooltip] // 0x00000001800E8E60-0x00000001800E8E90
			public float stepSpeed; // 0x34
			// [Tooltip] // 0x00000001800E9300-0x00000001800E9330
			public AnimationCurve stepHeight; // 0x38
			// [Tooltip] // 0x00000001800E9360-0x00000001800E9390
			public AnimationCurve heelHeight; // 0x40
			// [Range] // 0x00000001800E9390-0x00000001800E93F0
			// [Tooltip] // 0x00000001800E9390-0x00000001800E93F0
			public float relaxLegTwistMinAngle; // 0x48
			// [Tooltip] // 0x00000001800E93F0-0x00000001800E9420
			public float relaxLegTwistSpeed; // 0x4C
			// [Tooltip] // 0x00000001800E96B0-0x00000001800E96E0
			public InterpolationMode stepInterpolation; // 0x50
			// [Tooltip] // 0x00000001800E96E0-0x00000001800E9710
			public Vector3 offset; // 0x54
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public bool blockingEnabled; // 0x60
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public LayerMask blockingLayers; // 0x64
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public float raycastRadius; // 0x68
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public float raycastHeight; // 0x6C
			// [Tooltip] // 0x00000001800E9950-0x00000001800E9980
			public UnityEvent onLeftFootstep; // 0x70
			// [Tooltip] // 0x00000001800E99A0-0x00000001800E99D0
			public UnityEvent onRightFootstep; // 0x78
			private Footstep[] footsteps; // 0x90
			private Vector3 lastComPosition; // 0x98
			private Vector3 comVelocity; // 0xA4
			private int leftFootIndex; // 0xB0
			private int rightFootIndex; // 0xB4
	
			// Properties
			public Vector3 centerOfMass { get; private set; } // 0x00000001809FDE80-0x00000001809FDEA0 0x00000001809FE000-0x00000001809FE020
			public Vector3 leftFootstepPosition { get => default; } // 0x00000001809FDEA0-0x00000001809FDF00 
			public Vector3 rightFootstepPosition { get => default; } // 0x00000001809FDF50-0x00000001809FDFB0 
			public Quaternion leftFootstepRotation { get => default; } // 0x00000001809FDF00-0x00000001809FDF50 
			public Quaternion rightFootstepRotation { get => default; } // 0x00000001809FDFB0-0x00000001809FE000 
	
			// Constructors
			public Locomotion() {} // 0x00000001809FDD60-0x00000001809FDE80
	
			// Methods
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes) {} // 0x00000001809FB2E0-0x00000001809FB6D0
			public void Reset(Vector3[] positions, Quaternion[] rotations) {} // 0x00000001809FB6D0-0x00000001809FBBA0
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot) {} // 0x00000001809FAB40-0x00000001809FB030
			public void AddDeltaPosition(Vector3 delta) {} // 0x00000001809FA910-0x00000001809FAB40
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset) {
				leftFootPosition = default;
				rightFootPosition = default;
				leftFootRotation = default;
				rightFootRotation = default;
				leftFootOffset = default;
				rightFootOffset = default;
				leftHeelOffset = default;
				rightHeelOffset = default;
			} // 0x00000001809FBBA0-0x00000001809FDB00
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition) => default; // 0x00000001809FDB00-0x00000001809FDD60
			private bool CanStep() => default; // 0x00000001809FB030-0x00000001809FB0B0
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius) => default; // 0x00000001809FB0B0-0x00000001809FB2E0
		}
	
		[Serializable]
		public class Spine : BodyPart // TypeDefIndex: 6750
		{
			// Fields
			// [Tooltip] // 0x00000001800E9CF0-0x00000001800E9D20
			public Transform headTarget; // 0x48
			// [Tooltip] // 0x00000001800E9DC0-0x00000001800E9DF0
			public Transform pelvisTarget; // 0x50
			// [Range] // 0x00000001800E9E20-0x00000001800E9E80
			// [Tooltip] // 0x00000001800E9E20-0x00000001800E9E80
			public float positionWeight; // 0x58
			// [Range] // 0x00000001800E9F50-0x00000001800E9FB0
			// [Tooltip] // 0x00000001800E9F50-0x00000001800E9FB0
			public float rotationWeight; // 0x5C
			// [Range] // 0x00000001800E9FF0-0x00000001800EA050
			// [Tooltip] // 0x00000001800E9FF0-0x00000001800EA050
			public float pelvisPositionWeight; // 0x60
			// [Range] // 0x00000001800EA0F0-0x00000001800EA150
			// [Tooltip] // 0x00000001800EA0F0-0x00000001800EA150
			public float pelvisRotationWeight; // 0x64
			// [Tooltip] // 0x00000001800EA1F0-0x00000001800EA220
			public Transform chestGoal; // 0x68
			// [Range] // 0x00000001800EA300-0x00000001800EA360
			// [Tooltip] // 0x00000001800EA300-0x00000001800EA360
			public float chestGoalWeight; // 0x70
			// [Tooltip] // 0x00000001800EA3A0-0x00000001800EA3D0
			public float minHeadHeight; // 0x74
			// [Range] // 0x00000001800EA4D0-0x00000001800EA530
			// [Tooltip] // 0x00000001800EA4D0-0x00000001800EA530
			public float bodyPosStiffness; // 0x78
			// [Range] // 0x00000001800EA570-0x00000001800EA5D0
			// [Tooltip] // 0x00000001800EA570-0x00000001800EA5D0
			public float bodyRotStiffness; // 0x7C
			// [FormerlySerializedAs] // 0x00000001800EA630-0x00000001800EA6B0
			// [Range] // 0x00000001800EA630-0x00000001800EA6B0
			// [Tooltip] // 0x00000001800EA630-0x00000001800EA6B0
			public float neckStiffness; // 0x80
			// [Range] // 0x00000001800EBB30-0x00000001800EBB90
			// [Tooltip] // 0x00000001800EBB30-0x00000001800EBB90
			public float rotateChestByHands; // 0x84
			// [Range] // 0x00000001800EBCB0-0x00000001800EBD10
			// [Tooltip] // 0x00000001800EBCB0-0x00000001800EBD10
			public float chestClampWeight; // 0x88
			// [Range] // 0x00000001800EBD90-0x00000001800EBDF0
			// [Tooltip] // 0x00000001800EBD90-0x00000001800EBDF0
			public float headClampWeight; // 0x8C
			// [Tooltip] // 0x00000001800ED220-0x00000001800ED250
			public float moveBodyBackWhenCrouching; // 0x90
			// [Range] // 0x00000001800ED350-0x00000001800ED3B0
			// [Tooltip] // 0x00000001800ED350-0x00000001800ED3B0
			public float maintainPelvisPosition; // 0x94
			// [Range] // 0x00000001800ED480-0x00000001800ED4E0
			// [Tooltip] // 0x00000001800ED480-0x00000001800ED4E0
			public float maxRootAngle; // 0x98
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Vector3 IKPositionHead; // 0x9C
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Quaternion IKRotationHead; // 0xA8
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Vector3 IKPositionPelvis; // 0xB8
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Quaternion IKRotationPelvis; // 0xC4
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Vector3 goalPositionChest; // 0xD4
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Vector3 pelvisPositionOffset; // 0xE0
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Vector3 chestPositionOffset; // 0xEC
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Vector3 headPositionOffset; // 0xF8
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Quaternion pelvisRotationOffset; // 0x104
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Quaternion chestRotationOffset; // 0x114
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Quaternion headRotationOffset; // 0x124
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Vector3 faceDirection; // 0x134
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Vector3 locomotionHeadPositionOffset; // 0x140
			[NonSerialized]
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Vector3 headPosition; // 0x14C
			private Quaternion headRotation; // 0x168
			private Quaternion anchorRelativeToHead; // 0x178
			private Quaternion pelvisRelativeRotation; // 0x188
			private Quaternion chestRelativeRotation; // 0x198
			private Vector3 headDeltaPosition; // 0x1A8
			private Quaternion pelvisDeltaRotation; // 0x1B4
			private Quaternion chestTargetRotation; // 0x1C4
			private int pelvisIndex; // 0x1D4
			private int spineIndex; // 0x1D8
			private int chestIndex; // 0x1DC
			private int neckIndex; // 0x1E0
			private int headIndex; // 0x1E4
			private float length; // 0x1E8
			private bool hasChest; // 0x1EC
			private bool hasNeck; // 0x1ED
			private float headHeight; // 0x1F0
			private float sizeMlp; // 0x1F4
			private Vector3 chestForward; // 0x1F8
	
			// Properties
			public VirtualBone pelvis { get => default; } // 0x00000001807F59A0-0x00000001807F59E0 
			public VirtualBone firstSpineBone { get => default; } // 0x00000001807F58E0-0x00000001807F5920 
			public VirtualBone chest { get => default; } // 0x00000001807F5870-0x00000001807F58E0 
			private VirtualBone neck { get => default; } // 0x00000001807F5960-0x00000001807F59A0 
			public VirtualBone head { get => default; } // 0x00000001807F5920-0x00000001807F5960 
			public Quaternion anchorRotation { get; private set; } // 0x00000001807F5860-0x00000001807F5870 0x00000001807F59E0-0x00000001807F59F0
	
			// Constructors
			public Spine() {} // 0x00000001807F5690-0x00000001807F5860
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index) {} // 0x00000001807F2E60-0x00000001807F3C80
			public override void PreSolve() {} // 0x00000001807F3C80-0x00000001807F3F30
			public override void ApplyOffsets() {} // 0x00000001807F15F0-0x00000001807F1C20
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms) {} // 0x00000001807F2250-0x00000001807F2470
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms) {} // 0x00000001807F4560-0x00000001807F4E50
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp) {} // 0x00000001807F2470-0x00000001807F27B0
			private void SolvePelvis() {} // 0x00000001807F4040-0x00000001807F4560
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations) {} // 0x00000001807F53C0-0x00000001807F5690
			public override void ResetOffsets() {} // 0x00000001807F3F30-0x00000001807F4040
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms) {} // 0x00000001807F1140-0x00000001807F15F0
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w) {} // 0x00000001807F27B0-0x00000001807F2A10
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation) {} // 0x00000001807F4E50-0x00000001807F53C0
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2 /* Metadata: 0x00652ED1 */) => default; // 0x00000001807F2A10-0x00000001807F2E60
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w) {} // 0x00000001807F1C20-0x00000001807F1F20
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w) {} // 0x00000001807F1F20-0x00000001807F2250
		}
	
		[Serializable]
		public enum PositionOffset // TypeDefIndex: 6751
		{
			Pelvis = 0,
			Chest = 1,
			Head = 2,
			LeftHand = 3,
			RightHand = 4,
			LeftFoot = 5,
			RightFoot = 6,
			LeftHeel = 7,
			RightHeel = 8
		}
	
		[Serializable]
		public enum RotationOffset // TypeDefIndex: 6752
		{
			Pelvis = 0,
			Chest = 1,
			Head = 2
		}
	
		[Serializable]
		public class VirtualBone // TypeDefIndex: 6753
		{
			// Fields
			public Vector3 readPosition; // 0x10
			public Quaternion readRotation; // 0x1C
			public Vector3 solverPosition; // 0x2C
			public Quaternion solverRotation; // 0x38
			public float length; // 0x48
			public float sqrMag; // 0x4C
			public Vector3 axis; // 0x50
	
			// Constructors
			public VirtualBone() {} // Dummy constructor
			public VirtualBone(Vector3 position, Quaternion rotation) {} // 0x00000001807F8550-0x00000001807F85B0
	
			// Methods
			public void Read(Vector3 position, Quaternion rotation) {} // 0x00000001807F6730-0x00000001807F6760
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f /* Metadata: 0x00652F05 */) {} // 0x00000001807F8290-0x00000001807F8550
			public static float PreSolve(ref VirtualBone[] bones) => default; // 0x00000001807F6300-0x00000001807F6730
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation) {} // 0x00000001807F6760-0x00000001807F69A0
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation) {} // 0x00000001807F69A0-0x00000001807F6C60
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation) {} // 0x00000001807F6C60-0x00000001807F6F40
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation) {} // 0x00000001807F6F40-0x00000001807F7020
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight) {} // 0x00000001807F7AB0-0x00000001807F8290
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2) => default; // 0x00000001807F60B0-0x00000001807F6300
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset) {} // 0x00000001807F7490-0x00000001807F7AB0
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) => default; // 0x00000001807F7350-0x00000001807F7490
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations) {} // 0x00000001807F7020-0x00000001807F7350
		}
	
		// Constructors
		public IKSolverVR() {} // 0x00000001809F8110-0x00000001809F8480
	
		// Methods
		public void SetToReferences(VRIK.References references) {} // 0x00000001809F5D10-0x00000001809F6010
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero) {} // 0x00000001809F4630-0x00000001809F49D0
		public void DefaultAnimationCurves() {} // 0x00000001809F32B0-0x00000001809F3450
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value) {} // 0x00000001809F29E0-0x00000001809F2EE0
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value) {} // 0x00000001809F3090-0x00000001809F32B0
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value) {} // 0x00000001809F2EE0-0x00000001809F3090
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot) {} // 0x00000001809F2630-0x00000001809F29E0
		public void Reset() {} // 0x00000001809F5B60-0x00000001809F5D10
		public override void StoreDefaultLocalState() {} // 0x00000001809F78E0-0x00000001809F7AC0
		public override void FixTransforms() {} // 0x00000001809F3450-0x00000001809F3650
		public override Point[] GetPoints() => default; // 0x00000001809F43D0-0x00000001809F4430
		public override Point GetPoint(Transform transform) => default; // 0x00000001809F4370-0x00000001809F43D0
		public override bool IsValid(ref string message) => default; // 0x00000001809F50C0-0x00000001809F53A0
		private Vector3 GetNormal(Transform[] transforms) => default; // 0x00000001809F3650-0x00000001809F39E0
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm) => default; // 0x00000001809F4EB0-0x00000001809F50C0
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm) => default; // 0x00000001809F49D0-0x00000001809F4EB0
		private static Keyframe[] GetSineKeyframes(float mag) => default; // 0x00000001809F44D0-0x00000001809F4630
		private void UpdateSolverTransforms() {} // 0x00000001809F7AC0-0x00000001809F7C80
		protected override void OnInitiate() {} // 0x00000001809F53A0-0x00000001809F53F0
		protected override void OnUpdate() {} // 0x00000001809F53F0-0x00000001809F5470
		private void WriteTransforms() {} // 0x00000001809F7C80-0x00000001809F7F60
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes) {} // 0x00000001809F5470-0x00000001809F5B60
		private void Solve() {} // 0x00000001809F6010-0x00000001809F78E0
		private Vector3 GetPosition(int index) => default; // 0x00000001809F4430-0x00000001809F4480
		private Quaternion GetRotation(int index) => default; // 0x00000001809F4480-0x00000001809F44D0
		private void Write() {} // 0x00000001809F7F60-0x00000001809F8110
		private Vector3 GetPelvisOffset() => default; // 0x00000001809F39E0-0x00000001809F4370
	}
}
