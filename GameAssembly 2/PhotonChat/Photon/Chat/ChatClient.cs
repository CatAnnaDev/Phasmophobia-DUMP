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
	public class ChatClient : IPhotonPeerListener // TypeDefIndex: 5588
	{
		// Fields
		private const int FriendRequestListMax = 1024; // Metadata: 0x0064FF3C
		public const int DefaultMaxSubscribers = 100; // Metadata: 0x0064FF40
		private const byte HttpForwardWebFlag = 1; // Metadata: 0x0064FF44
		private string chatRegion; // 0x20
		public int MessageLimit; // 0x48
		public readonly Dictionary<string, ChatChannel> PublicChannels; // 0x50
		public readonly Dictionary<string, ChatChannel> PrivateChannels; // 0x58
		private readonly HashSet<string> PublicChannelsUnsubscribing; // 0x60
		private readonly IChatClientListener listener; // 0x68
		public ChatPeer chatPeer; // 0x70
		private const string ChatAppName = "chat"; // Metadata: 0x0064FF45
		private bool didAuthenticate; // 0x78
		private int? statusToSetWhenConnected; // 0x7C
		private object messageToSetWhenConnected; // 0x88
		private int msDeltaForServiceCalls; // 0x90
		private int msTimestampOfLastServiceCall; // 0x94
	
		// Properties
		public string NameServerAddress { get; private set; } // 0x0000000180248E10-0x0000000180248E20 0x0000000180248410-0x0000000180248420
		public string FrontendAddress { get; private set; } // 0x0000000180246BC0-0x0000000180246BD0 0x0000000180246D40-0x0000000180246D50
		public string ChatRegion { get => default; set {} } // 0x0000000180246FE0-0x0000000180246FF0 0x0000000180249080-0x0000000180249090
		public ChatState State { get; private set; } // 0x000000018026C7E0-0x000000018026C7F0 0x000000018026D130-0x000000018026D140
		public ChatDisconnectCause DisconnectedCause { get; private set; } // 0x000000018026C890-0x000000018026C8A0 0x00000001803B49F0-0x00000001803B4A00
		public bool CanChat { get => default; } // 0x00000001820543B0-0x00000001820543D0 
		private bool HasPeer { get => default; } // 0x00000001820543F0-0x0000000182054400 
		public string AppVersion { get; private set; } // 0x00000001802470B0-0x00000001802470C0 0x0000000180249070-0x0000000180249080
		public string AppId { get; private set; } // 0x0000000180246FD0-0x0000000180246FE0 0x0000000180278400-0x0000000180278410
		public AuthenticationValues AuthValues { get; set; } // 0x0000000180249A10-0x0000000180249A20 0x0000000180249920-0x0000000180249930
		public string UserId { get => default; private set {} } // 0x0000000182054440-0x0000000182054450 0x00000001820548E0-0x0000000182054980
		public bool UseBackgroundWorkerForSending { get; set; } // 0x00000001802F2670-0x00000001802F2680 0x00000001820548D0-0x00000001820548E0
		public ConnectionProtocol TransportProtocol { get => default; set {} } // 0x0000000182054420-0x0000000182054440 0x00000001820547E0-0x00000001820548D0
		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig { get => default; } // 0x0000000182054400-0x0000000182054420 
		public DebugLevel DebugOut { get => default; set {} } // 0x00000001820543D0-0x00000001820543F0 0x00000001820547C0-0x00000001820547E0
	
		// Constructors
		public ChatClient() {} // Dummy constructor
		public ChatClient(IChatClientListener listener, ConnectionProtocol protocol = ConnectionProtocol.Udp /* Metadata: 0x0064FF25 */) {} // 0x00000001820541E0-0x00000001820543B0
	
		// Methods
		public bool CanChatInChannel(string channelName) => default; // 0x0000000182050580-0x0000000182050610
		public bool ConnectUsingSettings(ChatAppSettings appSettings) => default; // 0x00000001820507D0-0x00000001820509B0
		public bool Connect(string appId, string appVersion, AuthenticationValues authValues) => default; // 0x00000001820509B0-0x0000000182050C00
		public bool ConnectAndSetStatus(string appId, string appVersion, AuthenticationValues authValues, int status = 2 /* Metadata: 0x0064FF26 */, object message = null) => default; // 0x0000000182050610-0x00000001820506C0
		public void Service() {} // 0x0000000182053240-0x00000001820532D0
		private bool SendOutgoingInBackground() => default; // 0x0000000182053170-0x00000001820531B0
		[Obsolete] // 0x00000001801399E0-0x0000000180139A10
		public void SendAcksOnly() {} // 0x0000000182053030-0x0000000182053050
		public void Disconnect(ChatDisconnectCause cause = ChatDisconnectCause.DisconnectByClientLogic /* Metadata: 0x0064FF2A */) {} // 0x0000000182050C00-0x0000000182050C60
		public void StopThread() {} // 0x00000001820534A0-0x00000001820534C0
		public bool Subscribe(string[] channels) => default; // 0x00000001820534C0-0x00000001820535A0
		public bool Subscribe(string[] channels, int[] lastMsgIds) => default; // 0x0000000182053B60-0x0000000182053DE0
		public bool Subscribe(string[] channels, int messagesFromHistory) => default; // 0x00000001820535A0-0x0000000182053690
		public bool Unsubscribe(string[] channels) => default; // 0x00000001820540B0-0x00000001820541E0
		public bool PublishMessage(string channelName, object message, bool forwardAsWebhook = false /* Metadata: 0x0064FF2E */) => default; // 0x0000000182052D20-0x0000000182052D40
		internal bool PublishMessageUnreliable(string channelName, object message, bool forwardAsWebhook = false /* Metadata: 0x0064FF2F */) => default; // 0x0000000182052D00-0x0000000182052D20
		private bool publishMessage(string channelName, object message, bool reliable, bool forwardAsWebhook = false /* Metadata: 0x0064FF30 */) => default; // 0x0000000182054450-0x0000000182054600
		public bool SendPrivateMessage(string target, object message, bool forwardAsWebhook = false /* Metadata: 0x0064FF31 */) => default; // 0x00000001820531E0-0x0000000182053210
		public bool SendPrivateMessage(string target, object message, bool encrypt, bool forwardAsWebhook) => default; // 0x0000000182053210-0x0000000182053240
		internal bool SendPrivateMessageUnreliable(string target, object message, bool encrypt, bool forwardAsWebhook = false /* Metadata: 0x0064FF32 */) => default; // 0x00000001820531B0-0x00000001820531E0
		private bool sendPrivateMessage(string target, object message, bool encrypt, bool reliable, bool forwardAsWebhook = false /* Metadata: 0x0064FF33 */) => default; // 0x0000000182054600-0x00000001820547C0
		private bool SetOnlineStatus(int status, object message, bool skipMessage) => default; // 0x00000001820532F0-0x0000000182053480
		public bool SetOnlineStatus(int status) => default; // 0x0000000182053480-0x00000001820534A0
		public bool SetOnlineStatus(int status, object message) => default; // 0x00000001820532D0-0x00000001820532F0
		public bool AddFriends(string[] friends) => default; // 0x0000000182050120-0x0000000182050410
		public bool RemoveFriends(string[] friends) => default; // 0x0000000182052D40-0x0000000182053030
		public string GetPrivateChannelNameByUser(string userName) => default; // 0x00000001820514E0-0x0000000182051540
		public bool TryGetChannel(string channelName, bool isPrivate, out ChatChannel channel) {
			channel = default;
			return default;
		} // 0x0000000182053EC0-0x0000000182053F40
		public bool TryGetChannel(string channelName, out ChatChannel channel) {
			channel = default;
			return default;
		} // 0x0000000182053F40-0x0000000182053FE0
		public bool TryGetPrivateChannelByUser(string userId, out ChatChannel channel) {
			channel = default;
			return default;
		} // 0x0000000182053FE0-0x00000001820540B0
		void IPhotonPeerListener.DebugReturn(DebugLevel level, string message) {} // 0x0000000182050C60-0x0000000182050CD0
		void IPhotonPeerListener.OnEvent(EventData eventData) {} // 0x0000000182050CD0-0x0000000182050D80
		void IPhotonPeerListener.OnOperationResponse(OperationResponse operationResponse) {} // 0x0000000182050D80-0x0000000182050ED0
		void IPhotonPeerListener.OnStatusChanged(StatusCode statusCode) {} // 0x0000000182050ED0-0x00000001820514E0
		private void TryAuthenticateOnNameServer() {} // 0x0000000182053DE0-0x0000000182053EC0
		private bool SendChannelOperation(string[] channels, byte operation, int historyLength) => default; // 0x0000000182053050-0x0000000182053170
		private void HandlePrivateMessageEvent(EventData eventData) {} // 0x0000000182051DA0-0x0000000182052130
		private void HandleChatMessagesEvent(EventData eventData) {} // 0x0000000182051A80-0x0000000182051DA0
		private void HandleSubscribeEvent(EventData eventData) {} // 0x0000000182052310-0x0000000182052680
		private void HandleUnsubscribeEvent(EventData eventData) {} // 0x0000000182052680-0x0000000182052810
		private void HandleAuthResponse(OperationResponse operationResponse) {} // 0x0000000182051540-0x0000000182051A80
		private void HandleStatusUpdate(EventData eventData) {} // 0x0000000182052130-0x0000000182052310
		private bool ConnectToFrontEnd() => default; // 0x00000001820506C0-0x00000001820507D0
		private bool AuthenticateOnFrontEnd() => default; // 0x0000000182050410-0x0000000182050580
		private void HandleUserUnsubscribedEvent(EventData eventData) {} // 0x0000000182052AF0-0x0000000182052D00
		private void HandleUserSubscribedEvent(EventData eventData) {} // 0x0000000182052810-0x0000000182052AF0
		public bool Subscribe(string channel, int lastMsgId = 0 /* Metadata: 0x0064FF34 */, int messagesFromHistory = -1 /* Metadata: 0x0064FF38 */, ChannelCreationOptions creationOptions = null) => default; // 0x0000000182053690-0x0000000182053B60
	}
}
