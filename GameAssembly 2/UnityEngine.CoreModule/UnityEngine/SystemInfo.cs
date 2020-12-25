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

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180101DE0-0x0000000180101ED0
	// [NativeHeader] // 0x0000000180101DE0-0x0000000180101ED0
	// [NativeHeader] // 0x0000000180101DE0-0x0000000180101ED0
	// [NativeHeader] // 0x0000000180101DE0-0x0000000180101ED0
	// [NativeHeader] // 0x0000000180101DE0-0x0000000180101ED0
	// [NativeHeader] // 0x0000000180101DE0-0x0000000180101ED0
	public sealed class SystemInfo // TypeDefIndex: 3313
	{
		// Properties
		public static OperatingSystemFamily operatingSystemFamily { get => default; } // 0x00000001808DF320-0x00000001808DF350 
		public static string deviceUniqueIdentifier { get => default; } // 0x00000001808DF1F0-0x00000001808DF220 
		public static DeviceType deviceType { get => default; } // 0x00000001808DF1C0-0x00000001808DF1F0 
		public static GraphicsDeviceType graphicsDeviceType { get => default; } // 0x00000001808DF220-0x00000001808DF250 
		public static bool graphicsUVStartsAtTop { get => default; } // 0x00000001808DF2F0-0x00000001808DF320 
		public static string graphicsDeviceVersion { get => default; } // 0x00000001808DF250-0x00000001808DF280 
		public static int graphicsShaderLevel { get => default; } // 0x00000001808DF2C0-0x00000001808DF2F0 
		[Obsolete] // 0x0000000180105F10-0x0000000180105F40
		public static bool supportsRenderTextures { get => default; } // 0x00000001808DAFA0-0x00000001808DAFB0 
		public static bool supportsMotionVectors { get => default; } // 0x00000001808DF540-0x00000001808DF570 
		[Obsolete] // 0x0000000180105FE0-0x0000000180106010
		public static bool supportsImageEffects { get => default; } // 0x00000001808DAFA0-0x00000001808DAFB0 
		public static bool supports3DTextures { get => default; } // 0x00000001808DF4E0-0x00000001808DF510 
		public static bool supports3DRenderTextures { get => default; } // 0x00000001808DF4B0-0x00000001808DF4E0 
		public static CopyTextureSupport copyTextureSupport { get => default; } // 0x00000001808DF190-0x00000001808DF1C0 
		public static bool supportsComputeShaders { get => default; } // 0x00000001808DF510-0x00000001808DF540 
		public static int supportedRenderTargetCount { get => default; } // 0x00000001808DF480-0x00000001808DF4B0 
		public static int supportedRandomWriteTargetCount { get => default; } // 0x00000001808DF450-0x00000001808DF480 
		public static bool usesReversedZBuffer { get => default; } // 0x00000001808DF720-0x00000001808DF750 
		public static bool usesLoadStoreActions { get => default; } // 0x00000001808DF6F0-0x00000001808DF720 
	
		// Constructors
		public SystemInfo() {} // Dummy constructor
	
		// Methods
		private static bool IsValidEnumValue(Enum value) => default; // 0x00000001808DF3D0-0x00000001808DF450
		public static bool SupportsRenderTextureFormat(RenderTextureFormat format) => default; // 0x00000001808DF570-0x00000001808DF610
		public static bool SupportsTextureFormat(TextureFormat format) => default; // 0x00000001808DF650-0x00000001808DF6F0
		[FreeFunction] // 0x0000000180102140-0x0000000180102170
		private static OperatingSystemFamily GetOperatingSystemFamily() => default; // 0x00000001808DF320-0x00000001808DF350
		[FreeFunction] // 0x0000000180102320-0x0000000180102350
		private static string GetDeviceUniqueIdentifier() => default; // 0x00000001808DF1F0-0x00000001808DF220
		[FreeFunction] // 0x00000001801024B0-0x00000001801024E0
		private static DeviceType GetDeviceType() => default; // 0x00000001808DF1C0-0x00000001808DF1F0
		[FreeFunction] // 0x0000000180102510-0x0000000180102540
		private static GraphicsDeviceType GetGraphicsDeviceType() => default; // 0x00000001808DF220-0x00000001808DF250
		[FreeFunction] // 0x00000001801026F0-0x0000000180102720
		private static bool GetGraphicsUVStartsAtTop() => default; // 0x00000001808DF2F0-0x00000001808DF320
		[FreeFunction] // 0x0000000180102850-0x0000000180102880
		private static string GetGraphicsDeviceVersion() => default; // 0x00000001808DF250-0x00000001808DF280
		[FreeFunction] // 0x0000000180102A30-0x0000000180102A60
		private static int GetGraphicsShaderLevel() => default; // 0x00000001808DF2C0-0x00000001808DF2F0
		[FreeFunction] // 0x0000000180102A90-0x0000000180102AC0
		private static bool SupportsMotionVectors() => default; // 0x00000001808DF540-0x00000001808DF570
		[FreeFunction] // 0x0000000180102BB0-0x0000000180102BE0
		private static bool Supports3DTextures() => default; // 0x00000001808DF4E0-0x00000001808DF510
		[FreeFunction] // 0x0000000180102CC0-0x0000000180102CF0
		private static bool Supports3DRenderTextures() => default; // 0x00000001808DF4B0-0x00000001808DF4E0
		[FreeFunction] // 0x0000000180102D20-0x0000000180102D50
		private static CopyTextureSupport GetCopyTextureSupport() => default; // 0x00000001808DF190-0x00000001808DF1C0
		[FreeFunction] // 0x0000000180102E30-0x0000000180102E60
		private static bool SupportsComputeShaders() => default; // 0x00000001808DF510-0x00000001808DF540
		[FreeFunction] // 0x0000000180102FF0-0x0000000180103020
		private static int SupportedRenderTargetCount() => default; // 0x00000001808DF480-0x00000001808DF4B0
		[FreeFunction] // 0x0000000180103180-0x00000001801031B0
		private static int SupportedRandomWriteTargetCount() => default; // 0x00000001808DF450-0x00000001808DF480
		[FreeFunction] // 0x0000000180104520-0x0000000180104550
		private static bool UsesReversedZBuffer() => default; // 0x00000001808DF720-0x00000001808DF750
		[FreeFunction] // 0x0000000180104720-0x0000000180104750
		private static bool HasRenderTextureNative(RenderTextureFormat format) => default; // 0x00000001808DF350-0x00000001808DF390
		[FreeFunction] // 0x00000001801047C0-0x00000001801047F0
		private static bool SupportsTextureFormatNative(TextureFormat format) => default; // 0x00000001808DF610-0x00000001808DF650
		[FreeFunction] // 0x00000001801048F0-0x0000000180104920
		public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) => default; // 0x00000001808DF390-0x00000001808DF3D0
		[FreeFunction] // 0x0000000180104950-0x0000000180104980
		public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) => default; // 0x00000001808DF150-0x00000001808DF190
		[FreeFunction] // 0x0000000180104A80-0x0000000180104AB0
		public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) => default; // 0x00000001808DF280-0x00000001808DF2C0
		[FreeFunction] // 0x0000000180105E00-0x0000000180105E30
		private static bool UsesLoadStoreActions() => default; // 0x00000001808DF6F0-0x00000001808DF720
	}
}
