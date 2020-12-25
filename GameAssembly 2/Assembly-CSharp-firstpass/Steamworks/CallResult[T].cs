/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public sealed class CallResult<T> : IDisposable // TypeDefIndex: 6082
	{
		// Fields
		private CCallbackBaseVTable m_CallbackBaseVTable;
		private IntPtr m_pVTable;
		private CCallbackBase m_CCallbackBase;
		private GCHandle m_pCCallbackBase;
		private SteamAPICall_t m_hAPICall;
		private readonly int m_size;
		private bool m_bDisposed;
	
		// Properties
		public SteamAPICall_t Handle { get => default; }
	
		// Events
		private event APIDispatchDelegate m_Func;
	
		// Nested types
		public delegate void APIDispatchDelegate(T param, bool bIOFailure); // TypeDefIndex: 6083; 0x00000000-0x00000000
	
		// Constructors
		public CallResult() {} // Dummy constructor
		public CallResult(APIDispatchDelegate func = null) {}
	
		// Methods
		public static CallResult<T> Create(APIDispatchDelegate func = null) => default;
		~CallResult() {}
		public void Dispose() {}
		public void Set(SteamAPICall_t hAPICall, APIDispatchDelegate func = null) {}
		public bool IsActive() => default;
		public void Cancel() {}
		public void SetGameserverFlag() {}
		private void OnRunCallback(IntPtr thisptr, IntPtr pvParam) {}
		private void OnRunCallResult(IntPtr thisptr, IntPtr pvParam, bool bFailed, ulong hSteamAPICall_) {}
		private int OnGetCallbackSizeBytes(IntPtr thisptr) => default;
		private void BuildCCallbackBase() {}
	}
}
