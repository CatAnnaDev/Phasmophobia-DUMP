/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 56: PhotonUnityNetworking.Utilities.dll - Assembly: PhotonUnityNetworking.Utilities, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5605-5662

namespace Photon.Pun.UtilityScripts
{
	public class OnClickInstantiate : MonoBehaviour, IPointerClickHandler // TypeDefIndex: 5632
	{
		// Fields
		public PointerEventData.InputButton Button; // 0x18
		public KeyCode ModifierKey; // 0x1C
		public GameObject Prefab; // 0x20
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private InstantiateOption InstantiateType; // 0x28
	
		// Nested types
		public enum InstantiateOption // TypeDefIndex: 5633
		{
			Mine = 0,
			Scene = 1
		}
	
		// Constructors
		public OnClickInstantiate() {} // 0x0000000180276E90-0x0000000180276EA0
	
		// Methods
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData) {} // 0x0000000181279780-0x0000000181279AA0
	}
}
