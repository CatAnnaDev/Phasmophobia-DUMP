/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	public class Protocol // TypeDefIndex: 4287
	{
		// Fields
		internal static readonly Dictionary<Type, CustomType> TypeDict; // 0x00
		internal static readonly Dictionary<byte, CustomType> CodeDict; // 0x08
		private static IProtocol ProtocolDefault; // 0x10
		private static readonly float[] memFloatBlock; // 0x18
		private static readonly byte[] memDeserialize; // 0x20
	
		// Constructors
		public Protocol() {} // 0x00000001802466A0-0x00000001802466B0
		static Protocol() {} // 0x00000001806C6830-0x00000001806C6930
	
		// Methods
		public static bool TryRegisterType(Type type, byte typeCode, SerializeMethod serializeFunction, DeserializeMethod deserializeFunction) => default; // 0x00000001806C6660-0x00000001806C6830
		public static bool TryRegisterType(Type type, byte typeCode, SerializeStreamMethod serializeFunction, DeserializeStreamMethod deserializeFunction) => default; // 0x00000001806C6490-0x00000001806C6660
		[Obsolete] // 0x00000001800F1C40-0x00000001800F1C50
		public static byte[] Serialize(object obj) => default; // 0x00000001806C5F50-0x00000001806C6120
		[Obsolete] // 0x00000001800F1C40-0x00000001800F1C50
		public static object Deserialize(byte[] serializedData) => default; // 0x00000001806C58D0-0x00000001806C5B10
		public static void Serialize(short value, byte[] target, ref int targetOffset) {} // 0x00000001806C6420-0x00000001806C6490
		public static void Serialize(int value, byte[] target, ref int targetOffset) {} // 0x00000001806C5E90-0x00000001806C5F50
		public static void Serialize(float value, byte[] target, ref int targetOffset) {} // 0x00000001806C6120-0x00000001806C6420
		public static void Deserialize(out int value, byte[] source, ref int offset) {
			value = default;
		} // 0x00000001806C57E0-0x00000001806C58D0
		public static void Deserialize(out short value, byte[] source, ref int offset) {
			value = default;
		} // 0x00000001806C5E10-0x00000001806C5E90
		public static void Deserialize(out float value, byte[] source, ref int offset) {
			value = default;
		} // 0x00000001806C5B10-0x00000001806C5E10
	}
}
