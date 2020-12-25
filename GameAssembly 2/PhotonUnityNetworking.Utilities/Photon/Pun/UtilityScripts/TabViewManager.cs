/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 56: PhotonUnityNetworking.Utilities.dll - Assembly: PhotonUnityNetworking.Utilities, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5605-5662

namespace Photon.Pun.UtilityScripts
{
	public class TabViewManager : MonoBehaviour // TypeDefIndex: 5649
	{
		// Fields
		public ToggleGroup ToggleGroup; // 0x18
		public Tab[] Tabs; // 0x20
		public TabChangeEvent OnTabChanged; // 0x28
		protected Tab CurrentTab; // 0x30
		private Dictionary<Toggle, Tab> Tab_lut; // 0x38
	
		// Nested types
		[Serializable]
		public class TabChangeEvent : UnityEvent<string> // TypeDefIndex: 5650
		{
			// Constructors
			public TabChangeEvent() {} // 0x0000000181282F30-0x0000000181282F70
		}
	
		[Serializable]
		public class Tab // TypeDefIndex: 5651
		{
			// Fields
			public string ID; // 0x10
			public Toggle Toggle; // 0x18
			public RectTransform View; // 0x20
	
			// Constructors
			public Tab() {} // 0x0000000181283360-0x00000001812833B0
		}
	
		// Constructors
		public TabViewManager() {} // 0x0000000180276E90-0x0000000180276EA0
	
		// Methods
		private void Start() {} // 0x0000000181283130-0x0000000181283360
		public void SelectTab(string id) {} // 0x0000000181283090-0x0000000181283130
		private void OnTabSelected(Tab tab) {} // 0x0000000181282F70-0x0000000181283090
	}
}
