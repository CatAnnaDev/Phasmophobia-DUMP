/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.CinematicEffects
{
	// [AddComponentMenu] // 0x0000000180108B40-0x0000000180108BE0
	[ExecuteInEditMode] // 0x0000000180108B40-0x0000000180108BE0
	[ImageEffectAllowedInSceneView] // 0x0000000180108B40-0x0000000180108BE0
	// [RequireComponent] // 0x0000000180108B40-0x0000000180108BE0
	public class Bloom : MonoBehaviour // TypeDefIndex: 5994
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		public Settings settings; // 0x18
		[HideInInspector] // 0x00000001800D5490-0x00000001800D54C0
		[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
		private Shader m_Shader; // 0x30
		private Material m_Material; // 0x38
		private const int kMaxIterations = 16; // Metadata: 0x00650979
		private RenderTexture[] m_blurBuffer1; // 0x40
		private RenderTexture[] m_blurBuffer2; // 0x48
	
		// Properties
		public Shader shader { get => default; } // 0x000000018082C810-0x000000018082C8A0 
		public Material material { get => default; } // 0x000000018082C770-0x000000018082C810 
	
		// Nested types
		[Serializable]
		public struct Settings // TypeDefIndex: 5995
		{
			// Fields
			[SerializeField] // 0x0000000180109070-0x00000001801090B0
			// [Tooltip] // 0x0000000180109070-0x00000001801090B0
			public float threshold; // 0x00
			// [Range] // 0x0000000180109170-0x00000001801091D0
			[SerializeField] // 0x0000000180109170-0x00000001801091D0
			// [Tooltip] // 0x0000000180109170-0x00000001801091D0
			public float softKnee; // 0x04
			// [Range] // 0x0000000180109480-0x00000001801094E0
			[SerializeField] // 0x0000000180109480-0x00000001801094E0
			// [Tooltip] // 0x0000000180109480-0x00000001801094E0
			public float radius; // 0x08
			[SerializeField] // 0x000000018010A9B0-0x000000018010A9F0
			// [Tooltip] // 0x000000018010A9B0-0x000000018010A9F0
			public float intensity; // 0x0C
			[SerializeField] // 0x000000018010AB10-0x000000018010AB50
			// [Tooltip] // 0x000000018010AB10-0x000000018010AB50
			public bool highQuality; // 0x10
			[SerializeField] // 0x000000018010AB90-0x000000018010ABD0
			// [Tooltip] // 0x000000018010AB90-0x000000018010ABD0
			public bool antiFlicker; // 0x11
	
			// Properties
			public float thresholdGamma { get => default; set {} } // 0x0000000180030420-0x0000000180030490 0x000000018000FCF0-0x000000018000FD00
			public float thresholdLinear { get => default; set {} } // 0x0000000180030490-0x00000001800304A0 0x00000001800304A0-0x0000000180030D20
			public static Settings defaultSettings { get => default; } // 0x0000000180836D00-0x0000000180836DE0 
		}
	
		// Constructors
		public Bloom() {} // 0x000000018082C6E0-0x000000018082C770
	
		// Methods
		private void OnEnable() {} // 0x000000018082BD30-0x000000018082BD80
		private void OnDisable() {} // 0x000000018082BC80-0x000000018082BD30
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x000000018082BD80-0x000000018082C6E0
	}
}
