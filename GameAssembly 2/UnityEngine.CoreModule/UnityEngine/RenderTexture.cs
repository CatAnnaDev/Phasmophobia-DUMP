/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800E3CC0-0x00000001800E3D70
	// [NativeHeader] // 0x00000001800E3CC0-0x00000001800E3D70
	// [NativeHeader] // 0x00000001800E3CC0-0x00000001800E3D70
	// [NativeHeader] // 0x00000001800E3CC0-0x00000001800E3D70
	[UsedByNativeCode] // 0x00000001800E3CC0-0x00000001800E3D70
	public class RenderTexture : Texture // TypeDefIndex: 3207
	{
		// Properties
		public override int width { get => default; set {} } // 0x00000001809481C0-0x0000000180948200 0x0000000180948560-0x00000001809485A0
		public override int height { get => default; set {} } // 0x00000001809480C0-0x0000000180948100 0x0000000180948440-0x0000000180948480
		public override TextureDimension dimension { get => default; set {} } // 0x0000000180947FC0-0x0000000180948000 0x0000000180948370-0x00000001809483B0
		[NativeProperty] // 0x00000001800E4DA0-0x00000001800E4DD0
		public GraphicsFormat graphicsFormat { get => default; set {} } // 0x0000000180948080-0x00000001809480C0 0x0000000180948400-0x0000000180948440
		[NativeProperty] // 0x00000001800E5050-0x00000001800E5080
		public bool useMipMap { set {} } // 0x00000001809484D0-0x0000000180948520
		[NativeProperty] // 0x00000001800E5150-0x00000001800E5180
		public bool sRGB { get => default; } // 0x0000000180948100-0x0000000180948140 
		public RenderTextureFormat format { get => default; } // 0x0000000180948040-0x0000000180948080 
		public bool autoGenerateMips { set {} } // 0x0000000180948240-0x0000000180948290
		public int volumeDepth { get => default; set {} } // 0x0000000180948180-0x00000001809481C0 0x0000000180948520-0x0000000180948560
		public int antiAliasing { set {} } // 0x0000000180948200-0x0000000180948240
		public bool enableRandomWrite { get => default; set {} } // 0x0000000180948000-0x0000000180948040 0x00000001809483B0-0x0000000180948400
		public bool useDynamicScale { get => default; set {} } // 0x0000000180948140-0x0000000180948180 0x0000000180948480-0x00000001809484D0
		public static RenderTexture active { get => default; set {} } // 0x0000000180946A00-0x0000000180946A30 0x0000000180947280-0x00000001809472C0
		public RenderBuffer colorBuffer { get => default; } // 0x0000000180946A80-0x0000000180946AE0 
		public RenderBuffer depthBuffer { get => default; } // 0x0000000180946C70-0x0000000180946CD0 
		public int depth { [FreeFunction] /* 0x00000001800E4480-0x00000001800E44C0 */ set {} } // 0x0000000180948290-0x00000001809482D0
		public RenderTextureDescriptor descriptor { get => default; set {} } // 0x0000000180946D20-0x0000000180946DB0 0x00000001809482D0-0x0000000180948370
	
		// Constructors
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		protected internal RenderTexture() {} // 0x0000000180947F60-0x0000000180947FC0
		public RenderTexture(RenderTextureDescriptor desc) {} // 0x0000000180947E60-0x0000000180947F60
		public RenderTexture(RenderTexture textureToCopy) {} // 0x0000000180947950-0x0000000180947BA0
		public RenderTexture(int width, int height, int depth, DefaultFormat format) {} // 0x0000000180947D90-0x0000000180947DF0
		public RenderTexture(int width, int height, int depth, GraphicsFormat format) {} // 0x0000000180947BA0-0x0000000180947D30
		public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount) {} // 0x0000000180947650-0x00000001809478F0
		public RenderTexture(int width, int height, int depth, [DefaultValue] /* 0x00000001800E4670-0x00000001800E46A0 */ RenderTextureFormat format, [DefaultValue] /* 0x00000001800E46D0-0x00000001800E4700 */ RenderTextureReadWrite readWrite) {} // 0x00000001809478F0-0x0000000180947950
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format) {} // 0x00000001809475F0-0x0000000180947650
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public RenderTexture(int width, int height, int depth) {} // 0x0000000180947D30-0x0000000180947D90
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount) {} // 0x0000000180947DF0-0x0000000180947E60
	
		// Methods
		[FreeFunction] // 0x00000001800E3E30-0x00000001800E3E60
		private static RenderTexture GetActive() => default; // 0x0000000180946A00-0x0000000180946A30
		[FreeFunction] // 0x00000001800E3E90-0x00000001800E3EC0
		private static void SetActive(RenderTexture rt) {} // 0x0000000180947280-0x00000001809472C0
		[FreeFunction] // 0x00000001800E3F50-0x00000001800E3F90
		private RenderBuffer GetColorBuffer() => default; // 0x0000000180946A80-0x0000000180946AE0
		[FreeFunction] // 0x00000001800E3FF0-0x00000001800E4030
		private RenderBuffer GetDepthBuffer() => default; // 0x0000000180946C70-0x0000000180946CD0
		public void DiscardContents(bool discardColor, bool discardDepth) {} // 0x00000001809469A0-0x0000000180946A00
		public void MarkRestoreExpected() {} // 0x00000001809471C0-0x0000000180947200
		public void DiscardContents() {} // 0x0000000180946960-0x00000001809469A0
		public bool Create() => default; // 0x0000000180946920-0x0000000180946960
		public void Release() {} // 0x0000000180947240-0x0000000180947280
		public bool IsCreated() => default; // 0x0000000180947180-0x00000001809471C0
		internal void SetSRGBReadWrite(bool srgb) {} // 0x0000000180947360-0x00000001809473B0
		[FreeFunction] // 0x00000001800E4090-0x00000001800E40C0
		private static void Internal_Create([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ RenderTexture rt) {} // 0x0000000180947140-0x0000000180947180
		// [NativeName] // 0x00000001800E4200-0x00000001800E4230
		private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) {} // 0x0000000180947310-0x0000000180947360
		// [NativeName] // 0x00000001800E4360-0x00000001800E4390
		private RenderTextureDescriptor GetDescriptor() => default; // 0x0000000180946D20-0x0000000180946DB0
		[FreeFunction] // 0x00000001800E43F0-0x00000001800E4420
		private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) => default; // 0x0000000180946EF0-0x0000000180946F30
		[FreeFunction] // 0x00000001800E4420-0x00000001800E4450
		public static void ReleaseTemporary(RenderTexture temp) {} // 0x0000000180947200-0x0000000180947240
		private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) {} // 0x00000001809473B0-0x00000001809475F0
		internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) => default; // 0x0000000180946AE0-0x0000000180946C20
		public static RenderTexture GetTemporary(RenderTextureDescriptor desc) => default; // 0x00000001809470B0-0x0000000180947140
		private static RenderTexture GetTemporaryImpl(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing = 1 /* Metadata: 0x0064BC06 */, RenderTextureMemoryless memorylessMode = RenderTextureMemoryless.None /* Metadata: 0x0064BC0A */, VRTextureUsage vrUsage = VRTextureUsage.None /* Metadata: 0x0064BC0E */, bool useDynamicScale = false /* Metadata: 0x0064BC12 */) => default; // 0x0000000180946DB0-0x0000000180946EB0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) => default; // 0x0000000180946FE0-0x0000000180947050
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) => default; // 0x0000000180947050-0x00000001809470B0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer) => default; // 0x0000000180946F80-0x0000000180946FE0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static RenderTexture GetTemporary(int width, int height) => default; // 0x0000000180946F30-0x0000000180946F80
		private void GetColorBuffer_Injected(out RenderBuffer ret) {
			ret = default;
		} // 0x0000000180946A30-0x0000000180946A80
		private void GetDepthBuffer_Injected(out RenderBuffer ret) {
			ret = default;
		} // 0x0000000180946C20-0x0000000180946C70
		private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) {} // 0x00000001809472C0-0x0000000180947310
		private void GetDescriptor_Injected(out RenderTextureDescriptor ret) {
			ret = default;
		} // 0x0000000180946CD0-0x0000000180946D20
		private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) => default; // 0x0000000180946EB0-0x0000000180946EF0
	}
}
