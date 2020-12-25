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
	internal class IOSelectorJob : IThreadPoolWorkItem // TypeDefIndex: 2313
	{
		// Fields
		private IOOperation operation; // 0x10
		private IOAsyncCallback callback; // 0x18
		private IOAsyncResult state; // 0x20
	
		// Constructors
		public IOSelectorJob() {} // Dummy constructor
		public IOSelectorJob(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) {} // 0x000000018075BD60-0x000000018075BDC0
	
		// Methods
		void IThreadPoolWorkItem.ExecuteWorkItem() {} // 0x000000018075BD30-0x000000018075BD60
		void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void MarkDisposed() {} // 0x000000018075BD00-0x000000018075BD30
	}
}
