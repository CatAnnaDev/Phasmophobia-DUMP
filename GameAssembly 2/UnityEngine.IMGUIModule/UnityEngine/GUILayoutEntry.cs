/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 13: UnityEngine.IMGUIModule.dll - Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3731-3777

namespace UnityEngine
{
	[VisibleToOtherModules] // 0x0000000180102540-0x00000001801025C0
	internal class GUILayoutEntry // TypeDefIndex: 3764
	{
		// Fields
		public float minWidth; // 0x10
		public float maxWidth; // 0x14
		public float minHeight; // 0x18
		public float maxHeight; // 0x1C
		public Rect rect; // 0x20
		public int stretchWidth; // 0x30
		public int stretchHeight; // 0x34
		public bool consideredForMargin; // 0x38
		private GUIStyle m_Style; // 0x40
		internal static Rect kDummyRect; // 0x00
		protected static int indent; // 0x10
	
		// Properties
		public GUIStyle style { get => default; set {} } // 0x0000000180A1CA50-0x0000000180A1CA60 0x0000000180A1CA60-0x0000000180A1CAA0
		public virtual int marginLeft { get => default; } // 0x0000000180A1C980-0x0000000180A1C9B0 
		public virtual int marginRight { get => default; } // 0x0000000180A1C9B0-0x0000000180A1C9E0 
		public virtual int marginTop { get => default; } // 0x0000000180A1C9E0-0x0000000180A1CA10 
		public virtual int marginBottom { get => default; } // 0x0000000180A1C910-0x0000000180A1C940 
		public int marginHorizontal { get => default; } // 0x0000000180A1C940-0x0000000180A1C980 
		public int marginVertical { get => default; } // 0x0000000180A1CA10-0x0000000180A1CA50 
	
		// Constructors
		public GUILayoutEntry() {} // Dummy constructor
		public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) {} // 0x0000000180A1C7B0-0x0000000180A1C910
		public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) {} // 0x0000000180A1C660-0x0000000180A1C7B0
		static GUILayoutEntry() {} // 0x0000000180A1C5E0-0x0000000180A1C660
	
		// Methods
		public virtual void CalcWidth() {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void CalcHeight() {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void SetHorizontal(float x, float width) {} // 0x0000000180A1BC60-0x0000000180A1BCA0
		public virtual void SetVertical(float y, float height) {} // 0x0000000180A1BCA0-0x0000000180A1BCE0
		protected virtual void ApplyStyleSettings(GUIStyle style) {} // 0x0000000180A1BB50-0x0000000180A1BC60
		public virtual void ApplyOptions(GUILayoutOption[] options) {} // 0x0000000180A1B7B0-0x0000000180A1BB50
		public override string ToString() => default; // 0x0000000180A1BCE0-0x0000000180A1C5E0
	}
}
