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
	// [AddComponentMenu] // 0x00000001800FD7C0-0x00000001800FD850
	[ExecuteInEditMode] // 0x00000001800FD7C0-0x00000001800FD850
	// [RequireComponent] // 0x00000001800FD7C0-0x00000001800FD850
	public class EdgeDetection : PostEffectsBase // TypeDefIndex: 5937
	{
		// Fields
		public EdgeDetectMode mode; // 0x20
		public float sensitivityDepth; // 0x24
		public float sensitivityNormals; // 0x28
		public float lumThreshold; // 0x2C
		public float edgeExp; // 0x30
		public float sampleDist; // 0x34
		public float edgesOnly; // 0x38
		public Color edgesOnlyBgColor; // 0x3C
		public Shader edgeDetectShader; // 0x50
		private Material edgeDetectMaterial; // 0x58
		private EdgeDetectMode oldMode; // 0x60
	
		// Nested types
		public enum EdgeDetectMode // TypeDefIndex: 5938
		{
			TriangleDepthNormals = 0,
			RobertsCrossDepthNormals = 1,
			SobelDepth = 2,
			SobelDepthThin = 3,
			TriangleLuminance = 4
		}
	
		// Constructors
		public EdgeDetection() {} // 0x0000000180A3DEA0-0x0000000180A3DF10
	
		// Methods
		public override bool CheckResources() => default; // 0x0000000180A3DB10-0x0000000180A3DB90
		private new void Start() {} // 0x0000000180A3DE90-0x0000000180A3DEA0
		private void SetCameraFlag() {} // 0x0000000180A3DDE0-0x0000000180A3DE90
		private new void OnEnable() {} // 0x0000000180A3DB90-0x0000000180A3DBA0
		[ImageEffectOpaque] // 0x00000001800D4E50-0x00000001800D4E60
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180A3DBA0-0x0000000180A3DDE0
	}
}
