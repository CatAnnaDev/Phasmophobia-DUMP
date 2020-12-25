/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace MeshCombineStudio
{
	[Serializable]
	public class MeshObjectsHolder // TypeDefIndex: 8558
	{
		// Fields
		public FastList<MeshObject> meshObjects; // 0x10
		public u091Au091Du0921u0927u0926u0922u0924u091Cu0926u0922u0926.u0923u0922u0921u0923u091Eu091Au0926u091Du0924u0929u091F lodParent; // 0x18
		public FastList<CachedGameObject> newCachedGOs; // 0x20
		public int lodLevel; // 0x28
		public Material mat; // 0x30
		public bool hasChanged; // 0x38
		public CombineCondition combineCondition; // 0x40
	
		// Constructors
		public MeshObjectsHolder() {} // Dummy constructor
		public MeshObjectsHolder(ref CombineCondition combineCondition, Material mat) {} // 0x0000000181390330-0x00000001813903F0
	}
}
