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
	// [NativeHeader] // 0x0000000180100C10-0x0000000180100C80
	// [NativeHeader] // 0x0000000180100C10-0x0000000180100C80
	[UsedByNativeCode] // 0x0000000180100C10-0x0000000180100C80
	public sealed class ComputeBuffer : IDisposable // TypeDefIndex: 3305
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Properties
		public int count { get => default; } // 0x0000000180965540-0x0000000180965580 
	
		// Constructors
		public ComputeBuffer() {} // Dummy constructor
		public ComputeBuffer(int count, int stride) {} // 0x00000001809654E0-0x0000000180965510
		public ComputeBuffer(int count, int stride, ComputeBufferType type) {} // 0x0000000180965510-0x0000000180965540
		internal ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) {} // 0x00000001809653D0-0x00000001809654E0
	
		// Methods
		~ComputeBuffer() {} // 0x0000000180964EF0-0x0000000180964F90
		public void Dispose() {} // 0x0000000180964CD0-0x0000000180964D70
		private void Dispose(bool disposing) {} // 0x0000000180964D70-0x0000000180964EF0
		[FreeFunction] // 0x0000000180100E30-0x0000000180100E60
		private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) => default; // 0x0000000180965110-0x0000000180965170
		[FreeFunction] // 0x0000000180100F60-0x0000000180100F90
		private static void DestroyBuffer(ComputeBuffer buf) {} // 0x0000000180964C90-0x0000000180964CD0
		public void Release() {} // 0x0000000180964CD0-0x0000000180964D70
		public void SetData(Array data) {} // 0x0000000180965250-0x00000001809653D0
		[FreeFunction] // 0x0000000180101070-0x00000001801010B0
		private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) {} // 0x00000001809651E0-0x0000000180965250
		public void GetData(Array data) {} // 0x0000000180964F90-0x0000000180965110
		[FreeFunction] // 0x0000000180101120-0x0000000180101160
		private void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) {} // 0x0000000180965170-0x00000001809651E0
		public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes) {} // 0x0000000180964C30-0x0000000180964C90
	}
}
