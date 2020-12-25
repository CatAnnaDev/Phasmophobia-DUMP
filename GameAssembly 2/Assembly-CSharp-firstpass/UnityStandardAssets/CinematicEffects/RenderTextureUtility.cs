/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.CinematicEffects
{
	public class RenderTextureUtility // TypeDefIndex: 5998
	{
		// Fields
		private List<RenderTexture> m_TemporaryRTs; // 0x10
	
		// Constructors
		public RenderTextureUtility() {} // 0x0000000180624540-0x00000001806245B0
	
		// Methods
		public RenderTexture GetTemporaryRenderTexture(int width, int height, int depthBuffer = 0 /* Metadata: 0x0065097D */, RenderTextureFormat format = RenderTextureFormat.ARGBHalf /* Metadata: 0x00650981 */, FilterMode filterMode = FilterMode.Bilinear /* Metadata: 0x00650985 */) => default; // 0x0000000180624260-0x0000000180624330
		public void ReleaseTemporaryRenderTexture(RenderTexture rt) {} // 0x00000001806243E0-0x0000000180624540
		public void ReleaseAllTemporaryRenderTextures() {} // 0x0000000180624330-0x00000001806243E0
	}
}
