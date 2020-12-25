/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace LIV.SDK.Unity
{
	// [AddComponentMenu] // 0x00000001800E65A0-0x00000001800E6600
	// [HelpURL] // 0x00000001800E65A0-0x00000001800E6600
	public class LIV : MonoBehaviour // TypeDefIndex: 8570
	{
		// Fields
		public Action onActivate; // 0x18
		public Action onDeactivate; // 0x20
		public Action<SDKRender> onPreRender; // 0x28
		public Action<SDKRender> onPostRender; // 0x30
		public Action<SDKRender> onPreRenderForeground; // 0x38
		public Action<SDKRender> onPostRenderForeground; // 0x40
		public Action<SDKRender> onPreRenderBackground; // 0x48
		public Action<SDKRender> onPostRenderBackground; // 0x50
		// [FormerlySerializedAs] // 0x00000001800E6700-0x00000001800E6770
		[SerializeField] // 0x00000001800E6700-0x00000001800E6770
		// [Tooltip] // 0x00000001800E6700-0x00000001800E6770
		private Transform _stage; // 0x58
		// [FormerlySerializedAs] // 0x00000001800E6910-0x00000001800E6980
		[SerializeField] // 0x00000001800E6910-0x00000001800E6980
		// [Tooltip] // 0x00000001800E6910-0x00000001800E6980
		private Transform _stageTransform; // 0x60
		// [FormerlySerializedAs] // 0x00000001800E6A30-0x00000001800E6AA0
		[SerializeField] // 0x00000001800E6A30-0x00000001800E6AA0
		// [Tooltip] // 0x00000001800E6A30-0x00000001800E6AA0
		private Camera _HMDCamera; // 0x68
		// [FormerlySerializedAs] // 0x00000001800E6BA0-0x00000001800E6C10
		[SerializeField] // 0x00000001800E6BA0-0x00000001800E6C10
		// [Tooltip] // 0x00000001800E6BA0-0x00000001800E6C10
		private Camera _MRCameraPrefab; // 0x70
		// [FormerlySerializedAs] // 0x00000001800E7F00-0x00000001800E7F70
		[SerializeField] // 0x00000001800E7F00-0x00000001800E7F70
		// [Tooltip] // 0x00000001800E7F00-0x00000001800E7F70
		private bool _disableStandardAssets; // 0x78
		// [FormerlySerializedAs] // 0x00000001800E8310-0x00000001800E8380
		[SerializeField] // 0x00000001800E8310-0x00000001800E8380
		// [Tooltip] // 0x00000001800E8310-0x00000001800E8380
		private LayerMask _spectatorLayerMask; // 0x7C
		// [FormerlySerializedAs] // 0x00000001800E84A0-0x00000001800E8510
		[SerializeField] // 0x00000001800E84A0-0x00000001800E8510
		// [Tooltip] // 0x00000001800E84A0-0x00000001800E8510
		private string[] _excludeBehaviours; // 0x80
		// [FormerlySerializedAs] // 0x00000001800E8640-0x00000001800E86B0
		[SerializeField] // 0x00000001800E8640-0x00000001800E86B0
		// [Tooltip] // 0x00000001800E8640-0x00000001800E86B0
		private bool _fixPostEffectsAlpha; // 0x88
		private SDKRender _render; // 0x90
		private bool _wasActive; // 0x98
		private INVALIDATION_FLAGS _invalidate; // 0x9C
		private Transform _stageCandidate; // 0xA0
		private Camera _HMDCameraCandidate; // 0xA8
		private Camera _MRCameraPrefabCandidate; // 0xB0
		private string[] _excludeBehavioursCandidate; // 0xB8
		private bool _enabled; // 0xC0
		private Coroutine _waitForEndOfFrameCoroutine; // 0xC8
	
		// Properties
		public Transform stage { get => default; set {} } // 0x00000001818078B0-0x0000000181807950 0x0000000181807B60-0x0000000181808020
		[Obsolete] // 0x00000001800E88B0-0x00000001800E88E0
		public Transform trackedSpaceOrigin { get => default; set {} } // 0x0000000181807950-0x0000000181807960 0x0000000181807B60-0x0000000181808020
		public Matrix4x4 stageLocalToWorldMatrix { get => default; } // 0x00000001818076D0-0x00000001818077C0 
		public Matrix4x4 stageWorldToLocalMatrix { get => default; } // 0x00000001818077C0-0x00000001818078B0 
		public Transform stageTransform { get => default; set {} } // 0x0000000180274940-0x0000000180274950 0x0000000180280570-0x0000000180280580
		public Camera HMDCamera { get => default; set {} } // 0x0000000180274930-0x0000000180274940 0x0000000181807960-0x0000000181807A60
		public Camera MRCameraPrefab { get => default; set {} } // 0x0000000180274980-0x0000000180274990 0x0000000181807A60-0x0000000181807B10
		public bool disableStandardAssets { get => default; set {} } // 0x000000018074A720-0x000000018074A730 0x000000018074A790-0x000000018074A7A0
		public LayerMask spectatorLayerMask { get => default; set {} } // 0x0000000180422DD0-0x0000000180422DE0 0x0000000180AF8E80-0x0000000180AF8E90
		public string[] excludeBehaviours { get => default; set {} } // 0x0000000180274900-0x0000000180274910 0x0000000181807B10-0x0000000181807B60
		public bool fixPostEffectsAlpha { get => default; set {} } // 0x00000001802E9350-0x00000001802E9360 0x00000001802E9980-0x00000001802E9990
		public bool isValid { get => default; } // 0x0000000181807570-0x00000001818076D0 
		public bool isActive { get => default; } // 0x00000001818072D0-0x0000000181807570 
		public SDKRender render { get => default; } // 0x0000000180274960-0x0000000180274970 
	
		// Constructors
		public LIV() {} // 0x0000000181807050-0x00000001818072D0
	
		// Methods
		private void OnEnable() {} // 0x0000000181806400-0x0000000181806450
		private void Update() {} // 0x0000000181806F90-0x0000000181806FE0
		private void OnDisable() {} // 0x00000001818063B0-0x0000000181806400
		// [IteratorStateMachine] // 0x00000001800E8800-0x00000001800E8850
		private IEnumerator WaitForUnityEndOfFrame() => default; // 0x0000000181806FE0-0x0000000181807050
		private void UpdateSDKActive() {} // 0x0000000181806F50-0x0000000181806F90
		private void OnSDKActiveChanged(bool value) {} // 0x00000001818065F0-0x0000000181806860
		private void OnSDKActivate() {} // 0x0000000181806450-0x00000001818065F0
		private void OnSDKDeactivate() {} // 0x0000000181806860-0x0000000181806930
		private void CreateAssets() {} // 0x0000000181806130-0x00000001818061D0
		private void DestroyAssets() {} // 0x00000001818061D0-0x0000000181806210
		private void StartRenderCoroutine() {} // 0x0000000181806930-0x00000001818069F0
		private void StopRenderCoroutine() {} // 0x00000001818069F0-0x0000000181806A30
		private void SubmitSDKOutput() {} // 0x0000000181806A30-0x0000000181806F50
		private void Invalidate() {} // 0x0000000181806210-0x00000001818063B0
	}
}
