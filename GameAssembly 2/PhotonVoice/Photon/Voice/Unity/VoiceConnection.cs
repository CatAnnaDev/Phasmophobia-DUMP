/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;
using Photon.Voice;
using UnityEngine;
using UnityEngine.Serialization;

// Image 52: PhotonVoice.dll - Assembly: PhotonVoice, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5360-5410

namespace Photon.Voice.Unity
{
	// [AddComponentMenu] // 0x0000000180113210-0x0000000180113270
	// [HelpURL] // 0x0000000180113210-0x0000000180113270
	public class VoiceConnection : ConnectionHandler, ILoggable // TypeDefIndex: 5388
	{
		// Fields
		private VoiceLogger logger; // 0x38
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private DebugLevel logLevel; // 0x40
		private const string PlayerPrefsKey = "VoiceCloudBestRegion"; // Metadata: 0x0064FA3B
		private LoadBalancingTransport client; // 0x48
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool enableSupportLogger; // 0x50
		private SupportLogger supportLoggerComponent; // 0x58
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private int updateInterval; // 0x60
		private int nextSendTickCount; // 0x64
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool runInBackground; // 0x68
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private int statsResetInterval; // 0x6C
		private int nextStatsTickCount; // 0x70
		private float statsReferenceTime; // 0x74
		private int referenceFramesLost; // 0x78
		private int referenceFramesReceived; // 0x7C
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GameObject speakerPrefab; // 0x80
		private bool cleanedUp; // 0x88
		protected List<RemoteVoiceLink> cachedRemoteVoices; // 0x90
		// [FormerlySerializedAs] // 0x00000001801135B0-0x0000000180113600
		[SerializeField] // 0x00000001801135B0-0x0000000180113600
		private Recorder primaryRecorder; // 0x98
		private bool primaryRecorderInitialized; // 0xA0
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private DebugLevel globalRecordersLogLevel; // 0xA1
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private DebugLevel globalSpeakersLogLevel; // 0xA2
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private int globalPlaybackDelay; // 0xA4
		private List<Speaker> linkedSpeakers; // 0xA8
		public AppSettings Settings; // 0xB0
		public Func<int, byte, object, Speaker> SpeakerFactory; // 0xB8
		public float MinimalTimeScaleToDispatchInFixedUpdate; // 0xD0
		public bool AutoCreateSpeakerIfNotFound; // 0xD4
	
		// Properties
		public VoiceLogger Logger { get => default; protected set {} } // 0x0000000180F56800-0x0000000180F56910 0x0000000180278400-0x0000000180278410
		public DebugLevel LogLevel { get => default; set {} } // 0x0000000180F567C0-0x0000000180F56800 0x0000000180F56D10-0x0000000180F56D50
		public new LoadBalancingTransport Client { get => default; } // 0x0000000180F56540-0x0000000180F56770 
		public VoiceClient VoiceClient { get => default; } // 0x0000000180F56950-0x0000000180F56980 
		public ClientState ClientState { get => default; } // 0x0000000180F56510-0x0000000180F56540 
		public float FramesReceivedPerSecond { get; private set; } // 0x0000000180F56790-0x0000000180F567A0 0x0000000180F56B40-0x0000000180F56B50
		public float FramesLostPerSecond { get; private set; } // 0x0000000180F56770-0x0000000180F56780 0x0000000180F56B20-0x0000000180F56B30
		public float FramesLostPercent { get; private set; } // 0x0000000180F56780-0x0000000180F56790 0x0000000180F56B30-0x0000000180F56B40
		public GameObject SpeakerPrefab { get => default; set {} } // 0x0000000180274900-0x0000000180274910 0x0000000180F56D80-0x0000000180F56EF0
		public Recorder PrimaryRecorder { get => default; set {} } // 0x0000000180F56910-0x0000000180F56950 0x0000000180F56D50-0x0000000180F56D80
		public DebugLevel GlobalRecordersLogLevel { get => default; set {} } // 0x0000000180F567A0-0x0000000180F567B0 0x0000000180F56C10-0x0000000180F56C20
		public DebugLevel GlobalSpeakersLogLevel { get => default; set {} } // 0x0000000180F567B0-0x0000000180F567C0 0x0000000180F56C20-0x0000000180F56D10
		public int GlobalPlaybackDelay { get => default; set {} } // 0x00000001807FB910-0x00000001807FB920 0x0000000180F56B50-0x0000000180F56C10
		public string BestRegionSummaryInPreferences { get => default; set {} } // 0x0000000180F564D0-0x0000000180F56510 0x0000000180F56AC0-0x0000000180F56B20
	
		// Events
		public event Action<Speaker> SpeakerLinked;
		public event Action<RemoteVoiceLink> RemoteVoiceAdded;
	
		// Constructors
		public VoiceConnection() {} // 0x0000000180F562B0-0x0000000180F56390
	
		// Methods
		public bool ConnectUsingSettings(AppSettings overwriteSettings = null) => default; // 0x0000000180F54170-0x0000000180F54690
		public void InitRecorder(Recorder rec) {} // 0x0000000180F547E0-0x0000000180F548B0
		protected override void Awake() {} // 0x0000000180F53B20-0x0000000180F53C40
		protected virtual void Update() {} // 0x0000000180F56280-0x0000000180F562B0
		protected virtual void FixedUpdate() {} // 0x0000000180F54790-0x0000000180F547E0
		protected void Dispatch() {} // 0x0000000180F54790-0x0000000180F547E0
		private void LateUpdate() {} // 0x0000000180F548B0-0x0000000180F54AC0
		protected override void OnDisable() {} // 0x0000000180F55100-0x0000000180F55180
		protected virtual void OnDestroy() {} // 0x0000000180F550F0-0x0000000180F55100
		protected virtual Speaker SimpleSpeakerFactory(int playerId, byte voiceId, object userData) => default; // 0x0000000180F55E40-0x0000000180F561D0
		internal void DeleteVoiceOnRemoteVoiceRemove(Speaker speaker) {} // 0x0000000180F54690-0x0000000180F54790
		private void OnRemoteVoiceInfo(int channelId, int playerId, byte voiceId, VoiceInfo voiceInfo, ref RemoteVoiceOptions options) {} // 0x0000000180F55180-0x0000000180F55A60
		protected virtual void OnVoiceStateChanged(ClientState fromState, ClientState toState) {} // 0x0000000180F55A60-0x0000000180F55E40
		protected void CalcStatistics() {} // 0x0000000180F53C40-0x0000000180F53D80
		private void CleanUp() {} // 0x0000000180F53D80-0x0000000180F54010
		protected void LinkSpeaker(Speaker speaker, RemoteVoiceLink remoteVoice) {} // 0x0000000180F54AC0-0x0000000180F550F0
		private void ClearRemoteVoicesCache() {} // 0x0000000180F54010-0x0000000180F54170
		private void TryInitializePrimaryRecorder() {} // 0x0000000180F561D0-0x0000000180F56280
	}
}
