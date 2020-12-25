/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 10: UnityEngine.TextRenderingModule.dll - Assembly: UnityEngine.TextRenderingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3692-3706

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800D8150-0x00000001800D81A0
	[UsedByNativeCode] // 0x00000001800D8150-0x00000001800D81A0
	public sealed class TextGenerator : IDisposable // TypeDefIndex: 3696
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
		private string m_LastString; // 0x18
		private TextGenerationSettings m_LastSettings; // 0x20
		private bool m_HasGenerated; // 0x80
		private TextGenerationError m_LastValid; // 0x84
		private readonly List<UIVertex> m_Verts; // 0x88
		private readonly List<UICharInfo> m_Characters; // 0x90
		private readonly List<UILineInfo> m_Lines; // 0x98
		private bool m_CachedVerts; // 0xA0
		private bool m_CachedCharacters; // 0xA1
		private bool m_CachedLines; // 0xA2
	
		// Properties
		public int characterCountVisible { get => default; } // 0x0000000180AE9B10-0x0000000180AE9B50 
		public IList<UIVertex> verts { get => default; } // 0x0000000180AE9D60-0x0000000180AE9DD0 
		public IList<UICharInfo> characters { get => default; } // 0x0000000180AE9B90-0x0000000180AE9C00 
		public IList<UILineInfo> lines { get => default; } // 0x0000000180AE9C40-0x0000000180AE9CB0 
		public Rect rectExtents { get => default; } // 0x0000000180AE9D00-0x0000000180AE9D60 
		public int characterCount { get => default; } // 0x0000000180AE9B50-0x0000000180AE9B90 
		public int lineCount { get => default; } // 0x0000000180AE9C00-0x0000000180AE9C40 
	
		// Constructors
		public TextGenerator() {} // 0x0000000180AE9A10-0x0000000180AE9B10
		public TextGenerator(int initialCapacity) {} // 0x0000000180AE9900-0x0000000180AE9A10
	
		// Methods
		~TextGenerator() {} // 0x0000000180AE83C0-0x0000000180AE8480
		void IDisposable.Dispose() {} // 0x0000000180AE9510-0x0000000180AE9590
		private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) => default; // 0x0000000180AE9590-0x0000000180AE9900
		public void Invalidate() {} // 0x0000000180AE8770-0x0000000180AE8780
		public void GetCharacters(List<UICharInfo> characters) {} // 0x0000000180AE8480-0x0000000180AE84D0
		public void GetLines(List<UILineInfo> lines) {} // 0x0000000180AE84D0-0x0000000180AE8520
		public void GetVertices(List<UIVertex> vertices) {} // 0x0000000180AE86B0-0x0000000180AE8700
		public float GetPreferredWidth(string str, TextGenerationSettings settings) => default; // 0x0000000180AE85E0-0x0000000180AE86B0
		public float GetPreferredHeight(string str, TextGenerationSettings settings) => default; // 0x0000000180AE8520-0x0000000180AE85E0
		public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) => default; // 0x0000000180AE8E30-0x0000000180AE9070
		public bool Populate(string str, TextGenerationSettings settings) => default; // 0x0000000180AE94B0-0x0000000180AE9510
		private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) => default; // 0x0000000180AE8AA0-0x0000000180AE8E30
		private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) => default; // 0x0000000180AE8780-0x0000000180AE8AA0
		[NativeMethod] // 0x00000001800D8420-0x00000001800D8450
		private static IntPtr Internal_Create() => default; // 0x0000000180AE8700-0x0000000180AE8730
		[NativeMethod] // 0x00000001800D8420-0x00000001800D8450
		private static void Internal_Destroy(IntPtr ptr) {} // 0x0000000180AE8730-0x0000000180AE8770
		internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) {
			error = default;
			return default;
		} // 0x0000000180AE9330-0x0000000180AE94B0
		internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) {
			error = default;
			return default;
		} // 0x0000000180AE9130-0x0000000180AE9330
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		private void GetVerticesInternal(object vertices) {} // 0x0000000180AE86B0-0x0000000180AE8700
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		private void GetCharactersInternal(object characters) {} // 0x0000000180AE8480-0x0000000180AE84D0
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		private void GetLinesInternal(object lines) {} // 0x0000000180AE84D0-0x0000000180AE8520
		private void get_rectExtents_Injected(out Rect ret) {
			ret = default;
		} // 0x0000000180AE9CB0-0x0000000180AE9D00
		private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) {
			error = default;
			return default;
		} // 0x0000000180AE9070-0x0000000180AE9130
	}
}
