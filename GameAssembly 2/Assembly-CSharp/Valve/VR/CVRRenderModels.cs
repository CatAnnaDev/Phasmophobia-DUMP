/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public class CVRRenderModels // TypeDefIndex: 8217
	{
		// Fields
		private IVRRenderModels FnTable; // 0x10
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetComponentStatePacked(string pchRenderModelName, string pchComponentName, ref VRControllerState_t_Packed pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState); // TypeDefIndex: 8218; 0x00000001811EB560-0x00000001811EBAE0
	
		private struct GetComponentStateUnion // TypeDefIndex: 8219
		{
			// Fields
			public IVRRenderModels._GetComponentState pGetComponentState; // 0x00
			public _GetComponentStatePacked pGetComponentStatePacked; // 0x00
		}
	
		// Constructors
		public CVRRenderModels() {} // Dummy constructor
		internal CVRRenderModels(IntPtr pInterface) {} // 0x00000001811DF680-0x00000001811DF7B0
	
		// Methods
		public EVRRenderModelError LoadRenderModel_Async(string pchRenderModelName, ref IntPtr ppRenderModel) => default; // 0x00000001811DF610-0x00000001811DF630
		public void FreeRenderModel(IntPtr pRenderModel) {} // 0x00000001811DF220-0x00000001811DF240
		public EVRRenderModelError LoadTexture_Async(int textureId, ref IntPtr ppTexture) => default; // 0x00000001811DF630-0x00000001811DF650
		public void FreeTexture(IntPtr pTexture) {} // 0x00000001811DF260-0x00000001811DF280
		public EVRRenderModelError LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D) => default; // 0x00000001811DD660-0x00000001811DD690
		public EVRRenderModelError LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture) => default; // 0x00000001811DF5F0-0x00000001811DF610
		public void FreeTextureD3D11(IntPtr pD3D11Texture2D) {} // 0x00000001811DF240-0x00000001811DF260
		public uint GetRenderModelName(uint unRenderModelIndex, StringBuilder pchRenderModelName, uint unRenderModelNameLen) => default; // 0x00000001811DF560-0x00000001811DF590
		public uint GetRenderModelCount() => default; // 0x00000001811DF4C0-0x00000001811DF4E0
		public uint GetComponentCount(string pchRenderModelName) => default; // 0x00000001811DF2A0-0x00000001811DF2C0
		public uint GetComponentName(string pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen) => default; // 0x00000001811DF2C0-0x00000001811DF2F0
		public ulong GetComponentButtonMask(string pchRenderModelName, string pchComponentName) => default; // 0x00000001811DF280-0x00000001811DF2A0
		public uint GetComponentRenderModelName(string pchRenderModelName, string pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen) => default; // 0x00000001811DF2F0-0x00000001811DF320
		public bool GetComponentState(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState) => default; // 0x00000001811DF320-0x00000001811DF4C0
		public bool RenderModelHasComponent(string pchRenderModelName, string pchComponentName) => default; // 0x00000001811DF650-0x00000001811DF680
		public uint GetRenderModelThumbnailURL(string pchRenderModelName, StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError) => default; // 0x00000001811DF5C0-0x00000001811DF5F0
		public uint GetRenderModelOriginalPath(string pchRenderModelName, StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError) => default; // 0x00000001811DF590-0x00000001811DF5C0
		public string GetRenderModelErrorNameFromEnum(EVRRenderModelError error) => default; // 0x00000001811DF4E0-0x00000001811DF560
	}
}
