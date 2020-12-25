/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	// [ClassInterface] // 0x00000001800EEA40-0x00000001800EEA80
	// [ComVisible] // 0x00000001800EEA40-0x00000001800EEA80
	public sealed class AppDomain : MarshalByRefObject // TypeDefIndex: 328
	{
		// Fields
		private IntPtr _mono_app_domain; // 0x18
		private static string _process_guid; // 0x00
		[ThreadStatic] // 0x00000001800D4E50-0x00000001800D4E60
		private static Dictionary<string, object> type_resolve_in_progress; // 0x80000000
		[ThreadStatic] // 0x00000001800D4E50-0x00000001800D4E60
		private static Dictionary<string, object> assembly_resolve_in_progress; // 0x80000008
		[ThreadStatic] // 0x00000001800D4E50-0x00000001800D4E60
		private static Dictionary<string, object> assembly_resolve_in_progress_refonly; // 0x80000010
		private object _evidence; // 0x20
		private object _granted; // 0x28
		private int _principalPolicy; // 0x30
		[ThreadStatic] // 0x00000001800D4E50-0x00000001800D4E60
		private static object _principal; // 0x80000018
		private static AppDomain default_domain; // 0x08
		private object _domain_manager; // 0x78
		private object _activation; // 0x88
		private object _applicationIdentity; // 0x90
		private List<string> compatibility_switch; // 0x98
	
		// Properties
		public AppDomainSetup SetupInformation { get => default; } // 0x00000001807025E0-0x0000000180702640 
		public static AppDomain CurrentDomain { get => default; } // 0x00000001807025B0-0x00000001807025C0 
	
		// Events
		public event EventHandler DomainUnload;
		public event EventHandler ProcessExit;
		public event UnhandledExceptionEventHandler UnhandledException;
	
		// Constructors
		private AppDomain() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		private AppDomainSetup getSetup() => default; // 0x00000001807025D0-0x00000001807025E0
		private string getFriendlyName() => default; // 0x00000001807023C0-0x00000001807023D0
		private static AppDomain getCurDomain() => default; // 0x00000001807025B0-0x00000001807025C0
		private Assembly[] GetAssemblies(bool refOnly) => default; // 0x0000000180701B30-0x0000000180701B40
		public Assembly[] GetAssemblies() => default; // 0x0000000180701B40-0x0000000180701B50
		public object GetData(string name) => default; // 0x0000000180701B60-0x0000000180701B70
		public override object InitializeLifetimeService() => default; // 0x0000000180246C90-0x0000000180246CA0
		internal Assembly LoadAssembly(string assemblyRef, System.Security.Policy.Evidence securityEvidence, bool refOnly) => default; // 0x0000000180701F60-0x0000000180701F70
		internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError) => default; // 0x0000000180701F70-0x0000000180702070
		public Assembly Load(string assemblyString) => default; // 0x0000000180702070-0x0000000180702170
		internal Assembly Load(string assemblyString, System.Security.Policy.Evidence assemblySecurity, bool refonly) => default; // 0x0000000180702170-0x0000000180702290
		private static AppDomain InternalSetDomainByID(int domain_id) => default; // 0x0000000180701D40-0x0000000180701D50
		private static AppDomain InternalSetDomain(AppDomain context) => default; // 0x0000000180701D50-0x0000000180701D60
		internal static void InternalPushDomainRefByID(int domain_id) {} // 0x0000000180701D20-0x0000000180701D30
		internal static void InternalPopDomainRef() {} // 0x0000000180701D10-0x0000000180701D20
		internal static Context InternalSetContext(Context context) => default; // 0x0000000180701D30-0x0000000180701D40
		internal static Context InternalGetContext() => default; // 0x0000000180701CF0-0x0000000180701D00
		internal static Context InternalGetDefaultContext() => default; // 0x0000000180701CF0-0x0000000180701D00
		internal static string InternalGetProcessGuid(string newguid) => default; // 0x0000000180701D00-0x0000000180701D10
		internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) => default; // 0x0000000180701D60-0x0000000180701F40
		internal static string GetProcessGuid() => default; // 0x0000000180701C30-0x0000000180701CF0
		private static bool InternalIsFinalizingForUnload(int domain_id) => default; // 0x0000000180289B70-0x0000000180289B80
		public bool IsFinalizingForUnload() => default; // 0x0000000180701F40-0x0000000180701F60
		private int getDomainID() => default; // 0x00000001807025C0-0x00000001807025D0
		[Obsolete] // 0x00000001800F05D0-0x00000001800F0600
		public static int GetCurrentThreadId() => default; // 0x0000000180701B50-0x0000000180701B60
		public override string ToString() => default; // 0x00000001807023C0-0x00000001807023D0
		private void DoAssemblyLoad(Assembly assembly) {} // 0x0000000180701330-0x0000000180701410
		private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) => default; // 0x0000000180701410-0x0000000180701710
		internal Assembly DoTypeResolve(object name_or_tb) => default; // 0x0000000180701860-0x0000000180701B30
		internal Assembly DoResourceResolve(string name, Assembly requesting) => default; // 0x0000000180701730-0x0000000180701860
		private void DoDomainUnload() {} // 0x0000000180701710-0x0000000180701730
		internal byte[] GetMarshalledDomainObjRef() => default; // 0x0000000180701B70-0x0000000180701C30
		internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) {
			arrResponse = default;
			cadMrm = default;
		} // 0x0000000180702290-0x00000001807023C0
	}
}
