/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

public static class FileBasedPrefs // TypeDefIndex: 5816
{
	// Fields
	private const string SaveFileName = "saveData.txt"; // Metadata: 0x0065066A
	private const bool ScrambleSaveData = true; // Metadata: 0x0065067A
	private const string EncryptionCodeword = "CHANGE ME TO YOUR OWN RANDOM STRING"; // Metadata: 0x0065067B
	private const bool AutoSaveData = true; // Metadata: 0x006506A2
	private static FileBasedPrefsSaveFileModel _latestData; // 0x00
	private const string String_Empty = ""; // Metadata: 0x006506A3
	private static bool isQuitting; // 0x08

	// Methods
	private static void Quit() {} // 0x000000018032BB50-0x000000018032BB90
	[RuntimeInitializeOnLoadMethod] // 0x00000001800DFB10-0x00000001800DFB20
	private static void RunOnStart() {} // 0x000000018032BB90-0x000000018032BBF0
	public static void SetString(string key, string value = "" /* Metadata: 0x0065064F */) {} // 0x000000018032BDA0-0x000000018032BE00
	public static string GetString(string key, string defaultValue = "" /* Metadata: 0x00650653 */) => default; // 0x000000018032B760-0x000000018032B850
	public static void SetInt(string key, int value = 0 /* Metadata: 0x00650657 */) {} // 0x000000018032BD30-0x000000018032BDA0
	public static int GetInt(string key, int defaultValue = 0 /* Metadata: 0x0065065B */) => default; // 0x000000018032B400-0x000000018032B500
	public static void SetFloat(string key, float value = 0f /* Metadata: 0x0065065F */) {} // 0x000000018032BCC0-0x000000018032BD30
	public static float GetFloat(string key, float defaultValue = 0f /* Metadata: 0x00650663 */) => default; // 0x000000018032B2F0-0x000000018032B400
	public static void SetBool(string key, bool value = false /* Metadata: 0x00650667 */) {} // 0x000000018032BC50-0x000000018032BCC0
	public static bool GetBool(string key, bool defaultValue = false /* Metadata: 0x00650668 */) => default; // 0x000000018032B170-0x000000018032B270
	public static bool HasKey(string key) => default; // 0x000000018032BA20-0x000000018032BA50
	public static bool HasKeyForString(string key) => default; // 0x000000018032B9C0-0x000000018032BA20
	public static bool HasKeyForInt(string key) => default; // 0x000000018032B940-0x000000018032B9C0
	public static bool HasKeyForFloat(string key) => default; // 0x000000018032B8C0-0x000000018032B940
	public static bool HasKeyForBool(string key) => default; // 0x000000018032B850-0x000000018032B8C0
	public static void DeleteKey(string key) {} // 0x000000018032AE90-0x000000018032AF10
	public static void DeleteString(string key) {} // 0x000000018032AF10-0x000000018032B090
	public static void DeleteInt(string key) {} // 0x000000018032AD10-0x000000018032AE90
	public static void DeleteFloat(string key) {} // 0x000000018032AB90-0x000000018032AD10
	public static void DeleteBool(string key) {} // 0x000000018032AA10-0x000000018032AB90
	public static void DeleteAll() {} // 0x000000018032A960-0x000000018032AA10
	public static void OverwriteLocalSaveFile(string data) {} // 0x000000018032BAE0-0x000000018032BB50
	private static FileBasedPrefsSaveFileModel GetSaveFile() => default; // 0x000000018032B5E0-0x000000018032B760
	public static string GetSaveFilePath() => default; // 0x000000018032B580-0x000000018032B5E0
	public static string GetSaveFileAsJson() => default; // 0x000000018032B500-0x000000018032B580
	private static object GetDataFromSaveFile(string key, object defaultValue) => default; // 0x000000018032B270-0x000000018032B2F0
	private static void AddDataToSaveFile(string key, object value) {} // 0x000000018032A5C0-0x000000018032A6B0
	public static void ManualySave() {} // 0x000000018032BA50-0x000000018032BAE0
	private static void SaveSaveFile(bool manualSave = false /* Metadata: 0x00650669 */) {} // 0x000000018032BBF0-0x000000018032BC50
	private static void WriteToSaveFile(string data) {} // 0x000000018032BE00-0x000000018032BEC0
	private static void CheckSaveFileExists() {} // 0x000000018032A6B0-0x000000018032A820
	private static bool DoesSaveFileExist() => default; // 0x000000018032B090-0x000000018032B170
	private static void CreateNewSaveFile() {} // 0x000000018032A820-0x000000018032A8A0
	private static string DataScrambler(string data) => default; // 0x000000018032A8A0-0x000000018032A960
}

