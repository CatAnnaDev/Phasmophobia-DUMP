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
	// [AddComponentMenu] // 0x0000000180102430-0x00000001801024B0
	// [RequireComponent] // 0x0000000180102430-0x00000001801024B0
	internal class TiltShift : PostEffectsBase // TypeDefIndex: 5959
	{
		// Fields
		public TiltShiftMode mode; // 0x20
		public TiltShiftQuality quality; // 0x24
		// [Range] // 0x0000000180102670-0x0000000180102690
		public float blurArea; // 0x28
		// [Range] // 0x0000000180102760-0x0000000180102780
		public float maxBlurSize; // 0x2C
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public int downsample; // 0x30
		public Shader tiltShiftShader; // 0x38
		private Material tiltShiftMaterial; // 0x40
	
		// Nested types
		public enum TiltShiftMode // TypeDefIndex: 5960
		{
			TiltShiftMode = 0,
			IrisMode = 1
		}
	
		public enum TiltShiftQuality // TypeDefIndex: 5961
		{
			Preview = 0,
			Normal = 1,
			High = 2
		}
	
		// Constructors
		public TiltShift() {} // 0x0000000180A47B60-0x0000000180A47B90
	
		// Methods
		public override bool CheckResources() => default; // 0x0000000180A47850-0x0000000180A478B0
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180A478B0-0x0000000180A47B60
	}
}
