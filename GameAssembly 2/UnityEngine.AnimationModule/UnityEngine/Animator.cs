/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 22: UnityEngine.AnimationModule.dll - Assembly: UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3891-3932

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180145CB0-0x0000000180145D40
	// [NativeHeader] // 0x0000000180145CB0-0x0000000180145D40
	// [NativeHeader] // 0x0000000180145CB0-0x0000000180145D40
	[UsedByNativeCode] // 0x0000000180145CB0-0x0000000180145D40
	public class Animator : Behaviour // TypeDefIndex: 3902
	{
		// Properties
		public bool isHuman { [NativeMethod] /* 0x0000000180145FC0-0x0000000180145FF0 */ get => default; } // 0x0000000180ADAAA0-0x0000000180ADAAE0 
		public bool hasRootMotion { [NativeMethod] /* 0x0000000180146060-0x0000000180146090 */ get => default; } // 0x0000000180ADAA60-0x0000000180ADAAA0 
		public Vector3 deltaPosition { get => default; } // 0x0000000180ADA900-0x0000000180ADA970 
		public Quaternion deltaRotation { get => default; } // 0x0000000180ADA9C0-0x0000000180ADAA20 
		public bool applyRootMotion { get => default; set {} } // 0x0000000180ADA870-0x0000000180ADA8B0 0x0000000180ADAC60-0x0000000180ADACB0
		public AnimatorUpdateMode updateMode { get => default; set {} } // 0x0000000180ADAC20-0x0000000180ADAC60 0x0000000180ADAD00-0x0000000180ADAD40
		public AnimatorControllerParameter[] parameters { [FreeFunction] /* 0x00000001801464C0-0x0000000180146500 */ get => default; } // 0x0000000180ADAB20-0x0000000180ADAB60 
		public Vector3 pivotPosition { get => default; } // 0x0000000180ADABB0-0x0000000180ADAC20 
		public float speed { set {} } // 0x0000000180ADACB0-0x0000000180ADAD00
		public bool hasBoundPlayables { [NativeMethod] /* 0x0000000180146DC0-0x0000000180146DF0 */ get => default; } // 0x0000000180ADAA20-0x0000000180ADAA60 
		public bool logWarnings { get => default; } // 0x0000000180ADAAE0-0x0000000180ADAB20 
	
		// Constructors
		public Animator() {} // Dummy constructor
	
		// Methods
		public float GetFloat(string name) => default; // 0x0000000180AD9CF0-0x0000000180AD9D40
		public float GetFloat(int id) => default; // 0x0000000180AD9CB0-0x0000000180AD9CF0
		public void SetFloat(string name, float value) {} // 0x0000000180ADA0E0-0x0000000180ADA140
		public void SetFloat(int id, float value) {} // 0x0000000180ADA090-0x0000000180ADA0E0
		public bool GetBool(string name) => default; // 0x0000000180AD9BD0-0x0000000180AD9C20
		public bool GetBool(int id) => default; // 0x0000000180AD9B90-0x0000000180AD9BD0
		public void SetBool(string name, bool value) {} // 0x0000000180ADA030-0x0000000180ADA090
		public void SetBool(int id, bool value) {} // 0x0000000180AD9FD0-0x0000000180ADA030
		public int GetInteger(string name) => default; // 0x0000000180AD9D80-0x0000000180AD9DD0
		public int GetInteger(int id) => default; // 0x0000000180AD9D40-0x0000000180AD9D80
		public void SetInteger(string name, int value) {} // 0x0000000180ADA510-0x0000000180ADA570
		public void SetInteger(int id, int value) {} // 0x0000000180ADA4C0-0x0000000180ADA510
		public void SetTrigger(string name) {} // 0x0000000180ADA7E0-0x0000000180ADA830
		public void SetTrigger(int id) {} // 0x0000000180ADA7A0-0x0000000180ADA7E0
		public void ResetTrigger(string name) {} // 0x0000000180AD9F80-0x0000000180AD9FD0
		public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) {} // 0x0000000180ADA380-0x0000000180ADA3F0
		private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) {} // 0x0000000180ADA190-0x0000000180ADA1E0
		public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) {} // 0x0000000180ADA450-0x0000000180ADA4C0
		private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) {} // 0x0000000180ADA230-0x0000000180ADA280
		public void SetIKPositionWeight(AvatarIKGoal goal, float value) {} // 0x0000000180ADA320-0x0000000180ADA380
		private void SetGoalWeightPosition(AvatarIKGoal goal, float value) {} // 0x0000000180ADA280-0x0000000180ADA2D0
		public void SetIKRotationWeight(AvatarIKGoal goal, float value) {} // 0x0000000180ADA3F0-0x0000000180ADA450
		private void SetGoalWeightRotation(AvatarIKGoal goal, float value) {} // 0x0000000180ADA2D0-0x0000000180ADA320
		public void SetLookAtPosition(Vector3 lookAtPosition) {} // 0x0000000180ADA660-0x0000000180ADA6C0
		[NativeMethod] // 0x0000000180146100-0x0000000180146130
		private void SetLookAtPositionInternal(Vector3 lookAtPosition) {} // 0x0000000180ADA610-0x0000000180ADA660
		public void SetLookAtWeight(float weight, [DefaultValue] /* 0x000000018012F090-0x000000018012F0C0 */ float bodyWeight, [DefaultValue] /* 0x00000001801461A0-0x00000001801461D0 */ float headWeight, [DefaultValue] /* 0x000000018012F090-0x000000018012F0C0 */ float eyesWeight, [DefaultValue] /* 0x00000001801462A0-0x00000001801462D0 */ float clampWeight) {} // 0x0000000180ADA730-0x0000000180ADA7A0
		[NativeMethod] // 0x00000001801463D0-0x0000000180146400
		private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) {} // 0x0000000180ADA6C0-0x0000000180ADA730
		public float GetLayerWeight(int layerIndex) => default; // 0x0000000180AD9DD0-0x0000000180AD9E10
		public void SetLayerWeight(int layerIndex, float weight) {} // 0x0000000180ADA570-0x0000000180ADA5C0
		private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) {
			info = default;
		} // 0x0000000180AD9930-0x0000000180AD9990
		public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) => default; // 0x0000000180AD9C20-0x0000000180AD9CB0
		public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) => default; // 0x0000000180AD9E10-0x0000000180AD9EA0
		private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info) {
			info = default;
		} // 0x0000000180AD9990-0x0000000180AD99E0
		public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) => default; // 0x0000000180AD99E0-0x0000000180AD9A60
		public bool IsInTransition(int layerIndex) => default; // 0x0000000180AD9EE0-0x0000000180AD9F20
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) {} // 0x0000000180AD97B0-0x0000000180AD9840
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) {} // 0x0000000180AD9710-0x0000000180AD97B0
		public void CrossFade(string stateName, float normalizedTransitionDuration, [DefaultValue] /* 0x0000000180139340-0x0000000180139370 */ int layer, [DefaultValue] /* 0x0000000180146590-0x00000001801465C0 */ float normalizedTimeOffset, [DefaultValue] /* 0x000000018012F090-0x000000018012F0C0 */ float normalizedTransitionTime) {} // 0x0000000180AD98A0-0x0000000180AD9930
		[FreeFunction] // 0x00000001801467B0-0x00000001801467F0
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, [DefaultValue] /* 0x0000000180139340-0x0000000180139370 */ int layer, [DefaultValue] /* 0x000000018012F090-0x000000018012F0C0 */ float normalizedTimeOffset, [DefaultValue] /* 0x000000018012F090-0x000000018012F0C0 */ float normalizedTransitionTime) {} // 0x0000000180AD9840-0x0000000180AD98A0
		[FreeFunction] // 0x0000000180146A60-0x0000000180146AA0
		public void Play(int stateNameHash, [DefaultValue] /* 0x0000000180139340-0x0000000180139370 */ int layer, [DefaultValue] /* 0x0000000180146590-0x00000001801465C0 */ float normalizedTime) {} // 0x0000000180AD9F20-0x0000000180AD9F80
		public Transform GetBoneTransform(HumanBodyBones humanBoneId) => default; // 0x0000000180AD9AA0-0x0000000180AD9B90
		[NativeMethod] // 0x0000000180146C60-0x0000000180146C90
		internal Transform GetBoneTransformInternal(int humanBoneId) => default; // 0x0000000180AD9A60-0x0000000180AD9AA0
		[NativeMethod] // 0x0000000180146F60-0x0000000180146FA0
		public static int StringToHash(string name) => default; // 0x0000000180ADA830-0x0000000180ADA870
		private void CheckIfInIKPass() {} // 0x0000000180AD9660-0x0000000180AD9710
		private bool IsInIKPass() => default; // 0x0000000180AD9EA0-0x0000000180AD9EE0
		[FreeFunction] // 0x0000000180147100-0x0000000180147140
		private void SetFloatString(string name, float value) {} // 0x0000000180ADA0E0-0x0000000180ADA140
		[FreeFunction] // 0x0000000180147280-0x00000001801472C0
		private void SetFloatID(int id, float value) {} // 0x0000000180ADA090-0x0000000180ADA0E0
		[FreeFunction] // 0x0000000180147450-0x0000000180147490
		private float GetFloatString(string name) => default; // 0x0000000180AD9CF0-0x0000000180AD9D40
		[FreeFunction] // 0x00000001801474C0-0x0000000180147500
		private float GetFloatID(int id) => default; // 0x0000000180AD9CB0-0x0000000180AD9CF0
		[FreeFunction] // 0x00000001801476D0-0x0000000180147710
		private void SetBoolString(string name, bool value) {} // 0x0000000180ADA030-0x0000000180ADA090
		[FreeFunction] // 0x0000000180147770-0x00000001801477B0
		private void SetBoolID(int id, bool value) {} // 0x0000000180AD9FD0-0x0000000180ADA030
		[FreeFunction] // 0x0000000180147860-0x00000001801478A0
		private bool GetBoolString(string name) => default; // 0x0000000180AD9BD0-0x0000000180AD9C20
		[FreeFunction] // 0x0000000180147950-0x0000000180147990
		private bool GetBoolID(int id) => default; // 0x0000000180AD9B90-0x0000000180AD9BD0
		[FreeFunction] // 0x0000000180147A50-0x0000000180147A90
		private void SetIntegerString(string name, int value) {} // 0x0000000180ADA510-0x0000000180ADA570
		[FreeFunction] // 0x0000000180147B50-0x0000000180147B90
		private void SetIntegerID(int id, int value) {} // 0x0000000180ADA4C0-0x0000000180ADA510
		[FreeFunction] // 0x0000000180147CE0-0x0000000180147D20
		private int GetIntegerString(string name) => default; // 0x0000000180AD9D80-0x0000000180AD9DD0
		[FreeFunction] // 0x0000000180147E60-0x0000000180147EA0
		private int GetIntegerID(int id) => default; // 0x0000000180AD9D40-0x0000000180AD9D80
		[FreeFunction] // 0x0000000180147F60-0x0000000180147FA0
		private void SetTriggerString(string name) {} // 0x0000000180ADA7E0-0x0000000180ADA830
		[FreeFunction] // 0x0000000180148180-0x00000001801481C0
		private void SetTriggerID(int id) {} // 0x0000000180ADA7A0-0x0000000180ADA7E0
		[FreeFunction] // 0x00000001801482A0-0x00000001801482E0
		private void ResetTriggerString(string name) {} // 0x0000000180AD9F80-0x0000000180AD9FD0
		private void get_deltaPosition_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000180ADA8B0-0x0000000180ADA900
		private void get_deltaRotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x0000000180ADA970-0x0000000180ADA9C0
		private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) {} // 0x0000000180ADA140-0x0000000180ADA190
		private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) {} // 0x0000000180ADA1E0-0x0000000180ADA230
		private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) {} // 0x0000000180ADA5C0-0x0000000180ADA610
		private void get_pivotPosition_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000180ADAB60-0x0000000180ADABB0
	}
}
