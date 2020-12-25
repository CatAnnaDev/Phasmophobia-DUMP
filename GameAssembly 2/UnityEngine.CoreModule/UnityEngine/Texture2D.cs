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
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800DF0C0-0x00000001800DF130
	// [NativeHeader] // 0x00000001800DF0C0-0x00000001800DF130
	[UsedByNativeCode] // 0x00000001800DF0C0-0x00000001800DF130
	public sealed class Texture2D : Texture // TypeDefIndex: 3202
	{
		// Properties
		public TextureFormat format { /* [NativeName] */ /* 0x00000001800DF210-0x00000001800DF240 */ get => default; } // 0x00000001808E1380-0x00000001808E13C0 
		// [StaticAccessor] // 0x00000001800DFD00-0x00000001800DFD30
		public static Texture2D whiteTexture { get => default; } // 0x00000001808E1400-0x00000001808E1430 
		public override bool isReadable { get => default; } // 0x00000001808E13C0-0x00000001808E1400 
	
		// Constructors
		public Texture2D() {} // Dummy constructor
		internal Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex) {} // 0x00000001808E11E0-0x00000001808E1380
		public Texture2D(int width, int height, [DefaultValue] /* 0x00000001800DFAB0-0x00000001800DFAE0 */ TextureFormat textureFormat, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool mipChain, [DefaultValue] /* 0x00000001800DFAE0-0x00000001800DFB10 */ bool linear) {} // 0x00000001808E1010-0x00000001808E10B0
		public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain) {} // 0x00000001808E1150-0x00000001808E11E0
		public Texture2D(int width, int height) {} // 0x00000001808E10B0-0x00000001808E1150
	
		// Methods
		[FreeFunction] // 0x00000001800DF3A0-0x00000001800DF3D0
		private static bool Internal_CreateImpl([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) => default; // 0x00000001808E07B0-0x00000001808E0810
		private static void Internal_Create([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) {} // 0x00000001808E0810-0x00000001808E08E0
		// [NativeName] // 0x00000001800DF460-0x00000001800DF490
		private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) {} // 0x00000001808DFF30-0x00000001808DFF90
		// [NativeName] // 0x00000001800DF4D0-0x00000001800DF500
		private void SetPixelImpl(int image, int x, int y, Color color) {} // 0x00000001808E0C20-0x00000001808E0C90
		// [NativeName] // 0x00000001800DF560-0x00000001800DF590
		private Color GetPixelImpl(int image, int x, int y) => default; // 0x00000001808E0400-0x00000001808E0490
		// [NativeName] // 0x00000001800DF590-0x00000001800DF5C0
		private Color GetPixelBilinearImpl(int image, float u, float v) => default; // 0x00000001808E0230-0x00000001808E02C0
		[FreeFunction] // 0x00000001800DF730-0x00000001800DF770
		private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) {} // 0x00000001808E0950-0x00000001808E09C0
		[FreeFunction] // 0x00000001800DF790-0x00000001800DF7D0
		private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) {} // 0x00000001808E0DB0-0x00000001808E0E10
		[FreeFunction] // 0x00000001800DF800-0x00000001800DF840
		public void UpdateExternalTexture(IntPtr nativeTex) {} // 0x00000001808E0FC0-0x00000001808E1010
		[FreeFunction] // 0x00000001800DF890-0x00000001800DF8D0
		private void SetAllPixels32(Color32[] colors, int miplevel) {} // 0x00000001808E0B60-0x00000001808E0BC0
		[FreeFunction] // 0x00000001800DF9E0-0x00000001800DFA20
		public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) => default; // 0x00000001808E06B0-0x00000001808E0710
		[FreeFunction] // 0x00000001800DFA20-0x00000001800DFA60
		public Color32[] GetPixels32(int miplevel) => default; // 0x00000001808E05B0-0x00000001808E05F0
		public Color32[] GetPixels32() => default; // 0x00000001808E0570-0x00000001808E05B0
		public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex) => default; // 0x00000001808E00D0-0x00000001808E01D0
		public void SetPixel(int x, int y, Color color) {} // 0x00000001808E0C90-0x00000001808E0D60
		public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, [DefaultValue] /* 0x00000001800DEB90-0x00000001800DEBC0 */ int miplevel) {} // 0x00000001808E0E10-0x00000001808E0ED0
		public void SetPixels(Color[] colors) {} // 0x00000001808E0ED0-0x00000001808E0FC0
		public Color GetPixel(int x, int y) => default; // 0x00000001808E0490-0x00000001808E0570
		public Color GetPixelBilinear(float u, float v) => default; // 0x00000001808E02C0-0x00000001808E03A0
		public void Apply([DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool updateMipmaps, [DefaultValue] /* 0x00000001800DFAE0-0x00000001800DFB10 */ bool makeNoLongerReadable) {} // 0x00000001808E0020-0x00000001808E00D0
		public void Apply() {} // 0x00000001808DFF90-0x00000001808E0020
		public void ReadPixels(Rect source, int destX, int destY, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool recalculateMipMaps) {} // 0x00000001808E0A90-0x00000001808E0B60
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void ReadPixels(Rect source, int destX, int destY) {} // 0x00000001808E09C0-0x00000001808E0A90
		public void SetPixels32(Color32[] colors, int miplevel) {} // 0x00000001808E0B60-0x00000001808E0BC0
		public void SetPixels32(Color32[] colors) {} // 0x00000001808E0D60-0x00000001808E0DB0
		public Color[] GetPixels(int miplevel) => default; // 0x00000001808E05F0-0x00000001808E06B0
		public Color[] GetPixels() => default; // 0x00000001808E0710-0x00000001808E07B0
		private void SetPixelImpl_Injected(int image, int x, int y, ref Color color) {} // 0x00000001808E0BC0-0x00000001808E0C20
		private void GetPixelImpl_Injected(int image, int x, int y, out Color ret) {
			ret = default;
		} // 0x00000001808E03A0-0x00000001808E0400
		private void GetPixelBilinearImpl_Injected(int image, float u, float v, out Color ret) {
			ret = default;
		} // 0x00000001808E01D0-0x00000001808E0230
		private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) {} // 0x00000001808E08E0-0x00000001808E0950
	}
}
