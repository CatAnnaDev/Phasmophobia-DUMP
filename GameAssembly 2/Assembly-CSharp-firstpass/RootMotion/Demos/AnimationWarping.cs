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
	public class AnimationWarping : OffsetModifier // TypeDefIndex: 6601
	{
		// Fields
		// [Tooltip] // 0x000000018012C2F0-0x000000018012C320
		public Animator animator; // 0x30
		// [Tooltip] // 0x000000018012C3A0-0x000000018012C3D0
		public EffectorMode effectorMode; // 0x38
		[Space] // 0x000000018012C470-0x000000018012C4C0
		// [Tooltip] // 0x000000018012C470-0x000000018012C4C0
		public Warp[] warps; // 0x40
		private EffectorMode lastMode; // 0x48
	
		// Nested types
		[Serializable]
		public struct Warp // TypeDefIndex: 6602
		{
			// Fields
			// [Tooltip] // 0x000000018012C610-0x000000018012C640
			public int animationLayer; // 0x00
			// [Tooltip] // 0x000000018012C6F0-0x000000018012C720
			public string animationState; // 0x08
			// [Tooltip] // 0x000000018012C7E0-0x000000018012C810
			public AnimationCurve weightCurve; // 0x10
			// [Tooltip] // 0x000000018012C8B0-0x000000018012C8E0
			public Transform warpFrom; // 0x18
			// [Tooltip] // 0x000000018012C920-0x000000018012C950
			public Transform warpTo; // 0x20
			// [Tooltip] // 0x000000018012DCD0-0x000000018012DD00
			public FullBodyBipedEffector effector; // 0x28
		}
	
		[Serializable]
		public enum EffectorMode // TypeDefIndex: 6603
		{
			PositionOffset = 0,
			Position = 1
		}
	
		// Constructors
		public AnimationWarping() {} // 0x00000001804AF900-0x00000001804AF910
	
		// Methods
		protected override void Start() {} // 0x00000001804AF8E0-0x00000001804AF900
		public float GetWarpWeight(int warpIndex) => default; // 0x00000001804AF090-0x00000001804AF310
		protected override void OnModifyOffset() {} // 0x00000001804AF3C0-0x00000001804AF8E0
		private void OnDisable() {} // 0x00000001804AF310-0x00000001804AF3C0
	}
}
