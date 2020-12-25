/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	// [CallbackIdentity] // 0x0000000180124060-0x0000000180124080
	public struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t // TypeDefIndex: 6280
	{
		// Fields
		public const int k_iCallback = 1328; // Metadata: 0x00650DCB
		public EResult m_eResult; // 0x00
		public EWorkshopFileAction m_eAction; // 0x04
		public int m_nResultsReturned; // 0x08
		public int m_nTotalResultCount; // 0x0C
		public PublishedFileId_t[] m_rgPublishedFileId; // 0x10
		public uint[] m_rgRTimeUpdated; // 0x18
	}
}
