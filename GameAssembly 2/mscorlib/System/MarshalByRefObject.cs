/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public abstract class MarshalByRefObject // TypeDefIndex: 362
	{
		// Fields
		[NonSerialized]
		private object _identity; // 0x10
	
		// Properties
		internal ServerIdentity ObjectIdentity { get; set; } // 0x000000018067F380-0x000000018067F3D0 0x000000018067F3D0-0x000000018067F420
	
		// Constructors
		protected MarshalByRefObject() {} // 0x0000000180246DB0-0x0000000180246DC0
	
		// Methods
		public virtual ObjRef CreateObjRef(Type requestedType) => default; // 0x000000018067F2E0-0x000000018067F330
		public virtual object InitializeLifetimeService() => default; // 0x000000018067F330-0x000000018067F380
	}
}
