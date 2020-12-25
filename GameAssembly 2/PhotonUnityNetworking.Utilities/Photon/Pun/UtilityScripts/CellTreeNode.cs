/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 56: PhotonUnityNetworking.Utilities.dll - Assembly: PhotonUnityNetworking.Utilities, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5605-5662

namespace Photon.Pun.UtilityScripts
{
	public class CellTreeNode // TypeDefIndex: 5609
	{
		// Fields
		public byte Id; // 0x10
		public Vector3 Center; // 0x14
		public Vector3 Size; // 0x20
		public Vector3 TopLeft; // 0x2C
		public Vector3 BottomRight; // 0x38
		public ENodeType NodeType; // 0x44
		public CellTreeNode Parent; // 0x48
		public List<CellTreeNode> Childs; // 0x50
		private float maxDistance; // 0x58
	
		// Nested types
		public enum ENodeType // TypeDefIndex: 5610
		{
			Root = 0,
			Node = 1,
			Leaf = 2
		}
	
		// Constructors
		public CellTreeNode() {} // 0x00000001802466A0-0x00000001802466B0
		public CellTreeNode(byte id, ENodeType nodeType, CellTreeNode parent) {} // 0x0000000181275B50-0x0000000181275BA0
	
		// Methods
		public void AddChild(CellTreeNode child) {} // 0x00000001812755D0-0x0000000181275670
		public void Draw() {} // 0x0000000180246DB0-0x0000000180246DC0
		public void GetActiveCells(List<byte> activeCells, bool yIsUpAxis, Vector3 position) {} // 0x0000000181275670-0x00000001812759C0
		public bool IsPointInsideCell(bool yIsUpAxis, Vector3 point) => default; // 0x00000001812759C0-0x0000000181275A40
		public bool IsPointNearCell(bool yIsUpAxis, Vector3 point) => default; // 0x0000000181275A40-0x0000000181275B50
	}
}
