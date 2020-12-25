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
	public class WeakReference : ISerializable // TypeDefIndex: 412
	{
		// Fields
		private bool isLongReference; // 0x10
		private GCHandle gcHandle; // 0x14
	
		// Properties
		public virtual bool IsAlive { get => default; } // 0x0000000180A78110-0x0000000180A78130 
		public virtual object Target { get => default; set {} } // 0x0000000180A78130-0x0000000180A78160 0x0000000180A78160-0x0000000180A78170
		public virtual bool TrackResurrection { get => default; } // 0x00000001803628F0-0x0000000180362930 
	
		// Constructors
		protected WeakReference() {} // 0x00000001802466A0-0x00000001802466B0
		public WeakReference(object target) {} // 0x0000000180A77F80-0x0000000180A77FC0
		public WeakReference(object target, bool trackResurrection) {} // 0x0000000180A77FC0-0x0000000180A78010
		protected WeakReference(SerializationInfo info, StreamingContext context) {} // 0x0000000180A78010-0x0000000180A78110
	
		// Methods
		private void AllocateHandle(object target) {} // 0x0000000180A77DB0-0x0000000180A77DE0
		~WeakReference() {} // 0x0000000180A77DE0-0x0000000180A77E80
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000180A77E80-0x0000000180A77F80
	}
}
