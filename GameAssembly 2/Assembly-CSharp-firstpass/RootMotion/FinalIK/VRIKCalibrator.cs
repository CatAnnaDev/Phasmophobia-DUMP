/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.FinalIK
{
	public static class VRIKCalibrator // TypeDefIndex: 6823
	{
		// Nested types
		[Serializable]
		public class Settings // TypeDefIndex: 6824
		{
			// Fields
			// [Tooltip] // 0x0000000180102E00-0x0000000180102E30
			public Vector3 headTrackerForward; // 0x10
			// [Tooltip] // 0x0000000180102F70-0x0000000180102FA0
			public Vector3 headTrackerUp; // 0x1C
			// [Tooltip] // 0x0000000180103150-0x0000000180103180
			public Vector3 bodyTrackerForward; // 0x28
			// [Tooltip] // 0x00000001801044F0-0x0000000180104520
			public Vector3 bodyTrackerUp; // 0x34
			// [Tooltip] // 0x00000001801046F0-0x0000000180104720
			public Vector3 handTrackerForward; // 0x40
			// [Tooltip] // 0x0000000180104790-0x00000001801047C0
			public Vector3 handTrackerUp; // 0x4C
			// [Tooltip] // 0x00000001801047F0-0x0000000180104820
			public Vector3 footTrackerForward; // 0x58
			// [Tooltip] // 0x0000000180104920-0x0000000180104950
			public Vector3 footTrackerUp; // 0x64
			[Space] // 0x00000001801049B0-0x0000000180104A00
			// [Tooltip] // 0x00000001801049B0-0x0000000180104A00
			public Vector3 headOffset; // 0x70
			// [Tooltip] // 0x0000000180105E30-0x0000000180105E60
			public Vector3 handOffset; // 0x7C
			// [Tooltip] // 0x0000000180105F40-0x0000000180105F70
			public float footForwardOffset; // 0x88
			// [Tooltip] // 0x0000000180106010-0x0000000180106040
			public float footInwardOffset; // 0x8C
			// [Range] // 0x00000001801060D0-0x0000000180106130
			// [Tooltip] // 0x00000001801060D0-0x0000000180106130
			public float footHeadingOffset; // 0x90
	
			// Constructors
			public Settings() {} // 0x00000001807D40F0-0x00000001807D4220
		}
	
		// Methods
		public static void Calibrate(VRIK ik, Settings settings, Transform headTracker, Transform bodyTracker = null, Transform leftHandTracker = null, Transform rightHandTracker = null, Transform leftFootTracker = null, Transform rightFootTracker = null) {} // 0x00000001807D6FA0-0x00000001807D8960
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft) {} // 0x00000001807D65D0-0x00000001807D6FA0
	}
}
