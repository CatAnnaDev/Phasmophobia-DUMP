/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

// Image 45: PhotonRealtime.dll - Assembly: PhotonRealtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4334-4405

namespace Photon.Realtime
{
	[Serializable]
	public class AppSettings // TypeDefIndex: 4335
	{
		// Fields
		public string AppIdRealtime; // 0x10
		public string AppIdChat; // 0x18
		public string AppIdVoice; // 0x20
		public string AppVersion; // 0x28
		public bool UseNameServer; // 0x30
		public string FixedRegion; // 0x38
		[NonSerialized]
		public string BestRegionSummaryFromStorage; // 0x40
		public string Server; // 0x48
		public int Port; // 0x50
		public string ProxyServer; // 0x58
		public ConnectionProtocol Protocol; // 0x60
		public bool EnableProtocolFallback; // 0x61
		public AuthModeOption AuthMode; // 0x64
		public bool EnableLobbyStatistics; // 0x68
		public DebugLevel NetworkLogging; // 0x69
	
		// Properties
		public bool IsMasterServerAddress { get => default; } // 0x0000000180735AB0-0x0000000180735AC0 
		public bool IsBestRegion { get => default; } // 0x0000000180735A60-0x0000000180735A80 
		public bool IsDefaultNameServer { get => default; } // 0x0000000180735A80-0x0000000180735AA0 
		public bool IsDefaultPort { get => default; } // 0x0000000180735AA0-0x0000000180735AB0 
	
		// Constructors
		public AppSettings() {} // 0x0000000180735A40-0x0000000180735A60
	
		// Methods
		public string ToStringFull() => default; // 0x00000001807353B0-0x0000000180735A40
		private string HideAppId(string appId) => default; // 0x0000000180735330-0x00000001807353B0
		public AppSettings CopyTo(AppSettings d) => default; // 0x0000000180735250-0x0000000180735330
	}
}
