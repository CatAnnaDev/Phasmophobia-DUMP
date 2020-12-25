/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	internal sealed class LocalDataStoreMgr // TypeDefIndex: 139
	{
		// Fields
		private const int InitialSlotTableSize = 64; // Metadata: 0x0062F900
		private const int SlotTableDoubleThreshold = 512; // Metadata: 0x0062F904
		private const int LargeSlotTableSizeIncrease = 128; // Metadata: 0x0062F908
		private bool[] m_SlotInfoTable; // 0x10
		private int m_FirstAvailableSlot; // 0x18
		private List<LocalDataStore> m_ManagedLocalDataStores; // 0x20
		private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap; // 0x28
		private long m_CookieGenerator; // 0x30
	
		// Constructors
		public LocalDataStoreMgr() {} // 0x0000000180631560-0x0000000180631620
	
		// Methods
		public LocalDataStoreHolder CreateLocalDataStore() => default; // 0x0000000180630DE0-0x0000000180630F90
		public void DeleteLocalDataStore(LocalDataStore store) {} // 0x0000000180630F90-0x0000000180631090
		public LocalDataStoreSlot AllocateDataSlot() => default; // 0x0000000180630A70-0x0000000180630CC0
		public LocalDataStoreSlot AllocateNamedDataSlot(string name) => default; // 0x0000000180630CC0-0x0000000180630DE0
		public LocalDataStoreSlot GetNamedDataSlot(string name) => default; // 0x00000001806313B0-0x00000001806314E0
		public void FreeNamedDataSlot(string name) {} // 0x00000001806312B0-0x00000001806313B0
		internal void FreeDataSlot(int slot, long cookie) {} // 0x0000000180631090-0x00000001806312B0
		public void ValidateSlot(LocalDataStoreSlot slot) {} // 0x00000001806314E0-0x0000000180631560
		internal int GetSlotTableLength() => default; // 0x000000018054E710-0x000000018054E730
	}
}
