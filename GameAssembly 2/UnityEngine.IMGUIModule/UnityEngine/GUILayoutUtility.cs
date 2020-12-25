/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngineInternal;

// Image 13: UnityEngine.IMGUIModule.dll - Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3731-3777

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800F71F0-0x00000001800F7220
	public class GUILayoutUtility // TypeDefIndex: 3752
	{
		// Fields
		private static readonly Dictionary<int, LayoutCache> s_StoredLayouts; // 0x00
		private static readonly Dictionary<int, LayoutCache> s_StoredWindows; // 0x08
		internal static LayoutCache current; // 0x10
		internal static readonly Rect kDummyRect; // 0x18
		private static GUIStyle s_SpaceStyle; // 0x28
	
		// Properties
		internal static GUIStyle spaceStyle { get => default; } // 0x0000000180A22620-0x0000000180A22750 
	
		// Nested types
		[VisibleToOtherModules] // 0x00000001800F7920-0x00000001800F79A0
		internal sealed class LayoutCache // TypeDefIndex: 3753
		{
			// Fields
			[VisibleToOtherModules] // 0x00000001800F7B20-0x00000001800F7BA0
			internal GUILayoutGroup topLevel; // 0x10
			internal GenericStack layoutGroups; // 0x18
			internal GUILayoutGroup windows; // 0x20
	
			// Constructors
			[VisibleToOtherModules] // 0x00000001800F7D70-0x00000001800F7DF0
			internal LayoutCache() {} // 0x0000000180A36990-0x0000000180A36A80
		}
	
		// Constructors
		public GUILayoutUtility() {} // Dummy constructor
		static GUILayoutUtility() {} // 0x0000000180A22500-0x0000000180A22620
	
		// Methods
		private static Rect Internal_GetWindowRect(int windowID) => default; // 0x0000000180A21600-0x0000000180A216A0
		private static void Internal_MoveWindow(int windowID, Rect r) {} // 0x0000000180A216E0-0x0000000180A21760
		[VisibleToOtherModules] // 0x00000001800F7250-0x00000001800F72D0
		internal static LayoutCache SelectIDList(int instanceID, bool isWindow) => default; // 0x0000000180A22330-0x0000000180A22500
		internal static void Begin(int instanceID) {} // 0x0000000180A206C0-0x0000000180A20970
		[VisibleToOtherModules] // 0x00000001800F7470-0x00000001800F74F0
		internal static void BeginContainer(LayoutCache cache) {} // 0x0000000180A1FAD0-0x0000000180A1FCB0
		internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) {} // 0x0000000180A20300-0x0000000180A206C0
		internal static void Layout() {} // 0x0000000180A22060-0x0000000180A22330
		internal static void LayoutFromEditorWindow() {} // 0x0000000180A21B00-0x0000000180A21D10
		[VisibleToOtherModules] // 0x00000001800F7690-0x00000001800F7710
		internal static void LayoutFromContainer(float w, float h) {} // 0x0000000180A21920-0x0000000180A21B00
		internal static void LayoutFreeGroup(GUILayoutGroup toplevel) {} // 0x0000000180A21760-0x0000000180A21920
		private static void LayoutSingleGroup(GUILayoutGroup i) {} // 0x0000000180A21D10-0x0000000180A22060
		private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) => default; // 0x0000000180A20970-0x0000000180A20A90
		internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) => default; // 0x0000000180A1FFB0-0x0000000180A20300
		internal static void EndLayoutGroup() {} // 0x0000000180A211B0-0x0000000180A21470
		internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) => default; // 0x0000000180A1FCB0-0x0000000180A1FFB0
		public static Rect GetRect(GUIContent content, GUIStyle style, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) => default; // 0x0000000180A21470-0x0000000180A21510
		private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) => default; // 0x0000000180A20A90-0x0000000180A20F60
		public static Rect GetRect(float width, float height, GUIStyle style, params /* 0x00000001800D4E50-0x00000001800D4E60 */ GUILayoutOption[] options) => default; // 0x0000000180A21510-0x0000000180A215C0
		private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) => default; // 0x0000000180A20F60-0x0000000180A211B0
		private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) {
			ret = default;
		} // 0x0000000180A215C0-0x0000000180A21600
		private static void Internal_MoveWindow_Injected(int windowID, ref Rect r) {} // 0x0000000180A216A0-0x0000000180A216E0
	}
}
