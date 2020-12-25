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
	internal class NCommandPool // TypeDefIndex: 4264
	{
		// Fields
		private readonly Stack<NCommand> pool; // 0x10
	
		// Constructors
		public NCommandPool() {} // 0x00000001806BB0F0-0x00000001806BB160
	
		// Methods
		public NCommand Acquire(EnetPeer peer, byte[] inBuff, ref int readingOffset) => default; // 0x00000001806BAE40-0x00000001806BAFD0
		public NCommand Acquire(EnetPeer peer, byte commandType, StreamBuffer payload, byte channel) => default; // 0x00000001806BAC90-0x00000001806BAE40
		public void Release(NCommand nCommand) {} // 0x00000001806BAFD0-0x00000001806BB0F0
	}
}
