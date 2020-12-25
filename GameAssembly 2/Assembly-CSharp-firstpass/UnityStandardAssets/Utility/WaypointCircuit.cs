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
	public class WaypointCircuit : MonoBehaviour // TypeDefIndex: 5883
	{
		// Fields
		public WaypointList waypointList; // 0x18
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool smoothRoute; // 0x20
		private int numPoints; // 0x24
		private Vector3[] points; // 0x28
		private float[] distances; // 0x30
		public float editorVisualisationSubsteps; // 0x38
		private int p0n; // 0x40
		private int p1n; // 0x44
		private int p2n; // 0x48
		private int p3n; // 0x4C
		private float i; // 0x50
		private Vector3 P0; // 0x54
		private Vector3 P1; // 0x60
		private Vector3 P2; // 0x6C
		private Vector3 P3; // 0x78
	
		// Properties
		public float Length { get; private set; } // 0x000000018036E6D0-0x000000018036E6E0 0x0000000180691F00-0x0000000180691F10
		public Transform[] Waypoints { get => default; } // 0x00000001803EB7A0-0x00000001803EB7C0 
	
		// Nested types
		[Serializable]
		public class WaypointList // TypeDefIndex: 5884
		{
			// Fields
			public WaypointCircuit circuit; // 0x10
			public Transform[] items; // 0x18
	
			// Constructors
			public WaypointList() {} // 0x0000000180A4CE20-0x0000000180A4CE70
		}
	
		public struct RoutePoint // TypeDefIndex: 5885
		{
			// Fields
			public Vector3 position; // 0x00
			public Vector3 direction; // 0x0C
	
			// Constructors
			public RoutePoint(Vector3 position, Vector3 direction) {
				this.position = default;
				this.direction = default;
			} // 0x0000000180044A40-0x0000000180044A70
		}
	
		// Constructors
		public WaypointCircuit() {} // 0x0000000180A4CD70-0x0000000180A4CE20
	
		// Methods
		private void Awake() {} // 0x0000000180A4BAF0-0x0000000180A4BB40
		public RoutePoint GetRoutePoint(float dist) => default; // 0x0000000180A4C790-0x0000000180A4C8C0
		public Vector3 GetRoutePosition(float dist) => default; // 0x0000000180A4C8C0-0x0000000180A4CD50
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i) => default; // 0x0000000180A4BF20-0x0000000180A4C420
		private void CachePositionsAndDistances() {} // 0x0000000180A4BB40-0x0000000180A4BF20
		private void OnDrawGizmos() {} // 0x0000000180A4CD60-0x0000000180A4CD70
		private void OnDrawGizmosSelected() {} // 0x0000000180A4CD50-0x0000000180A4CD60
		private void DrawGizmos(bool selected) {} // 0x0000000180A4C420-0x0000000180A4C790
	}
}
