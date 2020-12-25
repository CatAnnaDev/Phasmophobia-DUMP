/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;

// Image 51: PhotonUnityNetworking.dll - Assembly: PhotonUnityNetworking, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5293-5359

namespace Photon.Pun
{
	public struct InstantiateParameters // TypeDefIndex: 5310
	{
		// Fields
		public int[] viewIDs; // 0x00
		public byte objLevelPrefix; // 0x08
		public object[] data; // 0x10
		public byte group; // 0x18
		public Quaternion rotation; // 0x1C
		public Vector3 position; // 0x2C
		public string prefabName; // 0x38
		public Photon.Realtime.Player creator; // 0x40
		public int timestamp; // 0x48
	
		// Constructors
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, Photon.Realtime.Player creator, int timestamp) {
			this.viewIDs = default;
			this.objLevelPrefix = default;
			this.data = default;
			this.group = default;
			this.rotation = default;
			this.position = default;
			this.prefabName = default;
			this.creator = default;
			this.timestamp = default;
		} // 0x000000018001E3D0-0x000000018001E490
	}
}
