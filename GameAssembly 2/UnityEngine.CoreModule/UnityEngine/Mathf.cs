/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800F0470-0x00000001800F0510
	// [NativeHeader] // 0x00000001800F0470-0x00000001800F0510
	// [NativeHeader] // 0x00000001800F0470-0x00000001800F0510
	// [NativeHeader] // 0x00000001800F0470-0x00000001800F0510
	public struct Mathf // TypeDefIndex: 3225
	{
		// Fields
		public static readonly float Epsilon; // 0x00
	
		// Constructors
		static Mathf() {
			Epsilon = default;
		} // 0x0000000180934BC0-0x0000000180934C90
	
		// Methods
		[FreeFunction] // 0x00000001800E9DF0-0x00000001800E9E20
		public static int ClosestPowerOfTwo(int value) => default; // 0x00000001809338E0-0x0000000180933920
		[FreeFunction] // 0x00000001800E9DF0-0x00000001800E9E20
		public static float GammaToLinearSpace(float value) => default; // 0x0000000180933B90-0x0000000180933BD0
		[FreeFunction] // 0x00000001800E9DF0-0x00000001800E9E20
		public static float LinearToGammaSpace(float value) => default; // 0x0000000180933EA0-0x0000000180933EE0
		[FreeFunction] // 0x00000001800F09C0-0x00000001800F0A00
		public static float PerlinNoise(float x, float y) => default; // 0x00000001809341B0-0x0000000180934200
		public static float Sin(float f) => default; // 0x0000000180934500-0x0000000180934560
		public static float Cos(float f) => default; // 0x0000000180933920-0x0000000180933980
		public static float Tan(float f) => default; // 0x0000000180934B60-0x0000000180934BC0
		public static float Asin(float f) => default; // 0x0000000180933680-0x00000001809336E0
		public static float Acos(float f) => default; // 0x0000000180933550-0x00000001809335B0
		public static float Atan(float f) => default; // 0x0000000180933760-0x00000001809337C0
		public static float Atan2(float y, float x) => default; // 0x00000001809336E0-0x0000000180933760
		public static float Sqrt(float f) => default; // 0x0000000180934B00-0x0000000180934B60
		public static float Abs(float f) => default; // 0x00000001809334E0-0x0000000180933550
		public static int Abs(int value) => default; // 0x0000000180933490-0x00000001809334E0
		public static float Min(float a, float b) => default; // 0x00000001809340B0-0x00000001809340C0
		public static int Min(int a, int b) => default; // 0x00000001809340A0-0x00000001809340B0
		public static float Max(float a, float b) => default; // 0x0000000180934020-0x0000000180934030
		public static float Max(params /* 0x00000001800D4E50-0x00000001800D4E60 */ float[] values) => default; // 0x0000000180934040-0x00000001809340A0
		public static int Max(int a, int b) => default; // 0x0000000180934030-0x0000000180934040
		public static float Pow(float f, float p) => default; // 0x0000000180934300-0x0000000180934380
		public static float Exp(float power) => default; // 0x0000000180933A70-0x0000000180933AD0
		public static float Log(float f, float p) => default; // 0x0000000180933FA0-0x0000000180934020
		public static float Log(float f) => default; // 0x0000000180933F40-0x0000000180933FA0
		public static float Log10(float f) => default; // 0x0000000180933EE0-0x0000000180933F40
		public static float Ceil(float f) => default; // 0x0000000180933820-0x0000000180933880
		public static float Floor(float f) => default; // 0x0000000180933B30-0x0000000180933B90
		public static float Round(float f) => default; // 0x0000000180934480-0x00000001809344E0
		public static int CeilToInt(float f) => default; // 0x00000001809337C0-0x0000000180933820
		public static int FloorToInt(float f) => default; // 0x0000000180933AD0-0x0000000180933B30
		public static int RoundToInt(float f) => default; // 0x0000000180934420-0x0000000180934480
		public static float Sign(float f) => default; // 0x00000001809344E0-0x0000000180934500
		public static float Clamp(float value, float min, float max) => default; // 0x00000001809338A0-0x00000001809338C0
		public static int Clamp(int value, int min, int max) => default; // 0x00000001809338C0-0x00000001809338E0
		public static float Clamp01(float value) => default; // 0x0000000180933880-0x00000001809338A0
		public static float Lerp(float a, float b, float t) => default; // 0x0000000180933E00-0x0000000180933EA0
		public static float LerpUnclamped(float a, float b, float t) => default; // 0x0000000180933DE0-0x0000000180933E00
		public static float LerpAngle(float a, float b, float t) => default; // 0x0000000180933C80-0x0000000180933DE0
		public static float MoveTowards(float current, float target, float maxDelta) => default; // 0x00000001809340C0-0x00000001809341B0
		public static bool Approximately(float a, float b) => default; // 0x00000001809335B0-0x0000000180933680
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime) => default; // 0x0000000180934A40-0x0000000180934B00
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxSpeed, [DefaultValue] /* 0x00000001800EE370-0x00000001800EE3A0 */ float deltaTime) => default; // 0x00000001809348B0-0x0000000180934A40
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime) => default; // 0x00000001809346D0-0x00000001809348B0
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxSpeed, [DefaultValue] /* 0x00000001800EE370-0x00000001800EE3A0 */ float deltaTime) => default; // 0x0000000180934560-0x00000001809346D0
		public static float Repeat(float t, float length) => default; // 0x0000000180934380-0x0000000180934420
		public static float PingPong(float t, float length) => default; // 0x0000000180934200-0x0000000180934300
		public static float InverseLerp(float a, float b, float value) => default; // 0x0000000180933BD0-0x0000000180933C80
		public static float DeltaAngle(float current, float target) => default; // 0x0000000180933980-0x0000000180933A70
	}
}
