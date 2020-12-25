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
	[UsedByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
	public struct Plane // TypeDefIndex: 3124
	{
		// Fields
		internal const int size = 16; // Metadata: 0x0064B867
		private Vector3 m_Normal; // 0x00
		private float m_Distance; // 0x0C
	
		// Properties
		public Vector3 normal { get => default; } // 0x000000018003AEA0-0x000000018003AEE0 
		public float distance { get => default; } // 0x000000018003AE90-0x000000018003AEA0 
	
		// Constructors
		public Plane(Vector3 inNormal, Vector3 inPoint) : this() {
			m_Normal = default;
			m_Distance = default;
		} // 0x000000018003AD20-0x000000018003ADF0
		public Plane(Vector3 inNormal, float d) : this() {
			m_Normal = default;
			m_Distance = default;
		} // 0x000000018003ADF0-0x000000018003AE90
		public Plane(Vector3 a, Vector3 b, Vector3 c) : this() {
			m_Normal = default;
			m_Distance = default;
		} // 0x000000018003ABA0-0x000000018003AD20
	
		// Methods
		public float GetDistanceToPoint(Vector3 point) => default; // 0x000000018003A840-0x000000018003A8F0
		public bool GetSide(Vector3 point) => default; // 0x000000018003A8F0-0x000000018003A9A0
		public bool Raycast(Ray ray, out float enter) {
			enter = default;
			return default;
		} // 0x000000018003A9A0-0x000000018003AB90
		public override string ToString() => default; // 0x000000018003AB90-0x000000018003ABA0
	}
}
