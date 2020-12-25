/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 32: UnityEngine.UIModule.dll - Assembly: UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4132-4141

namespace UnityEngine
{
	// [NativeClass] // 0x000000018011B9F0-0x000000018011BA50
	// [NativeHeader] // 0x000000018011B9F0-0x000000018011BA50
	public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 4134
	{
		// Properties
		[NativeProperty] // 0x000000018011BBB0-0x000000018011BBF0
		public float alpha { get => default; set {} } // 0x0000000180AECEE0-0x0000000180AECF20 0x0000000180AECFA0-0x0000000180AECFF0
		[NativeProperty] // 0x000000018011BD60-0x000000018011BDA0
		public bool interactable { get => default; } // 0x0000000180AECF60-0x0000000180AECFA0 
		[NativeProperty] // 0x000000018011BE60-0x000000018011BEA0
		public bool blocksRaycasts { get => default; set {} } // 0x0000000180AECEA0-0x0000000180AECEE0 0x0000000180AECFF0-0x0000000180AED040
		[NativeProperty] // 0x000000018011BFC0-0x000000018011C000
		public bool ignoreParentGroups { get => default; } // 0x0000000180AECF20-0x0000000180AECF60 
	
		// Constructors
		public CanvasGroup() {} // Dummy constructor
	
		// Methods
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) => default; // 0x0000000180AECEA0-0x0000000180AECEE0
	}
}
