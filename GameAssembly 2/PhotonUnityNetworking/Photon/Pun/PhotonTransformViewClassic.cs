/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 51: PhotonUnityNetworking.dll - Assembly: PhotonUnityNetworking, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5293-5359

namespace Photon.Pun
{
	// [AddComponentMenu] // 0x000000018010C810-0x000000018010C840
	public class PhotonTransformViewClassic : MonoBehaviourPun, IPunObservable // TypeDefIndex: 5345
	{
		// Fields
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public PhotonTransformViewPositionModel m_PositionModel; // 0x20
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public PhotonTransformViewRotationModel m_RotationModel; // 0x28
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public PhotonTransformViewScaleModel m_ScaleModel; // 0x30
		private PhotonTransformViewPositionControl m_PositionControl; // 0x38
		private PhotonTransformViewRotationControl m_RotationControl; // 0x40
		private PhotonTransformViewScaleControl m_ScaleControl; // 0x48
		private PhotonView m_PhotonView; // 0x50
		private bool m_ReceivedNetworkUpdate; // 0x58
		private bool m_firstTake; // 0x59
	
		// Constructors
		public PhotonTransformViewClassic() {} // 0x0000000181DC09B0-0x0000000181DC0AC0
	
		// Methods
		private void Awake() {} // 0x0000000181DBFC30-0x0000000181DBFE20
		private void OnEnable() {} // 0x0000000181DBFE20-0x0000000181DBFE30
		private void Update() {} // 0x0000000181DC0830-0x0000000181DC09B0
		private void UpdatePosition() {} // 0x0000000181DC0320-0x0000000181DC03F0
		private void UpdateRotation() {} // 0x0000000181DC03F0-0x0000000181DC05F0
		private void UpdateScale() {} // 0x0000000181DC05F0-0x0000000181DC0830
		public void SetSynchronizedValues(Vector3 speed, float turnSpeed) {} // 0x0000000181DC02F0-0x0000000181DC0320
		public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {} // 0x0000000181DBFE30-0x0000000181DC02F0
	}
}
