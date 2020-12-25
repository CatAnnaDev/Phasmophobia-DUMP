/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

[Serializable]
public class HxOctreeNode<T> // TypeDefIndex: 5828
{
	// Fields
	public HxOctreeNode<T> Parent;
	private float MinSize;
	private float Overlap;
	private float SizeWithOverlap;
	public Vector3 BoundsMin;
	public Vector3 BoundsMax;
	private readonly List<NodeObject> Objects;
	private const int MaxObjectCount = 8; // Metadata: 0x006506D3
	public HxOctreeNode<T>[] Children;
	private Vector3[] ChildrenBoundsMin;
	private Vector3[] ChildrenBoundsMax;
	public int ID;
	private static int _idCtr;

	// Properties
	public Vector3 Origin { get; private set; }
	public float Size { get; private set; }

	// Nested types
	[Serializable]
	public class NodeObject // TypeDefIndex: 5829
	{
		// Fields
		public HxOctreeNode<T> Node;
		public T Value;
		public Vector3 BoundsMin;
		public Vector3 BoundsMax;
		public Vector3 Center;

		// Constructors
		public NodeObject() {} // Dummy constructor
		public NodeObject(T value, Vector3 boundsMin, Vector3 boundsMax) {}
	}

	// Constructors
	public HxOctreeNode() {} // Dummy constructor
	public HxOctreeNode(float size, float overlap, float minSize, Vector3 origin, HxOctreeNode<T> parent) {}
	static HxOctreeNode() {}

	// Methods
	private void Init(float size, float overlap, float minSize, Vector3 origin, HxOctreeNode<T> parent) {}
	public void Add(NodeObject node) {}
	public bool Remove(T value) => default;
	public void GetObjects(Vector3 boundsMin, Vector3 boundsMax, List<T> items) {}
	public void GetObjects2(Vector3 boundsMin, Vector3 boundsMax, List<T> items) {}
	public void GetObjects2BoundsPlane(ref Plane[] planes, Vector3 boundsMin, Vector3 boundsMax, List<T> items) {}
	private void DrawBounds(Vector3 min, Vector3 max) {}
	private int BoundsInPlanes(Vector3 min, Vector3 max, ref Plane[] planes) => default;
	private bool ObjectInPlanes(Vector3 min, Vector3 max, ref Plane[] planes) => default;
	private Vector3 GetVertexP(Vector3 min, Vector3 max, Vector3 normal) => default;
	private Vector3 GetVertexN(Vector3 min, Vector3 max, Vector3 normal) => default;
	private void addAllObjectsToList(List<T> items) {}
	private void addAllObjectsToList(List<T> items, ref Vector3 min, ref Vector3 max) {}
	public HxOctreeNode<T> TryShrink(float minSize) => default;
	private Vector3 GetVertexP(Vector3 normal) => default;
	private bool HasObjects() => default;
	public static bool BoundsIntersects(Vector3 aMin, Vector3 aMax, Vector3 bMin, Vector3 bMax) => default;
	public static bool BoundsContains(Vector3 outerMin, Vector3 outerMax, Vector3 innerMin, Vector3 innerMax) => default;
	private int OctantIndex(Vector3 point) => default;
	public void Draw(int counter = 0 /* Metadata: 0x006506CF */) {}
}

