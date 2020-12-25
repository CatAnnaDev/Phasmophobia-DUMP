/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion
{
	public static class BipedNaming // TypeDefIndex: 6572
	{
		// Fields
		public static string[] typeLeft; // 0x00
		public static string[] typeRight; // 0x08
		public static string[] typeSpine; // 0x10
		public static string[] typeHead; // 0x18
		public static string[] typeArm; // 0x20
		public static string[] typeLeg; // 0x28
		public static string[] typeTail; // 0x30
		public static string[] typeEye; // 0x38
		public static string[] typeExclude; // 0x40
		public static string[] typeExcludeSpine; // 0x48
		public static string[] typeExcludeHead; // 0x50
		public static string[] typeExcludeArm; // 0x58
		public static string[] typeExcludeLeg; // 0x60
		public static string[] typeExcludeTail; // 0x68
		public static string[] typeExcludeEye; // 0x70
		public static string[] pelvis; // 0x78
		public static string[] hand; // 0x80
		public static string[] foot; // 0x88
	
		// Nested types
		[Serializable]
		public enum BoneType // TypeDefIndex: 6573
		{
			Unassigned = 0,
			Spine = 1,
			Head = 2,
			Arm = 3,
			Leg = 4,
			Tail = 5,
			Eye = 6
		}
	
		[Serializable]
		public enum BoneSide // TypeDefIndex: 6574
		{
			Center = 0,
			Left = 1,
			Right = 2
		}
	
		// Constructors
		static BipedNaming() {} // 0x00000001804B3AF0-0x00000001804B6F00
	
		// Methods
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones) => default; // 0x00000001804B3760-0x00000001804B38D0
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones) => default; // 0x00000001804B3440-0x00000001804B35B0
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones) => default; // 0x00000001804B35B0-0x00000001804B3760
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones) => default; // 0x00000001804B38D0-0x00000001804B3980
		public static Transform GetNamingMatch(Transform[] transforms, params /* 0x00000001800D4E50-0x00000001800D4E60 */ string[][] namings) => default; // 0x00000001804B3980-0x00000001804B3AB0
		public static BoneType GetBoneType(string boneName) => default; // 0x00000001804B2E90-0x00000001804B33B0
		public static BoneSide GetBoneSide(string boneName) => default; // 0x00000001804B2B60-0x00000001804B2E90
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center /* Metadata: 0x00652D1E */, params /* 0x00000001800D4E50-0x00000001800D4E60 */ string[][] namings) => default; // 0x00000001804B33B0-0x00000001804B3440
		private static bool isLeft(string boneName) => default; // 0x00000001804B7230-0x00000001804B7390
		private static bool isRight(string boneName) => default; // 0x00000001804B7450-0x00000001804B75C0
		private static bool isSpine(string boneName) => default; // 0x00000001804B75C0-0x00000001804B7680
		private static bool isHead(string boneName) => default; // 0x00000001804B7170-0x00000001804B7230
		private static bool isArm(string boneName) => default; // 0x00000001804B6FF0-0x00000001804B70B0
		private static bool isLeg(string boneName) => default; // 0x00000001804B7390-0x00000001804B7450
		private static bool isTail(string boneName) => default; // 0x00000001804B7680-0x00000001804B7740
		private static bool isEye(string boneName) => default; // 0x00000001804B70B0-0x00000001804B7170
		private static bool isTypeExclude(string boneName) => default; // 0x00000001804B7740-0x00000001804B77B0
		private static bool matchesNaming(string boneName, string[] namingConvention) => default; // 0x00000001804B78D0-0x00000001804B79C0
		private static bool excludesNaming(string boneName, string[] namingConvention) => default; // 0x00000001804B6F00-0x00000001804B6F90
		private static bool matchesLastLetter(string boneName, string[] namingConvention) => default; // 0x00000001804B7810-0x00000001804B78D0
		private static bool LastLetterIs(string boneName, string letter) => default; // 0x00000001804B3AB0-0x00000001804B3AF0
		private static string firstLetter(string boneName) => default; // 0x00000001804B6F90-0x00000001804B6FF0
		private static string lastLetter(string boneName) => default; // 0x00000001804B77B0-0x00000001804B7810
	}
}
