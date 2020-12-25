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
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public sealed class LocalDataStoreSlot // TypeDefIndex: 138
	{
		// Fields
		private LocalDataStoreMgr m_mgr; // 0x10
		private int m_slot; // 0x18
		private long m_cookie; // 0x20
	
		// Properties
		internal LocalDataStoreMgr Manager { get => default; } // 0x0000000180248E10-0x0000000180248E20 
		internal int Slot { get => default; } // 0x000000018027A800-0x000000018027A810 
		internal long Cookie { get => default; } // 0x0000000180246FE0-0x0000000180246FF0 
	
		// Constructors
		public LocalDataStoreSlot() {} // Dummy constructor
		internal LocalDataStoreSlot(LocalDataStoreMgr mgr, int slot, long cookie) {} // 0x000000018067F050-0x000000018067F090
	
		// Methods
		~LocalDataStoreSlot() {} // 0x000000018067EFB0-0x000000018067F050
	}
}
