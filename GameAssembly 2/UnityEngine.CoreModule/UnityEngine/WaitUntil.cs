/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	public sealed class WaitUntil : CustomYieldInstruction // TypeDefIndex: 3298
	{
		// Fields
		private Func<bool> m_Predicate; // 0x10
	
		// Properties
		public override bool keepWaiting { get => default; } // 0x0000000180AC9880-0x0000000180AC98D0 
	
		// Constructors
		public WaitUntil() {} // Dummy constructor
		public WaitUntil(Func<bool> predicate) {} // 0x0000000180288B20-0x00000001802896B0
	}
}
