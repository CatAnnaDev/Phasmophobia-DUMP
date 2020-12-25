/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

// Image 16: UnityEngine.Physics2DModule.dll - Assembly: UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3789-3798

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180110140-0x00000001801101F0
	// [NativeHeader] // 0x0000000180110140-0x00000001801101F0
	// [NativeHeader] // 0x0000000180110140-0x00000001801101F0
	// [StaticAccessor] // 0x0000000180110140-0x00000001801101F0
	public class Physics2D // TypeDefIndex: 3791
	{
		// Fields
		private static List<Rigidbody2D> m_LastDisabledRigidbody2D; // 0x00
	
		// Properties
		public static PhysicsScene2D defaultPhysicsScene { get => default; } // 0x00000001806C1010-0x00000001806C1020 
		// [StaticAccessor] // 0x00000001801129B0-0x00000001801129E0
		public static bool queriesHitTriggers { get => default; } // 0x0000000180AF0A00-0x0000000180AF0A30 
	
		// Constructors
		public Physics2D() {} // Dummy constructor
		static Physics2D() {} // 0x0000000180AF09A0-0x0000000180AF0A00
	
		// Methods
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) => default; // 0x0000000180AF0840-0x0000000180AF09A0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) => default; // 0x0000000180AF0090-0x0000000180AF0160
		[ExcludeFromDocs] // 0x00000001800D5490-0x00000001800D54C0
		[RequiredByNativeCode] // 0x00000001800D5490-0x00000001800D54C0
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) => default; // 0x0000000180AF06A0-0x0000000180AF0840
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) => default; // 0x0000000180AF0500-0x0000000180AF06A0
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float distance, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask, [DefaultValue] /* 0x0000000180110760-0x0000000180110790 */ float minDepth, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDepth) => default; // 0x0000000180AF0160-0x0000000180AF0300
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) => default; // 0x0000000180AEFF90-0x0000000180AF0090
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float distance) => default; // 0x0000000180AF0300-0x0000000180AF0400
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float distance = 1F / 0F /* Metadata: 0x0064CDCB */) => default; // 0x0000000180AF0400-0x0000000180AF0500
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) => default; // 0x0000000180AEF890-0x0000000180AEF9C0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) => default; // 0x0000000180AEF750-0x0000000180AEF890
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float distance, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask) => default; // 0x0000000180AEF610-0x0000000180AEF750
		[NativeMethod] // 0x0000000180110E80-0x0000000180110EE0
		// [StaticAccessor] // 0x0000000180110E80-0x0000000180110EE0
		private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) => default; // 0x0000000180AEF570-0x0000000180AEF610
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) => default; // 0x0000000180AEFC10-0x0000000180AEFD30
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) => default; // 0x0000000180AEF9C0-0x0000000180AEFAE0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float distance, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask) => default; // 0x0000000180AEFAE0-0x0000000180AEFC10
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static Collider2D[] OverlapCircleAll(Vector2 point, float radius) => default; // 0x0000000180AEFE30-0x0000000180AEFF90
		[NativeMethod] // 0x0000000180112850-0x00000001801128B0
		// [StaticAccessor] // 0x0000000180112850-0x00000001801128B0
		private static Collider2D[] OverlapCircleAll_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter) => default; // 0x0000000180AEFDA0-0x0000000180AEFE30
		private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask) => default; // 0x0000000180AEF500-0x0000000180AEF570
		private static Collider2D[] OverlapCircleAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, float radius, ref ContactFilter2D contactFilter) => default; // 0x0000000180AEFD30-0x0000000180AEFDA0
	}
}
