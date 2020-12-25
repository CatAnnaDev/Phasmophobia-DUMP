/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Internal;
using UnityEngine.Scripting;

// Image 22: UnityEngine.AnimationModule.dll - Assembly: UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3891-3932

namespace UnityEngine
{
	public sealed class Animation : Behaviour, IEnumerable // TypeDefIndex: 3917
	{
		// Properties
		public AnimationClip clip { [GeneratedByOldBindingsGenerator] /* 0x00000001800D4E50-0x00000001800D4E60 */ get => default; [GeneratedByOldBindingsGenerator] /* 0x00000001800D4E50-0x00000001800D4E60 */ set {} } // 0x0000000180AD9120-0x0000000180AD9160 0x0000000180AD9160-0x0000000180AD91B0
		public bool playAutomatically { [GeneratedByOldBindingsGenerator] /* 0x00000001800D4E50-0x00000001800D4E60 */ set {} } // 0x0000000180AD91B0-0x0000000180AD9200
		public AnimationState this[string name] { get => default; } // 0x0000000180AD8F20-0x0000000180AD8F70 
		public bool animatePhysics { [GeneratedByOldBindingsGenerator] /* 0x00000001800D4E50-0x00000001800D4E60 */ get => default; } // 0x0000000180AD90E0-0x0000000180AD9120 
	
		// Nested types
		private sealed class Enumerator : IEnumerator // TypeDefIndex: 3918
		{
			// Fields
			private Animation m_Outer; // 0x10
			private int m_CurrentIndex; // 0x18
	
			// Properties
			public object Current { get => default; } // 0x0000000180ADADA0-0x0000000180ADADF0 
	
			// Constructors
			public Enumerator() {} // Dummy constructor
			internal Enumerator(Animation outer) {} // 0x0000000180245720-0x0000000180245760
	
			// Methods
			public bool MoveNext() => default; // 0x0000000180ADAD40-0x0000000180ADADA0
			public void Reset() {} // 0x0000000180245710-0x0000000180245720
		}
	
		// Constructors
		public Animation() {} // Dummy constructor
	
		// Methods
		public void Stop() {} // 0x0000000180AD8F70-0x0000000180AD8FB0
		[GeneratedByOldBindingsGenerator] // 0x00000001800D4E50-0x00000001800D4E60
		private static void INTERNAL_CALL_Stop(Animation self) {} // 0x0000000180AD8F70-0x0000000180AD8FB0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public bool Play() => default; // 0x0000000180AD90A0-0x0000000180AD90E0
		public bool Play([DefaultValue] /* 0x00000001800D5730-0x00000001800D5760 */ PlayMode mode) => default; // 0x0000000180AD8FB0-0x0000000180AD8FF0
		[GeneratedByOldBindingsGenerator] // 0x00000001800D4E50-0x00000001800D4E60
		public bool Play(string animation, [DefaultValue] /* 0x00000001800D5730-0x00000001800D5760 */ PlayMode mode) => default; // 0x0000000180AD9040-0x0000000180AD90A0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public bool Play(string animation) => default; // 0x0000000180AD8FF0-0x0000000180AD9040
		[GeneratedByOldBindingsGenerator] // 0x00000001800D4E50-0x00000001800D4E60
		public void CrossFade(string animation, [DefaultValue] /* 0x00000001800D5DD0-0x00000001800D5E00 */ float fadeLength, [DefaultValue] /* 0x00000001800D5730-0x00000001800D5760 */ PlayMode mode) {} // 0x0000000180AD8D30-0x0000000180AD8DA0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void CrossFade(string animation, float fadeLength) {} // 0x0000000180AD8CD0-0x0000000180AD8D30
		[GeneratedByOldBindingsGenerator] // 0x00000001800D4E50-0x00000001800D4E60
		private bool PlayDefaultAnimation(PlayMode mode) => default; // 0x0000000180AD8FB0-0x0000000180AD8FF0
		public IEnumerator GetEnumerator() => default; // 0x0000000180AD8E30-0x0000000180AD8EA0
		[GeneratedByOldBindingsGenerator] // 0x00000001800D4E50-0x00000001800D4E60
		internal AnimationState GetState(string name) => default; // 0x0000000180AD8F20-0x0000000180AD8F70
		[GeneratedByOldBindingsGenerator] // 0x00000001800D4E50-0x00000001800D4E60
		internal AnimationState GetStateAtIndex(int index) => default; // 0x0000000180AD8EA0-0x0000000180AD8EE0
		[GeneratedByOldBindingsGenerator] // 0x00000001800D4E50-0x00000001800D4E60
		internal int GetStateCount() => default; // 0x0000000180AD8EE0-0x0000000180AD8F20
		public AnimationClip GetClip(string name) => default; // 0x0000000180AD8DA0-0x0000000180AD8E30
	}
}
