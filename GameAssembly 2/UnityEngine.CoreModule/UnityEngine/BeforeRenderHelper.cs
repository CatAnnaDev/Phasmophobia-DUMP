/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	internal static class BeforeRenderHelper // TypeDefIndex: 3132
	{
		// Fields
		private static List<OrderBlock> s_OrderBlocks; // 0x00
	
		// Nested types
		private struct OrderBlock // TypeDefIndex: 3133
		{
			// Fields
			internal int order; // 0x00
			internal UnityAction callback; // 0x08
		}
	
		// Constructors
		static BeforeRenderHelper() {} // 0x000000018095F590-0x000000018095F5F0
	
		// Methods
		private static int GetUpdateOrder(UnityAction callback) => default; // 0x000000018095EA90-0x000000018095EBB0
		public static void RegisterCallback(UnityAction callback) {} // 0x000000018095ED70-0x000000018095F1C0
		public static void UnregisterCallback(UnityAction callback) {} // 0x000000018095F1C0-0x000000018095F590
		public static void Invoke() {} // 0x000000018095EBB0-0x000000018095ED70
	}
}
