/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	public class ControllerButtonHints : MonoBehaviour // TypeDefIndex: 8407
	{
		// Fields
		public Material controllerMaterial; // 0x18
		public Color flashColor; // 0x20
		public GameObject textHintPrefab; // 0x30
		// [Header] // 0x00000001800D7660-0x00000001800D7690
		public bool debugHints; // 0x38
		private SteamVR_RenderModel renderModel; // 0x40
		private Player player; // 0x48
		private List<MeshRenderer> renderers; // 0x50
		private List<MeshRenderer> flashingRenderers; // 0x58
		private float startTime; // 0x60
		private float tickCount; // 0x64
		private Dictionary<EVRButtonId, ButtonHintInfo> buttonHintInfos; // 0x68
		private Transform textHintParent; // 0x70
		private List<KeyValuePair<string, ulong>> componentButtonMasks; // 0x78
		private int colorID; // 0x80
		private Vector3 centerPosition; // 0x88
		private SteamVR_Events.Action renderModelLoadedAction; // 0x98
	
		// Properties
		public bool initialized { get; private set; } // 0x00000001809AE610-0x00000001809AE620 0x00000001809AE620-0x00000001809AE630
	
		// Nested types
		private enum OffsetType // TypeDefIndex: 8408
		{
			Up = 0,
			Right = 1,
			Forward = 2,
			Back = 3
		}
	
		private class ButtonHintInfo // TypeDefIndex: 8409
		{
			// Fields
			public string componentName; // 0x10
			public List<MeshRenderer> renderers; // 0x18
			public Transform localTransform; // 0x20
			public GameObject textHintObject; // 0x28
			public Transform textStartAnchor; // 0x30
			public Transform textEndAnchor; // 0x38
			public Vector3 textEndOffsetDir; // 0x40
			public Transform canvasOffset; // 0x50
			public UnityEngine.UI.Text text; // 0x58
			public TextMesh textMesh; // 0x60
			public Canvas textCanvas; // 0x68
			public LineRenderer line; // 0x70
			public float distanceFromCenter; // 0x78
			public bool textHintActive; // 0x7C
	
			// Constructors
			public ButtonHintInfo() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		// Constructors
		public ControllerButtonHints() {} // 0x0000000180FBF240-0x0000000180FBF380
	
		// Methods
		private void Awake() {} // 0x0000000180FBA8B0-0x0000000180FBA960
		private void Start() {} // 0x0000000180FBE950-0x0000000180FBE980
		private void HintDebugLog(string msg) {} // 0x0000000180FBD300-0x0000000180FBD380
		private void OnEnable() {} // 0x0000000180FBD670-0x0000000180FBD6A0
		private void OnDisable() {} // 0x0000000180FBD600-0x0000000180FBD670
		private void OnParentHandInputFocusLost() {} // 0x0000000180FBD8D0-0x0000000180FBD8F0
		private void OnHandInitialized(int deviceIndex) {} // 0x0000000180FBD6A0-0x0000000180FBD8D0
		private void OnRenderModelLoaded(SteamVR_RenderModel renderModel, bool succeess) {} // 0x0000000180FBD8F0-0x0000000180FBE160
		private void CreateAndAddButtonInfo(EVRButtonId buttonID) {} // 0x0000000180FBB1B0-0x0000000180FBC730
		private void ComputeTextEndTransforms() {} // 0x0000000180FBA9C0-0x0000000180FBB1B0
		private void ShowButtonHint(params /* 0x00000001800D4E50-0x00000001800D4E60 */ EVRButtonId[] buttons) {} // 0x0000000180FBE160-0x0000000180FBE620
		private void HideAllButtonHints() {} // 0x0000000180FBCA50-0x0000000180FBCAD0
		private void HideButtonHint(params /* 0x00000001800D4E50-0x00000001800D4E60 */ EVRButtonId[] buttons) {} // 0x0000000180FBCDD0-0x0000000180FBD0E0
		private bool IsButtonHintActive(EVRButtonId button) => default; // 0x0000000180FBD380-0x0000000180FBD560
		// [IteratorStateMachine] // 0x0000000180146D70-0x0000000180146DC0
		private IEnumerator TestButtonHints() => default; // 0x0000000180FBE980-0x0000000180FBE9F0
		// [IteratorStateMachine] // 0x0000000180146FD0-0x0000000180147020
		private IEnumerator TestTextHints() => default; // 0x0000000180FBE9F0-0x0000000180FBEA60
		private void Update() {} // 0x0000000180FBEE40-0x0000000180FBF240
		private void UpdateTextHint(ButtonHintInfo hintInfo) {} // 0x0000000180FBEA60-0x0000000180FBEE40
		private void Clear() {} // 0x0000000180FBA960-0x0000000180FBA9C0
		private void ShowText(EVRButtonId button, string text, bool highlightButton = true /* Metadata: 0x006558AF */) {} // 0x0000000180FBE770-0x0000000180FBE950
		private void HideText(EVRButtonId button) {} // 0x0000000180FBD220-0x0000000180FBD300
		private void HideAllText() {} // 0x0000000180FBCB50-0x0000000180FBCD40
		private string GetActiveHintText(EVRButtonId button) => default; // 0x0000000180FBC730-0x0000000180FBC7E0
		private static ControllerButtonHints GetControllerButtonHints(Hand hand) => default; // 0x0000000180FBC910-0x0000000180FBC9D0
		public static void ShowButtonHint(Hand hand, params /* 0x00000001800D4E50-0x00000001800D4E60 */ EVRButtonId[] buttons) {} // 0x0000000180FBE620-0x0000000180FBE6B0
		public static void HideButtonHint(Hand hand, params /* 0x00000001800D4E50-0x00000001800D4E60 */ EVRButtonId[] buttons) {} // 0x0000000180FBCD40-0x0000000180FBCDD0
		public static void HideAllButtonHints(Hand hand) {} // 0x0000000180FBC9D0-0x0000000180FBCA50
		public static bool IsButtonHintActive(Hand hand, EVRButtonId button) => default; // 0x0000000180FBD560-0x0000000180FBD600
		public static void ShowTextHint(Hand hand, EVRButtonId button, string text, bool highlightButton = true /* Metadata: 0x006558B0 */) {} // 0x0000000180FBE6B0-0x0000000180FBE770
		public static void HideTextHint(Hand hand, EVRButtonId button) {} // 0x0000000180FBD0E0-0x0000000180FBD220
		public static void HideAllTextHints(Hand hand) {} // 0x0000000180FBCAD0-0x0000000180FBCB50
		public static string GetActiveHintText(Hand hand, EVRButtonId button) => default; // 0x0000000180FBC7E0-0x0000000180FBC910
	}
}
