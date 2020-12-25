/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon.Encryption
{
	public class EncryptorNative : IPhotonEncryptor // TypeDefIndex: 4318
	{
		// Fields
		public static readonly int BLOCK_SIZE; // 0x00
		public static readonly int IV_SIZE; // 0x04
		public static readonly int HMAC_SIZE; // 0x08
		protected byte[] hmacHash; // 0x10
		protected IntPtr encryptor; // 0x18
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x00000001800E8E90-0x00000001800E8EB0
		public delegate void LogCallbackDelegate(IntPtr userData, int level, string msg); // TypeDefIndex: 4319; 0x00000001806BA930-0x00000001806BAC90
	
		private enum egDebugLevel // TypeDefIndex: 4320
		{
			OFF = 0,
			ERRORS = 1,
			WARNINGS = 2,
			INFO = 3,
			ALL = 4
		}
	
		// Constructors
		public EncryptorNative() {} // 0x00000001806AE730-0x00000001806AE7B0
		static EncryptorNative() {} // 0x00000001806AE6C0-0x00000001806AE730
	
		// Methods
		public static extern IntPtr egconstructEncryptor(byte[] pEncryptSecret, byte[] pHmacSecret); // 0x00000001806AE890-0x00000001806AE930
		public static extern void egdestructEncryptor(IntPtr pEncryptor); // 0x00000001806AEA10-0x00000001806AEA90
		public static extern void egencrypt(IntPtr pEncryptor, byte[] pIn, int inSize, byte[] pOut, ref int outSize, ref int outOffset); // 0x00000001806AEA90-0x00000001806AEB70
		public static extern void egdecrypt(IntPtr pEncryptor, byte[] pIn, int inSizem, int inOffset, byte[] pOut, ref int outSize); // 0x00000001806AE930-0x00000001806AEA10
		public static extern void egHMAC(IntPtr pEncryptor, byte[] pIn, int inSize, int inOffset, byte[] pOut, ref int outSize); // 0x00000001806AE7B0-0x00000001806AE890
		public static extern void egsetEncryptorLoggingCallback(IntPtr userData, LogCallbackDelegate callback); // 0x00000001806AEB70-0x00000001806AEC10
		public static extern bool egsetEncryptorLoggingLevel(int level); // 0x00000001806AEC10-0x00000001806AEC90
		~EncryptorNative() {} // 0x00000001806AE270-0x00000001806AE3C0
		// [MonoPInvokeCallback] // 0x00000001800F7AA0-0x00000001800F7AF0
		private static void OnNativeLog(IntPtr userData, int debugLevel, string message) {} // 0x00000001806AE5A0-0x00000001806AE6C0
		public void Init(byte[] encryptionSecret, byte[] hmacSecret, byte[] ivBytes = null, bool chainingModeGCM = false /* Metadata: 0x0064D720 */) {} // 0x00000001806AE3C0-0x00000001806AE5A0
		private void Dispose(bool dispose) {} // 0x00000001806AE060-0x00000001806AE140
		public void Encrypt(byte[] data, int len, byte[] output, ref int offset, bool ivPrefix = true /* Metadata: 0x0064D721 */) {} // 0x00000001806AE140-0x00000001806AE270
		public byte[] CreateHMAC(byte[] data, int offset, int count) => default; // 0x00000001806ADDF0-0x00000001806ADF40
		public byte[] Decrypt(byte[] data, int offset, int len, out int outLen, bool ivPrefix = true /* Metadata: 0x0064D722 */) {
			outLen = default;
			return default;
		} // 0x00000001806ADF40-0x00000001806AE060
		public bool CheckHMAC(byte[] data, int len) => default; // 0x00000001806AD9A0-0x00000001806ADDF0
	}
}
