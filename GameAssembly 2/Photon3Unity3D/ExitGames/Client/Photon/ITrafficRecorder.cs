/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	public interface ITrafficRecorder // TypeDefIndex: 4263
	{
		// Properties
		bool Enabled { get; set; }
	
		// Methods
		void Record(byte[] inBuffer, int length, bool incoming, short peerId, IPhotonSocket connection);
	}
}
