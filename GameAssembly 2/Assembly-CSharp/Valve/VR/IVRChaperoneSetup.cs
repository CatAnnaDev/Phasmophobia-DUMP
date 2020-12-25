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
	public struct IVRChaperoneSetup // TypeDefIndex: 8008
	{
		// Fields
		internal _CommitWorkingCopy CommitWorkingCopy; // 0x00
		internal _RevertWorkingCopy RevertWorkingCopy; // 0x08
		internal _GetWorkingPlayAreaSize GetWorkingPlayAreaSize; // 0x10
		internal _GetWorkingPlayAreaRect GetWorkingPlayAreaRect; // 0x18
		internal _GetWorkingCollisionBoundsInfo GetWorkingCollisionBoundsInfo; // 0x20
		internal _GetLiveCollisionBoundsInfo GetLiveCollisionBoundsInfo; // 0x28
		internal _GetWorkingSeatedZeroPoseToRawTrackingPose GetWorkingSeatedZeroPoseToRawTrackingPose; // 0x30
		internal _GetWorkingStandingZeroPoseToRawTrackingPose GetWorkingStandingZeroPoseToRawTrackingPose; // 0x38
		internal _SetWorkingPlayAreaSize SetWorkingPlayAreaSize; // 0x40
		internal _SetWorkingCollisionBoundsInfo SetWorkingCollisionBoundsInfo; // 0x48
		internal _SetWorkingSeatedZeroPoseToRawTrackingPose SetWorkingSeatedZeroPoseToRawTrackingPose; // 0x50
		internal _SetWorkingStandingZeroPoseToRawTrackingPose SetWorkingStandingZeroPoseToRawTrackingPose; // 0x58
		internal _ReloadFromDisk ReloadFromDisk; // 0x60
		internal _GetLiveSeatedZeroPoseToRawTrackingPose GetLiveSeatedZeroPoseToRawTrackingPose; // 0x68
		internal _SetWorkingCollisionBoundsTagsInfo SetWorkingCollisionBoundsTagsInfo; // 0x70
		internal _GetLiveCollisionBoundsTagsInfo GetLiveCollisionBoundsTagsInfo; // 0x78
		internal _SetWorkingPhysicalBoundsInfo SetWorkingPhysicalBoundsInfo; // 0x80
		internal _GetLivePhysicalBoundsInfo GetLivePhysicalBoundsInfo; // 0x88
		internal _ExportLiveToBuffer ExportLiveToBuffer; // 0x90
		internal _ImportFromBufferToWorking ImportFromBufferToWorking; // 0x98
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _CommitWorkingCopy(EChaperoneConfigFile configFile); // TypeDefIndex: 8009; 0x00000001808287F0-0x0000000180828AD0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _RevertWorkingCopy(); // TypeDefIndex: 8010; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ); // TypeDefIndex: 8011; 0x00000001811EC860-0x00000001811ECB50
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetWorkingPlayAreaRect(ref HmdQuad_t rect); // TypeDefIndex: 8012; 0x00000001811EC4F0-0x00000001811EC7C0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetWorkingCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount); // TypeDefIndex: 8013; 0x0000000181E680A0-0x0000000181E682A0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetLiveCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount); // TypeDefIndex: 8014; 0x0000000181E680A0-0x0000000181E682A0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose); // TypeDefIndex: 8015; 0x0000000181E68450-0x0000000181E68620
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose); // TypeDefIndex: 8016; 0x0000000181E68450-0x0000000181E68620
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _SetWorkingPlayAreaSize(float sizeX, float sizeZ); // TypeDefIndex: 8017; 0x0000000181E6EBD0-0x0000000181E6EF10
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _SetWorkingCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, uint unQuadsCount); // TypeDefIndex: 8018; 0x000000018047AFB0-0x000000018047B290
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose); // TypeDefIndex: 8019; 0x0000000181E6EFA0-0x0000000181E6F160
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose); // TypeDefIndex: 8020; 0x0000000181E6EFA0-0x0000000181E6F160
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _ReloadFromDisk(EChaperoneConfigFile configFile); // TypeDefIndex: 8021; 0x0000000180AC5520-0x0000000180AC56E0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose); // TypeDefIndex: 8022; 0x0000000181E68450-0x0000000181E68620
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _SetWorkingCollisionBoundsTagsInfo([In, Out] byte[] pTagsBuffer, uint unTagCount); // TypeDefIndex: 8023; 0x000000018047AFB0-0x000000018047B290
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetLiveCollisionBoundsTagsInfo([In, Out] byte[] pTagsBuffer, ref uint punTagCount); // TypeDefIndex: 8024; 0x00000001811EC860-0x00000001811ECB50
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _SetWorkingPhysicalBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, uint unQuadsCount); // TypeDefIndex: 8025; 0x00000001811EE520-0x00000001811EE810
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetLivePhysicalBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount); // TypeDefIndex: 8026; 0x0000000181E680A0-0x0000000181E682A0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _ExportLiveToBuffer(StringBuilder pBuffer, ref uint pnBufferLength); // TypeDefIndex: 8027; 0x0000000181E64F20-0x0000000181E65420
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _ImportFromBufferToWorking(string pBuffer, uint nImportFlags); // TypeDefIndex: 8028; 0x00000001806D5B30-0x00000001806D6070
	}
}
