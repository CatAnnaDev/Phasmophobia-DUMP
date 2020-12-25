/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;

// Image 51: PhotonUnityNetworking.dll - Assembly: PhotonUnityNetworking, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5293-5359

namespace Photon.Pun
{
	public class PhotonStream // TypeDefIndex: 5325
	{
		// Fields
		private List<object> writeData; // 0x10
		private object[] readData; // 0x18
		private int currentItem; // 0x20
	
		// Properties
		public bool IsWriting { get; private set; } // 0x00000001802932C0-0x00000001802932D0 0x0000000180457830-0x0000000180457840
		public bool IsReading { get => default; } // 0x0000000181DBFC20-0x0000000181DBFC30 
		public int Count { get => default; } // 0x0000000181DBFBD0-0x0000000181DBFC20 
	
		// Constructors
		public PhotonStream() {} // Dummy constructor
		public PhotonStream(bool write, object[] incomingData) {} // 0x0000000181DBFB80-0x0000000181DBFBD0
	
		// Methods
		public void SetReadStream(object[] incomingData, int pos = 0 /* Metadata: 0x0064F752 */) {} // 0x0000000181DBF950-0x0000000181DBF980
		internal void SetWriteStream(List<object> newWriteData, int pos = 0 /* Metadata: 0x0064F756 */) {} // 0x0000000181DBF980-0x0000000181DBFB20
		internal List<object> GetWriteStream() => default; // 0x0000000180248E10-0x0000000180248E20
		[Obsolete] // 0x000000018010A820-0x000000018010A850
		internal void ResetWriteStream() {} // 0x0000000181DBEE00-0x0000000181DBEE50
		public object ReceiveNext() => default; // 0x0000000181DBED60-0x0000000181DBEE00
		public object PeekNext() => default; // 0x0000000181DBECC0-0x0000000181DBED60
		public void SendNext(object obj) {} // 0x0000000181DBEE50-0x0000000181DBEEE0
		[Obsolete] // 0x000000018010A940-0x000000018010A970
		public bool CopyToListAndClear(List<object> target) => default; // 0x0000000181DBEC40-0x0000000181DBECC0
		public object[] ToArray() => default; // 0x0000000181DBFB20-0x0000000181DBFB80
		public void Serialize(ref bool myBool) {} // 0x0000000181DBEEE0-0x0000000181DBEFE0
		public void Serialize(ref int myInt) {} // 0x0000000181DBF0E0-0x0000000181DBF1E0
		public void Serialize(ref string value) {} // 0x0000000181DBF3F0-0x0000000181DBF4E0
		public void Serialize(ref char value) {} // 0x0000000181DBF850-0x0000000181DBF950
		public void Serialize(ref short value) {} // 0x0000000181DBF5E0-0x0000000181DBF6E0
		public void Serialize(ref float obj) {} // 0x0000000181DBF2F0-0x0000000181DBF3F0
		public void Serialize(ref Photon.Realtime.Player obj) {} // 0x0000000181DBF6E0-0x0000000181DBF850
		public void Serialize(ref Vector3 obj) {} // 0x0000000181DBF1E0-0x0000000181DBF2F0
		public void Serialize(ref Vector2 obj) {} // 0x0000000181DBEFE0-0x0000000181DBF0E0
		public void Serialize(ref Quaternion obj) {} // 0x0000000181DBF4E0-0x0000000181DBF5E0
	}
}
