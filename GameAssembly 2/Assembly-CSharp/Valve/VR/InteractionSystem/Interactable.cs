/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	public class Interactable : MonoBehaviour // TypeDefIndex: 8371
	{
		// Events
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public event OnAttachedToHandDelegate onAttachedToHand;
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public event OnDetachedFromHandDelegate onDetachedFromHand;
	
		// Nested types
		public delegate void OnAttachedToHandDelegate(Hand hand); // TypeDefIndex: 8372; 0x0000000180397EB0-0x0000000180398120
	
		public delegate void OnDetachedFromHandDelegate(Hand hand); // TypeDefIndex: 8373; 0x0000000180397EB0-0x0000000180398120
	
		// Constructors
		public Interactable() {} // 0x0000000180276E90-0x0000000180276EA0
	
		// Methods
		private void OnAttachedToHand(Hand hand) {} // 0x0000000180FC5970-0x0000000180FC5990
		private void OnDetachedFromHand(Hand hand) {} // 0x0000000180FC5990-0x0000000180FC59B0
	}
}
