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
	public class PhotonTransformViewRotationModel // TypeDefIndex: 5350
	{
		// Fields
		public bool SynchronizeEnabled; // 0x10
		public InterpolateOptions InterpolateOption; // 0x14
		public float InterpolateRotateTowardsSpeed; // 0x18
		public float InterpolateLerpSpeed; // 0x1C
	
		// Nested types
		public enum InterpolateOptions // TypeDefIndex: 5351
		{
			Disabled = 0,
			RotateTowards = 1,
			Lerp = 2
		}
	
		// Constructors
		public PhotonTransformViewRotationModel() {} // 0x0000000181DC1CC0-0x0000000181DC1CE0
	}
}
