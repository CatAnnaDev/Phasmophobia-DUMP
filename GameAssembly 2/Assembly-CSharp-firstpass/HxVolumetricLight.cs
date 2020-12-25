/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

[ExecuteInEditMode] // 0x00000001800D4E50-0x00000001800D4E60
public class HxVolumetricLight : MonoBehaviour // TypeDefIndex: 5842
{
	// Fields
	private static float ShadowDistanceExtra; // 0x00
	private Light myLight; // 0x18
	private HxDummyLight myDummyLight; // 0x20
	public Texture3D NoiseTexture3D; // 0x28
	private CommandBuffer BufferRender; // 0x30
	private CommandBuffer BufferCopy; // 0x38
	private Projector myProjector; // 0x40
	public Vector3 NoiseScale; // 0x48
	public Vector3 NoiseVelocity; // 0x54
	private bool dirty; // 0x60
	public Texture LightFalloff; // 0x68
	public float NearPlane; // 0x70
	public bool NoiseEnabled; // 0x74
	public bool CustomMieScatter; // 0x75
	public bool CustomExtinction; // 0x76
	public bool CustomExtinctionEffect; // 0x77
	public bool CustomDensity; // 0x78
	public bool CustomSampleCount; // 0x79
	public bool CustomColor; // 0x7A
	public bool CustomNoiseEnabled; // 0x7B
	public bool CustomNoiseTexture; // 0x7C
	public bool CustomNoiseScale; // 0x7D
	public bool CustomNoiseVelocity; // 0x7E
	public bool CustomNoiseContrast; // 0x7F
	public bool CustomFogHeightEnabled; // 0x80
	public bool CustomFogHeight; // 0x81
	public bool CustomFogTransitionSize; // 0x82
	public bool CustomAboveFogPercent; // 0x83
	public bool CustomSunSize; // 0x84
	public bool CustomSunBleed; // 0x85
	public bool ShadowCasting; // 0x86
	public bool CustomStrength; // 0x87
	public bool CustomIntensity; // 0x88
	public bool CustomTintMode; // 0x89
	public bool CustomTintColor; // 0x8A
	public bool CustomTintColor2; // 0x8B
	public bool CustomTintGradient; // 0x8C
	public bool CustomTintIntensity; // 0x8D
	public bool CustomMaxLightDistance; // 0x8E
	// [Range] // 0x00000001800EDF90-0x00000001800EDFB0
	public float NoiseContrast; // 0x90
	public HxVolumetricCamera.HxTintMode TintMode; // 0x94
	public Color TintColor; // 0x98
	public Color TintColor2; // 0xA8
	public float TintIntensity; // 0xB8
	// [Range] // 0x00000001800D6560-0x00000001800D6580
	public float TintGradient; // 0xBC
	// [Range] // 0x00000001800ED7E0-0x00000001800ED800
	public float Intensity; // 0xC0
	// [Range] // 0x00000001800D6560-0x00000001800D6580
	public float Strength; // 0xC4
	public Color Color; // 0xC8
	// [Range] // 0x00000001800F19C0-0x00000001800F1A10
	// [Tooltip] // 0x00000001800F19C0-0x00000001800F1A10
	public float MieScattering; // 0xD8
	// [Range] // 0x00000001800F1AF0-0x00000001800F1B40
	// [Tooltip] // 0x00000001800F1AF0-0x00000001800F1B40
	public float SunSize; // 0xDC
	// [Tooltip] // 0x00000001800EE550-0x00000001800EE580
	public bool SunBleed; // 0xE0
	// [Range] // 0x00000001800F1D20-0x00000001800F1D70
	// [Tooltip] // 0x00000001800F1D20-0x00000001800F1D70
	public float Extinction; // 0xE4
	// [Range] // 0x00000001800EE260-0x00000001800EE2B0
	// [Tooltip] // 0x00000001800EE260-0x00000001800EE2B0
	public float Density; // 0xE8
	// [Range] // 0x00000001800F2040-0x00000001800F2090
	// [Tooltip] // 0x00000001800F2040-0x00000001800F2090
	public float ExtraDensity; // 0xEC
	// [Range] // 0x00000001800F2140-0x00000001800F2190
	// [Tooltip] // 0x00000001800F2140-0x00000001800F2190
	public int SampleCount; // 0xF0
	// [Tooltip] // 0x00000001800F2220-0x00000001800F2250
	public bool Shadows; // 0xF4
	public bool FogHeightEnabled; // 0xF5
	public float FogHeight; // 0xF8
	public float FogTransitionSize; // 0xFC
	public float MaxLightDistance; // 0x100
	public float AboveFogPercent; // 0x104
	private bool OffsetUpdated; // 0x108
	public Vector3 Offset; // 0x10C
	private static MaterialPropertyBlock propertyBlock; // 0x08
	private bool bufferBuilt; // 0x118
	public static int VolumetricBMVPPID; // 0x10
	public static int VolumetricMVPPID; // 0x14
	public static int VolumetricMVP2PID; // 0x18
	public static int VolumetricMVPID; // 0x1C
	private static int LightColourPID; // 0x20
	private static int LightColour2PID; // 0x24
	private static int FogHeightsPID; // 0x28
	private static int PhasePID; // 0x2C
	private static int _LightParamsPID; // 0x30
	private static int DensityPID; // 0x34
	private static int ShadowBiasPID; // 0x38
	private static int _CustomLightPositionPID; // 0x3C
	private static int hxNearPlanePID; // 0x40
	private static int NoiseScalePID; // 0x44
	private static int NoiseOffsetPID; // 0x48
	private static int _SpotLightParamsPID; // 0x4C
	private static int _LightTexture0PID; // 0x50
	private static int _hxProjectorTexturePID; // 0x54
	private static int _hxProjectorFalloffTexturePID; // 0x58
	private bool LastBufferDirectional; // 0x119
	private float LastSpotAngle; // 0x11C
	private float LastRange; // 0x120
	private float LastAspect; // 0x124
	private LightType lastType; // 0x128
	private Matrix4x4 LightMatrix; // 0x12C
	private Bounds lastBounds; // 0x16C
	private Vector3 minBounds; // 0x184
	private Vector3 maxBounds; // 0x190
	private HxOctreeNode<HxVolumetricLight> octreeNode; // 0x1A0
	private Vector4 TopFrustumNormal; // 0x1A8
	private Vector4 BottomFrustumNormal; // 0x1B8
	private Vector4 LeftFrustumNormal; // 0x1C8
	private Vector4 RightFrustumNormal; // 0x1D8
	private static Matrix4x4[] VolumeMatrixArrays; // 0x60
	private static Vector4[] VolumeSettingsArrays; // 0x68
	private static Matrix4x4[] VolumeMatrixArraysOld; // 0x70
	private static Vector4[] VolumeSettingsArraysOld; // 0x78
	private float LastOrthoSize; // 0x1E8
	private bool LastOrtho; // 0x1EC
	private bool matrixReconstruct; // 0x1ED

	// Constructors
	public HxVolumetricLight() {} // 0x000000018034FF40-0x0000000180350120
	static HxVolumetricLight() {} // 0x000000018034FE50-0x000000018034FF40

	// Methods
	public Light LightSafe() => default; // 0x000000018034B760-0x000000018034B800
	public HxDummyLight DummyLightSafe() => default; // 0x000000018034A6D0-0x000000018034A770
	private LightType GetLightType() => default; // 0x000000018034A8A0-0x000000018034A980
	private LightShadows LightShadow() => default; // 0x000000018034B930-0x000000018034B9C0
	private bool HasLight() => default; // 0x000000018034AC60-0x000000018034AD10
	private Texture LightCookie() => default; // 0x000000018034AF20-0x000000018034B000
	private Texture LightFalloffTexture() => default; // 0x000000018034B220-0x000000018034B480
	private float LightShadowBias() => default; // 0x000000018034B800-0x000000018034B8A0
	private Color LightColor() => default; // 0x000000018034AD10-0x000000018034AF20
	private float LightSpotAngle() => default; // 0x000000018034B9C0-0x000000018034BAF0
	private bool LightEnabled() => default; // 0x000000018034B000-0x000000018034B220
	private float LightRange() => default; // 0x000000018034B630-0x000000018034B760
	private float LightShadowStrength() => default; // 0x000000018034B8A0-0x000000018034B930
	private float LightIntensity() => default; // 0x000000018034B480-0x000000018034B5A0
	private void OnEnable() {} // 0x000000018034CC50-0x000000018034CE40
	private void OnDisable() {} // 0x000000018034CB30-0x000000018034CC50
	private void OnDestroy() {} // 0x000000018034CA10-0x000000018034CB30
	private void Start() {} // 0x000000018034DB30-0x000000018034DBA0
	public void BuildBuffer(CommandBuffer CameraBuffer) {} // 0x0000000180340C20-0x0000000180340D60
	public void ReleaseBuffer() {} // 0x000000018034CE40-0x000000018034CF10
	public static void CreatePID() {} // 0x00000001803487F0-0x0000000180348A90
	private float LightNearPlane() => default; // 0x000000018034B5A0-0x000000018034B630
	private int DirectionalPass(CommandBuffer buffer) => default; // 0x0000000180348A90-0x0000000180348F70
	private float getContrast() => default; // 0x0000000180350120-0x00000001803501B0
	private bool ShaderModel4() => default; // 0x000000018034DB10-0x000000018034DB30
	private void BuildDirectionalBuffer(CommandBuffer CameraBuffer) {} // 0x0000000180340D60-0x0000000180342730
	private void LoadVolumeDateIntoBuffer(CommandBuffer buffer) {} // 0x000000018034C610-0x000000018034C6D0
	private float CalcLightInstensityDistance(float distance) => default; // 0x0000000180347290-0x00000001803473D0
	private void BuildSpotLightBuffer(CommandBuffer cameraBuffer) {} // 0x00000001803455E0-0x0000000180347290
	private void BuildProjectorLightBuffer(CommandBuffer cameraBuffer) {} // 0x0000000180343F80-0x00000001803455E0
	private void SetColors(CommandBuffer buffer, float distanceLerp) {} // 0x000000018034D4A0-0x000000018034DB10
	private void SetColors(CommandBuffer buffer) {} // 0x000000018034CF10-0x000000018034D4A0
	private Vector3 CalcTintColor(Vector4 c) => default; // 0x0000000180347730-0x0000000180347A90
	private Vector3 CalcTintColorEdge(Vector4 c) => default; // 0x00000001803473D0-0x0000000180347730
	private void BuildPointBuffer(CommandBuffer cameraBuffer) {} // 0x0000000180342730-0x0000000180343F80
	public int MID(bool RenderShadows, bool full) => default; // 0x000000018034C6D0-0x000000018034C8A0
	private void Update() {} // 0x000000018034FE40-0x000000018034FE50
	private float GetFogDensity() => default; // 0x000000018034A800-0x000000018034A8A0
	private Texture3D GetNoiseTexture() => default; // 0x000000018034A980-0x000000018034AA40
	private int GetSampleCount(bool RenderShadows) => default; // 0x000000018034AB60-0x000000018034AC60
	public static Vector3 ClosestPointOnLine(Vector3 vA, Vector3 vB, Vector3 vPoint) => default; // 0x00000001803485B0-0x00000001803487F0
	private float ClosestDistanceToCone(Vector3 Point) => default; // 0x0000000180347C50-0x00000001803485B0
	private void UpdateLightMatrix() {} // 0x000000018034DBA0-0x000000018034E1F0
	private void CheckLightType() {} // 0x0000000180347A90-0x0000000180347C50
	private void LoadVolumeData() {} // 0x000000018034C0C0-0x000000018034C610
	private bool BoundsIntersect(HxDensityVolume vol) => default; // 0x0000000180340BB0-0x0000000180340C20
	private void LoadVolumeDataBounds() {} // 0x000000018034BAF0-0x000000018034C0C0
	private Vector4 NormalOfTriangle(Vector3 a, Vector3 b, Vector3 c) => default; // 0x000000018034C8A0-0x000000018034CA10
	private void DrawIntersect() {} // 0x00000001803498C0-0x000000018034A6D0
	private float GetAspect() => default; // 0x000000018034A770-0x000000018034A800
	private float GetOrthoSize() => default; // 0x000000018034AA40-0x000000018034AAD0
	private bool GetOrtho() => default; // 0x000000018034AAD0-0x000000018034AB60
	public void UpdatePosition(bool first = false /* Metadata: 0x0065073B */) {} // 0x000000018034E1F0-0x000000018034FE40
	public void DrawBounds() {} // 0x0000000180348F70-0x00000001803498C0
}

