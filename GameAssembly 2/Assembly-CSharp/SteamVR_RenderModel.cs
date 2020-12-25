/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

[ExecuteInEditMode] // 0x00000001800D4E50-0x00000001800D4E60
public class SteamVR_RenderModel : MonoBehaviour // TypeDefIndex: 7294
{
	// Fields
	public SteamVR_TrackedObject.EIndex index; // 0x18
	public const string modelOverrideWarning = "Model override is really only meant to be used in the scene view for lining things up; using it at runtime is discouraged.  Use tracked device index instead to ensure the correct model is displayed for all users."; // Metadata: 0x0065349C
	// [Tooltip] // 0x000000018011DEB0-0x000000018011DEE0
	public string modelOverride; // 0x20
	// [Tooltip] // 0x000000018011E070-0x000000018011E0A0
	public Shader shader; // 0x28
	// [Tooltip] // 0x000000018011E180-0x000000018011E1B0
	public bool verbose; // 0x30
	// [Tooltip] // 0x000000018011E260-0x000000018011E290
	public bool createComponents; // 0x31
	// [Tooltip] // 0x000000018011E390-0x000000018011E3C0
	public bool updateDynamically; // 0x32
	public RenderModel_ControllerMode_State_t controllerModeState; // 0x33
	public const string k_localTransformName = "attach"; // Metadata: 0x00653574
	public static Hashtable models; // 0x00
	public static Hashtable materials; // 0x08
	private SteamVR_Events.Action deviceConnectedAction; // 0x40
	private SteamVR_Events.Action hideRenderModelsAction; // 0x48
	private SteamVR_Events.Action modelSkinSettingsHaveChangedAction; // 0x50
	private Dictionary<int, string> nameCache; // 0x58

	// Properties
	public string renderModelName { get; private set; } // 0x0000000180246FD0-0x0000000180246FE0 0x0000000180278400-0x0000000180278410

	// Nested types
	public class RenderModel // TypeDefIndex: 7295
	{
		// Properties
		public Mesh mesh { get; private set; } // 0x0000000180248E10-0x0000000180248E20 0x0000000180248410-0x0000000180248420
		public Material material { get; private set; } // 0x0000000180246BC0-0x0000000180246BD0 0x0000000180246D40-0x0000000180246D50

		// Constructors
		public RenderModel() {} // Dummy constructor
		public RenderModel(Mesh mesh, Material material) {} // 0x0000000180294750-0x00000001802947A0
	}

	public sealed class RenderModelInterfaceHolder : IDisposable // TypeDefIndex: 7296
	{
		// Fields
		private bool needsShutdown; // 0x10
		private bool failedLoadInterface; // 0x11
		private CVRRenderModels _instance; // 0x18

		// Properties
		public CVRRenderModels instance { get => default; } // 0x0000000180CB8F10-0x0000000180CB9060 

		// Constructors
		public RenderModelInterfaceHolder() {} // 0x00000001802466A0-0x00000001802466B0

		// Methods
		public void Dispose() {} // 0x0000000180CB8EB0-0x0000000180CB8F10
	}

	// Constructors
	private SteamVR_RenderModel() {} // 0x0000000180CCBD30-0x0000000180CCBEE0
	static SteamVR_RenderModel() {} // 0x0000000180CCBCA0-0x0000000180CCBD30

	// Methods
	private void OnModelSkinSettingsHaveChanged(VREvent_t vrEvent) {} // 0x0000000180CCAE20-0x0000000180CCAE80
	private void OnHideRenderModels(bool hidden) {} // 0x0000000180CCAD10-0x0000000180CCAE20
	private void OnDeviceConnected(int i, bool connected) {} // 0x0000000180CCAB60-0x0000000180CCAB80
	public void UpdateModel() {} // 0x0000000180CCBA20-0x0000000180CCBC30
	// [IteratorStateMachine] // 0x000000018011F9D0-0x000000018011FA20
	private IEnumerator SetModelAsync(string renderModelName) => default; // 0x0000000180CCAEF0-0x0000000180CCAF80
	private bool SetModel(string renderModelName) => default; // 0x0000000180CCAF80-0x0000000180CCB410
	private RenderModel LoadRenderModel(CVRRenderModels renderModels, string renderModelName, string baseName) => default; // 0x0000000180CC9AF0-0x0000000180CCA750
	// [IteratorStateMachine] // 0x000000018011FBA0-0x000000018011FBF0
	private IEnumerator FreeRenderModel(IntPtr pRenderModel) => default; // 0x0000000180CC92F0-0x0000000180CC9350
	public Transform FindComponent(string componentName) => default; // 0x0000000180CC9250-0x0000000180CC92F0
	private void StripMesh(GameObject go) {} // 0x0000000180CCB420-0x0000000180CCB540
	private bool LoadComponents(RenderModelInterfaceHolder holder, string renderModelName) => default; // 0x0000000180CC9350-0x0000000180CC9AF0
	private void OnEnable() {} // 0x0000000180CCABF0-0x0000000180CCAD10
	private void OnDisable() {} // 0x0000000180CCAB80-0x0000000180CCABF0
	private void Update() {} // 0x0000000180CCBC30-0x0000000180CCBCA0
	public void UpdateComponents(CVRRenderModels renderModels) {} // 0x0000000180CCB540-0x0000000180CCBA20
	public void SetDeviceIndex(int index) {} // 0x0000000180CCAE80-0x0000000180CCAEF0
	private static void Sleep() {} // 0x0000000180CCB410-0x0000000180CCB420
	private RenderModel_t MarshalRenderModel(IntPtr pRenderModel) => default; // 0x0000000180CCA940-0x0000000180CCAB60
	private RenderModel_TextureMap_t MarshalRenderModel_TextureMap(IntPtr pRenderModel) => default; // 0x0000000180CCA750-0x0000000180CCA940
}

