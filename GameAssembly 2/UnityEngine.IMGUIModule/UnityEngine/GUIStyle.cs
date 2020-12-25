/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 13: UnityEngine.IMGUIModule.dll - Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3731-3777

namespace UnityEngine
{
	[Serializable]
	// [NativeHeader] // 0x00000001800FB780-0x00000001800FB7F0
	// [NativeHeader] // 0x00000001800FB780-0x00000001800FB7F0
	[RequiredByNativeCode] // 0x00000001800FB780-0x00000001800FB7F0
	public sealed class GUIStyle // TypeDefIndex: 3759
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
		[NonSerialized]
		private GUIStyleState m_Normal; // 0x18
		[NonSerialized]
		private GUIStyleState m_Hover; // 0x20
		[NonSerialized]
		private GUIStyleState m_Active; // 0x28
		[NonSerialized]
		private GUIStyleState m_Focused; // 0x30
		[NonSerialized]
		private GUIStyleState m_OnNormal; // 0x38
		[NonSerialized]
		private GUIStyleState m_OnHover; // 0x40
		[NonSerialized]
		private GUIStyleState m_OnActive; // 0x48
		[NonSerialized]
		private GUIStyleState m_OnFocused; // 0x50
		[NonSerialized]
		private RectOffset m_Border; // 0x58
		[NonSerialized]
		private RectOffset m_Padding; // 0x60
		[NonSerialized]
		private RectOffset m_Margin; // 0x68
		[NonSerialized]
		private RectOffset m_Overflow; // 0x70
		[NonSerialized]
		private string m_Name; // 0x78
		internal static bool showKeyboardFocus; // 0x00
		private static GUIStyle s_None; // 0x08
	
		// Properties
		[NativeProperty] // 0x00000001800FC960-0x00000001800FC9A0
		internal string rawName { get => default; set {} } // 0x0000000180A2B760-0x0000000180A2B7A0 0x0000000180A2BBC0-0x0000000180A2BC10
		[NativeProperty] // 0x00000001800FCA10-0x00000001800FCA50
		public Font font { get => default; set {} } // 0x0000000180A2B2A0-0x0000000180A2B2E0 0x0000000180A2BB20-0x0000000180A2BB70
		[NativeProperty] // 0x00000001800FCA80-0x00000001800FCAC0
		public ImagePosition imagePosition { get => default; } // 0x0000000180A2B2E0-0x0000000180A2B320 
		[NativeProperty] // 0x00000001800FCBB0-0x00000001800FCBF0
		public TextAnchor alignment { set {} } // 0x0000000180A2B9D0-0x0000000180A2BA10
		[NativeProperty] // 0x00000001800FCC50-0x00000001800FCC90
		public bool wordWrap { get => default; } // 0x0000000180A2B820-0x0000000180A2B860 
		[NativeProperty] // 0x00000001800FCCC0-0x00000001800FCD00
		public Vector2 contentOffset { get => default; set {} } // 0x0000000180A2B1D0-0x0000000180A2B220 0x0000000180A2BA60-0x0000000180A2BAA0
		[NativeProperty] // 0x00000001800FCD50-0x00000001800FCD90
		public float fixedWidth { get => default; } // 0x0000000180A2B260-0x0000000180A2B2A0 
		[NativeProperty] // 0x00000001800FCE00-0x00000001800FCE40
		public float fixedHeight { get => default; } // 0x0000000180A2B220-0x0000000180A2B260 
		[NativeProperty] // 0x00000001800FCEA0-0x00000001800FCEE0
		public bool stretchWidth { get => default; set {} } // 0x0000000180A2B7E0-0x0000000180A2B820 0x0000000180A2BC60-0x0000000180A2BCB0
		[NativeProperty] // 0x00000001800FCFA0-0x00000001800FCFE0
		public bool stretchHeight { get => default; set {} } // 0x0000000180A2B7A0-0x0000000180A2B7E0 0x0000000180A2BC10-0x0000000180A2BC60
		[NativeProperty] // 0x00000001800FD060-0x00000001800FD0A0
		public int fontSize { set {} } // 0x0000000180A2BAA0-0x0000000180A2BAE0
		[NativeProperty] // 0x00000001800FD160-0x00000001800FD1A0
		public FontStyle fontStyle { set {} } // 0x0000000180A2BAE0-0x0000000180A2BB20
		[NativeProperty] // 0x00000001800FD220-0x00000001800FD260
		internal Vector2 Internal_clipOffset { set {} } // 0x0000000180A2B990-0x0000000180A2B9D0
		public string name { get => default; set {} } // 0x0000000180A2B520-0x0000000180A2B580 0x0000000180A2BB70-0x0000000180A2BBC0
		public GUIStyleState normal { get => default; } // 0x0000000180A2B640-0x0000000180A2B6B0 
		public RectOffset margin { get => default; } // 0x0000000180A2B470-0x0000000180A2B520 
		public RectOffset padding { get => default; } // 0x0000000180A2B6B0-0x0000000180A2B760 
		public float lineHeight { get => default; } // 0x0000000180A2B3C0-0x0000000180A2B470 
		public static GUIStyle none { get => default; } // 0x0000000180A2B580-0x0000000180A2B640 
		public bool isHeightDependantOnWidth { get => default; } // 0x0000000180A2B320-0x0000000180A2B3C0 
	
		// Constructors
		public GUIStyle() {} // 0x0000000180A2B100-0x0000000180A2B180
		public GUIStyle(GUIStyle other) {} // 0x0000000180A2B030-0x0000000180A2B100
		static GUIStyle() {} // 0x0000000180A2AFF0-0x0000000180A2B030
	
		// Methods
		[FreeFunction] // 0x00000001800FB970-0x00000001800FB9B0
		private static IntPtr Internal_Create(GUIStyle self) => default; // 0x0000000180A2A5E0-0x0000000180A2A620
		[FreeFunction] // 0x00000001800FBB40-0x00000001800FBB80
		private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) => default; // 0x0000000180A2A590-0x0000000180A2A5E0
		[FreeFunction] // 0x00000001800FBC10-0x00000001800FBC50
		private static void Internal_Destroy(IntPtr self) {} // 0x0000000180A2A620-0x0000000180A2A660
		[FreeFunction] // 0x00000001800FBD60-0x00000001800FBDA0
		private IntPtr GetStyleStatePtr(int idx) => default; // 0x0000000180A2A3C0-0x0000000180A2A400
		[FreeFunction] // 0x00000001800FBDA0-0x00000001800FBDE0
		private IntPtr GetRectOffsetPtr(int idx) => default; // 0x0000000180A2A380-0x0000000180A2A3C0
		[FreeFunction] // 0x00000001800FBE10-0x00000001800FBE50
		private static float Internal_GetLineHeight(IntPtr target) => default; // 0x0000000180A2ACB0-0x0000000180A2ACF0
		[FreeFunction] // 0x00000001800FBF40-0x00000001800FBF80
		private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) {} // 0x0000000180A2AA30-0x0000000180A2AAC0
		[FreeFunction] // 0x00000001800FBFD0-0x00000001800FC010
		private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) {} // 0x0000000180A2A6D0-0x0000000180A2A740
		[FreeFunction] // 0x00000001800FC060-0x00000001800FC0A0
		private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) {} // 0x0000000180A2A7B0-0x0000000180A2A820
		[FreeFunction] // 0x00000001800FC180-0x00000001800FC1C0
		private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) {} // 0x0000000180A2A8D0-0x0000000180A2A9A0
		[FreeFunction] // 0x00000001800FC230-0x00000001800FC270
		internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) => default; // 0x0000000180A2AB60-0x0000000180A2ABE0
		[FreeFunction] // 0x00000001800FC2A0-0x00000001800FC2E0
		internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) => default; // 0x0000000180A2AC50-0x0000000180A2ACB0
		[FreeFunction] // 0x00000001800FC3F0-0x00000001800FC430
		internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) => default; // 0x0000000180A2AD60-0x0000000180A2ADD0
		[FreeFunction] // 0x00000001800FC430-0x00000001800FC470
		internal Vector2 Internal_CalcSize(GUIContent content) => default; // 0x0000000180A292B0-0x0000000180A29310
		[FreeFunction] // 0x00000001800FC4C0-0x00000001800FC500
		internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) => default; // 0x0000000180A29250-0x0000000180A292B0
		[FreeFunction] // 0x00000001800FC500-0x00000001800FC540
		private float Internal_CalcHeight(GUIContent content, float width) => default; // 0x0000000180A29170-0x0000000180A291D0
		[FreeFunction] // 0x00000001800FC5C0-0x00000001800FC600
		private Vector2 Internal_CalcMinMaxWidth(GUIContent content) => default; // 0x0000000180A2A460-0x0000000180A2A4C0
		[FreeFunction] // 0x00000001800FC700-0x00000001800FC740
		internal static void SetMouseTooltip(string tooltip, Rect screenRect) {} // 0x0000000180A2AE60-0x0000000180A2AEE0
		[FreeFunction] // 0x00000001800FC7C0-0x00000001800FC800
		private static float Internal_GetCursorFlashOffset() => default; // 0x0000000180A2AAC0-0x0000000180A2AAF0
		[FreeFunction] // 0x00000001800FC8B0-0x00000001800FC8F0
		internal static void SetDefaultFont(Font font) {} // 0x0000000180A2ADD0-0x0000000180A2AE10
		~GUIStyle() {} // 0x0000000180A2A190-0x0000000180A2A2A0
		public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) {} // 0x0000000180A29D00-0x0000000180A29DF0
		public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) {} // 0x0000000180A29F60-0x0000000180A29FF0
		public void Draw(Rect position, GUIContent content, int controlID) {} // 0x0000000180A2A0D0-0x0000000180A2A190
		public void Draw(Rect position, GUIContent content, int controlID, bool on) {} // 0x0000000180A29E90-0x0000000180A29F60
		public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) {} // 0x0000000180A29DF0-0x0000000180A29E90
		private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) {} // 0x0000000180A29FF0-0x0000000180A2A0D0
		public void DrawCursor(Rect position, GUIContent content, int controlID, int character) {} // 0x0000000180A29310-0x0000000180A295F0
		internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) {} // 0x0000000180A297A0-0x0000000180A29B60
		internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) {} // 0x0000000180A295F0-0x0000000180A297A0
		public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) {} // 0x0000000180A29B60-0x0000000180A29D00
		public static implicit operator GUIStyle(string str) => default; // 0x0000000180A2B860-0x0000000180A2B940
		public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) => default; // 0x0000000180A2A2A0-0x0000000180A2A320
		public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) => default; // 0x0000000180A2A320-0x0000000180A2A380
		public Vector2 CalcSize(GUIContent content) => default; // 0x0000000180A292B0-0x0000000180A29310
		internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) => default; // 0x0000000180A29250-0x0000000180A292B0
		public float CalcHeight(GUIContent content, float width) => default; // 0x0000000180A29170-0x0000000180A291D0
		public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) {
			minWidth = default;
			maxWidth = default;
		} // 0x0000000180A291D0-0x0000000180A29250
		public override string ToString() => default; // 0x0000000180A2AEE0-0x0000000180A2AFF0
		private void get_contentOffset_Injected(out Vector2 ret) {
			ret = default;
		} // 0x0000000180A2B180-0x0000000180A2B1D0
		private void set_contentOffset_Injected(ref Vector2 value) {} // 0x0000000180A2BA10-0x0000000180A2BA60
		private void set_Internal_clipOffset_Injected(ref Vector2 value) {} // 0x0000000180A2B940-0x0000000180A2B990
		private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) {} // 0x0000000180A2A9A0-0x0000000180A2AA30
		private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) {} // 0x0000000180A2A660-0x0000000180A2A6D0
		private void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor) {} // 0x0000000180A2A740-0x0000000180A2A7B0
		private void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor) {} // 0x0000000180A2A820-0x0000000180A2A8D0
		private void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret) {
			ret = default;
		} // 0x0000000180A2AAF0-0x0000000180A2AB60
		private int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition) => default; // 0x0000000180A2ABE0-0x0000000180A2AC50
		private string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) => default; // 0x0000000180A2ACF0-0x0000000180A2AD60
		private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) {
			ret = default;
		} // 0x0000000180A2A530-0x0000000180A2A590
		private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) {
			ret = default;
		} // 0x0000000180A2A4C0-0x0000000180A2A530
		private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) {
			ret = default;
		} // 0x0000000180A2A400-0x0000000180A2A460
		private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) {} // 0x0000000180A2AE10-0x0000000180A2AE60
	}
}
