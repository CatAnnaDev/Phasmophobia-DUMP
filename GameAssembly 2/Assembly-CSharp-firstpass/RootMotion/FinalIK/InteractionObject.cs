/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.FinalIK
{
	// [AddComponentMenu] // 0x00000001800EE610-0x00000001800EE670
	// [HelpURL] // 0x00000001800EE610-0x00000001800EE670
	public class InteractionObject : MonoBehaviour // TypeDefIndex: 6757
	{
		// Fields
		// [Tooltip] // 0x00000001800EE7C0-0x00000001800EE7F0
		public Transform otherLookAtTarget; // 0x18
		// [Tooltip] // 0x00000001800EE8E0-0x00000001800EE910
		public Transform otherTargetsRoot; // 0x20
		// [Tooltip] // 0x00000001800EE980-0x00000001800EE9B0
		public Transform positionOffsetSpace; // 0x28
		public WeightCurve[] weightCurves; // 0x30
		public Multiplier[] multipliers; // 0x38
		public InteractionEvent[] events; // 0x40
		private InteractionTarget[] targets; // 0x58
	
		// Properties
		public float length { get; private set; } // 0x0000000180274910-0x0000000180274920 0x0000000180274D70-0x0000000180274D80
		public InteractionSystem lastUsedInteractionSystem { get; private set; } // 0x00000001802505D0-0x00000001802505E0 0x000000018027AC50-0x000000018027AC60
		public Transform lookAtTarget { get => default; } // 0x00000001807E04C0-0x00000001807E0540 
		public Transform targetsRoot { get => default; } // 0x00000001807E0540-0x00000001807E05C0 
	
		// Nested types
		[Serializable]
		public class InteractionEvent // TypeDefIndex: 6758
		{
			// Fields
			// [Tooltip] // 0x00000001800F0630-0x00000001800F0660
			public float time; // 0x10
			// [Tooltip] // 0x00000001800F0730-0x00000001800F0760
			public bool pause; // 0x14
			// [Tooltip] // 0x00000001800F0950-0x00000001800F0980
			public bool pickUp; // 0x15
			// [Tooltip] // 0x00000001800F0A00-0x00000001800F0A30
			public AnimatorEvent[] animations; // 0x18
			// [Tooltip] // 0x00000001800F0B00-0x00000001800F0B30
			public Message[] messages; // 0x20
			// [Tooltip] // 0x00000001800F0B60-0x00000001800F0B90
			public UnityEvent unityEvent; // 0x28
	
			// Constructors
			public InteractionEvent() {} // 0x00000001802466A0-0x00000001802466B0
	
			// Methods
			public void Activate(Transform t) {} // 0x00000001807DE140-0x00000001807DE2E0
		}
	
		[Serializable]
		public class Message // TypeDefIndex: 6759
		{
			// Fields
			// [Tooltip] // 0x00000001800F0BD0-0x00000001800F0C00
			public string function; // 0x10
			// [Tooltip] // 0x00000001800F0C50-0x00000001800F0C80
			public GameObject recipient; // 0x18
			private const string empty = ""; // Metadata: 0x00652F09
	
			// Constructors
			public Message() {} // 0x00000001802466A0-0x00000001802466B0
	
			// Methods
			public void Send(Transform t) {} // 0x00000001807E6DD0-0x00000001807E6EB0
		}
	
		[Serializable]
		public class AnimatorEvent // TypeDefIndex: 6760
		{
			// Fields
			// [Tooltip] // 0x00000001800F0D60-0x00000001800F0D90
			public Animator animator; // 0x10
			// [Tooltip] // 0x00000001800F0EE0-0x00000001800F0F10
			public Animation animation; // 0x18
			// [Tooltip] // 0x00000001800F0F80-0x00000001800F0FB0
			public string animationState; // 0x20
			// [Tooltip] // 0x00000001800F1040-0x00000001800F1070
			public float crossfadeTime; // 0x28
			// [Tooltip] // 0x00000001800F11B0-0x00000001800F11E0
			public int layer; // 0x2C
			// [Tooltip] // 0x00000001800F12C0-0x00000001800F12F0
			public bool resetNormalizedTime; // 0x30
			private const string empty = ""; // Metadata: 0x00652F0D
	
			// Constructors
			public AnimatorEvent() {} // 0x00000001807D98C0-0x00000001807D98D0
	
			// Methods
			public void Activate(bool pickUp) {} // 0x00000001807D9560-0x00000001807D9760
			private void Activate(Animator animator) {} // 0x00000001807D9760-0x00000001807D9800
			private void Activate(Animation animation) {} // 0x00000001807D9800-0x00000001807D98C0
		}
	
		[Serializable]
		public class WeightCurve // TypeDefIndex: 6761
		{
			// Fields
			// [Tooltip] // 0x00000001800F1360-0x00000001800F1390
			public Type type; // 0x10
			// [Tooltip] // 0x00000001800F1430-0x00000001800F1460
			public AnimationCurve curve; // 0x18
	
			// Nested types
			[Serializable]
			public enum Type // TypeDefIndex: 6762
			{
				PositionWeight = 0,
				RotationWeight = 1,
				PositionOffsetX = 2,
				PositionOffsetY = 3,
				PositionOffsetZ = 4,
				Pull = 5,
				Reach = 6,
				RotateBoneWeight = 7,
				Push = 8,
				PushParent = 9,
				PoserWeight = 10
			}
	
			// Constructors
			public WeightCurve() {} // 0x00000001802466A0-0x00000001802466B0
	
			// Methods
			public float GetValue(float timer) => default; // 0x00000001807F85B0-0x00000001807F85D0
		}
	
		[Serializable]
		public class Multiplier // TypeDefIndex: 6763
		{
			// Fields
			// [Tooltip] // 0x00000001800F14D0-0x00000001800F1500
			public WeightCurve.Type curve; // 0x10
			// [Tooltip] // 0x00000001800F15C0-0x00000001800F15F0
			public float multiplier; // 0x14
			// [Tooltip] // 0x00000001800F16A0-0x00000001800F16D0
			public WeightCurve.Type result; // 0x18
	
			// Constructors
			public Multiplier() {} // 0x00000001804C2F30-0x00000001804C2F40
	
			// Methods
			public float GetValue(WeightCurve weightCurve, float timer) => default; // 0x00000001807E6EB0-0x00000001807E6EF0
		}
	
		// Constructors
		public InteractionObject() {} // 0x00000001807E0470-0x00000001807E04C0
	
		// Methods
		// [ContextMenu] // 0x00000001800EEB70-0x00000001800EEBA0
		private void OpenTutorial1() {} // 0x00000001807E02F0-0x00000001807E0330
		// [ContextMenu] // 0x00000001800EEC60-0x00000001800EEC90
		private void OpenTutorial2() {} // 0x00000001807E0330-0x00000001807E0370
		// [ContextMenu] // 0x00000001800EED80-0x00000001800EEDB0
		private void OpenTutorial3() {} // 0x00000001807E0370-0x00000001807E03B0
		// [ContextMenu] // 0x00000001800EEEC0-0x00000001800EEEF0
		private void OpenTutorial4() {} // 0x00000001807E03B0-0x00000001807E03F0
		// [ContextMenu] // 0x00000001800D51F0-0x00000001800D5220
		private void SupportGroup() {} // 0x00000001807E0430-0x00000001807E0470
		// [ContextMenu] // 0x00000001800D5260-0x00000001800D5290
		private void ASThread() {} // 0x00000001807DEAA0-0x00000001807DEAE0
		public void Initiate() {} // 0x00000001807DFFD0-0x00000001807E02B0
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem) => default; // 0x00000001807DFA50-0x00000001807DFBD0
		public bool CurveUsed(WeightCurve.Type type) => default; // 0x00000001807DF760-0x00000001807DF820
		public InteractionTarget[] GetTargets() => default; // 0x0000000180246F30-0x0000000180246F40
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag) => default; // 0x00000001807DF890-0x00000001807DFA50
		public void OnStartInteraction(InteractionSystem interactionSystem) {} // 0x000000018027AC50-0x000000018027AC60
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight) {} // 0x00000001807DF1C0-0x00000001807DF750
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer) => default; // 0x00000001807DFC60-0x00000001807DFF60
		private void Awake() {} // 0x00000001807DF750-0x00000001807DF760
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight) {} // 0x00000001807DEAE0-0x00000001807DF1C0
		private Transform GetTarget(FullBodyBipedEffector effectorType) => default; // 0x00000001807DFBD0-0x00000001807DFC60
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType) => default; // 0x00000001807DFF60-0x00000001807DFFD0
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType) => default; // 0x00000001807DF820-0x00000001807DF890
		// [ContextMenu] // 0x00000001800D5050-0x00000001800D5080
		private void OpenUserManual() {} // 0x00000001807E03F0-0x00000001807E0430
		// [ContextMenu] // 0x00000001800D50F0-0x00000001800D5120
		private void OpenScriptReference() {} // 0x00000001807E02B0-0x00000001807E02F0
	}
}
