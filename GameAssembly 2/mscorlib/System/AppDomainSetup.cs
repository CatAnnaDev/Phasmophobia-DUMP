/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	// [ClassInterface] // 0x00000001800EEA40-0x00000001800EEA80
	// [ComVisible] // 0x00000001800EEA40-0x00000001800EEA80
	public sealed class AppDomainSetup // TypeDefIndex: 337
	{
		// Fields
		private string application_base; // 0x10
		private string application_name; // 0x18
		private string cache_path; // 0x20
		private string configuration_file; // 0x28
		private string dynamic_base; // 0x30
		private string license_file; // 0x38
		private string private_bin_path; // 0x40
		private string private_bin_path_probe; // 0x48
		private string shadow_copy_directories; // 0x50
		private string shadow_copy_files; // 0x58
		private bool publisher_policy; // 0x60
		private bool path_changed; // 0x61
		private int loader_optimization; // 0x64
		private bool disallow_binding_redirects; // 0x68
		private bool disallow_code_downloads; // 0x69
		private object _activationArguments; // 0x70
		private object domain_initializer; // 0x78
		private object application_trust; // 0x80
		private string[] domain_initializer_args; // 0x88
		private bool disallow_appbase_probe; // 0x90
		private byte[] configuration_bytes; // 0x98
		private byte[] serialized_non_primitives; // 0xA0
	
		// Properties
		public string ApplicationBase { get => default; } // 0x00000001807012C0-0x00000001807012D0 
		public string LicenseFile { get => default; } // 0x0000000180246FD0-0x0000000180246FE0 
	
		// Constructors
		public AppDomainSetup() {} // 0x00000001802466A0-0x00000001802466B0
		internal AppDomainSetup(AppDomainSetup setup) {} // 0x0000000180701150-0x00000001807012C0
	
		// Methods
		private static string GetAppBase(string appBase) => default; // 0x0000000180700E00-0x0000000180701150
	}
}
