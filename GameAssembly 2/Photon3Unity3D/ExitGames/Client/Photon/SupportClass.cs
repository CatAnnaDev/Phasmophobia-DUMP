/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	public class SupportClass // TypeDefIndex: 4305
	{
		// Fields
		private static List<Thread> threadList; // 0x00
		private static readonly object ThreadListLock; // 0x08
		protected internal static IntegerMillisecondsDelegate IntegerMilliseconds; // 0x10
		private static uint[] crcLookupTable; // 0x18
	
		// Nested types
		public delegate int IntegerMillisecondsDelegate(); // TypeDefIndex: 4306; 0x0000000180A8BB90-0x0000000180A8BE20
	
		public class ThreadSafeRandom // TypeDefIndex: 4307
		{
			// Fields
			private static readonly Random _r; // 0x00
	
			// Constructors
			public ThreadSafeRandom() {} // 0x00000001802466A0-0x00000001802466B0
			static ThreadSafeRandom() {} // 0x0000000180A90FF0-0x0000000180A91050
	
			// Methods
			public static int Next() => default; // 0x0000000180A90EA0-0x0000000180A90FF0
		}
	
		// Constructors
		public SupportClass() {} // 0x00000001802466A0-0x00000001802466B0
		static SupportClass() {} // 0x0000000180A8E210-0x0000000180A8E300
	
		// Methods
		public static List<MethodInfo> GetMethods(Type type, Type attribute) => default; // 0x0000000180A8D3A0-0x0000000180A8D4C0
		public static int GetTickCount() => default; // 0x0000000180A8D4C0-0x0000000180A8D530
		public static byte StartBackgroundCalls(Func<bool> myThread, int millisecondsInterval = 100 /* Metadata: 0x0064D706 */, string taskName = "" /* Metadata: 0x0064D70A */) => default; // 0x0000000180A8D6E0-0x0000000180A8DB40
		public static bool StopBackgroundCalls(byte id) => default; // 0x0000000180A8DE00-0x0000000180A8E0B0
		public static bool StopAllBackgroundCalls() => default; // 0x0000000180A8DB40-0x0000000180A8DE00
		public static void WriteStackTrace(Exception throwable, TextWriter stream) {} // 0x0000000180A8E140-0x0000000180A8E210
		public static void WriteStackTrace(Exception throwable) {} // 0x0000000180A8E0B0-0x0000000180A8E140
		public static string DictionaryToString(IDictionary dictionary) => default; // 0x0000000180A8CC80-0x0000000180A8CCE0
		public static string DictionaryToString(IDictionary dictionary, bool includeTypes) => default; // 0x0000000180A8CCE0-0x0000000180A8D3A0
		[Obsolete] // 0x00000001800F2350-0x00000001800F2380
		public static string HashtableToString(Hashtable hash) => default; // 0x0000000180A8D530-0x0000000180A8D5D0
		public static string ByteArrayToString(byte[] list) => default; // 0x0000000180A8CAB0-0x0000000180A8CB20
		private static uint[] InitializeTable(uint polynomial) => default; // 0x0000000180A8D5D0-0x0000000180A8D6E0
		public static uint CalculateCrc(byte[] buffer, int length) => default; // 0x0000000180A8CB20-0x0000000180A8CC80
	}
}
