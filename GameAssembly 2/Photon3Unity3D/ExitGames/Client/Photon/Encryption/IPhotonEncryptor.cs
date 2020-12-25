/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon.Encryption
{
	public interface IPhotonEncryptor // TypeDefIndex: 4316
	{
		// Methods
		void Init(byte[] encryptionSecret, byte[] hmacSecret, byte[] ivBytes = null, bool chainingModeGCM = false /* Metadata: 0x0064D71A */);
		void Encrypt(byte[] data, int len, byte[] output, ref int offset, bool ivPrefix = true /* Metadata: 0x0064D71B */);
		byte[] Decrypt(byte[] data, int offset, int len, out int outLen, bool ivPrefix = true /* Metadata: 0x0064D71C */);
		byte[] CreateHMAC(byte[] data, int offset, int count);
		bool CheckHMAC(byte[] data, int len);
	}
}
