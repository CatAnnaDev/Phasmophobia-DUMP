/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion
{
	public class SolverManager : MonoBehaviour // TypeDefIndex: 6586
	{
		// Fields
		// [Tooltip] // 0x000000018012AEB0-0x000000018012AEE0
		public bool fixTransforms; // 0x18
		private Animator animator; // 0x20
		private Animation legacy; // 0x28
		private bool updateFrame; // 0x30
		private bool componentInitiated; // 0x31
		private bool skipSolverUpdate; // 0x32
	
		// Properties
		private bool animatePhysics { get => default; } // 0x00000001807D4640-0x00000001807D4720 
		private bool isAnimated { get => default; } // 0x00000001807D4720-0x00000001807D47D0 
	
		// Constructors
		public SolverManager() {} // 0x000000018074E1A0-0x000000018074E1B0
	
		// Methods
		public void Disable() {} // 0x00000001807D4220-0x00000001807D42A0
		protected virtual void InitiateSolver() {} // 0x0000000180246DB0-0x0000000180246DC0
		protected virtual void UpdateSolver() {} // 0x0000000180246DB0-0x0000000180246DC0
		protected virtual void FixTransforms() {} // 0x0000000180246DB0-0x0000000180246DC0
		private void OnDisable() {} // 0x00000001807D4560-0x00000001807D45C0
		private void Start() {} // 0x00000001807D44C0-0x00000001807D4510
		private void Initiate() {} // 0x00000001807D44C0-0x00000001807D4510
		private void Update() {} // 0x00000001807D4600-0x00000001807D4640
		private void FindAnimatorRecursive(Transform t, bool findInChildren) {} // 0x00000001807D42A0-0x00000001807D4470
		private void FixedUpdate() {} // 0x00000001807D4470-0x00000001807D44C0
		private void LateUpdate() {} // 0x00000001807D4510-0x00000001807D4560
		public void UpdateSolverExternal() {} // 0x00000001807D45C0-0x00000001807D4600
	}
}
