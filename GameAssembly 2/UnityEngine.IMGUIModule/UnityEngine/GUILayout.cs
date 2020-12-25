/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 13: UnityEngine.IMGUIModule.dll - Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3731-3777

namespace UnityEngine
{
	public class GUILayout // TypeDefIndex: 3746
	{
		// Nested types
		private sealed class LayoutedWindow // TypeDefIndex: 3747
		{
			// Fields
			private readonly GUI.WindowFunction m_Func; // 0x10
			private readonly Rect m_ScreenRect; // 0x18
			private readonly GUILayoutOption[] m_Options; // 0x28
			private readonly GUIStyle m_Style; // 0x30
	
			// Constructors
			public LayoutedWindow() {} // Dummy constructor
			internal LayoutedWindow(GUI.WindowFunction f, Rect screenRect, GUIContent content, GUILayoutOption[] options, GUIStyle style) {} // 0x0000000180A36BF0-0x0000000180A36D10
	
			// Methods
			public void DoWindow(int windowID) {} // 0x0000000180A36A80-0x0000000180A36BF0
		}
	
		public class HorizontalScope : GUI.Scope // TypeDefIndex: 3748
		{
			// Constructors
			public HorizontalScope() {} // Dummy constructor
			public HorizontalScope(params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) {} // 0x0000000180A368E0-0x0000000180A36990
	
			// Methods
			protected override void CloseScope() {} // 0x0000000180A24680-0x0000000180A246D0
		}
	
		public class VerticalScope : GUI.Scope // TypeDefIndex: 3749
		{
			// Constructors
			public VerticalScope() {} // Dummy constructor
			public VerticalScope(params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) {} // 0x0000000180A36F50-0x0000000180A37000
	
			// Methods
			protected override void CloseScope() {} // 0x0000000180A247C0-0x0000000180A24810
		}
	
		// Constructors
		public GUILayout() {} // Dummy constructor
	
		// Methods
		public static void Label(string text, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) {} // 0x0000000180A25020-0x0000000180A25110
		public static void Label(string text, GUIStyle style, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) {} // 0x0000000180A25110-0x0000000180A25190
		private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) {} // 0x0000000180A23C20-0x0000000180A23D70
		public static void Box(Texture image, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) {} // 0x0000000180A23520-0x0000000180A236C0
		public static void Box(string text, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) {} // 0x0000000180A23430-0x0000000180A23520
		private static void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options) {} // 0x0000000180A23830-0x0000000180A23940
		public static bool Button(string text, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) => default; // 0x0000000180A23740-0x0000000180A23830
		public static bool Button(string text, GUIStyle style, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) => default; // 0x0000000180A236C0-0x0000000180A23740
		private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) => default; // 0x0000000180A23940-0x0000000180A23A50
		public static string TextField(string text, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) => default; // 0x0000000180A25600-0x0000000180A256E0
		public static string TextArea(string text, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) => default; // 0x0000000180A25520-0x0000000180A25600
		private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options) => default; // 0x0000000180A23D70-0x0000000180A23F90
		public static bool Toggle(bool value, string text, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) => default; // 0x0000000180A256E0-0x0000000180A257F0
		private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) => default; // 0x0000000180A23F90-0x0000000180A241F0
		public static int Toolbar(int selected, string[] texts, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) => default; // 0x0000000180A25C90-0x0000000180A25EB0
		public static int Toolbar(int selected, GUIContent[] contents, GUIStyle style, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) => default; // 0x0000000180A25EB0-0x0000000180A25EE0
		public static int Toolbar(int selected, GUIContent[] contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) => default; // 0x0000000180A25C60-0x0000000180A25C90
		public static int Toolbar(int selected, GUIContent[] contents, bool[] enabled, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) => default; // 0x0000000180A257F0-0x0000000180A25C60
		public static float HorizontalSlider(float value, float leftValue, float rightValue, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) => default; // 0x0000000180A24D20-0x0000000180A25020
		private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) => default; // 0x0000000180A23A50-0x0000000180A23C20
		public static void Space(float pixels) {} // 0x0000000180A25190-0x0000000180A25520
		public static void FlexibleSpace() {} // 0x0000000180A24910-0x0000000180A24C90
		public static void BeginHorizontal(params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) {} // 0x0000000180A22C00-0x0000000180A22CA0
		public static void BeginHorizontal(GUIStyle style, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) {} // 0x0000000180A22CA0-0x0000000180A22D20
		public static void BeginHorizontal(GUIContent content, GUIStyle style, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) {} // 0x0000000180A22A90-0x0000000180A22C00
		public static void EndHorizontal() {} // 0x0000000180A24680-0x0000000180A246D0
		public static void BeginVertical(params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) {} // 0x0000000180A231A0-0x0000000180A23240
		public static void BeginVertical(GUIStyle style, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) {} // 0x0000000180A233B0-0x0000000180A23430
		public static void BeginVertical(GUIContent content, GUIStyle style, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) {} // 0x0000000180A23240-0x0000000180A233B0
		public static void EndVertical() {} // 0x0000000180A247C0-0x0000000180A24810
		public static void BeginArea(Rect screenRect) {} // 0x0000000180A229E0-0x0000000180A22A90
		public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) {} // 0x0000000180A22750-0x0000000180A229E0
		public static void EndArea() {} // 0x0000000180A244A0-0x0000000180A24680
		public static Vector2 BeginScrollView(Vector2 scrollPosition, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) => default; // 0x0000000180A22FD0-0x0000000180A231A0
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) => default; // 0x0000000180A22D20-0x0000000180A22FD0
		public static void EndScrollView() {} // 0x0000000180A24750-0x0000000180A247C0
		internal static void EndScrollView(bool handleScrollWheel) {} // 0x0000000180A246D0-0x0000000180A24750
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) => default; // 0x0000000180A25F70-0x0000000180A260D0
		private static Rect DoWindow(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUILayoutOption[] options) => default; // 0x0000000180A241F0-0x0000000180A244A0
		public static GUILayoutOption Width(float width) => default; // 0x0000000180A25EE0-0x0000000180A25F70
		public static GUILayoutOption Height(float height) => default; // 0x0000000180A24C90-0x0000000180A24D20
		public static GUILayoutOption ExpandWidth(bool expand) => default; // 0x0000000180A24890-0x0000000180A24910
		public static GUILayoutOption ExpandHeight(bool expand) => default; // 0x0000000180A24810-0x0000000180A24890
	}
}
