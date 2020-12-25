/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	internal class TermInfoDriver : IConsoleDriver // TypeDefIndex: 384
	{
		// Fields
		private static unsafe int* native_terminal_size; // 0x00
		private static int terminal_size; // 0x08
		private static readonly string[] locations; // 0x10
		private TermInfoReader reader; // 0x10
		private int cursorLeft; // 0x18
		private int cursorTop; // 0x1C
		private string title; // 0x20
		private string titleFormat; // 0x28
		private bool cursorVisible; // 0x30
		private string csrVisible; // 0x38
		private string csrInvisible; // 0x40
		private string clear; // 0x48
		private string bell; // 0x50
		private string term; // 0x58
		private StreamReader stdin; // 0x60
		private CStreamWriter stdout; // 0x68
		private int windowWidth; // 0x70
		private int windowHeight; // 0x74
		private int bufferHeight; // 0x78
		private int bufferWidth; // 0x7C
		private char[] buffer; // 0x80
		private int readpos; // 0x88
		private int writepos; // 0x8C
		private string keypadXmit; // 0x90
		private string keypadLocal; // 0x98
		private bool inited; // 0xA0
		private object initLock; // 0xA8
		private bool initKeys; // 0xB0
		private string origPair; // 0xB8
		private string origColors; // 0xC0
		private string cursorAddress; // 0xC8
		private ConsoleColor fgcolor; // 0xD0
		private string setfgcolor; // 0xD8
		private string setbgcolor; // 0xE0
		private int maxColors; // 0xE8
		private bool noGetPosition; // 0xEC
		private Hashtable keymap; // 0xF0
		private ByteMatcher rootmap; // 0xF8
		private int rl_startx; // 0x100
		private int rl_starty; // 0x104
		private byte[] control_characters; // 0x108
		private static readonly int[] _consoleColorToAnsiCode; // 0x18
		private char[] echobuf; // 0x110
		private int echon; // 0x118
	
		// Properties
		public bool Initialized { get => default; } // 0x00000001807FB900-0x00000001807FB910 
		public int WindowHeight { get => default; } // 0x00000001808D02D0-0x00000001808D0300 
		public int WindowWidth { get => default; } // 0x00000001808D0300-0x00000001808D0330 
	
		// Constructors
		public TermInfoDriver() {} // Dummy constructor
		public TermInfoDriver(string term) {} // 0x00000001808CFEC0-0x00000001808D02D0
		static TermInfoDriver() {} // 0x00000001808CFC80-0x00000001808CFEC0
	
		// Methods
		private static string TryTermInfoDir(string dir, string term) => default; // 0x00000001808CF7B0-0x00000001808CFA20
		private static string SearchTerminfo(string term) => default; // 0x00000001808CF400-0x00000001808CF5A0
		private void WriteConsole(string str) {} // 0x00000001808CFA20-0x00000001808CFA50
		public void Init() {} // 0x00000001808CDFD0-0x00000001808CE8E0
		private void IncrementX() {} // 0x00000001808CDD70-0x00000001808CDE00
		public void WriteSpecialKey(ConsoleKeyInfo key) {} // 0x00000001808CFA50-0x00000001808CFC30
		public void WriteSpecialKey(char c) {} // 0x00000001808CFC30-0x00000001808CFC80
		public bool IsSpecialKey(ConsoleKeyInfo key) => default; // 0x00000001808CE9F0-0x00000001808CEA90
		public bool IsSpecialKey(char c) => default; // 0x00000001808CE920-0x00000001808CE9F0
		private void GetCursorPosition() {} // 0x00000001808CD6E0-0x00000001808CD9C0
		private void CheckWindowDimensions() {} // 0x00000001808CAB60-0x00000001808CAD60
		private void AddToBuffer(int b) {} // 0x00000001808CAA40-0x00000001808CAB40
		private void AdjustBuffer() {} // 0x00000001808CAB40-0x00000001808CAB60
		private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt) => default; // 0x00000001808CAD60-0x00000001808CAEA0
		private object GetKeyFromBuffer(bool cooked) => default; // 0x00000001808CD9C0-0x00000001808CDD70
		private ConsoleKeyInfo ReadKeyInternal(out bool fresh) {
			fresh = default;
			return default;
		} // 0x00000001808CEB90-0x00000001808CEDA0
		private bool InputPending() => default; // 0x00000001808CE8E0-0x00000001808CE920
		private void QueueEcho(char c) {} // 0x00000001808CEA90-0x00000001808CEB90
		private void Echo(ConsoleKeyInfo key) {} // 0x00000001808CD4E0-0x00000001808CD6E0
		private void EchoFlush() {} // 0x00000001808CD490-0x00000001808CD4E0
		public int Read([In, Out] char[] dest, int index, int count) {
			dest = default;
			return default;
		} // 0x00000001808CF0B0-0x00000001808CF400
		public ConsoleKeyInfo ReadKey(bool intercept) => default; // 0x00000001808CEDA0-0x00000001808CEE50
		public string ReadLine() => default; // 0x00000001808CEE50-0x00000001808CEE60
		public string ReadToEnd() => default; // 0x00000001808CEE60-0x00000001808CEE70
		private string ReadUntilConditionInternal(bool haltOnNewLine) => default; // 0x00000001808CEE70-0x00000001808CF0B0
		public void SetCursorPosition(int left, int top) {} // 0x00000001808CF5A0-0x00000001808CF7B0
		private void CreateKeyMap() {} // 0x00000001808CAEA0-0x00000001808CD490
		private void InitKeys() {} // 0x00000001808CDE00-0x00000001808CDFD0
		private void AddStringMapping(TermInfoStrings s) {} // 0x00000001808CA9F0-0x00000001808CAA40
	}
}
