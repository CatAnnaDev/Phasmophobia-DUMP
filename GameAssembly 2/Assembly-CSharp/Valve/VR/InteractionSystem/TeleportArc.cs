/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	public class TeleportArc : MonoBehaviour // TypeDefIndex: 8439
	{
		// Fields
		public int segmentCount; // 0x18
		public float thickness; // 0x1C
		// [Tooltip] // 0x00000001800D8090-0x00000001800D80C0
		public float arcDuration; // 0x20
		// [Tooltip] // 0x00000001800D82B0-0x00000001800D82E0
		public float segmentBreak; // 0x24
		// [Tooltip] // 0x00000001800D8590-0x00000001800D85C0
		public float arcSpeed; // 0x28
		public Material material; // 0x30
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public int traceLayerMask; // 0x38
		private LineRenderer[] lineRenderers; // 0x40
		private float arcTimeOffset; // 0x48
		private float prevThickness; // 0x4C
		private int prevSegmentCount; // 0x50
		private bool showArc; // 0x54
		private Vector3 startPos; // 0x58
		private Vector3 projectileVelocity; // 0x64
		private bool useGravity; // 0x70
		private Transform arcObjectsTransfrom; // 0x78
		private bool arcInvalid; // 0x80
	
		// Constructors
		public TeleportArc() {} // 0x0000000180EEB2B0-0x0000000180EEB2F0
	
		// Methods
		private void Start() {} // 0x0000000180EEB250-0x0000000180EEB270
		private void Update() {} // 0x0000000180EEB270-0x0000000180EEB2B0
		private void CreateLineRendererObjects() {} // 0x0000000180EEA250-0x0000000180EEA6C0
		public void SetArcData(Vector3 position, Vector3 velocity, bool gravity, bool pointerAtBadAngle) {} // 0x0000000180EEB0D0-0x0000000180EEB160
		public void Show() {} // 0x0000000180EEB230-0x0000000180EEB250
		public void Hide() {} // 0x0000000180EEB040-0x0000000180EEB0D0
		public bool DrawArc(out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x0000000180EEA820-0x0000000180EEAB80
		private void DrawArcSegment(int index, float startTime, float endTime) {} // 0x0000000180EEA6C0-0x0000000180EEA820
		public void SetColor(Color color) {} // 0x0000000180EEB160-0x0000000180EEB230
		private float FindProjectileCollision(out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x0000000180EEAB80-0x0000000180EEAE10
		public Vector3 GetArcPositionAtTime(float time) => default; // 0x0000000180EEAE10-0x0000000180EEAFC0
		private void HideLineSegments(int startSegment, int endSegment) {} // 0x0000000180EEAFC0-0x0000000180EEB040
	}
}
