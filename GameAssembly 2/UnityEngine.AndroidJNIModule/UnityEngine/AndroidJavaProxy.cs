/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 21: UnityEngine.AndroidJNIModule.dll - Assembly: UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3877-3890

namespace UnityEngine
{
	public class AndroidJavaProxy // TypeDefIndex: 3882
	{
		// Fields
		public readonly AndroidJavaClass javaInterface; // 0x10
		internal IntPtr proxyObject; // 0x18
		private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x00
		private static readonly IntPtr s_HashCodeMethodID; // 0x08
	
		// Constructors
		public AndroidJavaProxy() {} // Dummy constructor
		public AndroidJavaProxy(string javaInterface) {} // 0x0000000180AB6D20-0x0000000180AB6DC0
		public AndroidJavaProxy(AndroidJavaClass javaInterface) {} // 0x0000000180AB6DC0-0x0000000180AB6E20
		static AndroidJavaProxy() {} // 0x0000000180AB6C50-0x0000000180AB6D20
	
		// Methods
		~AndroidJavaProxy() {} // 0x0000000180AB60A0-0x0000000180AB6180
		public virtual AndroidJavaObject Invoke(string methodName, object[] args) => default; // 0x0000000180AB64E0-0x0000000180AB6C50
		public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) => default; // 0x0000000180AB62F0-0x0000000180AB64E0
		internal AndroidJavaObject GetProxyObject() => default; // 0x0000000180AB6180-0x0000000180AB61E0
		internal IntPtr GetRawProxy() => default; // 0x0000000180AB61E0-0x0000000180AB62F0
	}
}
