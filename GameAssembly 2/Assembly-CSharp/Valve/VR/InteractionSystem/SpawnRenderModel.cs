/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	public class SpawnRenderModel : MonoBehaviour // TypeDefIndex: 8395
	{
		// Fields
		public Material[] materials; // 0x18
		private SteamVR_RenderModel[] renderModels; // 0x20
		private Hand hand; // 0x28
		private List<MeshRenderer> renderers; // 0x30
		private static List<SpawnRenderModel> spawnRenderModels; // 0x00
		private static int lastFrameUpdated; // 0x08
		private static int spawnRenderModelUpdateIndex; // 0x0C
		private SteamVR_Events.Action renderModelLoadedAction; // 0x38
	
		// Constructors
		public SpawnRenderModel() {} // 0x0000000180EEA1E0-0x0000000180EEA250
		static SpawnRenderModel() {} // 0x0000000180EEA180-0x0000000180EEA1E0
	
		// Methods
		private void Awake() {} // 0x0000000180EE93B0-0x0000000180EE9480
		private void OnEnable() {} // 0x0000000180EE96A0-0x0000000180EE9740
		private void OnDisable() {} // 0x0000000180EE9600-0x0000000180EE96A0
		private void OnAttachedToHand(Hand hand) {} // 0x0000000180EE95A0-0x0000000180EE95D0
		private void OnDetachedFromHand(Hand hand) {} // 0x0000000180EE95D0-0x0000000180EE9600
		private void Update() {} // 0x0000000180EE9DC0-0x0000000180EEA180
		private void ShowController() {} // 0x0000000180EE9AA0-0x0000000180EE9DC0
		private void HideController() {} // 0x0000000180EE9480-0x0000000180EE95A0
		private void OnRenderModelLoaded(SteamVR_RenderModel renderModel, bool success) {} // 0x0000000180EE9740-0x0000000180EE9AA0
	}
}
