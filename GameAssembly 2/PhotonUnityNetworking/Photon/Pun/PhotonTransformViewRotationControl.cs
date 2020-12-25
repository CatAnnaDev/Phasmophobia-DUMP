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
	public class PhotonTransformViewRotationControl // TypeDefIndex: 5352
	{
		// Fields
		private PhotonTransformViewRotationModel m_Model; // 0x10
		private Quaternion m_NetworkRotation; // 0x18
	
		// Constructors
		public PhotonTransformViewRotationControl() {} // Dummy constructor
		public PhotonTransformViewRotationControl(PhotonTransformViewRotationModel model) {} // 0x000000018024B380-0x000000018024B3B0
	
		// Methods
		public Quaternion GetNetworkRotation() => default; // 0x00000001802A64F0-0x00000001802A6500
		public Quaternion GetRotation(Quaternion currentRotation) => default; // 0x0000000181DC1A50-0x0000000181DC1BF0
		public void OnPhotonSerializeView(Quaternion currentRotation, PhotonStream stream, PhotonMessageInfo info) {} // 0x0000000181DC1BF0-0x0000000181DC1CC0
	}
}
