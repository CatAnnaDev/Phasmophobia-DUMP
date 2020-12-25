/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

// Image 56: PhotonUnityNetworking.Utilities.dll - Assembly: PhotonUnityNetworking.Utilities, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5605-5662

namespace Photon.Pun.UtilityScripts
{
	// [RequireComponent] // 0x0000000180145210-0x0000000180145260
	public class SmoothSyncMovement : MonoBehaviourPun, IPunObservable // TypeDefIndex: 5627
	{
		// Fields
		public float SmoothingDelay; // 0x20
		private Vector3 correctPlayerPos; // 0x24
		private Quaternion correctPlayerRot; // 0x30
	
		// Constructors
		public SmoothSyncMovement() {} // 0x00000001812814A0-0x0000000181281550
	
		// Methods
		public void Awake() {} // 0x0000000181280ED0-0x00000001812810C0
		public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {} // 0x00000001812810C0-0x0000000181281250
		public void Update() {} // 0x0000000181281250-0x00000001812814A0
	}
}
