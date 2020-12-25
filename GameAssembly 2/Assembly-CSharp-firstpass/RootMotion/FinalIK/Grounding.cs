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
	public class Grounding // TypeDefIndex: 6688
	{
		// Fields
		// [Tooltip] // 0x000000018013F0D0-0x000000018013F100
		public LayerMask layers; // 0x10
		// [Tooltip] // 0x000000018013F280-0x000000018013F2B0
		public float maxStep; // 0x14
		// [Tooltip] // 0x000000018013F3E0-0x000000018013F410
		public float heightOffset; // 0x18
		// [Tooltip] // 0x000000018013F5E0-0x000000018013F610
		public float footSpeed; // 0x1C
		// [Tooltip] // 0x000000018013F850-0x000000018013F880
		public float footRadius; // 0x20
		[HideInInspector] // 0x000000018013F9B0-0x000000018013FA00
		// [Tooltip] // 0x000000018013F9B0-0x000000018013FA00
		public float footCenterOffset; // 0x24
		// [Tooltip] // 0x000000018013FC30-0x000000018013FC60
		public float prediction; // 0x28
		// [Range] // 0x000000018013FD50-0x000000018013FDB0
		// [Tooltip] // 0x000000018013FD50-0x000000018013FDB0
		public float footRotationWeight; // 0x2C
		// [Tooltip] // 0x0000000180140070-0x00000001801400A0
		public float footRotationSpeed; // 0x30
		// [Range] // 0x0000000180140170-0x00000001801401D0
		// [Tooltip] // 0x0000000180140170-0x00000001801401D0
		public float maxFootRotationAngle; // 0x34
		// [Tooltip] // 0x0000000180140380-0x00000001801403B0
		public bool rotateSolver; // 0x38
		// [Tooltip] // 0x0000000180143840-0x0000000180143870
		public float pelvisSpeed; // 0x3C
		// [Range] // 0x0000000180143A60-0x0000000180143AC0
		// [Tooltip] // 0x0000000180143A60-0x0000000180143AC0
		public float pelvisDamper; // 0x40
		// [Tooltip] // 0x0000000180143B60-0x0000000180143B90
		public float lowerPelvisWeight; // 0x44
		// [Tooltip] // 0x0000000180143DA0-0x0000000180143DD0
		public float liftPelvisWeight; // 0x48
		// [Tooltip] // 0x0000000180145140-0x0000000180145170
		public float rootSphereCastRadius; // 0x4C
		// [Tooltip] // 0x0000000180145330-0x0000000180145360
		public Quality quality; // 0x50
		private bool initiated; // 0xA4
	
		// Properties
		public Leg[] legs { get; private set; } // 0x0000000180246F30-0x0000000180246F40 0x00000001802470C0-0x00000001802470D0
		public Pelvis pelvis { get; private set; } // 0x0000000180274940-0x0000000180274950 0x0000000180280570-0x0000000180280580
		public bool isGrounded { get; private set; } // 0x00000001802FF6E0-0x00000001802FF6F0 0x00000001802FF710-0x00000001802FF720
		public Transform root { get; private set; } // 0x0000000180274980-0x0000000180274990 0x0000000180280510-0x0000000180280520
		public RaycastHit rootHit { get; private set; } // 0x00000001809AAA60-0x00000001809AAA90 0x00000001809AAC00-0x00000001809AAC30
		public bool rootGrounded { get => default; } // 0x00000001809AAA00-0x00000001809AAA60 
		public Vector3 up { get => default; } // 0x00000001809AAA90-0x00000001809AAB30 
		private bool useRootRotation { get => default; } // 0x00000001809AAB30-0x00000001809AAC00 
	
		// Nested types
		[Serializable]
		public enum Quality // TypeDefIndex: 6689
		{
			Fastest = 0,
			Simple = 1,
			Best = 2
		}
	
		public class Leg // TypeDefIndex: 6690
		{
			// Fields
			public Quaternion rotationOffset; // 0x20
			public bool invertFootCenter; // 0x54
			private Grounding grounding; // 0x58
			private float lastTime; // 0x60
			private float deltaTime; // 0x64
			private Vector3 lastPosition; // 0x68
			private Quaternion toHitNormal; // 0x74
			private Quaternion r; // 0x84
			private RaycastHit heelHit; // 0x94
			private Vector3 up; // 0xC0
	
			// Properties
			public bool isGrounded { get; private set; } // 0x00000001803628F0-0x0000000180362930 0x00000001802F6FA0-0x00000001802F6FB0
			public Vector3 IKPosition { get; private set; } // 0x00000001809C2A40-0x00000001809C2A60 0x00000001809C2CD0-0x00000001809C2CE0
			public bool initiated { get; private set; } // 0x00000001802FB160-0x00000001802FB170 0x00000001803C0D60-0x00000001803C0D70
			public float heightFromGround { get; private set; } // 0x000000018036E6F0-0x000000018036E700 0x0000000180482B00-0x0000000180483410
			public Vector3 velocity { get; private set; } // 0x00000001809AC210-0x00000001809AC230 0x00000001809AC250-0x00000001809AC260
			public Transform transform { get; private set; } // 0x00000001803F7AF0-0x00000001803F7B00 0x0000000180249C10-0x0000000180249C20
			public float IKOffset { get; private set; } // 0x0000000180274990-0x00000001802749A0 0x0000000180274EE0-0x0000000180274EF0
			public float stepHeightFromGround { get => default; } // 0x00000001809C2C30-0x00000001809C2CD0 
			private float rootYOffset { get => default; } // 0x00000001809C2A60-0x00000001809C2C30 
	
			// Constructors
			public Leg() {} // 0x00000001809C2990-0x00000001809C2A40
	
			// Methods
			public void Initiate(Grounding grounding, Transform transform) {} // 0x00000001809C1010-0x00000001809C1150
			public void OnEnable() {} // 0x00000001809C1150-0x00000001809C11A0
			public void Reset() {} // 0x00000001809C2180-0x00000001809C2250
			public void Process() {} // 0x00000001809C11A0-0x00000001809C2180
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel) => default; // 0x00000001809C0440-0x00000001809C0990
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel) => default; // 0x00000001809C0BA0-0x00000001809C0EF0
			private Vector3 RotateNormal(Vector3 normal) => default; // 0x00000001809C2440-0x00000001809C2590
			private void SetFootToPoint(Vector3 normal, Vector3 point) {} // 0x00000001809C2870-0x00000001809C2990
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint) {} // 0x00000001809C2590-0x00000001809C2870
			private float GetHeightFromGround(Vector3 hitPoint) => default; // 0x00000001809C0990-0x00000001809C0BA0
			private void RotateFoot() {} // 0x00000001809C2250-0x00000001809C2440
			private Quaternion GetRotationOffsetTarget() => default; // 0x00000001809C0EF0-0x00000001809C1010
		}
	
		public class Pelvis // TypeDefIndex: 6691
		{
			// Fields
			private Grounding grounding; // 0x20
			private Vector3 lastRootPosition; // 0x28
			private float damperF; // 0x34
			private bool initiated; // 0x38
			private float lastTime; // 0x3C
	
			// Properties
			public Vector3 IKOffset { get; private set; } // 0x0000000180623A70-0x0000000180623A90 0x000000018062E900-0x000000018062E910
			public float heightOffset { get; private set; } // 0x00000001803847E0-0x00000001803847F0 0x0000000180384820-0x0000000180384830
	
			// Constructors
			public Pelvis() {} // 0x00000001802466A0-0x00000001802466B0
	
			// Methods
			public void Initiate(Grounding grounding) {} // 0x00000001809C3120-0x00000001809C31A0
			public void Reset() {} // 0x00000001809C3560-0x00000001809C3620
			public void OnEnable() {} // 0x00000001809C31A0-0x00000001809C3210
			public void Process(float lowestOffset, float highestOffset, bool isGrounded) {} // 0x00000001809C3210-0x00000001809C3560
		}
	
		// Constructors
		public Grounding() {} // 0x00000001809AA9A0-0x00000001809AAA00
	
		// Methods
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f /* Metadata: 0x00652E10 */) => default; // 0x00000001809A97E0-0x00000001809A9DD0
		public bool IsValid(ref string errorMessage) => default; // 0x00000001809AA400-0x00000001809AA4F0
		public void Initiate(Transform root, Transform[] feet) {} // 0x00000001809A9F40-0x00000001809AA400
		public void Update() {} // 0x00000001809AA710-0x00000001809AA9A0
		public Vector3 GetLegsPlaneNormal() => default; // 0x00000001809A9490-0x00000001809A97E0
		public void Reset() {} // 0x00000001809AA510-0x00000001809AA710
		public void LogWarning(string message) {} // 0x00000001809AA4F0-0x00000001809AA510
		public float GetVerticalOffset(Vector3 p1, Vector3 p2) => default; // 0x00000001809A9DD0-0x00000001809A9F40
		public Vector3 Flatten(Vector3 v) => default; // 0x00000001809A91F0-0x00000001809A9330
		public Vector3 GetFootCenterOffset() => default; // 0x00000001809A9330-0x00000001809A9490
	}
}
