/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngineInternal;

// Image 13: UnityEngine.IMGUIModule.dll - Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3731-3777

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800F2C60-0x00000001800F2CC0
	// [NativeHeader] // 0x00000001800F2C60-0x00000001800F2CC0
	public class GUI // TypeDefIndex: 3737
	{
		// Fields
		private static int s_ScrollControlId; // 0x00
		private static int s_HotTextField; // 0x04
		private static readonly int s_BoxHash; // 0x08
		private static readonly int s_ButonHash; // 0x0C
		private static readonly int s_RepeatButtonHash; // 0x10
		private static readonly int s_ToggleHash; // 0x14
		private static readonly int s_ButtonGridHash; // 0x18
		private static readonly int s_SliderHash; // 0x1C
		private static readonly int s_BeginGroupHash; // 0x20
		private static readonly int s_ScrollviewHash; // 0x24
		private static GUISkin s_Skin; // 0x38
	
		// Properties
		public static Color color { get => default; set {} } // 0x0000000180A35FA0-0x0000000180A36030 0x0000000180A36470-0x0000000180A364E0
		public static Color backgroundColor { get => default; set {} } // 0x0000000180A35E40-0x0000000180A35ED0 0x0000000180A36380-0x0000000180A363F0
		public static Color contentColor { get => default; set {} } // 0x0000000180A36070-0x0000000180A36100 0x0000000180A36520-0x0000000180A36590
		public static bool changed { get => default; set {} } // 0x0000000180A35F30-0x0000000180A35F60 0x0000000180A363F0-0x0000000180A36430
		public static bool enabled { get => default; set {} } // 0x0000000180A36100-0x0000000180A36130 0x0000000180A36590-0x0000000180A365D0
		internal static bool usePageScrollbars { get => default; } // 0x0000000180A36310-0x0000000180A36340 
		internal static Material blendMaterial { [FreeFunction] /* 0x00000001800F4320-0x00000001800F4350 */ get => default; } // 0x0000000180A35ED0-0x0000000180A35F00 
		internal static Material blitMaterial { [FreeFunction] /* 0x00000001800F43D0-0x00000001800F4400 */ get => default; } // 0x0000000180A35F00-0x0000000180A35F30 
		internal static Material roundedRectMaterial { [FreeFunction] /* 0x00000001800F4580-0x00000001800F45B0 */ get => default; } // 0x0000000180A36190-0x0000000180A361C0 
		internal static Material roundedRectWithColorPerBorderMaterial { [FreeFunction] /* 0x00000001800F4640-0x00000001800F4670 */ get => default; } // 0x0000000180A361C0-0x0000000180A361F0 
		internal static int scrollTroughSide { get; set; } // 0x0000000180A361F0-0x0000000180A36250 0x0000000180A366F0-0x0000000180A36750
		internal static DateTime nextScrollStepTime { get; set; } // 0x0000000180A36130-0x0000000180A36190 0x0000000180A36630-0x0000000180A366F0
		public static GUISkin skin { get => default; set {} } // 0x0000000180A362B0-0x0000000180A36310 0x0000000180A36750-0x0000000180A368E0
		public static Matrix4x4 matrix { get => default; set {} } // 0x0000000180A1AA90-0x0000000180A1AB10 0x0000000180A365D0-0x0000000180A36630
		internal static GenericStack scrollViewStates { get; } // 0x0000000180A36250-0x0000000180A362B0 
	
		// Nested types
		public enum ToolbarButtonSize // TypeDefIndex: 3738
		{
			Fixed = 0,
			FitToContents = 1
		}
	
		public delegate void WindowFunction(int id); // TypeDefIndex: 3739; 0x0000000180948F50-0x0000000180949220
	
		public abstract class Scope : IDisposable // TypeDefIndex: 3740
		{
			// Fields
			private bool m_Disposed; // 0x10
	
			// Constructors
			protected Scope() {} // 0x00000001802466A0-0x00000001802466B0
	
			// Methods
			internal virtual void Dispose(bool disposing) {} // 0x0000000180A36D10-0x0000000180A36D70
			~Scope() {} // 0x0000000180A36DE0-0x0000000180A36F50
			public void Dispose() {} // 0x0000000180A36D70-0x0000000180A36DE0
			protected abstract void CloseScope();
		}
	
		// Constructors
		public GUI() {} // Dummy constructor
		static GUI() {} // 0x0000000180A35B80-0x0000000180A35E00
	
		// Methods
		internal static void GrabMouseControl(int id) {} // 0x0000000180A32A90-0x0000000180A32AD0
		internal static bool HasMouseControl(int id) => default; // 0x0000000180A33700-0x0000000180A33740
		internal static void ReleaseMouseControl() {} // 0x0000000180A340E0-0x0000000180A34110
		[FreeFunction] // 0x00000001800F46F0-0x00000001800F4720
		public static void SetNextControlName(string name) {} // 0x0000000180A34C20-0x0000000180A34C60
		[FreeFunction] // 0x00000001800F4840-0x00000001800F4870
		public static string GetNameOfFocusedControl() => default; // 0x0000000180A32A60-0x0000000180A32A90
		[FreeFunction] // 0x00000001800F49A0-0x00000001800F49D0
		public static void FocusControl(string name) {} // 0x0000000180A32A20-0x0000000180A32A60
		internal static void InternalRepaintEditorWindow() {} // 0x0000000180A33B80-0x0000000180A33BB0
		private static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout) => default; // 0x0000000180A33C20-0x0000000180A33D20
		public static void DragWindow(Rect position) {} // 0x0000000180A306C0-0x0000000180A30730
		internal static void DoSetSkin(GUISkin newSkin) {} // 0x0000000180A2FDF0-0x0000000180A2FF40
		public static void Label(Rect position, string text) {} // 0x0000000180A33E10-0x0000000180A33F20
		public static void Label(Rect position, string text, GUIStyle style) {} // 0x0000000180A33D20-0x0000000180A33E10
		public static void Label(Rect position, GUIContent content, GUIStyle style) {} // 0x0000000180A33F20-0x0000000180A33FB0
		public static void DrawTexture(Rect position, Texture image) {} // 0x0000000180A31740-0x0000000180A31920
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) {} // 0x0000000180A312D0-0x0000000180A31480
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) {} // 0x0000000180A31DF0-0x0000000180A31F70
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) {} // 0x0000000180A31CB0-0x0000000180A31DF0
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) {} // 0x0000000180A31480-0x0000000180A31740
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) {} // 0x0000000180A31A80-0x0000000180A31CB0
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) {} // 0x0000000180A31F70-0x0000000180A32100
		internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) {} // 0x0000000180A31920-0x0000000180A31A80
		internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) {} // 0x0000000180A30CF0-0x0000000180A312D0
		internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect) => default; // 0x0000000180A2DF00-0x0000000180A2E240
		public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords) {} // 0x0000000180A30C60-0x0000000180A30CF0
		public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords, bool alphaBlend) {} // 0x0000000180A30820-0x0000000180A30C60
		public static void Box(Rect position, string text) {} // 0x0000000180A2D2A0-0x0000000180A2D360
		public static void Box(Rect position, GUIContent content) {} // 0x0000000180A2D210-0x0000000180A2D2A0
		public static void Box(Rect position, GUIContent content, GUIStyle style) {} // 0x0000000180A2D030-0x0000000180A2D210
		public static bool Button(Rect position, string text) => default; // 0x0000000180A2D360-0x0000000180A2D420
		public static bool Button(Rect position, string text, GUIStyle style) => default; // 0x0000000180A2D760-0x0000000180A2D810
		public static bool Button(Rect position, GUIContent content, GUIStyle style) => default; // 0x0000000180A2D590-0x0000000180A2D760
		internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) => default; // 0x0000000180A2D420-0x0000000180A2D590
		private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType) => default; // 0x0000000180A2FA00-0x0000000180A2FDF0
		public static string TextField(Rect position, string text) => default; // 0x0000000180A34F40-0x0000000180A35090
		public static string TextField(Rect position, string text, int maxLength) => default; // 0x0000000180A34DF0-0x0000000180A34F40
		internal static string PasswordFieldGetStrToShow(string password, char maskChar) => default; // 0x0000000180A33FB0-0x0000000180A340E0
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style) {} // 0x0000000180A30220-0x0000000180A30320
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText) {} // 0x0000000180A30320-0x0000000180A303E0
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar) {} // 0x0000000180A2FF40-0x0000000180A30220
		private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor) {} // 0x0000000180A331C0-0x0000000180A33700
		private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor) {} // 0x0000000180A32AD0-0x0000000180A331C0
		public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style) => default; // 0x0000000180A35090-0x0000000180A35240
		internal static int Toolbar(Rect position, int selected, GUIContent[] contents, string[] controlNames, GUIStyle style, ToolbarButtonSize buttonSize, bool[] contentsEnabled = null) => default; // 0x0000000180A35240-0x0000000180A35390
		internal static void FindStyles(ref GUIStyle style, out GUIStyle firstStyle, out GUIStyle midStyle, out GUIStyle lastStyle, string first, string mid, string last) {
			firstStyle = default;
			midStyle = default;
			lastStyle = default;
		} // 0x0000000180A326C0-0x0000000180A32A20
		internal static int CalcTotalHorizSpacing(int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle) => default; // 0x0000000180A2DCF0-0x0000000180A2DF00
		private static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) => default; // 0x0000000180A2F340-0x0000000180A2F760
		private static void DoLabel(Rect position, GUIContent content, GUIStyle style) {} // 0x0000000180A2F760-0x0000000180A2FA00
		internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style) => default; // 0x0000000180A303E0-0x0000000180A30520
		internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) => default; // 0x0000000180A2F210-0x0000000180A2F340
		private static int DoButtonGrid(Rect position, int selected, GUIContent[] contents, string[] controlNames, int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, ToolbarButtonSize buttonSize, bool[] contentsEnabled = null) => default; // 0x0000000180A2E620-0x0000000180A2F210
		private static Rect[] CalcMouseRects(Rect position, GUIContent[] contents, int xCount, float elemWidth, float elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, bool addBorders, ToolbarButtonSize buttonSize) => default; // 0x0000000180A2D810-0x0000000180A2DCF0
		public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) => default; // 0x0000000180A33AB0-0x0000000180A33B80
		public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null) => default; // 0x0000000180A34C60-0x0000000180A34DF0
		public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style) => default; // 0x0000000180A33740-0x0000000180A33AB0
		internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style) => default; // 0x0000000180A34110-0x0000000180A34410
		public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue) => default; // 0x0000000180A35390-0x0000000180A35630
		public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style) => default; // 0x0000000180A35630-0x0000000180A359A0
		internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz) => default; // 0x0000000180A34410-0x0000000180A34C20
		public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) {} // 0x0000000180A2BCB0-0x0000000180A2BD70
		internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) {} // 0x0000000180A2BD70-0x0000000180A2C090
		public static void EndGroup() {} // 0x0000000180A32100-0x0000000180A32140
		internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background) => default; // 0x0000000180A2C090-0x0000000180A2D030
		public static void EndScrollView(bool handleScrollWheel) {} // 0x0000000180A32140-0x0000000180A326C0
		public static Rect Window(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style) => default; // 0x0000000180A359A0-0x0000000180A35B80
		private static Rect DoWindow(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout) => default; // 0x0000000180A30520-0x0000000180A30680
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void CallWindowDelegate(WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) {} // 0x0000000180A2E240-0x0000000180A2E620
		public static void DragWindow() {} // 0x0000000180A30730-0x0000000180A30820
		private static void get_color_Injected(out Color ret) {
			ret = default;
		} // 0x0000000180A35F60-0x0000000180A35FA0
		private static void set_color_Injected(ref Color value) {} // 0x0000000180A36430-0x0000000180A36470
		private static void get_backgroundColor_Injected(out Color ret) {
			ret = default;
		} // 0x0000000180A35E00-0x0000000180A35E40
		private static void set_backgroundColor_Injected(ref Color value) {} // 0x0000000180A36340-0x0000000180A36380
		private static void get_contentColor_Injected(out Color ret) {
			ret = default;
		} // 0x0000000180A36030-0x0000000180A36070
		private static void set_contentColor_Injected(ref Color value) {} // 0x0000000180A364E0-0x0000000180A36520
		private static void Internal_DoWindow_Injected(int id, int instanceID, ref Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout, out Rect ret) {
			ret = default;
		} // 0x0000000180A33BB0-0x0000000180A33C20
		private static void DragWindow_Injected(ref Rect position) {} // 0x0000000180A30680-0x0000000180A306C0
	}
}
