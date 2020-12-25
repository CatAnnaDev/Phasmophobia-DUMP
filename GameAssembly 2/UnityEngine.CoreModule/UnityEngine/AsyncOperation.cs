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
	// [NativeHeader] // 0x00000001800F4C90-0x00000001800F4D00
	// [NativeHeader] // 0x00000001800F4C90-0x00000001800F4D00
	[RequiredByNativeCode] // 0x00000001800F4C90-0x00000001800F4D00
	public class AsyncOperation : YieldInstruction // TypeDefIndex: 3247
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
		private Action<AsyncOperation> m_completeCallback; // 0x18
	
		// Properties
		public bool isDone { [NativeMethod] /* 0x00000001800F4FE0-0x00000001800F5010 */ get => default; } // 0x000000018095E0F0-0x000000018095E130 
		public float progress { [NativeMethod] /* 0x00000001800F5040-0x00000001800F5070 */ get => default; } // 0x000000018095E130-0x000000018095E170 
		public bool allowSceneActivation { [NativeMethod] /* 0x00000001800F5150-0x00000001800F5180 */ set {} } // 0x000000018095E1F0-0x000000018095E240
	
		// Events
		public event Action<AsyncOperation> completed;
	
		// Constructors
		public AsyncOperation() {} // 0x0000000180289A80-0x0000000180289A90
	
		// Methods
		[NativeMethod] // 0x00000001800F4EB0-0x00000001800F4F10
		// [StaticAccessor] // 0x00000001800F4EB0-0x00000001800F4F10
		private static void InternalDestroy(IntPtr ptr) {} // 0x000000018095DF80-0x000000018095DFC0
		~AsyncOperation() {} // 0x000000018095DEC0-0x000000018095DF80
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal void InvokeCompletionEvent() {} // 0x000000018095DFC0-0x000000018095E020
	}
}
