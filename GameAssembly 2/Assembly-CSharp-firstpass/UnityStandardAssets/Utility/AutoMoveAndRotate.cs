/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.Utility
{
	public class AutoMoveAndRotate : MonoBehaviour // TypeDefIndex: 5854
	{
		// Fields
		public Vector3andSpace moveUnitsPerSecond; // 0x18
		public Vector3andSpace rotateDegreesPerSecond; // 0x20
		public bool ignoreTimescale; // 0x28
		private float m_LastRealTime; // 0x2C
	
		// Nested types
		[Serializable]
		public class Vector3andSpace // TypeDefIndex: 5855
		{
			// Fields
			public Vector3 value; // 0x10
			public Space space; // 0x1C
	
			// Constructors
			public Vector3andSpace() {} // 0x0000000180A4B1F0-0x0000000180A4B200
		}
	
		// Constructors
		public AutoMoveAndRotate() {} // 0x0000000180276E90-0x0000000180276EA0
	
		// Methods
		private void Start() {} // 0x0000000180A374A0-0x0000000180A374C0
		private void Update() {} // 0x0000000180A374C0-0x0000000180A37650
	}
}
