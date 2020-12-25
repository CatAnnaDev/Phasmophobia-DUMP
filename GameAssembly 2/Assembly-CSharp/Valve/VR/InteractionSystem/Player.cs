/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	public class Player : MonoBehaviour // TypeDefIndex: 8388
	{
		// Fields
		// [Tooltip] // 0x000000018013D880-0x000000018013D8B0
		public Transform trackingOriginTransform; // 0x18
		// [Tooltip] // 0x000000018013D9B0-0x000000018013D9E0
		public Transform[] hmdTransforms; // 0x20
		// [Tooltip] // 0x000000018013DAD0-0x000000018013DB00
		public Hand[] hands; // 0x28
		// [Tooltip] // 0x000000018013DC20-0x000000018013DC50
		public Collider headCollider; // 0x30
		// [Tooltip] // 0x000000018013F070-0x000000018013F0A0
		public GameObject rigSteamVR; // 0x38
		// [Tooltip] // 0x000000018013F100-0x000000018013F130
		public GameObject rig2DFallback; // 0x40
		// [Tooltip] // 0x000000018013F2B0-0x000000018013F2E0
		public Transform audioListener; // 0x48
		public bool allowToggleTo2D; // 0x50
		private static Player _instance; // 0x00
	
		// Properties
		public static Player instance { get => default; } // 0x0000000180FCB390-0x0000000180FCB450 
		public int handCount { get => default; } // 0x0000000180FCB220-0x0000000180FCB2C0 
		public Hand leftHand { get => default; } // 0x0000000180FCB5D0-0x0000000180FCB6F0 
		public Hand rightHand { get => default; } // 0x0000000180FCB870-0x0000000180FCB990 
		public SteamVR_Controller.Device leftController { get => default; } // 0x0000000180FCB450-0x0000000180FCB5D0 
		public SteamVR_Controller.Device rightController { get => default; } // 0x0000000180FCB6F0-0x0000000180FCB870 
		public Transform hmdTransform { get => default; } // 0x0000000180FCB2C0-0x0000000180FCB390 
		public float eyeHeight { get => default; } // 0x0000000180FCAE50-0x0000000180FCB020 
		public Vector3 feetPositionGuess { get => default; } // 0x0000000180FCB020-0x0000000180FCB220 
		public Vector3 bodyDirectionGuess { get => default; } // 0x0000000180FCAC20-0x0000000180FCAE50 
	
		// Constructors
		public Player() {} // 0x0000000180FCAC10-0x0000000180FCAC20
	
		// Methods
		public Hand GetHand(int i) => default; // 0x0000000180FCA350-0x0000000180FCA430
		private void Awake() {} // 0x0000000180FCA150-0x0000000180FCA1E0
		private void OnEnable() {} // 0x0000000180FCAB80-0x0000000180FCAC10
		private void OnDrawGizmos() {} // 0x0000000180FCA430-0x0000000180FCAB80
		public void Draw2DDebug() {} // 0x0000000180FCA1E0-0x0000000180FCA350
		private void ActivateRig(GameObject rig) {} // 0x0000000180FC9F80-0x0000000180FCA150
		public void PlayerShotSelf() {} // 0x0000000180246DB0-0x0000000180246DC0
	}
}
