/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.CrossPlatformInput
{
	public class TiltInput : MonoBehaviour // TypeDefIndex: 6054
	{
		// Fields
		public AxisMapping mapping; // 0x18
		public AxisOptions tiltAroundAxis; // 0x20
		public float fullTiltAngle; // 0x24
		public float centreAngleOffset; // 0x28
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis; // 0x30
	
		// Nested types
		public enum AxisOptions // TypeDefIndex: 6055
		{
			ForwardAxis = 0,
			SidewaysAxis = 1
		}
	
		[Serializable]
		public class AxisMapping // TypeDefIndex: 6056
		{
			// Fields
			public MappingType type; // 0x10
			public string axisName; // 0x18
	
			// Nested types
			public enum MappingType // TypeDefIndex: 6057
			{
				NamedAxis = 0,
				MousePositionX = 1,
				MousePositionY = 2,
				MousePositionZ = 3
			}
	
			// Constructors
			public AxisMapping() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		// Constructors
		public TiltInput() {} // 0x0000000180628A70-0x0000000180628A80
	
		// Methods
		private void OnEnable() {} // 0x0000000180628520-0x00000001806285F0
		private void Update() {} // 0x00000001806285F0-0x0000000180628A70
		private void OnDisable() {} // 0x00000001806284B0-0x0000000180628520
	}
}
