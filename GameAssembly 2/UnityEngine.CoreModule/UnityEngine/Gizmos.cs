/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180133370-0x00000001801333D0
	// [StaticAccessor] // 0x0000000180133370-0x00000001801333D0
	public sealed class Gizmos // TypeDefIndex: 3130
	{
		// Properties
		public static Color color { set {} } // 0x000000018096AC80-0x000000018096ACC0
		public static Matrix4x4 matrix { set {} } // 0x000000018096AD00-0x000000018096AD50
	
		// Constructors
		public Gizmos() {} // Dummy constructor
	
		// Methods
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static void DrawLine(Vector3 from, Vector3 to) {} // 0x000000018096A650-0x000000018096A6A0
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static void DrawWireSphere(Vector3 center, float radius) {} // 0x000000018096ABF0-0x000000018096AC40
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static void DrawSphere(Vector3 center, float radius) {} // 0x000000018096A960-0x000000018096A9B0
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static void DrawWireCube(Vector3 center, Vector3 size) {} // 0x000000018096AA00-0x000000018096AA50
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static void DrawCube(Vector3 center, Vector3 size) {} // 0x000000018096A400-0x000000018096A450
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static void DrawMesh(Mesh mesh, int submeshIndex, [DefaultValue] /* 0x0000000180133640-0x0000000180133670 */ Vector3 position, [DefaultValue] /* 0x00000001801336F0-0x0000000180133720 */ Quaternion rotation, [DefaultValue] /* 0x0000000180133790-0x00000001801337C0 */ Vector3 scale) {} // 0x000000018096A8A0-0x000000018096A910
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, [DefaultValue] /* 0x0000000180133640-0x0000000180133670 */ Vector3 position, [DefaultValue] /* 0x00000001801336F0-0x0000000180133720 */ Quaternion rotation, [DefaultValue] /* 0x0000000180133790-0x00000001801337C0 */ Vector3 scale) {} // 0x000000018096AB30-0x000000018096ABA0
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static void DrawIcon(Vector3 center, string name, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool allowScaling) {} // 0x000000018096A520-0x000000018096A590
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static void DrawIcon(Vector3 center, string name, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool allowScaling, [DefaultValue] /* 0x0000000180133DA0-0x0000000180133DD0 */ Color tint) {} // 0x000000018096A590-0x000000018096A600
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static void DrawMesh(Mesh mesh) {} // 0x000000018096A780-0x000000018096A8A0
		public static void DrawMesh(Mesh mesh, [DefaultValue] /* 0x0000000180133640-0x0000000180133670 */ Vector3 position, [DefaultValue] /* 0x00000001801336F0-0x0000000180133720 */ Quaternion rotation, [DefaultValue] /* 0x0000000180133790-0x00000001801337C0 */ Vector3 scale) {} // 0x000000018096A700-0x000000018096A780
		public static void DrawWireMesh(Mesh mesh, [DefaultValue] /* 0x0000000180133640-0x0000000180133670 */ Vector3 position, [DefaultValue] /* 0x00000001801336F0-0x0000000180133720 */ Quaternion rotation, [DefaultValue] /* 0x0000000180133790-0x00000001801337C0 */ Vector3 scale) {} // 0x000000018096AAB0-0x000000018096AB30
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static void DrawIcon(Vector3 center, string name) {} // 0x000000018096A4C0-0x000000018096A520
		private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to) {} // 0x000000018096A600-0x000000018096A650
		private static void DrawWireSphere_Injected(ref Vector3 center, float radius) {} // 0x000000018096ABA0-0x000000018096ABF0
		private static void DrawSphere_Injected(ref Vector3 center, float radius) {} // 0x000000018096A910-0x000000018096A960
		private static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size) {} // 0x000000018096A9B0-0x000000018096AA00
		private static void DrawCube_Injected(ref Vector3 center, ref Vector3 size) {} // 0x000000018096A3B0-0x000000018096A400
		private static void DrawMesh_Injected(Mesh mesh, int submeshIndex, [DefaultValue] /* 0x0000000180133640-0x0000000180133670 */ ref Vector3 position, [DefaultValue] /* 0x00000001801336F0-0x0000000180133720 */ ref Quaternion rotation, [DefaultValue] /* 0x0000000180133790-0x00000001801337C0 */ ref Vector3 scale) {} // 0x000000018096A6A0-0x000000018096A700
		private static void DrawWireMesh_Injected(Mesh mesh, int submeshIndex, [DefaultValue] /* 0x0000000180133640-0x0000000180133670 */ ref Vector3 position, [DefaultValue] /* 0x00000001801336F0-0x0000000180133720 */ ref Quaternion rotation, [DefaultValue] /* 0x0000000180133790-0x00000001801337C0 */ ref Vector3 scale) {} // 0x000000018096AA50-0x000000018096AAB0
		private static void DrawIcon_Injected(ref Vector3 center, string name, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool allowScaling, [DefaultValue] /* 0x0000000180133DA0-0x0000000180133DD0 */ ref Color tint) {} // 0x000000018096A450-0x000000018096A4C0
		private static void set_color_Injected(ref Color value) {} // 0x000000018096AC40-0x000000018096AC80
		private static void set_matrix_Injected(ref Matrix4x4 value) {} // 0x000000018096ACC0-0x000000018096AD00
	}
}
