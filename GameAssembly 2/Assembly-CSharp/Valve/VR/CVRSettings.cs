/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public class CVRSettings // TypeDefIndex: 8221
	{
		// Fields
		private IVRSettings FnTable; // 0x10
	
		// Constructors
		public CVRSettings() {} // Dummy constructor
		internal CVRSettings(IntPtr pInterface) {} // 0x00000001811DFD90-0x00000001811DFEA0
	
		// Methods
		public string GetSettingsErrorNameFromEnum(EVRSettingsError eError) => default; // 0x00000001811DFBB0-0x00000001811DFC30
		public bool Sync(bool bForce, ref EVRSettingsError peError) => default; // 0x00000001811DFD70-0x00000001811DFD90
		public void SetBool(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError) {} // 0x00000001811DFCB0-0x00000001811DFCE0
		public void SetInt32(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError) {} // 0x00000001811DFD10-0x00000001811DFD40
		public void SetFloat(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError) {} // 0x00000001811DFCE0-0x00000001811DFD10
		public void SetString(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError) {} // 0x00000001811DFD40-0x00000001811DFD70
		public bool GetBool(string pchSection, string pchSettingsKey, ref EVRSettingsError peError) => default; // 0x00000001811DFB20-0x00000001811DFB50
		public int GetInt32(string pchSection, string pchSettingsKey, ref EVRSettingsError peError) => default; // 0x00000001811DFB80-0x00000001811DFBB0
		public float GetFloat(string pchSection, string pchSettingsKey, ref EVRSettingsError peError) => default; // 0x00000001811DFB50-0x00000001811DFB80
		public void GetString(string pchSection, string pchSettingsKey, StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError) {} // 0x00000001811DFC30-0x00000001811DFC60
		public void RemoveSection(string pchSection, ref EVRSettingsError peError) {} // 0x00000001811DFC90-0x00000001811DFCB0
		public void RemoveKeyInSection(string pchSection, string pchSettingsKey, ref EVRSettingsError peError) {} // 0x00000001811DFC60-0x00000001811DFC90
	}
}
