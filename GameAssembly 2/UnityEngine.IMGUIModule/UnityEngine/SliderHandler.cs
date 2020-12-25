/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 13: UnityEngine.IMGUIModule.dll - Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3731-3777

namespace UnityEngine
{
	internal struct SliderHandler // TypeDefIndex: 3771
	{
		// Fields
		private readonly Rect position; // 0x00
		private readonly float currentValue; // 0x10
		private readonly float size; // 0x14
		private readonly float start; // 0x18
		private readonly float end; // 0x1C
		private readonly GUIStyle slider; // 0x20
		private readonly GUIStyle thumb; // 0x28
		private readonly GUIStyle thumbExtent; // 0x30
		private readonly bool horiz; // 0x38
		private readonly int id; // 0x3C
	
		// Constructors
		public SliderHandler(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null) {
			this.position = default;
			this.currentValue = default;
			this.size = default;
			this.start = default;
			this.end = default;
			this.slider = default;
			this.thumb = default;
			this.thumbExtent = default;
			this.horiz = default;
			this.id = default;
		} // 0x0000000180048C60-0x0000000180048E20
	
		// Methods
		public float Handle() => default; // 0x0000000180048920-0x00000001800489C0
		private float OnMouseDown() => default; // 0x0000000180048A40-0x0000000180048A50
		private float OnMouseDrag() => default; // 0x0000000180048A50-0x0000000180048A60
		private float OnMouseUp() => default; // 0x0000000180048A60-0x0000000180048A70
		private float OnRepaint() => default; // 0x0000000180048A70-0x0000000180048A80
		private EventType CurrentEventType() => default; // 0x00000001800488D0-0x0000000180048900
		private int CurrentScrollTroughSide() => default; // 0x0000000180048910-0x0000000180048920
		private bool IsEmptySlider() => default; // 0x00000001800489F0-0x0000000180048A10
		private bool SupportsPageMovements() => default; // 0x0000000180048B10-0x0000000180048B80
		private float PageMovementValue() => default; // 0x0000000180048A80-0x0000000180048A90
		private float PageUpMovementBound() => default; // 0x0000000180048A90-0x0000000180048AA0
		private Event CurrentEvent() => default; // 0x0000000180048900-0x0000000180048910
		private float ValueForCurrentMousePosition() => default; // 0x0000000180048C10-0x0000000180048C20
		private float Clamp(float value) => default; // 0x00000001800488A0-0x00000001800488B0
		private Rect ThumbSelectionRect() => default; // 0x0000000180048BB0-0x0000000180048C00
		private void StartDraggingWithValue(float dragStartValue) {} // 0x0000000180048AB0-0x0000000180048B10
		private SliderState SliderState() => default; // 0x0000000180048AA0-0x0000000180048AB0
		private Rect ThumbExtRect() => default; // 0x0000000180048B80-0x0000000180048BB0
		private Rect ThumbRect() => default; // 0x0000000180048BB0-0x0000000180048C00
		private Rect VerticalThumbRect() => default; // 0x0000000180048C30-0x0000000180048C60
		private Rect HorizontalThumbRect() => default; // 0x00000001800489C0-0x00000001800489F0
		private float ClampedCurrentValue() => default; // 0x00000001800488B0-0x00000001800488D0
		private float MousePosition() => default; // 0x0000000180048A30-0x0000000180048A40
		private float ValuesPerPixel() => default; // 0x0000000180048C20-0x0000000180048C30
		private float ThumbSize() => default; // 0x0000000180048C00-0x0000000180048C10
		private float MaxValue() => default; // 0x0000000180048A10-0x0000000180048A20
		private float MinValue() => default; // 0x0000000180048A20-0x0000000180048A30
	}
}
