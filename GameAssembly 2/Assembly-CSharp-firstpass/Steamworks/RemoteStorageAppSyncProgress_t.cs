/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	// [CallbackIdentity] // 0x0000000180122E60-0x0000000180122E80
	public struct RemoteStorageAppSyncProgress_t // TypeDefIndex: 6259
	{
		// Fields
		public const int k_iCallback = 1303; // Metadata: 0x00650D77
		public string m_rgchCurrentFile; // 0x00
		public AppId_t m_nAppID; // 0x08
		public uint m_uBytesTransferredThisChunk; // 0x0C
		public double m_dAppPercentComplete; // 0x10
		public bool m_bUploading; // 0x18
	}
}
