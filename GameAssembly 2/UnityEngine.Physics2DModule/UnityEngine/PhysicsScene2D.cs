/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 16: UnityEngine.Physics2DModule.dll - Assembly: UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3789-3798

namespace UnityEngine
{
	// [NativeHeader] // 0x000000018010FA40-0x000000018010FA70
	public struct PhysicsScene2D : IEquatable<UnityEngine.PhysicsScene2D> // TypeDefIndex: 3790
	{
		// Fields
		private int m_Handle; // 0x00
	
		// Methods
		public override string ToString() => default; // 0x000000018004DF60-0x000000018004E030
		public override int GetHashCode() => default; // 0x0000000180005FD0-0x0000000180005FE0
		public override bool Equals(object other) => default; // 0x000000018004DC20-0x000000018004DCA0
		public bool Equals(PhysicsScene2D other) => default; // 0x000000018003B530-0x000000018003B540
		public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, [DefaultValue] /* 0x000000018010FB00-0x000000018010FB30 */ int layerMask = -5 /* Metadata: 0x0064CDC3 */) => default; // 0x000000018004DCF0-0x000000018004DD50
		public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) => default; // 0x000000018004DE90-0x000000018004DF60
		[NativeMethod] // 0x000000018010FB70-0x000000018010FBD0
		// [StaticAccessor] // 0x000000018010FB70-0x000000018010FBD0
		private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) => default; // 0x0000000180AF0E40-0x0000000180AF1130
		public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) => default; // 0x000000018004DDF0-0x000000018004DE90
		[NativeMethod] // 0x000000018010FCB0-0x000000018010FD10
		// [StaticAccessor] // 0x000000018010FCB0-0x000000018010FD10
		private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, [NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ RaycastHit2D[] results) => default; // 0x0000000180AF0C60-0x0000000180AF0CE0
		public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) => default; // 0x000000018004DD50-0x000000018004DDF0
		[NativeMethod] // 0x000000018010FDE0-0x000000018010FE40
		// [StaticAccessor] // 0x000000018010FDE0-0x000000018010FE40
		private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, [NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ List<RaycastHit2D> results) => default; // 0x0000000180AF0D50-0x0000000180AF0DD0
		public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, [DefaultValue] /* 0x000000018010FB00-0x000000018010FB30 */ int layerMask = -5 /* Metadata: 0x0064CDC7 */) => default; // 0x000000018004DCA0-0x000000018004DCF0
		[NativeMethod] // 0x000000018010FF90-0x000000018010FFF0
		// [StaticAccessor] // 0x000000018010FF90-0x000000018010FFF0
		private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, [NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ RaycastHit2D[] results) => default; // 0x0000000180AF0AA0-0x0000000180AF0BF0
		private static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret) {
			ret = default;
		} // 0x0000000180AF0DD0-0x0000000180AF0E40
		private static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) => default; // 0x0000000180AF0BF0-0x0000000180AF0C60
		private static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results) => default; // 0x0000000180AF0CE0-0x0000000180AF0D50
		private static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) => default; // 0x0000000180AF0A30-0x0000000180AF0AA0
	}
}
