/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800F1330-0x00000001800F1360
	internal class PlayerConnectionInternal : IPlayerEditorConnectionNative // TypeDefIndex: 3230
	{
		// Constructors
		public PlayerConnectionInternal() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		void IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId) {} // 0x000000018093E090-0x000000018093E1B0
		bool IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId) => default; // 0x000000018093E1B0-0x000000018093E2D0
		void IPlayerEditorConnectionNative.Poll() {} // 0x000000018093DEF0-0x000000018093DF20
		void IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) {} // 0x000000018093E020-0x000000018093E090
		void IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) {} // 0x000000018093E2D0-0x000000018093E340
		void IPlayerEditorConnectionNative.Initialize() {} // 0x000000018093DE90-0x000000018093DEC0
		bool IPlayerEditorConnectionNative.IsConnected() => default; // 0x000000018093DEC0-0x000000018093DEF0
		void IPlayerEditorConnectionNative.DisconnectAll() {} // 0x000000018093DE60-0x000000018093DE90
		[FreeFunction] // 0x00000001800F13D0-0x00000001800F1400
		private static bool IsConnected() => default; // 0x000000018093DEC0-0x000000018093DEF0
		[FreeFunction] // 0x00000001800F14A0-0x00000001800F14D0
		private static void Initialize() {} // 0x000000018093DE90-0x000000018093DEC0
		[FreeFunction] // 0x00000001800F1590-0x00000001800F15C0
		private static void RegisterInternal(string messageId) {} // 0x000000018093DF20-0x000000018093DF60
		[FreeFunction] // 0x00000001800F1670-0x00000001800F16A0
		private static void UnregisterInternal(string messageId) {} // 0x000000018093E340-0x000000018093E380
		[FreeFunction] // 0x00000001800F1740-0x00000001800F1770
		private static void SendMessage(string messageId, byte[] data, int playerId) {} // 0x000000018093DF60-0x000000018093DFC0
		[FreeFunction] // 0x00000001800F1840-0x00000001800F1870
		private static bool TrySendMessage(string messageId, byte[] data, int playerId) => default; // 0x000000018093DFC0-0x000000018093E020
		[FreeFunction] // 0x00000001800F1930-0x00000001800F1960
		private static void PollInternal() {} // 0x000000018093DEF0-0x000000018093DF20
		[FreeFunction] // 0x00000001800F1A60-0x00000001800F1A90
		private static void DisconnectAll() {} // 0x000000018093DE60-0x000000018093DE90
	}
}
