/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

// Image 55: PhotonChat.dll - Assembly: PhotonChat, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5583-5604

namespace Photon.Chat
{
	public class ChatPeer : PhotonPeer // TypeDefIndex: 5593
	{
		// Fields
		public string NameServerHost; // 0x108
		public string NameServerHttp; // 0x110
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort; // 0x00
	
		// Properties
		public string NameServerAddress { get => default; } // 0x0000000182055140-0x00000001820552C0 
		internal virtual bool IsProtocolSecure { get => default; } // 0x0000000182055120-0x0000000182055140 
	
		// Constructors
		public ChatPeer() {} // Dummy constructor
		public ChatPeer(IPhotonPeerListener listener, ConnectionProtocol protocol) {} // 0x0000000182055070-0x0000000182055120
		static ChatPeer() {} // 0x0000000182054FA0-0x0000000182055070
	
		// Methods
		// [Conditional] // 0x0000000180100050-0x0000000180100080
		private void ConfigUnitySockets() {} // 0x0000000182054B70-0x0000000182054D50
		private string GetNameServerAddress() => default; // 0x0000000182054E00-0x0000000182054FA0
		public bool Connect() => default; // 0x0000000182054D50-0x0000000182054E00
		public bool AuthenticateOnNameServer(string appId, string appVersion, string region, AuthenticationValues authValues) => default; // 0x0000000182054980-0x0000000182054B70
	}
}
