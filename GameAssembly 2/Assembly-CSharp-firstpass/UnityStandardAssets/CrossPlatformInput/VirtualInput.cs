/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.CrossPlatformInput
{
	public abstract class VirtualInput // TypeDefIndex: 6061
	{
		// Fields
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes; // 0x20
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons; // 0x28
		protected List<string> m_AlwaysUseVirtual; // 0x30
	
		// Properties
		public Vector3 virtualMousePosition { get; private set; } // 0x0000000180623A70-0x0000000180623A90 0x000000018062E900-0x000000018062E910
	
		// Constructors
		protected VirtualInput() {} // 0x000000018062E830-0x000000018062E900
	
		// Methods
		public bool AxisExists(string name) => default; // 0x000000018062E300-0x000000018062E360
		public bool ButtonExists(string name) => default; // 0x000000018062E360-0x000000018062E3C0
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis) {} // 0x000000018062E3C0-0x000000018062E4C0
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button) {} // 0x000000018062E4C0-0x000000018062E5C0
		public void UnRegisterVirtualAxis(string name) {} // 0x000000018062E6D0-0x000000018062E740
		public void UnRegisterVirtualButton(string name) {} // 0x000000018062E740-0x000000018062E7B0
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name) => default; // 0x000000018062E7B0-0x000000018062E830
		public void SetVirtualMousePositionX(float f) {} // 0x000000018062E5C0-0x000000018062E620
		public void SetVirtualMousePositionY(float f) {} // 0x000000018062E620-0x000000018062E680
		public void SetVirtualMousePositionZ(float f) {} // 0x000000018062E680-0x000000018062E6D0
		public abstract float GetAxis(string name, bool raw);
		public abstract bool GetButton(string name);
		public abstract bool GetButtonDown(string name);
		public abstract bool GetButtonUp(string name);
		public abstract void SetButtonDown(string name);
		public abstract void SetButtonUp(string name);
		public abstract void SetAxisPositive(string name);
		public abstract void SetAxisNegative(string name);
		public abstract void SetAxisZero(string name);
		public abstract void SetAxis(string name, float value);
		public abstract Vector3 MousePosition();
	}
}
