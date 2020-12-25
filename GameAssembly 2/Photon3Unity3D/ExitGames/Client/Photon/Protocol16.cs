/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	public class Protocol16 : IProtocol // TypeDefIndex: 4288
	{
		// Fields
		private readonly byte[] versionBytes; // 0x18
		private readonly byte[] memShort; // 0x20
		private readonly long[] memLongBlock; // 0x28
		private readonly byte[] memLongBlockBytes; // 0x30
		private static readonly float[] memFloatBlock; // 0x00
		private static readonly byte[] memFloatBlockBytes; // 0x08
		private readonly double[] memDoubleBlock; // 0x38
		private readonly byte[] memDoubleBlockBytes; // 0x40
		private readonly byte[] memInteger; // 0x48
		private readonly byte[] memLong; // 0x50
		private readonly byte[] memFloat; // 0x58
		private readonly byte[] memDouble; // 0x60
		private byte[] memString; // 0x68
	
		// Properties
		public override string ProtocolType { get => default; } // 0x0000000180A05010-0x0000000180A05040 
		public override byte[] VersionBytes { get => default; } // 0x00000001809302F0-0x0000000180930300 
	
		// Nested types
		public enum GpType : byte // TypeDefIndex: 4289
		{
			Unknown = 0,
			Null = 42,
			Dictionary = 68,
			StringArray = 97,
			Byte = 98,
			Custom = 99,
			Double = 100,
			EventData = 101,
			Float = 102,
			Hashtable = 104,
			Integer = 105,
			Short = 107,
			Long = 108,
			IntegerArray = 110,
			Boolean = 111,
			OperationResponse = 112,
			OperationRequest = 113,
			String = 115,
			ByteArray = 120,
			Array = 121,
			ObjectArray = 122
		}
	
		// Constructors
		public Protocol16() {} // 0x0000000180A04E50-0x0000000180A05010
		static Protocol16() {} // 0x0000000180A04DD0-0x0000000180A04E50
	
		// Methods
		private bool SerializeCustom(StreamBuffer dout, object serObject) => default; // 0x0000000180A02190-0x0000000180A02590
		private object DeserializeCustom(StreamBuffer din, byte customTypeCode) => default; // 0x00000001809FEDF0-0x00000001809FEFD0
		private Type GetTypeOfCode(byte typeCode) => default; // 0x0000000180A01710-0x0000000180A01960
		private GpType GetCodeOfType(Type type) => default; // 0x0000000180A013D0-0x0000000180A01710
		private Array CreateArrayByType(byte arrayType, short length) => default; // 0x00000001809FE810-0x00000001809FE840
		private void SerializeOperationRequest(StreamBuffer stream, OperationRequest serObject, bool setType) {} // 0x0000000180A03F30-0x0000000180A03F70
		public override void SerializeOperationRequest(StreamBuffer stream, byte operationCode, Dictionary<byte, object> parameters, bool setType) {} // 0x0000000180A03EB0-0x0000000180A03F30
		public override OperationRequest DeserializeOperationRequest(StreamBuffer din) => default; // 0x0000000180A003E0-0x0000000180A00490
		public override void SerializeOperationResponse(StreamBuffer stream, OperationResponse serObject, bool setType) {} // 0x0000000180A03F70-0x0000000180A04050
		public override OperationResponse DeserializeOperationResponse(StreamBuffer stream) => default; // 0x0000000180A00490-0x0000000180A005B0
		public override void SerializeEventData(StreamBuffer stream, EventData serObject, bool setType) {} // 0x0000000180A02F90-0x0000000180A03000
		public override EventData DeserializeEventData(StreamBuffer din, EventData target = null, DeserializationFlags flags = DeserializationFlags.None /* Metadata: 0x0064D674 */) => default; // 0x00000001809FFA00-0x00000001809FFAC0
		private void SerializeParameterTable(StreamBuffer stream, Dictionary<byte, object> parameters) {} // 0x0000000180A04050-0x0000000180A04270
		private Dictionary<byte, object> DeserializeParameterTable(StreamBuffer stream, Dictionary<byte, object> target = null) => default; // 0x0000000180A005B0-0x0000000180A006B0
		public override void Serialize(StreamBuffer dout, object serObject, bool setType) {} // 0x0000000180A04630-0x0000000180A04DD0
		private void SerializeByte(StreamBuffer dout, byte serObject, bool setType) {} // 0x0000000180A02140-0x0000000180A02190
		private void SerializeBoolean(StreamBuffer dout, bool serObject, bool setType) {} // 0x0000000180A01FC0-0x0000000180A02010
		public override void SerializeShort(StreamBuffer dout, short serObject, bool setType) {} // 0x0000000180A04270-0x0000000180A043D0
		private void SerializeInteger(StreamBuffer dout, int serObject, bool setType) {} // 0x0000000180A03810-0x0000000180A039B0
		private void SerializeLong(StreamBuffer dout, long serObject, bool setType) {} // 0x0000000180A039B0-0x0000000180A03CC0
		private void SerializeFloat(StreamBuffer dout, float serObject, bool setType) {} // 0x0000000180A03000-0x0000000180A033E0
		private void SerializeDouble(StreamBuffer dout, double serObject, bool setType) {} // 0x0000000180A02C70-0x0000000180A02F90
		public override void SerializeString(StreamBuffer stream, string value, bool setType) {} // 0x0000000180A044B0-0x0000000180A04630
		private void SerializeArray(StreamBuffer dout, Array serObject, bool setType) {} // 0x0000000180A01960-0x0000000180A01FC0
		private void SerializeByteArray(StreamBuffer dout, byte[] serObject, bool setType) {} // 0x0000000180A020B0-0x0000000180A02140
		private void SerializeByteArraySegment(StreamBuffer dout, byte[] serObject, int offset, int count, bool setType) {} // 0x0000000180A02010-0x0000000180A020B0
		private void SerializeIntArrayOptimized(StreamBuffer inWriter, int[] serObject, bool setType) {} // 0x0000000180A035F0-0x0000000180A03810
		private void SerializeStringArray(StreamBuffer dout, string[] serObject, bool setType) {} // 0x0000000180A043D0-0x0000000180A044B0
		private void SerializeObjectArray(StreamBuffer dout, IList objects, bool setType) {} // 0x0000000180A03CC0-0x0000000180A03EB0
		private void SerializeHashTable(StreamBuffer dout, Hashtable serObject, bool setType) {} // 0x0000000180A033E0-0x0000000180A035F0
		private void SerializeDictionary(StreamBuffer dout, IDictionary serObject, bool setType) {} // 0x0000000180A02BD0-0x0000000180A02C70
		private void SerializeDictionaryHeader(StreamBuffer writer, Type dictType) {} // 0x0000000180A02860-0x0000000180A02890
		private void SerializeDictionaryHeader(StreamBuffer writer, object dict, out bool setKeyType, out bool setValueType) {
			setKeyType = default;
			setValueType = default;
		} // 0x0000000180A02890-0x0000000180A02BD0
		private void SerializeDictionaryElements(StreamBuffer writer, object dict, bool setKeyType, bool setValueType) {} // 0x0000000180A02590-0x0000000180A02860
		public override object Deserialize(StreamBuffer din, byte type) => default; // 0x0000000180A00A00-0x0000000180A013D0
		public override byte DeserializeByte(StreamBuffer din) => default; // 0x00000001809FEDD0-0x00000001809FEDF0
		private bool DeserializeBoolean(StreamBuffer din) => default; // 0x00000001809FED00-0x00000001809FED30
		public override short DeserializeShort(StreamBuffer din) => default; // 0x0000000180A006B0-0x0000000180A007E0
		private int DeserializeInteger(StreamBuffer din) => default; // 0x00000001809FFEB0-0x0000000180A00020
		private long DeserializeLong(StreamBuffer din) => default; // 0x0000000180A00020-0x0000000180A002B0
		private float DeserializeFloat(StreamBuffer din) => default; // 0x00000001809FFAC0-0x00000001809FFCD0
		private double DeserializeDouble(StreamBuffer din) => default; // 0x00000001809FF730-0x00000001809FFA00
		private string DeserializeString(StreamBuffer din) => default; // 0x0000000180A008F0-0x0000000180A00A00
		private Array DeserializeArray(StreamBuffer din) => default; // 0x00000001809FE840-0x00000001809FED00
		private byte[] DeserializeByteArray(StreamBuffer din, int size = -1 /* Metadata: 0x0064D678 */) => default; // 0x00000001809FED30-0x00000001809FEDD0
		private int[] DeserializeIntArray(StreamBuffer din, int size = -1 /* Metadata: 0x0064D67C */) => default; // 0x00000001809FFDE0-0x00000001809FFEB0
		private string[] DeserializeStringArray(StreamBuffer din) => default; // 0x0000000180A007E0-0x0000000180A008F0
		private object[] DeserializeObjectArray(StreamBuffer din) => default; // 0x0000000180A002B0-0x0000000180A003E0
		private Hashtable DeserializeHashTable(StreamBuffer din) => default; // 0x00000001809FFCD0-0x00000001809FFDE0
		private IDictionary DeserializeDictionary(StreamBuffer din) => default; // 0x00000001809FF430-0x00000001809FF730
		private bool DeserializeDictionaryArray(StreamBuffer din, short size, out Array arrayResult) {
			arrayResult = default;
			return default;
		} // 0x00000001809FEFD0-0x00000001809FF210
		private Type DeserializeDictionaryType(StreamBuffer reader, out byte keyTypeCode, out byte valTypeCode) {
			keyTypeCode = default;
			valTypeCode = default;
			return default;
		} // 0x00000001809FF210-0x00000001809FF430
	}
}
