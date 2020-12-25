/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 45: PhotonRealtime.dll - Assembly: PhotonRealtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4334-4405

namespace Photon.Realtime
{
	public abstract class PhotonPing : IDisposable // TypeDefIndex: 4386
	{
		// Fields
		public string DebugString; // 0x10
		public bool Successful; // 0x18
		protected internal bool GotResult; // 0x19
		protected internal int PingLength; // 0x1C
		protected internal byte[] PingBytes; // 0x20
		protected internal byte PingId; // 0x28
		private static readonly Random RandomIdProvider; // 0x00
	
		// Constructors
		protected PhotonPing() {} // 0x0000000180745200-0x0000000180745290
		static PhotonPing() {} // 0x00000001807451A0-0x0000000180745200
	
		// Methods
		public virtual bool StartPing(string ip) => default; // 0x0000000180745150-0x00000001807451A0
		public virtual bool Done() => default; // 0x0000000180745070-0x00000001807450C0
		public virtual void Dispose() {} // 0x0000000180745020-0x0000000180745070
		protected internal void Init() {} // 0x00000001807450C0-0x0000000180745150
	}
}
