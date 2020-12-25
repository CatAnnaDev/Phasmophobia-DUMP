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
	public class CullArea : MonoBehaviour // TypeDefIndex: 5607
	{
		// Fields
		private const int MAX_NUMBER_OF_ALLOWED_CELLS = 250; // Metadata: 0x006500E7
		public const int MAX_NUMBER_OF_SUBDIVISIONS = 3; // Metadata: 0x006500EB
		public readonly byte FIRST_GROUP_ID; // 0x18
		public readonly int[] SUBDIVISION_FIRST_LEVEL_ORDER; // 0x20
		public readonly int[] SUBDIVISION_SECOND_LEVEL_ORDER; // 0x28
		public readonly int[] SUBDIVISION_THIRD_LEVEL_ORDER; // 0x30
		public Vector2 Center; // 0x38
		public Vector2 Size; // 0x40
		public Vector2[] Subdivisions; // 0x48
		public int NumberOfSubdivisions; // 0x50
		public bool YIsUpAxis; // 0x68
		public bool RecreateCellHierarchy; // 0x69
		private byte idCounter; // 0x6A
	
		// Properties
		public int CellCount { get; private set; } // 0x0000000180400CB0-0x0000000180400CC0 0x0000000180400D60-0x0000000180400D70
		public CellTree CellTree { get; private set; } // 0x0000000180246F30-0x0000000180246F40 0x00000001802470C0-0x00000001802470D0
		public Dictionary<int, GameObject> Map { get; private set; } // 0x0000000180274940-0x0000000180274950 0x0000000180280570-0x0000000180280580
	
		// Constructors
		public CullArea() {} // 0x0000000181277CD0-0x0000000181277E10
	
		// Methods
		private void Awake() {} // 0x0000000181276E00-0x0000000181276E10
		public void OnDrawGizmos() {} // 0x0000000181277C90-0x0000000181277CD0
		private void CreateCellHierarchy() {} // 0x0000000181276E10-0x0000000181277650
		private void CreateChildCells(CellTreeNode parent, int cellLevelInHierarchy) {} // 0x0000000181277650-0x0000000181277B30
		private void DrawCells() {} // 0x0000000181277B30-0x0000000181277B50
		private bool IsCellCountAllowed() => default; // 0x0000000181277C00-0x0000000181277C90
		public List<byte> GetActiveCells(Vector3 position) => default; // 0x0000000181277B50-0x0000000181277C00
	}
}
