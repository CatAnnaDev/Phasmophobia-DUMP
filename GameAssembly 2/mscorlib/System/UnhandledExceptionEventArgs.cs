/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public class UnhandledExceptionEventArgs : EventArgs // TypeDefIndex: 321
	{
		// Fields
		private object _Exception; // 0x10
		private bool _IsTerminating; // 0x18
	
		// Properties
		public object ExceptionObject { /* [ReliabilityContract] */ /* 0x00000001800DF1C0-0x00000001800DF1E0 */ get => default; } // 0x0000000180248E10-0x0000000180248E20 
		public bool IsTerminating { /* [ReliabilityContract] */ /* 0x00000001800DF1C0-0x00000001800DF1E0 */ get => default; } // 0x00000001802D9720-0x00000001802D9730 
	
		// Constructors
		public UnhandledExceptionEventArgs() {} // Dummy constructor
		public UnhandledExceptionEventArgs(object exception, bool isTerminating) {} // 0x0000000180A74760-0x0000000180A747E0
	}
}
