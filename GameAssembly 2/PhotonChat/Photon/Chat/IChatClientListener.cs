/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

// Image 55: PhotonChat.dll - Assembly: PhotonChat, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5583-5604

namespace Photon.Chat
{
	public interface IChatClientListener // TypeDefIndex: 5600
	{
		// Methods
		void DebugReturn(DebugLevel level, string message);
		void OnDisconnected();
		void OnConnected();
		void OnChatStateChange(ChatState state);
		void OnGetMessages(string channelName, string[] senders, object[] messages);
		void OnPrivateMessage(string sender, object message, string channelName);
		void OnSubscribed(string[] channels, bool[] results);
		void OnUnsubscribed(string[] channels);
		void OnStatusUpdate(string user, int status, bool gotMessage, object message);
		void OnUserSubscribed(string channel, string user);
		void OnUserUnsubscribed(string channel, string user);
	}
}
