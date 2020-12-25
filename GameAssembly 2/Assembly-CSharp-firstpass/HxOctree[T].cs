/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

public class HxOctree<T> // TypeDefIndex: 5827
{
	// Fields
	private HxOctreeNode<T> Root;
	private float Overlap;
	private float InitialSize;
	private float MinNodeSize;
	private Dictionary<T, HxOctreeNode<T>> NodeMap;

	// Properties
	public int Count { get; private set; }

	// Constructors
	public HxOctree() {} // Dummy constructor
	public HxOctree(Vector3 origin = default, float initialSize = 10f /* Metadata: 0x006506C3 */, float overlap = 0f /* Metadata: 0x006506C7 */, float minNodeSize = 1f /* Metadata: 0x006506CB */) {}

	// Methods
	public HxOctreeNode<T> Add(T value, Vector3 boundsMin, Vector3 boundsMax) => default;
	public void Print() {}
	public void Move(HxOctreeNode<T> value, Vector3 boundsMin, Vector3 boundsMax) {}
	public void Move(T value, Vector3 boundsMin, Vector3 boundsMax) {}
	public void TryShrink() {}
	public bool Remove(T value) => default;
	private void ExpandRoot(Vector3 center) {}
	public void GetObjects(Vector3 boundsMin, Vector3 boundsMax, List<T> items) {}
	public void GetObjectsBoundsPlane(ref Plane[] planes, Vector3 min, Vector3 max, List<T> items) {}
	public void Draw() {}
}

