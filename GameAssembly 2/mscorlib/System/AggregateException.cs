/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
	// [DebuggerDisplay] // 0x0000000180145EA0-0x0000000180145ED0
	public class AggregateException : Exception // TypeDefIndex: 132
	{
		// Fields
		private ReadOnlyCollection<Exception> m_innerExceptions; // 0x88
	
		// Properties
		public ReadOnlyCollection<Exception> InnerExceptions { get => default; } // 0x000000018024B310-0x000000018024B320 
	
		// Constructors
		public AggregateException() {} // 0x0000000180700C90-0x0000000180700D50
		public AggregateException(IEnumerable<Exception> innerExceptions) {} // 0x00000001807003C0-0x0000000180700490
		public AggregateException(params /* 0x00000001800D4E50-0x00000001800D4E60 */ Exception[] innerExceptions) {} // 0x0000000180700790-0x00000001807007F0
		public AggregateException(string message, IEnumerable<Exception> innerExceptions) {} // 0x0000000180700D50-0x0000000180700E00
		public AggregateException(string message, params /* 0x00000001800D4E50-0x00000001800D4E60 */ Exception[] innerExceptions) {} // 0x00000001807008C0-0x00000001807008D0
		private AggregateException(string message, IList<Exception> innerExceptions) {} // 0x0000000180700490-0x00000001807006E0
		internal AggregateException(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) {} // 0x00000001807007F0-0x00000001807008C0
		internal AggregateException(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) {} // 0x00000001807006E0-0x0000000180700790
		private AggregateException(string message, IList<ExceptionDispatchInfo> innerExceptionInfos) {} // 0x00000001807008D0-0x0000000180700B00
		protected AggregateException(SerializationInfo info, StreamingContext context) {} // 0x0000000180700B00-0x0000000180700C90
	
		// Methods
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001806FFFB0-0x00000001807000F0
		public AggregateException Flatten() => default; // 0x00000001806FFDE0-0x00000001806FFFB0
		public override string ToString() => default; // 0x00000001807000F0-0x00000001807003C0
	}
}
