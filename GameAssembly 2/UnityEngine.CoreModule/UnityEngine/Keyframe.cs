/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
	public struct Keyframe // TypeDefIndex: 3104
	{
		// Fields
		private float m_Time; // 0x00
		private float m_Value; // 0x04
		private float m_InTangent; // 0x08
		private float m_OutTangent; // 0x0C
		private int m_WeightedMode; // 0x10
		private float m_InWeight; // 0x14
		private float m_OutWeight; // 0x18
	
		// Properties
		public float time { get => default; set {} } // 0x0000000180005D50-0x0000000180005D60 0x000000018000FCF0-0x000000018000FD00
		public float value { set {} } // 0x000000018000FCE0-0x000000018000FCF0
	
		// Constructors
		public Keyframe(float time, float value) : this() {
			m_Time = default;
			m_Value = default;
			m_InTangent = default;
			m_OutTangent = default;
			m_WeightedMode = default;
			m_InWeight = default;
			m_OutWeight = default;
		} // 0x0000000180043F10-0x0000000180043F30
		public Keyframe(float time, float value, float inTangent, float outTangent) : this() {
			m_Time = default;
			m_Value = default;
			m_InTangent = default;
			m_OutTangent = default;
			m_WeightedMode = default;
			m_InWeight = default;
			m_OutWeight = default;
		} // 0x0000000180043F30-0x0000000180043F60
	}
}
