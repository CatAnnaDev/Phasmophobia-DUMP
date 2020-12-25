/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;

// Image 51: PhotonUnityNetworking.dll - Assembly: PhotonUnityNetworking, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5293-5359

namespace Photon.Pun
{
	[Serializable]
	// [HelpURL] // 0x000000018010B030-0x000000018010B060
	public class ServerSettings : ScriptableObject // TypeDefIndex: 5329
	{
		// Fields
		// [Tooltip] // 0x000000018010B130-0x000000018010B160
		public AppSettings AppSettings; // 0x18
		// [Tooltip] // 0x000000018010B240-0x000000018010B270
		public string DevRegion; // 0x20
		// [Tooltip] // 0x000000018010B2F0-0x000000018010B320
		public PunLogLevel PunLogging; // 0x28
		// [Tooltip] // 0x000000018010B370-0x000000018010B3A0
		public bool EnableSupportLogger; // 0x2C
		// [Tooltip] // 0x000000018010B3D0-0x000000018010B400
		public bool RunInBackground; // 0x2D
		// [Tooltip] // 0x000000018010B500-0x000000018010B530
		public bool StartInOfflineMode; // 0x2E
		// [Tooltip] // 0x000000018010B5B0-0x000000018010B5E0
		public List<string> RpcList; // 0x30
	
		// Properties
		public static string BestRegionSummaryInPreferences { get => default; } // 0x0000000181DC66F0-0x0000000181DC6740 
	
		// Constructors
		public ServerSettings() {} // 0x0000000181DC6680-0x0000000181DC66F0
	
		// Methods
		public void UseCloud(string cloudAppid, string code = "" /* Metadata: 0x0064F75A */) {} // 0x0000000181DC6600-0x0000000181DC6680
		public static bool IsAppId(string val) => default; // 0x0000000181DC64D0-0x0000000181DC6550
		public static void ResetBestRegionCodeInPreferences() {} // 0x0000000181DC6550-0x0000000181DC65A0
		public override string ToString() => default; // 0x0000000181DC65A0-0x0000000181DC6600
	}
}
