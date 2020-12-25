/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public class OperationCanceledException : SystemException // TypeDefIndex: 273
	{
		// Fields
		[NonSerialized]
		private CancellationToken _cancellationToken; // 0x88
	
		// Properties
		public CancellationToken CancellationToken { get => default; private set {} } // 0x000000018024B310-0x000000018024B320 0x000000018068E2A0-0x000000018068E2C0
	
		// Constructors
		public OperationCanceledException() {} // 0x000000018068E1C0-0x000000018068E220
		public OperationCanceledException(string message) {} // 0x000000018068E220-0x000000018068E250
		public OperationCanceledException(string message, CancellationToken token) {} // 0x000000018068E250-0x000000018068E2A0
		protected OperationCanceledException(SerializationInfo info, StreamingContext context) {} // 0x000000018031B190-0x000000018031B1B0
	}
}
