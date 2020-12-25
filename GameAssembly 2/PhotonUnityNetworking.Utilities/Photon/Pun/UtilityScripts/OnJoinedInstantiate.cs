/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.Serialization;

// Image 56: PhotonUnityNetworking.Utilities.dll - Assembly: PhotonUnityNetworking.Utilities, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5605-5662

namespace Photon.Pun.UtilityScripts
{
	public class OnJoinedInstantiate : MonoBehaviour, IMatchmakingCallbacks // TypeDefIndex: 5637
	{
		// Fields
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		private Transform SpawnPosition; // 0x18
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public SpawnSequence Sequence; // 0x20
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public List<Transform> SpawnPoints; // 0x28
		[HideInInspector] // 0x00000001801465F0-0x0000000180146640
		// [Tooltip] // 0x00000001801465F0-0x0000000180146640
		public bool UseRandomOffset; // 0x30
		// [FormerlySerializedAs] // 0x0000000180146740-0x00000001801467B0
		[HideInInspector] // 0x0000000180146740-0x00000001801467B0
		// [Tooltip] // 0x0000000180146740-0x00000001801467B0
		public float RandomOffset; // 0x34
		[HideInInspector] // 0x00000001801468B0-0x0000000180146900
		// [Tooltip] // 0x00000001801468B0-0x0000000180146900
		public bool ClampY; // 0x38
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public List<GameObject> PrefabsToInstantiate; // 0x40
		// [FormerlySerializedAs] // 0x0000000180146AD0-0x0000000180146B10
		[HideInInspector] // 0x0000000180146AD0-0x0000000180146B10
		public bool AutoSpawnObjects; // 0x48
		public Stack<GameObject> SpawnedObjects; // 0x50
		protected int spawnedAsActorId; // 0x58
		protected int lastUsedSpawnPointIndex; // 0x5C
	
		// Nested types
		public enum SpawnSequence // TypeDefIndex: 5638
		{
			Connection = 0,
			Random = 1,
			RoundRobin = 2
		}
	
		// Constructors
		public OnJoinedInstantiate() {} // 0x000000018127A550-0x000000018127A670
	
		// Methods
		public virtual void OnEnable() {} // 0x000000018127A240-0x000000018127A2A0
		public virtual void OnDisable() {} // 0x000000018127A1E0-0x000000018127A240
		public virtual void OnJoinedRoom() {} // 0x000000018127A2A0-0x000000018127A320
		public virtual void SpawnObjects() {} // 0x000000018127A320-0x000000018127A550
		public virtual void DespawnObjects(bool localOnly) {} // 0x0000000181279C80-0x0000000181279D90
		public virtual void OnFriendListUpdate(List<FriendInfo> friendList) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnCreatedRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnCreateRoomFailed(short returnCode, string message) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnJoinRoomFailed(short returnCode, string message) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnJoinRandomFailed(short returnCode, string message) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnLeftRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void GetSpawnPoint(out Vector3 spawnPos, out Quaternion spawnRot) {
			spawnPos = default;
			spawnRot = default;
		} // 0x0000000181279EA0-0x000000018127A0B0
		protected virtual Transform GetSpawnPoint() => default; // 0x000000018127A0B0-0x000000018127A1E0
		protected virtual Vector3 GetRandomOffset() => default; // 0x0000000181279D90-0x0000000181279EA0
	}
}
