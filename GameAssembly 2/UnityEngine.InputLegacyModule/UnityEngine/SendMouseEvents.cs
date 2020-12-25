/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting;

// Image 14: UnityEngine.InputLegacyModule.dll - Assembly: UnityEngine.InputLegacyModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3778-3786

namespace UnityEngine
{
	internal class SendMouseEvents // TypeDefIndex: 3785
	{
		// Fields
		private static bool s_MouseUsed; // 0x00
		private static readonly HitInfo[] m_LastHit; // 0x08
		private static readonly HitInfo[] m_MouseDownHit; // 0x10
		private static readonly HitInfo[] m_CurrentHit; // 0x18
		private static Camera[] m_Cameras; // 0x20
	
		// Nested types
		private struct HitInfo // TypeDefIndex: 3786
		{
			// Fields
			public GameObject target; // 0x00
			public Camera camera; // 0x08
	
			// Methods
			public void SendMessage(string name) {} // 0x000000018004EBC0-0x000000018004EC10
			public static implicit operator bool(HitInfo exists) => default; // 0x0000000180AF3C90-0x0000000180AF3D30
			public static bool Compare(HitInfo lhs, HitInfo rhs) => default; // 0x0000000180AF3BC0-0x0000000180AF3C90
		}
	
		// Constructors
		public SendMouseEvents() {} // Dummy constructor
		static SendMouseEvents() {} // 0x0000000180AF5DB0-0x0000000180AF5E90
	
		// Methods
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static void SetMouseMoved() {} // 0x0000000180AF5D50-0x0000000180AF5DB0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static void DoSendMouseEvents(int skipRTCameras) {} // 0x0000000180AF46B0-0x0000000180AF5370
		private static void SendEvents(int i, HitInfo hit) {} // 0x0000000180AF5370-0x0000000180AF5D50
	}
}
