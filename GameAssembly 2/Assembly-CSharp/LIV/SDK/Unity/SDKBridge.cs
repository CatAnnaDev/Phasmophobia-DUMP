/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace LIV.SDK.Unity
{
	public static class SDKBridge // TypeDefIndex: 8572
	{
		// Fields
		private static SDKInjection<SDKInputFrame> _injection_SDKInputFrame; // 0x00
		private static SDKInjection<bool> _injection_IsActive; // 0x160
		private static bool _injection_DisableSubmit; // 0x162
		private static bool _injection_DisableSubmitApplicationOutput; // 0x163
		private static bool _injection_DisableAddTexture; // 0x164
		private static bool _injection_DisableCreateFrame; // 0x165
		private static Action _injection_InputFrameHandler; // 0x168
	
		// Properties
		public static bool IsActive { get; } // 0x000000018180AA50-0x000000018180AB60 
	
		// Nested types
		public struct SDKInjection<T> // TypeDefIndex: 8573
		{
			// Fields
			public bool active;
			public T data;
		}
	
		private struct testing // TypeDefIndex: 8574
		{
			// Fields
			private int x; // 0x00
			private int y; // 0x04
		}
	
		// Constructors
		static SDKBridge() {} // 0x000000018180A680-0x000000018180A890
	
		// Methods
		private static extern IntPtr GetRenderEventFunc(); // 0x00000001818096E0-0x0000000181809750
		private static extern bool GetIsCaptureActive(); // 0x00000001818094B0-0x0000000181809520
		private static extern int GetTextureWidth(); // 0x00000001818097C0-0x0000000181809830
		private static extern int GetTextureHeight(); // 0x0000000181809750-0x00000001818097C0
		private static extern void SetTexture(IntPtr texture); // 0x0000000181809C80-0x0000000181809D00
		public static extern int AcquireCompositorFrame(ulong timestamp); // 0x0000000181808190-0x0000000181808210
		public static extern int ReleaseCompositorFrame(); // 0x0000000181809C10-0x0000000181809C80
		public static extern ulong GetObjectTimeStamp(IntPtr obj); // 0x00000001818095A0-0x0000000181809620
		private static extern ulong GetCurrentTimeTicks(); // 0x0000000181808EC0-0x0000000181808F30
		public static extern ulong GetObjectTag(IntPtr obj); // 0x0000000181809520-0x00000001818095A0
		public static extern IntPtr GetCompositorFrameObject(ulong tag); // 0x0000000181808E40-0x0000000181808EC0
		public static extern IntPtr GetViewportTexture(); // 0x00000001818099D0-0x0000000181809A40
		public static extern IntPtr GetCompositorChannelObject(int slot, ulong tag, ulong timestamp); // 0x0000000181808DA0-0x0000000181808E40
		public static extern IntPtr GetChannelObject(int slot, ulong tag, ulong timestamp); // 0x0000000181808D00-0x0000000181808DA0
		public static extern int AddObjectToChannel(int slot, IntPtr obj, int objectsize, ulong tag); // 0x0000000181808210-0x00000001818082B0
		public static extern int AddObjectToCompositorChannel(int slot, IntPtr obj, int objectsize, ulong tag); // 0x00000001818082B0-0x0000000181808350
		public static extern int AddObjectToFrame(IntPtr obj, int objectsize, ulong tag); // 0x0000000181808350-0x00000001818083F0
		public static extern int AddStringToFrame(IntPtr str, ulong tag); // 0x0000000181808490-0x0000000181808520
		public static extern int AddStringToChannel(int slot, IntPtr str, ulong tag); // 0x00000001818083F0-0x0000000181808490
		public static extern int NewFrame(); // 0x0000000181809B30-0x0000000181809BA0
		public static extern IntPtr CommitFrame(); // 0x00000001818089E0-0x0000000181808A50
		public static extern int addsharedtexture(int width, int height, int format, IntPtr sourcetexture, ulong tag); // 0x000000018180A890-0x000000018180A940
		public static extern int addtexture(IntPtr sourcetexture, ulong tag); // 0x000000018180A940-0x000000018180A9D0
		public static extern void PublishTextures(); // 0x0000000181809BA0-0x0000000181809C10
		public static extern IntPtr updatinputframe(IntPtr InputFrame); // 0x000000018180ACF0-0x000000018180AFD0
		public static extern IntPtr setinputframe(float x, float y, float z, float q0, float q1, float q2, float q3, float fov, int priority); // 0x000000018180ABE0-0x000000018180ACF0
		public static extern ulong setfeature(ulong feature); // 0x000000018180AB60-0x000000018180ABE0
		public static extern ulong clearfeature(ulong feature); // 0x000000018180A9D0-0x000000018180AA50
		public static ulong Tag(string str) => default; // 0x0000000181809F30-0x0000000181809FA0
		public static void AddString(string tag, string value, int slot) {} // 0x0000000181808520-0x0000000181808690
		public static void AddTexture(SDKTexture texture, ulong tag) {} // 0x0000000181808890-0x00000001818089E0
		public static ulong GetObjectTime(IntPtr objectptr) => default; // 0x0000000181809620-0x00000001818096E0
		public static ulong GetCurrentTime() => default; // 0x0000000181808F30-0x0000000181808FE0
		public static void IssuePluginEvent() {} // 0x0000000181809A40-0x0000000181809B30
		public static void SubmitApplicationOutput(SDKApplicationOutput applicationOutput) {} // 0x0000000181809D00-0x0000000181809F30
		public static SDKInputFrame GetInputFrame() => default; // 0x0000000181808FE0-0x00000001818094B0
		public static bool GetStructFromBridgeChannel<T>(ref T mystruct, int channel, ulong tag) => default;
		public static int AddStructToBridgeChannel<T>(ref T mystruct, int channel, ulong tag) => default;
		public static void AddStructToFrame<T>(ref T mystruct, ulong tag) {}
		public static bool UpdateInputFrame(ref SDKInputFrame setframe) => default; // 0x0000000181809FA0-0x000000018180A680
		public static SDKTexture GetViewfinderTexture() => default; // 0x0000000181809830-0x00000001818099D0
		public static void AddTexture(SDKTexture texture) {} // 0x0000000181808690-0x0000000181808890
		public static void CreateFrame(SDKOutputFrame frame) {} // 0x0000000181808A50-0x0000000181808D00
	}
}
