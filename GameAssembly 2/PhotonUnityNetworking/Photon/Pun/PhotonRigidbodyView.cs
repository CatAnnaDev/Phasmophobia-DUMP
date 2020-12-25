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
	// [AddComponentMenu] // 0x000000018010C3B0-0x000000018010C430
	// [RequireComponent] // 0x000000018010C3B0-0x000000018010C430
	public class PhotonRigidbodyView : MonoBehaviourPun, IPunObservable // TypeDefIndex: 5343
	{
		// Fields
		private float m_Distance; // 0x20
		private float m_Angle; // 0x24
		private Rigidbody m_Body; // 0x28
		private Vector3 m_NetworkPosition; // 0x30
		private Quaternion m_NetworkRotation; // 0x3C
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public bool m_SynchronizeVelocity; // 0x4C
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public bool m_SynchronizeAngularVelocity; // 0x4D
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public bool m_TeleportEnabled; // 0x4E
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public float m_TeleportIfDistanceGreaterThan; // 0x50
	
		// Constructors
		public PhotonRigidbodyView() {} // 0x0000000181DBE2E0-0x0000000181DBE300
	
		// Methods
		public void Awake() {} // 0x0000000181DBD970-0x0000000181DBDA20
		public void FixedUpdate() {} // 0x0000000181DBDA20-0x0000000181DBDC90
		public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {} // 0x0000000181DBDC90-0x0000000181DBE2E0
	}
}
