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
	// [AddComponentMenu] // 0x0000000180106910-0x00000001801069B0
	[ExecuteInEditMode] // 0x0000000180106910-0x00000001801069B0
	[ImageEffectAllowedInSceneView] // 0x0000000180106910-0x00000001801069B0
	// [RequireComponent] // 0x0000000180106910-0x00000001801069B0
	public class AntiAliasing : MonoBehaviour // TypeDefIndex: 5975
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private SMAA m_SMAA; // 0x18
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private FXAA m_FXAA; // 0x20
		[HideInInspector] // 0x00000001800D5490-0x00000001800D54C0
		[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
		private int m_Method; // 0x28
		private Camera m_Camera; // 0x30
	
		// Properties
		public int method { get => default; set {} } // 0x000000018026C7E0-0x000000018026C7F0 0x000000018082B4B0-0x000000018082B4C0
		public IAntiAliasing current { get => default; } // 0x000000018082B4A0-0x000000018082B4B0 
		public Camera cameraComponent { get => default; } // 0x000000018082B400-0x000000018082B4A0 
	
		// Nested types
		public enum Method // TypeDefIndex: 5976
		{
			Smaa = 0,
			Fxaa = 1
		}
	
		// Constructors
		public AntiAliasing() {} // 0x000000018082B2C0-0x000000018082B400
	
		// Methods
		private void OnEnable() {} // 0x000000018082B070-0x000000018082B0E0
		private void OnDisable() {} // 0x000000018082AFB0-0x000000018082B070
		private void OnPreCull() {} // 0x000000018082B150-0x000000018082B1C0
		private void OnPostRender() {} // 0x000000018082B0E0-0x000000018082B150
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x000000018082B1C0-0x000000018082B2C0
	}
}
