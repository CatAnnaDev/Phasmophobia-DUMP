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
	[ExcludeFromPreset] // 0x0000000180108850-0x0000000180108900
	// [NativeHeader] // 0x0000000180108850-0x0000000180108900
	// [NativeHeader] // 0x0000000180108850-0x0000000180108900
	// [NativeHeader] // 0x0000000180108850-0x0000000180108900
	[NativeType] // 0x0000000180108850-0x0000000180108900
	public sealed class Sprite : Object // TypeDefIndex: 3330
	{
		// Properties
		public Bounds bounds { get => default; } // 0x00000001808DD580-0x00000001808DD5F0 
		public Rect rect { get => default; } // 0x00000001808DD760-0x00000001808DD7C0 
		public Vector4 border { get => default; } // 0x00000001808DD4D0-0x00000001808DD530 
		public Texture2D texture { get => default; } // 0x00000001808DD890-0x00000001808DD8D0 
		public float pixelsPerUnit { [NativeMethod] /* 0x0000000180108CF0-0x0000000180108D20 */ get => default; } // 0x00000001808DD6D0-0x00000001808DD710 
		public Texture2D associatedAlphaSplitTexture { [NativeMethod] /* 0x0000000180108D50-0x0000000180108D80 */ get => default; } // 0x00000001808DD440-0x00000001808DD480 
		public Vector2 pivot { [NativeMethod] /* 0x0000000180108E80-0x0000000180108EB0 */ get => default; } // 0x00000001808DD680-0x00000001808DD6D0 
		public bool packed { get => default; } // 0x00000001808DD5F0-0x00000001808DD630 
		public SpritePackingMode packingMode { get => default; } // 0x00000001808DD240-0x00000001808DD280 
		public Rect textureRect { get => default; } // 0x00000001808DD7C0-0x00000001808DD890 
		public Vector2[] vertices { [FreeFunction] /* 0x0000000180108F80-0x0000000180108FC0 */ get => default; } // 0x00000001808DD950-0x00000001808DD990 
		public ushort[] triangles { [FreeFunction] /* 0x0000000180109100-0x0000000180109140 */ get => default; } // 0x00000001808DD8D0-0x00000001808DD910 
		public Vector2[] uv { [FreeFunction] /* 0x00000001801091D0-0x0000000180109210 */ get => default; } // 0x00000001808DD910-0x00000001808DD950 
	
		// Constructors
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private Sprite() {} // 0x00000001808DD3E0-0x00000001808DD440
	
		// Methods
		internal int GetPackingMode() => default; // 0x00000001808DD240-0x00000001808DD280
		internal int GetPacked() => default; // 0x00000001808DD200-0x00000001808DD240
		internal Rect GetTextureRect() => default; // 0x00000001808DD380-0x00000001808DD3E0
		internal Vector4 GetInnerUVs() => default; // 0x00000001808DD0F0-0x00000001808DD150
		internal Vector4 GetOuterUVs() => default; // 0x00000001808DD1A0-0x00000001808DD200
		internal Vector4 GetPadding() => default; // 0x00000001808DD2D0-0x00000001808DD330
		[FreeFunction] // 0x0000000180108BE0-0x0000000180108C10
		internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) => default; // 0x00000001808DC7C0-0x00000001808DC850
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) => default; // 0x00000001808DCC10-0x00000001808DD0A0
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) => default; // 0x00000001808DC850-0x00000001808DC8B0
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) => default; // 0x00000001808DCA50-0x00000001808DCB30
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) => default; // 0x00000001808DCB30-0x00000001808DCC10
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) => default; // 0x00000001808DC8B0-0x00000001808DC980
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) => default; // 0x00000001808DC980-0x00000001808DCA50
		private void GetTextureRect_Injected(out Rect ret) {
			ret = default;
		} // 0x00000001808DD330-0x00000001808DD380
		private void GetInnerUVs_Injected(out Vector4 ret) {
			ret = default;
		} // 0x00000001808DD0A0-0x00000001808DD0F0
		private void GetOuterUVs_Injected(out Vector4 ret) {
			ret = default;
		} // 0x00000001808DD150-0x00000001808DD1A0
		private void GetPadding_Injected(out Vector4 ret) {
			ret = default;
		} // 0x00000001808DD280-0x00000001808DD2D0
		private static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape) => default; // 0x00000001808DC740-0x00000001808DC7C0
		private void get_bounds_Injected(out Bounds ret) {
			ret = default;
		} // 0x00000001808DD530-0x00000001808DD580
		private void get_rect_Injected(out Rect ret) {
			ret = default;
		} // 0x00000001808DD710-0x00000001808DD760
		private void get_border_Injected(out Vector4 ret) {
			ret = default;
		} // 0x00000001808DD480-0x00000001808DD4D0
		private void get_pivot_Injected(out Vector2 ret) {
			ret = default;
		} // 0x00000001808DD630-0x00000001808DD680
	}
}
