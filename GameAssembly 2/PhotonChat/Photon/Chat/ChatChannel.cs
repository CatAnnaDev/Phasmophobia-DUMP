/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: PhotonChat.dll - Assembly: PhotonChat, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5583-5604

namespace Photon.Chat
{
	public class ChatChannel // TypeDefIndex: 5587
	{
		// Fields
		public readonly string Name; // 0x10
		public readonly List<string> Senders; // 0x18
		public readonly List<object> Messages; // 0x20
		public int MessageLimit; // 0x28
		public int ChannelID; // 0x2C
		private Dictionary<object, object> properties; // 0x38
		public readonly HashSet<string> Subscribers; // 0x48
	
		// Properties
		public bool IsPrivate { get; protected internal set; } // 0x00000001802FB160-0x00000001802FB170 0x00000001803C0D60-0x00000001803C0D70
		public int MessageCount { get => default; } // 0x00000001820500E0-0x0000000182050120 
		public int LastMsgId { get; protected set; } // 0x0000000180293280-0x0000000180293290 0x00000001802932D0-0x00000001802932E0
		public bool PublishSubscribers { get; protected set; } // 0x0000000180247090-0x00000001802470A0 0x00000001803BF790-0x00000001803BF7A0
		public int MaxSubscribers { get; protected set; } // 0x000000018035B690-0x000000018035B6A0 0x00000001806E4BA0-0x00000001806E4BB0
	
		// Constructors
		public ChatChannel() {} // Dummy constructor
		public ChatChannel(string name) {} // 0x0000000182050000-0x00000001820500E0
	
		// Methods
		public void Add(string sender, object message, int msgId) {} // 0x000000018204F9B0-0x000000018204FA50
		public void Add(string[] senders, object[] messages, int lastMsgId) {} // 0x000000018204FA50-0x000000018204FAF0
		public void TruncateMessages() {} // 0x000000018204FF70-0x0000000182050000
		public void ClearMessages() {} // 0x000000018204FAF0-0x000000018204FB50
		public string ToStringMessages() => default; // 0x000000018204FE50-0x000000018204FF70
		internal void ReadChannelProperties(Dictionary<object, object> newProperties) {} // 0x000000018204FB50-0x000000018204FE50
		internal void AddSubscribers(string[] users) {} // 0x000000018204F910-0x000000018204F9B0
	}
}
