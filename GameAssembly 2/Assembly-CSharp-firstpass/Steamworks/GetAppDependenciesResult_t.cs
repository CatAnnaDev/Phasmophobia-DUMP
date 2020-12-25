/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	// [CallbackIdentity] // 0x0000000180124FF0-0x0000000180125010
	public struct GetAppDependenciesResult_t // TypeDefIndex: 6302
	{
		// Fields
		public const int k_iCallback = 3416; // Metadata: 0x00650E23
		public EResult m_eResult; // 0x00
		public PublishedFileId_t m_nPublishedFileId; // 0x08
		public AppId_t[] m_rgAppIDs; // 0x10
		public uint m_nNumAppDependencies; // 0x18
		public uint m_nTotalNumAppDependencies; // 0x1C
	}
}
