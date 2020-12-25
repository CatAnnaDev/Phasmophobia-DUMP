/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VRTK;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace VRTK.SecondaryControllerGrabActions
{
	public abstract class VRTK_BaseGrabAction : MonoBehaviour // TypeDefIndex: 7824
	{
		// Fields
		protected VRTK_InteractableObject u0926u0926u0925u0922u091Fu0924u091Eu091Eu091Eu0927u091B; // 0x18
		protected VRTK_InteractGrab u0929u0927u0925u0924u091Cu091Cu0922u0928u0922u0921u091A; // 0x20
		protected VRTK_InteractGrab u091Du091Eu0921u091Fu0924u0929u091Au091Cu091Eu0921u0923; // 0x28
		protected Transform u091Eu091Eu0920u0929u091Fu0926u0920u091Bu0920u0929u0921; // 0x30
		protected Transform u0928u0928u0924u0923u0920u0923u0925u0925u0926u091Du091B; // 0x38
		protected bool u0924u0920u0923u0929u091Bu0925u0921u0928u091Eu0922u091C; // 0x40
		protected bool u091Eu091Fu0925u091Du091Eu091Du0924u0921u0925u091Cu0921; // 0x41
		protected bool u0920u091Eu091Au0926u091Au0925u0929u0922u091Bu091Au091B; // 0x42
	
		// Constructors
		protected VRTK_BaseGrabAction() {} // 0x000000018162EC10-0x000000018162EC20
	
		// Methods
		public virtual void Initialise(VRTK_InteractableObject u0924u0921u091Fu0929u0924u0926u0924u091Du091Cu091Cu0928, VRTK_InteractGrab u0920u0922u0929u091Du0922u0922u091Bu0925u0928u0927u091A, VRTK_InteractGrab u0927u0923u0920u091Du0922u091Du091Eu091Du0927u0926u091D, Transform u091Fu0928u0921u091Du091Cu091Au091Bu091Bu091Au0927u091C, Transform u0921u0926u0927u091Au0921u0929u0925u091Bu0923u0929u091C) {} // 0x000000018162E9E0-0x000000018162EA60
		public virtual void ResetAction() {} // 0x000000018162EA60-0x000000018162EAD0
		public virtual bool IsActionable() => default; // 0x00000001803C0B00-0x00000001803C0B10
		public virtual bool IsSwappable() => default; // 0x0000000180597AE0-0x0000000180597AF0
		public virtual void ProcessUpdate() {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void ProcessFixedUpdate() {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnDropAction() {} // 0x0000000180246DB0-0x0000000180246DC0
		protected virtual void u0923u091Cu0923u091Au091Au0925u091Fu091Bu091Fu0926u091E(float u0920u0926u091Du0921u091Eu0922u091Fu0929u091Eu091Au0920) {} // 0x000000018162EAD0-0x000000018162EC10
	}
}
