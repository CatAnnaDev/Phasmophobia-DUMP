﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using VRTK.Highlighters;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace VRTK
{
	[ExecuteInEditMode] // 0x00000001800D4E50-0x00000001800D4E60
	public class VRTK_SnapDropZone : MonoBehaviour // TypeDefIndex: 7471
	{
		// Fields
		public GameObject u0929u091Cu0920u091Bu091Au0928u091Au091Bu091Cu0927u0920; // 0x18
		public u091Eu091Du0928u0920u0920u0920u091Bu0929u0927u0922u0925 u0925u0923u0929u091Cu0929u091Fu0923u091Fu0920u0922u091F; // 0x20
		public float u0922u0921u0925u091Eu091Fu091Au0926u0920u0924u091Du0921; // 0x24
		public bool u0924u0927u091Eu091Fu091Au0923u0925u0920u091Fu0924u0926; // 0x28
		public bool u0923u0929u091Du0920u091Du0920u0925u091Bu091Du091Eu0923; // 0x29
		public Color u0926u091Du091Du0920u091Eu0922u091Cu0921u0928u0923u091C; // 0x2C
		public bool u0925u091Bu091Fu0923u091Bu091Bu0922u0927u091Au091Cu0929; // 0x3C
		public VRTK_PolicyList u0928u091Bu0928u0922u0922u0928u0928u091Bu0923u091Du0922; // 0x40
		public bool u091Au091Cu091Du091Eu0921u0924u0926u091Du0922u0929u0921; // 0x48
		public GameObject u0928u091Eu0924u0923u091Bu0926u0922u0923u0927u0926u0923; // 0x50
		protected GameObject u0928u0923u091Eu091Fu0925u091Cu091Fu0922u091Eu0922u0926; // 0x78
		protected GameObject u0923u0928u091Bu091Au0926u0927u0924u0922u0924u0921u0922; // 0x80
		protected GameObject u0924u0927u091Bu0926u091Bu091Cu0922u0926u0920u0921u0928; // 0x88
		protected GameObject u091Eu0927u0921u0927u091Cu091Fu0929u0926u0924u091Du091A; // 0x90
		protected List<GameObject> u0928u0923u0923u0929u0922u0924u0924u0928u0921u0920u0928; // 0x98
		protected GameObject u0925u0924u091Bu091Bu0920u0921u091Eu0920u091Cu0920u091B; // 0xA0
		protected GameObject u0925u0926u091Au0926u0926u091Eu0929u091Du0924u0928u0921; // 0xA8
		protected bool[] u0920u0923u0924u0920u091Du0925u0921u091Au0929u0927u0925; // 0xB0
		protected VRTK_BaseHighlighter u0921u091Bu091Au091Cu0927u0929u091Au091Eu091Bu0920u091A; // 0xB8
		protected bool u0925u091Du0923u0925u0923u0921u091Au0922u0921u0929u091A; // 0xC0
		protected bool u0928u0920u0924u0920u091Fu091Du0920u091Du0921u0922u091F; // 0xC1
		protected bool u091Au0928u0926u0929u0926u091Fu0927u0923u0927u091Au0921; // 0xC2
		protected bool u0927u091Au0928u0923u091Du091Eu091Du091Cu091Fu0922u0922; // 0xC3
		protected Coroutine u091Au091Fu0920u091Bu0922u0922u091Fu0923u0921u0923u0922; // 0xC8
		protected bool u0928u0928u0921u0924u091Bu0926u0927u0924u091Du0923u091C; // 0xD0
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private PhotonView view; // 0xD8
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool isHeadCamDropZone; // 0xE0
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool isBeltDropZone; // 0xE1
		protected static string u0926u0924u091Fu0922u0925u0921u0924u0928u091Au0922u0920 = null; // 0x00
		protected static string u091Bu0923u0928u091Eu091Du0921u091Eu091Bu091Eu0920u0924 = null; // 0x08
		protected static string u0928u0921u0925u0926u0923u0927u0921u0922u0924u0927u0920 = null; // 0x10
	
		// Events
		public event u0924u0922u0923u0924u0927u0923u0925u0929u091Eu0921u0920 u091Eu091Cu0924u0921u0921u0922u091Eu0928u0924u0924u0920;
		public event u0924u0922u0923u0924u0927u0923u0925u0929u091Eu0921u0920 u0923u0920u0929u0928u0922u091Eu0923u0921u091Cu091Eu091F;
		public event u0924u0922u0923u0924u0927u0923u0925u0929u091Eu0921u0920 u0926u0922u0921u0925u091Cu091Au0925u091Au0922u091Bu091C;
		public event u0924u0922u0923u0924u0927u0923u0925u0929u091Eu0921u0920 u0929u0927u0922u0924u091Au0925u0924u0929u091Eu091Eu091C;
	
		// Nested types
		public enum u091Eu091Du0928u0920u0920u0920u091Bu0929u0927u0922u0925 // TypeDefIndex: 7472
		{
			UseKinematic = 0,
			UseJoint = 1,
			UseParenting = 2
		}
	
		// Constructors
		public VRTK_SnapDropZone() {} // 0x0000000181488720-0x00000001814887B0
		static VRTK_SnapDropZone() {} // 0x0000000181488690-0x0000000181488720
	
		// Methods
		public void u0927u091Au0925u091Bu091Du091Fu091Eu091Cu091Eu091Au091A(u0924u0922u0923u0924u0927u0923u0925u0929u091Eu0921u0920 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x00000001814871A0-0x0000000181487240
		protected virtual void OnTriggerStay(Collider u091Bu0920u0925u0929u091Fu091Au0923u091Eu0925u0928u0927) {} // 0x0000000181481540-0x00000001814816A0
		public virtual List<GameObject> GetHoveringObjects() => default; // 0x0000000180274970-0x0000000180274980
		protected virtual void u091Cu0921u091Bu091Eu0927u0921u0924u091Cu0920u0929u091B() {} // 0x00000001814822A0-0x0000000181482350
		protected virtual void u091Au0921u091Fu0926u0920u0926u0929u091Eu091Au0924u091A(GameObject u091Fu091Au0927u0921u0923u0921u0922u0924u0926u091Du091D) {} // 0x0000000181481B60-0x0000000181481F70
		public virtual bool IsObjectHovering(GameObject u0924u0921u091Du0923u091Au0920u091Cu0920u0928u0921u091B) => default; // 0x00000001814810C0-0x0000000181481120
		protected virtual void u091Fu0920u091Eu0921u0921u0923u0925u091Fu0923u091Eu0927(PhotonObjectInteract u0928u0926u091Eu091Du0921u0922u0923u0923u091Fu091Au0923) {} // 0x0000000181483770-0x0000000181483A40
		protected virtual void u0922u091Cu0928u091Au0927u0921u0929u0923u091Eu091Fu0927() {} // 0x0000000181484840-0x00000001814848F0
		// [IteratorStateMachine] // 0x0000000180139A70-0x0000000180139AC0
		protected virtual IEnumerator u091Cu091Au0925u0924u091Cu091Eu0925u091Eu0921u091Fu0922(PhotonObjectInteract u0928u0926u091Eu091Du0921u0922u0923u0923u091Fu091Au0923, GameObject u0925u0929u0925u091Du0921u0922u091Fu091Du091Bu091Fu0925, Vector3 u091Fu091Fu091Eu091Du0929u0923u0928u0922u0924u091Fu0920, float u0926u0927u091Du0923u0920u091Cu091Fu0921u091Cu0927u091C) => default; // 0x00000001814820B0-0x0000000181482180
		protected virtual void u0923u0924u0925u0921u0927u091Fu0926u0920u091Fu091Au0925() {} // 0x0000000181481AC0-0x0000000181481B60
		protected virtual void u091Eu091Cu0925u091Bu091Bu091Au0924u0923u0925u091Fu0926() {} // 0x0000000181483150-0x00000001814833A0
		protected virtual void u0920u0920u0920u0923u091Du091Eu091Eu0920u0926u0929u091E() {} // 0x0000000181483E90-0x0000000181483F40
		protected virtual void u0926u0929u091Bu091Au0927u091Eu0926u0929u0922u091Fu091A() {} // 0x0000000181486F50-0x00000001814871A0
		protected virtual void u0927u0923u0927u0929u091Bu0921u0920u091Du0921u0922u0925(Rigidbody u091Fu0925u091Eu091Fu0928u0926u0922u091Fu091Fu0924u0925) {} // 0x0000000181487590-0x00000001814879D0
		protected virtual void u0922u0923u0925u0927u0922u0928u0922u0929u091Cu091Cu091E(Collider u091Bu0920u0925u0929u091Fu091Au0923u091Eu0925u0928u0927, bool u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925) {} // 0x0000000181484BB0-0x0000000181484DE0
		protected virtual void u0929u091Fu0927u0926u0920u091Du091Cu091Du091Eu0927u091A() {} // 0x0000000181488290-0x0000000181488540
		protected virtual void u0925u0923u091Au0929u0927u091Cu0924u0924u0920u0925u091F(GameObject u091Fu091Au0927u0921u0923u0921u0922u0924u0926u091Du091D) {} // 0x0000000181486110-0x0000000181486510
		protected virtual void u0927u0924u091Cu0922u091Au091Eu091Du091Du0929u0921u0921() {} // 0x00000001814879D0-0x0000000181487C60
		protected virtual void u0926u091Bu0926u0923u091Eu0927u091Fu091Au0925u091Du0928() {} // 0x0000000181486650-0x00000001814866D0
		protected virtual void u0927u091Eu0929u091Au0926u0924u0926u0923u0922u0923u0926(GameObject u0929u091Eu0923u091Fu0928u091Cu0925u0928u091Eu0920u091C) {} // 0x0000000181487470-0x00000001814874F0
		protected virtual void u0921u0920u091Au0928u0923u0927u0921u0926u0925u0927u091E() {} // 0x00000001814841C0-0x0000000181484270
		protected virtual void u0927u0923u091Du0920u0926u0923u0926u0923u091Bu0927u0929() {} // 0x00000001814874F0-0x0000000181487590
		protected virtual Vector3 u091Fu0926u0921u0922u091Eu091Fu091Du091Fu091Au091Fu091B(VRTK_InteractableObject u0928u0926u091Eu091Du0921u0922u0923u0923u091Fu091Au0923) => default; // 0x0000000181483A40-0x0000000181483BA0
		protected virtual void u0924u091Du091Fu091Bu0929u0920u091Fu0920u0921u0926u091C() {} // 0x0000000181485A90-0x0000000181485CE0
		protected virtual void u0926u0925u0929u091Fu0921u0922u0929u0920u091Eu0922u091C(Transform u0922u0928u0927u091Bu091Au0925u091Fu0927u0921u091Fu091F) {} // 0x0000000181486CF0-0x0000000181486D90
		public void u091Cu0926u0928u0929u0928u0924u0928u0927u0927u0920u091B(u0924u0922u0923u0924u0927u0923u0925u0929u091Eu0921u0920 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x0000000181482350-0x00000001814823F0
		public virtual void InitaliseHighlightObject(bool u0924u0927u0925u0923u0925u0922u091Au0922u0921u0928u0924 = false /* Metadata: 0x0065386B */) {} // 0x0000000181480FF0-0x00000001814810C0
		protected virtual string u091Cu091Du091Eu0924u091Au091Au0923u0922u0925u0928u091D(string u091Du0925u091Eu091Bu091Fu0925u0926u091Au0928u0921u0923) => default; // 0x00000001814821C0-0x0000000181482200
		private IEnumerator u091Du0924u0924u091Eu091Cu091Eu0922u0921u091Du0927u091F(PhotonObjectInteract u0928u0926u091Eu091Du0921u0922u0923u0923u091Fu091Au0923) => default; // 0x0000000181482AF0-0x0000000181482B80
		protected virtual void OnDrawGizmosSelected() {} // 0x00000001814811D0-0x00000001814813A0
		protected virtual Vector3 u0924u091Bu0920u0927u091Au0924u091Cu091Bu0924u0929u091F(VRTK_InteractableObject u0928u0926u091Eu091Du0921u0922u0923u0923u091Fu091Au0923) => default; // 0x0000000181485880-0x00000001814859E0
		protected virtual void u0924u091Fu091Du0924u0921u091Cu091Du091Fu0924u0928u0928(Collider u091Bu0920u0925u0929u091Fu091Au0923u091Eu0925u0928u0927) {} // 0x0000000181485CE0-0x0000000181485D50
		protected virtual void Update() {} // 0x00000001814885C0-0x0000000181488640
		protected virtual void u0926u091Fu091Du091Bu091Au091Fu0922u091Cu0924u0927u0920() {} // 0x00000001814866D0-0x0000000181486790
		public void u091Cu091Fu091Au0921u0925u0920u0924u0927u0926u091Fu0927(u0924u0922u0923u0924u0927u0923u0925u0929u091Eu0921u0920 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x0000000181482200-0x00000001814822A0
		public void u0921u0922u0928u091Cu0923u0927u0926u0920u0925u0928u091C(u0924u0922u0923u0924u0927u0923u0925u0929u091Eu0921u0920 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x00000001814843D0-0x0000000181484470
		protected virtual void u0920u091Au091Eu0925u0927u0922u0926u0920u0923u0927u091A() {} // 0x0000000181483DC0-0x0000000181483E90
		protected virtual void u0927u091Bu0927u091Bu0923u0926u091Cu091Au0928u0926u091B(Collider u091Bu0920u0925u0929u091Fu091Au0923u091Eu0925u0928u0927, bool u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925) {} // 0x0000000181487240-0x0000000181487470
		protected virtual void u0928u0926u091Au091Du0929u0929u0925u0923u0922u0921u0920() {} // 0x0000000181481A70-0x0000000181481AC0
		protected virtual void u0926u091Fu091Du0926u0922u0922u091Bu091Au091Au091Eu091A() {} // 0x0000000181486790-0x0000000181486AA0
		protected virtual IEnumerator u0926u0920u0929u0921u0929u0922u0922u0926u0929u0925u0925(PhotonObjectInteract u0928u0926u091Eu091Du0921u0922u0923u0923u091Fu091Au0923, GameObject u0925u0929u0925u091Du0921u0922u091Fu091Du091Bu091Fu0925, Vector3 u091Fu091Fu091Eu091Du0929u0923u0928u0922u0924u091Fu0920, float u0926u0927u091Du0923u0920u091Cu091Fu0921u091Cu0927u091C) => default; // 0x0000000181486AA0-0x0000000181486B70
		public virtual GameObject u091Cu091Fu0920u091Au091Du091Au0924u0920u091Au091Eu091E() => default; // 0x00000001802749B0-0x00000001802749C0
		public virtual bool ValidSnappableObjectIsHovering() => default; // 0x0000000181488640-0x0000000181488690
		public virtual void u0921u091Eu0926u0923u0927u091Fu0929u0929u091Cu0924u0920(u0926u091Du091Fu091Au091Fu091Du091Du091Cu0923u091Eu0927 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181481440-0x0000000181481460
		protected virtual void u0923u0923u091Fu0929u0921u0927u0927u091Du0929u0925u0928(Collider u091Bu0920u0925u0929u091Fu091Au0923u091Eu0925u0928u0927) {} // 0x0000000181485250-0x00000001814855A0
		protected virtual void u0927u0925u0926u091Du091Fu0927u0924u0924u0922u091Cu0927() {} // 0x0000000181487C60-0x0000000181487D20
		public virtual void OnObjectSnappedToDropZone(u0926u091Du091Fu091Au091Fu091Du091Du091Cu0923u091Eu0927 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000180FCFA40-0x0000000180FCFA60
		protected virtual void u091Du0920u0924u091Bu0923u091Au0928u0922u0922u0920u091C() {} // 0x00000001814824A0-0x0000000181482730
		protected virtual void u0928u0928u0928u0929u0925u091Cu091Fu0923u091Du0928u091D(GameObject u0928u091Fu0926u0922u091Eu0922u0927u0921u091Bu0921u0922, ref GameObject u091Bu0928u0922u0923u091Eu091Fu0925u091Au091Eu091Fu091B, string u091Au0926u0924u0927u0925u0927u0929u0922u091Bu0925u0927) {} // 0x0000000181487F90-0x00000001814881F0
		public virtual void ForceSnap(GameObject u0927u091Bu091Fu091Cu091Au091Fu091Cu0925u0923u091Bu091F) {} // 0x0000000181480DB0-0x0000000181480EF0
		public virtual u0926u091Du091Fu091Au091Fu091Du091Du091Cu0923u091Eu0927 SetSnapDropZoneEvent(GameObject u091Du091Du0923u0920u0929u0929u0920u091Fu0923u0923u0924) => default; // 0x0000000180FCFF40-0x0000000180FCFF60
		protected virtual void u0928u0925u0929u0922u0921u0923u0920u0924u0922u091Fu091E() {} // 0x0000000181487D20-0x0000000181487F90
		public virtual GameObject GetCurrentSnappedObject() => default; // 0x00000001802749B0-0x00000001802749C0
		protected virtual void u0924u091Bu0923u0928u091Bu0922u0922u0925u091Du0921u091F() {} // 0x00000001814859E0-0x0000000181485A90
		protected virtual void u091Fu0927u0923u0925u0921u091Cu0926u091Cu0929u091Eu0925() {} // 0x0000000181483BA0-0x0000000181483DC0
		protected virtual string u091Cu091Du091Bu0925u0920u091Fu0929u0921u091Cu0925u0924(string u091Du0925u091Eu091Bu091Fu0925u0926u091Au0928u0921u0923) => default; // 0x0000000181482180-0x00000001814821C0
		protected virtual void u0920u0921u0929u0927u091Du0922u0926u0928u0927u091Bu091E() {} // 0x0000000181483F40-0x0000000181484000
		protected virtual void u091Eu091Bu091Eu0921u0920u0928u0922u0925u0921u0928u091D() {} // 0x0000000181482B80-0x0000000181482E30
		protected virtual void u0925u0923u091Du091Du091Cu091Bu0923u0925u0924u0923u091F() {} // 0x0000000181486510-0x00000001814865D0
		protected virtual void u091Du091Fu0928u091Fu091Au0921u0922u0925u0925u0926u0925() {} // 0x00000001814823F0-0x00000001814824A0
		protected virtual void u091Eu091Cu091Eu091Au0922u0920u0927u091Bu0922u0926u0920() {} // 0x0000000181482E30-0x0000000181483150
		protected virtual void u091Fu091Cu091Eu0924u0927u091Du0929u091Eu0925u091Du0921(Collider u091Bu0920u0925u0929u091Fu091Au0923u091Eu0925u0928u0927) {} // 0x0000000181483420-0x0000000181483770
		protected virtual void u0920u0928u0922u091Du0925u0928u0925u0923u0925u091Au091F() {} // 0x0000000181484090-0x0000000181484170
		protected virtual void Awake() {} // 0x0000000181480CF0-0x0000000181480DB0
		protected virtual void u0921u0920u091Fu0927u0928u0920u0928u0923u091Fu0920u0922(Collider u091Bu0920u0925u0929u091Fu091Au0923u091Eu0925u0928u0927) {} // 0x0000000181484270-0x00000001814843D0
		public virtual void u0920u091Du0925u091Du091Au0929u0921u091Cu0921u0929u0929(u0926u091Du091Fu091Au091Fu091Du091Du091Cu0923u091Eu0927 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000180FCFA60-0x0000000180FCFA80
		// [IteratorStateMachine] // 0x0000000180139D90-0x0000000180139DE0
		private IEnumerator u0920u0926u0920u0928u0929u0920u091Fu0929u091Fu091Au091A(PhotonObjectInteract u0928u0926u091Eu091Du0921u0922u0923u0923u091Fu091Au0923) => default; // 0x0000000181484000-0x0000000181484090
		protected virtual void u0925u0922u091Du091Fu091Du0928u0927u091Fu091Eu091Au0928(GameObject u091Au0922u0927u0923u0920u0923u0923u0926u091Du0928u0921) {} // 0x0000000181485FF0-0x0000000181486110
		protected virtual void u0926u0922u091Fu0924u0920u0921u0926u0925u091Fu091Du0929(GameObject u0927u091Bu091Fu091Cu091Au091Fu091Cu0925u0923u091Bu091F) {} // 0x0000000181486B70-0x0000000181486C00
		protected virtual void u091Au091Bu091Au091Du091Eu0928u0928u091Fu091Bu0925u091C() {} // 0x0000000181481A70-0x0000000181481AC0
		public virtual void u0926u0927u091Bu0923u091Fu0927u091Du091Bu0928u0921u091B(bool u0924u0927u0925u0923u0925u0922u091Au0922u0921u0928u0924 = false /* Metadata: 0x0065386C */) {} // 0x0000000181486E80-0x0000000181486F50
		public virtual void OnObjectUnsnappedFromDropZone(u0926u091Du091Fu091Au091Fu091Du091Du091Cu0923u091Eu0927 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181481460-0x00000001814814B0
		[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
		private void SyncDropZone(int u0925u091Bu091Cu0927u0921u0921u0929u0927u0928u0924u0926) {} // 0x0000000181481780-0x0000000181481A70
		public virtual bool u0921u091Du091Eu091Fu091Fu091Fu0926u0926u0921u0921u0922() => default; // 0x0000000181484170-0x00000001814841C0
		protected virtual void u091Bu0923u091Fu091Du0925u0924u091Bu091Du0927u0929u091B() {} // 0x0000000181482010-0x00000001814820B0
		private void Start() {} // 0x00000001814816A0-0x0000000181481780
		protected virtual void u0923u0926u0921u0921u091Fu0924u0923u091Fu0920u091Bu091F() {} // 0x00000001814855A0-0x00000001814857F0
		public virtual void OnObjectEnteredSnapDropZone(u0926u091Du091Fu091Au091Fu091Du091Du091Cu0923u091Eu0927 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181481440-0x0000000181481460
		protected virtual void u091Au091Bu091Bu0921u0921u0922u0927u0928u0920u0928u0923() {} // 0x0000000181481AC0-0x0000000181481B60
		protected virtual void u091Bu0928u0926u0924u0928u091Bu0928u091Du0923u0920u091F() {} // 0x0000000181481A70-0x0000000181481AC0
		protected virtual void u0922u0925u0921u0928u0923u091Du0927u0921u0929u0925u091F() {} // 0x0000000181484DE0-0x0000000181484EC0
		protected virtual void u0923u091Eu0929u0928u091Cu0927u091Au091Bu0926u091Du0925() {} // 0x0000000181485080-0x0000000181485250
		protected virtual void u091Du0920u0926u0926u091Eu091Fu091Fu091Bu0926u0927u091D() {} // 0x0000000181482730-0x0000000181482A50
		public virtual void ForceUnsnap() {} // 0x0000000181480EF0-0x0000000181480FF0
		protected virtual void OnTriggerExit(Collider u091Bu0920u0925u0929u091Fu091Au0923u091Eu0925u0928u0927) {} // 0x00000001814814D0-0x0000000181481540
		protected virtual void u091Eu0926u0921u0926u091Du0929u091Au0922u091Du0929u0924() {} // 0x00000001814833A0-0x0000000181483420
		protected virtual void OnApplicationQuit() {} // 0x0000000181481120-0x00000001814811D0
		protected virtual void u0922u0920u0925u0921u0921u091Bu0925u091Eu0928u0920u0924() {} // 0x00000001814848F0-0x00000001814849A0
		public virtual void OnObjectExitedSnapDropZone(u0926u091Du091Fu091Au091Fu091Du091Du091Cu0923u091Eu0927 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000180FCFA60-0x0000000180FCFA80
		protected virtual void u0923u091Au0924u091Cu0924u0926u0923u0921u091Eu0929u0926(Component u091Du0929u091Eu0920u0921u091Du091Fu091Bu091Au0922u091C) {} // 0x0000000181484F90-0x0000000181485080
		protected virtual void OnTriggerEnter(Collider u091Bu0920u0925u0929u091Fu091Au0923u091Eu0925u0928u0927) {} // 0x00000001814814B0-0x00000001814814D0
		protected virtual void u0922u0921u0924u0926u0924u091Du0929u0923u091Cu0922u091F() {} // 0x00000001814849A0-0x0000000181484BB0
		protected virtual void u091Bu0921u0921u0926u091Eu0924u091Bu091Cu0921u091Eu0920(Transform u0922u0928u0927u091Bu091Au0925u091Fu0927u0921u091Fu091F) {} // 0x0000000181481F70-0x0000000181482010
		protected virtual void u0921u0928u091Bu091Bu0923u0928u0923u091Au091Du0920u0927() {} // 0x0000000181484530-0x0000000181484840
		// [IteratorStateMachine] // 0x000000018013B1D0-0x000000018013B220
		protected virtual IEnumerator u0923u0928u0927u091Fu0920u0929u0927u0921u091Au091Eu0920(GameObject u0927u091Bu091Fu091Cu091Au091Fu091Cu0925u0923u091Bu091F) => default; // 0x00000001814857F0-0x0000000181485880
		protected virtual void u0925u0929u0922u0928u0929u0927u0923u0926u0920u0921u0922() {} // 0x00000001814865D0-0x0000000181486650
		public void u0929u091Au0924u091Eu0924u0924u0925u0921u0922u091Du091E(u0924u0922u0923u0924u0927u0923u0925u0929u091Eu0921u0920 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x00000001814881F0-0x0000000181488290
		protected virtual IEnumerator u0922u0929u0927u0922u091Fu0927u0928u0922u091Du0926u0926(PhotonObjectInteract u0928u0926u091Eu091Du0921u0922u0923u0923u091Fu091Au0923, GameObject u0925u0929u0925u091Du0921u0922u091Fu091Du091Bu091Fu0925, Vector3 u091Fu091Fu091Eu091Du0929u0923u0928u0922u0924u091Fu0920, float u0926u0927u091Du0923u0920u091Cu091Fu0921u091Cu0927u091C) => default; // 0x0000000181484EC0-0x0000000181484F90
		public virtual void u0923u091Eu091Du0926u0921u0921u0927u0921u0922u0920u0923(u0926u091Du091Fu091Au091Fu091Du091Du091Cu0923u091Eu0927 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000180FCFA60-0x0000000180FCFA80
		protected virtual void u0929u0929u0926u0922u091Bu0925u0928u0923u091Eu0926u0928(GameObject u0929u091Eu0923u091Fu0928u091Cu0925u0928u091Eu0920u091C) {} // 0x0000000181488540-0x00000001814885C0
		protected virtual void u0926u0925u0929u091Fu0921u0922u0929u0920u091Eu0922u091C(GameObject u091Au0924u091Fu0925u0925u0927u0921u0921u091Bu0921u0923) {} // 0x0000000181486C00-0x0000000181486CF0
		public void u0924u0928u0927u091Bu091Fu0926u0921u0923u091Cu091Bu091F(u0924u0922u0923u0924u0927u0923u0925u0929u091Eu0921u0920 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x0000000181485F50-0x0000000181485FF0
		public void u091Du0923u091Fu091Eu0922u091Fu0921u0920u091Au091Eu091F(u0924u0922u0923u0924u0927u0923u0925u0929u091Eu0921u0920 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x0000000181482A50-0x0000000181482AF0
		protected virtual void OnEnable() {} // 0x00000001814813A0-0x0000000181481440
		protected virtual void u0926u0925u0929u091Fu0921u0922u0929u0920u091Eu0922u091C(Component u091Du0929u091Eu0920u0921u091Du091Fu091Bu091Au0922u091C) {} // 0x0000000181486D90-0x0000000181486E80
		protected virtual void u0921u0924u091Au0927u0923u0928u0921u0921u091Au091Bu091B() {} // 0x0000000181484470-0x0000000181484530
		protected virtual PhotonObjectInteract u0924u0928u0922u0926u091Fu0925u091Au0921u0924u0929u091A(GameObject u0924u0921u091Du0923u091Au0920u091Cu0920u0928u0921u091B, bool u0923u0925u0926u0926u091Cu0921u0921u091Cu0921u091Bu0926, bool u091Du091Fu091Fu0920u0920u0920u0920u091Cu091Eu0928u091D = true /* Metadata: 0x0065386D */) => default; // 0x0000000181485D50-0x0000000181485F50
	}
}