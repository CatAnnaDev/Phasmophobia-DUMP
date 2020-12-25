/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeClass] // 0x00000001800F6330-0x00000001800F63A0
	// [NativeHeader] // 0x00000001800F6330-0x00000001800F63A0
	[RequiredByNativeCode] // 0x00000001800F6330-0x00000001800F63A0
	public class Component : Object // TypeDefIndex: 3264
	{
		// Properties
		public Transform transform { [FreeFunction] /* 0x00000001800F6570-0x00000001800F65B0 */ get => default; } // 0x0000000180964B70-0x0000000180964BB0 
		public GameObject gameObject { [FreeFunction] /* 0x00000001800F67A0-0x00000001800F67E0 */ get => default; } // 0x0000000180964AC0-0x0000000180964B00 
		public string tag { get => default; set {} } // 0x0000000180964B00-0x0000000180964B70 0x0000000180964BB0-0x0000000180964C30
	
		// Constructors
		public Component() {} // 0x000000018095F5F0-0x000000018095F650
	
		// Methods
		// [TypeInferenceRule] // 0x00000001800F6850-0x00000001800F6870
		public Component GetComponent(Type type) => default; // 0x00000001809647A0-0x0000000180964820
		[FreeFunction] // 0x00000001800F6950-0x00000001800F6980
		internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) {} // 0x0000000180964630-0x0000000180964690
		public T GetComponent<T>() => default;
		[FreeFunction] // 0x00000001800F69D0-0x00000001800F6A00
		public Component GetComponent(string type) => default; // 0x0000000180964820-0x0000000180964870
		// [TypeInferenceRule] // 0x00000001800F6850-0x00000001800F6870
		public Component GetComponentInChildren(Type t, bool includeInactive) => default; // 0x0000000180964690-0x0000000180964720
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public T GetComponentInChildren<T>() => default;
		public T[] GetComponentsInChildren<T>(bool includeInactive) => default;
		public void GetComponentsInChildren<T>(bool includeInactive, List<T> result) {}
		public T[] GetComponentsInChildren<T>() => default;
		public void GetComponentsInChildren<T>(List<T> results) {}
		// [TypeInferenceRule] // 0x00000001800F6850-0x00000001800F6870
		public Component GetComponentInParent(Type t) => default; // 0x0000000180964720-0x00000001809647A0
		public T GetComponentInParent<T>() => default;
		public T[] GetComponentsInParent<T>(bool includeInactive) => default;
		public void GetComponentsInParent<T>(bool includeInactive, List<T> results) {}
		public T[] GetComponentsInParent<T>() => default;
		[FreeFunction] // 0x00000001800F6950-0x00000001800F6980
		private void GetComponentsForListInternal(Type searchType, object resultList) {} // 0x0000000180964870-0x00000001809648D0
		public void GetComponents(Type type, List<Component> results) {} // 0x0000000180964870-0x00000001809648D0
		public void GetComponents<T>(List<T> results) {}
		public T[] GetComponents<T>() => default;
		public bool CompareTag(string tag) => default; // 0x00000001809645B0-0x0000000180964630
		[FreeFunction] // 0x00000001800F69D0-0x00000001800F6A00
		public void SendMessageUpwards(string methodName, [DefaultValue] /* 0x00000001800F6CB0-0x00000001800F6CE0 */ object value, [DefaultValue] /* 0x00000001800F6D20-0x00000001800F6D50 */ SendMessageOptions options) {} // 0x0000000180964930-0x00000001809649A0
		public void SendMessageUpwards(string methodName, SendMessageOptions options) {} // 0x00000001809648D0-0x0000000180964930
		public void SendMessage(string methodName) {} // 0x0000000180964A70-0x0000000180964AC0
		[FreeFunction] // 0x00000001800F6E20-0x00000001800F6E60
		public void SendMessage(string methodName, object value, SendMessageOptions options) {} // 0x0000000180964A00-0x0000000180964A70
		public void SendMessage(string methodName, SendMessageOptions options) {} // 0x00000001809649A0-0x0000000180964A00
		[FreeFunction] // 0x00000001800F6EC0-0x00000001800F6F00
		public void BroadcastMessage(string methodName, [DefaultValue] /* 0x00000001800F6CB0-0x00000001800F6CE0 */ object parameter, [DefaultValue] /* 0x00000001800F6D20-0x00000001800F6D50 */ SendMessageOptions options) {} // 0x0000000180964540-0x00000001809645B0
		public void BroadcastMessage(string methodName, SendMessageOptions options) {} // 0x00000001809644E0-0x0000000180964540
	}
}
