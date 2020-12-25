/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 28: UnityEngine.ParticleSystemModule.dll - Assembly: UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3950-3964

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800F65B0-0x00000001800F6730
	// [NativeHeader] // 0x00000001800F65B0-0x00000001800F6730
	// [NativeHeader] // 0x00000001800F65B0-0x00000001800F6730
	// [NativeHeader] // 0x00000001800F65B0-0x00000001800F6730
	// [NativeHeader] // 0x00000001800F65B0-0x00000001800F6730
	// [NativeHeader] // 0x00000001800F65B0-0x00000001800F6730
	// [NativeHeader] // 0x00000001800F65B0-0x00000001800F6730
	// [NativeHeader] // 0x00000001800F65B0-0x00000001800F6730
	// [RequireComponent] // 0x00000001800F65B0-0x00000001800F6730
	[UsedByNativeCode] // 0x00000001800F65B0-0x00000001800F6730
	public sealed class ParticleSystem : Component // TypeDefIndex: 3951
	{
		// Properties
		[Obsolete] // 0x00000001800F71C0-0x00000001800F71F0
		public bool enableEmission { set {} } // 0x0000000180AF2C90-0x0000000180AF2CF0
		[Obsolete] // 0x00000001800F7220-0x00000001800F7250
		public float startLifetime { get => default; } // 0x0000000180AF2C40-0x0000000180AF2C90 
		public bool isStopped { /* [NativeName] */ /* 0x00000001800F6C50-0x00000001800F6C80 */ get => default; } // 0x0000000180AF2C00-0x0000000180AF2C40 
		public bool isPaused { /* [NativeName] */ /* 0x00000001800F6C80-0x00000001800F6CB0 */ get => default; } // 0x0000000180AF2BC0-0x0000000180AF2C00 
		public MainModule main { get => default; } // 0x00000001803A5270-0x00000001803A5290 
		public EmissionModule emission { get => default; } // 0x00000001803A5270-0x00000001803A5290 
	
		// Nested types
		public struct MainModule // TypeDefIndex: 3952
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public float startLifetimeMultiplier { get => default; set {} } // 0x000000018004E4A0-0x000000018004E4E0 0x000000018004E5C0-0x000000018004E610
			public MinMaxCurve startSpeed { set {} } // 0x000000018004E6B0-0x000000018004E720
			public float startSpeedMultiplier { get => default; set {} } // 0x000000018004E520-0x000000018004E560 0x000000018004E660-0x000000018004E6B0
			// [NativeName] // 0x00000001800F72D0-0x00000001800F7300
			public float startSizeMultiplier { get => default; set {} } // 0x000000018004E4E0-0x000000018004E520 0x000000018004E610-0x000000018004E660
			public MinMaxGradient startColor { get => default; set {} } // 0x000000018004E410-0x000000018004E4A0 0x000000018004E560-0x000000018004E5C0
	
			// Constructors
			internal MainModule(ParticleSystem particleSystem) : this() {
				m_ParticleSystem = default;
			} // 0x000000018000A570-0x000000018000A580
	
			// Methods
			private static float get_startLifetimeMultiplier_Injected(ref MainModule _unity_self) => default; // 0x0000000180AF1F30-0x0000000180AF1F70
			private static void set_startLifetimeMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x0000000180AF2090-0x0000000180AF20E0
			private static void set_startSpeed_Injected(ref MainModule _unity_self, ref MinMaxCurve value) {} // 0x0000000180AF2180-0x0000000180AF2270
			private static float get_startSpeedMultiplier_Injected(ref MainModule _unity_self) => default; // 0x0000000180AF1FB0-0x0000000180AF1FF0
			private static void set_startSpeedMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x0000000180AF2130-0x0000000180AF2180
			private static float get_startSizeMultiplier_Injected(ref MainModule _unity_self) => default; // 0x0000000180AF1F70-0x0000000180AF1FB0
			private static void set_startSizeMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x0000000180AF20E0-0x0000000180AF2130
			private static void get_startColor_Injected(ref MainModule _unity_self, out MinMaxGradient ret) {
				ret = default;
			} // 0x0000000180AF1E50-0x0000000180AF1F30
			private static void set_startColor_Injected(ref MainModule _unity_self, ref MinMaxGradient value) {} // 0x0000000180AF1FF0-0x0000000180AF2090
		}
	
		public struct EmissionModule // TypeDefIndex: 3953
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public bool enabled { set {} } // 0x000000018004E130-0x000000018004E180
			public MinMaxCurve rateOverTime { set {} } // 0x000000018004E180-0x000000018004E410
	
			// Constructors
			internal EmissionModule(ParticleSystem particleSystem) : this() {
				m_ParticleSystem = default;
			} // 0x000000018000A570-0x000000018000A580
	
			// Methods
			private static void set_enabled_Injected(ref EmissionModule _unity_self, bool value) {} // 0x0000000180AF1D60-0x0000000180AF1DB0
			private static void set_rateOverTime_Injected(ref EmissionModule _unity_self, ref MinMaxCurve value) {} // 0x0000000180AF1DB0-0x0000000180AF1E50
		}
	
		[RequiredByNativeCode] // 0x00000001800F73F0-0x00000001800F7430
		public struct Particle // TypeDefIndex: 3954
		{
			// Fields
			private Vector3 m_Position; // 0x00
			private Vector3 m_Velocity; // 0x0C
			private Vector3 m_AnimatedVelocity; // 0x18
			private Vector3 m_InitialVelocity; // 0x24
			private Vector3 m_AxisOfRotation; // 0x30
			private Vector3 m_Rotation; // 0x3C
			private Vector3 m_AngularVelocity; // 0x48
			private Vector3 m_StartSize; // 0x54
			private Color32 m_StartColor; // 0x60
			private uint m_RandomSeed; // 0x64
			private uint m_ParentRandomSeed; // 0x68
			private float m_Lifetime; // 0x6C
			private float m_StartLifetime; // 0x70
			private int m_MeshIndex; // 0x74
			private float m_EmitAccumulator0; // 0x78
			private float m_EmitAccumulator1; // 0x7C
			private uint m_Flags; // 0x80
	
			// Properties
			[Obsolete] // 0x00000001800F7530-0x00000001800F7560
			public float lifetime { set {} } // 0x000000018004E8E0-0x000000018004E8F0
			public Vector3 position { set {} } // 0x000000018003BF20-0x000000018003BF30
			public Vector3 velocity { set {} } // 0x00000001800437A0-0x00000001800437B0
			public float remainingLifetime { set {} } // 0x000000018004E8E0-0x000000018004E8F0
			public float startLifetime { set {} } // 0x000000018004E9B0-0x000000018004E9C0
			public Color32 startColor { set {} } // 0x000000018004E9A0-0x000000018004E9B0
			public uint randomSeed { set {} } // 0x000000018004E8F0-0x000000018004E900
			public float startSize { set {} } // 0x000000018004E9C0-0x000000018004EBC0
			public Vector3 rotation3D { set {} } // 0x000000018004E900-0x000000018004E9A0
			public Vector3 angularVelocity3D { set {} } // 0x000000018004E840-0x000000018004E8E0
		}
	
		[Serializable]
		[NativeType] // 0x00000001800F7640-0x00000001800F7690
		public struct MinMaxCurve // TypeDefIndex: 3955
		{
			// Fields
			[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
			private ParticleSystemCurveMode m_Mode; // 0x00
			[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
			private float m_CurveMultiplier; // 0x04
			[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
			private AnimationCurve m_CurveMin; // 0x08
			[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
			private AnimationCurve m_CurveMax; // 0x10
			[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
			private float m_ConstantMin; // 0x18
			[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
			private float m_ConstantMax; // 0x1C
	
			// Constructors
			public MinMaxCurve(float constant) {
				m_Mode = default;
				m_CurveMultiplier = default;
				m_CurveMin = default;
				m_CurveMax = default;
				m_ConstantMin = default;
				m_ConstantMax = default;
			} // 0x000000018004E720-0x000000018004E770
	
			// Methods
			public static implicit operator MinMaxCurve(float constant) => default; // 0x0000000180AF2270-0x0000000180AF22F0
		}
	
		[Serializable]
		[NativeType] // 0x00000001800F7BE0-0x00000001800F7C30
		public struct MinMaxGradient // TypeDefIndex: 3956
		{
			// Fields
			[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
			private ParticleSystemGradientMode m_Mode; // 0x00
			[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
			private Gradient m_GradientMin; // 0x08
			[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
			private Gradient m_GradientMax; // 0x10
			[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
			private Color m_ColorMin; // 0x18
			[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
			private Color m_ColorMax; // 0x28
	
			// Properties
			public Color color { get => default; } // 0x000000018004E7D0-0x000000018004E7E0 
	
			// Constructors
			public MinMaxGradient(Color color) : this() {
				m_Mode = default;
				m_GradientMin = default;
				m_GradientMax = default;
				m_ColorMin = default;
				m_ColorMax = default;
			} // 0x000000018004E770-0x000000018004E7D0
	
			// Methods
			public static implicit operator MinMaxGradient(Color color) => default; // 0x0000000180AF22F0-0x0000000180AF23A0
		}
	
		public struct EmitParams // TypeDefIndex: 3957
		{
			// Fields
			// [NativeName] // 0x00000001800F82A0-0x00000001800F82D0
			private Particle m_Particle; // 0x00
			// [NativeName] // 0x00000001800F8680-0x00000001800F86B0
			private bool m_PositionSet; // 0x84
			// [NativeName] // 0x00000001800F86B0-0x00000001800F86E0
			private bool m_VelocitySet; // 0x85
			// [NativeName] // 0x00000001800F8890-0x00000001800F88C0
			private bool m_AxisOfRotationSet; // 0x86
			// [NativeName] // 0x00000001800F89B0-0x00000001800F89E0
			private bool m_RotationSet; // 0x87
			// [NativeName] // 0x00000001800F8B30-0x00000001800F8B60
			private bool m_AngularVelocitySet; // 0x88
			// [NativeName] // 0x00000001800F8D40-0x00000001800F8D70
			private bool m_StartSizeSet; // 0x89
			// [NativeName] // 0x00000001800F8E60-0x00000001800F8E90
			private bool m_StartColorSet; // 0x8A
			// [NativeName] // 0x00000001800F9070-0x00000001800F90A0
			private bool m_RandomSeedSet; // 0x8B
			// [NativeName] // 0x00000001800F9110-0x00000001800F9140
			private bool m_StartLifetimeSet; // 0x8C
			// [NativeName] // 0x00000001800F92B0-0x00000001800F92E0
			private bool m_MeshIndexSet; // 0x8D
			// [NativeName] // 0x00000001800F9400-0x00000001800F9430
			private bool m_ApplyShapeToPosition; // 0x8E
		}
	
		// Constructors
		public ParticleSystem() {} // Dummy constructor
	
		// Methods
		[Obsolete] // 0x00000001800F6BF0-0x00000001800F6C20
		public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) {} // 0x0000000180AF2710-0x0000000180AF2950
		[Obsolete] // 0x00000001800F6C20-0x00000001800F6C50
		public void Emit(Particle particle) {} // 0x0000000180AF26C0-0x0000000180AF2710
		[FreeFunction] // 0x00000001800F6CE0-0x00000001800F6D20
		public void Play(bool withChildren) {} // 0x0000000180AF2A80-0x0000000180AF2AD0
		public void Play() {} // 0x0000000180AF2A40-0x0000000180AF2A80
		[FreeFunction] // 0x00000001800F6DE0-0x00000001800F6E20
		public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) {} // 0x0000000180AF2B10-0x0000000180AF2B70
		public void Stop(bool withChildren) {} // 0x0000000180AF2B70-0x0000000180AF2BC0
		public void Stop() {} // 0x0000000180AF2AD0-0x0000000180AF2B10
		[FreeFunction] // 0x00000001800F6E80-0x00000001800F6EC0
		public void Clear(bool withChildren) {} // 0x0000000180AF2540-0x0000000180AF2590
		public void Clear() {} // 0x0000000180AF2590-0x0000000180AF25D0
		[FreeFunction] // 0x00000001800F6F90-0x00000001800F6FD0
		public bool IsAlive(bool withChildren) => default; // 0x0000000180AF29F0-0x0000000180AF2A40
		public bool IsAlive() => default; // 0x0000000180AF29B0-0x0000000180AF29F0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		public void Emit(int count) {} // 0x0000000180AF2680-0x0000000180AF26C0
		// [NativeName] // 0x00000001800F7050-0x00000001800F7080
		private void Emit_Internal(int count) {} // 0x0000000180AF2680-0x0000000180AF26C0
		// [NativeName] // 0x00000001800F7080-0x00000001800F70B0
		public void Emit(EmitParams emitParams, int count) {} // 0x0000000180AF2950-0x0000000180AF29B0
		// [NativeName] // 0x00000001800F7190-0x00000001800F71C0
		private void EmitOld_Internal(ref Particle particle) {} // 0x0000000180AF25D0-0x0000000180AF2620
		private void Emit_Injected(ref EmitParams emitParams, int count) {} // 0x0000000180AF2620-0x0000000180AF2680
	}
}
