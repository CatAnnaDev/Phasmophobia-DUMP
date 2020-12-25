/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 51: PhotonUnityNetworking.dll - Assembly: PhotonUnityNetworking, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5293-5359

namespace Photon.Pun
{
	public class PhotonTransformViewPositionControl // TypeDefIndex: 5349
	{
		// Fields
		private PhotonTransformViewPositionModel m_Model; // 0x10
		private float m_CurrentSpeed; // 0x18
		private double m_LastSerializeTime; // 0x20
		private Vector3 m_SynchronizedSpeed; // 0x28
		private float m_SynchronizedTurnSpeed; // 0x34
		private Vector3 m_NetworkPosition; // 0x38
		private Queue<Vector3> m_OldNetworkPositions; // 0x48
		private bool m_UpdatedPositionAfterOnSerialize; // 0x50
	
		// Constructors
		public PhotonTransformViewPositionControl() {} // Dummy constructor
		public PhotonTransformViewPositionControl(PhotonTransformViewPositionModel model) {} // 0x0000000181DC1940-0x0000000181DC1A10
	
		// Methods
		private Vector3 GetOldestStoredNetworkPosition() => default; // 0x0000000181DC10F0-0x0000000181DC1170
		public void SetSynchronizedValues(Vector3 speed, float turnSpeed) {} // 0x0000000181DC1440-0x0000000181DC1460
		public Vector3 UpdatePosition(Vector3 currentPosition) => default; // 0x0000000181DC1460-0x0000000181DC1940
		public Vector3 GetNetworkPosition() => default; // 0x00000001809AC210-0x00000001809AC230
		public Vector3 GetExtrapolatedPositionOffset() => default; // 0x0000000181DC0CB0-0x0000000181DC10F0
		public void OnPhotonSerializeView(Vector3 currentPosition, PhotonStream stream, PhotonMessageInfo info) {} // 0x0000000181DC1170-0x0000000181DC1330
		private void SerializeData(Vector3 currentPosition, PhotonStream stream, PhotonMessageInfo info) {} // 0x0000000181DC1330-0x0000000181DC1440
		private void DeserializeData(PhotonStream stream, PhotonMessageInfo info) {} // 0x0000000181DC0AC0-0x0000000181DC0CB0
	}
}
