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
	public class OnClickDestroy : MonoBehaviourPun, IPointerClickHandler // TypeDefIndex: 5630
	{
		// Fields
		public PointerEventData.InputButton Button; // 0x20
		public KeyCode ModifierKey; // 0x24
		public bool DestroyByRpc; // 0x28
	
		// Constructors
		public OnClickDestroy() {} // 0x000000018026EAB0-0x000000018026EAC0
	
		// Methods
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData) {} // 0x0000000181279670-0x0000000181279780
		// [IteratorStateMachine] // 0x0000000180145770-0x00000001801457E0
		[PunRPC] // 0x0000000180145770-0x00000001801457E0
		public IEnumerator DestroyRpc() => default; // 0x0000000181279600-0x0000000181279670
	}
}
