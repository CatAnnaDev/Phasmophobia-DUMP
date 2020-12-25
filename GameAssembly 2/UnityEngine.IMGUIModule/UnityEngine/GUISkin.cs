/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting;

// Image 13: UnityEngine.IMGUIModule.dll - Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3731-3777

namespace UnityEngine
{
	[Serializable]
	// [AssetFileNameExtension] // 0x00000001800F86E0-0x00000001800F8770
	[ExecuteInEditMode] // 0x00000001800F86E0-0x00000001800F8770
	[RequiredByNativeCode] // 0x00000001800F86E0-0x00000001800F8770
	public sealed class GUISkin : ScriptableObject // TypeDefIndex: 3755
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Font m_Font; // 0x18
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_box; // 0x20
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_button; // 0x28
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_toggle; // 0x30
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_label; // 0x38
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_textField; // 0x40
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_textArea; // 0x48
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_window; // 0x50
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_horizontalSlider; // 0x58
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_horizontalSliderThumb; // 0x60
		[NonSerialized]
		private GUIStyle m_horizontalSliderThumbExtent; // 0x68
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_verticalSlider; // 0x70
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_verticalSliderThumb; // 0x78
		[NonSerialized]
		private GUIStyle m_verticalSliderThumbExtent; // 0x80
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_horizontalScrollbar; // 0x88
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_horizontalScrollbarThumb; // 0x90
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_horizontalScrollbarLeftButton; // 0x98
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_horizontalScrollbarRightButton; // 0xA0
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_verticalScrollbar; // 0xA8
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_verticalScrollbarThumb; // 0xB0
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_verticalScrollbarUpButton; // 0xB8
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_verticalScrollbarDownButton; // 0xC0
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUIStyle m_ScrollView; // 0xC8
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		internal GUIStyle[] m_CustomStyles; // 0xD0
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GUISettings m_Settings; // 0xD8
		internal static GUIStyle ms_Error; // 0x00
		private Dictionary<string, GUIStyle> m_Styles; // 0xE0
		internal static SkinChangedDelegate m_SkinChanged; // 0x08
		internal static GUISkin current; // 0x10
	
		// Properties
		public Font font { get => default; set {} } // 0x00000001809302F0-0x0000000180930300 0x0000000180A284C0-0x0000000180A28600
		public GUIStyle box { get => default; set {} } // 0x0000000180930300-0x0000000180930310 0x0000000180A28330-0x0000000180A283B0
		public GUIStyle label { get => default; set {} } // 0x0000000180A28280-0x0000000180A28290 0x0000000180A28980-0x0000000180A28A00
		public GUIStyle textField { get => default; set {} } // 0x0000000180A1CA50-0x0000000180A1CA60 0x0000000180A28B00-0x0000000180A28B80
		public GUIStyle textArea { get => default; set {} } // 0x00000001802D5A00-0x00000001802D5A10 0x0000000180A28A80-0x0000000180A28B00
		public GUIStyle button { get => default; set {} } // 0x000000018095D2D0-0x000000018095D2E0 0x0000000180A283B0-0x0000000180A28430
		public GUIStyle toggle { get => default; set {} } // 0x00000001802DEAD0-0x00000001802DEAE0 0x0000000180A28B80-0x0000000180A28C00
		public GUIStyle window { get => default; set {} } // 0x0000000180A28320-0x0000000180A28330 0x0000000180A28F80-0x0000000180A29000
		public GUIStyle horizontalSlider { get => default; set {} } // 0x0000000180A28270-0x0000000180A28280 0x0000000180A28900-0x0000000180A28980
		public GUIStyle horizontalSliderThumb { get => default; set {} } // 0x00000001802D5810-0x00000001802D5820 0x0000000180A28880-0x0000000180A28900
		internal GUIStyle horizontalSliderThumbExtent { get => default; set {} } // 0x0000000180A28260-0x0000000180A28270 0x0000000180A28800-0x0000000180A28880
		public GUIStyle verticalSlider { get => default; set {} } // 0x0000000180A28310-0x0000000180A28320 0x0000000180A28F00-0x0000000180A28F80
		public GUIStyle verticalSliderThumb { get => default; set {} } // 0x0000000180A28300-0x0000000180A28310 0x0000000180A28E80-0x0000000180A28F00
		internal GUIStyle verticalSliderThumbExtent { get => default; set {} } // 0x0000000180A282F0-0x0000000180A28300 0x0000000180A28E00-0x0000000180A28E80
		public GUIStyle horizontalScrollbar { get => default; set {} } // 0x0000000180A28250-0x0000000180A28260 0x0000000180A28780-0x0000000180A28800
		public GUIStyle horizontalScrollbarThumb { get => default; set {} } // 0x0000000180A28240-0x0000000180A28250 0x0000000180A28700-0x0000000180A28780
		public GUIStyle horizontalScrollbarLeftButton { get => default; set {} } // 0x00000001806C0F30-0x00000001806C0F40 0x0000000180A28600-0x0000000180A28680
		public GUIStyle horizontalScrollbarRightButton { get => default; set {} } // 0x00000001806C0F20-0x00000001806C0F30 0x0000000180A28680-0x0000000180A28700
		public GUIStyle verticalScrollbar { get => default; set {} } // 0x0000000180A282E0-0x0000000180A282F0 0x0000000180A28D80-0x0000000180A28E00
		public GUIStyle verticalScrollbarThumb { get => default; set {} } // 0x0000000180A282C0-0x0000000180A282D0 0x0000000180A28C80-0x0000000180A28D00
		public GUIStyle verticalScrollbarUpButton { get => default; set {} } // 0x0000000180A282D0-0x0000000180A282E0 0x0000000180A28D00-0x0000000180A28D80
		public GUIStyle verticalScrollbarDownButton { get => default; set {} } // 0x0000000180A282B0-0x0000000180A282C0 0x0000000180A28C00-0x0000000180A28C80
		public GUIStyle scrollView { get => default; set {} } // 0x0000000180A28290-0x0000000180A282A0 0x0000000180A28A00-0x0000000180A28A80
		public GUIStyle[] customStyles { get => default; set {} } // 0x0000000180A28140-0x0000000180A28150 0x0000000180A28430-0x0000000180A284C0
		public GUISettings settings { get => default; } // 0x0000000180A282A0-0x0000000180A282B0 
		internal static GUIStyle error { get => default; } // 0x0000000180A28150-0x0000000180A28240 
	
		// Nested types
		internal delegate void SkinChangedDelegate(); // TypeDefIndex: 3756; 0x0000000180533490-0x0000000180533710
	
		// Constructors
		public GUISkin() {} // 0x0000000180A28040-0x0000000180A28140
	
		// Methods
		internal void OnEnable() {} // 0x0000000180A267F0-0x0000000180A26860
		internal static void CleanupRoots() {} // 0x0000000180A27A20-0x0000000180A27A80
		internal void Apply() {} // 0x0000000180A267F0-0x0000000180A26860
		private void BuildStyleCache() {} // 0x0000000180A26860-0x0000000180A27A20
		public GUIStyle GetStyle(string styleName) => default; // 0x0000000180A27BC0-0x0000000180A27F90
		public GUIStyle FindStyle(string styleName) => default; // 0x0000000180A27A80-0x0000000180A27B20
		internal void MakeCurrent() {} // 0x0000000180A27F90-0x0000000180A28040
		public IEnumerator GetEnumerator() => default; // 0x0000000180A27B20-0x0000000180A27BC0
	}
}
