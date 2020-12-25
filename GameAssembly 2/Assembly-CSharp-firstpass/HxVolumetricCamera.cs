/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

[ExecuteInEditMode] // 0x00000001800D4E50-0x00000001800D4E60
public class HxVolumetricCamera : MonoBehaviour // TypeDefIndex: 5830
{
	// Fields
	public hxRenderOrder RenderOrder; // 0x18
	public HxVolumetricRenderCallback callBackImageEffect; // 0x20
	public HxVolumetricRenderCallback callBackImageEffectOpaque; // 0x28
	public bool ShadowFix; // 0x30
	private bool TemporalFirst; // 0x31
	public bool TemporalSampling; // 0x32
	// [Range] // 0x00000001800D6560-0x00000001800D6580
	public float DitherSpeed; // 0x34
	// [Range] // 0x00000001800D6560-0x00000001800D6580
	public float LuminanceFeedback; // 0x38
	// [Range] // 0x00000001800D6560-0x00000001800D6580
	public float MaxFeedback; // 0x3C
	// [Range] // 0x00000001800EDF90-0x00000001800EDFB0
	public float NoiseContrast; // 0x40
	private static Shader directionalShader; // 0x00
	private static Shader pointShader; // 0x08
	private static Shader spotShader; // 0x10
	private static Shader ProjectorShader; // 0x18
	[NonSerialized]
	public bool FullUsed; // 0x44
	[NonSerialized]
	public bool LowResUsed; // 0x45
	[NonSerialized]
	public bool HeightFogUsed; // 0x46
	[NonSerialized]
	public bool HeightFogOffUsed; // 0x47
	[NonSerialized]
	public bool NoiseUsed; // 0x48
	[NonSerialized]
	public bool NoiseOffUsed; // 0x49
	[NonSerialized]
	public bool TransparencyUsed; // 0x4A
	[NonSerialized]
	public bool TransparencyOffUsed; // 0x4B
	[NonSerialized]
	public bool DensityParticlesUsed; // 0x4C
	[NonSerialized]
	public bool PointUsed; // 0x4D
	[NonSerialized]
	public bool SpotUsed; // 0x4E
	[NonSerialized]
	public bool ProjectorUsed; // 0x4F
	[NonSerialized]
	public bool DirectionalUsed; // 0x50
	[NonSerialized]
	public bool SinglePassStereoUsed; // 0x51
	public static TransparencyQualities TransparencyBufferDepth; // 0x20
	public static DensityParticleQualities DensityBufferDepth; // 0x24
	private int EnumBufferDepthLength; // 0x54
	private Matrix4x4 CurrentView; // 0x58
	private Matrix4x4 CurrentProj; // 0x98
	private Matrix4x4 CurrentInvers; // 0xD8
	private Matrix4x4 CurrentView2; // 0x118
	private Matrix4x4 CurrentProj2; // 0x158
	private Matrix4x4 CurrentInvers2; // 0x198
	private RenderTexture TemporalTexture; // 0x1D8
	private RenderTargetIdentifier TemporalTextureRTID; // 0x1E0
	private static RenderTexture VolumetricTexture; // 0x28
	private static RenderTexture FullBlurRT; // 0x30
	private static RenderTargetIdentifier FullBlurRTID; // 0x38
	private static RenderTexture downScaledBlurRT; // 0x60
	private static RenderTargetIdentifier downScaledBlurRTID; // 0x68
	private static RenderTexture FullBlurRT2; // 0x90
	private static RenderTargetIdentifier FullBlurRT2ID; // 0x98
	private static RenderTargetIdentifier[] VolumetricUpsampledBlurTextures; // 0xC0
	private static RenderTexture[] VolumetricDensityTextures; // 0xC8
	private static int[] VolumetricDensityPID; // 0xD0
	private static int[] VolumetricTransparencyPID; // 0xD8
	private static RenderTexture[] VolumetricTransparencyTextures; // 0xE0
	public static RenderTargetIdentifier[][] VolumetricDensity; // 0xE8
	public static RenderTargetIdentifier[][] VolumetricTransparency; // 0xF0
	public static RenderTargetIdentifier[][] VolumetricTransparencyI; // 0xF8
	private static RenderTexture[] ScaledDepthTexture; // 0x100
	private static ShaderVariantCollection CollectionAll; // 0x108
	public static Texture2D Tile5x5; // 0x110
	private static int VolumetricTexturePID; // 0x118
	private static int ScaledDepthTexturePID; // 0x11C
	public static int ShadowMapTexturePID; // 0x120
	public static RenderTargetIdentifier VolumetricTextureRTID; // 0x128
	public static RenderTargetIdentifier[] ScaledDepthTextureRTID; // 0x150
	[NonSerialized]
	public static Material DownSampleMaterial; // 0x158
	[NonSerialized]
	public static Material VolumeBlurMaterial; // 0x160
	[NonSerialized]
	public static Material TransparencyBlurMaterial; // 0x168
	[NonSerialized]
	public static Material ApplyMaterial; // 0x170
	[NonSerialized]
	public static Material ApplyDirectMaterial; // 0x178
	[NonSerialized]
	public static Material ApplyQueueMaterial; // 0x180
	public Texture3D NoiseTexture3D; // 0x208
	public static Matrix4x4 BlitMatrix; // 0x188
	public static Matrix4x4 BlitMatrixMV; // 0x1C8
	public static Matrix4x4 BlitMatrixMVP; // 0x208
	public static Vector3 BlitScale; // 0x248
	// [Tooltip] // 0x00000001800EE0F0-0x00000001800EE120
	public Resolution resolution; // 0x210
	// [Range] // 0x00000001800EE120-0x00000001800EE180
	// [Tooltip] // 0x00000001800EE120-0x00000001800EE180
	public int SampleCount; // 0x214
	// [Range] // 0x00000001800EE120-0x00000001800EE180
	// [Tooltip] // 0x00000001800EE120-0x00000001800EE180
	public int DirectionalSampleCount; // 0x218
	// [Tooltip] // 0x00000001800EE200-0x00000001800EE230
	public float MaxDirectionalRayDistance; // 0x21C
	// [Tooltip] // 0x00000001800EE230-0x00000001800EE260
	public float MaxLightDistance; // 0x220
	// [Range] // 0x00000001800EE260-0x00000001800EE2B0
	// [Tooltip] // 0x00000001800EE260-0x00000001800EE2B0
	public float Density; // 0x224
	// [Range] // 0x00000001800DF770-0x00000001800DF790
	public float AmbientLightingStrength; // 0x228
	// [Range] // 0x00000001800EE3A0-0x00000001800EE400
	// [Tooltip] // 0x00000001800EE3A0-0x00000001800EE400
	public float MieScattering; // 0x22C
	// [Range] // 0x00000001800EE500-0x00000001800EE550
	// [Tooltip] // 0x00000001800EE500-0x00000001800EE550
	public float SunSize; // 0x230
	// [Tooltip] // 0x00000001800EE550-0x00000001800EE580
	public bool SunBleed; // 0x234
	// [Range] // 0x00000001800EE6A0-0x00000001800EE6F0
	// [Tooltip] // 0x00000001800EE6A0-0x00000001800EE6F0
	public float Extinction; // 0x238
	// [Range] // 0x00000001800EE830-0x00000001800EE890
	// [Tooltip] // 0x00000001800EE830-0x00000001800EE890
	public float ExtinctionEffect; // 0x23C
	public bool FogHeightEnabled; // 0x240
	public float FogHeight; // 0x244
	public float FogTransitionSize; // 0x248
	public float AboveFogPercent; // 0x24C
	// [Tooltip] // 0x00000001800EE950-0x00000001800EE980
	public HxAmbientMode Ambient; // 0x250
	public Color AmbientSky; // 0x254
	public Color AmbientEquator; // 0x264
	public Color AmbientGround; // 0x274
	// [Range] // 0x00000001800D6560-0x00000001800D6580
	public float AmbientIntensity; // 0x284
	public HxTintMode TintMode; // 0x288
	public Color TintColor; // 0x28C
	public Color TintColor2; // 0x29C
	public float TintIntensity; // 0x2AC
	// [Range] // 0x00000001800D6560-0x00000001800D6580
	public float TintGradient; // 0x2B0
	public Vector3 CurrentTint; // 0x2B4
	public Vector3 CurrentTintEdge; // 0x2C0
	// [Tooltip] // 0x00000001800EEB40-0x00000001800EEB70
	public bool NoiseEnabled; // 0x2CC
	// [Tooltip] // 0x00000001800EEC30-0x00000001800EEC60
	public Vector3 NoiseScale; // 0x2D0
	// [Tooltip] // 0x00000001800EED50-0x00000001800EED80
	public Vector3 NoiseVelocity; // 0x2DC
	// [Tooltip] // 0x00000001800EEDF0-0x00000001800EEE20
	public bool ParticleDensitySupport; // 0x2E8
	// [Tooltip] // 0x00000001800EEF20-0x00000001800EEF50
	public DensityResolution densityResolution; // 0x2EC
	// [Tooltip] // 0x00000001800EEFB0-0x00000001800EEFE0
	public float densityDistance; // 0x2F0
	private float densityBias; // 0x2F4
	// [Tooltip] // 0x00000001800EEFE0-0x00000001800EF010
	public bool TransparencySupport; // 0x2F8
	// [Tooltip] // 0x00000001800F0360-0x00000001800F0390
	public float transparencyDistance; // 0x2FC
	// [Range] // 0x00000001800F03D0-0x00000001800F0430
	// [Tooltip] // 0x00000001800F03D0-0x00000001800F0430
	public int BlurTransparency; // 0x300
	private float transparencyBias; // 0x304
	// [Range] // 0x00000001800F0550-0x00000001800F05A0
	// [Tooltip] // 0x00000001800F0550-0x00000001800F05A0
	public int blurCount; // 0x308
	// [Tooltip] // 0x00000001800F0600-0x00000001800F0630
	public float BlurDepthFalloff; // 0x30C
	// [Tooltip] // 0x00000001800F0700-0x00000001800F0730
	public float DownsampledBlurDepthFalloff; // 0x310
	// [Range] // 0x00000001800F0900-0x00000001800F0950
	// [Tooltip] // 0x00000001800F0900-0x00000001800F0950
	public int UpSampledblurCount; // 0x314
	// [Tooltip] // 0x00000001800F0A30-0x00000001800F0A60
	public float DepthThreshold; // 0x318
	// [Tooltip] // 0x00000001800F0B30-0x00000001800F0B60
	public bool GaussianWeights; // 0x31C
	[HideInInspector] // 0x00000001800F0B90-0x00000001800F0BD0
	// [Tooltip] // 0x00000001800F0B90-0x00000001800F0BD0
	public bool MapToLDR; // 0x31D
	// [Tooltip] // 0x00000001800F0C00-0x00000001800F0C30
	public bool RemoveColorBanding; // 0x31E
	[NonSerialized]
	public Vector3 Offset; // 0x320
	private static int DepthThresholdPID; // 0x254
	private static int BlurDepthFalloffPID; // 0x258
	private static int VolumeScalePID; // 0x25C
	private static int InverseViewMatrixPID; // 0x260
	private static int InverseProjectionMatrixPID; // 0x264
	private static int InverseProjectionMatrix2PID; // 0x268
	private static int NoiseOffsetPID; // 0x26C
	private static int ShadowDistancePID; // 0x270
	private static HxVolumetricShadersUsed UsedShaderSettings; // 0x278
	private static List<string> ShaderVariantList; // 0x280
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public static List<HxDensityVolume> ActiveVolumes; // 0x288
	public static List<HxVolumetricLight> ActiveLights; // 0x290
	public static List<HxVolumetricParticleSystem> ActiveParticleSystems; // 0x298
	public static HxOctree<HxVolumetricLight> LightOctree; // 0x2A0
	public static HxOctree<HxVolumetricParticleSystem> ParticleOctree; // 0x2A8
	public static HashSet<HxDensityVolume> AllDensityVolumes; // 0x2B0
	public static HashSet<HxVolumetricLight> AllVolumetricLight; // 0x2B8
	public static HashSet<HxVolumetricParticleSystem> AllParticleSystems; // 0x2C0
	private bool test; // 0x32C
	public static Mesh QuadMesh; // 0x2C8
	public static Mesh BoxMesh; // 0x2D0
	public static Mesh SphereMesh; // 0x2D8
	public static Mesh SpotLightMesh; // 0x2E0
	public static Mesh OrthoProjectorMesh; // 0x2E8
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	private Camera Mycamera; // 0x330
	private static float[] ResolutionScale; // 0x2F0
	public static float[] SampleScale; // 0x2F8
	private CommandBuffer BufferSetup; // 0x338
	private CommandBuffer BufferRender; // 0x340
	private CommandBuffer BufferRenderLights; // 0x348
	private CommandBuffer BufferFinalize; // 0x350
	private bool dirty; // 0x358
	[NonSerialized]
	public static bool PIDCreated; // 0x300
	[NonSerialized]
	private static Dictionary<int, Material> DirectionalMaterial; // 0x308
	[NonSerialized]
	private static Dictionary<int, Material> PointMaterial; // 0x310
	[NonSerialized]
	private static Dictionary<int, Material> SpotMaterial; // 0x318
	[NonSerialized]
	private static Dictionary<int, Material> ProjectorMaterial; // 0x320
	public static ShaderVariantCollection.ShaderVariant[] DirectionalVariant; // 0x328
	public static ShaderVariantCollection.ShaderVariant[] PointVariant; // 0x330
	public static ShaderVariantCollection.ShaderVariant[] SpotVariant; // 0x338
	public static Material ShadowMaterial; // 0x340
	public static Material DensityMaterial; // 0x348
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public Matrix4x4 MatrixVP; // 0x35C
	public Matrix4x4 LastMatrixVP; // 0x39C
	public Matrix4x4 LastMatrixVPInv; // 0x3DC
	public Matrix4x4 LastMatrixVP2; // 0x41C
	public Matrix4x4 LastMatrixVPInv2; // 0x45C
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public Matrix4x4 MatrixV; // 0x49C
	private bool OffsetUpdated; // 0x4DC
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	private static Texture2D _SpotLightCookie; // 0x350
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	private static Texture2D _LightFalloff; // 0x358
	private int ParticleDensityRenderCount; // 0x4E0
	private static Matrix4x4 particleMatrix; // 0x360
	public static HxVolumetricCamera Active; // 0x3A0
	public static Camera ActiveCamera; // 0x3A8
	private CameraEvent LightRenderEvent; // 0x4E4
	private CameraEvent SetupEvent; // 0x4E8
	private CameraEvent RenderEvent; // 0x4EC
	private CameraEvent FinalizeEvent; // 0x4F0
	public static List<HxVolumetricLight> ActiveDirectionalLights; // 0x3B0
	private static Vector3 MinBounds; // 0x3B8
	private static Vector3 MaxBounds; // 0x3C4
	private static Plane[] CameraPlanes; // 0x3D0
	private bool preCullEventAdded; // 0x4F4
	private bool BuffersBuilt; // 0x4F5
	private bool LightBufferAdded; // 0x4F6
	private bool SetupBufferAdded; // 0x4F7
	private bool SetupBufferDirty; // 0x4F8
	private bool FinalizeBufferAdded; // 0x4F9
	private bool FinalizeBufferDirty; // 0x4FA
	private CameraEvent lastApply; // 0x4FC
	private CameraEvent lastRender; // 0x500
	private CameraEvent lastSetup; // 0x504
	private CameraEvent lastFinalize; // 0x508
	private CameraEvent lastLightRender; // 0x50C
	private bool LastPlaying; // 0x510
	[NonSerialized]
	private static int lastRes; // 0x3D8
	[NonSerialized]
	private int lastBlurCount; // 0x514
	[NonSerialized]
	private int lastupSampleBlurCount; // 0x518
	[NonSerialized]
	private int lastLDR; // 0x51C
	[NonSerialized]
	private int lastBanding; // 0x520
	[NonSerialized]
	private int lastH; // 0x524
	[NonSerialized]
	private int lastW; // 0x528
	[NonSerialized]
	private int lastPath; // 0x52C
	[NonSerialized]
	private int lastGaussian; // 0x530
	[NonSerialized]
	private int lastTransparency; // 0x534
	[NonSerialized]
	private int lastDensity; // 0x538
	[NonSerialized]
	private int lastDensityRes; // 0x53C
	[NonSerialized]
	private float lastDepthFalloff; // 0x540
	[NonSerialized]
	private float lastDownDepthFalloff; // 0x544
	private float currentDitherOffset; // 0x548
	private float MaxLightDistanceUsed; // 0x54C
	public static bool FirstDirectional; // 0x3DC
	private static int[] Tile5x5int; // 0x3E0

	// Properties
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public Texture2D SpotLightCookie { get => default; set {} } // 0x0000000180340520-0x00000001803406D0 0x0000000180340750-0x00000001803407C0
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public Texture2D LightFalloff { get => default; set {} } // 0x0000000180340370-0x0000000180340520 0x00000001803406E0-0x0000000180340750

	// Nested types
	public enum hxRenderOrder // TypeDefIndex: 5831
	{
		ImageEffect = 0,
		ImageEffectOpaque = 1
	}

	public enum TransparencyQualities // TypeDefIndex: 5832
	{
		Low = 0,
		Medium = 1,
		High = 2,
		VeryHigh = 3
	}

	public enum DensityParticleQualities // TypeDefIndex: 5833
	{
		Low = 0,
		Medium = 1,
		High = 2,
		VeryHigh = 3
	}

	public enum HxAmbientMode // TypeDefIndex: 5834
	{
		UseRenderSettings = 0,
		Color = 1,
		Gradient = 2
	}

	public enum HxTintMode // TypeDefIndex: 5835
	{
		Off = 0,
		Color = 1,
		Edge = 2,
		Gradient = 3
	}

	public enum Resolution // TypeDefIndex: 5836
	{
		full = 0,
		half = 1,
		quarter = 2
	}

	public enum DensityResolution // TypeDefIndex: 5837
	{
		full = 0,
		half = 1,
		quarter = 2,
		eighth = 3
	}

	private struct TriangleIndices // TypeDefIndex: 5838
	{
		// Fields
		public int v1; // 0x00
		public int v2; // 0x04
		public int v3; // 0x08

		// Constructors
		public TriangleIndices(int v1, int v2, int v3) {
			this.v1 = default;
			this.v2 = default;
			this.v3 = default;
		} // 0x00000001800084C0-0x0000000180008520
	}

	// Constructors
	public HxVolumetricCamera() {} // 0x000000018033FC90-0x000000018033FFB0
	static HxVolumetricCamera() {} // 0x000000018033EB60-0x000000018033FC90

	// Methods
	private void SetUpRenderOrder() {} // 0x000000018033D7D0-0x000000018033DAE0
	public static Material GetDirectionalMaterial(int mid) => default; // 0x000000018033A280-0x000000018033A440
	public static Material GetProjectorMaterial(int mid) => default; // 0x000000018033A610-0x000000018033A7E0
	public static Material GetSpotMaterial(int mid) => default; // 0x000000018033A7E0-0x000000018033A9B0
	public static Material GetPointMaterial(int mid) => default; // 0x000000018033A440-0x000000018033A610
	public TransparencyQualities compatibleTBuffer() => default; // 0x0000000180340070-0x0000000180340130
	private bool IsRenderBoth() => default; // 0x000000018033A9B0-0x000000018033AA50
	private DensityParticleQualities compatibleDBuffer() => default; // 0x000000018033FFB0-0x0000000180340070
	private void MyPreCull(Camera cam) {} // 0x000000018033AA50-0x000000018033AB10
	public bool renderDensityParticleCheck() => default; // 0x00000001803406D0-0x00000001803406E0
	private void WarmUp() {} // 0x000000018033E740-0x000000018033EB60
	private void CreateShaderVariant(Shader source, int i, ref Material[] material, ref ShaderVariantCollection.ShaderVariant[] Variant, bool point = true /* Metadata: 0x006506D7 */) {} // 0x0000000180337670-0x0000000180337CD0
	private static void CreateShader(Shader source, int i, out Material outMaterial, bool point = true /* Metadata: 0x006506D8 */) {
		outMaterial = default;
	} // 0x0000000180337CD0-0x0000000180337E90
	private void CreatePIDs() {} // 0x0000000180335C30-0x0000000180336F00
	public static bool ActiveFull() => default; // 0x000000018032D0B0-0x000000018032D120
	private void DefineFull() {} // 0x0000000180246DB0-0x0000000180246DC0
	private static void UpdateLight(HxOctreeNode<HxVolumetricLight> node, Vector3 boundsMin, Vector3 boundsMax) {} // 0x000000018033DFC0-0x000000018033E090
	public static HxOctreeNode<HxVolumetricLight> AddLightOctree(HxVolumetricLight light, Vector3 boundsMin, Vector3 boundsMax) => default; // 0x000000018032D120-0x000000018032D300
	public static HxOctreeNode<HxVolumetricParticleSystem> AddParticleOctree(HxVolumetricParticleSystem particle, Vector3 boundsMin, Vector3 boundsMax) => default; // 0x000000018032D300-0x000000018032D4E0
	public static void RemoveLightOctree(HxVolumetricLight light) {} // 0x000000018033C250-0x000000018033C300
	public static void RemoveParticletOctree(HxVolumetricParticleSystem Particle) {} // 0x000000018033C300-0x000000018033C3B0
	private void OnApplicationQuit() {} // 0x000000018033AB10-0x000000018033AB70
	public Camera GetCamera() => default; // 0x000000018033A1E0-0x000000018033A280
	private Vector4 CalculateDensityDistance(int i) => default; // 0x000000018032F720-0x000000018032F960
	private Vector4 CalculateTransparencyDistance(int i) => default; // 0x000000018032FA70-0x000000018032FC70
	private void RenderParticles() {} // 0x000000018033C3B0-0x000000018033CB80
	private void OnPostRender() {} // 0x000000018033B330-0x000000018033B370
	private int RenderSlices() => default; // 0x000000018033CB80-0x000000018033D7B0
	private int GetCamPixelHeight() => default; // 0x0000000180339FE0-0x000000018033A090
	private int GetCamPixelWidth() => default; // 0x000000018033A090-0x000000018033A1E0
	private void CreateTempTextures() {} // 0x0000000180337E90-0x00000001803393D0
	public static void ConstructPlanes(Camera cam, float near, float far) {} // 0x0000000180330100-0x0000000180330FA0
	private void FindActiveLights() {} // 0x0000000180339AA0-0x0000000180339EB0
	private void FindActiveParticleSystems() {} // 0x0000000180339EB0-0x0000000180339FE0
	public void Update() {} // 0x000000018033E200-0x000000018033E740
	private void Start() {} // 0x000000018033DAE0-0x000000018033DBC0
	private void OnEnable() {} // 0x000000018033B250-0x000000018033B330
	private void CreateApplyBuffer() {} // 0x0000000180246DB0-0x0000000180246DC0
	private void CreateSetupBuffer() {} // 0x00000001803371F0-0x0000000180337670
	private bool CheckBufferDirty() => default; // 0x000000018032FC70-0x000000018032FEC0
	private void CreateFinalizeBuffer() {} // 0x00000001803318B0-0x00000001803341B0
	private void BuildBuffer() {} // 0x000000018032D620-0x000000018032F720
	private void OnDestroy() {} // 0x000000018033AB70-0x000000018033AEE0
	private void SaveUsedShaderVarience() {} // 0x0000000180246DB0-0x0000000180246DC0
	private void OnDisable() {} // 0x000000018033AEE0-0x000000018033B250
	private void CalculateEvent() {} // 0x000000018032F960-0x000000018032FA70
	public void EventOnRenderImage(RenderTexture src, RenderTexture dest) {} // 0x00000001803399B0-0x0000000180339AA0
	private int ScalePass() => default; // 0x000000018033D7B0-0x000000018033D7D0
	private void DownSampledFullBlur(RenderTexture mainColor, RenderBuffer NewColor, RenderBuffer depth, int pass) {} // 0x0000000180339800-0x00000001803399B0
	private void CheckTemporalTextures() {} // 0x000000018032FEC0-0x0000000180330100
	public static void ReleaseTempTextures() {} // 0x000000018033B760-0x000000018033C250
	private void OnPreCull() {} // 0x000000018033B370-0x000000018033B580
	private void UpdateLightPoistions() {} // 0x000000018033DBC0-0x000000018033DFC0
	private void UpdateParticlePoistions() {} // 0x000000018033E090-0x000000018033E200
	private void Awake() {} // 0x000000018032D4E0-0x000000018032D620
	private void start() {} // 0x00000001803407C0-0x0000000180340810
	public void ReleaseLightBuffers() {} // 0x000000018033B640-0x000000018033B760
	private void CreateLightbuffers() {} // 0x0000000180335490-0x00000001803358B0
	private static void CreateTileTexture() {} // 0x00000001803393D0-0x0000000180339800
	public static Mesh CreateOrtho(int sides, bool inner = true /* Metadata: 0x006506D9 */) => default; // 0x00000001803358B0-0x0000000180335C30
	public static Mesh CreateCone(int sides, bool inner = true /* Metadata: 0x006506DA */) => default; // 0x0000000180331100-0x00000001803318B0
	public static Mesh CreateQuad() => default; // 0x0000000180336F00-0x00000001803371F0
	public static Mesh CreateBox() => default; // 0x0000000180331020-0x0000000180331100
	public static Mesh CreateIcoSphere(int recursionLevel, float radius) => default; // 0x00000001803341B0-0x0000000180335490
	private static int getMiddlePoint(int p1, int p2, ref List<Vector3> vertices, ref Dictionary<long, int> cache, float radius) => default; // 0x0000000180340130-0x0000000180340370
	public void Create3DNoiseTexture() {} // 0x0000000180330FA0-0x0000000180331020
	private int PostoIndex(Vector3 pos) => default; // 0x000000018033B580-0x000000018033B640
}

