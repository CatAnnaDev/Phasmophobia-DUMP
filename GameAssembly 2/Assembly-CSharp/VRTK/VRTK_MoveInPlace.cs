﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace VRTK
{
	// [AddComponentMenu] // 0x0000000180100C80-0x0000000180100CB0
	public class VRTK_MoveInPlace : MonoBehaviour // TypeDefIndex: 7629
	{
		// Fields
		public bool u0928u0929u091Bu0926u0927u091Au091Cu0928u0925u0924u091A; // 0x18
		public bool u0929u091Fu091Cu091Au0920u0929u0920u0927u0921u0920u0924; // 0x19
		public VRTK_ControllerEvents.u0929u0929u0922u0923u0924u0921u0929u0929u0922u0920u0929 u0920u0925u0923u0922u0921u0928u091Eu0922u0922u0927u091F; // 0x1C
		public u091Au0925u091Du0922u0925u091Fu0924u091Bu091Eu0920u0925 u0927u091Bu091Du0926u091Eu091Au0922u0922u0929u091Fu091B; // 0x20
		public u091Fu0928u0923u0922u091Bu0924u0921u0923u0923u0926u0926 u0925u0922u091Eu091Du0925u0926u091Fu0928u091Au0926u0928; // 0x24
		public float u0922u091Bu091Au0927u091Bu0923u0922u0924u0924u091Du091A; // 0x28
		public float u0925u0925u0923u0928u0923u0923u0929u0924u091Eu0923u0929; // 0x2C
		public float u0922u0925u0928u0924u0924u091Bu091Bu091Cu0921u0925u0922; // 0x30
		public float u0923u091Fu0929u0926u0927u0926u0921u0925u091Eu0922u0922; // 0x34
		public float u0923u0921u0924u091Eu091Fu091Fu0921u0926u0926u0920u091E; // 0x38
		public float u0920u0929u0921u091Du0920u091Eu0925u0924u0927u0929u091F; // 0x3C
		public VRTK_BodyPhysics u0923u0929u0925u091Fu091Bu091Cu0927u0923u091Fu091Au0927; // 0x40
		protected Transform u0923u0926u091Du091Bu091Eu091Eu0926u091Du0922u0925u091F; // 0x48
		protected GameObject u0924u091Fu0927u0920u0927u0927u0921u0923u0923u0929u0923; // 0x50
		protected GameObject u0927u091Bu091Du0926u0929u0921u0922u091Eu0921u091Fu0922; // 0x58
		protected u0922u0922u0921u0925u0928u091Fu0926u0922u0925u0921u0928 u0924u0921u0927u0927u0920u0926u091Cu0923u0924u0926u091A; // 0x60
		protected Transform u091Du0921u0925u0924u0922u0921u0927u0924u0923u0921u091C; // 0x68
		protected bool u0926u0920u0929u091Du091Du0923u091Bu091Au091Fu0924u0921; // 0x70
		protected bool u0929u0924u091Bu091Fu0923u091Fu0923u0921u0928u0925u0920; // 0x71
		protected bool u0926u0926u0920u091Eu0929u091Eu091Fu0924u0926u0921u091B; // 0x72
		protected bool u0924u0922u0929u091Fu0921u0925u0929u0925u091Du091Eu0923; // 0x73
		protected VRTK_ControllerEvents.u0929u0929u0922u0923u0924u0921u0929u0929u0922u0920u0929 u0921u091Fu091Bu091Fu0921u0922u0925u0929u0924u091Au0926; // 0x74
		protected bool u0926u091Du0921u0920u091Fu091Bu0922u0929u091Fu0923u0921; // 0x78
		protected int u091Eu0927u0921u091Au091Eu0925u091Du0921u0922u091Cu0923; // 0x7C
		protected List<Transform> u0921u0922u091Bu091Bu091Fu091Eu0929u0925u0928u091Cu0929; // 0x80
		protected Dictionary<Transform, List<float>> u0923u0928u091Bu0925u0922u091Eu0928u0920u0924u0920u0923; // 0x88
		protected Dictionary<Transform, float> u0921u091Cu091Au0923u091Bu0923u0922u091Au091Au0920u0929; // 0x90
		protected Vector3 u0928u0925u091Du0925u0925u091Fu0924u0927u0926u0921u0927; // 0x98
		protected float u0929u091Du0928u0926u0921u091Cu091Cu091Au0928u091Fu091C; // 0xA4
		protected Vector3 u0925u091Au0921u0925u0922u091Fu0921u091Cu091Bu0920u0929; // 0xA8
		protected Vector3 u0924u091Fu0927u091Cu0920u0925u0929u0925u0924u0925u0927; // 0xB4
		protected bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A; // 0xC0
	
		// Nested types
		public enum u091Au0925u091Du0922u0925u091Fu0924u091Bu091Eu0920u0925 // TypeDefIndex: 7630
		{
			HeadsetAndControllers = 0,
			ControllersOnly = 1,
			HeadsetOnly = 2
		}
	
		public enum u091Fu0928u0923u0922u091Bu0924u0921u0923u0923u0926u0926 // TypeDefIndex: 7631
		{
			Gaze = 0,
			ControllerRotation = 1,
			DumbDecoupling = 2,
			SmartDecoupling = 3,
			EngageControllerRotationOnly = 4,
			LeftControllerRotationOnly = 5,
			RightControllerRotationOnly = 6
		}
	
		// Constructors
		public VRTK_MoveInPlace() {} // 0x0000000181451140-0x0000000181451180
	
		// Methods
		protected virtual void Update() {} // 0x00000001814510C0-0x0000000181451140
		protected virtual bool u0925u0922u0922u0927u091Eu0924u0927u091Bu0923u091Fu091B(VRTK_BodyPhysics u0929u0921u0923u091Du0929u091Bu0920u0923u091Du0926u0927, Vector3 u091Bu0927u091Cu091Cu0929u091Du0926u091Du091Bu0928u0922, Vector3 u0921u091Du091Du091Fu091Du0928u091Cu091Au091Eu091Bu0922) => default; // 0x000000018144E1E0-0x000000018144E370
		protected virtual bool u0925u0928u0920u091Au091Bu091Eu091Du091Cu0921u091Eu0924(VRTK_BodyPhysics u0929u0921u0923u091Du0929u091Bu0920u0923u091Du0926u0927, Vector3 u091Bu0927u091Cu091Cu0929u091Du0926u091Du091Bu0928u0922, Vector3 u0921u091Du091Du091Fu091Du0928u091Cu091Au091Eu091Bu0922) => default; // 0x000000018144E500-0x000000018144E690
		public virtual void u091Du091Bu0924u0925u091Du0927u0921u0921u0928u091Bu091B(u091Au0925u091Du0922u0925u091Fu0924u091Bu091Eu0920u0925 u0926u0923u091Bu091Eu091Cu091Cu091Du091Du0926u0924u091F) {} // 0x000000018144B750-0x000000018144BAE0
		protected virtual Quaternion u091Bu0925u0925u0928u091Eu0920u091Au091Cu091Au0928u091C(Quaternion u091Cu0921u091Bu0920u0926u0923u0922u091Bu0926u091Au0926, Quaternion u091Au091Eu091Bu091Fu091Eu091Bu091Eu0926u091Fu0922u0923) => default; // 0x000000018144B340-0x000000018144B3E0
		protected virtual Quaternion u0920u0927u091Eu0928u0929u091Bu0929u0920u0925u0921u091C() => default; // 0x000000018144D6D0-0x000000018144D980
		protected virtual void u091Eu0927u0929u0922u0922u0924u0922u091Du0921u091Eu0921(Vector3 u0927u0921u091Fu091Eu0923u0927u0922u0929u091Cu0921u0929, float u091Fu0927u0929u0924u091Du091Du0925u0923u0929u091Du0921) {} // 0x000000018144C830-0x000000018144CA70
		protected virtual void u091Fu0920u0921u0920u091Du091Au0924u0924u0921u0927u0922() {} // 0x000000018144CAC0-0x000000018144CB80
		public virtual Vector3 u0922u0927u0920u0925u0923u091Du0928u091Cu0927u091Au0926() => default; // 0x0000000181449E00-0x0000000181449E20
		protected virtual void OnDestroy() {} // 0x0000000181449E30-0x0000000181449EA0
		protected virtual void u091Cu0926u0928u091Du0924u0929u0924u0926u0927u091Eu0923(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Eu0929u091Au091Eu0929u0924u0922u0929u0923u0928u091D u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018144B630-0x000000018144B750
		protected virtual void u0920u0927u091Bu091Du0927u091Fu091Cu091Du0922u0926u0921() {} // 0x000000018144D660-0x000000018144D6D0
		public virtual float u091Fu0929u0920u091Bu0925u0929u0923u0923u091Au0923u0925() => default; // 0x0000000181449E20-0x0000000181449E30
		protected virtual Vector3 u091Bu0926u0921u091Eu0928u0921u0928u091Cu091Du0922u0920(Vector3 u091Cu0927u0925u0925u091Eu0921u0923u0928u0926u091Du0927) => default; // 0x000000018144B3E0-0x000000018144B4C0
		public virtual float u0921u0928u091Bu0929u0921u0920u091Du091Eu091Au0923u091E() => default; // 0x0000000181449E20-0x0000000181449E30
		protected virtual void u0928u091Du0920u091Cu091Bu0925u091Eu0927u0921u091Eu0927(Vector3 u0927u0921u091Fu091Eu0923u0927u0922u0929u091Cu0921u0929, float u091Fu0927u0929u0924u091Du091Du0925u0923u0929u091Du0921) {} // 0x000000018144FB00-0x000000018144FD40
		protected virtual Quaternion u0928u0924u0924u0922u0929u0922u0923u0921u0926u0925u091F(Quaternion u091Cu0921u091Bu0920u0926u0923u0922u091Bu0926u091Au0926, Quaternion u091Au091Eu091Bu091Fu091Eu091Bu091Eu0926u091Fu0922u0923) => default; // 0x0000000181450BE0-0x0000000181450C80
		public virtual Vector3 u0921u0920u0920u091Fu091Fu091Cu0925u091Fu091Bu0928u0924() => default; // 0x0000000181449E00-0x0000000181449E20
		protected virtual Quaternion u091Du0929u0925u0920u0924u091Du0922u0927u091Eu0929u091B(Quaternion u091Cu0921u091Bu0920u0926u0923u0922u091Bu0926u091Au0926, Quaternion u091Au091Eu091Bu091Fu091Eu091Bu091Eu0926u091Fu0922u0923) => default; // 0x000000018144C4D0-0x000000018144C570
		public virtual Vector3 u0926u091Eu0925u0925u0929u0929u0922u0922u091Du091Cu091B() => default; // 0x0000000181449E00-0x0000000181449E20
		protected virtual float u091Bu0920u091Du0925u0921u0920u0920u0923u091Cu091Fu0921() => default; // 0x000000018144AFC0-0x000000018144B1E0
		protected virtual void u0928u0925u0923u091Cu091Au0921u091Cu0927u0923u091Cu0923() {} // 0x0000000181450C80-0x0000000181450CF0
		protected virtual void u091Au0929u091Fu0929u0925u091Fu0922u091Au091Du0921u0924(Vector3 u0927u0921u091Fu091Eu0923u0927u0922u0929u091Cu0921u0929, float u091Fu0927u0929u0924u091Du091Du0925u0923u0929u091Du0921) {} // 0x000000018144ACD0-0x000000018144AF10
		protected virtual void u091Eu091Eu0920u0920u0925u091Bu091Bu091Bu091Au0927u0926(GameObject u0923u0926u091Cu091Bu091Au0921u091Cu0925u0922u0925u0922, bool u0928u0926u091Eu0929u0929u0927u091Fu0926u0922u0920u0923, ref bool u091Au0921u0921u0926u0920u091Du091Au0924u0926u091Eu091D, ref bool u0924u091Eu091Bu0927u091Bu0922u091Bu0922u0924u0922u0925) {} // 0x000000018144C7B0-0x000000018144C800
		public virtual Vector3 GetMovementDirection() => default; // 0x0000000181449E00-0x0000000181449E20
		public virtual void SetControlOptions(u091Au0925u091Du0922u0925u091Fu0924u091Bu091Eu0920u0925 u0926u0923u091Bu091Eu091Cu091Cu091Du091Du0926u0924u091F) {} // 0x000000018144A770-0x000000018144AB00
		protected virtual void u091Au0927u0922u091Fu0922u0921u091Au0925u0921u0921u0927(GameObject u0923u0926u091Cu091Bu091Au0921u091Cu0925u0922u0925u0922, bool u0928u0926u091Eu0929u0929u0927u091Fu0926u0922u0920u0923, ref bool u091Au0921u0921u0926u0920u091Du091Au0924u0926u091Eu091D, bool u091Fu091Cu091Eu091Au0929u0925u091Au091Du0928u091Bu091F = false /* Metadata: 0x00653D52 */) {} // 0x000000018144AC20-0x000000018144ACD0
		protected virtual void u091Bu0925u091Eu0920u091Bu091Du091Du0927u0924u0922u0924() {} // 0x000000018144B2C0-0x000000018144B340
		public virtual float u0921u091Du0928u0927u0927u0927u091Du0921u0929u0921u0922() => default; // 0x0000000181449E20-0x0000000181449E30
		protected virtual Vector3 u091Bu0921u091Bu0923u0929u0922u091Du091Fu0929u091Cu0922(Vector3 u091Cu0927u0925u0925u091Eu0921u0923u0928u0926u091Du0927) => default; // 0x000000018144B1E0-0x000000018144B2C0
		protected virtual void u091Eu091Cu091Eu091Eu0924u0921u091Bu0922u091Eu0929u091B(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Eu0929u091Au091Eu0929u0924u0922u0929u0923u0928u091D u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018144C670-0x000000018144C7B0
		protected virtual bool u0925u0926u0921u091Bu0920u091Bu0929u0924u0924u091Du091A(VRTK_BodyPhysics u0929u0921u0923u091Du0929u091Bu0920u0923u091Du0926u0927, Vector3 u091Bu0927u091Cu091Cu0929u091Du0926u091Du091Bu0928u0922, Vector3 u0921u091Du091Du091Fu091Du0928u091Cu091Au091Eu091Bu0922) => default; // 0x000000018144E370-0x000000018144E500
		public virtual float u0922u091Fu0922u0929u0923u091Eu091Bu091Bu0924u0925u091E() => default; // 0x0000000181449E20-0x0000000181449E30
		protected virtual void Awake() {} // 0x0000000181449B40-0x0000000181449BB0
		protected virtual void u091Eu091Au091Bu091Fu091Au0923u091Eu0925u0927u0926u0922() {} // 0x000000018144C570-0x000000018144C670
		protected virtual void FixedUpdate() {} // 0x0000000181449BB0-0x0000000181449E00
		protected virtual void u0922u091Fu0922u0923u0925u091Eu0921u0928u091Cu0926u0924(GameObject u0923u0926u091Cu091Bu091Au0921u091Cu0925u0922u0925u0922, bool u0928u0926u091Eu0929u0929u0927u091Fu0926u0922u0920u0923, ref bool u091Au0921u0921u0926u0920u091Du091Au0924u0926u091Eu091D, bool u091Fu091Cu091Eu091Au0929u0925u091Au091Du0928u091Bu091F = false /* Metadata: 0x00653D53 */) {} // 0x000000018144DB20-0x000000018144DBE0
		protected virtual bool u0924u0929u0920u0928u0927u0924u0927u091Au0927u0928u0920() => default; // 0x000000018144DF10-0x000000018144DF30
		protected virtual void u091Cu091Du0929u0927u0924u091Cu0920u0925u091Au0925u0922(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Eu0929u091Au091Eu0929u0924u0922u0929u0923u0928u091D u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018144B4C0-0x000000018144B4F0
		public virtual void u0920u0921u0923u091Cu0925u0922u0920u0929u0927u0925u0923(u091Au0925u091Du0922u0925u091Fu0924u091Bu091Eu0920u0925 u0926u0923u091Bu091Eu091Cu091Cu091Du091Du0926u0924u091F) {} // 0x000000018144D020-0x000000018144D3B0
		protected virtual void u0924u0926u091Bu0923u0927u091Fu0924u0922u091Au091Bu091C() {} // 0x000000018144DEA0-0x000000018144DF10
		protected virtual void u091Cu091Fu0927u0926u0928u0923u091Eu091Du0929u091Du0925(GameObject u0923u0926u091Cu091Bu091Au0921u091Cu0925u0922u0925u0922, bool u0928u0926u091Eu0929u0929u0927u091Fu0926u0922u0920u0923, ref bool u091Au0921u0921u0926u0920u091Du091Au0924u0926u091Eu091D, ref bool u0924u091Eu091Bu0927u091Bu0922u091Bu0922u0924u0922u0925) {} // 0x000000018144B4F0-0x000000018144B540
		protected virtual void u0927u0923u091Bu0924u091Eu0920u091Bu0925u0924u091Eu0928(GameObject u0923u0926u091Cu091Bu091Au0921u091Cu0925u0922u0925u0922, bool u0928u0926u091Eu0929u0929u0927u091Fu0926u0922u0920u0923, ref bool u091Au0921u0921u0926u0920u091Du091Au0924u0926u091Eu091D, ref bool u0924u091Eu091Bu0927u091Bu0922u091Bu0922u0924u0922u0925) {} // 0x000000018144CA70-0x000000018144CAC0
		protected virtual Quaternion u0924u0929u0927u091Du0925u0929u091Cu0920u0922u091Au091F() => default; // 0x000000018144DF30-0x000000018144E1E0
		protected virtual void u091Du0922u0927u0922u091Cu0923u0925u0929u091Fu0923u0920(GameObject u0923u0926u091Cu091Bu091Au0921u091Cu0925u0922u0925u0922, bool u091Fu091Du0929u091Au0927u0928u0921u091Fu0926u0928u0925, ref bool u0923u0925u0924u0927u0924u0920u0927u0928u0925u0926u0926) {} // 0x000000018144C120-0x000000018144C3E0
		protected virtual bool u0927u091Eu0922u0928u091Cu091Fu091Eu0923u091Au091Bu0921(VRTK_BodyPhysics u0929u0921u0923u091Du0929u091Bu0920u0923u091Du0926u0927, Vector3 u091Bu0927u091Cu091Cu0929u091Du0926u091Du091Bu0928u0922, Vector3 u0921u091Du091Du091Fu091Du0928u091Cu091Au091Eu091Bu0922) => default; // 0x000000018144EF90-0x000000018144F120
		protected virtual void u091Eu0920u0921u091Au0921u091Au091Du0927u0929u0921u091F(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Eu0929u091Au091Eu0929u0924u0922u0929u0923u0928u091D u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018144C800-0x000000018144C830
		protected virtual void u0921u0926u0926u091Bu0929u091Cu091Cu091Du0922u0922u091F() {} // 0x000000018144DA90-0x000000018144DB00
		protected virtual Vector3 u0926u0923u091Du0929u0929u0922u091Cu0921u0928u0929u0922() => default; // 0x000000018144E690-0x000000018144EF90
		protected virtual void u091Fu0928u0929u091Bu091Eu0929u0925u0925u0924u091Au0928(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Eu0929u091Au091Eu0929u0924u0922u0929u0923u0928u091D u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018144CEE0-0x000000018144D020
		protected virtual void u0929u0926u0926u0929u0921u0920u0923u091Bu0920u0928u091A(GameObject u0923u0926u091Cu091Bu091Au0921u091Cu0925u0922u0925u0922, bool u091Fu091Du0929u091Au0927u0928u0921u091Fu0926u0928u0925, ref bool u0923u0925u0924u0927u0924u0920u0927u0928u0925u0926u0926) {} // 0x0000000181450DF0-0x00000001814510C0
		protected virtual void u091Du0920u091Eu0920u091Bu0921u0928u0921u0922u0925u0923(GameObject u0923u0926u091Cu091Bu091Au0921u091Cu0925u0922u0925u0922, bool u091Fu091Du0929u091Au0927u0928u0921u091Fu0926u0928u0925, ref bool u0923u0925u0924u0927u0924u0920u0927u0928u0925u0926u0926) {} // 0x000000018144BE60-0x000000018144C120
		protected virtual void u091Fu0920u0923u091Au091Eu091Eu0920u091Du0929u0925u0928() {} // 0x000000018144CB80-0x000000018144CDE0
		protected virtual void u0924u0921u0928u0921u0926u091Au091Du0929u091Cu0920u091E() {} // 0x000000018144DE20-0x000000018144DEA0
		protected virtual void u0929u091Au0928u0927u091Bu0920u0924u091Du0922u091Eu0924() {} // 0x0000000181450CF0-0x0000000181450DF0
		protected virtual void u0921u091Au091Bu0920u0926u0929u0922u0922u0922u091Au0920() {} // 0x000000018144D980-0x000000018144DA90
		public virtual float u0925u0928u0923u0928u0925u091Du091Cu091Cu0926u091Cu0927() => default; // 0x0000000181449E20-0x0000000181449E30
		public virtual Vector3 u091Fu091Bu091Du0920u091Au0921u091Au0925u091Au091Bu091B() => default; // 0x0000000181449E00-0x0000000181449E20
		protected virtual void u091Fu0926u0925u0927u091Cu0927u091Au0924u091Eu091Fu091A() {} // 0x000000018144CDE0-0x000000018144CEE0
		protected virtual Vector3 u0927u0923u0926u0926u091Au0927u091Fu0920u0927u091Cu0924() => default; // 0x000000018144F120-0x000000018144FB00
		protected virtual void u091Du0926u0922u091Cu091Du0921u0922u0928u0920u091Eu0920() {} // 0x000000018144C3E0-0x000000018144C4D0
		protected virtual void u091Au091Fu091Bu091Fu0926u0922u0923u0925u091Au0927u0929() {} // 0x000000018144ABA0-0x000000018144AC20
		protected virtual Quaternion u0920u0923u0924u0921u0923u0928u091Eu0924u0924u091Eu0925() => default; // 0x000000018144D3B0-0x000000018144D660
		protected virtual void u0928u0923u091Du091Bu091Eu0927u0925u0924u0921u0929u0929() {} // 0x0000000181450980-0x0000000181450BE0
		protected virtual void OnEnable() {} // 0x0000000181449F60-0x000000018144A770
		protected virtual Quaternion u091Au091Au0921u091Du091Fu0921u0922u0920u0922u0926u091B(Quaternion u091Cu0921u091Bu0920u0926u0923u0922u091Bu0926u091Au0926, Quaternion u091Au091Eu091Bu091Fu091Eu091Bu091Eu0926u091Fu0922u0923) => default; // 0x000000018144AB00-0x000000018144ABA0
		protected virtual void u091Eu0929u0928u091Fu091Au0928u0925u091Fu0929u0924u0926(GameObject u0923u0926u091Cu091Bu091Au0921u091Cu0925u0922u0925u0922, bool u0928u0926u091Eu0929u0929u0927u091Fu0926u0922u0920u0923, ref bool u091Au0921u0921u0926u0920u091Du091Au0924u0926u091Eu091D, ref bool u0924u091Eu091Bu0927u091Bu0922u091Bu0922u0924u0922u0925) {} // 0x000000018144CA70-0x000000018144CAC0
		protected virtual void u091Cu0923u0928u091Eu091Au091Cu0929u091Fu0923u091Cu091C() {} // 0x000000018144B540-0x000000018144B630
		protected virtual Vector3 u0928u0922u091Bu0925u0923u091Cu091Fu091Bu0926u0922u0927() => default; // 0x000000018144FFA0-0x0000000181450980
		protected virtual void u091Du091Cu091Du0924u0923u091Fu091Eu0922u0921u0929u0927(Vector3 u0927u0921u091Fu091Eu0923u0927u0922u0929u091Cu0921u0929, float u091Fu0927u0929u0924u091Du091Du0925u0923u0929u091Du0921) {} // 0x000000018144BAE0-0x000000018144BD20
		protected virtual void u091Du091Eu0921u0926u091Eu0928u0923u0924u091Du0926u0925(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Eu0929u091Au091Eu0929u0924u0922u0929u0923u0928u091D u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018144BD20-0x000000018144BE60
		protected virtual void u091Bu091Du0927u091Du091Cu091Bu0922u0927u0923u091Cu0922(GameObject u0923u0926u091Cu091Bu091Au0921u091Cu0925u0922u0925u0922, bool u0928u0926u091Eu0929u0929u0927u091Fu0926u0922u0920u0923, ref bool u091Au0921u0921u0926u0920u091Du091Au0924u0926u091Eu091D, bool u091Fu091Cu091Eu091Au0929u0925u091Au091Du0928u091Bu091F = false /* Metadata: 0x00653D54 */) {} // 0x000000018144AF10-0x000000018144AFC0
		protected virtual void u0923u091Fu091Cu091Au0928u091Cu0921u091Fu0929u0927u0923(Vector3 u0927u0921u091Fu091Eu0923u0927u0922u0929u091Cu0921u0929, float u091Fu0927u0929u0924u091Du091Du0925u0923u0929u091Du0921) {} // 0x000000018144DBE0-0x000000018144DE20
		public virtual float u0925u091Fu0924u0921u0926u0920u0929u0920u0927u091Au0929() => default; // 0x0000000181449E20-0x0000000181449E30
		protected virtual void OnDisable() {} // 0x0000000181449EA0-0x0000000181449F60
		public virtual float GetSpeed() => default; // 0x0000000181449E20-0x0000000181449E30
		protected virtual bool u0922u091Au091Eu0924u0922u0927u091Fu091Au0929u0928u0926() => default; // 0x000000018144DB00-0x000000018144DB20
		protected virtual void u0928u091Du0928u091Du0929u0923u0925u091Cu091Du0928u091C() {} // 0x000000018144FD40-0x000000018144FFA0
		protected virtual void u0924u0928u091Au091Au0926u091Bu0926u091Bu091Du091Fu0924(GameObject u0923u0926u091Cu091Bu091Au0921u091Cu0925u0922u0925u0922, bool u0928u0926u091Eu0929u0929u0927u091Fu0926u0922u0920u0923, ref bool u091Au0921u0921u0926u0920u091Du091Au0924u0926u091Eu091D, ref bool u0924u091Eu091Bu0927u091Bu0922u091Bu0922u0924u0922u0925) {} // 0x000000018144B4F0-0x000000018144B540
	}
}