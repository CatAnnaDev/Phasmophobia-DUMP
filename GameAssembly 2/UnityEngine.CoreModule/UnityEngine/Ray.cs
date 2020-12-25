/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	public struct Ray // TypeDefIndex: 3125
	{
		// Fields
		private Vector3 m_Origin; // 0x00
		private Vector3 m_Direction; // 0x0C
	
		// Properties
		public Vector3 origin { get => default; set {} } // 0x000000018003AEA0-0x000000018003AEE0 0x000000018003BF20-0x000000018003BF30
		public Vector3 direction { get => default; set {} } // 0x000000018003BEB0-0x000000018003BED0 0x000000018003BED0-0x000000018003BF20
	
		// Constructors
		public Ray(Vector3 origin, Vector3 direction) : this() {
			m_Origin = default;
			m_Direction = default;
		} // 0x000000018003BE50-0x000000018003BEB0
	
		// Methods
		public Vector3 GetPoint(float distance) => default; // 0x000000018003BBE0-0x000000018003BCE0
		public override string ToString() => default; // 0x000000018003BCE0-0x000000018003BE50
	}
}
