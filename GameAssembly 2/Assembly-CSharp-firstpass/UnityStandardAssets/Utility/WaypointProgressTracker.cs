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
	public class WaypointProgressTracker : MonoBehaviour // TypeDefIndex: 5886
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private WaypointCircuit circuit; // 0x18
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float lookAheadForTargetOffset; // 0x20
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float lookAheadForTargetFactor; // 0x24
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float lookAheadForSpeedOffset; // 0x28
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float lookAheadForSpeedFactor; // 0x2C
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private ProgressStyle progressStyle; // 0x30
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float pointToPointThreshold; // 0x34
		public Transform target; // 0x80
		private float progressDistance; // 0x88
		private int progressNum; // 0x8C
		private Vector3 lastPosition; // 0x90
		private float speed; // 0x9C
	
		// Properties
		public WaypointCircuit.RoutePoint targetPoint { get; private set; } // 0x000000018027A690-0x000000018027A6B0 0x0000000180A4DCB0-0x0000000180A4DCD0
		public WaypointCircuit.RoutePoint speedPoint { get; private set; } // 0x0000000180A4DC50-0x0000000180A4DC70 0x0000000180A4DC90-0x0000000180A4DCB0
		public WaypointCircuit.RoutePoint progressPoint { get; private set; } // 0x0000000180A4DC30-0x0000000180A4DC50 0x0000000180A4DC70-0x0000000180A4DC90
	
		// Nested types
		public enum ProgressStyle // TypeDefIndex: 5887
		{
			SmoothAlongRoute = 0,
			PointToPoint = 1
		}
	
		// Constructors
		public WaypointProgressTracker() {} // 0x0000000180A4DC00-0x0000000180A4DC30
	
		// Methods
		private void Start() {} // 0x0000000180A4D200-0x0000000180A4D400
		public void Reset() {} // 0x0000000180A4D0D0-0x0000000180A4D200
		private void Update() {} // 0x0000000180A4D400-0x0000000180A4DC00
		private void OnDrawGizmos() {} // 0x0000000180A4CE70-0x0000000180A4D0D0
	}
}
