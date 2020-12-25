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
	// [NativeClass] // 0x0000000180132190-0x0000000180132220
	// [NativeHeader] // 0x0000000180132190-0x0000000180132220
	[RequiredByNativeCode] // 0x0000000180132190-0x0000000180132220
	public struct Rect : IEquatable<UnityEngine.Rect> // TypeDefIndex: 3126
	{
		// Fields
		// [NativeName] // 0x0000000180132660-0x0000000180132690
		private float m_XMin; // 0x00
		// [NativeName] // 0x0000000180132750-0x0000000180132780
		private float m_YMin; // 0x04
		// [NativeName] // 0x0000000180132850-0x0000000180132880
		private float m_Width; // 0x08
		// [NativeName] // 0x0000000180132990-0x00000001801329C0
		private float m_Height; // 0x0C
	
		// Properties
		public static Rect zero { get => default; } // 0x0000000180945F70-0x0000000180945F80 
		public float x { get => default; set {} } // 0x0000000180005D50-0x0000000180005D60 0x000000018000FCF0-0x000000018000FD00
		public float y { get => default; set {} } // 0x000000018003C710-0x000000018003C720 0x000000018000FCE0-0x000000018000FCF0
		public Vector2 position { get => default; set {} } // 0x000000018003C680-0x000000018003C6B0 0x000000018003C760-0x000000018003C780
		public Vector2 center { get => default; set {} } // 0x000000018003C5F0-0x000000018003C640 0x000000018003C720-0x000000018003C760
		public Vector2 min { get => default; } // 0x000000018003C680-0x000000018003C6B0 
		public Vector2 max { get => default; } // 0x000000018003C640-0x000000018003C680 
		public float width { get => default; set {} } // 0x000000018003C6E0-0x000000018003C6F0 0x000000018000CFF0-0x000000018000D000
		public float height { get => default; set {} } // 0x000000018003AE90-0x000000018003AEA0 0x000000018000D000-0x000000018000D030
		public Vector2 size { get => default; set {} } // 0x000000018003C6B0-0x000000018003C6E0 0x000000018003C780-0x000000018003C7A0
		public float xMin { get => default; set {} } // 0x0000000180005D50-0x0000000180005D60 0x000000018003C7B0-0x000000018003C7D0
		public float yMin { get => default; set {} } // 0x000000018003C710-0x000000018003C720 0x000000018003C7E0-0x000000018003DC30
		public float xMax { get => default; set {} } // 0x000000018003C6F0-0x000000018003C700 0x000000018003C7A0-0x000000018003C7B0
		public float yMax { get => default; set {} } // 0x000000018003C700-0x000000018003C710 0x000000018003C7D0-0x000000018003C7E0
	
		// Constructors
		public Rect(float x, float y, float width, float height) : this() {
			m_XMin = default;
			m_YMin = default;
			m_Width = default;
			m_Height = default;
		} // 0x000000018003BA40-0x000000018003BA60
		public Rect(Vector2 position, Vector2 size) : this() {
			m_XMin = default;
			m_YMin = default;
			m_Width = default;
			m_Height = default;
		} // 0x000000018003C580-0x000000018003C5C0
		public Rect(Rect source) : this() {
			m_XMin = default;
			m_YMin = default;
			m_Width = default;
			m_Height = default;
		} // 0x000000018003C5C0-0x000000018003C5F0
	
		// Methods
		public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) => default; // 0x0000000180945970-0x00000001809459B0
		public void Set(float x, float y, float width, float height) {} // 0x000000018003BA40-0x000000018003BA60
		public bool Contains(Vector2 point) => default; // 0x000000018003C100-0x000000018003C140
		public bool Contains(Vector3 point) => default; // 0x000000018003C0B0-0x000000018003C100
		private static Rect OrderMinMax(Rect rect) => default; // 0x00000001809459B0-0x0000000180945F70
		public bool Overlaps(Rect other) => default; // 0x000000018003C390-0x000000018003C3F0
		public bool Overlaps(Rect other, bool allowInverse) => default; // 0x000000018003C3F0-0x000000018003C570
		public static bool operator !=(Rect lhs, Rect rhs) => default; // 0x0000000180945FC0-0x0000000180946140
		public static bool operator ==(Rect lhs, Rect rhs) => default; // 0x0000000180945F80-0x0000000180945FC0
		public override int GetHashCode() => default; // 0x000000018003C2F0-0x000000018003C390
		public override bool Equals(object other) => default; // 0x000000018003C140-0x000000018003C250
		public bool Equals(Rect other) => default; // 0x000000018003C250-0x000000018003C2F0
		public override string ToString() => default; // 0x000000018003C570-0x000000018003C580
	}
}
