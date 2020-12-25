/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 4: System.dll - Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 2170-2964

namespace System
{
	public class UriBuilder // TypeDefIndex: 2282
	{
		// Fields
		private bool _changed; // 0x10
		private string _fragment; // 0x18
		private string _host; // 0x20
		private string _password; // 0x28
		private string _path; // 0x30
		private int _port; // 0x38
		private string _query; // 0x40
		private string _scheme; // 0x48
		private string _schemeDelimiter; // 0x50
		private Uri _uri; // 0x58
		private string _username; // 0x60
	
		// Properties
		public string Host { set {} } // 0x00000001809C99A0-0x00000001809C9A70
		public string Path { set {} } // 0x00000001809C9A70-0x00000001809C9BF0
		public string Query { set {} } // 0x00000001809C9BF0-0x00000001809C9C90
		public string Scheme { set {} } // 0x00000001809C9C90-0x00000001809C9EB0
		public Uri Uri { get => default; } // 0x00000001809C9890-0x00000001809C99A0 
	
		// Constructors
		public UriBuilder() {} // 0x00000001809C9760-0x00000001809C9890
		public UriBuilder(Uri uri) {} // 0x00000001809C95E0-0x00000001809C9760
	
		// Methods
		private void Init(Uri uri) {} // 0x00000001809C8B40-0x00000001809C8D10
		public override bool Equals(object rparam) => default; // 0x00000001809C8AA0-0x00000001809C8B10
		public override int GetHashCode() => default; // 0x00000001809C8B10-0x00000001809C8B40
		private void SetFieldsFromUri(Uri uri) {} // 0x00000001809C8D10-0x00000001809C8EC0
		public override string ToString() => default; // 0x00000001809C8EC0-0x00000001809C95E0
	}
}
