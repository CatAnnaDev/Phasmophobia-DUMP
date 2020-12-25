/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Voice.Unity;
using UnityEngine;

// Image 52: PhotonVoice.dll - Assembly: PhotonVoice, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5360-5410

namespace Photon.Voice.Unity.UtilityScripts
{
	// [RequireComponent] // 0x0000000180116850-0x00000001801168A0
	public class PhotonVoiceLagSimulationGui : MonoBehaviour // TypeDefIndex: 5397
	{
		// Fields
		private VoiceConnection voiceConnection; // 0x18
		private Rect windowRect; // 0x20
		private int windowId; // 0x30
		private bool visible; // 0x34
		private PhotonPeer peer; // 0x38
		private float debugLostPercent; // 0x40
	
		// Constructors
		public PhotonVoiceLagSimulationGui() {} // 0x0000000180F3BE80-0x0000000180F3BEF0
	
		// Methods
		public void OnEnable() {} // 0x0000000180F3BB60-0x0000000180F3BD90
		private void OnGUI() {} // 0x0000000180F3BD90-0x0000000180F3BE80
		private void NetSimHasNoPeerWindow(int windowId) {} // 0x0000000180F3B580-0x0000000180F3B5D0
		private void NetSimWindow(int windowId) {} // 0x0000000180F3B5D0-0x0000000180F3BB60
	}
}
