/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180101330-0x0000000180101370
	[UsedByNativeCode] // 0x0000000180101330-0x0000000180101370
	public sealed class ComputeShader : Object // TypeDefIndex: 3308
	{
		// Constructors
		public ComputeShader() {} // Dummy constructor
	
		// Methods
		[NativeMethod] // 0x00000001801013E0-0x0000000180101440
		[RequiredByNativeCode] // 0x00000001801013E0-0x0000000180101440
		public int FindKernel(string name) => default; // 0x00000001809655E0-0x0000000180965630
		[FreeFunction] // 0x00000001801014C0-0x0000000180101500
		public void SetFloat(int nameID, float val) {} // 0x00000001809657C0-0x0000000180965810
		[FreeFunction] // 0x0000000180101500-0x0000000180101540
		public void SetInt(int nameID, int val) {} // 0x0000000180965810-0x0000000180965860
		[NativeMethod] // 0x0000000180101570-0x00000001801015C0
		public void SetTexture(int kernelIndex, int nameID, [NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ Texture texture, int mipLevel) {} // 0x0000000180965940-0x00000001809659A0
		[FreeFunction] // 0x00000001801016C0-0x0000000180101700
		public void SetBuffer(int kernelIndex, int nameID, [NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ ComputeBuffer buffer) {} // 0x0000000180965690-0x00000001809656F0
		[NativeMethod] // 0x00000001801019C0-0x0000000180101A10
		public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z) {
			x = default;
			y = default;
			z = default;
		} // 0x0000000180965630-0x0000000180965690
		// [NativeName] // 0x0000000180101B10-0x0000000180101B40
		public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) {} // 0x0000000180965580-0x00000001809655E0
		public void SetFloat(string name, float val) {} // 0x0000000180965760-0x00000001809657C0
		public void SetInt(string name, int val) {} // 0x0000000180965860-0x00000001809658C0
		public void SetTexture(int kernelIndex, string name, Texture texture) {} // 0x00000001809658C0-0x0000000180965940
		public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer) {} // 0x00000001809656F0-0x0000000180965760
	}
}
