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
	// [AddComponentMenu] // 0x00000001800FCDC0-0x00000001800FCE00
	[ExecuteInEditMode] // 0x00000001800FCDC0-0x00000001800FCE00
	public class ContrastStretch : MonoBehaviour // TypeDefIndex: 5927
	{
		// Fields
		// [Range] // 0x00000001800FCEE0-0x00000001800FCF00
		public float adaptationSpeed; // 0x18
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float limitMinimum; // 0x1C
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float limitMaximum; // 0x20
		private RenderTexture[] adaptRenderTex; // 0x28
		private int curAdaptIndex; // 0x30
		public Shader shaderLum; // 0x38
		private Material m_materialLum; // 0x40
		public Shader shaderReduce; // 0x48
		private Material m_materialReduce; // 0x50
		public Shader shaderAdapt; // 0x58
		private Material m_materialAdapt; // 0x60
		public Shader shaderApply; // 0x68
		private Material m_materialApply; // 0x70
	
		// Properties
		protected Material materialLum { get => default; } // 0x0000000180620BF0-0x0000000180620CB0 
		protected Material materialReduce { get => default; } // 0x0000000180620CB0-0x0000000180620D70 
		protected Material materialAdapt { get => default; } // 0x0000000180620A70-0x0000000180620B30 
		protected Material materialApply { get => default; } // 0x0000000180620B30-0x0000000180620BF0 
	
		// Constructors
		public ContrastStretch() {} // 0x0000000180620A00-0x0000000180620A70
	
		// Methods
		private void Start() {} // 0x0000000180620970-0x0000000180620A00
		private void OnEnable() {} // 0x0000000180620510-0x0000000180620660
		private void OnDisable() {} // 0x00000001806202A0-0x0000000180620510
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180620660-0x0000000180620970
		private void CalculateAdaptation(Texture curTexture) {} // 0x0000000180620030-0x00000001806202A0
	}
}
