/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	public abstract class IPhotonSocket // TypeDefIndex: 4257
	{
		// Fields
		protected internal PeerBase peerBase; // 0x10
		protected readonly ConnectionProtocol Protocol; // 0x18
		public bool PollReceive; // 0x19
		public string ConnectAddress; // 0x20
	
		// Properties
		protected IPhotonPeerListener Listener { get; } // 0x00000001806BA2C0-0x00000001806BA2F0 
		protected internal int MTU { get; } // 0x00000001806BA2F0-0x00000001806BA320 
		public PhotonSocketState State { get; protected set; } // 0x000000018027A6E0-0x000000018027A6F0 0x00000001802D6530-0x00000001802D6540
		public bool Connected { get; } // 0x00000001806BA2B0-0x00000001806BA2C0 
		public string ServerAddress { get; protected set; } // 0x00000001802470A0-0x00000001802470B0 0x0000000180249810-0x0000000180249820
		public string ProxyServerAddress { get; protected set; } // 0x00000001802470B0-0x00000001802470C0 0x0000000180249070-0x0000000180249080
		public static string ServerIpAddress { get; protected set; } // 0x00000001806BA410-0x00000001806BA450 0x00000001806BA450-0x00000001806BA4F0
		public int ServerPort { get; protected set; } // 0x00000001802932B0-0x00000001802932C0 0x00000001802D5D10-0x00000001802D5D20
		public bool AddressResolvedAsIpv6 { get; protected internal set; } // 0x0000000180293290-0x00000001802932A0 0x0000000180474BD0-0x0000000180474BE0
		public string UrlProtocol { get; protected set; } // 0x0000000180249A10-0x0000000180249A20 0x0000000180249920-0x0000000180249930
		public string UrlPath { get; protected set; } // 0x00000001803F7AF0-0x00000001803F7B00 0x0000000180249C10-0x0000000180249C20
		protected internal string SerializationProtocol { get; } // 0x00000001806BA320-0x00000001806BA410 
	
		// Constructors
		protected IPhotonSocket() {} // Dummy constructor
		public IPhotonSocket(PeerBase peerBase) {} // 0x00000001806BA1F0-0x00000001806BA2B0
	
		// Methods
		public virtual bool Connect() => default; // 0x00000001806B90F0-0x00000001806B95B0
		public abstract bool Disconnect();
		public abstract PhotonSocketError Send(byte[] data, int length);
		public abstract PhotonSocketError Receive(out byte[] data);
		public void HandleReceivedDatagram(byte[] inBuffer, int length, bool willBeReused) {} // 0x00000001806B9DB0-0x00000001806B9F20
		public bool ReportDebugOfLevel(DebugLevel levelOfMessage) => default; // 0x00000001806B9F90-0x00000001806B9FC0
		public void EnqueueDebugReturn(DebugLevel debugLevel, string message) {} // 0x00000001806B95B0-0x00000001806B95D0
		protected internal void HandleException(StatusCode statusCode) {} // 0x00000001806B9D00-0x00000001806B9DB0
		protected internal bool TryParseAddress(string url, out string address, out ushort port, out string urlProtocol, out string urlPath) {
			address = default;
			port = default;
			urlProtocol = default;
			urlPath = default;
			return default;
		} // 0x00000001806B9FC0-0x00000001806BA1F0
		protected internal bool IsIpv6SimpleCheck(IPAddress address) => default; // 0x00000001806B9F20-0x00000001806B9F90
		protected internal IPAddress[] GetIpAddresses(string hostname) => default; // 0x00000001806B9760-0x00000001806B9D00
		private int AddressSortComparer(IPAddress x, IPAddress y) => default; // 0x00000001806B90B0-0x00000001806B90F0
		[Obsolete] // 0x00000001800ED680-0x00000001800ED6B0
		protected internal static IPAddress GetIpAddress(string address) => default; // 0x00000001806B95D0-0x00000001806B9760
	}
}
