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
	public class ShoulderRotator : MonoBehaviour // TypeDefIndex: 6822
	{
		// Fields
		// [Tooltip] // 0x0000000180102C50-0x0000000180102C80
		public float weight; // 0x18
		// [Tooltip] // 0x0000000180102CF0-0x0000000180102D20
		public float offset; // 0x1C
		private FullBodyBipedIK ik; // 0x20
		private bool skip; // 0x28
	
		// Constructors
		public ShoulderRotator() {} // 0x00000001807F1120-0x00000001807F1140
	
		// Methods
		private void Start() {} // 0x00000001807F1030-0x00000001807F1120
		private void RotateShoulders() {} // 0x00000001807F0F30-0x00000001807F1030
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset) {} // 0x00000001807F09A0-0x00000001807F0F30
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain) => default; // 0x00000001807F0850-0x00000001807F0890
		private void OnDestroy() {} // 0x00000001807F0890-0x00000001807F09A0
	}
}
