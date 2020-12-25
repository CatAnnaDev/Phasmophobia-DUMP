/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace VRTK.Highlighters
{
	public abstract class VRTK_BaseHighlighter : MonoBehaviour // TypeDefIndex: 7828
	{
		// Fields
		public bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A; // 0x18
		public bool u0924u0920u091Du091Bu0927u091Bu0924u091Fu0927u0926u091D; // 0x19
		protected bool u091Fu0927u091Du091Fu091Au091Au091Du091Au091Eu0922u0923; // 0x1A
	
		// Constructors
		protected VRTK_BaseHighlighter() {} // 0x0000000180FB2930-0x0000000180FB2940
	
		// Methods
		public abstract void Initialise(Color? u0920u0924u091Fu0923u0923u091Fu0925u0928u0920u091Eu091E = default, Dictionary<string, object> u091Bu0922u091Bu0928u0923u0925u091Fu091Du0923u0928u0922 = null);
		public abstract void ResetHighlighter();
		public abstract void Highlight(Color? u0920u0924u091Fu0923u0923u091Fu0925u0928u0920u091Eu091E = default, float u0926u0927u091Du0923u0920u091Cu091Fu0921u091Cu0927u091C = 0f /* Metadata: 0x00654084 */);
		public abstract void Unhighlight(Color? u0920u0924u091Fu0923u0923u091Fu0925u0928u0920u091Eu091E = default, float u0926u0927u091Du0923u0920u091Cu091Fu0921u091Cu0927u091C = 0f /* Metadata: 0x00654088 */);
		public virtual T GetOption<T>(Dictionary<string, object> u091Bu0922u091Bu0928u0923u0925u091Fu091Du0923u0928u0922, string u091Bu0921u091Cu091Au0921u091Fu0922u0920u0928u0927u091C) => default;
		public virtual bool UsesClonedObject() => default; // 0x0000000180468080-0x0000000180468090
		public static VRTK_BaseHighlighter GetActiveHighlighter(GameObject u0920u0922u0921u091Du091Du0926u091Bu0920u091Bu0922u0920) => default; // 0x0000000181C4E820-0x0000000181C4E8C0
		protected virtual void OnDisable() {} // 0x0000000181C4E8C0-0x0000000181C4E910
	}
}
