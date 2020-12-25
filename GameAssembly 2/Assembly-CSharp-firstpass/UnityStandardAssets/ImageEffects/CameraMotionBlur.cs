/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.ImageEffects
{
	// [AddComponentMenu] // 0x00000001800FC600-0x00000001800FC690
	[ExecuteInEditMode] // 0x00000001800FC600-0x00000001800FC690
	// [RequireComponent] // 0x00000001800FC600-0x00000001800FC690
	public class CameraMotionBlur : PostEffectsBase // TypeDefIndex: 5920
	{
		// Fields
		private static float MAX_RADIUS; // 0x00
		public MotionBlurFilter filterType; // 0x20
		public bool preview; // 0x24
		public Vector3 previewScale; // 0x28
		public float movementScale; // 0x34
		public float rotationScale; // 0x38
		public float maxVelocity; // 0x3C
		public float minVelocity; // 0x40
		public float velocityScale; // 0x44
		public float softZDistance; // 0x48
		public int velocityDownsample; // 0x4C
		public LayerMask excludeLayers; // 0x50
		private GameObject tmpCam; // 0x58
		public Shader shader; // 0x60
		public Shader dx11MotionBlurShader; // 0x68
		public Shader replacementClear; // 0x70
		private Material motionBlurMaterial; // 0x78
		private Material dx11MotionBlurMaterial; // 0x80
		public Texture2D noiseTexture; // 0x88
		public float jitter; // 0x90
		public bool showVelocity; // 0x94
		public float showVelocityScale; // 0x98
		private Matrix4x4 currentViewProjMat; // 0x9C
		private Matrix4x4 prevViewProjMat; // 0xDC
		private int prevFrameCount; // 0x11C
		private bool wasActive; // 0x120
		private Vector3 prevFrameForward; // 0x124
		private Vector3 prevFrameUp; // 0x130
		private Vector3 prevFramePos; // 0x13C
		private Camera _camera; // 0x148
	
		// Nested types
		public enum MotionBlurFilter // TypeDefIndex: 5921
		{
			CameraMotion = 0,
			LocalBlur = 1,
			Reconstruction = 2,
			ReconstructionDX11 = 3,
			ReconstructionDisc = 4
		}
	
		// Constructors
		public CameraMotionBlur() {} // 0x000000018061D520-0x000000018061D640
		static CameraMotionBlur() {} // 0x000000018061D4E0-0x000000018061D520
	
		// Methods
		private void CalculateViewProjection() {} // 0x000000018061AFC0-0x000000018061B1A0
		private new void Start() {} // 0x000000018061D3F0-0x000000018061D4E0
		private new void OnEnable() {} // 0x000000018061B7F0-0x000000018061B8C0
		private void OnDisable() {} // 0x000000018061B650-0x000000018061B7F0
		public override bool CheckResources() => default; // 0x000000018061B1A0-0x000000018061B240
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x000000018061B8C0-0x000000018061D1F0
		private void Remember() {} // 0x000000018061D1F0-0x000000018061D2E0
		private Camera GetTmpCam() => default; // 0x000000018061B240-0x000000018061B650
		private void StartFrame() {} // 0x000000018061D2E0-0x000000018061D3F0
		private static int divRoundUp(int x, int d) => default; // 0x000000018061D640-0x000000018061D650
	}
}
