/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

// Image 52: PhotonVoice.dll - Assembly: PhotonVoice, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5360-5410

namespace Photon.Voice.Unity
{
	// [HelpURL] // 0x0000000180113010-0x0000000180113040
	public abstract class VoiceComponent : MonoBehaviour, ILoggableDependent // TypeDefIndex: 5387
	{
		// Fields
		private VoiceLogger logger; // 0x18
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		protected DebugLevel logLevel; // 0x20
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool ignoreGlobalLogLevel; // 0x21
	
		// Properties
		public VoiceLogger Logger { get; protected set; } // 0x0000000180F539D0-0x0000000180F53AE0 0x0000000180246D40-0x0000000180246D50
		public DebugLevel LogLevel { get; set; } // 0x0000000180F53990-0x0000000180F539D0 0x0000000180F53AE0-0x0000000180F53B20
		public bool IgnoreGlobalLogLevel { get; set; } // 0x0000000180468090-0x00000001804680A0 0x0000000180468120-0x0000000180468130
	
		// Constructors
		protected VoiceComponent() {} // 0x0000000180F44D80-0x0000000180F44D90
	
		// Methods
		protected virtual void Awake() {} // 0x0000000180F53890-0x0000000180F53990
	}
}
