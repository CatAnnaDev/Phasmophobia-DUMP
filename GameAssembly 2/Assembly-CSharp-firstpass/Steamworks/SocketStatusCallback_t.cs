/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	// [CallbackIdentity] // 0x0000000180121700-0x0000000180121720
	public struct SocketStatusCallback_t // TypeDefIndex: 6250
	{
		// Fields
		public const int k_iCallback = 1201; // Metadata: 0x00650D53
		public SNetSocket_t m_hSocket; // 0x00
		public SNetListenSocket_t m_hListenSocket; // 0x04
		public CSteamID m_steamIDRemote; // 0x08
		public int m_eSNetSocketState; // 0x10
	}
}
