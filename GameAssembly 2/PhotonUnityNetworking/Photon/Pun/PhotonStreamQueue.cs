/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 51: PhotonUnityNetworking.dll - Assembly: PhotonUnityNetworking, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5293-5359

namespace Photon.Pun
{
	public class PhotonStreamQueue // TypeDefIndex: 5315
	{
		// Fields
		private int m_SampleRate; // 0x10
		private int m_SampleCount; // 0x14
		private int m_ObjectsPerSample; // 0x18
		private float m_LastSampleTime; // 0x1C
		private int m_LastFrameCount; // 0x20
		private int m_NextObjectIndex; // 0x24
		private List<object> m_Objects; // 0x28
		private bool m_IsWriting; // 0x30
	
		// Constructors
		public PhotonStreamQueue() {} // Dummy constructor
		public PhotonStreamQueue(int sampleRate) {} // 0x0000000181DBEBB0-0x0000000181DBEC40
	
		// Methods
		private void BeginWritePackage() {} // 0x0000000181DBE300-0x0000000181DBE690
		public void Reset() {} // 0x0000000181DBE910-0x0000000181DBE970
		public void SendNext(object obj) {} // 0x0000000181DBE970-0x0000000181DBE9F0
		public bool HasQueuedObjects() => default; // 0x0000000181DBE870-0x0000000181DBE880
		public object ReceiveNext() => default; // 0x0000000181DBE880-0x0000000181DBE910
		public void Serialize(PhotonStream stream) {} // 0x0000000181DBE9F0-0x0000000181DBEBB0
		public void Deserialize(PhotonStream stream) {} // 0x0000000181DBE690-0x0000000181DBE870
	}
}
