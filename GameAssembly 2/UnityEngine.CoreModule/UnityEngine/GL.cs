/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x000000018013B8A0-0x000000018013B970
	// [NativeHeader] // 0x000000018013B8A0-0x000000018013B970
	// [NativeHeader] // 0x000000018013B8A0-0x000000018013B970
	// [NativeHeader] // 0x000000018013B8A0-0x000000018013B970
	// [StaticAccessor] // 0x000000018013B8A0-0x000000018013B970
	public sealed class GL // TypeDefIndex: 3141
	{
		// Constructors
		public GL() {} // Dummy constructor
	
		// Methods
		// [NativeName] // 0x000000018013BB10-0x000000018013BB40
		public static void Vertex3(float x, float y, float z) {} // 0x0000000180969700-0x0000000180969760
		// [NativeName] // 0x000000018013BBD0-0x000000018013BC00
		public static void TexCoord3(float x, float y, float z) {} // 0x00000001809696A0-0x0000000180969700
		public static void TexCoord2(float x, float y) {} // 0x0000000180969650-0x00000001809696A0
		// [NativeName] // 0x000000018013BC30-0x000000018013BC60
		public static void MultiTexCoord3(int unit, float x, float y, float z) {} // 0x0000000180969580-0x00000001809695F0
		public static void MultiTexCoord2(int unit, float x, float y) {} // 0x0000000180969520-0x0000000180969580
		// [NativeName] // 0x000000018013BCC0-0x000000018013BCF0
		private static void ImmediateColor(float r, float g, float b, float a) {} // 0x0000000180969310-0x0000000180969390
		public static void Color(Color c) {} // 0x0000000180969060-0x00000001809690C0
		[FreeFunction] // 0x000000018013BDA0-0x000000018013BDD0
		public static void PushMatrix() {} // 0x0000000180969620-0x0000000180969650
		[FreeFunction] // 0x000000018013BE50-0x000000018013BE80
		public static void PopMatrix() {} // 0x00000001809695F0-0x0000000180969620
		[FreeFunction] // 0x000000018013BF60-0x000000018013BF90
		public static void LoadIdentity() {} // 0x0000000180969440-0x0000000180969470
		[FreeFunction] // 0x000000018013C060-0x000000018013C090
		public static void LoadOrtho() {} // 0x0000000180969470-0x00000001809694A0
		[FreeFunction] // 0x000000018013C1C0-0x000000018013C1F0
		public static void LoadProjectionMatrix(Matrix4x4 mat) {} // 0x00000001809694E0-0x0000000180969520
		[FreeFunction] // 0x000000018013C2A0-0x000000018013C2D0
		public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) => default; // 0x0000000180969270-0x0000000180969310
		[FreeFunction] // 0x00000001800F2910-0x00000001800F2920
		private static void GLIssuePluginEvent(IntPtr callback, int eventID) {} // 0x00000001809691D0-0x0000000180969210
		public static void IssuePluginEvent(IntPtr callback, int eventID) {} // 0x0000000180969390-0x0000000180969440
		[FreeFunction] // 0x000000018013C430-0x000000018013C470
		public static void Begin(int mode) {} // 0x0000000180968F70-0x0000000180968FB0
		[FreeFunction] // 0x000000018013C5A0-0x000000018013C5D0
		public static void End() {} // 0x00000001809690C0-0x00000001809690F0
		[FreeFunction] // 0x00000001800F2910-0x00000001800F2920
		private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) {} // 0x0000000180969160-0x00000001809691D0
		public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) {} // 0x0000000180969000-0x0000000180969060
		[FreeFunction] // 0x000000018013C710-0x000000018013C740
		public static void ClearWithSkybox(bool clearDepth, Camera camera) {} // 0x0000000180968FB0-0x0000000180969000
		private static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat) {} // 0x00000001809694A0-0x00000001809694E0
		private static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000180969210-0x0000000180969270
		private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) {} // 0x00000001809690F0-0x0000000180969160
	}
}
