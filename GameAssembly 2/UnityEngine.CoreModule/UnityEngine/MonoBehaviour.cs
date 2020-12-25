/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	[ExtensionOfNativeClass] // 0x00000001800FBEA0-0x00000001800FBF20
	// [NativeHeader] // 0x00000001800FBEA0-0x00000001800FBF20
	// [NativeHeader] // 0x00000001800FBEA0-0x00000001800FBF20
	[RequiredByNativeCode] // 0x00000001800FBEA0-0x00000001800FBF20
	public class MonoBehaviour : Behaviour // TypeDefIndex: 3274
	{
		// Properties
		public bool useGUILayout { get => default; set {} } // 0x000000018093B2D0-0x000000018093B310 0x000000018093B370-0x000000018093B3C0
	
		// Constructors
		public MonoBehaviour() {} // 0x00000001808E4F10-0x00000001808E4F20
	
		// Methods
		public bool IsInvoking() => default; // 0x000000018093A990-0x000000018093A9D0
		public void CancelInvoke() {} // 0x000000018093A910-0x000000018093A950
		public void Invoke(string methodName, float time) {} // 0x000000018093AB20-0x000000018093AB80
		public void InvokeRepeating(string methodName, float time, float repeatRate) {} // 0x000000018093AA40-0x000000018093AB20
		public void CancelInvoke(string methodName) {} // 0x000000018093A8C0-0x000000018093A910
		public bool IsInvoking(string methodName) => default; // 0x000000018093AB80-0x000000018093ABD0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public Coroutine StartCoroutine(string methodName) => default; // 0x000000018093ADB0-0x000000018093AEB0
		public Coroutine StartCoroutine(string methodName, [DefaultValue] /* 0x00000001800F6CB0-0x00000001800F6CE0 */ object value) => default; // 0x000000018093AEB0-0x000000018093AFC0
		public Coroutine StartCoroutine(IEnumerator routine) => default; // 0x000000018093ACC0-0x000000018093ADB0
		[Obsolete] // 0x00000001800FC1C0-0x00000001800FC1F0
		public Coroutine StartCoroutine_Auto(IEnumerator routine) => default; // 0x000000018093ACC0-0x000000018093ADB0
		public void StopCoroutine(IEnumerator routine) {} // 0x000000018093B0A0-0x000000018093B190
		public void StopCoroutine(Coroutine routine) {} // 0x000000018093B1E0-0x000000018093B2D0
		public void StopCoroutine(string methodName) {} // 0x000000018093B190-0x000000018093B1E0
		public void StopAllCoroutines() {} // 0x000000018093AFC0-0x000000018093B000
		public static void print(object message) {} // 0x000000018093B310-0x000000018093B370
		[FreeFunction] // 0x00000001800FC270-0x00000001800FC2A0
		private static void Internal_CancelInvokeAll(MonoBehaviour self) {} // 0x000000018093A910-0x000000018093A950
		[FreeFunction] // 0x00000001800FC2E0-0x00000001800FC310
		private static bool Internal_IsInvokingAll(MonoBehaviour self) => default; // 0x000000018093A990-0x000000018093A9D0
		[FreeFunction] // 0x00000001800F2910-0x00000001800F2920
		private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) {} // 0x000000018093A9D0-0x000000018093AA40
		[FreeFunction] // 0x00000001800F2910-0x00000001800F2920
		private static void CancelInvoke(MonoBehaviour self, string methodName) {} // 0x000000018093A8C0-0x000000018093A910
		[FreeFunction] // 0x00000001800F2910-0x00000001800F2920
		private static bool IsInvoking(MonoBehaviour self, string methodName) => default; // 0x000000018093AB80-0x000000018093ABD0
		[FreeFunction] // 0x00000001800F2910-0x00000001800F2920
		private static bool IsObjectMonoBehaviour(Object obj) => default; // 0x000000018093ABD0-0x000000018093AC10
		private Coroutine StartCoroutineManaged(string methodName, object value) => default; // 0x000000018093AC60-0x000000018093ACC0
		private Coroutine StartCoroutineManaged2(IEnumerator enumerator) => default; // 0x000000018093AC10-0x000000018093AC60
		private void StopCoroutineManaged(Coroutine routine) {} // 0x000000018093B050-0x000000018093B0A0
		private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) {} // 0x000000018093B000-0x000000018093B050
		internal string GetScriptClassName() => default; // 0x000000018093A950-0x000000018093A990
	}
}
