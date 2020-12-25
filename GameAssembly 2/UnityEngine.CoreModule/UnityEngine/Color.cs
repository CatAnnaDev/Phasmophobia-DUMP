/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [DefaultMember] // 0x00000001800E9E80-0x00000001800E9F20
	// [NativeClass] // 0x00000001800E9E80-0x00000001800E9F20
	// [NativeHeader] // 0x00000001800E9E80-0x00000001800E9F20
	[RequiredByNativeCode] // 0x00000001800E9E80-0x00000001800E9F20
	public struct Color : IEquatable<UnityEngine.Color> // TypeDefIndex: 3216
	{
		// Fields
		public float r; // 0x00
		public float g; // 0x04
		public float b; // 0x08
		public float a; // 0x0C
	
		// Properties
		public static Color red { get => default; } // 0x0000000180963F00-0x0000000180963F10 
		public static Color green { get => default; } // 0x0000000180963DA0-0x0000000180963E70 
		public static Color blue { get => default; } // 0x0000000180963D20-0x0000000180963D30 
		public static Color white { get => default; } // 0x0000000180963F10-0x0000000180963F20 
		public static Color black { get => default; } // 0x0000000180963D10-0x0000000180963D20 
		public static Color yellow { get => default; } // 0x0000000180963F20-0x0000000180963F30 
		public static Color cyan { get => default; } // 0x0000000180963D40-0x0000000180963D50 
		public static Color magenta { get => default; } // 0x0000000180963E70-0x0000000180963F00 
		public static Color gray { get => default; } // 0x0000000180963D50-0x0000000180963DA0 
		public static Color grey { get => default; } // 0x0000000180963D50-0x0000000180963DA0 
		public static Color clear { get => default; } // 0x0000000180963D30-0x0000000180963D40 
		public float grayscale { get => default; } // 0x0000000180043BB0-0x0000000180043BF0 
		public Color linear { get => default; } // 0x0000000180043BF0-0x0000000180043C20 
		public float maxColorComponent { get => default; } // 0x0000000180043C20-0x0000000180043C30 
	
		// Constructors
		public Color(float r, float g, float b, float a) : this() {
			this.r = default;
			this.g = default;
			this.b = default;
			this.a = default;
		} // 0x000000018003BA40-0x000000018003BA60
		public Color(float r, float g, float b) : this() {
			this.r = default;
			this.g = default;
			this.b = default;
			a = default;
		} // 0x0000000180043B90-0x0000000180043BB0
	
		// Methods
		public override string ToString() => default; // 0x0000000180043B80-0x0000000180043B90
		public override int GetHashCode() => default; // 0x0000000180043AC0-0x0000000180043B30
		public override bool Equals(object other) => default; // 0x00000001800439E0-0x0000000180043AC0
		public bool Equals(Color other) => default; // 0x000000018003B770-0x000000018003B7E0
		public static Color operator +(Color a, Color b) => default; // 0x0000000180963F30-0x0000000180963FA0
		public static Color operator -(Color a, Color b) => default; // 0x00000001809643B0-0x00000001809644E0
		public static Color operator *(Color a, Color b) => default; // 0x00000001809642F0-0x0000000180964360
		public static Color operator *(Color a, float b) => default; // 0x0000000180964360-0x00000001809643B0
		public static Color operator *(float b, Color a) => default; // 0x0000000180964290-0x00000001809642F0
		public static Color operator /(Color a, float b) => default; // 0x0000000180963FA0-0x0000000180963FF0
		public static bool operator ==(Color lhs, Color rhs) => default; // 0x0000000180963FF0-0x00000001809640E0
		public static bool operator !=(Color lhs, Color rhs) => default; // 0x0000000180964170-0x0000000180964290
		public static Color Lerp(Color a, Color b, float t) => default; // 0x0000000180963970-0x0000000180963D10
		internal Color RGBMultiplied(float multiplier) => default; // 0x0000000180043B30-0x0000000180043B80
		public static implicit operator Vector4(Color c) => default; // 0x0000000180964120-0x0000000180964170
		public static implicit operator Color(Vector4 v) => default; // 0x00000001809640E0-0x0000000180964120
	}
}
