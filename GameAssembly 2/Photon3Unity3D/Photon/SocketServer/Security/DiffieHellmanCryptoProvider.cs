/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Photon.SocketServer.Numeric;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace Photon.SocketServer.Security
{
	internal class DiffieHellmanCryptoProvider : ICryptoProvider // TypeDefIndex: 4321
	{
		// Fields
		private static readonly BigInteger primeRoot; // 0x00
		private readonly BigInteger prime; // 0x10
		private readonly BigInteger secret; // 0x18
		private readonly BigInteger publicKey; // 0x20
		private Rijndael crypto; // 0x28
		private byte[] sharedKey; // 0x30
	
		// Properties
		public byte[] PublicKey { get => default; } // 0x0000000180A8BB70-0x0000000180A8BB90 
	
		// Constructors
		public DiffieHellmanCryptoProvider() {} // 0x0000000180A8B940-0x0000000180A8BA80
		public DiffieHellmanCryptoProvider(byte[] cryptoKey) {} // 0x0000000180A8BA80-0x0000000180A8BB70
		static DiffieHellmanCryptoProvider() {} // 0x0000000180A8B8A0-0x0000000180A8B940
	
		// Methods
		public void DeriveSharedKey(byte[] otherPartyPublicKey) {} // 0x0000000180A8B2C0-0x0000000180A8B4F0
		public byte[] Encrypt(byte[] data, int offset, int count) => default; // 0x0000000180A8B550-0x0000000180A8B690
		public byte[] Decrypt(byte[] data, int offset, int count) => default; // 0x0000000180A8B180-0x0000000180A8B2C0
		public void Dispose() {} // 0x0000000180A8B4F0-0x0000000180A8B550
		protected void Dispose(bool disposing) {} // 0x0000000180399C00-0x0000000180399C10
		private BigInteger CalculatePublicKey() => default; // 0x0000000180A8B0D0-0x0000000180A8B150
		private BigInteger CalculateSharedKey(BigInteger otherPartyPublicKey) => default; // 0x0000000180A8B150-0x0000000180A8B180
		private BigInteger GenerateRandomSecret(int secretLength) => default; // 0x0000000180A8B690-0x0000000180A8B8A0
	}
}
