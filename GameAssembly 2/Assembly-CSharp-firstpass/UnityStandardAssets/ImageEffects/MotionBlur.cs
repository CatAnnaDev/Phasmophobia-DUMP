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
	// [AddComponentMenu] // 0x00000001800FFF60-0x00000001800FFFF0
	[ExecuteInEditMode] // 0x00000001800FFF60-0x00000001800FFFF0
	// [RequireComponent] // 0x00000001800FFF60-0x00000001800FFFF0
	public class MotionBlur : ImageEffectBase // TypeDefIndex: 5944
	{
		// Fields
		// [Range] // 0x0000000180100130-0x0000000180100150
		public float blurAmount; // 0x28
		public bool extraBlur; // 0x2C
		private RenderTexture accumTexture; // 0x30
	
		// Constructors
		public MotionBlur() {} // 0x0000000180A40120-0x0000000180A40130
	
		// Methods
		protected override void Start() {} // 0x0000000180A40070-0x0000000180A40120
		protected override void OnDisable() {} // 0x0000000180A3FBE0-0x0000000180A3FCC0
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180A3FCC0-0x0000000180A40070
	}
}
