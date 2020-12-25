/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace Photon.SocketServer.Security
{
	internal interface ICryptoProvider : IDisposable // TypeDefIndex: 4323
	{
		// Properties
		byte[] PublicKey { get; }
	
		// Methods
		void DeriveSharedKey(byte[] otherPartyPublicKey);
		byte[] Encrypt(byte[] data, int offset, int count);
		byte[] Decrypt(byte[] data, int offset, int count);
	}
}
