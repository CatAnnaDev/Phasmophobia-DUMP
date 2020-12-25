/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 51: PhotonUnityNetworking.dll - Assembly: PhotonUnityNetworking, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5293-5359

namespace Photon.Pun
{
	[Serializable]
	public class PhotonTransformViewPositionModel // TypeDefIndex: 5346
	{
		// Fields
		public bool SynchronizeEnabled; // 0x10
		public bool TeleportEnabled; // 0x11
		public float TeleportIfDistanceGreaterThan; // 0x14
		public InterpolateOptions InterpolateOption; // 0x18
		public float InterpolateMoveTowardsSpeed; // 0x1C
		public float InterpolateLerpSpeed; // 0x20
		public ExtrapolateOptions ExtrapolateOption; // 0x24
		public float ExtrapolateSpeed; // 0x28
		public bool ExtrapolateIncludingRoundTripTime; // 0x2C
		public int ExtrapolateNumberOfStoredPositions; // 0x30
	
		// Nested types
		public enum InterpolateOptions // TypeDefIndex: 5347
		{
			Disabled = 0,
			FixedSpeed = 1,
			EstimatedSpeed = 2,
			SynchronizeValues = 3,
			Lerp = 4
		}
	
		public enum ExtrapolateOptions // TypeDefIndex: 5348
		{
			Disabled = 0,
			SynchronizeValues = 1,
			EstimateSpeedAndTurn = 2,
			FixedSpeed = 3
		}
	
		// Constructors
		public PhotonTransformViewPositionModel() {} // 0x0000000181DC1A10-0x0000000181DC1A50
	}
}
