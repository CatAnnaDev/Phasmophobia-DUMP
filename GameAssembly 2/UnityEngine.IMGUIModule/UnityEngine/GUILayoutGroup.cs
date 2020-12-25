/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 13: UnityEngine.IMGUIModule.dll - Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3731-3777

namespace UnityEngine
{
	[VisibleToOtherModules] // 0x00000001801027D0-0x0000000180102850
	internal class GUILayoutGroup : GUILayoutEntry // TypeDefIndex: 3766
	{
		// Fields
		public List<GUILayoutEntry> entries; // 0x48
		public bool isVertical; // 0x50
		public bool resetCoords; // 0x51
		public float spacing; // 0x54
		public bool sameSize; // 0x58
		public bool isWindow; // 0x59
		public int windowID; // 0x5C
		private int m_Cursor; // 0x60
		protected int m_StretchableCountX; // 0x64
		protected int m_StretchableCountY; // 0x68
		protected bool m_UserSpecifiedWidth; // 0x6C
		protected bool m_UserSpecifiedHeight; // 0x6D
		protected float m_ChildMinWidth; // 0x70
		protected float m_ChildMaxWidth; // 0x74
		protected float m_ChildMinHeight; // 0x78
		protected float m_ChildMaxHeight; // 0x7C
		protected int m_MarginLeft; // 0x80
		protected int m_MarginRight; // 0x84
		protected int m_MarginTop; // 0x88
		protected int m_MarginBottom; // 0x8C
	
		// Properties
		public override int marginLeft { get => default; } // 0x00000001804FA0E0-0x00000001804FA0F0 
		public override int marginRight { get => default; } // 0x0000000180A1FAC0-0x0000000180A1FAD0 
		public override int marginTop { get => default; } // 0x00000001802800E0-0x00000001802800F0 
		public override int marginBottom { get => default; } // 0x00000001806F9A90-0x00000001806F9AA0 
	
		// Constructors
		public GUILayoutGroup() {} // 0x0000000180A1F8D0-0x0000000180A1FAC0
	
		// Methods
		public override void ApplyOptions(GUILayoutOption[] options) {} // 0x0000000180A1CB00-0x0000000180A1CC20
		protected override void ApplyStyleSettings(GUIStyle style) {} // 0x0000000180A1CC20-0x0000000180A1CD90
		public void ResetCursor() {} // 0x0000000180A1E120-0x0000000180A1E130
		public GUILayoutEntry GetNext() => default; // 0x0000000180A1DE50-0x0000000180A1E120
		public void Add(GUILayoutEntry e) {} // 0x0000000180A1CAA0-0x0000000180A1CB00
		public override void CalcWidth() {} // 0x0000000180A1D5C0-0x0000000180A1DE50
		public override void SetHorizontal(float x, float width) {} // 0x0000000180A1E130-0x0000000180A1EAA0
		public override void CalcHeight() {} // 0x0000000180A1CD90-0x0000000180A1D5C0
		public override void SetVertical(float y, float height) {} // 0x0000000180A1EAA0-0x0000000180A1F430
		public override string ToString() => default; // 0x0000000180A1F430-0x0000000180A1F8D0
	}
}
