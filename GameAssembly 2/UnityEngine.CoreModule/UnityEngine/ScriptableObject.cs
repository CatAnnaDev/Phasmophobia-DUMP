/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	[ExtensionOfNativeClass] // 0x00000001800FC840-0x00000001800FC8B0
	// [NativeClass] // 0x00000001800FC840-0x00000001800FC8B0
	// [NativeHeader] // 0x00000001800FC840-0x00000001800FC8B0
	[RequiredByNativeCode] // 0x00000001800FC840-0x00000001800FC8B0
	public class ScriptableObject : Object // TypeDefIndex: 3279
	{
		// Constructors
		public ScriptableObject() {} // 0x00000001808D7310-0x00000001808D7390
	
		// Methods
		public static ScriptableObject CreateInstance(Type type) => default; // 0x00000001808DAE50-0x00000001808DAE90
		public static T CreateInstance<T>()
			where T : ScriptableObject => default;
		[NativeMethod] // 0x00000001800D8420-0x00000001800D8450
		private static void CreateScriptableObject([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ ScriptableObject self) {} // 0x00000001808DAEE0-0x00000001808DAF20
		[FreeFunction] // 0x00000001800FCB50-0x00000001800FCB80
		internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) => default; // 0x00000001808DAE90-0x00000001808DAEE0
	}
}
