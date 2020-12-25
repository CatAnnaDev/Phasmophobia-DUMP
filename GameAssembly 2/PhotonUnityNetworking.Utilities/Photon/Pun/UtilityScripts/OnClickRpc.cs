/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 56: PhotonUnityNetworking.Utilities.dll - Assembly: PhotonUnityNetworking.Utilities, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5605-5662

namespace Photon.Pun.UtilityScripts
{
	public class OnClickRpc : MonoBehaviourPun, IPointerClickHandler // TypeDefIndex: 5634
	{
		// Fields
		public PointerEventData.InputButton Button; // 0x20
		public KeyCode ModifierKey; // 0x24
		public RpcTarget Target; // 0x28
		private Material originalMaterial; // 0x30
		private Color originalColor; // 0x38
		private bool isFlashing; // 0x48
	
		// Constructors
		public OnClickRpc() {} // 0x000000018026EAB0-0x000000018026EAC0
	
		// Methods
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData) {} // 0x0000000181279B80-0x0000000181279C50
		[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
		public void ClickRpc() {} // 0x0000000181279B10-0x0000000181279B80
		// [IteratorStateMachine] // 0x0000000180145F00-0x0000000180145F50
		public IEnumerator ClickFlash() => default; // 0x0000000181279AA0-0x0000000181279B10
	}
}
