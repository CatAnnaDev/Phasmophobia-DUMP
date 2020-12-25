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
	// [NativeHeader] // 0x00000001800FD540-0x00000001800FD630
	// [NativeHeader] // 0x00000001800FD540-0x00000001800FD630
	// [NativeHeader] // 0x00000001800FD540-0x00000001800FD630
	// [NativeHeader] // 0x00000001800FD540-0x00000001800FD630
	// [NativeHeader] // 0x00000001800FD540-0x00000001800FD630
	// [NativeHeader] // 0x00000001800FD540-0x00000001800FD630
	public class GUIUtility // TypeDefIndex: 3762
	{
		// Fields
		[VisibleToOtherModules] // 0x00000001800FD8C0-0x00000001800FD940
		internal static int s_SkinMode; // 0x00
		[VisibleToOtherModules] // 0x00000001800FDA40-0x00000001800FDAC0
		internal static int s_OriginalID; // 0x04
		[VisibleToOtherModules] // 0x00000001800FEEE0-0x00000001800FEF60
		internal static Action takeCapture; // 0x08
		[VisibleToOtherModules] // 0x00000001800FEFF0-0x00000001800FF070
		internal static Action releaseCapture; // 0x10
		[VisibleToOtherModules] // 0x00000001800FF1B0-0x00000001800FF230
		internal static Func<int, IntPtr, bool> processEvent; // 0x18
		[VisibleToOtherModules] // 0x00000001800FF380-0x00000001800FF400
		internal static Action cleanupRoots; // 0x20
		[VisibleToOtherModules] // 0x00000001800FF4D0-0x00000001800FF550
		internal static Func<Exception, bool> endContainerGUIFromException; // 0x28
		[VisibleToOtherModules] // 0x00000001800FF620-0x00000001800FF6A0
		internal static Action guiChanged; // 0x30
		internal static Func<bool> s_HasCurrentWindowKeyFocusFunc; // 0x40
	
		// Properties
		[NativeProperty] // 0x0000000180101F20-0x0000000180101F60
		internal static float pixelsPerPoint { [VisibleToOtherModules] /* 0x00000001800FF8E0-0x00000001800FF960 */ get => default; } // 0x0000000180AA1630-0x0000000180AA1660 
		[NativeProperty] // 0x0000000180101FD0-0x0000000180102010
		internal static int guiDepth { [VisibleToOtherModules] /* 0x00000001800FFA30-0x00000001800FFAB0 */ get => default; } // 0x0000000180AA15C0-0x0000000180AA15F0 
		[NativeProperty] // 0x0000000180102040-0x0000000180102080
		internal static bool mouseUsed { set {} } // 0x0000000180AA1750-0x0000000180AA1790
		// [StaticAccessor] // 0x00000001801022A0-0x00000001801022D0
		internal static bool textFieldInput { set {} } // 0x0000000180AA17D0-0x0000000180AA1810
		public static string systemCopyBuffer { [FreeFunction] /* 0x00000001800FFC10-0x00000001800FFC40 */ get => default; [FreeFunction] /* 0x00000001800FFD00-0x00000001800FFD30 */ set {} } // 0x0000000180AA1660-0x0000000180AA1690 0x0000000180AA1790-0x0000000180AA17D0
		// [StaticAccessor] // 0x0000000180102380-0x00000001801023B0
		internal static string compositionString { [VisibleToOtherModules] /* 0x0000000180100D00-0x0000000180100D80 */ get => default; } // 0x0000000180AA1590-0x0000000180AA15C0 
		// [StaticAccessor] // 0x0000000180102380-0x00000001801023B0
		internal static Vector2 compositionCursorPos { [VisibleToOtherModules] /* 0x0000000180100EE0-0x0000000180100F60 */ set {} } // 0x0000000180AA16D0-0x0000000180AA1710
		internal static bool guiIsExiting { get; set; } // 0x0000000180AA15F0-0x0000000180AA1630 0x0000000180AA1710-0x0000000180AA1750
		public static int hotControl { get => default; set {} } // 0x0000000180AA1140-0x0000000180AA1170 0x0000000180AA11A0-0x0000000180AA11E0
		public static int keyboardControl { get => default; set {} } // 0x0000000180AA1170-0x0000000180AA11A0 0x0000000180AA11E0-0x0000000180AA1220
	
		// Constructors
		public GUIUtility() {} // Dummy constructor
	
		// Methods
		// [StaticAccessor] // 0x00000001800FFE50-0x00000001800FFE80
		public static int GetControlID(int hint, FocusType focusType, Rect rect) => default; // 0x0000000180AA0C40-0x0000000180AA0C90
		[VisibleToOtherModules] // 0x00000001800FFEE0-0x00000001800FFF60
		internal static void BeginContainerFromOwner(ScriptableObject owner) {} // 0x0000000180AA0540-0x0000000180AA0580
		[VisibleToOtherModules] // 0x0000000180100080-0x0000000180100100
		internal static void BeginContainer(ObjectGUIState objectGUIState) {} // 0x0000000180AA0580-0x0000000180AA05C0
		[NativeMethod] // 0x00000001801002B0-0x00000001801002E0
		internal static void Internal_EndContainer() {} // 0x0000000180AA10A0-0x0000000180AA10D0
		[VisibleToOtherModules] // 0x0000000180100340-0x00000001801003C0
		internal static int CheckForTabEvent(Event evt) => default; // 0x0000000180AA0730-0x0000000180AA0770
		[VisibleToOtherModules] // 0x00000001801005B0-0x0000000180100630
		internal static void SetKeyboardControlToFirstControlId() {} // 0x0000000180AA14E0-0x0000000180AA1510
		[VisibleToOtherModules] // 0x0000000180100710-0x0000000180100790
		internal static void SetKeyboardControlToLastControlId() {} // 0x0000000180AA1510-0x0000000180AA1540
		[VisibleToOtherModules] // 0x0000000180100910-0x0000000180100990
		internal static bool HasFocusableControls() => default; // 0x0000000180AA0DB0-0x0000000180AA0DE0
		[VisibleToOtherModules] // 0x0000000180100AD0-0x0000000180100B50
		internal static bool OwnsId(int id) => default; // 0x0000000180AA12F0-0x0000000180AA1330
		public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) {
			widthInPixels = default;
			heightInPixels = default;
			return default;
		} // 0x0000000180AA0450-0x0000000180AA04D0
		private static int Internal_GetHotControl() => default; // 0x0000000180AA1140-0x0000000180AA1170
		private static int Internal_GetKeyboardControl() => default; // 0x0000000180AA1170-0x0000000180AA11A0
		private static void Internal_SetHotControl(int value) {} // 0x0000000180AA11A0-0x0000000180AA11E0
		private static void Internal_SetKeyboardControl(int value) {} // 0x0000000180AA11E0-0x0000000180AA1220
		private static object Internal_GetDefaultSkin(int skinMode) => default; // 0x0000000180AA1100-0x0000000180AA1140
		private static void Internal_ExitGUI() {} // 0x0000000180AA10D0-0x0000000180AA1100
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static void MarkGUIChanged() {} // 0x0000000180AA12A0-0x0000000180AA12F0
		public static int GetControlID(FocusType focus) => default; // 0x0000000180AA0BF0-0x0000000180AA0C40
		public static int GetControlID(FocusType focus, Rect position) => default; // 0x0000000180AA0C90-0x0000000180AA0CD0
		public static int GetControlID(int hint, FocusType focus) => default; // 0x0000000180AA0B90-0x0000000180AA0BF0
		public static object GetStateObject(Type t, int controlID) => default; // 0x0000000180AA0D50-0x0000000180AA0DB0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void TakeCapture() {} // 0x0000000180AA1540-0x0000000180AA1590
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void RemoveCapture() {} // 0x0000000180AA13A0-0x0000000180AA13F0
		internal static bool HasKeyFocus(int controlID) => default; // 0x0000000180AA0DE0-0x0000000180AA0E70
		public static void ExitGUI() {} // 0x0000000180AA0AF0-0x0000000180AA0B40
		internal static GUISkin GetDefaultSkin() => default; // 0x0000000180AA0CD0-0x0000000180AA0D50
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) => default; // 0x0000000180AA1330-0x0000000180AA13A0
		[VisibleToOtherModules] // 0x0000000180101440-0x00000001801014C0
		internal static void EndContainer() {} // 0x0000000180AA0860-0x0000000180AA08B0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) {} // 0x0000000180AA05C0-0x0000000180AA0730
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void EndGUI(int layoutType) {} // 0x0000000180AA0950-0x0000000180AA0AF0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static bool EndGUIFromException(Exception exception) => default; // 0x0000000180AA08B0-0x0000000180AA0950
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static bool EndContainerGUIFromException(Exception exception) => default; // 0x0000000180AA0800-0x0000000180AA0860
		[VisibleToOtherModules] // 0x0000000180101760-0x00000001801017E0
		internal static void ResetGlobalState() {} // 0x0000000180AA13F0-0x0000000180AA14E0
		[VisibleToOtherModules] // 0x0000000180101A90-0x0000000180101B10
		internal static bool IsExitGUIException(Exception exception) => default; // 0x0000000180AA1220-0x0000000180AA12A0
		[VisibleToOtherModules] // 0x0000000180101C90-0x0000000180101D10
		internal static bool ShouldRethrowException(Exception exception) => default; // 0x0000000180AA1220-0x0000000180AA12A0
		internal static void CheckOnGUI() {} // 0x0000000180AA0770-0x0000000180AA0800
		public static Rect AlignRectToDevice(Rect rect) => default; // 0x0000000180AA04D0-0x0000000180AA0540
		internal static bool HitTest(Rect rect, Vector2 point, int offset) => default; // 0x0000000180AA0E70-0x0000000180AA0F10
		internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) => default; // 0x0000000180AA0F10-0x0000000180AA0FC0
		internal static bool HitTest(Rect rect, Event evt) => default; // 0x0000000180AA0FC0-0x0000000180AA10A0
		private static int GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) => default; // 0x0000000180AA0B40-0x0000000180AA0B90
		private static void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) {
			widthInPixels = default;
			heightInPixels = default;
			ret = default;
		} // 0x0000000180AA03E0-0x0000000180AA0450
		private static void set_compositionCursorPos_Injected(ref Vector2 value) {} // 0x0000000180AA1690-0x0000000180AA16D0
	}
}
