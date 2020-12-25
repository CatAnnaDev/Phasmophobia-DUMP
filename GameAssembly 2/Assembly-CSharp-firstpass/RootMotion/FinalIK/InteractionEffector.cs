/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.FinalIK
{
	[Serializable]
	public class InteractionEffector // TypeDefIndex: 6755
	{
		// Fields
		private Poser poser; // 0x20
		private IKEffector effector; // 0x28
		private float timer; // 0x30
		private float length; // 0x34
		private float weight; // 0x38
		private float fadeInSpeed; // 0x3C
		private float defaultPositionWeight; // 0x40
		private float defaultRotationWeight; // 0x44
		private float defaultPull; // 0x48
		private float defaultReach; // 0x4C
		private float defaultPush; // 0x50
		private float defaultPushParent; // 0x54
		private float resetTimer; // 0x58
		private bool positionWeightUsed; // 0x5C
		private bool rotationWeightUsed; // 0x5D
		private bool pullUsed; // 0x5E
		private bool reachUsed; // 0x5F
		private bool pushUsed; // 0x60
		private bool pushParentUsed; // 0x61
		private bool pickedUp; // 0x62
		private bool defaults; // 0x63
		private bool pickUpOnPostFBBIK; // 0x64
		private Vector3 pickUpPosition; // 0x68
		private Vector3 pausePositionRelative; // 0x74
		private Quaternion pickUpRotation; // 0x80
		private Quaternion pauseRotationRelative; // 0x90
		private InteractionTarget interactionTarget; // 0xA0
		private Transform target; // 0xA8
		private List<bool> triggered; // 0xB0
		private InteractionSystem interactionSystem; // 0xB8
		private bool started; // 0xC0
	
		// Properties
		public FullBodyBipedEffector effectorType { get; private set; } // 0x0000000180245EA0-0x0000000180246600 0x00000001802932E0-0x00000001802932F0
		public bool isPaused { get; private set; } // 0x00000001802D2B60-0x00000001802D2B70 0x000000018030F010-0x000000018030F020
		public InteractionObject interactionObject { get; private set; } // 0x0000000180246BC0-0x0000000180246BD0 0x0000000180246D40-0x0000000180246D50
		public bool inInteraction { get => default; } // 0x00000001807DDC60-0x00000001807DDCC0 
		public float progress { get => default; } // 0x00000001807DDCC0-0x00000001807DDD40 
	
		// Constructors
		public InteractionEffector() {} // Dummy constructor
		public InteractionEffector(FullBodyBipedEffector effectorType) {} // 0x00000001807DDBE0-0x00000001807DDC60
	
		// Methods
		public void Initiate(InteractionSystem interactionSystem) {} // 0x00000001807DB920-0x00000001807DB9F0
		private void StoreDefaults() {} // 0x00000001807DCE90-0x00000001807DD030
		public bool ResetToDefaults(float speed) => default; // 0x00000001807DC0C0-0x00000001807DC630
		public bool Pause() => default; // 0x00000001807DBCE0-0x00000001807DBE90
		public bool Resume() => default; // 0x00000001807DC630-0x00000001807DC6E0
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt) => default; // 0x00000001807DC6E0-0x00000001807DCC40
		public void Update(Transform root, float speed) {} // 0x00000001807DD340-0x00000001807DDBE0
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause) {
			pickUp = default;
			pause = default;
		} // 0x00000001807DD030-0x00000001807DD340
		private void PickUp(Transform root) {} // 0x00000001807DBE90-0x00000001807DC0C0
		public bool Stop() => default; // 0x00000001807DCC40-0x00000001807DCE90
		public void OnPostFBBIK() {} // 0x00000001807DB9F0-0x00000001807DBCE0
	}
}
