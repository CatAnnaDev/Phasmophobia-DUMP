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
	public class FABRIKChain // TypeDefIndex: 6705
	{
		// Fields
		public FABRIK ik; // 0x10
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float pull; // 0x18
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float pin; // 0x1C
		public int[] children; // 0x20
	
		// Constructors
		public FABRIKChain() {} // 0x0000000180526720-0x0000000180526780
	
		// Methods
		public bool IsValid(ref string message) => default; // 0x0000000180526370-0x0000000180526440
		public void Initiate() {} // 0x00000001804CBCB0-0x00000001804CBCE0
		public void Stage1(FABRIKChain[] chain) {} // 0x0000000180526440-0x0000000180526590
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain) {} // 0x0000000180526590-0x0000000180526720
		private Vector3 GetCentroid(FABRIKChain[] chain) => default; // 0x0000000180525EF0-0x0000000180526370
	}
}
