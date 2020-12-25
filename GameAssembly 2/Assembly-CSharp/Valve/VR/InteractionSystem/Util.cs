/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	public static class Util // TypeDefIndex: 8400
	{
		// Fields
		public const float FeetToMeters = 0.3048f; // Metadata: 0x00655887
		public const float FeetToCentimeters = 30.48f; // Metadata: 0x0065588B
		public const float InchesToMeters = 0.0254f; // Metadata: 0x0065588F
		public const float InchesToCentimeters = 2.54f; // Metadata: 0x00655893
		public const float MetersToFeet = 3.28084f; // Metadata: 0x00655897
		public const float MetersToInches = 39.3701f; // Metadata: 0x0065589B
		public const float CentimetersToFeet = 0.0328084f; // Metadata: 0x0065589F
		public const float CentimetersToInches = 0.393701f; // Metadata: 0x006558A3
		public const float KilometersToMiles = 0.621371f; // Metadata: 0x006558A7
		public const float MilesToKilometers = 1.60934f; // Metadata: 0x006558AB
	
		// Methods
		public static float RemapNumber(float num, float low1, float high1, float low2, float high2) => default; // 0x0000000180EF5F30-0x0000000180EF5F50
		public static float RemapNumberClamped(float num, float low1, float high1, float low2, float high2) => default; // 0x0000000180EF5E50-0x0000000180EF5F30
		public static float Approach(float target, float value, float speed) => default; // 0x0000000180EF48E0-0x0000000180EF4910
		public static Vector3 BezierInterpolate3(Vector3 p0, Vector3 c0, Vector3 p1, float t) => default; // 0x0000000180EF4910-0x0000000180EF4A80
		public static Vector3 BezierInterpolate4(Vector3 p0, Vector3 c0, Vector3 c1, Vector3 p1, float t) => default; // 0x0000000180EF4A80-0x0000000180EF4CA0
		public static Vector3 Vector3FromString(string szString) => default; // 0x0000000180EF6620-0x0000000180EF6790
		public static Vector2 Vector2FromString(string szString) => default; // 0x0000000180EF6460-0x0000000180EF65E0
		public static float Normalize(float value, float min, float max) => default; // 0x0000000180EF5B60-0x0000000180EF5B70
		public static Vector3 Vector2AsVector3(Vector2 v) => default; // 0x0000000180EF6420-0x0000000180EF6460
		public static Vector2 Vector3AsVector2(Vector3 v) => default; // 0x0000000180EF65E0-0x0000000180EF6620
		public static float AngleOf(Vector2 v) => default; // 0x0000000180EF4810-0x0000000180EF48E0
		public static float YawOf(Vector3 v) => default; // 0x0000000180EF6820-0x0000000180EF6A50
		public static void Swap<T>(ref T lhs, ref T rhs) {}
		public static void Shuffle<T>(T[] array) {}
		public static void Shuffle<T>(List<T> list) {}
		public static int RandomWithLookback(int min, int max, List<int> history, int historyCount) => default; // 0x0000000180EF5D70-0x0000000180EF5E50
		public static Transform FindChild(Transform parent, string name) => default; // 0x0000000180EF53B0-0x0000000180EF5630
		public static bool IsNullOrEmpty<T>(T[] array) => default;
		public static bool IsValidIndex<T>(T[] array, int i) => default;
		public static bool IsValidIndex<T>(List<T> list, int i) => default;
		public static int FindOrAdd<T>(List<T> list, T item) => default;
		public static List<T> FindAndRemove<T>(List<T> list, Predicate<T> match) => default;
		public static T FindOrAddComponent<T>(GameObject gameObject)
			where T : Component => default;
		public static void FastRemove<T>(List<T> list, int index) {}
		public static void ReplaceGameObject<T, U>(T replace, U replaceWith)
			where T : MonoBehaviour
			where U : MonoBehaviour {}
		public static void SwitchLayerRecursively(Transform transform, int fromLayer, int toLayer) {} // 0x0000000180EF6350-0x0000000180EF6420
		public static void DrawCross(Vector3 origin, Color crossColor, float size) {} // 0x0000000180EF5000-0x0000000180EF53B0
		public static void ResetTransform(Transform t, bool resetScale = true /* Metadata: 0x00655881 */) {} // 0x0000000180EF5F50-0x0000000180EF6080
		public static Vector3 ClosestPointOnLine(Vector3 vA, Vector3 vB, Vector3 vPoint) => default; // 0x0000000180EF4CA0-0x0000000180EF4EE0
		public static void AfterTimer(GameObject go, float _time, Action callback, bool trigger_if_destroyed_early = false /* Metadata: 0x00655882 */) {} // 0x0000000180EF4780-0x0000000180EF4810
		public static void SendPhysicsMessage(Collider collider, string message, SendMessageOptions sendMessageOptions) {} // 0x0000000180EF61C0-0x0000000180EF62D0
		public static void SendPhysicsMessage(Collider collider, string message, object arg, SendMessageOptions sendMessageOptions) {} // 0x0000000180EF6080-0x0000000180EF61C0
		public static void IgnoreCollisions(GameObject goA, GameObject goB) {} // 0x0000000180EF5A00-0x0000000180EF5B60
		// [IteratorStateMachine] // 0x0000000180145290-0x00000001801452E0
		public static IEnumerator WrapCoroutine(IEnumerator coroutine, Action onCoroutineFinished) => default; // 0x0000000180EF6790-0x0000000180EF6820
		public static void Quit() {} // 0x0000000180EF5D40-0x0000000180EF5D70
		public static decimal FloatToDecimal(float value, int decimalPlaces = 2 /* Metadata: 0x00655883 */) => default; // 0x0000000180EF56D0-0x0000000180EF5790
		public static string FixupNewlines(string text) => default; // 0x0000000180EF5630-0x0000000180EF56D0
		public static float PathLength(NavMeshPath path) => default; // 0x0000000180EF5B70-0x0000000180EF5D40
		public static bool HasCommandLineArgument(string argumentName) => default; // 0x0000000180EF5970-0x0000000180EF5A00
		public static int GetCommandLineArgValue(string argumentName, int nDefaultValue) => default; // 0x0000000180EF58A0-0x0000000180EF5970
		public static float GetCommandLineArgValue(string argumentName, float flDefaultValue) => default; // 0x0000000180EF5790-0x0000000180EF58A0
		public static void SetActive(GameObject gameObject, bool active) {} // 0x0000000180EF62D0-0x0000000180EF6350
		public static string CombinePaths(params /* 0x00000001800D4E50-0x00000001800D4E60 */ string[] paths) => default; // 0x0000000180EF4F00-0x0000000180EF5000
	
		// Extension methods
		public static Color ColorWithAlpha(this Color color, float alpha) => default; // 0x0000000180EF4EE0-0x0000000180EF4F00
		public static T Median<T>(this IEnumerable<T> source) => default;
		public static void ForEach<T>(this IEnumerable<T> source, Action<T> action) {}
	}
}
