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
	public class PhotonTransformViewScaleControl // TypeDefIndex: 5355
	{
		// Fields
		private PhotonTransformViewScaleModel m_Model; // 0x10
		private Vector3 m_NetworkScale; // 0x18
	
		// Constructors
		public PhotonTransformViewScaleControl() {} // Dummy constructor
		public PhotonTransformViewScaleControl(PhotonTransformViewScaleModel model) {} // 0x0000000181DC1FC0-0x0000000181DC2050
	
		// Methods
		public Vector3 GetNetworkScale() => default; // 0x00000001812E19E0-0x00000001812E1A00
		public Vector3 GetScale(Vector3 currentScale) => default; // 0x0000000181DC1CE0-0x0000000181DC1EB0
		public void OnPhotonSerializeView(Vector3 currentScale, PhotonStream stream, PhotonMessageInfo info) {} // 0x0000000181DC1EB0-0x0000000181DC1FC0
	}
}
