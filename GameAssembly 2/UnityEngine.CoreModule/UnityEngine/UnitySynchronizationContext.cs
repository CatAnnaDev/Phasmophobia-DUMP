/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	internal sealed class UnitySynchronizationContext : SynchronizationContext // TypeDefIndex: 3292
	{
		// Fields
		private readonly List<WorkRequest> m_AsyncWorkQueue; // 0x18
		private readonly List<WorkRequest> m_CurrentFrameWork; // 0x20
		private readonly int m_MainThreadID; // 0x28
		private int m_TrackedCount; // 0x2C
	
		// Nested types
		private struct WorkRequest // TypeDefIndex: 3293
		{
			// Fields
			private readonly SendOrPostCallback m_DelagateCallback; // 0x00
			private readonly object m_DelagateState; // 0x08
			private readonly ManualResetEvent m_WaitHandle; // 0x10
	
			// Constructors
			public WorkRequest(SendOrPostCallback callback, object state, ManualResetEvent waitHandle = null) {
				m_DelagateCallback = default;
				m_DelagateState = default;
				m_WaitHandle = default;
			} // 0x0000000180029F10-0x000000018002A4D0
	
			// Methods
			public void Invoke() {} // 0x0000000180036800-0x0000000180036A90
		}
	
		// Constructors
		public UnitySynchronizationContext() {} // Dummy constructor
		private UnitySynchronizationContext(int mainThreadID) {} // 0x00000001808E7130-0x00000001808E71F0
		private UnitySynchronizationContext(List<WorkRequest> queue, int mainThreadID) {} // 0x00000001808E7080-0x00000001808E7130
	
		// Methods
		public override void Send(SendOrPostCallback callback, object state) {} // 0x00000001808E6DC0-0x00000001808E7080
		public override void OperationStarted() {} // 0x00000001808E6C70-0x00000001808E6C80
		public override void OperationCompleted() {} // 0x00000001808E6C60-0x00000001808E6C70
		public override void Post(SendOrPostCallback callback, object state) {} // 0x00000001808E6C80-0x00000001808E6DC0
		public override SynchronizationContext CreateCopy() => default; // 0x00000001808E66D0-0x00000001808E67A0
		private void Exec() {} // 0x00000001808E67A0-0x00000001808E6960
		private bool HasPendingTasks() => default; // 0x00000001808E6AF0-0x00000001808E6B50
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static void InitializeSynchronizationContext() {} // 0x00000001808E6B50-0x00000001808E6C60
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static void ExecuteTasks() {} // 0x00000001808E6AA0-0x00000001808E6AF0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static bool ExecutePendingTasks(long millisecondsTimeout) => default; // 0x00000001808E6960-0x00000001808E6AA0
	}
}
