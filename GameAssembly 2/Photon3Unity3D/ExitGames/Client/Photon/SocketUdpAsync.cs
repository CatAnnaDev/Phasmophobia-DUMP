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
	public class SocketUdpAsync : IPhotonSocket, IDisposable // TypeDefIndex: 4303
	{
		// Fields
		private Socket sock; // 0x50
		private readonly object syncer; // 0x58
	
		// Constructors
		public SocketUdpAsync() {} // Dummy constructor
		[Preserve] // 0x00000001800D4E50-0x00000001800D4E60
		public SocketUdpAsync(PeerBase npeer) {} // 0x0000000180A15DF0-0x0000000180A15EB0
	
		// Methods
		~SocketUdpAsync() {} // 0x0000000180A14790-0x0000000180A14820
		public void Dispose() {} // 0x0000000180A14150-0x0000000180A14240
		public override bool Connect() => default; // 0x0000000180A13E00-0x0000000180A13F80
		public override bool Disconnect() => default; // 0x0000000180A13F80-0x0000000180A14150
		public override PhotonSocketError Send(byte[] data, int length) => default; // 0x0000000180A15690-0x0000000180A15AE0
		public override PhotonSocketError Receive(out byte[] data) {
			data = default;
			return default;
		} // 0x0000000180A0FA00-0x0000000180A0FA20
		internal void DnsAndConnect() {} // 0x0000000180A14240-0x0000000180A14790
		public void StartReceive() {} // 0x0000000180A15AE0-0x0000000180A15DF0
		private void OnReceive(IAsyncResult ar) {} // 0x0000000180A14820-0x0000000180A15690
	}
}
