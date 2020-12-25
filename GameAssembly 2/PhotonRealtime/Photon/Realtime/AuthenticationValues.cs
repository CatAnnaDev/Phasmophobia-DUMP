/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 45: PhotonRealtime.dll - Assembly: PhotonRealtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4334-4405

namespace Photon.Realtime
{
	public class AuthenticationValues // TypeDefIndex: 4385
	{
		// Fields
		private CustomAuthenticationType authType; // 0x10
	
		// Properties
		public CustomAuthenticationType AuthType { get => default; set {} } // 0x00000001803628F0-0x0000000180362930 0x00000001802F6FA0-0x00000001802F6FB0
		public string AuthGetParameters { get; set; } // 0x0000000180246BC0-0x0000000180246BD0 0x0000000180246D40-0x0000000180246D50
		public object AuthPostData { get; private set; } // 0x0000000180246FE0-0x0000000180246FF0 0x0000000180249080-0x0000000180249090
		public string Token { get; protected internal set; } // 0x00000001802470A0-0x00000001802470B0 0x0000000180249810-0x0000000180249820
		public string UserId { get; set; } // 0x00000001802470B0-0x00000001802470C0 0x0000000180249070-0x0000000180249080
	
		// Constructors
		public AuthenticationValues() {} // 0x0000000180735FC0-0x0000000180735FD0
		public AuthenticationValues(string userId) {} // 0x0000000180735F80-0x0000000180735FC0
	
		// Methods
		public virtual void SetAuthPostData(string stringData) {} // 0x0000000180735D10-0x0000000180735D60
		public virtual void SetAuthPostData(byte[] byteData) {} // 0x0000000180249080-0x0000000180249090
		public virtual void SetAuthPostData(Dictionary<string, object> dictData) {} // 0x0000000180249080-0x0000000180249090
		public virtual void AddAuthParameter(string key, string value) {} // 0x0000000180735AC0-0x0000000180735D10
		public override string ToString() => default; // 0x0000000180735D60-0x0000000180735F80
	}
}
