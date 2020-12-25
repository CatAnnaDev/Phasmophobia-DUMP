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
	public class Protocol18 : IProtocol // TypeDefIndex: 4291
	{
		// Fields
		private readonly byte[] versionBytes; // 0x18
		private static readonly byte[] boolMasks; // 0x00
		private readonly double[] memDoubleBlock; // 0x20
		private readonly float[] memFloatBlock; // 0x28
		private readonly byte[] memCustomTypeBodyLengthSerialized; // 0x30
		private readonly byte[] memCompressedUInt32; // 0x38
		private byte[] memCompressedUInt64; // 0x40
	
		// Properties
		public override string ProtocolType { get => default; } // 0x0000000180A0DB80-0x0000000180A0DBB0 
		public override byte[] VersionBytes { get => default; } // 0x00000001809302F0-0x0000000180930300 
	
		// Nested types
		public enum GpType : byte // TypeDefIndex: 4292
		{
			Unknown = 0,
			Boolean = 2,
			Byte = 3,
			Short = 4,
			Float = 5,
			Double = 6,
			String = 7,
			Null = 8,
			CompressedInt = 9,
			CompressedLong = 10,
			Int1 = 11,
			Int1_ = 12,
			Int2 = 13,
			Int2_ = 14,
			L1 = 15,
			L1_ = 16,
			L2 = 17,
			L2_ = 18,
			Custom = 19,
			Dictionary = 20,
			Hashtable = 21,
			ObjectArray = 23,
			OperationRequest = 24,
			OperationResponse = 25,
			EventData = 26,
			BooleanFalse = 27,
			BooleanTrue = 28,
			ShortZero = 29,
			IntZero = 30,
			LongZero = 31,
			FloatZero = 32,
			DoubleZero = 33,
			ByteZero = 34,
			Array = 64,
			BooleanArray = 66,
			ByteArray = 67,
			ShortArray = 68,
			FloatArray = 69,
			DoubleArray = 70,
			StringArray = 71,
			CompressedIntArray = 73,
			CompressedLongArray = 74,
			CustomTypeArray = 83,
			DictionaryArray = 84,
			HashtableArray = 85,
			CustomTypeSlim = 128
		}
	
		// Constructors
		public Protocol18() {} // 0x0000000180A0DA40-0x0000000180A0DB80
		static Protocol18() {} // 0x0000000180A0D9D0-0x0000000180A0DA40
	
		// Methods
		public override void Serialize(StreamBuffer dout, object serObject, bool setType) {} // 0x0000000180A09660-0x0000000180A09670
		public override void SerializeShort(StreamBuffer dout, short serObject, bool setType) {} // 0x0000000180A095E0-0x0000000180A09650
		public override void SerializeString(StreamBuffer dout, string serObject, bool setType) {} // 0x0000000180A09650-0x0000000180A09660
		public override object Deserialize(StreamBuffer din, byte type) => default; // 0x0000000180A05460-0x0000000180A05470
		public override short DeserializeShort(StreamBuffer din) => default; // 0x0000000180A05450-0x0000000180A05460
		public override byte DeserializeByte(StreamBuffer din) => default; // 0x00000001809FEDD0-0x00000001809FEDF0
		private static Type GetAllowedDictionaryKeyTypes(GpType gpType) => default; // 0x0000000180A054A0-0x0000000180A05600
		private static Type GetClrArrayType(GpType gpType) => default; // 0x0000000180A05600-0x0000000180A05800
		private GpType GetCodeOfType(Type type) => default; // 0x0000000180A05870-0x0000000180A05F20
		private GpType GetCodeOfTypeCode(TypeCode type) => default; // 0x0000000180A05800-0x0000000180A05870
		private object Read(StreamBuffer stream) => default; // 0x0000000180A08660-0x0000000180A086B0
		private object Read(StreamBuffer stream, byte gpType) => default; // 0x0000000180A086B0-0x0000000180A09410
		internal bool ReadBoolean(StreamBuffer stream) => default; // 0x00000001809FED00-0x00000001809FED30
		internal byte ReadByte(StreamBuffer stream) => default; // 0x00000001809FEDD0-0x00000001809FEDF0
		internal short ReadInt16(StreamBuffer stream) => default; // 0x0000000180A07BE0-0x0000000180A07C70
		internal ushort ReadUShort(StreamBuffer stream) => default; // 0x0000000180A07BE0-0x0000000180A07C70
		internal int ReadInt32(StreamBuffer stream) => default; // 0x0000000180A07CE0-0x0000000180A07DE0
		internal long ReadInt64(StreamBuffer stream) => default; // 0x0000000180A07DE0-0x0000000180A07FF0
		internal float ReadSingle(StreamBuffer stream) => default; // 0x0000000180A08410-0x0000000180A084A0
		internal double ReadDouble(StreamBuffer stream) => default; // 0x0000000180A07810-0x0000000180A078A0
		internal ByteArraySlice ReadNonAllocByteArray(StreamBuffer stream) => default; // 0x0000000180A080B0-0x0000000180A08130
		internal byte[] ReadByteArray(StreamBuffer stream) => default; // 0x0000000180A064C0-0x0000000180A06550
		public object ReadCustomType(StreamBuffer stream, byte gpType = 0 /* Metadata: 0x0064D695 */) => default; // 0x0000000180A06C60-0x0000000180A06E30
		public override EventData DeserializeEventData(StreamBuffer din, EventData target = null, DeserializationFlags flags = DeserializationFlags.None /* Metadata: 0x0064D696 */) => default; // 0x0000000180A05070-0x0000000180A05150
		private Dictionary<byte, object> ReadParameterTable(StreamBuffer stream, Dictionary<byte, object> target = null, DeserializationFlags flags = DeserializationFlags.None /* Metadata: 0x0064D69A */) => default; // 0x0000000180A08250-0x0000000180A08360
		public Hashtable ReadHashtable(StreamBuffer stream) => default; // 0x0000000180A079B0-0x0000000180A07AB0
		public int[] ReadIntArray(StreamBuffer stream) => default; // 0x0000000180A07FF0-0x0000000180A080B0
		public override OperationRequest DeserializeOperationRequest(StreamBuffer din) => default; // 0x0000000180A05150-0x0000000180A052B0
		public override OperationResponse DeserializeOperationResponse(StreamBuffer stream) => default; // 0x0000000180A052B0-0x0000000180A05450
		internal string ReadString(StreamBuffer stream) => default; // 0x0000000180A085A0-0x0000000180A08660
		private object ReadCustomTypeArray(StreamBuffer stream) => default; // 0x0000000180A06A20-0x0000000180A06C60
		private Type ReadDictionaryType(StreamBuffer stream, out GpType keyReadType, out GpType valueReadType) {
			keyReadType = default;
			valueReadType = default;
			return default;
		} // 0x0000000180A073D0-0x0000000180A07680
		private Type ReadDictionaryType(StreamBuffer stream) => default; // 0x0000000180A07150-0x0000000180A073D0
		private Type GetDictArrayType(StreamBuffer stream) => default; // 0x0000000180A05F20-0x0000000180A06010
		private IDictionary ReadDictionary(StreamBuffer stream) => default; // 0x0000000180A07680-0x0000000180A07760
		private bool ReadDictionaryElements(StreamBuffer stream, GpType keyReadType, GpType valueReadType, IDictionary dictionary) => default; // 0x0000000180A07050-0x0000000180A07150
		private object[] ReadObjectArray(StreamBuffer stream) => default; // 0x0000000180A08130-0x0000000180A08250
		private bool[] ReadBooleanArray(StreamBuffer stream) => default; // 0x0000000180A061D0-0x0000000180A064C0
		internal short[] ReadInt16Array(StreamBuffer stream) => default; // 0x0000000180A07AB0-0x0000000180A07BE0
		private float[] ReadSingleArray(StreamBuffer stream) => default; // 0x0000000180A08360-0x0000000180A08410
		private double[] ReadDoubleArray(StreamBuffer stream) => default; // 0x0000000180A07760-0x0000000180A07810
		internal string[] ReadStringArray(StreamBuffer stream) => default; // 0x0000000180A084A0-0x0000000180A085A0
		private Hashtable[] ReadHashtableArray(StreamBuffer stream) => default; // 0x0000000180A078A0-0x0000000180A079B0
		private IDictionary[] ReadDictionaryArray(StreamBuffer stream) => default; // 0x0000000180A06E30-0x0000000180A07050
		private Array ReadArrayInArray(StreamBuffer stream) => default; // 0x0000000180A06010-0x0000000180A061D0
		internal int ReadInt1(StreamBuffer stream, bool signNegative) => default; // 0x0000000180A07C70-0x0000000180A07CB0
		internal int ReadInt2(StreamBuffer stream, bool signNegative) => default; // 0x0000000180A07CB0-0x0000000180A07CE0
		internal int ReadCompressedInt32(StreamBuffer stream) => default; // 0x0000000180A06610-0x0000000180A06630
		private uint ReadCompressedUInt32(StreamBuffer stream) => default; // 0x0000000180A06810-0x0000000180A06910
		internal long ReadCompressedInt64(StreamBuffer stream) => default; // 0x0000000180A066F0-0x0000000180A06810
		private ulong ReadCompressedUInt64(StreamBuffer stream) => default; // 0x0000000180A06910-0x0000000180A06A20
		internal int[] ReadCompressedInt32Array(StreamBuffer stream) => default; // 0x0000000180A06550-0x0000000180A06610
		internal long[] ReadCompressedInt64Array(StreamBuffer stream) => default; // 0x0000000180A06630-0x0000000180A066F0
		private int DecodeZigZag32(uint value) => default; // 0x0000000180A05040-0x0000000180A05050
		private long DecodeZigZag64(ulong value) => default; // 0x0000000180A05050-0x0000000180A05070
		internal void Write(StreamBuffer stream, object value, bool writeType) {} // 0x0000000180A0CAD0-0x0000000180A0CB50
		private void Write(StreamBuffer stream, object value, GpType gpType, bool writeType) {} // 0x0000000180A0CB50-0x0000000180A0D9D0
		public override void SerializeEventData(StreamBuffer stream, EventData serObject, bool setType) {} // 0x0000000180A09410-0x0000000180A09480
		private void WriteParameterTable(StreamBuffer stream, Dictionary<byte, object> parameters) {} // 0x0000000180A0C370-0x0000000180A0C5A0
		private void SerializeOperationRequest(StreamBuffer stream, OperationRequest serObject, bool setType) {} // 0x0000000180A03F30-0x0000000180A03F70
		public override void SerializeOperationRequest(StreamBuffer stream, byte operationCode, Dictionary<byte, object> parameters, bool setType) {} // 0x0000000180A09480-0x0000000180A09500
		public override void SerializeOperationResponse(StreamBuffer stream, OperationResponse serObject, bool setType) {} // 0x0000000180A09500-0x0000000180A095E0
		internal void WriteByte(StreamBuffer stream, byte value, bool writeType) {} // 0x0000000180A0A0E0-0x0000000180A0A150
		internal void WriteBoolean(StreamBuffer stream, bool value, bool writeType) {} // 0x0000000180A09F70-0x0000000180A09FC0
		internal void WriteUShort(StreamBuffer stream, ushort value) {} // 0x0000000180A0CA90-0x0000000180A0CAC0
		internal void WriteInt16(StreamBuffer stream, short value, bool writeType) {} // 0x0000000180A095E0-0x0000000180A09650
		internal void WriteDouble(StreamBuffer stream, double value, bool writeType) {} // 0x0000000180A0BA10-0x0000000180A0BB70
		internal void WriteSingle(StreamBuffer stream, float value, bool writeType) {} // 0x0000000180A0C640-0x0000000180A0C7A0
		internal void WriteString(StreamBuffer stream, string value, bool writeType) {} // 0x0000000180A0C920-0x0000000180A0CA90
		private void WriteHashtable(StreamBuffer stream, object value, bool writeType) {} // 0x0000000180A0BC90-0x0000000180A0BEE0
		internal void WriteByteArray(StreamBuffer stream, byte[] value, bool writeType) {} // 0x0000000180A0A060-0x0000000180A0A0E0
		private void WriteArraySegmentByte(StreamBuffer stream, ArraySegment<byte> seg, bool writeType) {} // 0x0000000180A09850-0x0000000180A09900
		private void WriteByteArraySlice(StreamBuffer stream, ByteArraySlice buffer, bool writeType) {} // 0x0000000180A09FC0-0x0000000180A0A060
		internal void WriteInt32ArrayCompressed(StreamBuffer stream, int[] value, bool writeType) {} // 0x0000000180A0BF90-0x0000000180A0C040
		private void WriteInt64ArrayCompressed(StreamBuffer stream, long[] values, bool setType) {} // 0x0000000180A0C040-0x0000000180A0C0F0
		internal void WriteBoolArray(StreamBuffer stream, bool[] value, bool writeType) {} // 0x0000000180A09C40-0x0000000180A09F70
		internal void WriteInt16Array(StreamBuffer stream, short[] value, bool writeType) {} // 0x0000000180A0BEE0-0x0000000180A0BF90
		internal void WriteSingleArray(StreamBuffer stream, float[] values, bool setType) {} // 0x0000000180A0C5A0-0x0000000180A0C640
		internal void WriteDoubleArray(StreamBuffer stream, double[] values, bool setType) {} // 0x0000000180A0B970-0x0000000180A0BA10
		internal void WriteStringArray(StreamBuffer stream, object value0, bool writeType) {} // 0x0000000180A0C7A0-0x0000000180A0C920
		private void WriteObjectArray(StreamBuffer stream, object array, bool writeType) {} // 0x0000000180A0C2C0-0x0000000180A0C370
		private void WriteObjectArray(StreamBuffer stream, IList array, bool writeType) {} // 0x0000000180A0C100-0x0000000180A0C2C0
		private void WriteArrayInArray(StreamBuffer stream, object value, bool writeType) {} // 0x0000000180A09750-0x0000000180A09850
		private void WriteCustomTypeBody(CustomType customType, StreamBuffer stream, object value) {} // 0x0000000180A0AAB0-0x0000000180A0ACB0
		private void WriteCustomType(StreamBuffer stream, object value, bool writeType) {} // 0x0000000180A0ACB0-0x0000000180A0AE50
		private void WriteCustomTypeArray(StreamBuffer stream, object value, bool writeType) {} // 0x0000000180A0A750-0x0000000180A0AAB0
		private bool WriteArrayHeader(StreamBuffer stream, Type type) => default; // 0x0000000180A09670-0x0000000180A09750
		private void WriteDictionaryElements(StreamBuffer stream, IDictionary dictionary, GpType keyWriteType, GpType valueWriteType) {} // 0x0000000180A0AF80-0x0000000180A0B1D0
		private void WriteDictionary(StreamBuffer stream, object dict, bool setType) {} // 0x0000000180A0B870-0x0000000180A0B970
		private void WriteDictionaryHeader(StreamBuffer stream, Type type, out GpType keyWriteType, out GpType valueWriteType) {
			keyWriteType = default;
			valueWriteType = default;
		} // 0x0000000180A0B1D0-0x0000000180A0B870
		private bool WriteArrayType(StreamBuffer stream, Type type, out GpType writeType) {
			writeType = default;
			return default;
		} // 0x0000000180A09900-0x0000000180A09C40
		private void WriteHashtableArray(StreamBuffer stream, object value, bool writeType) {} // 0x0000000180A0BB70-0x0000000180A0BC90
		private void WriteDictionaryArray(StreamBuffer stream, IDictionary[] dictArray, bool writeType) {} // 0x0000000180A0AE50-0x0000000180A0AF80
		private void WriteIntLength(StreamBuffer stream, int value) {} // 0x0000000180A0C0F0-0x0000000180A0C100
		private void WriteVarInt32(StreamBuffer stream, int value, bool writeType) {} // 0x0000000180A0CAC0-0x0000000180A0CAD0
		private void WriteCompressedInt32(StreamBuffer stream, int value, bool writeType) {} // 0x0000000180A0A150-0x0000000180A0A2C0
		private void WriteCompressedInt64(StreamBuffer stream, long value, bool writeType) {} // 0x0000000180A0A2C0-0x0000000180A0A430
		private void WriteCompressedUInt32(StreamBuffer stream, uint value) {} // 0x0000000180A0A430-0x0000000180A0A520
		private int WriteCompressedUInt32(byte[] buffer, uint value) => default; // 0x0000000180A0A520-0x0000000180A0A5C0
		private void WriteCompressedUInt64(StreamBuffer stream, ulong value) {} // 0x0000000180A0A5C0-0x0000000180A0A750
		private uint EncodeZigZag32(int value) => default; // 0x0000000180A05470-0x0000000180A05480
		private ulong EncodeZigZag64(long value) => default; // 0x0000000180A05480-0x0000000180A054A0
	}
}
