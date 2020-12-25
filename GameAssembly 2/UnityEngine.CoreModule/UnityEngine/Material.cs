/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001801480B0-0x0000000180148110
	// [NativeHeader] // 0x00000001801480B0-0x0000000180148110
	public class Material : Object // TypeDefIndex: 3158
	{
		// Properties
		public Shader shader { get => default; } // 0x0000000180933120-0x0000000180933160 
		public Color color { get => default; set {} } // 0x0000000180932F30-0x0000000180933000 0x0000000180933160-0x0000000180933220
		public Texture mainTexture { get => default; set {} } // 0x0000000180933000-0x00000001809330A0 0x00000001809333A0-0x0000000180933450
		public Vector2 mainTextureOffset { set {} } // 0x0000000180933220-0x00000001809332E0
		public Vector2 mainTextureScale { set {} } // 0x00000001809332E0-0x00000001809333A0
		public int renderQueue { /* [NativeName] */ /* 0x000000018014A350-0x000000018014A380 */ get => default; /* [NativeName] */ /* 0x000000018014A500-0x000000018014A530 */ set {} } // 0x00000001809330E0-0x0000000180933120 0x0000000180933450-0x0000000180933490
		public int passCount { get => default; } // 0x00000001809330A0-0x00000001809330E0 
		public string[] shaderKeywords { set {} } // 0x0000000180932A00-0x0000000180932A50
	
		// Constructors
		public Material() {} // Dummy constructor
		public Material(Shader shader) {} // 0x0000000180932EA0-0x0000000180932F30
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		public Material(Material source) {} // 0x0000000180932D90-0x0000000180932E20
		[EditorBrowsable] // 0x0000000180149FC0-0x000000018014A010
		[Obsolete] // 0x0000000180149FC0-0x000000018014A010
		public Material(string contents) {} // 0x0000000180932E20-0x0000000180932EA0
	
		// Methods
		[FreeFunction] // 0x00000001801482E0-0x0000000180148310
		private static void CreateWithShader([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ Material self, [NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ Shader shader) {} // 0x0000000180931B30-0x0000000180931B80
		[FreeFunction] // 0x00000001801498D0-0x0000000180149900
		private static void CreateWithMaterial([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ Material self, [NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ Material source) {} // 0x0000000180931AE0-0x0000000180931B30
		[FreeFunction] // 0x0000000180149D00-0x0000000180149D30
		private static void CreateWithString([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ Material self) {} // 0x0000000180931B80-0x0000000180931BC0
		// [NativeName] // 0x000000018014A0B0-0x000000018014A0E0
		private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) => default; // 0x0000000180931DA0-0x0000000180931DE0
		// [NativeName] // 0x000000018014A1A0-0x000000018014A1D0
		public bool HasProperty(int nameID) => default; // 0x0000000180931F50-0x0000000180931F90
		public bool HasProperty(string name) => default; // 0x0000000180931F00-0x0000000180931F50
		public void EnableKeyword(string keyword) {} // 0x0000000180931C10-0x0000000180931C60
		public void DisableKeyword(string keyword) {} // 0x0000000180931BC0-0x0000000180931C10
		public bool IsKeywordEnabled(string keyword) => default; // 0x0000000180931F90-0x0000000180931FE0
		[FreeFunction] // 0x000000018014B8E0-0x000000018014B920
		public bool SetPass(int pass) => default; // 0x00000001809329C0-0x0000000180932A00
		[FreeFunction] // 0x000000018014B9D0-0x000000018014BA10
		public void CopyPropertiesFromMaterial(Material mat) {} // 0x0000000180931A90-0x0000000180931AE0
		[FreeFunction] // 0x000000018014BCE0-0x000000018014BD20
		private void SetShaderKeywords(string[] names) {} // 0x0000000180932A00-0x0000000180932A50
		// [NativeName] // 0x0000000180145110-0x0000000180145140
		private void SetFloatImpl(int name, float value) {} // 0x0000000180932720-0x0000000180932770
		// [NativeName] // 0x00000001801454D0-0x0000000180145500
		private void SetColorImpl(int name, Color value) {} // 0x0000000180932380-0x00000001809323D0
		// [NativeName] // 0x0000000180145530-0x0000000180145560
		private void SetMatrixImpl(int name, Matrix4x4 value) {} // 0x00000001809328F0-0x0000000180932940
		// [NativeName] // 0x0000000180145680-0x00000001801456B0
		private void SetTextureImpl(int name, Texture value) {} // 0x0000000180932A50-0x0000000180932AA0
		// [NativeName] // 0x0000000180145860-0x0000000180145890
		private void SetBufferImpl(int name, ComputeBuffer value) {} // 0x0000000180931FE0-0x0000000180932030
		// [NativeName] // 0x00000001800D4DD0-0x00000001800D4E00
		private float GetFloatImpl(int name) => default; // 0x0000000180931DE0-0x0000000180931E20
		// [NativeName] // 0x00000001800D5020-0x00000001800D5050
		private Color GetColorImpl(int name) => default; // 0x0000000180931CB0-0x0000000180931D20
		// [NativeName] // 0x00000001800D5120-0x00000001800D5150
		private Texture GetTextureImpl(int name) => default; // 0x0000000180931E70-0x0000000180931EB0
		[FreeFunction] // 0x00000001800D5220-0x00000001800D5260
		private void SetFloatArrayImpl(int name, float[] values, int count) {} // 0x0000000180932480-0x00000001809324E0
		[FreeFunction] // 0x00000001800D52E0-0x00000001800D5320
		private void SetColorArrayImpl(int name, Color[] values, int count) {} // 0x0000000180932090-0x00000001809320F0
		// [NativeName] // 0x00000001800D5420-0x00000001800D5450
		private void SetTextureOffsetImpl(int name, Vector2 offset) {} // 0x0000000180932AF0-0x0000000180932B40
		// [NativeName] // 0x00000001800D54C0-0x00000001800D54F0
		private void SetTextureScaleImpl(int name, Vector2 scale) {} // 0x0000000180932BF0-0x0000000180932C40
		private void SetFloatArray(int name, float[] values, int count) {} // 0x00000001809324E0-0x0000000180932610
		private void SetColorArray(int name, Color[] values, int count) {} // 0x0000000180932200-0x0000000180932330
		public void SetFloat(string name, float value) {} // 0x0000000180932770-0x00000001809327D0
		public void SetFloat(int nameID, float value) {} // 0x0000000180932720-0x0000000180932770
		public void SetInt(string name, int value) {} // 0x00000001809327D0-0x0000000180932840
		public void SetInt(int nameID, int value) {} // 0x0000000180932840-0x00000001809328A0
		public void SetColor(string name, Color value) {} // 0x0000000180932420-0x0000000180932480
		public void SetColor(int nameID, Color value) {} // 0x00000001809323D0-0x0000000180932420
		public void SetVector(string name, Vector4 value) {} // 0x0000000180932D00-0x0000000180932D90
		public void SetMatrix(string name, Matrix4x4 value) {} // 0x0000000180932940-0x00000001809329C0
		public void SetTexture(string name, Texture value) {} // 0x0000000180932CA0-0x0000000180932D00
		public void SetTexture(int nameID, Texture value) {} // 0x0000000180932A50-0x0000000180932AA0
		public void SetBuffer(string name, ComputeBuffer value) {} // 0x0000000180932030-0x0000000180932090
		public void SetFloatArray(string name, float[] values) {} // 0x0000000180932610-0x0000000180932720
		public void SetColorArray(string name, Color[] values) {} // 0x00000001809320F0-0x0000000180932200
		public float GetFloat(string name) => default; // 0x0000000180931E20-0x0000000180931E70
		public Color GetColor(string name) => default; // 0x0000000180931D20-0x0000000180931DA0
		public Color GetColor(int nameID) => default; // 0x0000000180931CB0-0x0000000180931D20
		public Texture GetTexture(string name) => default; // 0x0000000180931EB0-0x0000000180931F00
		public Texture GetTexture(int nameID) => default; // 0x0000000180931E70-0x0000000180931EB0
		public void SetTextureOffset(string name, Vector2 value) {} // 0x0000000180932B40-0x0000000180932BA0
		public void SetTextureOffset(int nameID, Vector2 value) {} // 0x0000000180932AF0-0x0000000180932B40
		public void SetTextureScale(string name, Vector2 value) {} // 0x0000000180932C40-0x0000000180932CA0
		public void SetTextureScale(int nameID, Vector2 value) {} // 0x0000000180932BF0-0x0000000180932C40
		private void SetColorImpl_Injected(int name, ref Color value) {} // 0x0000000180932330-0x0000000180932380
		private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) {} // 0x00000001809328A0-0x00000001809328F0
		private void GetColorImpl_Injected(int name, out Color ret) {
			ret = default;
		} // 0x0000000180931C60-0x0000000180931CB0
		private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset) {} // 0x0000000180932AA0-0x0000000180932AF0
		private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale) {} // 0x0000000180932BA0-0x0000000180932BF0
	}
}
