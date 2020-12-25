/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

[ExecuteInEditMode] // 0x00000001800D4E50-0x00000001800D4E60
public class HxVolumetricParticleSystem : MonoBehaviour // TypeDefIndex: 5843
{
	// Fields
	// [Range] // 0x00000001800EDF90-0x00000001800EDFB0
	public float DensityStrength; // 0x18
	private HxOctreeNode<HxVolumetricParticleSystem> octreeNode; // 0x20
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public Renderer particleRenderer; // 0x28
	public ParticleBlendMode BlendMode; // 0x30
	private Vector3 minBounds; // 0x34
	private Vector3 maxBounds; // 0x40
	private Bounds LastBounds; // 0x4C

	// Nested types
	public enum ParticleBlendMode // TypeDefIndex: 5844
	{
		Max = 0,
		Add = 1,
		Min = 2,
		Sub = 3
	}

	// Constructors
	public HxVolumetricParticleSystem() {} // 0x00000001804C7A10-0x00000001804C7A30

	// Methods
	private void OnEnable() {} // 0x00000001804C7740-0x00000001804C78B0
	public void UpdatePosition() {} // 0x00000001804C78B0-0x00000001804C7A10
	private void OnDisable() {} // 0x00000001804C7690-0x00000001804C7740
	private void OnDestroy() {} // 0x00000001804C75E0-0x00000001804C7690
}

