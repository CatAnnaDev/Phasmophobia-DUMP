/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 14: UnityEngine.InputLegacyModule.dll - Assembly: UnityEngine.InputLegacyModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3778-3786

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180107A60-0x0000000180107A90
	public struct Touch // TypeDefIndex: 3782
	{
		// Fields
		private int m_FingerId; // 0x00
		private Vector2 m_Position; // 0x04
		private Vector2 m_RawPosition; // 0x0C
		private Vector2 m_PositionDelta; // 0x14
		private float m_TimeDelta; // 0x1C
		private int m_TapCount; // 0x20
		private TouchPhase m_Phase; // 0x24
		private TouchType m_Type; // 0x28
		private float m_Pressure; // 0x2C
		private float m_maximumPossiblePressure; // 0x30
		private float m_Radius; // 0x34
		private float m_RadiusVariance; // 0x38
		private float m_AltitudeAngle; // 0x3C
		private float m_AzimuthAngle; // 0x40
	
		// Properties
		public int fingerId { get => default; } // 0x0000000180005FD0-0x0000000180005FE0 
		public Vector2 position { get => default; } // 0x000000018004EC20-0x000000018004EC40 
		public TouchPhase phase { get => default; } // 0x000000018004EC10-0x000000018004EC20 
		public TouchType type { get => default; } // 0x000000018004EC40-0x000000018004ED10 
	}
}
