/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	// [CallbackIdentity] // 0x0000000180123870-0x0000000180123890
	public struct RemoteStorageGetPublishedFileDetailsResult_t // TypeDefIndex: 6270
	{
		// Fields
		public const int k_iCallback = 1318; // Metadata: 0x00650DA3
		public EResult m_eResult; // 0x00
		public PublishedFileId_t m_nPublishedFileId; // 0x08
		public AppId_t m_nCreatorAppID; // 0x10
		public AppId_t m_nConsumerAppID; // 0x14
		public string m_rgchTitle; // 0x18
		public string m_rgchDescription; // 0x20
		public UGCHandle_t m_hFile; // 0x28
		public UGCHandle_t m_hPreviewFile; // 0x30
		public ulong m_ulSteamIDOwner; // 0x38
		public uint m_rtimeCreated; // 0x40
		public uint m_rtimeUpdated; // 0x44
		public ERemoteStoragePublishedFileVisibility m_eVisibility; // 0x48
		public bool m_bBanned; // 0x4C
		public string m_rgchTags; // 0x50
		public bool m_bTagsTruncated; // 0x58
		public string m_pchFileName; // 0x60
		public int m_nFileSize; // 0x68
		public int m_nPreviewFileSize; // 0x6C
		public string m_rgchURL; // 0x70
		public EWorkshopFileType m_eFileType; // 0x78
		public bool m_bAcceptedForUse; // 0x7C
	}
}
