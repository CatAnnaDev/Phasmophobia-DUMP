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
	public sealed class WeakReference<T> : ISerializable // TypeDefIndex: 413
		where T : class
	{
		// Fields
		private GCHandle handle;
		private bool trackResurrection;
	
		// Constructors
		public WeakReference() {} // Dummy constructor
		public WeakReference(T target) {}
		public WeakReference(T target, bool trackResurrection) {}
		private WeakReference(SerializationInfo info, StreamingContext context) {}
	
		// Methods
		public void GetObjectData(SerializationInfo info, StreamingContext context) {}
		public bool TryGetTarget(out T target) {
			target = default;
			return default;
		}
		~WeakReference() {}
	}
}
