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
	internal class DelegateSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 348
	{
		// Fields
		private Delegate _delegate; // 0x10
	
		// Nested types
		[Serializable]
		private class DelegateEntry // TypeDefIndex: 349
		{
			// Fields
			private string type; // 0x10
			private string assembly; // 0x18
			private object target; // 0x20
			private string targetTypeAssembly; // 0x28
			private string targetTypeName; // 0x30
			private string methodName; // 0x38
			public DelegateEntry delegateEntry; // 0x40
	
			// Constructors
			public DelegateEntry() {} // Dummy constructor
			public DelegateEntry(Delegate del, string targetLabel) {} // 0x0000000180290220-0x0000000180290410
	
			// Methods
			public Delegate DeserializeDelegate(SerializationInfo info, int index) => default; // 0x000000018028FE80-0x0000000180290220
		}
	
		// Constructors
		public DelegateSerializationHolder() {} // Dummy constructor
		private DelegateSerializationHolder(SerializationInfo info, StreamingContext ctx) {} // 0x0000000180290680-0x00000001802908E0
	
		// Methods
		public static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx) {} // 0x0000000180290410-0x0000000180290630
		public void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000180290630-0x0000000180290680
		public object GetRealObject(StreamingContext context) => default; // 0x0000000180248E10-0x0000000180248E20
	}
}
