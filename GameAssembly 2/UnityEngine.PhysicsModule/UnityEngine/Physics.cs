/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

// Image 8: UnityEngine.PhysicsModule.dll - Assembly: UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3646-3679

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001801361A0-0x0000000180136200
	// [StaticAccessor] // 0x00000001801361A0-0x0000000180136200
	public class Physics // TypeDefIndex: 3679
	{
		// Properties
		public static Vector3 gravity { [ThreadSafe] /* 0x00000001800EDA80-0x00000001800EDA90 */ get => default; } // 0x0000000180AD1640-0x0000000180AD16A0 
		public static bool queriesHitBackfaces { set {} } // 0x0000000180AD16A0-0x0000000180AD1960
		[NativeProperty] // 0x0000000180143B90-0x0000000180143BC0
		public static PhysicsScene defaultPhysicsScene { get => default; } // 0x0000000180AD15C0-0x0000000180AD1600 
	
		// Constructors
		public Physics() {} // Dummy constructor
	
		// Methods
		public static void IgnoreCollision(Collider collider1, Collider collider2, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool ignore) {} // 0x0000000180ACE050-0x0000000180ACE0B0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static void IgnoreCollision(Collider collider1, Collider collider2) {} // 0x0000000180ACE000-0x0000000180ACE050
		public static bool Raycast(Vector3 origin, Vector3 direction, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180AD0100-0x0000000180AD01D0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) => default; // 0x0000000180AD0670-0x0000000180AD0740
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) => default; // 0x0000000180ACFE60-0x0000000180ACFF30
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool Raycast(Vector3 origin, Vector3 direction) => default; // 0x0000000180AD03E0-0x0000000180AD0490
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000180AD0020-0x0000000180AD0100
		[ExcludeFromDocs] // 0x00000001800D5490-0x00000001800D54C0
		[RequiredByNativeCode] // 0x00000001800D5490-0x00000001800D54C0
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x0000000180AD0B30-0x0000000180AD0C10
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x0000000180AD05A0-0x0000000180AD0670
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x0000000180ACFD90-0x0000000180ACFE60
		public static bool Raycast(Ray ray, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180AD0A30-0x0000000180AD0B30
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool Raycast(Ray ray, float maxDistance, int layerMask) => default; // 0x0000000180AD01D0-0x0000000180AD02D0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool Raycast(Ray ray, float maxDistance) => default; // 0x0000000180ACFF30-0x0000000180AD0020
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool Raycast(Ray ray) => default; // 0x0000000180AD0940-0x0000000180AD0A30
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000180AD02D0-0x0000000180AD03E0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x0000000180AD0490-0x0000000180AD05A0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x0000000180AD0840-0x0000000180AD0940
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool Raycast(Ray ray, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x0000000180AD0740-0x0000000180AD0840
		public static bool Linecast(Vector3 start, Vector3 end, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACE300-0x0000000180ACE470
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool Linecast(Vector3 start, Vector3 end, int layerMask) => default; // 0x0000000180ACE190-0x0000000180ACE300
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000180ACE5E0-0x0000000180ACE760
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x0000000180ACE470-0x0000000180ACE5E0
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000180ACDB80-0x0000000180ACDC90
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x0000000180ACDA70-0x0000000180ACDB80
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000180AD1130-0x0000000180AD1220
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x0000000180AD1220-0x0000000180AD1310
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000180AD1310-0x0000000180AD1440
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x0000000180AD1440-0x0000000180AD1580
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, [DefaultValue] /* 0x00000001801336F0-0x0000000180133720 */ Quaternion orientation, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000180ACD390-0x0000000180ACD540
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x0000000180ACD540-0x0000000180ACD700
		// [NativeName] // 0x000000018013B320-0x000000018013B380
		// [StaticAccessor] // 0x000000018013B320-0x000000018013B380
		private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACE120-0x0000000180ACE190
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACEE50-0x0000000180ACF000
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) => default; // 0x0000000180ACEE00-0x0000000180ACEE50
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) => default; // 0x0000000180ACF0A0-0x0000000180ACF0F0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) => default; // 0x0000000180ACF0F0-0x0000000180ACF150
		public static RaycastHit[] RaycastAll(Ray ray, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACF1F0-0x0000000180ACF2A0
		[ExcludeFromDocs] // 0x00000001800D5490-0x00000001800D54C0
		[RequiredByNativeCode] // 0x00000001800D5490-0x00000001800D54C0
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) => default; // 0x0000000180ACF150-0x0000000180ACF1F0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) => default; // 0x0000000180ACF000-0x0000000180ACF0A0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static RaycastHit[] RaycastAll(Ray ray) => default; // 0x0000000180ACED70-0x0000000180ACEE00
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACF560-0x0000000180ACF6D0
		[ExcludeFromDocs] // 0x00000001800D5490-0x00000001800D54C0
		[RequiredByNativeCode] // 0x00000001800D5490-0x00000001800D54C0
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) => default; // 0x0000000180ACFAE0-0x0000000180ACFC50
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) => default; // 0x0000000180ACF2A0-0x0000000180ACF410
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) => default; // 0x0000000180ACF820-0x0000000180ACF990
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACF410-0x0000000180ACF560
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) => default; // 0x0000000180ACF990-0x0000000180ACFAE0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) => default; // 0x0000000180ACF6D0-0x0000000180ACF820
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) => default; // 0x0000000180ACFC50-0x0000000180ACFD90
		// [NativeName] // 0x000000018013CAA0-0x000000018013CB00
		// [StaticAccessor] // 0x000000018013CAA0-0x000000018013CB00
		private static RaycastHit[] Query_CapsuleCastAll(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACEBF0-0x0000000180ACEC80
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACD8C0-0x0000000180ACDA70
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance) => default; // 0x0000000180ACD700-0x0000000180ACD8C0
		// [NativeName] // 0x000000018013D820-0x000000018013D880
		// [StaticAccessor] // 0x000000018013D820-0x000000018013D880
		private static RaycastHit[] Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACECF0-0x0000000180ACED70
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180AD0DE0-0x0000000180AD0F70
		public static RaycastHit[] SphereCastAll(Ray ray, float radius, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxDistance, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layerMask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180AD0C10-0x0000000180AD0DE0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance) => default; // 0x0000000180AD0F70-0x0000000180AD1130
		// [NativeName] // 0x000000018013F2E0-0x000000018013F340
		// [StaticAccessor] // 0x000000018013F2E0-0x000000018013F340
		private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACE9B0-0x0000000180ACEA20
		public static Collider[] OverlapSphere(Vector3 position, float radius, [DefaultValue] /* 0x000000018013F5B0-0x000000018013F5E0 */ int layerMask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACEAC0-0x0000000180ACEB80
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static Collider[] OverlapSphere(Vector3 position, float radius) => default; // 0x0000000180ACEA20-0x0000000180ACEAC0
		// [NativeName] // 0x000000018013FAC0-0x000000018013FB20
		// [StaticAccessor] // 0x000000018013FAC0-0x000000018013FB20
		private static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACDD00-0x0000000180ACDD70
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, [DefaultValue] /* 0x00000001801336F0-0x0000000180133720 */ Quaternion orientation, [DefaultValue] /* 0x00000001801106C0-0x00000001801106F0 */ int layermask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACDF20-0x0000000180ACE000
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) => default; // 0x0000000180ACDE40-0x0000000180ACDF20
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation) => default; // 0x0000000180ACDD70-0x0000000180ACDE40
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, [DefaultValue] /* 0x00000001801336F0-0x0000000180133720 */ Quaternion orientation, [DefaultValue] /* 0x000000018013F5B0-0x000000018013F5E0 */ int mask, [DefaultValue] /* 0x00000001801345D0-0x0000000180134600 */ QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACE850-0x0000000180ACE940
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask) => default; // 0x0000000180ACE760-0x0000000180ACE850
		private static void get_gravity_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000180AD1600-0x0000000180AD1640
		private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) {
			ret = default;
		} // 0x0000000180AD1580-0x0000000180AD15C0
		private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACE0B0-0x0000000180ACE120
		private static RaycastHit[] Query_CapsuleCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACEB80-0x0000000180ACEBF0
		private static RaycastHit[] Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACEC80-0x0000000180ACECF0
		private static Collider[] OverlapSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACE940-0x0000000180ACE9B0
		private static bool CheckBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000180ACDC90-0x0000000180ACDD00
	}
}
