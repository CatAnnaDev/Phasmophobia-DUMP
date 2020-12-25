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
	[AttributeUsage(AttributeTargets.All)] // 0x00000001800F5B80-0x00000001800F5BC0
	[RequiredByNativeCode] // 0x00000001800F5B80-0x00000001800F5BC0
	public sealed class ContextMenu : Attribute // TypeDefIndex: 3253
	{
		// Fields
		public readonly string menuItem; // 0x10
		public readonly bool validate; // 0x18
		public readonly int priority; // 0x1C
	
		// Constructors
		public ContextMenu() {} // Dummy constructor
		public ContextMenu(string itemName) {} // 0x00000001809659F0-0x0000000180965A30
		public ContextMenu(string itemName, bool isValidateFunction) {} // 0x0000000180965A30-0x0000000180965A80
		public ContextMenu(string itemName, bool isValidateFunction, int priority) {} // 0x0000000180965A80-0x0000000180965AE0
	}
}
