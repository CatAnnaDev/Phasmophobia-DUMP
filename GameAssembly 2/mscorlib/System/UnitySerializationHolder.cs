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
	internal class UnitySerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 323
	{
		// Fields
		private Type[] m_instantiation; // 0x10
		private int[] m_elementTypes; // 0x18
		private int m_genericParameterPosition; // 0x20
		private Type m_declaringType; // 0x28
		private MethodBase m_declaringMethod; // 0x30
		private string m_data; // 0x38
		private string m_assemblyName; // 0x40
		private int m_unityType; // 0x48
	
		// Constructors
		public UnitySerializationHolder() {} // Dummy constructor
		internal UnitySerializationHolder(SerializationInfo info, StreamingContext context) {} // 0x0000000180A75800-0x0000000180A75A90
	
		// Methods
		internal static void GetUnitySerializationInfo(SerializationInfo info, Missing missing) {} // 0x0000000180A75430-0x0000000180A754C0
		internal static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type) => default; // 0x0000000180A747E0-0x0000000180A749D0
		internal Type MakeElementTypes(Type type) => default; // 0x0000000180A75600-0x0000000180A75760
		internal static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type) {} // 0x0000000180A75060-0x0000000180A75430
		internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly) {} // 0x0000000180A754C0-0x0000000180A75600
		private void ThrowInsufficientInformation(string field) {} // 0x0000000180A75760-0x0000000180A75800
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000180A749D0-0x0000000180A74A40
		public virtual object GetRealObject(StreamingContext context) => default; // 0x0000000180A74A40-0x0000000180A75060
	}
}
