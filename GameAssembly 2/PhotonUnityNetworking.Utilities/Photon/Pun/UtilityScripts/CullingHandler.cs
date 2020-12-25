/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

// Image 56: PhotonUnityNetworking.Utilities.dll - Assembly: PhotonUnityNetworking.Utilities, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5605-5662

namespace Photon.Pun.UtilityScripts
{
	// [RequireComponent] // 0x000000018013C110-0x000000018013C160
	public class CullingHandler : MonoBehaviour, IPunObservable // TypeDefIndex: 5611
	{
		// Fields
		private int orderIndex; // 0x18
		private CullArea cullArea; // 0x20
		private List<byte> previousActiveCells; // 0x28
		private List<byte> activeCells; // 0x30
		private PhotonView pView; // 0x38
		private Vector3 lastPosition; // 0x40
		private Vector3 currentPosition; // 0x4C
	
		// Constructors
		public CullingHandler() {} // 0x0000000180276E90-0x0000000180276EA0
	
		// Methods
		private void OnEnable() {} // 0x0000000181278060-0x0000000181278220
		private void Start() {} // 0x00000001812787E0-0x00000001812788E0
		private void Update() {} // 0x0000000181278B00-0x0000000181278C30
		private void OnGUI() {} // 0x0000000181278220-0x0000000181278620
		private bool HaveActiveCellsChanged() => default; // 0x0000000181277E10-0x0000000181278060
		private void UpdateInterestGroups() {} // 0x00000001812788E0-0x0000000181278B00
		public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {} // 0x0000000181278620-0x00000001812787E0
	}
}
