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
	public abstract class TeleportMarkerBase : MonoBehaviour // TypeDefIndex: 8441
	{
		// Fields
		public bool locked; // 0x18
		public bool markerActive; // 0x19
	
		// Properties
		public virtual bool showReticle { get; } // 0x0000000180246BB0-0x0000000180246BC0 
	
		// Constructors
		protected TeleportMarkerBase() {} // 0x0000000180EEB9E0-0x0000000180EEB9F0
	
		// Methods
		public void SetLocked(bool locked) {} // 0x0000000180EEB9C0-0x0000000180EEB9E0
		public virtual void TeleportPlayer(Vector3 pointedAtPosition) {} // 0x0000000180246DB0-0x0000000180246DC0
		public abstract void UpdateVisuals();
		public abstract void Highlight(bool highlight);
		public abstract void SetAlpha(float tintAlpha, float alphaPercent);
		public abstract bool ShouldActivate(Vector3 playerPosition);
		public abstract bool ShouldMovePlayer();
	}
}
