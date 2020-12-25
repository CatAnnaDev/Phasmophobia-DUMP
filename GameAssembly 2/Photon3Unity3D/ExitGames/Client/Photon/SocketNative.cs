/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	public class SocketNative : IPhotonSocket // TypeDefIndex: 4295
	{
		// Fields
		private const string LibName = "PhotonSocketPlugin"; // Metadata: 0x0064D6DC
		private IntPtr pConnectionHandler; // 0x50
		private GCHandle handle; // 0x58
		internal readonly object syncer; // 0x60
		private string serializationProtocolType; // 0x68
		private byte[] serializationProtocolBytes; // 0x70
		private string appId; // 0x78
		private NativeDebugLevel debugLevel; // 0x80
	
		// Nested types
		public delegate void LogCallbackDelegate(IntPtr pUserData, int level, string msg); // TypeDefIndex: 4296; 0x00000001806BA930-0x00000001806BAC90
	
		private enum NativeSocketState : byte // TypeDefIndex: 4297
		{
			Disconnected = 0,
			Connecting = 1,
			Connected = 2,
			ConnectionError = 3,
			SendError = 4,
			ReceiveError = 5,
			Disconnecting = 6
		}
	
		private enum NativeDebugLevel : byte // TypeDefIndex: 4298
		{
			OFF = 0,
			ERRORS = 1,
			WARNINGS = 2,
			INFO = 3,
			ALL = 4
		}
	
		// Constructors
		public SocketNative() {} // Dummy constructor
		[Preserve] // 0x00000001800D4E50-0x00000001800D4E60
		public SocketNative(PeerBase npeer) {} // 0x0000000180A0FCD0-0x0000000180A0FE90
	
		// Methods
		public static extern IntPtr egconnect(string address); // 0x0000000180A10050-0x0000000180A100F0
		public static extern IntPtr egconnectWithProtocol(string address, byte connectionProtocol); // 0x0000000180A0FE90-0x0000000180A0FF40
		public static extern IntPtr egconnectWithProtocols(string address, byte connectionProtocol, string appID, string serializationProtocolString, byte serializationProtocolMajor, byte serializationProtocolMinor); // 0x0000000180A0FF40-0x0000000180A10050
		public static extern byte eggetState(IntPtr pConnectionHandler); // 0x0000000180A10170-0x0000000180A101F0
		public static extern void egdisconnect(IntPtr pConnectionHandler); // 0x0000000180A100F0-0x0000000180A10170
		public static extern uint egservice(IntPtr pConnectionHandler); // 0x0000000180A103D0-0x0000000180A10450
		public static extern bool egsend(IntPtr pConnectionHandler, byte[] arr, uint size); // 0x0000000180A10320-0x0000000180A103D0
		public static extern uint egread(IntPtr pConnectionHandler, byte[] arr, ref uint size); // 0x0000000180A10270-0x0000000180A10320
		public static extern void egsetSocketLoggingCallback(IntPtr pConnectionHandler, IntPtr userData, LogCallbackDelegate callback); // 0x0000000180A10450-0x0000000180A104F0
		public static extern bool egsetSocketLoggingLevel(IntPtr pConnectionHandler, int level); // 0x0000000180A104F0-0x0000000180A10580
		public static extern bool eggetUsingIPv6(IntPtr pConnectionHandler); // 0x0000000180A101F0-0x0000000180A10270
		~SocketNative() {} // 0x0000000180A0F050-0x0000000180A0F0E0
		public void Dispose() {} // 0x0000000180A0E7D0-0x0000000180A0E8F0
		public override bool Connect() => default; // 0x0000000180A0E420-0x0000000180A0E520
		// [MonoPInvokeCallback] // 0x00000001800F1ED0-0x00000001800F1F20
		private static void DebugReturn(IntPtr pUserData, int debugLevel, string str) {} // 0x0000000180A0E520-0x0000000180A0E630
		internal void DnsAndConnect() {} // 0x0000000180A0E8F0-0x0000000180A0F050
		public override bool Disconnect() => default; // 0x0000000180A0E630-0x0000000180A0E7D0
		public override PhotonSocketError Send(byte[] data, int length) => default; // 0x0000000180A0FA20-0x0000000180A0FCD0
		public override PhotonSocketError Receive(out byte[] data) {
			data = default;
			return default;
		} // 0x0000000180A0FA00-0x0000000180A0FA20
		public void ReceiveLoop() {} // 0x0000000180A0F0E0-0x0000000180A0FA00
	}
}
