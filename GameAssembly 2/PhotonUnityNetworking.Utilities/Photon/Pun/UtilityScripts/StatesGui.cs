/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;

// Image 56: PhotonUnityNetworking.Utilities.dll - Assembly: PhotonUnityNetworking.Utilities, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5605-5662

namespace Photon.Pun.UtilityScripts
{
	public class StatesGui : MonoBehaviour // TypeDefIndex: 5614
	{
		// Fields
		public Rect GuiOffset; // 0x18
		public bool DontDestroy; // 0x28
		public bool ServerTimestamp; // 0x29
		public bool DetailedConnection; // 0x2A
		public bool Server; // 0x2B
		public bool AppVersion; // 0x2C
		public bool UserId; // 0x2D
		public bool Room; // 0x2E
		public bool RoomProps; // 0x2F
		public bool EventsIn; // 0x30
		public bool LocalPlayer; // 0x31
		public bool PlayerProps; // 0x32
		public bool Others; // 0x33
		public bool Buttons; // 0x34
		public bool ExpectedUsers; // 0x35
		private Rect GuiRect; // 0x38
		private static StatesGui Instance; // 0x00
		private float native_width; // 0x48
		private float native_height; // 0x4C
	
		// Constructors
		public StatesGui() {} // 0x0000000181282EC0-0x0000000181282F30
	
		// Methods
		private void Awake() {} // 0x0000000181281550-0x00000001812816C0
		private void OnDisable() {} // 0x00000001812816C0-0x0000000181281760
		private void OnGUI() {} // 0x0000000181281760-0x00000001812828E0
		private string PlayerToString(Photon.Realtime.Player player) => default; // 0x00000001812828E0-0x0000000181282EC0
	}
}
