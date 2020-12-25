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
	// [AddComponentMenu] // 0x000000018010C710-0x000000018010C770
	// [HelpURL] // 0x000000018010C710-0x000000018010C770
	public class PhotonTransformView : MonoBehaviourPun, IPunObservable // TypeDefIndex: 5344
	{
		// Fields
		private float m_Distance; // 0x20
		private float m_Angle; // 0x24
		private Vector3 m_Direction; // 0x28
		private Vector3 m_NetworkPosition; // 0x34
		private Vector3 m_StoredPosition; // 0x40
		private Quaternion m_NetworkRotation; // 0x4C
		public bool m_SynchronizePosition; // 0x5C
		public bool m_SynchronizeRotation; // 0x5D
		public bool m_SynchronizeScale; // 0x5E
		private bool m_firstTake; // 0x5F
	
		// Constructors
		public PhotonTransformView() {} // 0x0000000181DC2A20-0x0000000181DC2A30
	
		// Methods
		public void Awake() {} // 0x0000000181DC2050-0x0000000181DC2120
		private void OnEnable() {} // 0x0000000181DC2120-0x0000000181DC2130
		public void Update() {} // 0x0000000181DC2790-0x0000000181DC2A20
		public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {} // 0x0000000181DC2130-0x0000000181DC2790
	}
}
