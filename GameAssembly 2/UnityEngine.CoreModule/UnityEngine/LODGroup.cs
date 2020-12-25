/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800D8340-0x00000001800D83F0
	// [NativeHeader] // 0x00000001800D8340-0x00000001800D83F0
	// [NativeHeader] // 0x00000001800D8340-0x00000001800D83F0
	// [StaticAccessor] // 0x00000001800D8340-0x00000001800D83F0
	public class LODGroup : Component // TypeDefIndex: 3198
	{
		// Properties
		public Vector3 localReferencePoint { set {} } // 0x000000018096E8D0-0x000000018096E920
		public float size { set {} } // 0x000000018096E920-0x000000018096E990
		public LODFadeMode fadeMode { get => default; set {} } // 0x000000018096E760-0x000000018096E7A0 0x000000018096E840-0x000000018096E880
		public bool animateCrossFading { get => default; set {} } // 0x000000018096E720-0x000000018096E760 0x000000018096E7A0-0x000000018096E7F0
		public bool enabled { set {} } // 0x000000018096E7F0-0x000000018096E840
	
		// Constructors
		public LODGroup() {} // Dummy constructor
	
		// Methods
		[FreeFunction] // 0x00000001800D88C0-0x00000001800D8900
		public LOD[] GetLODs() => default; // 0x000000018096E690-0x000000018096E6D0
		[FreeFunction] // 0x00000001800D8A90-0x00000001800D8AD0
		public void SetLODs(LOD[] lods) {} // 0x000000018096E6D0-0x000000018096E720
		private void set_localReferencePoint_Injected(ref Vector3 value) {} // 0x000000018096E880-0x000000018096E8D0
	}
}
