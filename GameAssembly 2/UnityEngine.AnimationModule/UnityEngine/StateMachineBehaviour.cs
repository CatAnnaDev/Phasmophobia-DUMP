/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Scripting;

// Image 22: UnityEngine.AnimationModule.dll - Assembly: UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3891-3932

namespace UnityEngine
{
	[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
	public abstract class StateMachineBehaviour : ScriptableObject // TypeDefIndex: 3893
	{
		// Constructors
		protected StateMachineBehaviour() {} // 0x0000000180282910-0x0000000180282920
	
		// Methods
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) {} // 0x0000000180246DB0-0x0000000180246DC0
	}
}
