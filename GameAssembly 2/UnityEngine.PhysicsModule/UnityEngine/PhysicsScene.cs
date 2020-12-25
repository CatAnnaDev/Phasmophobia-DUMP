/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 8: UnityEngine.PhysicsModule.dll - Assembly: UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3646-3679

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001801342E0-0x0000000180134310
	public struct PhysicsScene : IEquatable<UnityEngine.PhysicsScene> // TypeDefIndex: 3678
	{
		// Fields
		private int m_Handle; // 0x00
	
		// Methods
		public override string ToString() => default; // 0x0000000180049CF0-0x0000000180049DC0
		public override int GetHashCode() => default; // 0x0000000180005FD0-0x0000000180005FE0
		public override bool Equals(object other) => default; // 0x00000001800499D0-0x0000000180049A50
		public bool Equals(PhysicsScene other) => default; // 0x000000018003B530-0x000000018003B540
		public bool Raycast(Vector3 origin, Vector3 direction, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance = 1F / 0F /* Metadata: 0x0064CAC5 */, [DefaultValue] /* 0x0000000180134520-0x0000000180134550 */ int layerMask = -5 /* Metadata: 0x0064CAC9 */, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0064CACD */) => default; // 0x0000000180049B80-0x0000000180049BF0
		// [NativeName] // 0x0000000180134700-0x0000000180134760
		// [StaticAccessor] // 0x0000000180134700-0x0000000180134760
		private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACC6D0-0x0000000180ACC740
		public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance = 1F / 0F /* Metadata: 0x0064CAD1 */, [DefaultValue] /* 0x0000000180134520-0x0000000180134550 */ int layerMask = -5 /* Metadata: 0x0064CAD5 */, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0064CAD9 */) {
			hitInfo = default;
			return default;
		} // 0x0000000180049B00-0x0000000180049B80
		// [NativeName] // 0x0000000180134BB0-0x0000000180134C10
		// [StaticAccessor] // 0x0000000180134BB0-0x0000000180134C10
		private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACC7B0-0x0000000180ACC820
		public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance = 1F / 0F /* Metadata: 0x0064CADD */, [DefaultValue] /* 0x0000000180134520-0x0000000180134550 */ int layerMask = -5 /* Metadata: 0x0064CAE1 */, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0064CAE5 */) => default; // 0x0000000180049BF0-0x0000000180049C70
		// [NativeName] // 0x0000000180135090-0x00000001801350F0
		// [StaticAccessor] // 0x0000000180135090-0x00000001801350F0
		private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACC5F0-0x0000000180ACC660
		// [NativeName] // 0x0000000180135240-0x00000001801352A0
		// [StaticAccessor] // 0x0000000180135240-0x00000001801352A0
		private static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACCC10-0x0000000180ACCCB0
		private static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000180ACC3C0-0x0000000180ACC580
		public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance = 1F / 0F /* Metadata: 0x0064CAE9 */, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask = -5 /* Metadata: 0x0064CAED */, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0064CAF1 */) {
			hitInfo = default;
			return default;
		} // 0x0000000180049920-0x00000001800499D0
		// [NativeName] // 0x00000001801357D0-0x0000000180135830
		// [StaticAccessor] // 0x00000001801357D0-0x0000000180135830
		private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACCD20-0x0000000180ACD390
		private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000180ACC820-0x0000000180ACC9A0
		public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance = 1F / 0F /* Metadata: 0x0064CAF5 */, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask = -5 /* Metadata: 0x0064CAF9 */, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0064CAFD */) {
			hitInfo = default;
			return default;
		} // 0x0000000180049C70-0x0000000180049CF0
		// [NativeName] // 0x0000000180135B40-0x0000000180135BA0
		// [StaticAccessor] // 0x0000000180135B40-0x0000000180135BA0
		private static bool Query_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACCB00-0x0000000180ACCBA0
		private static bool Internal_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000180ACC200-0x0000000180ACC3C0
		public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, [DefaultValue] /* 0x00000001801336F0-0x0000000180133720 */ Quaternion orientation, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance = 1F / 0F /* Metadata: 0x0064CB01 */, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask = -5 /* Metadata: 0x0064CB05 */, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0064CB09 */) {
			hitInfo = default;
			return default;
		} // 0x0000000180049860-0x0000000180049920
		// [NativeName] // 0x0000000180135FA0-0x0000000180136000
		// [StaticAccessor] // 0x0000000180135FA0-0x0000000180136000
		private static int OverlapBoxNonAlloc_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACCA10-0x0000000180ACCA90
		public int OverlapBox(Vector3 center, Vector3 halfExtents, Collider[] results, [DefaultValue] /* 0x00000001801336F0-0x0000000180133720 */ Quaternion orientation, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask = -5 /* Metadata: 0x0064CB0D */, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0064CB11 */) => default; // 0x0000000180049A50-0x0000000180049B00
		private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACC660-0x0000000180ACC6D0
		private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACC740-0x0000000180ACC7B0
		private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACC580-0x0000000180ACC5F0
		private static bool Query_CapsuleCast_Injected(ref PhysicsScene physicsScene, ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACCBA0-0x0000000180ACCC10
		private static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACCCB0-0x0000000180ACCD20
		private static bool Query_BoxCast_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACCA90-0x0000000180ACCB00
		private static int OverlapBoxNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, Collider[] results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACC9A0-0x0000000180ACCA10
	}
}
