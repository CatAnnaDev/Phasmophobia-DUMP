/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	internal sealed class LocalDataStore // TypeDefIndex: 137
	{
		// Fields
		private LocalDataStoreElement[] m_DataTable; // 0x10
		private LocalDataStoreMgr m_Manager; // 0x18
	
		// Constructors
		public LocalDataStore() {} // Dummy constructor
		public LocalDataStore(LocalDataStoreMgr mgr, int InitialCapacity) {} // 0x0000000180631B90-0x0000000180631C10
	
		// Methods
		internal void Dispose() {} // 0x0000000180631620-0x0000000180631650
		public object GetData(LocalDataStoreSlot slot) => default; // 0x00000001806316C0-0x00000001806317B0
		public void SetData(LocalDataStoreSlot slot, object data) {} // 0x0000000180631A80-0x0000000180631B90
		internal void FreeData(int slot, long cookie) {} // 0x0000000180631650-0x00000001806316C0
		private LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot) => default; // 0x00000001806317B0-0x0000000180631A80
	}
}
