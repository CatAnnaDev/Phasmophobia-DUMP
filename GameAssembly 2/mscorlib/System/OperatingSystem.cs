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
	public sealed class OperatingSystem : ICloneable, ISerializable // TypeDefIndex: 375
	{
		// Fields
		private PlatformID _platform; // 0x10
		private Version _version; // 0x18
		private string _servicePack; // 0x20
	
		// Properties
		public PlatformID Platform { get => default; } // 0x0000000180245EA0-0x0000000180246600 
		public Version Version { get => default; } // 0x0000000180246BC0-0x0000000180246BD0 
		public string ServicePack { get => default; } // 0x0000000180246FE0-0x0000000180246FF0 
	
		// Constructors
		public OperatingSystem() {} // Dummy constructor
		public OperatingSystem(PlatformID platform, Version version) {} // 0x000000018068DF10-0x000000018068E050
		private OperatingSystem(SerializationInfo information, StreamingContext context) {} // 0x000000018068E050-0x000000018068E1C0
	
		// Methods
		public object Clone() => default; // 0x000000018068DBB0-0x000000018068DD20
		public void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x000000018068DD20-0x000000018068DDC0
		public override string ToString() => default; // 0x000000018068DDC0-0x000000018068DF10
	}
}
