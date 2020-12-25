/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.CinematicEffects
{
	// [AddComponentMenu] // 0x000000018010F750-0x000000018010F7F0
	[ExecuteInEditMode] // 0x000000018010F750-0x000000018010F7F0
	[ImageEffectAllowedInSceneView] // 0x000000018010F750-0x000000018010F7F0
	// [RequireComponent] // 0x000000018010F750-0x000000018010F7F0
	public class TonemappingColorGrading : MonoBehaviour // TypeDefIndex: 6027
	{
		// Fields
		[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
		[SettingsGroup] // 0x00000001800D5490-0x00000001800D54C0
		private EyeAdaptationSettings m_EyeAdaptation; // 0x18
		[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
		[SettingsGroup] // 0x00000001800D5490-0x00000001800D54C0
		private TonemappingSettings m_Tonemapping; // 0x30
		[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
		[SettingsGroup] // 0x00000001800D5490-0x00000001800D54C0
		private ColorGradingSettings m_ColorGrading; // 0x60
		[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
		[SettingsGroup] // 0x00000001800D5490-0x00000001800D54C0
		private LUTSettings m_Lut; // 0xF8
		private Texture2D m_IdentityLut; // 0x110
		private RenderTexture m_InternalLut; // 0x118
		private Texture2D m_CurveTexture; // 0x120
		private Texture2D m_TonemapperCurve; // 0x128
		private float m_TonemapperCurveRange; // 0x130
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Shader m_Shader; // 0x138
		private Material m_Material; // 0x140
		private bool m_Dirty; // 0x14A
		private bool m_TonemapperDirty; // 0x14B
		private RenderTexture m_SmallAdaptiveRt; // 0x150
		private RenderTextureFormat m_AdaptiveRtFormat; // 0x158
	
		// Properties
		public EyeAdaptationSettings eyeAdaptation { get => default; set {} } // 0x000000018062BF80-0x000000018062BFA0 0x000000018062C640-0x000000018062C660
		public TonemappingSettings tonemapping { get => default; set {} } // 0x000000018062C560-0x000000018062C580 0x000000018062C690-0x000000018062C6D0
		public ColorGradingSettings colorGrading { get => default; set {} } // 0x000000018062BDE0-0x000000018062BE60 0x000000018062C5A0-0x000000018062C640
		public LUTSettings lut { get => default; set {} } // 0x000000018062C2A0-0x000000018062C2C0 0x000000018062C660-0x000000018062C690
		private Texture2D identityLut { get => default; } // 0x000000018062BFA0-0x000000018062C0A0 
		private RenderTexture internalLutRt { get => default; } // 0x000000018062C0A0-0x000000018062C260 
		private Texture2D curveTexture { get => default; } // 0x000000018062BE60-0x000000018062BF80 
		private Texture2D tonemapperCurve { get => default; } // 0x000000018062C410-0x000000018062C560 
		public Shader shader { get => default; } // 0x000000018062C370-0x000000018062C410 
		public Material material { get => default; } // 0x000000018062C2C0-0x000000018062C370 
		public bool isGammaColorSpace { get => default; } // 0x000000018062C260-0x000000018062C280 
		public int lutSize { get => default; } // 0x000000018062C280-0x000000018062C2A0 
		public bool validRenderTextureFormat { get; private set; } // 0x000000018062C580-0x000000018062C590 0x000000018062C6D0-0x000000018062C6E0
		public bool validUserLutSize { get; private set; } // 0x000000018062C590-0x000000018062C5A0 0x000000018062C6E0-0x000000018062C6F0
	
		// Nested types
		[AttributeUsage(AttributeTargets.All)] // 0x00000001800DFE30-0x00000001800DFE50
		public class SettingsGroup : Attribute // TypeDefIndex: 6028
		{
			// Constructors
			public SettingsGroup() {} // 0x0000000180289A80-0x0000000180289A90
		}
	
		public class IndentedGroup : PropertyAttribute // TypeDefIndex: 6029
		{
			// Constructors
			public IndentedGroup() {} // 0x000000018061D7D0-0x000000018061D7E0
		}
	
		public class ChannelMixer : PropertyAttribute // TypeDefIndex: 6030
		{
			// Constructors
			public ChannelMixer() {} // 0x000000018061D7D0-0x000000018061D7E0
		}
	
		public class ColorWheelGroup : PropertyAttribute // TypeDefIndex: 6031
		{
			// Fields
			public int minSizePerWheel; // 0x10
			public int maxSizePerWheel; // 0x14
	
			// Constructors
			public ColorWheelGroup() {} // 0x000000018061FB60-0x000000018061FB80
			public ColorWheelGroup(int minSizePerWheel, int maxSizePerWheel) {} // 0x000000018061FB10-0x000000018061FB60
		}
	
		public class Curve : PropertyAttribute // TypeDefIndex: 6032
		{
			// Fields
			public Color color; // 0x10
	
			// Constructors
			public Curve() {} // 0x0000000180621EA0-0x0000000180621ED0
			public Curve(float r, float g, float b, float a) {} // 0x0000000180621E00-0x0000000180621EA0
		}
	
		[Serializable]
		public struct EyeAdaptationSettings // TypeDefIndex: 6033
		{
			// Fields
			public bool enabled; // 0x00
			// [Min] // 0x00000001801101F0-0x0000000180110240
			// [Tooltip] // 0x00000001801101F0-0x0000000180110240
			public float middleGrey; // 0x04
			// [Tooltip] // 0x00000001801102A0-0x00000001801102D0
			public float min; // 0x08
			// [Tooltip] // 0x0000000180110300-0x0000000180110330
			public float max; // 0x0C
			// [Min] // 0x00000001801103A0-0x00000001801103F0
			// [Tooltip] // 0x00000001801103A0-0x00000001801103F0
			public float speed; // 0x10
			// [Tooltip] // 0x00000001801104E0-0x0000000180110510
			public bool showDebug; // 0x14
	
			// Properties
			public static EyeAdaptationSettings defaultSettings { get => default; } // 0x0000000180622570-0x00000001806225B0 
		}
	
		public enum Tonemapper // TypeDefIndex: 6034
		{
			ACES = 0,
			Curve = 1,
			Hable = 2,
			HejlDawson = 3,
			Photographic = 4,
			Reinhard = 5,
			Neutral = 6
		}
	
		[Serializable]
		public struct TonemappingSettings // TypeDefIndex: 6035
		{
			// Fields
			public bool enabled; // 0x00
			// [Tooltip] // 0x0000000180110610-0x0000000180110640
			public Tonemapper tonemapper; // 0x04
			// [Min] // 0x0000000180110670-0x00000001801106C0
			// [Tooltip] // 0x0000000180110670-0x00000001801106C0
			public float exposure; // 0x08
			// [Tooltip] // 0x0000000180110790-0x00000001801107C0
			public AnimationCurve curve; // 0x10
			// [Range] // 0x0000000180110830-0x0000000180110850
			public float neutralBlackIn; // 0x18
			// [Range] // 0x0000000180110920-0x0000000180110940
			public float neutralWhiteIn; // 0x1C
			// [Range] // 0x00000001801109B0-0x00000001801109D0
			public float neutralBlackOut; // 0x20
			// [Range] // 0x0000000180110B20-0x0000000180110B40
			public float neutralWhiteOut; // 0x24
			// [Range] // 0x0000000180110B90-0x0000000180110BB0
			public float neutralWhiteLevel; // 0x28
			// [Range] // 0x0000000180108240-0x0000000180108260
			public float neutralWhiteClip; // 0x2C
	
			// Properties
			public static TonemappingSettings defaultSettings { get => default; } // 0x000000018062C6F0-0x000000018062C7A0 
		}
	
		[Serializable]
		public struct LUTSettings // TypeDefIndex: 6036
		{
			// Fields
			public bool enabled; // 0x00
			// [Tooltip] // 0x0000000180110D10-0x0000000180110D40
			public Texture texture; // 0x08
			// [Range] // 0x0000000180110D90-0x0000000180110DE0
			// [Tooltip] // 0x0000000180110D90-0x0000000180110DE0
			public float contribution; // 0x10
	
			// Properties
			public static LUTSettings defaultSettings { get => default; } // 0x0000000180623150-0x00000001806231A0 
		}
	
		[Serializable]
		public struct ColorWheelsSettings // TypeDefIndex: 6037
		{
			// Fields
			// [ColorUsage] // 0x0000000180110EE0-0x0000000180110F00
			public Color shadows; // 0x00
			// [ColorUsage] // 0x0000000180110EE0-0x0000000180110F00
			public Color midtones; // 0x10
			// [ColorUsage] // 0x0000000180110EE0-0x0000000180110F00
			public Color highlights; // 0x20
	
			// Properties
			public static ColorWheelsSettings defaultSettings { get => default; } // 0x000000018061FB80-0x000000018061FBE0 
		}
	
		[Serializable]
		public struct BasicsSettings // TypeDefIndex: 6038
		{
			// Fields
			// [Range] // 0x00000001801111A0-0x00000001801111F0
			// [Tooltip] // 0x00000001801111A0-0x00000001801111F0
			public float temperatureShift; // 0x00
			// [Range] // 0x0000000180111270-0x00000001801112C0
			// [Tooltip] // 0x0000000180111270-0x00000001801112C0
			public float tint; // 0x04
			// [Range] // 0x0000000180112650-0x00000001801126B0
			[Space] // 0x0000000180112650-0x00000001801126B0
			// [Tooltip] // 0x0000000180112650-0x00000001801126B0
			public float hue; // 0x08
			// [Range] // 0x0000000180112920-0x0000000180112970
			// [Tooltip] // 0x0000000180112920-0x0000000180112970
			public float saturation; // 0x0C
			// [Range] // 0x0000000180112A30-0x0000000180112A80
			// [Tooltip] // 0x0000000180112A30-0x0000000180112A80
			public float vibrance; // 0x10
			// [Range] // 0x0000000180112C60-0x0000000180112CB0
			// [Tooltip] // 0x0000000180112C60-0x0000000180112CB0
			public float value; // 0x14
			// [Range] // 0x0000000180112DB0-0x0000000180112E10
			[Space] // 0x0000000180112DB0-0x0000000180112E10
			// [Tooltip] // 0x0000000180112DB0-0x0000000180112E10
			public float contrast; // 0x18
			// [Range] // 0x0000000180112EF0-0x0000000180112F40
			// [Tooltip] // 0x0000000180112EF0-0x0000000180112F40
			public float gain; // 0x1C
			// [Range] // 0x0000000180112FC0-0x0000000180113010
			// [Tooltip] // 0x0000000180112FC0-0x0000000180113010
			public float gamma; // 0x20
	
			// Properties
			public static BasicsSettings defaultSettings { get => default; } // 0x0000000180616510-0x0000000180616570 
		}
	
		[Serializable]
		public struct ChannelMixerSettings // TypeDefIndex: 6039
		{
			// Fields
			public int currentChannel; // 0x00
			public Vector3[] channels; // 0x08
	
			// Properties
			public static ChannelMixerSettings defaultSettings { get => default; } // 0x000000018061D650-0x000000018061D7D0 
		}
	
		[Serializable]
		public struct CurvesSettings // TypeDefIndex: 6040
		{
			// Fields
			[Curve] // 0x0000000180113100-0x0000000180113110
			public AnimationCurve master; // 0x00
			[Curve] // 0x0000000180113140-0x0000000180113180
			public AnimationCurve red; // 0x08
			[Curve] // 0x0000000180113270-0x00000001801132B0
			public AnimationCurve green; // 0x10
			[Curve] // 0x0000000180113320-0x0000000180113360
			public AnimationCurve blue; // 0x18
	
			// Properties
			public static CurvesSettings defaultSettings { get => default; } // 0x0000000180622030-0x00000001806220D0 
			public static AnimationCurve defaultCurve { get => default; } // 0x0000000180621ED0-0x0000000180622030 
		}
	
		public enum ColorGradingPrecision // TypeDefIndex: 6041
		{
			Normal = 16,
			High = 32
		}
	
		[Serializable]
		public struct ColorGradingSettings // TypeDefIndex: 6042
		{
			// Fields
			public bool enabled; // 0x00
			// [Tooltip] // 0x00000001801133D0-0x0000000180113400
			public ColorGradingPrecision precision; // 0x04
			[Space] // 0x0000000180113430-0x0000000180113460
			[ColorWheelGroup] // 0x0000000180113430-0x0000000180113460
			public ColorWheelsSettings colorWheels; // 0x08
			[Space] // 0x0000000180113490-0x00000001801134C0
			[IndentedGroup] // 0x0000000180113490-0x00000001801134C0
			public BasicsSettings basics; // 0x38
			[Space] // 0x0000000180113490-0x00000001801134C0
			[ChannelMixer] // 0x0000000180113490-0x00000001801134C0
			public ChannelMixerSettings channelMixer; // 0x60
			[Space] // 0x0000000180113490-0x00000001801134C0
			[IndentedGroup] // 0x0000000180113490-0x00000001801134C0
			public CurvesSettings curves; // 0x70
			[Space] // 0x0000000180113790-0x00000001801137D0
			// [Tooltip] // 0x0000000180113790-0x00000001801137D0
			public bool useDithering; // 0x90
			// [Tooltip] // 0x0000000180113830-0x0000000180113860
			public bool showDebug; // 0x91
	
			// Properties
			public static ColorGradingSettings defaultSettings { get => default; } // 0x000000018061F7D0-0x000000018061FB10 
	
			// Methods
			internal void Reset() {} // 0x0000000180023F50-0x0000000180024760
		}
	
		private enum Pass // TypeDefIndex: 6043
		{
			LutGen = 0,
			AdaptationLog = 1,
			AdaptationExpBlend = 2,
			AdaptationExp = 3,
			TonemappingOff = 4,
			TonemappingACES = 5,
			TonemappingCurve = 6,
			TonemappingHable = 7,
			TonemappingHejlDawson = 8,
			TonemappingPhotographic = 9,
			TonemappingReinhard = 10,
			TonemappingNeutral = 11,
			AdaptationDebug = 12
		}
	
		// Constructors
		public TonemappingColorGrading() {} // 0x000000018062BC20-0x000000018062BDE0
	
		// Methods
		public void SetDirty() {} // 0x000000018062BBD0-0x000000018062BBE0
		public void SetTonemapperDirty() {} // 0x000000018062BBE0-0x000000018062BBF0
		private void OnEnable() {} // 0x0000000180629E00-0x0000000180629E50
		private void OnDisable() {} // 0x0000000180629AC0-0x0000000180629E00
		private void OnValidate() {} // 0x000000018062BBC0-0x000000018062BBD0
		private static Texture2D GenerateIdentityLut(int dim) => default; // 0x0000000180629160-0x0000000180629410
		private float StandardIlluminantY(float x) => default; // 0x000000018062BBF0-0x000000018062BC20
		private Vector3 CIExyToLMS(float x, float y) => default; // 0x0000000180628C10-0x0000000180628CB0
		private Vector3 GetWhiteBalance() => default; // 0x00000001806297F0-0x00000001806299A0
		private static Color NormalizeColor(Color c) => default; // 0x00000001806299A0-0x0000000180629AC0
		private void GenerateLiftGammaGain(out Color lift, out Color gamma, out Color gain) {
			lift = default;
			gamma = default;
			gain = default;
		} // 0x0000000180629410-0x00000001806297F0
		private void GenCurveTexture() {} // 0x0000000180628EA0-0x0000000180629160
		private bool CheckUserLut() => default; // 0x0000000180628DC0-0x0000000180628EA0
		private bool CheckSmallAdaptiveRt() => default; // 0x0000000180628CB0-0x0000000180628DC0
		private void OnGUI() {} // 0x0000000180629E50-0x000000018062A0F0
		[ImageEffectTransformsToLDR] // 0x00000001800D4E50-0x00000001800D4E60
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x000000018062A0F0-0x000000018062BBC0
		public Texture2D BakeLUT() => default; // 0x0000000180628A80-0x0000000180628C10
	}
}
