/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 51: PhotonUnityNetworking.dll - Assembly: PhotonUnityNetworking, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5293-5359

namespace Photon.Pun
{
	// [AddComponentMenu] // 0x000000018010BA70-0x000000018010BAA0
	public class PhotonAnimatorView : MonoBehaviourPun, IPunObservable // TypeDefIndex: 5331
	{
		// Fields
		private bool TriggerUsageWarningDone; // 0x20
		private Animator m_Animator; // 0x28
		private PhotonStreamQueue m_StreamQueue; // 0x30
		[HideInInspector] // 0x00000001800D5490-0x00000001800D54C0
		[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
		private bool ShowLayerWeightsInspector; // 0x38
		[HideInInspector] // 0x00000001800D5490-0x00000001800D54C0
		[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
		private bool ShowParameterInspector; // 0x39
		[HideInInspector] // 0x00000001800D5490-0x00000001800D54C0
		[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
		private List<SynchronizedParameter> m_SynchronizeParameters; // 0x40
		[HideInInspector] // 0x00000001800D5490-0x00000001800D54C0
		[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
		private List<SynchronizedLayer> m_SynchronizeLayers; // 0x48
		private Vector3 m_ReceiverPosition; // 0x50
		private float m_LastDeserializeTime; // 0x5C
		private bool m_WasSynchronizeTypeChanged; // 0x60
		private List<string> m_raisedDiscreteTriggersCache; // 0x68
	
		// Nested types
		public enum ParameterType // TypeDefIndex: 5332
		{
			Float = 1,
			Int = 3,
			Bool = 4,
			Trigger = 9
		}
	
		public enum SynchronizeType // TypeDefIndex: 5333
		{
			Disabled = 0,
			Discrete = 1,
			Continuous = 2
		}
	
		[Serializable]
		public class SynchronizedParameter // TypeDefIndex: 5334
		{
			// Fields
			public ParameterType Type; // 0x10
			public SynchronizeType SynchronizeType; // 0x14
			public string Name; // 0x18
	
			// Constructors
			public SynchronizedParameter() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		[Serializable]
		public class SynchronizedLayer // TypeDefIndex: 5335
		{
			// Fields
			public SynchronizeType SynchronizeType; // 0x10
			public int LayerIndex; // 0x14
	
			// Constructors
			public SynchronizedLayer() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		// Constructors
		public PhotonAnimatorView() {} // 0x000000018059E8B0-0x000000018059E9B0
	
		// Methods
		private void Awake() {} // 0x000000018059CB30-0x000000018059CB80
		private void Update() {} // 0x000000018059E630-0x000000018059E8B0
		public void CacheDiscreteTriggers() {} // 0x000000018059CB80-0x000000018059CC70
		public bool DoesLayerSynchronizeTypeExist(int layerIndex) => default; // 0x000000018059D620-0x000000018059D6D0
		public bool DoesParameterSynchronizeTypeExist(string name) => default; // 0x000000018059D6D0-0x000000018059D790
		public List<SynchronizedLayer> GetSynchronizedLayers() => default; // 0x00000001803F7AF0-0x00000001803F7B00
		public List<SynchronizedParameter> GetSynchronizedParameters() => default; // 0x0000000180249A10-0x0000000180249A20
		public SynchronizeType GetLayerSynchronizeType(int layerIndex) => default; // 0x000000018059D790-0x000000018059D880
		public SynchronizeType GetParameterSynchronizeType(string name) => default; // 0x000000018059D880-0x000000018059D980
		public void SetLayerSynchronized(int layerIndex, SynchronizeType synchronizeType) {} // 0x000000018059E370-0x000000018059E4C0
		public void SetParameterSynchronized(string name, ParameterType type, SynchronizeType synchronizeType) {} // 0x000000018059E4C0-0x000000018059E630
		private void SerializeDataContinuously() {} // 0x000000018059DAC0-0x000000018059DE50
		private void DeserializeDataContinuously() {} // 0x000000018059CC70-0x000000018059D010
		private void SerializeDataDiscretly(PhotonStream stream) {} // 0x000000018059DE50-0x000000018059E190
		private void DeserializeDataDiscretly(PhotonStream stream) {} // 0x000000018059D010-0x000000018059D450
		private void SerializeSynchronizationTypeState(PhotonStream stream) {} // 0x000000018059E190-0x000000018059E370
		private void DeserializeSynchronizationTypeState(PhotonStream stream) {} // 0x000000018059D450-0x000000018059D620
		public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {} // 0x000000018059D980-0x000000018059DAC0
	}
}
