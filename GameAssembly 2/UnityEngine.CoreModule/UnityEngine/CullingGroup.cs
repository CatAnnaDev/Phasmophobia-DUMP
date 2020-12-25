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
	// [NativeHeader] // 0x000000018012E850-0x000000018012E880
	public class CullingGroup // TypeDefIndex: 3116
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
		private StateChanged m_OnStateChanged; // 0x18
	
		// Nested types
		public delegate void StateChanged(CullingGroupEvent sphere); // TypeDefIndex: 3117; 0x0000000180972350-0x0000000180972630
	
		// Constructors
		public CullingGroup() {} // Dummy constructor
	
		// Methods
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) {} // 0x0000000180966810-0x0000000180966880
	}
}
