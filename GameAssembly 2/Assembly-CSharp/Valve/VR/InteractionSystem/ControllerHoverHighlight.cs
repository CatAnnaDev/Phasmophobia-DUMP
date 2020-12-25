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
	public class ControllerHoverHighlight : MonoBehaviour // TypeDefIndex: 8346
	{
		// Fields
		public Material highLightMaterial; // 0x18
		public bool fireHapticsOnHightlight; // 0x20
		private Hand hand; // 0x28
		private MeshRenderer bodyMeshRenderer; // 0x30
		private MeshRenderer trackingHatMeshRenderer; // 0x38
		private SteamVR_RenderModel renderModel; // 0x40
		private bool renderModelLoaded; // 0x48
		private SteamVR_Events.Action renderModelLoadedAction; // 0x50
	
		// Constructors
		public ControllerHoverHighlight() {} // 0x00000001806F2EC0-0x00000001806F2ED0
	
		// Methods
		private void Start() {} // 0x0000000180FC02D0-0x0000000180FC0320
		private void Awake() {} // 0x0000000180FBF7D0-0x0000000180FBF870
		private void OnEnable() {} // 0x0000000180FBF9B0-0x0000000180FBF9E0
		private void OnDisable() {} // 0x0000000180FBF980-0x0000000180FBF9B0
		private void OnHandInitialized(int deviceIndex) {} // 0x0000000180FBF9E0-0x0000000180FBFA70
		private void OnRenderModelLoaded(SteamVR_RenderModel renderModel, bool success) {} // 0x0000000180FBFC90-0x0000000180FC01C0
		private void OnParentHandHoverBegin(Interactable other) {} // 0x0000000180FBFA70-0x0000000180FBFB50
		private void OnParentHandHoverEnd(Interactable other) {} // 0x0000000180FBFB50-0x0000000180FBFB60
		private void OnParentHandInputFocusAcquired() {} // 0x0000000180FBFB60-0x0000000180FBFC90
		private void OnParentHandInputFocusLost() {} // 0x0000000180FBFB50-0x0000000180FBFB60
		public void ShowHighlight() {} // 0x0000000180FC01C0-0x0000000180FC02D0
		public void HideHighlight() {} // 0x0000000180FBF870-0x0000000180FBF980
	}
}
