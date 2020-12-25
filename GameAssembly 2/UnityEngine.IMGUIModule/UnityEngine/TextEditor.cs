/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 13: UnityEngine.IMGUIModule.dll - Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3731-3777

namespace UnityEngine
{
	public class TextEditor // TypeDefIndex: 3772
	{
		// Fields
		public TouchScreenKeyboard keyboardOnScreen; // 0x10
		public int controlID; // 0x18
		public GUIStyle style; // 0x20
		public bool multiline; // 0x28
		public bool hasHorizontalCursorPos; // 0x29
		public bool isPasswordField; // 0x2A
		[VisibleToOtherModules] // 0x00000001801030A0-0x0000000180103120
		internal bool m_HasFocus; // 0x2B
		public Vector2 scrollOffset; // 0x2C
		private GUIContent m_Content; // 0x38
		private Rect m_Position; // 0x40
		private int m_CursorIndex; // 0x50
		private int m_SelectIndex; // 0x54
		private bool m_RevealCursor; // 0x58
		public Vector2 graphicalCursorPos; // 0x5C
		public Vector2 graphicalSelectCursorPos; // 0x64
		private bool m_MouseDragSelectsWholeWords; // 0x6C
		private int m_DblClickInitPos; // 0x70
		private DblClickSnapping m_DblClickSnap; // 0x74
		private bool m_bJustSelected; // 0x75
		private int m_iAltCursorPos; // 0x78
		private string oldText; // 0x80
		private int oldPos; // 0x88
		private int oldSelectPos; // 0x8C
		private static Dictionary<Event, TextEditOp> s_Keyactions; // 0x00
	
		// Properties
		public string text { get => default; set {} } // 0x0000000180AAA7F0-0x0000000180AAA810 0x0000000180AAA9C0-0x0000000180AAAA50
		public Rect position { get => default; set {} } // 0x0000000180AAA7D0-0x0000000180AAA7E0 0x0000000180AAA860-0x0000000180AAA970
		internal virtual Rect localPosition { [VisibleToOtherModules] /* 0x00000001801045D0-0x0000000180104650 */ get => default; } // 0x0000000180AAA7D0-0x0000000180AAA7E0 
		public int cursorIndex { get => default; set {} } // 0x0000000180A91690-0x0000000180A916A0 0x0000000180AAA810-0x0000000180AAA860
		public int selectIndex { get => default; set {} } // 0x0000000180AAA7E0-0x0000000180AAA7F0 0x0000000180AAA970-0x0000000180AAA9C0
		public bool hasSelection { get => default; } // 0x0000000180AAA7C0-0x0000000180AAA7D0 
	
		// Nested types
		public enum DblClickSnapping : byte // TypeDefIndex: 3773
		{
			WORDS = 0,
			PARAGRAPHS = 1
		}
	
		private enum CharacterType // TypeDefIndex: 3774
		{
			LetterLike = 0,
			Symbol = 1,
			Symbol2 = 2,
			WhiteSpace = 3
		}
	
		private enum Direction // TypeDefIndex: 3775
		{
			Forward = 0,
			Backward = 1
		}
	
		private enum TextEditOp // TypeDefIndex: 3776
		{
			MoveLeft = 0,
			MoveRight = 1,
			MoveUp = 2,
			MoveDown = 3,
			MoveLineStart = 4,
			MoveLineEnd = 5,
			MoveTextStart = 6,
			MoveTextEnd = 7,
			MovePageUp = 8,
			MovePageDown = 9,
			MoveGraphicalLineStart = 10,
			MoveGraphicalLineEnd = 11,
			MoveWordLeft = 12,
			MoveWordRight = 13,
			MoveParagraphForward = 14,
			MoveParagraphBackward = 15,
			MoveToStartOfNextWord = 16,
			MoveToEndOfPreviousWord = 17,
			SelectLeft = 18,
			SelectRight = 19,
			SelectUp = 20,
			SelectDown = 21,
			SelectTextStart = 22,
			SelectTextEnd = 23,
			SelectPageUp = 24,
			SelectPageDown = 25,
			ExpandSelectGraphicalLineStart = 26,
			ExpandSelectGraphicalLineEnd = 27,
			SelectGraphicalLineStart = 28,
			SelectGraphicalLineEnd = 29,
			SelectWordLeft = 30,
			SelectWordRight = 31,
			SelectToEndOfPreviousWord = 32,
			SelectToStartOfNextWord = 33,
			SelectParagraphBackward = 34,
			SelectParagraphForward = 35,
			Delete = 36,
			Backspace = 37,
			DeleteWordBack = 38,
			DeleteWordForward = 39,
			DeleteLineBack = 40,
			Cut = 41,
			Copy = 42,
			Paste = 43,
			SelectAll = 44,
			SelectNone = 45,
			ScrollStart = 46,
			ScrollEnd = 47,
			ScrollPageUp = 48,
			ScrollPageDown = 49
		}
	
		// Constructors
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		public TextEditor() {} // 0x0000000180AAA6A0-0x0000000180AAA7C0
	
		// Methods
		private void ClearCursorPos() {} // 0x0000000180AA3CB0-0x0000000180AA3CC0
		public void OnFocus() {} // 0x0000000180AA7670-0x0000000180AA7720
		public void OnLostFocus() {} // 0x0000000180AA7720-0x0000000180AA7790
		private void GrabGraphicalCursorPos() {} // 0x0000000180AA5420-0x0000000180AA5520
		public bool HandleKeyEvent(Event e) => default; // 0x0000000180AA5520-0x0000000180AA5620
		[VisibleToOtherModules] // 0x00000001800D4E50-0x00000001800D4E60
		internal bool HandleKeyEvent(Event e, bool textIsReadOnly) => default; // 0x0000000180AA5620-0x0000000180AA5730
		public bool DeleteLineBack() => default; // 0x0000000180AA3DA0-0x0000000180AA3EA0
		public bool DeleteWordBack() => default; // 0x0000000180AA40D0-0x0000000180AA41F0
		public bool DeleteWordForward() => default; // 0x0000000180AA41F0-0x0000000180AA42C0
		public bool Delete() => default; // 0x0000000180AA42C0-0x0000000180AA4380
		public bool Backspace() => default; // 0x0000000180AA39D0-0x0000000180AA3AF0
		public void SelectAll() {} // 0x0000000180AA8A00-0x0000000180AA8AB0
		public void SelectNone() {} // 0x0000000180AA92E0-0x0000000180AA9340
		public bool DeleteSelection() => default; // 0x0000000180AA3EA0-0x0000000180AA40D0
		public void ReplaceSelection(string replace) {} // 0x0000000180AA88B0-0x0000000180AA89B0
		public void Insert(char c) {} // 0x0000000180AA5DB0-0x0000000180AA5DE0
		public void MoveRight() {} // 0x0000000180AA6BC0-0x0000000180AA6CE0
		public void MoveLeft() {} // 0x0000000180AA65C0-0x0000000180AA66D0
		public void MoveUp() {} // 0x0000000180AA6FD0-0x0000000180AA7150
		public void MoveDown() {} // 0x0000000180AA62A0-0x0000000180AA6460
		public void MoveLineStart() {} // 0x0000000180AA6800-0x0000000180AA6910
		public void MoveLineEnd() {} // 0x0000000180AA66D0-0x0000000180AA6800
		public void MoveGraphicalLineStart() {} // 0x0000000180AA6510-0x0000000180AA65C0
		public void MoveGraphicalLineEnd() {} // 0x0000000180AA6460-0x0000000180AA6510
		public void MoveTextStart() {} // 0x0000000180AA6DA0-0x0000000180AA6E30
		public void MoveTextEnd() {} // 0x0000000180AA6CE0-0x0000000180AA6DA0
		private int IndexOfEndOfLine(int startIndex) => default; // 0x0000000180AA5730-0x0000000180AA57A0
		public void MoveParagraphForward() {} // 0x0000000180AA6A60-0x0000000180AA6BC0
		public void MoveParagraphBackward() {} // 0x0000000180AA6910-0x0000000180AA6A60
		public void MoveCursorToPosition(Vector2 cursorPosition) {} // 0x0000000180AA6100-0x0000000180AA62A0
		protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) {} // 0x0000000180AA5F70-0x0000000180AA6100
		public void SelectToPosition(Vector2 cursorPosition) {} // 0x0000000180AA9820-0x0000000180AA9DF0
		public void SelectLeft() {} // 0x0000000180AA9200-0x0000000180AA92E0
		public void SelectRight() {} // 0x0000000180AA95F0-0x0000000180AA96D0
		public void SelectUp() {} // 0x0000000180AA9E60-0x0000000180AA9F30
		public void SelectDown() {} // 0x0000000180AA9020-0x0000000180AA9120
		public void SelectTextEnd() {} // 0x0000000180AA96D0-0x0000000180AA9750
		public void SelectTextStart() {} // 0x0000000180AA9750-0x0000000180AA97B0
		public void MouseDragSelectsWholeWords(bool on) {} // 0x0000000180AA5F60-0x0000000180AA5F70
		public void DblClickSnap(DblClickSnapping snapping) {} // 0x00000001807FBBA0-0x00000001807FBBB0
		private int GetGraphicalLineStart(int p) => default; // 0x0000000180AA52C0-0x0000000180AA5420
		private int GetGraphicalLineEnd(int p) => default; // 0x0000000180AA5190-0x0000000180AA52C0
		private int FindNextSeperator(int startPos) => default; // 0x0000000180AA4E80-0x0000000180AA4F20
		private int FindPrevSeperator(int startPos) => default; // 0x0000000180AA4F20-0x0000000180AA4FC0
		public void MoveWordRight() {} // 0x0000000180AA72A0-0x0000000180AA7400
		public void MoveToStartOfNextWord() {} // 0x0000000180AA6F00-0x0000000180AA6FD0
		public void MoveToEndOfPreviousWord() {} // 0x0000000180AA6E30-0x0000000180AA6F00
		public void SelectToStartOfNextWord() {} // 0x0000000180AA9DF0-0x0000000180AA9E60
		public void SelectToEndOfPreviousWord() {} // 0x0000000180AA97B0-0x0000000180AA9820
		private CharacterType ClassifyChar(int index) => default; // 0x0000000180AA3B80-0x0000000180AA3CB0
		public int FindStartOfNextWord(int p) => default; // 0x0000000180AA4FC0-0x0000000180AA5190
		private int FindEndOfPreviousWord(int p) => default; // 0x0000000180AA4DB0-0x0000000180AA4E80
		public void MoveWordLeft() {} // 0x0000000180AA7150-0x0000000180AA72A0
		public void SelectWordRight() {} // 0x0000000180AAA080-0x0000000180AAA1D0
		public void SelectWordLeft() {} // 0x0000000180AA9F30-0x0000000180AAA080
		public void ExpandSelectGraphicalLineStart() {} // 0x0000000180AA4B60-0x0000000180AA4C50
		public void ExpandSelectGraphicalLineEnd() {} // 0x0000000180AA4A70-0x0000000180AA4B60
		public void SelectGraphicalLineStart() {} // 0x0000000180AA9190-0x0000000180AA9200
		public void SelectGraphicalLineEnd() {} // 0x0000000180AA9120-0x0000000180AA9190
		public void SelectParagraphForward() {} // 0x0000000180AA94B0-0x0000000180AA95F0
		public void SelectParagraphBackward() {} // 0x0000000180AA9340-0x0000000180AA94B0
		public void SelectCurrentWord() {} // 0x0000000180AA8C00-0x0000000180AA9020
		private int FindEndOfClassification(int p, Direction dir) => default; // 0x0000000180AA4C50-0x0000000180AA4DB0
		public void SelectCurrentParagraph() {} // 0x0000000180AA8AB0-0x0000000180AA8C00
		public void UpdateScrollOffsetIfNeeded(Event evt) {} // 0x0000000180AAA1D0-0x0000000180AAA220
		[VisibleToOtherModules] // 0x00000001800D4E50-0x00000001800D4E60
		internal void UpdateScrollOffset() {} // 0x0000000180AAA220-0x0000000180AAA6A0
		public void DrawCursor(string newText) {} // 0x0000000180AA4380-0x0000000180AA48F0
		private bool PerformOperation(TextEditOp operation, bool textIsReadOnly) => default; // 0x0000000180AA78A0-0x0000000180AA8780
		public void SaveBackup() {} // 0x0000000180AA89B0-0x0000000180AA8A00
		public bool Cut() => default; // 0x0000000180AA3D70-0x0000000180AA3DA0
		public void Copy() {} // 0x0000000180AA3CC0-0x0000000180AA3D70
		private static string ReplaceNewlinesWithSpaces(string value) => default; // 0x0000000180AA8830-0x0000000180AA88B0
		public bool Paste() => default; // 0x0000000180AA7790-0x0000000180AA78A0
		private static void MapKey(string key, TextEditOp action) {} // 0x0000000180AA5EE0-0x0000000180AA5F60
		private void InitKeyActions() {} // 0x0000000180AA57A0-0x0000000180AA5DB0
		public void DetectFocusChange() {} // 0x00000001803E89A0-0x00000001803E89C0
		internal virtual void OnDetectFocusChange() {} // 0x0000000180AA7500-0x0000000180AA7670
		internal virtual void OnCursorIndexChange() {} // 0x0000000180246DB0-0x0000000180246DC0
		internal virtual void OnSelectIndexChange() {} // 0x0000000180246DB0-0x0000000180246DC0
		private void ClampTextIndex(ref int index) {} // 0x0000000180AA3AF0-0x0000000180AA3B80
		private void EnsureValidCodePointIndex(ref int index) {} // 0x0000000180AA48F0-0x0000000180AA4A70
		private bool IsValidCodePointIndex(int index) => default; // 0x0000000180AA5DE0-0x0000000180AA5EE0
		private int PreviousCodePointIndex(int index) => default; // 0x0000000180AA8780-0x0000000180AA8830
		private int NextCodePointIndex(int index) => default; // 0x0000000180AA7400-0x0000000180AA7500
	}
}
