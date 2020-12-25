/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	public class TeleportPoint : TeleportMarkerBase // TypeDefIndex: 8442
	{
		// Fields
		public TeleportPointType teleportType; // 0x20
		public string title; // 0x28
		public string switchToScene; // 0x30
		public Color titleVisibleColor; // 0x38
		public Color titleHighlightedColor; // 0x48
		public Color titleLockedColor; // 0x58
		public bool playerSpawnPoint; // 0x68
		private bool gotReleventComponents; // 0x69
		private MeshRenderer markerMesh; // 0x70
		private MeshRenderer switchSceneIcon; // 0x78
		private MeshRenderer moveLocationIcon; // 0x80
		private MeshRenderer lockedIcon; // 0x88
		private MeshRenderer pointIcon; // 0x90
		private Transform lookAtJointTransform; // 0x98
		private Animation animation; // 0xA0
		private UnityEngine.UI.Text titleText; // 0xA8
		private Player player; // 0xB0
		private Vector3 lookAtPosition; // 0xB8
		private int tintColorID; // 0xC4
		private Color tintColor; // 0xC8
		private Color titleColor; // 0xD8
		private float fullTitleAlpha; // 0xE8
		private const string switchSceneAnimation = "switch_scenes_idle"; // Metadata: 0x0065591D
		private const string moveLocationAnimation = "move_location_idle"; // Metadata: 0x00655933
		private const string lockedAnimation = "locked_idle"; // Metadata: 0x00655949
	
		// Properties
		public override bool showReticle { get => default; } // 0x0000000180250A70-0x0000000180250A80 
	
		// Nested types
		public enum TeleportPointType // TypeDefIndex: 8443
		{
			MoveToLocation = 0,
			SwitchToNewScene = 1
		}
	
		// Constructors
		public TeleportPoint() {} // 0x0000000180EEC9E0-0x0000000180EECA90
	
		// Methods
		private void Awake() {} // 0x0000000180EEB9F0-0x0000000180EEBAE0
		private void Start() {} // 0x0000000180EEC200-0x0000000180EEC230
		private void Update() {} // 0x0000000180EEC8B0-0x0000000180EEC9E0
		public override bool ShouldActivate(Vector3 playerPosition) => default; // 0x0000000180EEC130-0x0000000180EEC200
		public override bool ShouldMovePlayer() => default; // 0x0000000180246BB0-0x0000000180246BC0
		public override void Highlight(bool highlight) {} // 0x0000000180EEBCD0-0x0000000180EEBE30
		public override void UpdateVisuals() {} // 0x0000000180EEC700-0x0000000180EEC8B0
		public override void SetAlpha(float tintAlpha, float alphaPercent) {} // 0x0000000180EEBEB0-0x0000000180EEC060
		public void SetMeshMaterials(Material material, Color textColor) {} // 0x0000000180EEC060-0x0000000180EEC130
		public void TeleportToScene() {} // 0x0000000180EEC230-0x0000000180EEC2F0
		public void GetRelevantComponents() {} // 0x0000000180EEBAE0-0x0000000180EEBCD0
		public void ReleaseRelevantComponents() {} // 0x0000000180EEBE30-0x0000000180EEBEB0
		public void UpdateVisualsInEditor() {} // 0x0000000180EEC2F0-0x0000000180EEC700
	}
}
