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
using UnityEngineInternal;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800FD430-0x00000001800FD4D0
	// [NativeHeader] // 0x00000001800FD430-0x00000001800FD4D0
	// [NativeHeader] // 0x00000001800FD430-0x00000001800FD4D0
	[RequiredByNativeCode] // 0x00000001800FD430-0x00000001800FD4D0
	public class Object // TypeDefIndex: 3291
	{
		// Fields
		private IntPtr m_CachedPtr; // 0x10
		internal static int OffsetOfInstanceIDInCPlusPlusObject; // 0x00
		private const string objectIsNullMessage = "The Object you want to instantiate is null."; // Metadata: 0x0064C187
		private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake."; // Metadata: 0x0064C1B6
	
		// Properties
		public string name { get => default; set {} } // 0x000000018093C9C0-0x000000018093CA30 0x000000018093CC20-0x000000018093D540
		public HideFlags hideFlags { get => default; set {} } // 0x000000018093C980-0x000000018093C9C0 0x000000018093CBE0-0x000000018093CC20
	
		// Constructors
		public Object() {} // 0x00000001802466A0-0x00000001802466B0
		static Object() {} // 0x000000018093C940-0x000000018093C980
	
		// Methods
		public int GetInstanceID() => default; // 0x000000018093BAA0-0x000000018093BBD0
		public override int GetHashCode() => default; // 0x000000018093BA90-0x000000018093BAA0
		public override bool Equals(object other) => default; // 0x000000018093B810-0x000000018093B980
		public static implicit operator bool(Object exists) => default; // 0x000000018093CAA0-0x000000018093CB70
		private static bool CompareBaseObjects(Object lhs, Object rhs) => default; // 0x000000018093B4B0-0x000000018093B5E0
		private static bool IsNativeObjectAlive(Object o) => default; // 0x000000018093C7F0-0x000000018093C840
		private IntPtr GetCachedPtr() => default; // 0x00000001809302E0-0x00000001809302F0
		// [TypeInferenceRule] // 0x00000001800FD720-0x00000001800FD740
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) => default; // 0x000000018093C2D0-0x000000018093C550
		// [TypeInferenceRule] // 0x00000001800FD720-0x00000001800FD740
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) => default; // 0x000000018093BD90-0x000000018093BFE0
		// [TypeInferenceRule] // 0x00000001800FD720-0x00000001800FD740
		public static Object Instantiate(Object original) => default; // 0x000000018093BC40-0x000000018093BD90
		// [TypeInferenceRule] // 0x00000001800FD720-0x00000001800FD740
		public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) => default; // 0x000000018093BFE0-0x000000018093C2D0
		public static T Instantiate<T>(T original)
			where T : Object => default;
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation)
			where T : Object => default;
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent)
			where T : Object => default;
		public static T Instantiate<T>(T original, Transform parent)
			where T : Object => default;
		public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays)
			where T : Object => default;
		[NativeMethod] // 0x00000001800FDA00-0x00000001800FDA40
		public static void Destroy(Object obj, [DefaultValue] /* 0x00000001800FEE40-0x00000001800FEE70 */ float t) {} // 0x000000018093B710-0x000000018093B760
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static void Destroy(Object obj) {} // 0x000000018093B760-0x000000018093B7D0
		[NativeMethod] // 0x00000001800FEF60-0x00000001800FEFA0
		public static void DestroyImmediate(Object obj, [DefaultValue] /* 0x00000001800DFAE0-0x00000001800DFB10 */ bool allowDestroyingAssets) {} // 0x000000018093B650-0x000000018093B6A0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static void DestroyImmediate(Object obj) {} // 0x000000018093B5E0-0x000000018093B650
		[FreeFunction] // 0x00000001800FF100-0x00000001800FF150
		// [TypeInferenceRule] // 0x00000001800FF100-0x00000001800FF150
		public static Object[] FindObjectsOfType(Type type) => default; // 0x000000018093BA50-0x000000018093BA90
		[FreeFunction] // 0x00000001800FF320-0x00000001800FF350
		public static void DontDestroyOnLoad(Object target) {} // 0x000000018093B7D0-0x000000018093B810
		[ExcludeFromDocs] // 0x00000001800FF400-0x00000001800FF440
		[Obsolete] // 0x00000001800FF400-0x00000001800FF440
		public static void DestroyObject(Object obj) {} // 0x000000018093B6A0-0x000000018093B710
		public static T[] FindObjectsOfType<T>()
			where T : Object => default;
		public static T FindObjectOfType<T>()
			where T : Object => default;
		private static void CheckNullArgument(object arg, string message) {} // 0x000000018093B440-0x000000018093B4B0
		// [TypeInferenceRule] // 0x00000001800F6850-0x00000001800F6870
		public static Object FindObjectOfType(Type type) => default; // 0x000000018093B9C0-0x000000018093BA50
		public override string ToString() => default; // 0x000000018093C890-0x000000018093C900
		public static bool operator ==(Object x, Object y) => default; // 0x000000018093CA30-0x000000018093CAA0
		public static bool operator !=(Object x, Object y) => default; // 0x000000018093CB70-0x000000018093CBE0
		[NativeMethod] // 0x00000001800FF580-0x00000001800FF5C0
		private static int GetOffsetOfInstanceIDInCPlusPlusObject() => default; // 0x000000018093BC10-0x000000018093BC40
		[FreeFunction] // 0x00000001800FF5F0-0x00000001800FF620
		private static Object Internal_CloneSingle(Object data) => default; // 0x000000018093C5B0-0x000000018093C5F0
		[FreeFunction] // 0x00000001800FF5F0-0x00000001800FF620
		private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) => default; // 0x000000018093C550-0x000000018093C5B0
		[FreeFunction] // 0x00000001800FF770-0x00000001800FF7A0
		private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) => default; // 0x000000018093C760-0x000000018093C7F0
		[FreeFunction] // 0x00000001800FF770-0x00000001800FF7A0
		private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) => default; // 0x000000018093C660-0x000000018093C700
		[FreeFunction] // 0x00000001800FF9A0-0x00000001800FF9D0
		private static string ToString(Object obj) => default; // 0x000000018093C900-0x000000018093C940
		[FreeFunction] // 0x00000001800FFA00-0x00000001800FFA30
		private static string GetName(Object obj) => default; // 0x000000018093BBD0-0x000000018093BC10
		[FreeFunction] // 0x00000001800FFAE0-0x00000001800FFB10
		private static void SetName(Object obj, string name) {} // 0x000000018093C840-0x000000018093C890
		[FreeFunction] // 0x00000001800FFBC0-0x00000001800FFC10
		[VisibleToOtherModules] // 0x00000001800FFBC0-0x00000001800FFC10
		internal static Object FindObjectFromInstanceID(int instanceID) => default; // 0x000000018093B980-0x000000018093B9C0
		private static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot) => default; // 0x000000018093C700-0x000000018093C760
		private static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot) => default; // 0x000000018093C5F0-0x000000018093C660
	}
}
