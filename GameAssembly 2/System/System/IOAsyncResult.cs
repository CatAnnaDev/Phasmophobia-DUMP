/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

// Image 4: System.dll - Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 2170-2964

namespace System
{
	internal abstract class IOAsyncResult : IAsyncResult // TypeDefIndex: 2312
	{
		// Fields
		private AsyncCallback async_callback; // 0x10
		private object async_state; // 0x18
		private ManualResetEvent wait_handle; // 0x20
		private bool completed_synchronously; // 0x28
		private bool completed; // 0x29
	
		// Properties
		public AsyncCallback AsyncCallback { get; } // 0x0000000180248E10-0x0000000180248E20 
		public object AsyncState { get; } // 0x0000000180246BC0-0x0000000180246BD0 
		public WaitHandle AsyncWaitHandle { get; } // 0x000000018075BAA0-0x000000018075BBD0 
		public bool CompletedSynchronously { get; protected set; } // 0x0000000180297A00-0x0000000180297A10 0x00000001804554D0-0x00000001804554E0
		public bool IsCompleted { get; protected set; } // 0x00000001804918D0-0x00000001804918E0 0x000000018075BBD0-0x000000018075BC90
	
		// Constructors
		protected IOAsyncResult() {} // Dummy constructor
		protected IOAsyncResult(AsyncCallback async_callback, object async_state) {} // 0x0000000180294750-0x00000001802947A0
	
		// Methods
		internal abstract void CompleteDisposed();
	}
}
