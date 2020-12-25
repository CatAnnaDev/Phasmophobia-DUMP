/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using Valve.VR;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	public class ChaperoneInfo : MonoBehaviour // TypeDefIndex: 8434
	{
		// Fields
		public static SteamVR_Events.Event Initialized; // 0x00
		private static ChaperoneInfo _instance; // 0x08
	
		// Properties
		public bool initialized { get; private set; } // 0x00000001802D9720-0x00000001802D9730 0x00000001803DE8D0-0x00000001803DE8E0
		public float playAreaSizeX { get; private set; } // 0x00000001803847E0-0x00000001803847F0 0x0000000180384820-0x0000000180384830
		public float playAreaSizeZ { get; private set; } // 0x00000001803B47F0-0x00000001803B4800 0x0000000180AE4EB0-0x0000000180AE5030
		public bool roomscale { get; private set; } // 0x00000001802932C0-0x00000001802932D0 0x0000000180457830-0x0000000180457840
		public static ChaperoneInfo instance { get => default; } // 0x0000000180FB76B0-0x0000000180FB7890 
	
		// Constructors
		public ChaperoneInfo() {} // 0x0000000180276E90-0x0000000180276EA0
		static ChaperoneInfo() {} // 0x0000000180FB7650-0x0000000180FB76B0
	
		// Methods
		public static SteamVR_Events.Action InitializedAction(UnityAction action) => default; // 0x0000000180FB7540-0x0000000180FB75E0
		// [IteratorStateMachine] // 0x00000001800D6820-0x00000001800D6870
		private IEnumerator Start() => default; // 0x0000000180FB75E0-0x0000000180FB7650
	}
}
