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
	public class AndroidJavaObject : IDisposable // TypeDefIndex: 3883
	{
		// Fields
		private static bool enableDebugPrints; // 0x00
		internal GlobalJavaObjectRef m_jobject; // 0x10
		internal GlobalJavaObjectRef m_jclass; // 0x18
	
		// Constructors
		public AndroidJavaObject(string className, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180AB6060-0x0000000180AB60A0
		internal AndroidJavaObject(IntPtr jobject) {} // 0x0000000180AB5F10-0x0000000180AB6060
		internal AndroidJavaObject() {} // 0x00000001802466A0-0x00000001802466B0
		static AndroidJavaObject() {} // 0x0000000180AB5ED0-0x0000000180AB5F10
	
		// Methods
		public void Dispose() {} // 0x0000000180AB59C0-0x0000000180AB5A30
		public void Call(string methodName, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180AB5920-0x0000000180AB5930
		public FieldType GetStatic<FieldType>(string fieldName) => default;
		public IntPtr GetRawObject() => default; // 0x00000001805F7310-0x00000001805F7330
		public IntPtr GetRawClass() => default; // 0x00000001803EB7A0-0x00000001803EB7C0
		public ReturnType Call<ReturnType>(string methodName, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) => default;
		public ReturnType CallStatic<ReturnType>(string methodName, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) => default;
		protected void DebugPrint(string msg) {} // 0x0000000180AB5930-0x0000000180AB59C0
		private void _AndroidJavaObject(string className, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180AB5B30-0x0000000180AB5D80
		~AndroidJavaObject() {} // 0x0000000180AB5A90-0x0000000180AB5B30
		protected virtual void Dispose(bool disposing) {} // 0x0000000180AB5A30-0x0000000180AB5A90
		protected void _Call(string methodName, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180AB5D80-0x0000000180AB5ED0
		protected ReturnType _Call<ReturnType>(string methodName, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) => default;
		protected ReturnType _CallStatic<ReturnType>(string methodName, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) => default;
		protected FieldType _GetStatic<FieldType>(string fieldName) => default;
		internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) => default; // 0x0000000180AB57F0-0x0000000180AB5920
		internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) => default; // 0x0000000180AB56C0-0x0000000180AB57F0
		protected IntPtr _GetRawObject() => default; // 0x00000001805F7310-0x00000001805F7330
		protected IntPtr _GetRawClass() => default; // 0x00000001803EB7A0-0x00000001803EB7C0
	}
}
