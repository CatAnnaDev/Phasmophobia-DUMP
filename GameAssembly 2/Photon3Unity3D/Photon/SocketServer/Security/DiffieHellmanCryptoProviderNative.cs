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
	internal class DiffieHellmanCryptoProviderNative : ICryptoProvider // TypeDefIndex: 4322
	{
		// Fields
		private IntPtr cryptor; // 0x10
		private byte[] sharedKeyHash; // 0x18
	
		// Properties
		public byte[] PublicKey { get => default; } // 0x0000000180A8AF60-0x0000000180A8B0D0 
	
		// Constructors
		public DiffieHellmanCryptoProviderNative() {} // 0x0000000180A8AA30-0x0000000180A8AAB0
		public DiffieHellmanCryptoProviderNative(byte[] sharedKeyHash) {} // 0x0000000180A8AAB0-0x0000000180A8AB40
	
		// Methods
		public static extern IntPtr egCryptorCreate(); // 0x0000000180A8AB40-0x0000000180A8ABB0
		public static extern int egCryptorPublicKey(IntPtr cryptor, out IntPtr key, out int keySize); // 0x0000000180A8AEC0-0x0000000180A8AF60
		public static extern int egCryptorDeriveSharedKey(IntPtr cryptor, byte[] serverPublicKey, int keySize); // 0x0000000180A8ACA0-0x0000000180A8AD50
		public static extern int egCryptorEncrypt(IntPtr cryptor, byte[] plainData, int plainDataOffset, int plainDataSize, byte[] sharedKeyHash, out IntPtr encodedData, out int encodedDataSize); // 0x0000000180A8ADD0-0x0000000180A8AEC0
		public static extern int egCryptorDecrypt(IntPtr cryptor, byte[] encodedData, int encodedDataOffset, int encodedDataSize, byte[] sharedKeyHash, out IntPtr plainData, out int plainDataSize); // 0x0000000180A8ABB0-0x0000000180A8ACA0
		public static extern void egCryptorDispose(IntPtr cryptor); // 0x0000000180A8AD50-0x0000000180A8ADD0
		public void DeriveSharedKey(byte[] otherPartyPublicKey) {} // 0x0000000180A8A650-0x0000000180A8A760
		public byte[] Encrypt(byte[] data, int offset, int count) => default; // 0x0000000180A8A8C0-0x0000000180A8AA30
		public byte[] Decrypt(byte[] data, int offset, int count) => default; // 0x0000000180A8A4E0-0x0000000180A8A650
		public void Dispose() {} // 0x0000000180A8A7F0-0x0000000180A8A8C0
		protected void Dispose(bool disposing) {} // 0x0000000180A8A760-0x0000000180A8A7F0
	}
}
