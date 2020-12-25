/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	public class EventData // TypeDefIndex: 4281
	{
		// Fields
		public byte Code; // 0x10
		public Dictionary<byte, object> Parameters; // 0x18
		public byte SenderKey; // 0x20
		private int sender; // 0x24
		public byte CustomDataKey; // 0x28
		private object customData; // 0x30
	
		// Properties
		public object this[byte key] { get => default; internal set {} } // 0x00000001806B8820-0x00000001806B8890 0x00000001806B8910-0x00000001806B89C0
		public int Sender { get => default; internal set {} } // 0x00000001806B8890-0x00000001806B8910 0x0000000180326FA0-0x0000000180326FB0
		public object CustomData { get => default; internal set {} } // 0x00000001806B87E0-0x00000001806B8820 0x0000000180249070-0x0000000180249080
	
		// Constructors
		public EventData() {} // 0x00000001806B87C0-0x00000001806B87E0
	
		// Methods
		internal void Reset() {} // 0x00000001806B8670-0x00000001806B86E0
		public override string ToString() => default; // 0x00000001806B8770-0x00000001806B87C0
		public string ToStringFull() => default; // 0x00000001806B86E0-0x00000001806B8770
	}
}
