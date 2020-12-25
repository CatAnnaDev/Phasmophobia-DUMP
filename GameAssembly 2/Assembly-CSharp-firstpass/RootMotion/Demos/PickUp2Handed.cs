/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.Demos
{
	public abstract class PickUp2Handed : MonoBehaviour // TypeDefIndex: 6631
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private int GUIspace; // 0x18
		public InteractionSystem interactionSystem; // 0x20
		public InteractionObject obj; // 0x28
		public Transform pivot; // 0x30
		public Transform holdPoint; // 0x38
		public float pickUpTime; // 0x40
		private float holdWeight; // 0x44
		private float holdWeightVel; // 0x48
		private Vector3 pickUpPosition; // 0x4C
		private Quaternion pickUpRotation; // 0x58
	
		// Properties
		private bool holding { get; } // 0x00000001804CE2A0-0x00000001804CE2D0 
	
		// Constructors
		protected PickUp2Handed() {} // 0x00000001804CE290-0x00000001804CE2A0
	
		// Methods
		private void OnGUI() {} // 0x00000001804CDCD0-0x00000001804CDE50
		protected abstract void RotatePivot();
		private void Start() {} // 0x00000001804CE0D0-0x00000001804CE290
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject) {} // 0x00000001804CDE50-0x00000001804CDFF0
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject) {} // 0x00000001804CDFF0-0x00000001804CE0D0
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject) {} // 0x00000001804CDBA0-0x00000001804CDCD0
		private void LateUpdate() {} // 0x00000001804CD730-0x00000001804CD9A0
		private void OnDestroy() {} // 0x00000001804CD9A0-0x00000001804CDBA0
	}
}
