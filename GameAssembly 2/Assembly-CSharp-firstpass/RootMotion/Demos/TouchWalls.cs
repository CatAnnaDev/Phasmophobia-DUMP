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
	public class TouchWalls : MonoBehaviour // TypeDefIndex: 6640
	{
		// Fields
		public InteractionSystem interactionSystem; // 0x18
		public EffectorLink[] effectorLinks; // 0x20
	
		// Nested types
		[Serializable]
		public class EffectorLink // TypeDefIndex: 6641
		{
			// Fields
			public bool enabled; // 0x10
			public FullBodyBipedEffector effectorType; // 0x14
			public InteractionObject interactionObject; // 0x18
			public Transform spherecastFrom; // 0x20
			public float spherecastRadius; // 0x28
			public float minDistance; // 0x2C
			public LayerMask touchLayers; // 0x30
			public float lerpSpeed; // 0x34
			public float minSwitchTime; // 0x38
			public float releaseDistance; // 0x3C
			public bool sliding; // 0x40
			private Vector3 raycastDirectionLocal; // 0x44
			private float raycastDistance; // 0x50
			private bool inTouch; // 0x54
			private RaycastHit hit; // 0x58
			private Vector3 targetPosition; // 0x84
			private Quaternion targetRotation; // 0x90
			private bool initiated; // 0xA0
			private float nextSwitchTime; // 0xA4
			private float speedF; // 0xA8
	
			// Constructors
			public EffectorLink() {} // 0x0000000180525EC0-0x0000000180525EF0
	
			// Methods
			public void Initiate(InteractionSystem interactionSystem) {} // 0x0000000180524EB0-0x0000000180525290
			private bool FindWalls(Vector3 direction) => default; // 0x0000000180524D90-0x0000000180524EB0
			public void Update(InteractionSystem interactionSystem) {} // 0x00000001805255C0-0x0000000180525EC0
			private void StopTouch(InteractionSystem interactionSystem) {} // 0x0000000180525410-0x00000001805255C0
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject) {} // 0x0000000180525310-0x0000000180525390
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject) {} // 0x0000000180525290-0x0000000180525310
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject) {} // 0x0000000180525390-0x0000000180525410
			public void Destroy(InteractionSystem interactionSystem) {} // 0x0000000180524BC0-0x0000000180524D90
		}
	
		// Constructors
		public TouchWalls() {} // 0x0000000180276E90-0x0000000180276EA0
	
		// Methods
		private void Start() {} // 0x000000018053CEB0-0x000000018053CF20
		private void FixedUpdate() {} // 0x000000018053CD60-0x000000018053CDE0
		private void OnDestroy() {} // 0x000000018053CDE0-0x000000018053CEB0
	}
}
