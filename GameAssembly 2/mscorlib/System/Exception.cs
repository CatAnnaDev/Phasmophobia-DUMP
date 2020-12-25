/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	// [ClassInterface] // 0x00000001800E1DD0-0x00000001800E1E40
	// [ComDefaultInterface] // 0x00000001800E1DD0-0x00000001800E1E40
	// [ComVisible] // 0x00000001800E1DD0-0x00000001800E1E40
	public class Exception : ISerializable, _Exception // TypeDefIndex: 208
	{
		// Fields
		[OptionalField] // 0x00000001800DF500-0x00000001800DF510
		private static object s_EDILock; // 0x00
		private string _className; // 0x10
		internal string _message; // 0x18
		private IDictionary _data; // 0x20
		private Exception _innerException; // 0x28
		private string _helpURL; // 0x30
		private object _stackTrace; // 0x38
		private string _stackTraceString; // 0x40
		private string _remoteStackTraceString; // 0x48
		private int _remoteStackIndex; // 0x50
		private object _dynamicMethods; // 0x58
		internal int _HResult; // 0x60
		private string _source; // 0x68
		[OptionalField] // 0x00000001800E2000-0x00000001800E2030
		private SafeSerializationManager _safeSerializationManager; // 0x70
		internal StackTrace[] captured_traces; // 0x78
		private IntPtr[] native_trace_ips; // 0x80
		private const int _COMPlusExceptionCode = -532462766; // Metadata: 0x0062FDA0
	
		// Properties
		public virtual string Message { get => default; } // 0x000000018031AE70-0x000000018031AF80 
		public virtual IDictionary Data { get => default; } // 0x000000018031ADE0-0x000000018031AE70 
		public Exception InnerException { get => default; } // 0x00000001802470A0-0x00000001802470B0 
		public virtual string StackTrace { get => default; } // 0x000000018031B0C0-0x000000018031B100 
		public virtual string Source { get => default; } // 0x000000018031AF80-0x000000018031B0C0 
		public int HResult { get => default; protected set {} } // 0x00000001802DEAB0-0x00000001802DEAC0 0x000000018031A500-0x000000018031A510
	
		// Nested types
		internal enum ExceptionMessageKind // TypeDefIndex: 209
		{
			ThreadAbort = 1,
			ThreadInterrupted = 2,
			OutOfMemory = 3
		}
	
		// Constructors
		public Exception() {} // 0x000000018031A9A0-0x000000018031A9C0
		public Exception(string message) {} // 0x000000018031AA20-0x000000018031AA60
		public Exception(string message, Exception innerException) {} // 0x000000018031A9C0-0x000000018031AA20
		protected Exception(SerializationInfo info, StreamingContext context) {} // 0x000000018031AA60-0x000000018031ADE0
		static Exception() {} // 0x000000018031A940-0x000000018031A9A0
	
		// Methods
		private void Init() {} // 0x000000018031A320-0x000000018031A3B0
		private static bool IsImmutableAgileException(Exception e) => default; // 0x0000000180250A70-0x0000000180250A80
		private string GetClassName() => default; // 0x0000000180319E60-0x0000000180319EB0
		private string GetStackTrace(bool needFileInfo) => default; // 0x000000018031A2C0-0x000000018031A310
		[FriendAccessAllowed] // 0x00000001800D4E50-0x00000001800D4E60
		internal void SetErrorCode(int hr) {} // 0x000000018031A500-0x000000018031A510
		public override string ToString() => default; // 0x000000018031A930-0x000000018031A940
		private string ToString(bool needFileLineInfo, bool needMessage) => default; // 0x000000018031A520-0x000000018031A930
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000180319F00-0x000000018031A2C0
		[OnDeserialized] // 0x00000001800D4E50-0x00000001800D4E60
		private void OnDeserialized(StreamingContext context) {} // 0x000000018031A3B0-0x000000018031A440
		private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) => default; // 0x000000018031A510-0x000000018031A520
		internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) {} // 0x000000018031A450-0x000000018031A500
		public new Type GetType() => default; // 0x000000018031A310-0x000000018031A320
		internal static string GetMessageFromNativeResources(ExceptionMessageKind kind) => default; // 0x0000000180319EB0-0x0000000180319F00
		internal Exception FixRemotingException() => default; // 0x0000000180319D80-0x0000000180319E60
		internal static void ReportUnhandledException(Exception exception) {} // 0x000000018031A440-0x000000018031A450
	}
}
