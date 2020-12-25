/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

[Serializable]
public class FileBasedPrefsSaveFileModel // TypeDefIndex: 5817
{
	// Fields
	public StringItem[] StringData; // 0x10
	public IntItem[] IntData; // 0x18
	public FloatItem[] FloatData; // 0x20
	public BoolItem[] BoolData; // 0x28

	// Nested types
	[Serializable]
	public class StringItem // TypeDefIndex: 5818
	{
		// Fields
		public string Key; // 0x10
		public string Value; // 0x18

		// Constructors
		public StringItem() {} // Dummy constructor
		public StringItem(string K, string V) {} // 0x0000000180294750-0x00000001802947A0
	}

	[Serializable]
	public class IntItem // TypeDefIndex: 5819
	{
		// Fields
		public string Key; // 0x10
		public int Value; // 0x18

		// Constructors
		public IntItem() {} // Dummy constructor
		public IntItem(string K, int V) {} // 0x00000001803501B0-0x0000000180350200
	}

	[Serializable]
	public class FloatItem // TypeDefIndex: 5820
	{
		// Fields
		public string Key; // 0x10
		public float Value; // 0x18

		// Constructors
		public FloatItem() {} // Dummy constructor
		public FloatItem(string K, float V) {} // 0x000000018032BEC0-0x000000018032BF10
	}

	[Serializable]
	public class BoolItem // TypeDefIndex: 5821
	{
		// Fields
		public string Key; // 0x10
		public bool Value; // 0x18

		// Constructors
		public BoolItem() {} // Dummy constructor
		public BoolItem(string K, bool V) {} // 0x0000000180328A50-0x0000000180328AA0
	}

	// Constructors
	public FileBasedPrefsSaveFileModel() {} // 0x000000018032A510-0x000000018032A5C0

	// Methods
	public object GetValueFromKey(string key, object defaultValue) => default; // 0x00000001803293C0-0x00000001803297D0
	public void UpdateOrAddData(string key, object value) {} // 0x000000018032A4B0-0x000000018032A510
	private void SetValueForNewKey(string key, object value) {} // 0x000000018032A130-0x000000018032A4B0
	private void SetValueForExistingKey(string key, object value) {} // 0x0000000180329CD0-0x000000018032A130
	public bool HasKeyFromObject(string key, object value) => default; // 0x00000001803297D0-0x0000000180329AA0
	public void DeleteKey(string key) {} // 0x0000000180328EF0-0x0000000180329290
	public void DeleteString(string key) {} // 0x0000000180329290-0x00000001803293C0
	public void DeleteInt(string key) {} // 0x0000000180328DC0-0x0000000180328EF0
	public void DeleteFloat(string key) {} // 0x0000000180328C90-0x0000000180328DC0
	public void DeleteBool(string key) {} // 0x0000000180328B60-0x0000000180328C90
	public bool HasKey(string key) => default; // 0x0000000180329AA0-0x0000000180329CD0
}

