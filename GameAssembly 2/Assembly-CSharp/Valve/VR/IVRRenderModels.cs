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
	public struct IVRRenderModels // TypeDefIndex: 8152
	{
		// Fields
		internal _LoadRenderModel_Async LoadRenderModel_Async; // 0x00
		internal _FreeRenderModel FreeRenderModel; // 0x08
		internal _LoadTexture_Async LoadTexture_Async; // 0x10
		internal _FreeTexture FreeTexture; // 0x18
		internal _LoadTextureD3D11_Async LoadTextureD3D11_Async; // 0x20
		internal _LoadIntoTextureD3D11_Async LoadIntoTextureD3D11_Async; // 0x28
		internal _FreeTextureD3D11 FreeTextureD3D11; // 0x30
		internal _GetRenderModelName GetRenderModelName; // 0x38
		internal _GetRenderModelCount GetRenderModelCount; // 0x40
		internal _GetComponentCount GetComponentCount; // 0x48
		internal _GetComponentName GetComponentName; // 0x50
		internal _GetComponentButtonMask GetComponentButtonMask; // 0x58
		internal _GetComponentRenderModelName GetComponentRenderModelName; // 0x60
		internal _GetComponentState GetComponentState; // 0x68
		internal _RenderModelHasComponent RenderModelHasComponent; // 0x70
		internal _GetRenderModelThumbnailURL GetRenderModelThumbnailURL; // 0x78
		internal _GetRenderModelOriginalPath GetRenderModelOriginalPath; // 0x80
		internal _GetRenderModelErrorNameFromEnum GetRenderModelErrorNameFromEnum; // 0x88
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRRenderModelError _LoadRenderModel_Async(string pchRenderModelName, ref IntPtr ppRenderModel); // TypeDefIndex: 8153; 0x0000000181C90BC0-0x0000000181C910C0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _FreeRenderModel(IntPtr pRenderModel); // TypeDefIndex: 8154; 0x00000001802A7CC0-0x00000001802A7E90
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRRenderModelError _LoadTexture_Async(int textureId, ref IntPtr ppTexture); // TypeDefIndex: 8155; 0x00000001811ED1B0-0x00000001811ED4D0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _FreeTexture(IntPtr pTexture); // TypeDefIndex: 8156; 0x00000001802A7CC0-0x00000001802A7E90
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRRenderModelError _LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D); // TypeDefIndex: 8157; 0x0000000181E679B0-0x0000000181E67D20
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRRenderModelError _LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture); // TypeDefIndex: 8158; 0x00000001811ED1B0-0x00000001811ED4D0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _FreeTextureD3D11(IntPtr pD3D11Texture2D); // TypeDefIndex: 8159; 0x00000001802A7CC0-0x00000001802A7E90
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetRenderModelName(uint unRenderModelIndex, StringBuilder pchRenderModelName, uint unRenderModelNameLen); // TypeDefIndex: 8160; 0x0000000181F3BBC0-0x0000000181F3BDF0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetRenderModelCount(); // TypeDefIndex: 8161; 0x00000001811E8610-0x00000001811E87B0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetComponentCount(string pchRenderModelName); // TypeDefIndex: 8162; 0x00000001811E8D00-0x00000001811E9090
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetComponentName(string pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen); // TypeDefIndex: 8163; 0x0000000181F38080-0x0000000181F38520
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate ulong _GetComponentButtonMask(string pchRenderModelName, string pchComponentName); // TypeDefIndex: 8164; 0x000000018078EAB0-0x000000018078EFB0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetComponentRenderModelName(string pchRenderModelName, string pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen); // TypeDefIndex: 8165; 0x00000001811EDF30-0x00000001811EE480
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetComponentState(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState); // TypeDefIndex: 8166; 0x00000001811EB560-0x00000001811EBAE0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _RenderModelHasComponent(string pchRenderModelName, string pchComponentName); // TypeDefIndex: 8167; 0x0000000181E64F20-0x0000000181E65420
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetRenderModelThumbnailURL(string pchRenderModelName, StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError); // TypeDefIndex: 8168; 0x0000000181F3BEA0-0x0000000181F3C1E0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetRenderModelOriginalPath(string pchRenderModelName, StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError); // TypeDefIndex: 8169; 0x0000000181F3BEA0-0x0000000181F3C1E0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate IntPtr _GetRenderModelErrorNameFromEnum(EVRRenderModelError error); // TypeDefIndex: 8170; 0x00000001811EA830-0x00000001811EAA00
	}
}
