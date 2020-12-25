/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace VRTK
{
	[ExecuteInEditMode] // 0x00000001800D4E50-0x00000001800D4E60
	public abstract class VRTK_Control : MonoBehaviour // TypeDefIndex: 7533
	{
		// Fields
		[Obsolete] // 0x00000001800D5B60-0x00000001800D5B90
		public DefaultControlEvents u091Du091Du0924u091Du091Du0929u0923u091Fu0926u0924u091C; // 0x18
		public bool u0920u091Fu091Au0924u0929u0922u0923u091Bu091Au0925u0922; // 0x20
		protected Bounds u0921u0923u0923u0926u0921u091Du091Du0922u0924u0921u091D; // 0x30
		protected bool u0928u0927u091Cu091Du0926u0924u0922u091Au0927u0921u0921; // 0x48
		protected VRTK_ControllerRigidbodyActivator u091Fu091Fu091Fu0927u0926u0920u0926u0925u0921u0924u091D; // 0x50
		protected float u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F; // 0x58
		protected static Color u091Cu0925u0923u0920u091Du0925u0923u091Cu091Eu091Du0921; // 0x00
		protected static Color u091Eu0921u091Fu0920u0924u091Fu0926u0921u091Eu0921u091C; // 0x10
		protected const float u0929u0928u0929u0923u0924u091Bu091Cu0927u0927u0922u0928 = 20f; // Metadata: 0x006539CE
		protected u091Eu0928u0929u091Cu0929u0925u091Bu0928u0920u0923u091A u091Bu0926u0928u0921u0920u0927u0920u091Bu0920u091Bu0925; // 0x5C
		protected GameObject u091Eu091Fu0921u0928u0928u091Bu0929u0929u091Fu0920u0926; // 0x68
		protected bool u0920u0928u0924u091Du0921u091Eu091Cu0929u0924u091Cu0925; // 0x70
	
		// Events
		public event u091Cu0923u091Fu0922u091Cu0925u0920u0923u0924u0929u091B u0924u0920u091Bu0923u0929u091Au091Cu0925u0922u0929u0928;
	
		// Nested types
		[Serializable]
		[Obsolete] // 0x00000001800D63E0-0x00000001800D6410
		public class ValueChangedEvent : UnityEvent<float, float> // TypeDefIndex: 7534
		{
			// Constructors
			public ValueChangedEvent() {} // 0x00000001814CC210-0x00000001814CC250
		}
	
		[Serializable]
		[Obsolete] // 0x00000001800D6450-0x00000001800D6480
		public class DefaultControlEvents // TypeDefIndex: 7535
		{
			// Fields
			public ValueChangedEvent OnValueChanged; // 0x10
	
			// Constructors
			public DefaultControlEvents() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		public struct u091Eu0928u0929u091Cu0929u0925u091Bu0928u0920u0923u091A // TypeDefIndex: 7536
		{
			// Fields
			public float u091Eu091Eu0926u091Fu0926u0925u0926u091Du091Bu0924u0927; // 0x00
			public float u0925u0926u0929u091Cu091Du0923u0924u0920u091Du0920u091D; // 0x04
		}
	
		public enum u0922u091Eu0929u091Du0921u0920u0920u091Cu0925u0920u0922 // TypeDefIndex: 7537
		{
			autodetect = 0,
			x = 1,
			y = 2,
			z = 3
		}
	
		// Constructors
		protected VRTK_Control() {} // 0x00000001814B5820-0x00000001814B5830
		static VRTK_Control() {} // 0x00000001814B5780-0x00000001814B5820
	
		// Methods
		protected abstract void u091Au0923u091Au091Bu0921u091Cu0927u091Du0920u0929u091D();
		protected abstract bool u0920u0927u0921u0925u0921u0926u091Au0926u091Du091Cu0924();
		protected abstract u091Eu0928u0929u091Cu0929u0925u091Bu0928u0920u0923u091A u0924u0926u0927u091Eu091Du091Eu0922u0922u0929u0925u0924();
		public virtual void OnValueChanged(u091Bu0922u0923u091Bu0923u0928u0923u091Eu0923u091Bu091A u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x00000001814B50A0-0x00000001814B50C0
		public virtual float GetValue() => default; // 0x00000001806995E0-0x00000001806995F0
		public virtual float GetNormalizedValue() => default; // 0x00000001814B4D60-0x00000001814B4E90
		public virtual void SetContent(GameObject u091Eu091Eu091Fu0927u0921u0924u0925u0928u0920u091Bu0927, bool u0926u0922u0920u0920u0923u0925u0923u091Bu0926u091Cu091A) {} // 0x00000001814B50C0-0x00000001814B50F0
		public virtual GameObject GetContent() => default; // 0x0000000180274930-0x0000000180274940
		protected abstract void u0929u091Au091Bu091Bu091Bu0928u091Du091Bu0929u091Eu091C();
		protected virtual void Awake() {} // 0x00000001814B4CB0-0x00000001814B4D60
		protected virtual void Update() {} // 0x00000001814B5640-0x00000001814B5780
		protected virtual u091Bu0922u0923u091Bu0923u0928u0923u091Eu0923u091Bu091A u0926u0921u091Eu0926u0929u091Au0922u0920u0926u091Fu0922() => default; // 0x00000001814B54D0-0x00000001814B5520
		protected virtual void OnDrawGizmos() {} // 0x00000001814B4E90-0x00000001814B50A0
		protected virtual void u0920u0921u091Fu0922u091Fu091Fu091Au0927u091Fu091Au091C() {} // 0x00000001814B50F0-0x00000001814B5330
		protected Vector3 u0924u0929u0926u091Fu0923u091Cu0926u0928u0929u0928u0927(Vector3 u0927u0923u091Du091Cu0922u0926u0921u0928u0928u0929u091F, Vector3 u091Bu0928u091Eu091Du091Eu091Bu0926u0923u0920u0921u0920) => default; // 0x00000001814B5330-0x00000001814B54D0
		protected virtual void u0928u0928u0927u0924u0928u0921u091Du0928u0929u091Cu0927() {} // 0x00000001814B5520-0x00000001814B5640
	}
}
