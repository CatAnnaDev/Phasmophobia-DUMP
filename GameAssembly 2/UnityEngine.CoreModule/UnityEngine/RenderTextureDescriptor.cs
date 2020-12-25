/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	public struct RenderTextureDescriptor // TypeDefIndex: 3208
	{
		// Fields
		private GraphicsFormat _graphicsFormat; // 0x14
		private int _depthBufferBits; // 0x1C
		private static int[] depthFormatBits; // 0x00
		private RenderTextureCreationFlags _flags; // 0x2C
	
		// Properties
		public int width { get; set; } // 0x000000018000B580-0x000000018000B590 0x00000001800163C0-0x00000001800163D0
		public int height { get; set; } // 0x0000000180022C20-0x0000000180022C30 0x0000000180022C60-0x0000000180022C70
		public int msaaSamples { get; set; } // 0x0000000180006CC0-0x0000000180006D60 0x0000000180008030-0x0000000180008060
		public int volumeDepth { get; set; } // 0x0000000180006B70-0x0000000180006C90 0x0000000180022C70-0x0000000180022C80
		public int mipCount { get; set; } // 0x000000018001EA40-0x000000018001EA50
		public GraphicsFormat graphicsFormat { get => default; set {} } // 0x00000001800350A0-0x00000001800350B0 0x00000001800351F0-0x0000000180035230
		public RenderTextureFormat colorFormat { get => default; set {} } // 0x0000000180034FF0-0x0000000180035000 0x0000000180035100-0x0000000180035190
		public bool sRGB { get => default; set {} } // 0x00000001800350B0-0x00000001800350C0 0x0000000180035240-0x00000001800352A0
		public int depthBufferBits { get => default; set {} } // 0x0000000180035000-0x0000000180035090 0x00000001800351B0-0x00000001800351D0
		public TextureDimension dimension { get; set; } // 0x0000000180020680-0x0000000180020690 0x0000000180020750-0x0000000180020760
		public ShadowSamplingMode shadowSamplingMode { get; set; } // 0x00000001800350C0-0x00000001800350D0 0x0000000180024760-0x0000000180024800
		public VRTextureUsage vrUsage { get; set; } // 0x0000000180003BD0-0x0000000180003BE0 0x000000018000CEA0-0x000000018000CED0
		public RenderTextureMemoryless memoryless { get; set; } // 0x0000000180020980-0x0000000180020990 0x0000000180035230-0x0000000180035240
		public bool useMipMap { get => default; set {} } // 0x00000001800350D0-0x00000001800350E0 0x00000001800352C0-0x00000001800352E0
		public bool autoGenerateMips { get => default; set {} } // 0x0000000180034FE0-0x0000000180034FF0 0x00000001800350E0-0x0000000180035100
		public bool enableRandomWrite { get => default; set {} } // 0x0000000180035090-0x00000001800350A0 0x00000001800351D0-0x00000001800351F0
		internal bool createdFromScript { set {} } // 0x0000000180035190-0x00000001800351B0
		public bool useDynamicScale { set {} } // 0x00000001800352A0-0x00000001800352C0
	
		// Constructors
		public RenderTextureDescriptor(int width, int height) : this() {
			_graphicsFormat = default;
			_depthBufferBits = default;
			_flags = default;
		} // 0x0000000180034EB0-0x0000000180034FD0
		public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits) : this() {
			_graphicsFormat = default;
			_depthBufferBits = default;
			_flags = default;
		} // 0x0000000180034E20-0x0000000180034EB0
		public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits) : this() {
			_graphicsFormat = default;
			_depthBufferBits = default;
			_flags = default;
		} // 0x0000000180034FD0-0x0000000180034FE0
		public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits, int mipCount) : this() {
			_graphicsFormat = default;
			_depthBufferBits = default;
			_flags = default;
		} // 0x0000000180034E10-0x0000000180034E20
		static RenderTextureDescriptor() {
			depthFormatBits = default;
		} // 0x00000001808D8820-0x00000001808D8E20
	
		// Methods
		private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) {} // 0x0000000180034DF0-0x0000000180034E10
	}
}
