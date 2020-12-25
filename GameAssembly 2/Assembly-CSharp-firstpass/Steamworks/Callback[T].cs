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
	public sealed class Callback<T> : IDisposable // TypeDefIndex: 6080
	{
		// Fields
		private CCallbackBaseVTable m_CallbackBaseVTable;
		private IntPtr m_pVTable;
		private CCallbackBase m_CCallbackBase;
		private GCHandle m_pCCallbackBase;
		private bool m_bGameServer;
		private readonly int m_size;
		private bool m_bDisposed;
	
		// Events
		private event DispatchDelegate m_Func;
	
		// Nested types
		public delegate void DispatchDelegate(T param); // TypeDefIndex: 6081; 0x00000000-0x00000000
	
		// Constructors
		public Callback() {} // Dummy constructor
		public Callback(DispatchDelegate func, bool bGameServer = false /* Metadata: 0x00650B29 */) {}
	
		// Methods
		public static Callback<T> Create(DispatchDelegate func) => default;
		public static Callback<T> CreateGameServer(DispatchDelegate func) => default;
		~Callback() {}
		public void Dispose() {}
		public void Register(DispatchDelegate func) {}
		public void Unregister() {}
		public void SetGameserverFlag() {}
		private void OnRunCallback(IntPtr thisptr, IntPtr pvParam) {}
		private void OnRunCallResult(IntPtr thisptr, IntPtr pvParam, bool bFailed, ulong hSteamAPICall) {}
		private int OnGetCallbackSizeBytes(IntPtr thisptr) => default;
		private void BuildCCallbackBase() {}
	}
}
