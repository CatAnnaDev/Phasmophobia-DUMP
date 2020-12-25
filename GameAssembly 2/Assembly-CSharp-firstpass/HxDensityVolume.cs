/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

[ExecuteInEditMode] // 0x00000001800D4E50-0x00000001800D4E60
public class HxDensityVolume : MonoBehaviour // TypeDefIndex: 5823
{
	// Fields
	public static HxOctree<HxDensityVolume> DensityOctree; // 0x00
	private HxOctreeNode<HxDensityVolume> octreeNode; // 0x18
	public DensityShape Shape; // 0x20
	public DensityBlendMode BlendMode; // 0x24
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public Vector3 minBounds; // 0x28
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public Vector3 maxBounds; // 0x34
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public Matrix4x4 ToLocalSpace; // 0x40
	public float Density; // 0x80
	private static Color gizmoColor; // 0x08
	private static Vector3 c1; // 0x18
	private static Vector3 c2; // 0x24
	private static Vector3 c3; // 0x30
	private static Vector3 c4; // 0x3C
	private static Vector3 c5; // 0x48
	private static Vector3 c6; // 0x54
	private static Vector3 c7; // 0x60
	private static Vector3 c8; // 0x6C

	// Nested types
	public enum DensityShape // TypeDefIndex: 5824
	{
		Square = 0,
		Sphere = 1,
		Cylinder = 2
	}

	public enum DensityBlendMode // TypeDefIndex: 5825
	{
		Max = 0,
		Add = 1,
		Min = 2,
		Sub = 3
	}

	// Constructors
	public HxDensityVolume() {} // 0x000000018032CF60-0x000000018032CF80
	static HxDensityVolume() {} // 0x000000018032CCC0-0x000000018032CF60

	// Methods
	private void OnEnable() {} // 0x000000018032C9D0-0x000000018032CBC0
	private void OnDrawGizmos() {} // 0x000000018032C950-0x000000018032C9D0
	private void OnDrawGizmosSelected() {} // 0x000000018032C800-0x000000018032C950
	private void OnDisable() {} // 0x000000018032C6F0-0x000000018032C800
	private void OnDestroy() {} // 0x000000018032C5E0-0x000000018032C6F0
	public void UpdateVolume() {} // 0x000000018032CBC0-0x000000018032CCC0
	private void CalculateBounds() {} // 0x000000018032BF10-0x000000018032C5E0
}

