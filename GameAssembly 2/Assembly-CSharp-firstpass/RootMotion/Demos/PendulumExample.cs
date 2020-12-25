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
	// [RequireComponent] // 0x000000018012F400-0x000000018012F450
	public class PendulumExample : MonoBehaviour // TypeDefIndex: 6630
	{
		// Fields
		// [Range] // 0x000000018012F4B0-0x000000018012F510
		// [Tooltip] // 0x000000018012F4B0-0x000000018012F510
		public float weight; // 0x18
		// [Tooltip] // 0x000000018012F590-0x000000018012F5C0
		public float hangingDistanceMlp; // 0x1C
		[HideInInspector] // 0x000000018012F6D0-0x000000018012F720
		// [Tooltip] // 0x000000018012F6D0-0x000000018012F720
		public Vector3 rootTargetPosition; // 0x20
		[HideInInspector] // 0x0000000180130B20-0x0000000180130B70
		// [Tooltip] // 0x0000000180130B20-0x0000000180130B70
		public Quaternion rootTargetRotation; // 0x2C
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Transform target; // 0x40
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Transform leftHandTarget; // 0x48
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Transform rightHandTarget; // 0x50
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Transform leftFootTarget; // 0x58
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Transform rightFootTarget; // 0x60
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Transform pelvisTarget; // 0x68
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Transform bodyTarget; // 0x70
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Transform headTarget; // 0x78
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Vector3 pelvisDownAxis; // 0x80
		private FullBodyBipedIK ik; // 0x90
		private Quaternion rootRelativeToPelvis; // 0x98
		private Vector3 pelvisToRoot; // 0xA8
		private float lastWeight; // 0xB4
	
		// Constructors
		public PendulumExample() {} // 0x00000001804CD6B0-0x00000001804CD730
	
		// Methods
		private void Start() {} // 0x00000001804CD2F0-0x00000001804CD6B0
		private void LateUpdate() {} // 0x00000001804CC9A0-0x00000001804CD2F0
	}
}
