/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800DEE00-0x00000001800DEE70
	// [NativeHeader] // 0x00000001800DEE00-0x00000001800DEE70
	[UsedByNativeCode] // 0x00000001800DEE00-0x00000001800DEE70
	public class Texture : Object // TypeDefIndex: 3201
	{
		// Fields
		public static readonly int GenerateAllMips; // 0x00
	
		// Properties
		public virtual int width { get => default; set {} } // 0x00000001808E1FB0-0x00000001808E1FF0 0x00000001808E26C0-0x00000001808E2710
		public virtual int height { get => default; set {} } // 0x00000001808E1F70-0x00000001808E1FB0 0x00000001808E2670-0x00000001808E26C0
		public virtual TextureDimension dimension { get => default; set {} } // 0x00000001808E1FF0-0x00000001808E2030 0x00000001808E25E0-0x00000001808E2630
		public virtual bool isReadable { get => default; } // 0x00000001808E2480-0x00000001808E24C0 
		public TextureWrapMode wrapMode { /* [NativeName] */ /* 0x00000001800DEF20-0x00000001800DEF50 */ get => default; set {} } // 0x00000001808E2560-0x00000001808E25A0 0x00000001808E2710-0x00000001808E2750
		public FilterMode filterMode { set {} } // 0x00000001808E2630-0x00000001808E2670
		public int anisoLevel { set {} } // 0x00000001808E25A0-0x00000001808E25E0
		public Vector2 texelSize { /* [NativeName] */ /* 0x00000001800DEFB0-0x00000001800DEFE0 */ get => default; } // 0x00000001808E2510-0x00000001808E2560 
	
		// Constructors
		protected Texture() {} // 0x00000001808E2420-0x00000001808E2480
		static Texture() {} // 0x00000001808E23E0-0x00000001808E2420
	
		// Methods
		private int GetDataWidth() => default; // 0x00000001808E1FB0-0x00000001808E1FF0
		private int GetDataHeight() => default; // 0x00000001808E1F70-0x00000001808E1FB0
		private TextureDimension GetDimension() => default; // 0x00000001808E1FF0-0x00000001808E2030
		public IntPtr GetNativeTexturePtr() => default; // 0x00000001808E2030-0x00000001808E2070
		internal bool ValidateFormat(TextureFormat format) => default; // 0x00000001808E2070-0x00000001808E2280
		internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) => default; // 0x00000001808E2280-0x00000001808E23E0
		internal UnityException CreateNonReadableException(Texture t) => default; // 0x00000001808E1EA0-0x00000001808E1F70
		private void get_texelSize_Injected(out Vector2 ret) {
			ret = default;
		} // 0x00000001808E24C0-0x00000001808E2510
	}
}
