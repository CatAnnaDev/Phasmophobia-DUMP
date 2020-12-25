/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public abstract class MulticastDelegate : Delegate // TypeDefIndex: 368
	{
		// Fields
		private Delegate[] delegates; // 0x68
	
		// Constructors
		protected MulticastDelegate() {} // Dummy constructor
	
		// Methods
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000180683920-0x0000000180683940
		public sealed override bool Equals(object obj) => default; // 0x0000000180683650-0x00000001806837D0
		public sealed override int GetHashCode() => default; // 0x00000001806837D0-0x00000001806837E0
		protected override MethodInfo GetMethodImpl() => default; // 0x00000001806838D0-0x0000000180683920
		public sealed override Delegate[] GetInvocationList() => default; // 0x00000001806837E0-0x00000001806838D0
		protected sealed override Delegate CombineImpl(Delegate follow) => default; // 0x0000000180683290-0x0000000180683650
		private int LastIndexOf(Delegate[] haystack, Delegate[] needle) => default; // 0x0000000180683940-0x0000000180683AB0
		protected sealed override Delegate RemoveImpl(Delegate value) => default; // 0x0000000180683AB0-0x0000000180683DE0
	}
}
