/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AOT;
using Viveport.Internal.Arcade;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Viveport.Arcade
{
	internal class Session // TypeDefIndex: 7405
	{
		// Fields
		private static SessionCallback isReadyIl2cppCallback; // 0x00
		private static SessionCallback startIl2cppCallback; // 0x08
		private static SessionCallback stopIl2cppCallback; // 0x10
	
		// Nested types
		private class SessionHandler : BaseHandler // TypeDefIndex: 7406
		{
			// Fields
			private static SessionListener listener; // 0x00
	
			// Constructors
			public SessionHandler() {} // Dummy constructor
			public SessionHandler(SessionListener cb) {} // 0x0000000181B547F0-0x0000000181B54850
	
			// Methods
			public SessionCallback getIsReadyHandler() => default; // 0x0000000181B54850-0x0000000181B548D0
			protected override void IsReadyHandler(int code, string message) {} // 0x0000000181B53320-0x0000000181B539D0
			public SessionCallback getStartHandler() => default; // 0x0000000181B548D0-0x0000000181B54950
			protected override void StartHandler(int code, string message) {} // 0x0000000181B539D0-0x0000000181B540E0
			public SessionCallback getStopHandler() => default; // 0x0000000181B54950-0x0000000181B549D0
			protected override void StopHandler(int code, string message) {} // 0x0000000181B540E0-0x0000000181B547F0
		}
	
		private abstract class BaseHandler // TypeDefIndex: 7407
		{
			// Constructors
			protected BaseHandler() {} // 0x00000001802466A0-0x00000001802466B0
	
			// Methods
			protected abstract void IsReadyHandler(int code, string message);
			protected abstract void StartHandler(int code, string message);
			protected abstract void StopHandler(int code, string message);
		}
	
		public class SessionListener // TypeDefIndex: 7408
		{
			// Constructors
			public SessionListener() {} // 0x00000001802466A0-0x00000001802466B0
	
			// Methods
			public virtual void OnSuccess(string pchAppID) {} // 0x0000000180246DB0-0x0000000180246DC0
			public virtual void OnStartSuccess(string pchAppID, string pchGuid) {} // 0x0000000180246DB0-0x0000000180246DC0
			public virtual void OnStopSuccess(string pchAppID, string pchGuid) {} // 0x0000000180246DB0-0x0000000180246DC0
			public virtual void OnFailure(int nCode, string pchMessage) {} // 0x0000000180246DB0-0x0000000180246DC0
		}
	
		// Constructors
		public Session() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		// [MonoPInvokeCallback] // 0x0000000180132290-0x00000001801322E0
		private static void IsReadyIl2cppCallback(int errorCode, string message) {} // 0x0000000181B549D0-0x0000000181B54A30
		public static void IsReady(SessionListener listener) {} // 0x0000000181B54B50-0x0000000181B54DB0
		// [MonoPInvokeCallback] // 0x0000000180132310-0x0000000180132360
		private static void StartIl2cppCallback(int errorCode, string message) {} // 0x0000000181B54DB0-0x0000000181B54E10
		public static void Start(SessionListener listener) {} // 0x0000000181B54F30-0x0000000181B55190
		// [MonoPInvokeCallback] // 0x00000001801327D0-0x0000000180132820
		private static void StopIl2cppCallback(int errorCode, string message) {} // 0x0000000181B55190-0x0000000181B551F0
		public static void Stop(SessionListener listener) {} // 0x0000000181B55310-0x0000000181B55570
	}
}
