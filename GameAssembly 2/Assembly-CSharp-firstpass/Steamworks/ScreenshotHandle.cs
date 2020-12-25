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
	public struct ScreenshotHandle : IEquatable<Steamworks.ScreenshotHandle>, IComparable<Steamworks.ScreenshotHandle> // TypeDefIndex: 6551
	{
		// Fields
		public static readonly ScreenshotHandle Invalid; // 0x00
		public uint m_ScreenshotHandle; // 0x00
	
		// Constructors
		public ScreenshotHandle(uint value) {
			m_ScreenshotHandle = default;
		} // 0x00000001800163C0-0x00000001800163D0
		static ScreenshotHandle() {
			Invalid = default;
		} // 0x0000000180948C60-0x0000000180948CA0
	
		// Methods
		public override string ToString() => default; // 0x00000001800262C0-0x0000000180026340
		public override bool Equals(object other) => default; // 0x00000001800417D0-0x0000000180041880
		public override int GetHashCode() => default; // 0x000000018000DD00-0x000000018000DD10
		public static bool operator ==(ScreenshotHandle x, ScreenshotHandle y) => default; // 0x00000001803DE020-0x00000001803DE090
		public static bool operator !=(ScreenshotHandle x, ScreenshotHandle y) => default; // 0x0000000180948CA0-0x0000000180948D00
		public static explicit operator ScreenshotHandle(uint value) => default; // 0x0000000180322710-0x00000001803232A0
		public static explicit operator uint(ScreenshotHandle that) => default; // 0x0000000180322710-0x00000001803232A0
		public bool Equals(ScreenshotHandle other) => default; // 0x0000000180016320-0x0000000180016330
		public int CompareTo(ScreenshotHandle other) => default; // 0x000000018002CB20-0x000000018002CB30
	}
}
