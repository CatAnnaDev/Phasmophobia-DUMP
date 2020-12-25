/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.CrossPlatformInput
{
	public static class CrossPlatformInputManager // TypeDefIndex: 6046
	{
		// Fields
		private static VirtualInput activeInput; // 0x00
		private static VirtualInput s_TouchInput; // 0x08
		private static VirtualInput s_HardwareInput; // 0x10
	
		// Properties
		public static Vector3 mousePosition { get; } // 0x0000000180621D70-0x0000000180621E00 
	
		// Nested types
		public enum ActiveInputMethod // TypeDefIndex: 6047
		{
			Hardware = 0,
			Touch = 1
		}
	
		public class VirtualAxis // TypeDefIndex: 6048
		{
			// Fields
			private float m_Value; // 0x18
	
			// Properties
			public string name { get; private set; } // 0x0000000180248E10-0x0000000180248E20 0x0000000180248410-0x0000000180248420
			public bool matchWithInputManager { get; private set; } // 0x0000000180568740-0x0000000180568750 0x000000018062E0A0-0x000000018062E0B0
			public float GetValue { get => default; } // 0x00000001803847D0-0x00000001803847E0 
			public float GetValueRaw { get => default; } // 0x00000001803847D0-0x00000001803847E0 
	
			// Constructors
			public VirtualAxis() {} // Dummy constructor
			public VirtualAxis(string name) {} // 0x000000018062E010-0x000000018062E050
			public VirtualAxis(string name, bool matchToInputSettings) {} // 0x000000018062E050-0x000000018062E0A0
	
			// Methods
			public void Remove() {} // 0x000000018062DFB0-0x000000018062E010
			public void Update(float value) {} // 0x0000000180384810-0x0000000180384820
		}
	
		public class VirtualButton // TypeDefIndex: 6049
		{
			// Fields
			private int m_LastPressedFrame; // 0x1C
			private int m_ReleasedFrame; // 0x20
			private bool m_Pressed; // 0x24
	
			// Properties
			public string name { get; private set; } // 0x0000000180248E10-0x0000000180248E20 0x0000000180248410-0x0000000180248420
			public bool matchWithInputManager { get; private set; } // 0x00000001802D9720-0x00000001802D9730 0x00000001803DE8D0-0x00000001803DE8E0
			public bool GetButton { get => default; } // 0x00000001802932C0-0x00000001802932D0 
			public bool GetButtonDown { get => default; } // 0x000000018062E2C0-0x000000018062E2E0 
			public bool GetButtonUp { get => default; } // 0x000000018062E2E0-0x000000018062E300 
	
			// Constructors
			public VirtualButton() {} // Dummy constructor
			public VirtualButton(string name) {} // 0x000000018062E270-0x000000018062E2C0
			public VirtualButton(string name, bool matchToInputSettings) {} // 0x000000018062E210-0x000000018062E270
	
			// Methods
			public void Pressed() {} // 0x000000018062E0B0-0x000000018062E0E0
			public void Released() {} // 0x000000018062E0E0-0x000000018062E100
			public void Remove() {} // 0x000000018062E100-0x000000018062E210
		}
	
		// Constructors
		static CrossPlatformInputManager() {} // 0x0000000180621CC0-0x0000000180621D70
	
		// Methods
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod) {} // 0x0000000180621980-0x0000000180621A30
		public static bool AxisExists(string name) => default; // 0x0000000180620D70-0x0000000180620E20
		public static bool ButtonExists(string name) => default; // 0x0000000180620E20-0x0000000180620ED0
		public static void RegisterVirtualAxis(VirtualAxis axis) {} // 0x00000001806211A0-0x00000001806212F0
		public static void RegisterVirtualButton(VirtualButton button) {} // 0x00000001806212F0-0x0000000180621440
		public static void UnRegisterVirtualAxis(string name) {} // 0x0000000180621A30-0x0000000180621B30
		public static void UnRegisterVirtualButton(string name) {} // 0x0000000180621B30-0x0000000180621BF0
		public static VirtualAxis VirtualAxisReference(string name) => default; // 0x0000000180621BF0-0x0000000180621CC0
		public static float GetAxis(string name) => default; // 0x0000000180620F30-0x0000000180620F90
		public static float GetAxisRaw(string name) => default; // 0x0000000180620ED0-0x0000000180620F30
		private static float GetAxis(string name, bool raw) => default; // 0x0000000180620F90-0x0000000180621020
		public static bool GetButton(string name) => default; // 0x0000000180621120-0x00000001806211A0
		public static bool GetButtonDown(string name) => default; // 0x0000000180621020-0x00000001806210A0
		public static bool GetButtonUp(string name) => default; // 0x00000001806210A0-0x0000000180621120
		public static void SetButtonDown(string name) {} // 0x0000000180621650-0x00000001806216D0
		public static void SetButtonUp(string name) {} // 0x00000001806216D0-0x0000000180621750
		public static void SetAxisPositive(string name) {} // 0x00000001806214C0-0x0000000180621540
		public static void SetAxisNegative(string name) {} // 0x0000000180621440-0x00000001806214C0
		public static void SetAxisZero(string name) {} // 0x0000000180621540-0x00000001806215C0
		public static void SetAxis(string name, float value) {} // 0x00000001806215C0-0x0000000180621650
		public static void SetVirtualMousePositionX(float f) {} // 0x0000000180621750-0x0000000180621810
		public static void SetVirtualMousePositionY(float f) {} // 0x0000000180621810-0x00000001806218D0
		public static void SetVirtualMousePositionZ(float f) {} // 0x00000001806218D0-0x0000000180621980
	}
}
