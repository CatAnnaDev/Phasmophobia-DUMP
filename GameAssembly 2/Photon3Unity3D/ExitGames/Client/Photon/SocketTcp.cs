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
	public class SocketTcp : IPhotonSocket, IDisposable // TypeDefIndex: 4299
	{
		// Fields
		private Socket sock; // 0x50
		private readonly object syncer; // 0x58
	
		// Constructors
		public SocketTcp() {} // Dummy constructor
		[Preserve] // 0x00000001800D4E50-0x00000001800D4E60
		public SocketTcp(PeerBase npeer) {} // 0x0000000180A13D40-0x0000000180A13E00
	
		// Methods
		~SocketTcp() {} // 0x0000000180A12E20-0x0000000180A12EB0
		public void Dispose() {} // 0x0000000180A12660-0x0000000180A12750
		public override bool Connect() => default; // 0x0000000180A12310-0x0000000180A12490
		public override bool Disconnect() => default; // 0x0000000180A12490-0x0000000180A12660
		public override PhotonSocketError Send(byte[] data, int length) => default; // 0x0000000180A13910-0x0000000180A13D40
		public override PhotonSocketError Receive(out byte[] data) {
			data = default;
			return default;
		} // 0x0000000180A0FA00-0x0000000180A0FA20
		internal void DnsAndConnect() {} // 0x0000000180A12750-0x0000000180A12E20
		public void ReceiveLoop() {} // 0x0000000180A12EB0-0x0000000180A13910
	}
}
