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
	// [AddComponentMenu] // 0x00000001800FC0A0-0x00000001800FC0E0
	[ExecuteInEditMode] // 0x00000001800FC0A0-0x00000001800FC0E0
	public class Blur : MonoBehaviour // TypeDefIndex: 5917
	{
		// Fields
		// [Range] // 0x00000001800DF840-0x00000001800DF860
		public int iterations; // 0x18
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float blurSpread; // 0x1C
		public Shader blurShader; // 0x20
		private static Material m_Material; // 0x00
	
		// Properties
		protected Material material { get => default; } // 0x000000018061AA60-0x000000018061ABB0 
	
		// Constructors
		public Blur() {} // 0x000000018061AA40-0x000000018061AA60
		static Blur() {} // 0x0000000180246DB0-0x0000000180246DC0
	
		// Methods
		protected void OnDisable() {} // 0x000000018061A730-0x000000018061A820
		protected void Start() {} // 0x000000018061A980-0x000000018061AA40
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration) {} // 0x000000018061A510-0x000000018061A730
		private void DownSample4x(RenderTexture source, RenderTexture dest) {} // 0x000000018061A300-0x000000018061A510
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x000000018061A820-0x000000018061A980
	}
}
