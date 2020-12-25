/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 17: UnityEngine.TerrainModule.dll - Assembly: UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3799-3816

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001801183E0-0x0000000180118450
	// [NativeHeader] // 0x00000001801183E0-0x0000000180118450
	[UsedByNativeCode] // 0x00000001801183E0-0x0000000180118450
	public sealed class TerrainData : Object // TypeDefIndex: 3802
	{
		// Fields
		internal static readonly int k_MaximumResolution; // 0x00
		internal static readonly int k_MinimumDetailResolutionPerPatch; // 0x04
		internal static readonly int k_MaximumDetailResolutionPerPatch; // 0x08
		internal static readonly int k_MaximumDetailPatchCount; // 0x0C
		internal static readonly int k_MaximumDetailsPerRes; // 0x10
		internal static readonly int k_MinimumAlphamapResolution; // 0x14
		internal static readonly int k_MaximumAlphamapResolution; // 0x18
		internal static readonly int k_MinimumBaseMapResolution; // 0x1C
		internal static readonly int k_MaximumBaseMapResolution; // 0x20
	
		// Properties
		public Vector3 size { /* [NativeName] */ /* 0x0000000180118890-0x00000001801188C0 */ get => default; } // 0x0000000180ADD8C0-0x0000000180ADD930 
		internal Terrain[] users { get => default; } // 0x0000000180ADD930-0x0000000180ADD970 
	
		// Nested types
		private enum BoundaryValueType // TypeDefIndex: 3803
		{
			MaxHeightmapRes = 0,
			MinDetailResPerPatch = 1,
			MaxDetailResPerPatch = 2,
			MaxDetailPatchCount = 3,
			MaxDetailsPerRes = 4,
			MinAlphamapRes = 5,
			MaxAlphamapRes = 6,
			MinBaseMapRes = 7,
			MaxBaseMapRes = 8
		}
	
		// Constructors
		public TerrainData() {} // 0x0000000180ADD7D0-0x0000000180ADD870
		static TerrainData() {} // 0x0000000180ADD5C0-0x0000000180ADD7D0
	
		// Methods
		// [StaticAccessor] // 0x0000000180118600-0x0000000180118650
		[ThreadSafe] // 0x0000000180118600-0x0000000180118650
		private static int GetBoundaryValue(BoundaryValueType type) => default; // 0x0000000180ADD540-0x0000000180ADD580
		[FreeFunction] // 0x00000001801186A0-0x00000001801186D0
		private static void Internal_Create([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ TerrainData terrainData) {} // 0x0000000180ADD580-0x0000000180ADD5C0
		// [NativeName] // 0x0000000180118A40-0x0000000180118A80
		[RequiredByNativeCode] // 0x0000000180118A40-0x0000000180118A80
		internal float GetAlphamapResolutionInternal() => default; // 0x0000000180ADD500-0x0000000180ADD540
		private void get_size_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000180ADD870-0x0000000180ADD8C0
	}
}
