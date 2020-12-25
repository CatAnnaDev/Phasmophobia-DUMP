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
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngineInternal;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	[ExcludeFromPreset] // 0x00000001800F7710-0x00000001800F7770
	// [NativeHeader] // 0x00000001800F7710-0x00000001800F7770
	[UsedByNativeCode] // 0x00000001800F7710-0x00000001800F7770
	public sealed class GameObject : Object // TypeDefIndex: 3271
	{
		// Properties
		public Transform transform { [FreeFunction] /* 0x00000001800F8770-0x00000001800F87B0 */ get => default; } // 0x000000018096A2E0-0x000000018096A320 
		public int layer { get => default; set {} } // 0x000000018096A1C0-0x000000018096A200 0x000000018096A320-0x000000018096A360
		public bool activeSelf { [NativeMethod] /* 0x00000001800F8A40-0x00000001800F8A80 */ get => default; } // 0x000000018096A140-0x000000018096A180 
		public bool activeInHierarchy { [NativeMethod] /* 0x00000001800F8C50-0x00000001800F8C90 */ get => default; } // 0x000000018096A100-0x000000018096A140 
		public bool isStatic { [NativeMethod] /* 0x00000001800F8E20-0x00000001800F8E60 */ get => default; } // 0x000000018096A180-0x000000018096A1C0 
		public string tag { [FreeFunction] /* 0x00000001800F9010-0x00000001800F9050 */ get => default; [FreeFunction] /* 0x00000001800F90D0-0x00000001800F9110 */ set {} } // 0x000000018096A2A0-0x000000018096A2E0 0x000000018096A360-0x000000018096A3B0
		public Scene scene { [FreeFunction] /* 0x00000001800FB440-0x00000001800FB480 */ get => default; } // 0x000000018096A250-0x000000018096A2A0 
		public GameObject gameObject { get => default; } // 0x00000001802E9530-0x00000001802E9540 
	
		// Constructors
		public GameObject(string name) {} // 0x000000018096A070-0x000000018096A100
		public GameObject() {} // 0x0000000180969FF0-0x000000018096A070
		public GameObject(string name, params /* 0x00000001800D4E50-0x00000001800D4E60 */ Type[] components) {} // 0x0000000180969EF0-0x0000000180969FF0
	
		// Methods
		[FreeFunction] // 0x00000001800F7890-0x00000001800F78C0
		public static GameObject CreatePrimitive(PrimitiveType type) => default; // 0x0000000180969920-0x0000000180969960
		public T GetComponent<T>() => default;
		[FreeFunction] // 0x00000001800F78C0-0x00000001800F7920
		// [TypeInferenceRule] // 0x00000001800F78C0-0x00000001800F7920
		public Component GetComponent(Type type) => default; // 0x0000000180969B80-0x0000000180969BD0
		[FreeFunction] // 0x00000001800F7A50-0x00000001800F7AA0
		[NativeWritableSelf] // 0x00000001800F7A50-0x00000001800F7AA0
		internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) {} // 0x0000000180969A70-0x0000000180969AD0
		[FreeFunction] // 0x00000001800F7BA0-0x00000001800F7BE0
		internal Component GetComponentByName(string type) => default; // 0x0000000180969A20-0x0000000180969A70
		public Component GetComponent(string type) => default; // 0x0000000180969A20-0x0000000180969A70
		[FreeFunction] // 0x00000001800F7C30-0x00000001800F7C90
		// [TypeInferenceRule] // 0x00000001800F7C30-0x00000001800F7C90
		public Component GetComponentInChildren(Type type, bool includeInactive) => default; // 0x0000000180969AD0-0x0000000180969B30
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public T GetComponentInChildren<T>() => default;
		public T GetComponentInChildren<T>([DefaultValue] /* 0x00000001800DFAE0-0x00000001800DFB10 */ bool includeInactive) => default;
		[FreeFunction] // 0x00000001800F81D0-0x00000001800F8230
		// [TypeInferenceRule] // 0x00000001800F81D0-0x00000001800F8230
		public Component GetComponentInParent(Type type) => default; // 0x0000000180969B30-0x0000000180969B80
		public T GetComponentInParent<T>() => default;
		[FreeFunction] // 0x00000001800F8260-0x00000001800F82A0
		private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) => default; // 0x0000000180969BD0-0x0000000180969C50
		public T[] GetComponents<T>() => default;
		public void GetComponents<T>(List<T> results) {}
		public T[] GetComponentsInChildren<T>(bool includeInactive) => default;
		public void GetComponentsInChildren<T>(bool includeInactive, List<T> results) {}
		public T[] GetComponentsInChildren<T>() => default;
		public void GetComponentsInParent<T>(bool includeInactive, List<T> results) {}
		public T[] GetComponentsInParent<T>(bool includeInactive) => default;
		public void SendMessageUpwards(string methodName, SendMessageOptions options) {} // 0x0000000180969CA0-0x0000000180969D00
		public void SendMessage(string methodName, SendMessageOptions options) {} // 0x0000000180969D70-0x0000000180969DD0
		public void BroadcastMessage(string methodName, SendMessageOptions options) {} // 0x0000000180969800-0x0000000180969860
		[FreeFunction] // 0x00000001800F8640-0x00000001800F8680
		private Component Internal_AddComponentWithType(Type componentType) => default; // 0x0000000180969760-0x00000001809697B0
		// [TypeInferenceRule] // 0x00000001800F6850-0x00000001800F6870
		public Component AddComponent(Type componentType) => default; // 0x0000000180969760-0x00000001809697B0
		public T AddComponent<T>()
			where T : Component => default;
		[NativeMethod] // 0x00000001800F8970-0x00000001800F89B0
		public void SetActive(bool value) {} // 0x0000000180969EA0-0x0000000180969EF0
		[FreeFunction] // 0x00000001800F9170-0x00000001800F91B0
		public bool CompareTag(string tag) => default; // 0x00000001809698D0-0x0000000180969920
		[FreeFunction] // 0x00000001800F9340-0x00000001800F9380
		public static GameObject FindGameObjectWithTag(string tag) => default; // 0x0000000180969960-0x00000001809699A0
		[FreeFunction] // 0x00000001800F94B0-0x00000001800F94F0
		public static GameObject[] FindGameObjectsWithTag(string tag) => default; // 0x00000001809699A0-0x00000001809699E0
		[FreeFunction] // 0x00000001800F9620-0x00000001800F9660
		public void SendMessageUpwards(string methodName, [DefaultValue] /* 0x00000001800F6CB0-0x00000001800F6CE0 */ object value, [DefaultValue] /* 0x00000001800F6D20-0x00000001800F6D50 */ SendMessageOptions options) {} // 0x0000000180969D00-0x0000000180969D70
		[FreeFunction] // 0x00000001800F9900-0x00000001800F9940
		public void SendMessage(string methodName, [DefaultValue] /* 0x00000001800F6CB0-0x00000001800F6CE0 */ object value, [DefaultValue] /* 0x00000001800F6D20-0x00000001800F6D50 */ SendMessageOptions options) {} // 0x0000000180969E30-0x0000000180969EA0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void SendMessage(string methodName, object value) {} // 0x0000000180969DD0-0x0000000180969E30
		[FreeFunction] // 0x00000001800F9BA0-0x00000001800F9BE0
		public void BroadcastMessage(string methodName, [DefaultValue] /* 0x00000001800F6CB0-0x00000001800F6CE0 */ object parameter, [DefaultValue] /* 0x00000001800F6D20-0x00000001800F6D50 */ SendMessageOptions options) {} // 0x0000000180969860-0x00000001809698D0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void BroadcastMessage(string methodName) {} // 0x00000001809697B0-0x0000000180969800
		[FreeFunction] // 0x00000001800F9E50-0x00000001800F9E90
		private static void Internal_CreateGameObject([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ GameObject self, string name) {} // 0x0000000180969C50-0x0000000180969CA0
		[FreeFunction] // 0x00000001800FB360-0x00000001800FB3A0
		public static GameObject Find(string name) => default; // 0x00000001809699E0-0x0000000180969A20
		private void get_scene_Injected(out Scene ret) {
			ret = default;
		} // 0x000000018096A200-0x000000018096A250
	}
}
