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
	public class CameraControllerFPS : MonoBehaviour // TypeDefIndex: 6567
	{
		// Fields
		public float rotationSensitivity; // 0x18
		public float yMinLimit; // 0x1C
		public float yMaxLimit; // 0x20
		private float x; // 0x24
		private float y; // 0x28
	
		// Constructors
		public CameraControllerFPS() {} // 0x00000001804BBFD0-0x00000001804BBFF0
	
		// Methods
		private void Awake() {} // 0x00000001804BBCB0-0x00000001804BBD00
		public void LateUpdate() {} // 0x00000001804BBDA0-0x00000001804BBFD0
		private float ClampAngle(float angle, float min, float max) => default; // 0x00000001804BBD00-0x00000001804BBDA0
	}
}
