﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using RootMotion.FinalIK;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.Demos
{
	public class BipedIKvsAnimatorIK : MonoBehaviour // TypeDefIndex: 6595
	{
		// Fields
		// [LargeHeader] // 0x000000018012B660-0x000000018012B690
		public Animator animator; // 0x18
		public BipedIK bipedIK; // 0x20
		// [LargeHeader] // 0x000000018012B6E0-0x000000018012B710
		public Transform lookAtTargetBiped; // 0x28
		public Transform lookAtTargetAnimator; // 0x30
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float lookAtWeight; // 0x38
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float lookAtBodyWeight; // 0x3C
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float lookAtHeadWeight; // 0x40
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float lookAtEyesWeight; // 0x44
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float lookAtClampWeight; // 0x48
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float lookAtClampWeightHead; // 0x4C
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float lookAtClampWeightEyes; // 0x50
		// [LargeHeader] // 0x000000018012B9A0-0x000000018012B9D0
		public Transform footTargetBiped; // 0x58
		public Transform footTargetAnimator; // 0x60
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float footPositionWeight; // 0x68
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float footRotationWeight; // 0x6C
		// [LargeHeader] // 0x000000018012BB90-0x000000018012BBC0
		public Transform handTargetBiped; // 0x70
		public Transform handTargetAnimator; // 0x78
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float handPositionWeight; // 0x80
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float handRotationWeight; // 0x84
	
		// Constructors
		public BipedIKvsAnimatorIK() {} // 0x00000001804B24C0-0x00000001804B2500
	
		// Methods
		private void OnAnimatorIK(int layer) {} // 0x00000001804B1D40-0x00000001804B24C0
	}
}
