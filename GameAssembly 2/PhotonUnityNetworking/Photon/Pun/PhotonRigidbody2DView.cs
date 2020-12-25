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
	// [AddComponentMenu] // 0x000000018010C230-0x000000018010C2B0
	// [RequireComponent] // 0x000000018010C230-0x000000018010C2B0
	public class PhotonRigidbody2DView : MonoBehaviourPun, IPunObservable // TypeDefIndex: 5342
	{
		// Fields
		private float m_Distance; // 0x20
		private float m_Angle; // 0x24
		private Rigidbody2D m_Body; // 0x28
		private Vector2 m_NetworkPosition; // 0x30
		private float m_NetworkRotation; // 0x38
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public bool m_SynchronizeVelocity; // 0x3C
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public bool m_SynchronizeAngularVelocity; // 0x3D
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public bool m_TeleportEnabled; // 0x3E
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public float m_TeleportIfDistanceGreaterThan; // 0x40
	
		// Constructors
		public PhotonRigidbody2DView() {} // 0x00000001805B95C0-0x00000001805B9620
	
		// Methods
		public void Awake() {} // 0x00000001805B8C70-0x00000001805B8CC0
		public void FixedUpdate() {} // 0x00000001805B8CC0-0x00000001805B8F40
		public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {} // 0x00000001805B8F40-0x00000001805B95C0
	}
}
