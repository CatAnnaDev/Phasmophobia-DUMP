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
	public class SocketUdp : IPhotonSocket, IDisposable // TypeDefIndex: 4302
	{
		// Fields
		private Socket sock; // 0x50
		private readonly object syncer; // 0x58
	
		// Constructors
		public SocketUdp() {} // Dummy constructor
		[Preserve] // 0x00000001800D4E50-0x00000001800D4E60
		public SocketUdp(PeerBase npeer) {} // 0x0000000180A175F0-0x0000000180A176D0
	
		// Methods
		~SocketUdp() {} // 0x0000000180A168A0-0x0000000180A16930
		public void Dispose() {} // 0x0000000180A16200-0x0000000180A162F0
		public override bool Connect() => default; // 0x0000000180A15EB0-0x0000000180A16030
		public override bool Disconnect() => default; // 0x0000000180A16030-0x0000000180A16200
		public override PhotonSocketError Send(byte[] data, int length) => default; // 0x0000000180A171A0-0x0000000180A175F0
		public override PhotonSocketError Receive(out byte[] data) {
			data = default;
			return default;
		} // 0x0000000180A0FA00-0x0000000180A0FA20
		internal void DnsAndConnect() {} // 0x0000000180A162F0-0x0000000180A168A0
		public void ReceiveLoop() {} // 0x0000000180A16930-0x0000000180A171A0
	}
}
