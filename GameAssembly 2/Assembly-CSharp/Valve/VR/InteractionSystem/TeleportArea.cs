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
	public class TeleportArea : TeleportMarkerBase // TypeDefIndex: 8440
	{
		// Fields
		private MeshRenderer areaMesh; // 0x38
		private int tintColorId; // 0x40
		private Color visibleTintColor; // 0x44
		private Color highlightedTintColor; // 0x54
		private Color lockedTintColor; // 0x64
		private bool highlighted; // 0x74
	
		// Properties
		public Bounds meshBounds { get; private set; } // 0x0000000180EEB980-0x0000000180EEB9A0 0x0000000180EEB9A0-0x0000000180EEB9C0
	
		// Constructors
		public TeleportArea() {} // 0x0000000180EEB920-0x0000000180EEB980
	
		// Methods
		public void Awake() {} // 0x0000000180EEB2F0-0x0000000180EEB420
		public void Start() {} // 0x0000000180EEB690-0x0000000180EEB770
		public override bool ShouldActivate(Vector3 playerPosition) => default; // 0x0000000180246BB0-0x0000000180246BC0
		public override bool ShouldMovePlayer() => default; // 0x0000000180246BB0-0x0000000180246BC0
		public override void Highlight(bool highlight) {} // 0x0000000180EEB540-0x0000000180EEB610
		public override void SetAlpha(float tintAlpha, float alphaPercent) {} // 0x0000000180EEB610-0x0000000180EEB690
		public override void UpdateVisuals() {} // 0x0000000180EEB850-0x0000000180EEB920
		public void UpdateVisualsInEditor() {} // 0x0000000180EEB770-0x0000000180EEB850
		private bool CalculateBounds() => default; // 0x0000000180EEB420-0x0000000180EEB510
		private Color GetTintColor() => default; // 0x0000000180EEB510-0x0000000180EEB540
	}
}
