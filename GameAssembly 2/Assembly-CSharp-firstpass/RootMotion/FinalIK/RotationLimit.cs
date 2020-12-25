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
	public abstract class RotationLimit : MonoBehaviour // TypeDefIndex: 6782
	{
		// Fields
		public Vector3 axis; // 0x18
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public Quaternion defaultLocalRotation; // 0x24
		private bool initiated; // 0x34
		private bool applicationQuit; // 0x35
		private bool defaultLocalRotationSet; // 0x36
	
		// Properties
		public Vector3 secondaryAxis { get; } // 0x00000001807F0810-0x00000001807F0850 
		public Vector3 crossAxis { get; } // 0x00000001807F0720-0x00000001807F0810 
	
		// Constructors
		protected RotationLimit() {} // 0x00000001807F06B0-0x00000001807F0720
	
		// Methods
		public void SetDefaultLocalRotation() {} // 0x00000001807F0670-0x00000001807F06B0
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed) {
			changed = default;
			return default;
		} // 0x00000001807EFEF0-0x00000001807F0070
		public bool Apply() => default; // 0x00000001807EFBE0-0x00000001807EFDB0
		public void Disable() {} // 0x00000001807EFEC0-0x00000001807EFEF0
		protected abstract Quaternion LimitRotation(Quaternion rotation);
		private void Awake() {} // 0x00000001807EFDB0-0x00000001807EFEC0
		private void LateUpdate() {} // 0x00000001807F0130-0x00000001807F0300
		public void LogWarning(string message) {} // 0x0000000180521FA0-0x0000000180521FD0
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis) => default; // 0x00000001807F0300-0x00000001807F0400
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit) => default; // 0x00000001807F0400-0x00000001807F0670
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal) => default; // 0x00000001807F0070-0x00000001807F0130
	}
}
