/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public static class Environment // TypeDefIndex: 331
	{
		// Fields
		private const int mono_corlib_version = 1051100001; // Metadata: 0x00630242
		private static string nl; // 0x00
		private static OperatingSystem os; // 0x08
	
		// Properties
		public static string CurrentDirectory { get; } // 0x0000000180319330-0x0000000180319340 
		public static int CurrentManagedThreadId { get; } // 0x0000000180319340-0x0000000180319370 
		public static bool HasShutdownStarted { get; } // 0x0000000180319370-0x0000000180319380 
		public static string MachineName { get; } // 0x00000001803193C0-0x00000001803193D0 
		public static string NewLine { get; } // 0x00000001803193D0-0x0000000180319440 
		private static PlatformID Platform { get; } // 0x00000001803196C0-0x00000001803196D0 
		public static OperatingSystem OSVersion { get; } // 0x0000000180319440-0x00000001803196C0 
		public static string StackTrace { get; } // 0x00000001803196E0-0x0000000180319750 
		public static int TickCount { get; } // 0x0000000180319750-0x0000000180319760 
		public static string UserDomainName { get; } // 0x00000001803193C0-0x00000001803193D0 
		public static string UserName { get; } // 0x0000000180319760-0x0000000180319770 
		public static bool Is64BitProcess { get; } // 0x0000000180319380-0x00000001803193A0 
		public static int ProcessorCount { get; } // 0x00000001803196D0-0x00000001803196E0 
		internal static bool IsRunningOnWindows { get; } // 0x00000001803193A0-0x00000001803193C0 
	
		// Nested types
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public enum SpecialFolder // TypeDefIndex: 332
		{
			Desktop = 0,
			Programs = 2,
			MyDocuments = 5,
			Personal = 5,
			Favorites = 6,
			Startup = 7,
			Recent = 8,
			SendTo = 9,
			StartMenu = 11,
			MyMusic = 13,
			MyVideos = 14,
			DesktopDirectory = 16,
			MyComputer = 17,
			NetworkShortcuts = 19,
			Fonts = 20,
			Templates = 21,
			CommonStartMenu = 22,
			CommonPrograms = 23,
			CommonStartup = 24,
			CommonDesktopDirectory = 25,
			ApplicationData = 26,
			PrinterShortcuts = 27,
			LocalApplicationData = 28,
			InternetCache = 32,
			Cookies = 33,
			History = 34,
			CommonApplicationData = 35,
			Windows = 36,
			System = 37,
			ProgramFiles = 38,
			MyPictures = 39,
			UserProfile = 40,
			SystemX86 = 41,
			ProgramFilesX86 = 42,
			CommonProgramFiles = 43,
			CommonProgramFilesX86 = 44,
			CommonTemplates = 45,
			CommonDocuments = 46,
			CommonAdminTools = 47,
			AdminTools = 48,
			CommonMusic = 53,
			CommonPictures = 54,
			CommonVideos = 55,
			Resources = 56,
			LocalizedResources = 57,
			CommonOemLinks = 58,
			CDBurning = 59
		}
	
		public enum SpecialFolderOption // TypeDefIndex: 333
		{
			None = 0,
			DoNotVerify = 16384,
			Create = 32768
		}
	
		// Methods
		internal static string GetResourceString(string key) => default; // 0x00000001802A78B0-0x00000001802A78C0
		internal static string GetResourceString(string key, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] values) => default; // 0x0000000180318A10-0x0000000180318A80
		internal static string GetResourceStringEncodingName(int codePage) => default; // 0x0000000180318910-0x0000000180318A10
		private static string GetNewLine() => default; // 0x00000001803188E0-0x00000001803188F0
		internal static string GetOSVersionString() => default; // 0x00000001803188F0-0x0000000180318900
		internal static Version CreateVersionFromString(string info) => default; // 0x0000000180318100-0x00000001803182B0
		public static void Exit(int exitCode) {} // 0x00000001803182B0-0x00000001803182C0
		public static string ExpandEnvironmentVariables(string name) => default; // 0x00000001803182C0-0x0000000180318670
		public static string[] GetCommandLineArgs() => default; // 0x0000000180318720-0x0000000180318730
		internal static string internalGetEnvironmentVariable_native(IntPtr variable) => default; // 0x0000000180319850-0x0000000180319860
		internal static string internalGetEnvironmentVariable(string variable) => default; // 0x0000000180319770-0x0000000180319850
		public static string GetEnvironmentVariable(string variable) => default; // 0x0000000180318740-0x0000000180318750
		private static Hashtable GetEnvironmentVariablesNoCase() => default; // 0x0000000180318750-0x0000000180318840
		public static string GetFolderPath(SpecialFolder folder) => default; // 0x0000000180318840-0x0000000180318880
		private static string GetWindowsFolderPath(int folder) => default; // 0x0000000180318B10-0x0000000180318B20
		public static string GetFolderPath(SpecialFolder folder, SpecialFolderOption option) => default; // 0x0000000180318880-0x00000001803188D0
		private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback) => default; // 0x0000000180318B20-0x0000000180318EB0
		internal static string UnixGetFolderPath(SpecialFolder folder, SpecialFolderOption option) => default; // 0x0000000180318EB0-0x0000000180319330
		public static void FailFast(string message) {} // 0x0000000180318670-0x00000001803186C0
		public static void FailFast(string message, Exception exception) {} // 0x00000001803186C0-0x0000000180318720
		private static string[] GetEnvironmentVariableNames() => default; // 0x0000000180318730-0x0000000180318740
		internal static string GetMachineConfigPath() => default; // 0x00000001803188D0-0x00000001803188E0
		internal static string internalGetHome() => default; // 0x0000000180319860-0x0000000180319870
		internal static int GetPageSize() => default; // 0x0000000180318900-0x0000000180318910
		internal static string GetStackTrace(Exception e, bool needFileInfo) => default; // 0x0000000180318A80-0x0000000180318B10
	}
}
