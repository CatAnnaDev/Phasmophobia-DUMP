/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeClass] // 0x0000000180131910-0x0000000180131A20
	// [NativeHeader] // 0x0000000180131910-0x0000000180131A20
	// [NativeHeader] // 0x0000000180131910-0x0000000180131A20
	// [NativeHeader] // 0x0000000180131910-0x0000000180131A20
	// [NativeHeader] // 0x0000000180131910-0x0000000180131A20
	[NativeType] // 0x0000000180131910-0x0000000180131A20
	[RequiredByNativeCode] // 0x0000000180131910-0x0000000180131A20
	public struct Bounds : IEquatable<UnityEngine.Bounds> // TypeDefIndex: 3123
	{
		// Fields
		private Vector3 m_Center; // 0x00
		// [NativeName] // 0x0000000180131C20-0x0000000180131C50
		private Vector3 m_Extents; // 0x0C
	
		// Properties
		public Vector3 center { get => default; set {} } // 0x000000018003AEA0-0x000000018003AEE0 0x000000018003BF20-0x000000018003BF30
		public Vector3 size { get => default; set {} } // 0x0000000180043700-0x00000001800437A0 0x0000000180043890-0x0000000180043920
		public Vector3 extents { get => default; set {} } // 0x000000018003BEB0-0x000000018003BED0 0x00000001800437A0-0x00000001800437B0
		public Vector3 min { get => default; set {} } // 0x00000001800436D0-0x0000000180043700 0x0000000180043820-0x0000000180043890
		public Vector3 max { get => default; set {} } // 0x00000001800436A0-0x00000001800436D0 0x00000001800437B0-0x0000000180043820
	
		// Constructors
		public Bounds(Vector3 center, Vector3 size) : this() {
			m_Center = default;
			m_Extents = default;
		} // 0x00000001800435F0-0x00000001800436A0
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000180043010-0x0000000180043070
		public override bool Equals(object other) => default; // 0x0000000180042C90-0x0000000180042DA0
		public bool Equals(Bounds other) => default; // 0x0000000180042DA0-0x0000000180042E40
		public static bool operator ==(Bounds lhs, Bounds rhs) => default; // 0x00000001809605B0-0x00000001809606A0
		public static bool operator !=(Bounds lhs, Bounds rhs) => default; // 0x00000001809606A0-0x0000000180960920
		public void SetMinMax(Vector3 min, Vector3 max) {} // 0x00000001800433F0-0x0000000180043430
		public void Encapsulate(Vector3 point) {} // 0x0000000180042C60-0x0000000180042C90
		public void Encapsulate(Bounds bounds) {} // 0x0000000180042B40-0x0000000180042C60
		public void Expand(float amount) {} // 0x0000000180042E40-0x0000000180042F30
		public void Expand(Vector3 amount) {} // 0x0000000180042F30-0x0000000180043010
		public bool Intersects(Bounds bounds) => default; // 0x0000000180043070-0x00000001800433F0
		public override string ToString() => default; // 0x0000000180043480-0x00000001800435F0
		[NativeMethod] // 0x0000000180131CA0-0x0000000180131CE0
		public bool Contains(Vector3 point) => default; // 0x0000000180042AF0-0x0000000180042B40
		[FreeFunction] // 0x0000000180132080-0x00000001801320C0
		public float SqrDistance(Vector3 point) => default; // 0x0000000180043430-0x0000000180043480
		private static bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point) => default; // 0x000000018095F860-0x0000000180960220
		private static float SqrDistance_Injected(ref Bounds _unity_self, ref Vector3 point) => default; // 0x0000000180960220-0x00000001809605B0
	}
}
