/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 32: UnityEngine.UIModule.dll - Assembly: UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4132-4141

namespace UnityEngine
{
	// [NativeClass] // 0x000000018011C8D0-0x000000018011C990
	// [NativeHeader] // 0x000000018011C8D0-0x000000018011C990
	// [NativeHeader] // 0x000000018011C8D0-0x000000018011C990
	// [RequireComponent] // 0x000000018011C8D0-0x000000018011C990
	public sealed class Canvas : Behaviour // TypeDefIndex: 4138
	{
		// Properties
		public RenderMode renderMode { get => default; } // 0x0000000180AEDC00-0x0000000180AEDC40 
		public bool isRootCanvas { get => default; } // 0x0000000180AEDB00-0x0000000180AEDB40 
		public float scaleFactor { get => default; set {} } // 0x0000000180AEDCC0-0x0000000180AEDD00 0x0000000180AEDFA0-0x0000000180AEDFF0
		public float referencePixelsPerUnit { get => default; set {} } // 0x0000000180AEDBC0-0x0000000180AEDC00 0x0000000180AEDF50-0x0000000180AEDFA0
		public bool pixelPerfect { get => default; } // 0x0000000180AEDB80-0x0000000180AEDBC0 
		public float planeDistance { set {} } // 0x0000000180AEDF00-0x0000000180AEDF50
		public int renderOrder { get => default; } // 0x0000000180AEDC40-0x0000000180AEDC80 
		public bool overrideSorting { get => default; set {} } // 0x0000000180AEDB40-0x0000000180AEDB80 0x0000000180AEDEB0-0x0000000180AEDF00
		public int sortingOrder { get => default; set {} } // 0x0000000180AEDD40-0x0000000180AEDD80 0x0000000180AEE030-0x0000000180AEE070
		public int targetDisplay { get => default; } // 0x0000000180AEDD80-0x0000000180AEDDC0 
		public int sortingLayerID { get => default; set {} } // 0x0000000180AEDD00-0x0000000180AEDD40 0x0000000180AEDFF0-0x0000000180AEE030
		public Canvas rootCanvas { get => default; } // 0x0000000180AEDC80-0x0000000180AEDCC0 
		[NativeProperty] // 0x000000018011E440-0x000000018011E480
		public Camera worldCamera { get => default; set {} } // 0x0000000180AEDDC0-0x0000000180AEDE00 0x0000000180AEE070-0x0000000180AEE0C0
	
		// Events
		public static event WillRenderCanvases willRenderCanvases;
	
		// Nested types
		public delegate void WillRenderCanvases(); // TypeDefIndex: 4139; 0x0000000180533490-0x0000000180533710
	
		// Constructors
		public Canvas() {} // 0x00000001808E4F10-0x00000001808E4F20
	
		// Methods
		[FreeFunction] // 0x000000018011E1B0-0x000000018011E1E0
		public static Material GetDefaultCanvasMaterial() => default; // 0x0000000180AED9F0-0x0000000180AEDA20
		[FreeFunction] // 0x000000018011E290-0x000000018011E2C0
		public static Material GetETC1SupportedCanvasMaterial() => default; // 0x0000000180AEDA20-0x0000000180AEDA50
		public static void ForceUpdateCanvases() {} // 0x0000000180AED9A0-0x0000000180AED9F0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static void SendWillRenderCanvases() {} // 0x0000000180AED9A0-0x0000000180AED9F0
	}
}
