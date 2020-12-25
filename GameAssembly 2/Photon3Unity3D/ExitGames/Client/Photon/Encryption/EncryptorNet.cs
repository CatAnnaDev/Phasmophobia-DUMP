/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon.Encryption
{
	public class EncryptorNet : IPhotonEncryptor // TypeDefIndex: 4317
	{
		// Fields
		protected Aes encryptorIn; // 0x10
		protected Aes encryptorOut; // 0x18
		protected HMACSHA256 hmacsha256In; // 0x20
		protected HMACSHA256 hmacsha256Out; // 0x28
		private readonly byte[] reusedIvBuffer; // 0x30
		private readonly byte[] reusedReadBuffer; // 0x38
	
		// Constructors
		public EncryptorNet() {} // 0x00000001806AF850-0x00000001806AF8D0
	
		// Methods
		public void Init(byte[] encryptionSecret, byte[] hmacSecret, byte[] ivBytes = null, bool chainingModeGCM = false /* Metadata: 0x0064D71D */) {} // 0x00000001806AF710-0x00000001806AF850
		public void Encrypt(byte[] data, int len, byte[] output, ref int offset, bool ivPrefix = true /* Metadata: 0x0064D71E */) {} // 0x00000001806AF3A0-0x00000001806AF710
		public byte[] Decrypt(byte[] data, int offset, int len, out int outLen, bool ivPrefix = true /* Metadata: 0x0064D71F */) {
			outLen = default;
			return default;
		} // 0x00000001806AF000-0x00000001806AF3A0
		public byte[] CreateHMAC(byte[] data, int offset, int count) => default; // 0x00000001806AEF90-0x00000001806AF000
		public bool CheckHMAC(byte[] data, int len) => default; // 0x00000001806AEC90-0x00000001806AEF90
	}
}
