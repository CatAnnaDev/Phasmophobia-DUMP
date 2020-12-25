/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.Cameras
{
	public abstract class AbstractTargetFollower : MonoBehaviour // TypeDefIndex: 6070
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		protected Transform m_Target; // 0x18
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool m_AutoTargetPlayer; // 0x20
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private UpdateType m_UpdateType; // 0x24
		protected Rigidbody targetRigidbody; // 0x28
	
		// Properties
		public Transform Target { get; } // 0x0000000180246BC0-0x0000000180246BD0 
	
		// Nested types
		public enum UpdateType // TypeDefIndex: 6071
		{
			FixedUpdate = 0,
			LateUpdate = 1,
			ManualUpdate = 2
		}
	
		// Constructors
		protected AbstractTargetFollower() {} // 0x00000001806F2EC0-0x00000001806F2ED0
	
		// Methods
		protected virtual void Start() {} // 0x00000001808290F0-0x0000000180829190
		private void FixedUpdate() {} // 0x0000000180828E80-0x0000000180828F50
		private void LateUpdate() {} // 0x0000000180828F50-0x0000000180829020
		public void ManualUpdate() {} // 0x0000000180829020-0x00000001808290F0
		protected abstract void FollowTarget(float deltaTime);
		public void FindAndTargetPlayer() {} // 0x0000000180828DE0-0x0000000180828E80
		public virtual void SetTarget(Transform newTransform) {} // 0x0000000180246D40-0x0000000180246D50
	}
}
