/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	[Serializable]
	public struct AppId_t : IEquatable<Steamworks.AppId_t>, IComparable<Steamworks.AppId_t> // TypeDefIndex: 6553
	{
		// Fields
		public static readonly AppId_t Invalid; // 0x00
		public uint m_AppId; // 0x00
	
		// Constructors
		public AppId_t(uint value) {
			m_AppId = default;
		} // 0x00000001800163C0-0x00000001800163D0
		static AppId_t() {
			Invalid = default;
		} // 0x00000001807CA9C0-0x00000001807CAA00
	
		// Methods
		public override string ToString() => default; // 0x00000001800262C0-0x0000000180026340
		public override bool Equals(object other) => default; // 0x000000018002D110-0x000000018002D310
		public override int GetHashCode() => default; // 0x000000018000DD00-0x000000018000DD10
		public static bool operator ==(AppId_t x, AppId_t y) => default; // 0x00000001803DE020-0x00000001803DE090
		public static bool operator !=(AppId_t x, AppId_t y) => default; // 0x00000001807CAA00-0x00000001807CAAD0
		public static explicit operator AppId_t(uint value) => default; // 0x0000000180322710-0x00000001803232A0
		public static explicit operator uint(AppId_t that) => default; // 0x0000000180322710-0x00000001803232A0
		public bool Equals(AppId_t other) => default; // 0x0000000180016320-0x0000000180016330
		public int CompareTo(AppId_t other) => default; // 0x000000018002CB20-0x000000018002CB30
	}
}
