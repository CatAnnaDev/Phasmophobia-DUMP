/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	public class InputModule : BaseInputModule // TypeDefIndex: 8370
	{
		// Fields
		private GameObject submitObject; // 0x48
		private static InputModule _instance; // 0x00
	
		// Properties
		public static InputModule instance { get => default; } // 0x0000000180FC50F0-0x0000000180FC51B0 
	
		// Constructors
		public InputModule() {} // 0x0000000180FC50E0-0x0000000180FC50F0
	
		// Methods
		public override bool ShouldActivateModule() => default; // 0x0000000180FC5070-0x0000000180FC50E0
		public void HoverBegin(GameObject gameObject) {} // 0x0000000180FC4D20-0x0000000180FC4E10
		public void HoverEnd(GameObject gameObject) {} // 0x0000000180FC4E10-0x0000000180FC4F20
		public void Submit(GameObject gameObject) {} // 0x0000000180249C10-0x0000000180249C20
		public override void Process() {} // 0x0000000180FC4F20-0x0000000180FC5070
	}
}
