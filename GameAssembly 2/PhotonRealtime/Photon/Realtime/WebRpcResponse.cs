/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

// Image 45: PhotonRealtime.dll - Assembly: PhotonRealtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4334-4405

namespace Photon.Realtime
{
	public class WebRpcResponse // TypeDefIndex: 4398
	{
		// Properties
		public string Name { get; private set; } // 0x0000000180248E10-0x0000000180248E20 0x0000000180248410-0x0000000180248420
		public int ResultCode { get; private set; } // 0x000000018027A800-0x000000018027A810 0x000000018027AC40-0x000000018027AC50
		[Obsolete] // 0x00000001801076B0-0x00000001801076E0
		public int ReturnCode { get => default; } // 0x000000018027A800-0x000000018027A810 
		public string Message { get; private set; } // 0x0000000180246FE0-0x0000000180246FF0 0x0000000180249080-0x0000000180249090
		[Obsolete] // 0x0000000180107710-0x0000000180107740
		public string DebugMessage { get => default; } // 0x0000000180246FE0-0x0000000180246FF0 
		public Dictionary<string, object> Parameters { get; private set; } // 0x00000001802470A0-0x00000001802470B0 0x0000000180249810-0x0000000180249820
	
		// Constructors
		public WebRpcResponse() {} // Dummy constructor
		public WebRpcResponse(OperationResponse response) {} // 0x00000001820D31B0-0x00000001820D3380
	
		// Methods
		public string ToStringFull() => default; // 0x00000001820D2F90-0x00000001820D31B0
	}
}
