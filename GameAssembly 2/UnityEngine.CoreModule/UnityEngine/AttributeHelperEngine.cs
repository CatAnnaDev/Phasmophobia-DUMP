/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	internal class AttributeHelperEngine // TypeDefIndex: 3248
	{
		// Fields
		public static DisallowMultipleComponent[] _disallowMultipleComponentArray; // 0x00
		public static ExecuteInEditMode[] _executeInEditModeArray; // 0x08
		public static RequireComponent[] _requireComponentArray; // 0x10
	
		// Constructors
		public AttributeHelperEngine() {} // Dummy constructor
		static AttributeHelperEngine() {} // 0x000000018095E870-0x000000018095E920
	
		// Methods
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static Type GetParentTypeDisallowingMultipleInclusion(Type type) => default; // 0x000000018095E470-0x000000018095E550
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static Type[] GetRequiredComponents(Type klass) => default; // 0x000000018095E550-0x000000018095E870
		private static int GetExecuteMode(Type klass) => default; // 0x000000018095E370-0x000000018095E470
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static int CheckIsEditorScript(Type klass) => default; // 0x000000018095E240-0x000000018095E300
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static int GetDefaultExecutionOrderFor(Type klass) => default; // 0x000000018095E300-0x000000018095E370
		private static T GetCustomAttributeOfType<T>(Type klass)
			where T : Attribute => default;
	}
}
