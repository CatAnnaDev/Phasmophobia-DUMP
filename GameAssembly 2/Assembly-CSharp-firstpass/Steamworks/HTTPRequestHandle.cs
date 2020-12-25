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
	public struct HTTPRequestHandle : IEquatable<Steamworks.HTTPRequestHandle>, IComparable<Steamworks.HTTPRequestHandle> // TypeDefIndex: 6519
	{
		// Fields
		public static readonly HTTPRequestHandle Invalid; // 0x00
		public uint m_HTTPRequestHandle; // 0x00
	
		// Constructors
		public HTTPRequestHandle(uint value) {
			m_HTTPRequestHandle = default;
		} // 0x00000001800163C0-0x00000001800163D0
		static HTTPRequestHandle() {
			Invalid = default;
		} // 0x00000001807CDB90-0x00000001807CDBD0
	
		// Methods
		public override string ToString() => default; // 0x00000001800262C0-0x0000000180026340
		public override bool Equals(object other) => default; // 0x000000018002FB20-0x000000018002FD70
		public override int GetHashCode() => default; // 0x000000018000DD00-0x000000018000DD10
		public static bool operator ==(HTTPRequestHandle x, HTTPRequestHandle y) => default; // 0x00000001803DE020-0x00000001803DE090
		public static bool operator !=(HTTPRequestHandle x, HTTPRequestHandle y) => default; // 0x00000001807CDBD0-0x00000001807CDC30
		public static explicit operator HTTPRequestHandle(uint value) => default; // 0x0000000180322710-0x00000001803232A0
		public static explicit operator uint(HTTPRequestHandle that) => default; // 0x0000000180322710-0x00000001803232A0
		public bool Equals(HTTPRequestHandle other) => default; // 0x0000000180016320-0x0000000180016330
		public int CompareTo(HTTPRequestHandle other) => default; // 0x000000018002CB20-0x000000018002CB30
	}
}
