/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	public class SocketTcpAsync : IPhotonSocket, IDisposable // TypeDefIndex: 4300
	{
		// Fields
		private Socket sock; // 0x50
		private readonly object syncer; // 0x58
	
		// Nested types
		private class ReceiveContext // TypeDefIndex: 4301
		{
			// Fields
			public Socket workSocket; // 0x10
			public int ReceivedHeaderBytes; // 0x18
			public byte[] HeaderBuffer; // 0x20
			public int ExpectedMessageBytes; // 0x28
			public int ReceivedMessageBytes; // 0x2C
			public byte[] MessageBuffer; // 0x30
	
			// Properties
			public bool ReadingHeader { get => default; } // 0x0000000180A0DC70-0x0000000180A0DC80 
			public bool ReadingMessage { get => default; } // 0x0000000180A0DC80-0x0000000180A0DC90 
			public byte[] CurrentBuffer { get => default; } // 0x0000000180A0DC30-0x0000000180A0DC50 
			public int CurrentOffset { get => default; } // 0x0000000180A0DC60-0x0000000180A0DC70 
			public int CurrentExpected { get => default; } // 0x0000000180A0DC50-0x0000000180A0DC60 
	
			// Constructors
			public ReceiveContext() {} // Dummy constructor
			public ReceiveContext(Socket socket, byte[] headerBuffer, byte[] messageBuffer) {} // 0x0000000180A0DBC0-0x0000000180A0DC30
	
			// Methods
			public void Reset() {} // 0x0000000180A0DBB0-0x0000000180A0DBC0
		}
	
		// Constructors
		public SocketTcpAsync() {} // Dummy constructor
		[Preserve] // 0x00000001800D4E50-0x00000001800D4E60
		public SocketTcpAsync(PeerBase npeer) {} // 0x0000000180A12250-0x0000000180A12310
	
		// Methods
		~SocketTcpAsync() {} // 0x0000000180A11030-0x0000000180A110C0
		public void Dispose() {} // 0x0000000180A108D0-0x0000000180A109C0
		public override bool Connect() => default; // 0x0000000180A10580-0x0000000180A10700
		public override bool Disconnect() => default; // 0x0000000180A10700-0x0000000180A108D0
		public override PhotonSocketError Send(byte[] data, int length) => default; // 0x0000000180A11E20-0x0000000180A12250
		public override PhotonSocketError Receive(out byte[] data) {
			data = default;
			return default;
		} // 0x0000000180A0FA00-0x0000000180A0FA20
		internal void DnsAndConnect() {} // 0x0000000180A109C0-0x0000000180A11030
		private void ReceiveAsync(ReceiveContext context = null) {} // 0x0000000180A11A70-0x0000000180A11E20
		private void ReceiveAsync(IAsyncResult ar) {} // 0x0000000180A110C0-0x0000000180A11A70
	}
}
