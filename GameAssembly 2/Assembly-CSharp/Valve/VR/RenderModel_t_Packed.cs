/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public struct RenderModel_t_Packed // TypeDefIndex: 8334
	{
		// Fields
		public IntPtr rVertexData; // 0x00
		public uint unVertexCount; // 0x08
		public IntPtr rIndexData; // 0x0C
		public uint unTriangleCount; // 0x14
		public int diffuseTextureId; // 0x18
	
		// Constructors
		public RenderModel_t_Packed(RenderModel_t unpacked) {
			rVertexData = default;
			unVertexCount = default;
			rIndexData = default;
			unTriangleCount = default;
			diffuseTextureId = default;
		} // 0x00000001801DA100-0x00000001801DA370
	
		// Methods
		public void Unpack(ref RenderModel_t unpacked) {} // 0x00000001801DA0D0-0x00000001801DA100
	}
}
