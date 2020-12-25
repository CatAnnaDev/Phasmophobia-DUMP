/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

// Image 18: UnityEngine.UnityWebRequestModule.dll - Assembly: UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3817-3829

namespace UnityEngine
{
	public class WWWForm // TypeDefIndex: 3819
	{
		// Fields
		private List<byte[]> formData; // 0x10
		private List<string> fieldNames; // 0x18
		private List<string> fileNames; // 0x20
		private List<string> types; // 0x28
		private byte[] boundary; // 0x30
		private bool containsFiles; // 0x38
	
		// Properties
		internal static Encoding DefaultEncoding { get => default; } // 0x0000000180AD5BA0-0x0000000180AD5BB0 
		public Dictionary<string, string> headers { get => default; } // 0x0000000180AD6AD0-0x0000000180AD6BB0 
		public byte[] data { get => default; } // 0x0000000180AD5BB0-0x0000000180AD6AD0 
	
		// Constructors
		public WWWForm() {} // 0x0000000180AD5A30-0x0000000180AD5BA0
	
		// Methods
		public void AddField(string fieldName, string value) {} // 0x0000000180AD57E0-0x0000000180AD5900
		public void AddField(string fieldName, string value, Encoding e) {} // 0x0000000180AD56D0-0x0000000180AD57E0
		public void AddField(string fieldName, int i) {} // 0x0000000180AD5900-0x0000000180AD5A30
	}
}
