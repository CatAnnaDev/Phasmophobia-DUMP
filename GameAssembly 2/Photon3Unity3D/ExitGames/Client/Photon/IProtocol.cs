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
	public abstract class IProtocol // TypeDefIndex: 4261
	{
		// Fields
		public readonly ByteArraySlicePool ByteArraySlicePool; // 0x10
	
		// Properties
		public abstract string ProtocolType { get; }
		public abstract byte[] VersionBytes { get; }
	
		// Nested types
		public enum DeserializationFlags // TypeDefIndex: 4262
		{
			None = 0,
			AllowPooledByteArray = 1
		}
	
		// Constructors
		protected IProtocol() {} // 0x00000001806BA6A0-0x00000001806BA820
	
		// Methods
		public abstract void Serialize(StreamBuffer dout, object serObject, bool setType);
		public abstract void SerializeShort(StreamBuffer dout, short serObject, bool setType);
		public abstract void SerializeString(StreamBuffer dout, string serObject, bool setType);
		public abstract void SerializeEventData(StreamBuffer stream, EventData serObject, bool setType);
		public abstract void SerializeOperationRequest(StreamBuffer stream, byte operationCode, Dictionary<byte, object> parameters, bool setType);
		public abstract void SerializeOperationResponse(StreamBuffer stream, OperationResponse serObject, bool setType);
		public abstract object Deserialize(StreamBuffer din, byte type);
		public abstract short DeserializeShort(StreamBuffer din);
		public abstract byte DeserializeByte(StreamBuffer din);
		public abstract EventData DeserializeEventData(StreamBuffer din, EventData target = null, DeserializationFlags flags = DeserializationFlags.None /* Metadata: 0x0064D5FA */);
		public abstract OperationRequest DeserializeOperationRequest(StreamBuffer din);
		public abstract OperationResponse DeserializeOperationResponse(StreamBuffer stream);
		public byte[] Serialize(object obj) => default; // 0x00000001806BA600-0x00000001806BA6A0
		public object Deserialize(StreamBuffer stream) => default; // 0x00000001806BA4F0-0x00000001806BA540
		public object Deserialize(byte[] serializedData) => default; // 0x00000001806BA540-0x00000001806BA5D0
		public object DeserializeMessage(StreamBuffer stream) => default; // 0x00000001806BA4F0-0x00000001806BA540
		internal void SerializeMessage(StreamBuffer ms, object msg) {} // 0x00000001806BA5D0-0x00000001806BA600
	}
}
