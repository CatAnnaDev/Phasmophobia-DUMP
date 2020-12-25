/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AOT;
using Viveport.Internal;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Viveport
{
	public class Api // TypeDefIndex: 7351
	{
		// Fields
		internal static readonly List<GetLicenseCallback> InternalGetLicenseCallbacks; // 0x00
		internal static readonly List<StatusCallback> InternalStatusCallbacks; // 0x08
		internal static readonly List<QueryRuntimeModeCallback> InternalQueryRunTimeCallbacks; // 0x10
		internal static readonly List<StatusCallback2> InternalStatusCallback2s; // 0x18
		internal static readonly List<LicenseChecker> InternalLicenseCheckers; // 0x20
		private static StatusCallback initIl2cppCallback; // 0x28
		private static StatusCallback shutdownIl2cppCallback; // 0x30
		private static QueryRuntimeModeCallback queryRuntimeModeIl2cppCallback; // 0x38
		private static readonly string VERSION; // 0x40
		private static string _appId; // 0x48
		private static string _appKey; // 0x50
	
		// Nested types
		public abstract class LicenseChecker // TypeDefIndex: 7352
		{
			// Constructors
			protected LicenseChecker() {} // 0x00000001802466A0-0x00000001802466B0
	
			// Methods
			public abstract void OnSuccess(long issueTime, long expirationTime, int latestVersion, bool updateRequired);
			public abstract void OnFailure(int errorCode, string errorMessage);
		}
	
		// Constructors
		public Api() {} // 0x00000001802466A0-0x00000001802466B0
		static Api() {} // 0x0000000180EE63D0-0x0000000180EE6580
	
		// Methods
		public static void GetLicense(LicenseChecker checker, string appId, string appKey) {} // 0x0000000180EE5720-0x0000000180EE5980
		// [MonoPInvokeCallback] // 0x0000000180125D20-0x0000000180125D70
		private static void InitIl2cppCallback(int errorCode) {} // 0x0000000180EE5980-0x0000000180EE59F0
		public static int Init(StatusCallback callback, string appId) => default; // 0x0000000180EE59F0-0x0000000180EE5BF0
		// [MonoPInvokeCallback] // 0x0000000180125E90-0x0000000180125EE0
		private static void ShutdownIl2cppCallback(int errorCode) {} // 0x0000000180EE5E40-0x0000000180EE5EB0
		public static int Shutdown(StatusCallback callback) => default; // 0x0000000180EE5EB0-0x0000000180EE6080
		public static string Version() => default; // 0x0000000180EE6220-0x0000000180EE63D0
		// [MonoPInvokeCallback] // 0x0000000180126050-0x00000001801260A0
		private static void QueryRuntimeModeIl2cppCallback(int errorCode, int mode) {} // 0x0000000180EE5BF0-0x0000000180EE5C70
		public static void QueryRuntimeMode(QueryRuntimeModeCallback callback) {} // 0x0000000180EE5C70-0x0000000180EE5E40
		// [MonoPInvokeCallback] // 0x0000000180126200-0x0000000180126250
		private static void GetLicenseHandler(string message, string signature) {} // 0x0000000180EE4F30-0x0000000180EE5720
		private static bool VerifyMessage(string appId, string appKey, string message, string signature) => default; // 0x0000000180EE6080-0x0000000180EE6220
	}
}
