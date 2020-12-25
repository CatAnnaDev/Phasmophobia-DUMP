/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using Valve.VR;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public static class SteamVR_Events // TypeDefIndex: 7268
{
	// Fields
	public static Event<bool> Calibrating; // 0x00
	public static Event<int, bool> DeviceConnected; // 0x08
	public static Event<Color, float, bool> Fade; // 0x10
	public static Event FadeReady; // 0x18
	public static Event<bool> HideRenderModels; // 0x20
	public static Event<bool> Initializing; // 0x28
	public static Event<bool> InputFocus; // 0x30
	public static Event<bool> Loading; // 0x38
	public static Event<float> LoadingFadeIn; // 0x40
	public static Event<float> LoadingFadeOut; // 0x48
	public static Event<TrackedDevicePose_t[]> NewPoses; // 0x50
	public static Event NewPosesApplied; // 0x58
	public static Event<bool> OutOfRange; // 0x60
	public static Event<SteamVR_RenderModel, bool> RenderModelLoaded; // 0x68
	private static Dictionary<EVREventType, Event<VREvent_t>> systemEvents; // 0x70

	// Nested types
	public abstract class Action // TypeDefIndex: 7269
	{
		// Properties
		public bool enabled { get; set; } // 0x0000000180AD31F0-0x0000000180AD3210

		// Constructors
		protected Action() {} // 0x00000001802466A0-0x00000001802466B0

		// Methods
		public abstract void Enable(bool enabled);
	}

	[Serializable]
	public class ActionNoArgs : Action // TypeDefIndex: 7270
	{
		// Fields
		private Event _event; // 0x10
		private UnityAction action; // 0x18

		// Constructors
		public ActionNoArgs() {} // Dummy constructor
		public ActionNoArgs(Event _event, UnityAction action) {} // 0x0000000180294750-0x00000001802947A0

		// Methods
		public override void Enable(bool enabled) {} // 0x0000000180CB8250-0x0000000180CB8290
	}

	[Serializable]
	public class Action<T> : Action // TypeDefIndex: 7271
	{
		// Fields
		private Event<T> _event;
		private UnityAction<T> action;

		// Constructors
		public Action() {} // Dummy constructor
		public Action(Event<T> _event, UnityAction<T> action) {}

		// Methods
		public override void Enable(bool enabled) {}
	}

	[Serializable]
	public class Action<T0, T1> : Action // TypeDefIndex: 7272
	{
		// Fields
		private Event<T0, T1> _event;
		private UnityAction<T0, T1> action;

		// Constructors
		public Action() {} // Dummy constructor
		public Action(Event<T0, T1> _event, UnityAction<T0, T1> action) {}

		// Methods
		public override void Enable(bool enabled) {}
	}

	[Serializable]
	public class Action<T0, T1, T2> : Action // TypeDefIndex: 7273
	{
		// Fields
		private Event<T0, T1, T2> _event;
		private UnityAction<T0, T1, T2> action;

		// Constructors
		public Action() {} // Dummy constructor
		public Action(Event<T0, T1, T2> _event, UnityAction<T0, T1, T2> action) {}

		// Methods
		public override void Enable(bool enabled) {}
	}

	public class Event : UnityEvent // TypeDefIndex: 7274
	{
		// Constructors
		public Event() {} // 0x00000001803B3D60-0x00000001803B3D70

		// Methods
		public void Listen(UnityAction action) {} // 0x0000000180CB8E80-0x0000000180CB8E90
		public void Remove(UnityAction action) {} // 0x0000000180CB8E90-0x0000000180CB8EA0
		public void Send() {} // 0x0000000180CB8EA0-0x0000000180CB8EB0
	}

	public class Event<T> : UnityEvent<T> // TypeDefIndex: 7275
	{
		// Constructors
		public Event() {}

		// Methods
		public void Listen(UnityAction<T> action) {}
		public void Remove(UnityAction<T> action) {}
		public void Send(T arg0) {}
	}

	public class Event<T0, T1> : UnityEvent<T0, T1> // TypeDefIndex: 7276
	{
		// Constructors
		public Event() {}

		// Methods
		public void Listen(UnityAction<T0, T1> action) {}
		public void Remove(UnityAction<T0, T1> action) {}
		public void Send(T0 arg0, T1 arg1) {}
	}

	public class Event<T0, T1, T2> : UnityEvent<T0, T1, T2> // TypeDefIndex: 7277
	{
		// Constructors
		public Event() {}

		// Methods
		public void Listen(UnityAction<T0, T1, T2> action) {}
		public void Remove(UnityAction<T0, T1, T2> action) {}
		public void Send(T0 arg0, T1 arg1, T2 arg2) {}
	}

	// Constructors
	static SteamVR_Events() {} // 0x0000000180CBD840-0x0000000180CBDBD0

	// Methods
	public static Action CalibratingAction(UnityAction<bool> action) => default; // 0x0000000180CBCDC0-0x0000000180CBCE60
	public static Action DeviceConnectedAction(UnityAction<int, bool> action) => default; // 0x0000000180CBCE60-0x0000000180CBCF00
	public static Action FadeAction(UnityAction<Color, float, bool> action) => default; // 0x0000000180CBCF00-0x0000000180CBCFA0
	public static Action FadeReadyAction(UnityAction action) => default; // 0x0000000180CBCFA0-0x0000000180CBD050
	public static Action HideRenderModelsAction(UnityAction<bool> action) => default; // 0x0000000180CBD050-0x0000000180CBD0F0
	public static Action InitializingAction(UnityAction<bool> action) => default; // 0x0000000180CBD0F0-0x0000000180CBD190
	public static Action InputFocusAction(UnityAction<bool> action) => default; // 0x0000000180CBD190-0x0000000180CBD230
	public static Action LoadingAction(UnityAction<bool> action) => default; // 0x0000000180CBD230-0x0000000180CBD2D0
	public static Action LoadingFadeInAction(UnityAction<float> action) => default; // 0x0000000180CBD2D0-0x0000000180CBD370
	public static Action LoadingFadeOutAction(UnityAction<float> action) => default; // 0x0000000180CBD370-0x0000000180CBD410
	public static Action NewPosesAction(UnityAction<TrackedDevicePose_t[]> action) => default; // 0x0000000180CBD410-0x0000000180CBD4B0
	public static Action NewPosesAppliedAction(UnityAction action) => default; // 0x0000000180CBD4B0-0x0000000180CBD560
	public static Action OutOfRangeAction(UnityAction<bool> action) => default; // 0x0000000180CBD560-0x0000000180CBD600
	public static Action RenderModelLoadedAction(UnityAction<SteamVR_RenderModel, bool> action) => default; // 0x0000000180CBD600-0x0000000180CBD6A0
	public static Event<VREvent_t> System(EVREventType eventType) => default; // 0x0000000180CBD730-0x0000000180CBD840
	public static Action SystemAction(EVREventType eventType, UnityAction<VREvent_t> action) => default; // 0x0000000180CBD6A0-0x0000000180CBD730
}

