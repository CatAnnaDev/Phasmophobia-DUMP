/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001801438A0-0x0000000180143940
	// [NativeHeader] // 0x00000001801438A0-0x0000000180143940
	// [NativeHeader] // 0x00000001801438A0-0x0000000180143940
	// [NativeHeader] // 0x00000001801438A0-0x0000000180143940
	public sealed class MaterialPropertyBlock // TypeDefIndex: 3154
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Constructors
		public MaterialPropertyBlock() {} // 0x0000000180931A50-0x0000000180931A90
	
		// Methods
		// [NativeName] // 0x0000000180143C30-0x0000000180143C60
		private Vector4 GetVectorImpl(int name) => default; // 0x0000000180931460-0x00000001809314D0
		// [NativeName] // 0x0000000180145110-0x0000000180145140
		private void SetFloatImpl(int name, float value) {} // 0x00000001809316F0-0x0000000180931740
		// [NativeName] // 0x0000000180145260-0x0000000180145290
		private void SetVectorImpl(int name, Vector4 value) {} // 0x00000001809319B0-0x0000000180931A00
		// [NativeName] // 0x00000001801454D0-0x0000000180145500
		private void SetColorImpl(int name, Color value) {} // 0x00000001809315F0-0x0000000180931640
		// [NativeName] // 0x0000000180145530-0x0000000180145560
		private void SetMatrixImpl(int name, Matrix4x4 value) {} // 0x00000001809317F0-0x0000000180931840
		// [NativeName] // 0x0000000180145680-0x00000001801456B0
		private void SetTextureImpl(int name, [NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ Texture value) {} // 0x00000001809318B0-0x0000000180931900
		// [NativeName] // 0x0000000180145860-0x0000000180145890
		private void SetBufferImpl(int name, ComputeBuffer value) {} // 0x0000000180931550-0x00000001809315A0
		[NativeMethod] // 0x0000000180145950-0x0000000180145990
		private static IntPtr CreateImpl() => default; // 0x00000001809311F0-0x0000000180931220
		[NativeMethod] // 0x0000000180145A50-0x0000000180145A90
		private static void DestroyImpl(IntPtr mpb) {} // 0x0000000180931220-0x0000000180931260
		private void Clear(bool keepMemory) {} // 0x00000001809311A0-0x00000001809311F0
		public void Clear() {} // 0x0000000180931160-0x00000001809311A0
		~MaterialPropertyBlock() {} // 0x0000000180931300-0x0000000180931410
		private void Dispose() {} // 0x0000000180931260-0x0000000180931300
		public void SetFloat(string name, float value) {} // 0x0000000180931740-0x00000001809317A0
		public void SetFloat(int nameID, float value) {} // 0x00000001809316F0-0x0000000180931740
		public void SetVector(int nameID, Vector4 value) {} // 0x0000000180931A00-0x0000000180931A50
		public void SetColor(string name, Color value) {} // 0x0000000180931640-0x00000001809316A0
		public void SetColor(int nameID, Color value) {} // 0x00000001809316A0-0x00000001809316F0
		public void SetMatrix(int nameID, Matrix4x4 value) {} // 0x0000000180931840-0x00000001809318B0
		public void SetBuffer(int nameID, ComputeBuffer value) {} // 0x0000000180931550-0x00000001809315A0
		public void SetTexture(string name, Texture value) {} // 0x0000000180931900-0x0000000180931960
		public void SetTexture(int nameID, Texture value) {} // 0x00000001809318B0-0x0000000180931900
		public Vector4 GetVector(string name) => default; // 0x00000001809314D0-0x0000000180931550
		private void GetVectorImpl_Injected(int name, out Vector4 ret) {
			ret = default;
		} // 0x0000000180931410-0x0000000180931460
		private void SetVectorImpl_Injected(int name, ref Vector4 value) {} // 0x0000000180931960-0x00000001809319B0
		private void SetColorImpl_Injected(int name, ref Color value) {} // 0x00000001809315A0-0x00000001809315F0
		private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) {} // 0x00000001809317A0-0x00000001809317F0
	}
}
