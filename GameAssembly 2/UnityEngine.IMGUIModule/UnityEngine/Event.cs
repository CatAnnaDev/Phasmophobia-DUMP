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
	// [NativeHeader] // 0x00000001800EEF50-0x00000001800EEFB0
	// [StaticAccessor] // 0x00000001800EEF50-0x00000001800EEFB0
	public sealed class Event // TypeDefIndex: 3732
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
		private static Event s_Current; // 0x00
		private static Event s_MasterEvent; // 0x08
	
		// Properties
		[NativeProperty] // 0x00000001800F1000-0x00000001800F1040
		public EventType rawType { get => default; } // 0x0000000180A1A5B0-0x0000000180A1A5F0 
		[NativeProperty] // 0x00000001800F10D0-0x00000001800F1110
		public Vector2 mousePosition { get => default; set {} } // 0x0000000180A1A4E0-0x0000000180A1A530 0x0000000180A1A8C0-0x0000000180A1A900
		[NativeProperty] // 0x00000001800F1220-0x00000001800F1260
		public Vector2 delta { get => default; } // 0x0000000180A1A260-0x0000000180A1A2B0 
		[NativeProperty] // 0x00000001800F12F0-0x00000001800F1330
		public PointerType pointerType { get => default; } // 0x0000000180A1A530-0x0000000180A1A570 
		[NativeProperty] // 0x00000001800F1390-0x00000001800F13D0
		public int button { get => default; } // 0x0000000180A1A050-0x0000000180A1A090 
		[NativeProperty] // 0x00000001800F1460-0x00000001800F14A0
		public EventModifiers modifiers { get => default; set {} } // 0x0000000180A1A450-0x0000000180A1A490 0x0000000180A1A830-0x0000000180A1A870
		[NativeProperty] // 0x00000001800F1520-0x00000001800F1560
		public float pressure { get => default; } // 0x0000000180A1A570-0x0000000180A1A5B0 
		[NativeProperty] // 0x00000001800F15F0-0x00000001800F1630
		public int clickCount { get => default; } // 0x0000000180A1A0D0-0x0000000180A1A110 
		[NativeProperty] // 0x00000001800F1700-0x00000001800F1740
		public char character { get => default; set {} } // 0x0000000180A1A090-0x0000000180A1A0D0 0x0000000180A1A670-0x0000000180A1A6C0
		[NativeProperty] // 0x00000001800F1800-0x00000001800F1840
		public KeyCode keyCode { get => default; set {} } // 0x0000000180A1A410-0x0000000180A1A450 0x0000000180A1A7F0-0x0000000180A1A830
		[NativeProperty] // 0x00000001800F18A0-0x00000001800F18E0
		public int displayIndex { get => default; set {} } // 0x0000000180A1A2B0-0x0000000180A1A2F0 0x0000000180A1A7B0-0x0000000180A1A7F0
		public EventType type { [FreeFunction] /* 0x00000001800EF010-0x00000001800EF050 */ get => default; [FreeFunction] /* 0x00000001800F0390-0x00000001800F03D0 */ set {} } // 0x0000000180A1A630-0x0000000180A1A670 0x0000000180A1A900-0x0000000180A1A940
		public string commandName { [FreeFunction] /* 0x00000001800F0430-0x00000001800F0470 */ get => default; [FreeFunction] /* 0x00000001800F0510-0x00000001800F0550 */ set {} } // 0x0000000180A1A110-0x0000000180A1A150 0x0000000180A1A6C0-0x0000000180A1A710
		public bool shift { get => default; } // 0x0000000180A1A5F0-0x0000000180A1A630 
		public bool control { get => default; } // 0x0000000180A1A190-0x0000000180A1A1D0 
		public bool alt { get => default; } // 0x0000000180A1A010-0x0000000180A1A050 
		public bool command { get => default; } // 0x0000000180A1A150-0x0000000180A1A190 
		public static Event current { get => default; set {} } // 0x0000000180A1A1D0-0x0000000180A1A210 0x0000000180A1A710-0x0000000180A1A7B0
		public bool isKey { get => default; } // 0x0000000180A1A360-0x0000000180A1A3B0 
		public bool isMouse { get => default; } // 0x0000000180A1A3B0-0x0000000180A1A410 
		internal bool isDirectManipulationDevice { [VisibleToOtherModules] /* 0x00000001800F0DE0-0x00000001800F0E60 */ get => default; } // 0x0000000180A1A2F0-0x0000000180A1A360 
	
		// Constructors
		public Event() {} // 0x0000000180A19F80-0x0000000180A19FC0
		public Event(int displayIndex) {} // 0x0000000180A19FC0-0x0000000180A1A010
	
		// Methods
		[NativeMethod] // 0x00000001800F05A0-0x00000001800F05D0
		private void Internal_Use() {} // 0x0000000180A17E40-0x0000000180A17E80
		[FreeFunction] // 0x00000001800F0660-0x00000001800F06A0
		private static IntPtr Internal_Create(int displayIndex) => default; // 0x0000000180A17C40-0x0000000180A17C80
		[FreeFunction] // 0x00000001800F0760-0x00000001800F07A0
		private static void Internal_Destroy(IntPtr ptr) {} // 0x0000000180A17C80-0x0000000180A17CC0
		[FreeFunction] // 0x00000001800F0980-0x00000001800F09C0
		public EventType GetTypeForControl(int controlID) => default; // 0x0000000180A17C00-0x0000000180A17C40
		[FreeFunction] // 0x00000001800F0A60-0x00000001800F0B00
		[VisibleToOtherModules] // 0x00000001800F0A60-0x00000001800F0B00
		internal void CopyFromPtr(IntPtr ptr) {} // 0x0000000180A176D0-0x0000000180A17720
		public static bool PopEvent([NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ Event outEvent) => default; // 0x0000000180A192B0-0x0000000180A192F0
		private static void Internal_SetNativeEvent(IntPtr ptr) {} // 0x0000000180A17E00-0x0000000180A17E40
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void Internal_MakeMasterEventCurrent(int displayIndex) {} // 0x0000000180A17CC0-0x0000000180A17E00
		~Event() {} // 0x0000000180A179E0-0x0000000180A17AD0
		[VisibleToOtherModules] // 0x00000001800F0C80-0x00000001800F0D00
		internal void CopyFrom(Event e) {} // 0x0000000180A17720-0x0000000180A17790
		public static Event KeyboardEvent(string key) => default; // 0x0000000180A17E80-0x0000000180A192B0
		public override int GetHashCode() => default; // 0x0000000180A17AD0-0x0000000180A17C00
		public override bool Equals(object obj) => default; // 0x0000000180A17790-0x0000000180A179E0
		public override string ToString() => default; // 0x0000000180A192F0-0x0000000180A19DD0
		public void Use() {} // 0x0000000180A19DD0-0x0000000180A19F80
		private void get_mousePosition_Injected(out Vector2 ret) {
			ret = default;
		} // 0x0000000180A1A490-0x0000000180A1A4E0
		private void set_mousePosition_Injected(ref Vector2 value) {} // 0x0000000180A1A870-0x0000000180A1A8C0
		private void get_delta_Injected(out Vector2 ret) {
			ret = default;
		} // 0x0000000180A1A210-0x0000000180A1A260
	}
}
