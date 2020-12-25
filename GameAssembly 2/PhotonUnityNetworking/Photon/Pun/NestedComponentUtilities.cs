/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 51: PhotonUnityNetworking.dll - Assembly: PhotonUnityNetworking, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5293-5359

namespace Photon.Pun
{
	public static class NestedComponentUtilities // TypeDefIndex: 5330
	{
		// Fields
		private static Queue<Transform> nodesQueue; // 0x00
		public static Dictionary<Type, ICollection> searchLists; // 0x08
		private static Stack<Transform> nodeStack; // 0x10
	
		// Constructors
		static NestedComponentUtilities() {} // 0x000000018059CA50-0x000000018059CB30
	
		// Extension methods
		public static T GetParentComponent<T>(this Transform t)
			where T : Component => default;
		public static void GetNestedComponentsInParents<T>(this Transform t, List<T> list)
			where T : Component {}
		public static T GetNestedComponentInChildren<T, NestedT>(this Transform t, bool includeInactive)
			where T : class
			where NestedT : class => default;
		public static T GetNestedComponentInParent<T, NestedT>(this Transform t)
			where T : class
			where NestedT : class => default;
		public static T GetNestedComponentInParents<T, NestedT>(this Transform t)
			where T : class
			where NestedT : class => default;
		public static void GetNestedComponentsInParents<T, NestedT>(this Transform t, List<T> list)
			where T : class
			where NestedT : class {}
		public static List<T> GetNestedComponentsInChildren<T, NestedT>(this Transform t, List<T> list, bool includeInactive = true /* Metadata: 0x0064F75E */)
			where T : class
			where NestedT : class => default;
		public static void GetNestedComponentsInChildren<T, SearchT, NestedT>(this Transform t, bool includeInactive, List<T> list)
			where T : class
			where SearchT : class {}
	}
}
