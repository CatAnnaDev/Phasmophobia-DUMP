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
	public interface IAntiAliasing // TypeDefIndex: 5982
	{
		// Methods
		void OnEnable(AntiAliasing owner);
		void OnDisable();
		void OnPreCull(Camera camera);
		void OnPostRender(Camera camera);
		void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination);
	}
}
