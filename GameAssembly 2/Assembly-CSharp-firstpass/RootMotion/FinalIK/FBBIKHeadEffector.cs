/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.FinalIK
{
	public class FBBIKHeadEffector : MonoBehaviour // TypeDefIndex: 6707
	{
		// Fields
		// [Tooltip] // 0x00000001800D73A0-0x00000001800D73D0
		public FullBodyBipedIK ik; // 0x18
		// [LargeHeader] // 0x00000001800D7490-0x00000001800D7510
		// [Range] // 0x00000001800D7490-0x00000001800D7510
		// [Tooltip] // 0x00000001800D7490-0x00000001800D7510
		public float positionWeight; // 0x20
		// [Range] // 0x00000001800D7690-0x00000001800D76F0
		// [Tooltip] // 0x00000001800D7690-0x00000001800D76F0
		public float bodyWeight; // 0x24
		// [Range] // 0x00000001800D7770-0x00000001800D77D0
		// [Tooltip] // 0x00000001800D7770-0x00000001800D77D0
		public float thighWeight; // 0x28
		// [Tooltip] // 0x00000001800D7990-0x00000001800D79C0
		public bool handsPullBody; // 0x2C
		// [LargeHeader] // 0x00000001800D7A20-0x00000001800D7AA0
		// [Range] // 0x00000001800D7A20-0x00000001800D7AA0
		// [Tooltip] // 0x00000001800D7A20-0x00000001800D7AA0
		public float rotationWeight; // 0x30
		// [Range] // 0x00000001800D7D60-0x00000001800D7DC0
		// [Tooltip] // 0x00000001800D7D60-0x00000001800D7DC0
		public float bodyClampWeight; // 0x34
		// [Range] // 0x00000001800D7F60-0x00000001800D7FC0
		// [Tooltip] // 0x00000001800D7F60-0x00000001800D7FC0
		public float headClampWeight; // 0x38
		// [Range] // 0x00000001800D8250-0x00000001800D82B0
		// [Tooltip] // 0x00000001800D8250-0x00000001800D82B0
		public float bendWeight; // 0x3C
		// [Tooltip] // 0x00000001800D85C0-0x00000001800D85F0
		public BendBone[] bendBones; // 0x40
		// [LargeHeader] // 0x00000001800D8780-0x00000001800D8800
		// [Range] // 0x00000001800D8780-0x00000001800D8800
		// [Tooltip] // 0x00000001800D8780-0x00000001800D8800
		public float CCDWeight; // 0x48
		// [Range] // 0x00000001800D8AD0-0x00000001800D8B30
		// [Tooltip] // 0x00000001800D8AD0-0x00000001800D8B30
		public float roll; // 0x4C
		// [Range] // 0x00000001800D8D50-0x00000001800D8DB0
		// [Tooltip] // 0x00000001800D8D50-0x00000001800D8DB0
		public float damper; // 0x50
		// [Tooltip] // 0x00000001800D9000-0x00000001800D9030
		public Transform[] CCDBones; // 0x58
		// [LargeHeader] // 0x00000001800D91A0-0x00000001800D9220
		// [Range] // 0x00000001800D91A0-0x00000001800D9220
		// [Tooltip] // 0x00000001800D91A0-0x00000001800D9220
		public float postStretchWeight; // 0x60
		// [Tooltip] // 0x00000001800D95A0-0x00000001800D95D0
		public float maxStretch; // 0x64
		// [Tooltip] // 0x00000001800D9740-0x00000001800D9770
		public float stretchDamper; // 0x68
		// [Tooltip] // 0x00000001800D9980-0x00000001800D99B0
		public bool fixHead; // 0x6C
		// [Tooltip] // 0x00000001800D9E20-0x00000001800D9E50
		public Transform[] stretchBones; // 0x70
		// [LargeHeader] // 0x00000001800D9FF0-0x00000001800DA020
		public Vector3 chestDirection; // 0x78
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float chestDirectionWeight; // 0x84
		public Transform[] chestBones; // 0x88
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK; // 0x90
		private Vector3 offset; // 0x98
		private Vector3 headToBody; // 0xA4
		private Vector3 shoulderCenterToHead; // 0xB0
		private Vector3 headToLeftThigh; // 0xBC
		private Vector3 headToRightThigh; // 0xC8
		private Vector3 leftShoulderPos; // 0xD4
		private Vector3 rightShoulderPos; // 0xE0
		private float shoulderDist; // 0xEC
		private float leftShoulderDist; // 0xF0
		private float rightShoulderDist; // 0xF4
		private Quaternion chestRotation; // 0xF8
		private Quaternion headRotationRelativeToRoot; // 0x108
		private Quaternion[] ccdDefaultLocalRotations; // 0x118
		private Vector3 headLocalPosition; // 0x120
		private Quaternion headLocalRotation; // 0x12C
		private Vector3[] stretchLocalPositions; // 0x140
		private Quaternion[] stretchLocalRotations; // 0x148
		private Vector3[] chestLocalPositions; // 0x150
		private Quaternion[] chestLocalRotations; // 0x158
		private int bendBonesCount; // 0x160
		private int ccdBonesCount; // 0x164
		private int stretchBonesCount; // 0x168
		private int chestBonesCount; // 0x16C
	
		// Nested types
		[Serializable]
		public class BendBone // TypeDefIndex: 6708
		{
			// Fields
			// [Tooltip] // 0x00000001800DA270-0x00000001800DA2A0
			public Transform transform; // 0x10
			// [Range] // 0x00000001800DB710-0x00000001800DB770
			// [Tooltip] // 0x00000001800DB710-0x00000001800DB770
			public float weight; // 0x18
			private Quaternion defaultLocalRotation; // 0x1C
	
			// Constructors
			public BendBone() {} // 0x0000000180520FA0-0x0000000180521010
			public BendBone(Transform transform, float weight) {} // 0x0000000180520F00-0x0000000180520FA0
	
			// Methods
			public void StoreDefaultLocalState() {} // 0x0000000180520EC0-0x0000000180520F00
			public void FixTransforms() {} // 0x0000000180520E80-0x0000000180520EC0
		}
	
		// Constructors
		public FBBIKHeadEffector() {} // 0x000000018052B570-0x000000018052B750
	
		// Methods
		private void Start() {} // 0x000000018052B170-0x000000018052B570
		private void OnStoreDefaultLocalState() {} // 0x0000000180529FB0-0x000000018052A680
		private void OnFixTransforms() {} // 0x0000000180528EC0-0x0000000180529460
		private void OnPreRead() {} // 0x00000001805296A0-0x0000000180529FB0
		private void SpineBend() {} // 0x000000018052AD60-0x000000018052B170
		private void CCDPass() {} // 0x0000000180527440-0x0000000180527910
		private void Iterate(int iteration) {} // 0x0000000180527C80-0x00000001805289F0
		private void OnPostUpdate() {} // 0x0000000180529460-0x00000001805296A0
		private void ChestDirection() {} // 0x0000000180527910-0x0000000180527C80
		private void PostStretching() {} // 0x000000018052A680-0x000000018052AB60
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset) {} // 0x00000001805289F0-0x0000000180528B70
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance) {} // 0x000000018052AB60-0x000000018052AD60
		private void OnDestroy() {} // 0x0000000180528B70-0x0000000180528EC0
	}
}
