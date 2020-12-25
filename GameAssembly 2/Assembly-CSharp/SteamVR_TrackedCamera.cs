/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class SteamVR_TrackedCamera // TypeDefIndex: 7304
{
	// Fields
	private static VideoStreamTexture[] distorted; // 0x00
	private static VideoStreamTexture[] undistorted; // 0x08
	private static VideoStream[] videostreams; // 0x10

	// Nested types
	public class VideoStreamTexture // TypeDefIndex: 7305
	{
		// Fields
		private Texture2D _texture; // 0x28
		private int prevFrameCount; // 0x30
		private uint glTextureId; // 0x34
		private VideoStream videostream; // 0x38
		private CameraVideoStreamFrameHeader_t header; // 0x40

		// Properties
		public bool undistorted { get; private set; } // 0x00000001803628F0-0x0000000180362930 0x00000001802F6FA0-0x00000001802F6FB0
		public uint deviceIndex { get => default; } // 0x0000000181D38470-0x0000000181D38490 
		public bool hasCamera { get => default; } // 0x0000000181D384D0-0x0000000181D384F0 
		public bool hasTracking { get => default; } // 0x0000000181D384F0-0x0000000181D38510 
		public uint frameId { get => default; } // 0x0000000181D384A0-0x0000000181D384C0 
		public VRTextureBounds_t frameBounds { get; private set; } // 0x0000000181D38490-0x0000000181D384A0 0x0000000180319D70-0x0000000180319D80
		public EVRTrackedCameraFrameType frameType { get => default; } // 0x0000000181D384C0-0x0000000181D384D0 
		public Texture2D texture { get => default; } // 0x0000000181D38510-0x0000000181D38530 
		public SteamVR_Utils.RigidTransform transform { get => default; } // 0x0000000181D38530-0x0000000181D385A0 
		public Vector3 velocity { get => default; } // 0x0000000181D385A0-0x0000000181D38610 
		public Vector3 angularVelocity { get => default; } // 0x0000000181D38400-0x0000000181D38470 

		// Constructors
		public VideoStreamTexture() {} // Dummy constructor
		public VideoStreamTexture(uint deviceIndex, bool undistorted) {} // 0x0000000181D383B0-0x0000000181D38400

		// Methods
		public TrackedDevicePose_t GetPose() => default; // 0x0000000181D37DE0-0x0000000181D37E40
		public ulong Acquire() => default; // 0x0000000181D37D40-0x0000000181D37DE0
		public ulong Release() => default; // 0x0000000181D37E40-0x0000000181D37F60
		private void Update() {} // 0x0000000181D37F60-0x0000000181D383B0
	}

	private class VideoStream // TypeDefIndex: 7306
	{
		// Fields
		private ulong _handle; // 0x18
		private bool _hasCamera; // 0x20
		private ulong refCount; // 0x28

		// Properties
		public uint deviceIndex { get; private set; } // 0x0000000180245EA0-0x0000000180246600 0x00000001802932E0-0x00000001802932F0
		public ulong handle { get => default; } // 0x0000000180246BC0-0x0000000180246BD0 
		public bool hasCamera { get => default; } // 0x000000018027A6C0-0x000000018027A6D0 

		// Constructors
		public VideoStream() {} // Dummy constructor
		public VideoStream(uint deviceIndex) {} // 0x0000000181D38740-0x0000000181D387C0

		// Methods
		public ulong Acquire() => default; // 0x0000000181D38610-0x0000000181D386A0
		public ulong Release() => default; // 0x0000000181D386A0-0x0000000181D38740
	}

	// Constructors
	public SteamVR_TrackedCamera() {} // 0x00000001802466A0-0x00000001802466B0

	// Methods
	public static VideoStreamTexture Distorted(int deviceIndex = 0 /* Metadata: 0x00653592 */) => default; // 0x0000000181D276B0-0x0000000181D27840
	public static VideoStreamTexture Undistorted(int deviceIndex = 0 /* Metadata: 0x00653596 */) => default; // 0x0000000181D27D20-0x0000000181D27EB0
	public static VideoStreamTexture Source(bool undistorted, int deviceIndex = 0 /* Metadata: 0x0065359A */) => default; // 0x0000000181D27840-0x0000000181D27B50
	private static VideoStream Stream(uint deviceIndex) => default; // 0x0000000181D27B50-0x0000000181D27D20
}

