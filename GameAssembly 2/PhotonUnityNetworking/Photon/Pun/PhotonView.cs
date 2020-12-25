/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.Serialization;

// Image 51: PhotonUnityNetworking.dll - Assembly: PhotonUnityNetworking, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5293-5359

namespace Photon.Pun
{
	// [AddComponentMenu] // 0x00000001801081C0-0x00000001801081F0
	public class PhotonView : MonoBehaviour // TypeDefIndex: 5316
	{
		// Fields
		[NonSerialized]
		private int ownerActorNr; // 0x18
		// [FormerlySerializedAs] // 0x00000001801082B0-0x00000001801082E0
		public byte Group; // 0x1C
		protected internal bool mixedModeIsReliable; // 0x1D
		// [FormerlySerializedAs] // 0x0000000180108380-0x00000001801083B0
		public int prefixField; // 0x20
		public ObservableSearch observableSearch; // 0x24
		internal object[] instantiationDataField; // 0x28
		protected internal List<object> lastOnSerializeDataSent; // 0x30
		protected internal List<object> syncValues; // 0x38
		protected internal object[] lastOnSerializeDataReceived; // 0x40
		// [FormerlySerializedAs] // 0x0000000180108480-0x00000001801084B0
		public ViewSynchronization Synchronization; // 0x48
		// [FormerlySerializedAs] // 0x00000001801085B0-0x00000001801085E0
		public OwnershipOption OwnershipTransfer; // 0x4C
		public List<Component> ObservedComponents; // 0x50
		private Queue<CallbackTargetChange> CallbackChangeQueue; // 0x58
		private List<IOnPhotonViewPreNetDestroy> OnPreNetDestroyCallbacks; // 0x60
		private List<IOnPhotonViewOwnerChange> OnOwnerChangeCallbacks; // 0x68
		private List<IOnPhotonViewControllerChange> OnControllerChangeCallbacks; // 0x70
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private int viewIdField; // 0x78
		// [FormerlySerializedAs] // 0x0000000180108820-0x0000000180108850
		public int InstantiationId; // 0x7C
		private Photon.Realtime.Player owner; // 0x80
		private Photon.Realtime.Player controller; // 0x88
		private int controllerActorNr; // 0x90
		internal OwnershipCacheState ownershipCacheIsValid; // 0x94
		private bool amController; // 0x98
		protected internal bool didAwake; // 0x9A
		[HideInInspector] // 0x00000001800D5490-0x00000001800D54C0
		[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
		public bool isRuntimeInstantiated; // 0x9B
		protected internal bool removedFromLocalViewList; // 0x9C
		internal MonoBehaviour[] RpcMonoBehaviours; // 0xA0
	
		// Properties
		public int Prefix { get => default; set {} } // 0x0000000181DC5E30-0x0000000181DC5EE0 0x0000000180293310-0x0000000180293320
		public object[] InstantiationData { get => default; set {} } // 0x0000000181DC59D0-0x0000000181DC5A40 0x0000000180249810-0x0000000180249820
		public int ViewID { get => default; set {} } // 0x00000001804019C0-0x00000001804019D0 0x0000000181DC5EF0-0x0000000181DC5FB0
		public bool IsSceneView { get => default; } // 0x0000000181DC5B80-0x0000000181DC5BF0 
		public Photon.Realtime.Player Owner { get => default; } // 0x0000000181DC5D10-0x0000000181DC5E30 
		public int OwnerActorNr { get => default; } // 0x0000000181DC5BF0-0x0000000181DC5D10 
		public Photon.Realtime.Player Controller { get => default; } // 0x0000000181DC57D0-0x0000000181DC5970 
		public int ControllerActorNr { get => default; } // 0x0000000181DC5630-0x0000000181DC57D0 
		public bool IsOwnerActive { get => default; } // 0x0000000181DC5B40-0x0000000181DC5B80 
		public int CreatorActorNr { get => default; } // 0x0000000181DC5970-0x0000000181DC59D0 
		public bool IsMine { get => default; } // 0x0000000181DC5A40-0x0000000181DC5B40 
		public bool AmOwner { get; private set; } // 0x0000000181DC5620-0x0000000181DC5630 0x0000000181DC5EE0-0x0000000181DC5EF0
	
		// Nested types
		public enum ObservableSearch // TypeDefIndex: 5317
		{
			Manual = 0,
			AutoFindActive = 1,
			AutoFindAll = 2
		}
	
		private struct CallbackTargetChange // TypeDefIndex: 5318
		{
			// Fields
			public IPhotonViewCallback obj; // 0x00
			public Type type; // 0x08
			public bool add; // 0x10
	
			// Constructors
			public CallbackTargetChange(IPhotonViewCallback obj, Type type, bool add) {
				this.obj = default;
				this.type = default;
				this.add = default;
			} // 0x000000018020C290-0x000000018020C300
		}
	
		internal enum OwnershipCacheState // TypeDefIndex: 5319
		{
			Invalid = 0,
			OwnerValid = 1,
			ControllerValid = 2,
			AllValid = 3
		}
	
		// Constructors
		public PhotonView() {} // 0x0000000181DC55A0-0x0000000181DC5620
	
		// Methods
		public void AddCallbackTarget(IPhotonViewCallback obj) {} // 0x0000000181DC2A30-0x0000000181DC2AE0
		public void RemoveCallbackTarget(IPhotonViewCallback obj) {} // 0x0000000181DC3900-0x0000000181DC39B0
		public void AddCallback<T>(IPhotonViewCallback obj)
			where T : class, IPhotonViewCallback {}
		public void RemoveCallback<T>(IPhotonViewCallback obj)
			where T : class, IPhotonViewCallback {}
		private void UpdateCallbackLists() {} // 0x0000000181DC5300-0x0000000181DC55A0
		private void TryRegisterCallback<T>(IPhotonViewCallback obj, ref List<T> list, bool add)
			where T : class, IPhotonViewCallback {}
		private void RegisterCallback<T>(T obj, ref List<T> list, bool add)
			where T : class, IPhotonViewCallback {}
		internal void ResetPhotonView(bool resetOwner) {} // 0x0000000181DC3EE0-0x0000000181DC3F10
		internal void ResetOwnership() {} // 0x0000000181DC3CD0-0x0000000181DC3EE0
		public void SetOwnerInternal(Photon.Realtime.Player newOwner, int newOwnerId) {} // 0x0000000181DC4660-0x0000000181DC4840
		public void SetControllerInternal(int newControllerId) {} // 0x0000000181DC4410-0x0000000181DC44A0
		public void SetControllerInternal(Photon.Realtime.Player newController, int newControllerId) {} // 0x0000000181DC44A0-0x0000000181DC4660
		internal void RebuildControllerCache(bool ownerHasChanged = false /* Metadata: 0x0064F728 */) {} // 0x0000000181DC3680-0x0000000181DC38B0
		protected internal void Awake() {} // 0x0000000181DC2AE0-0x0000000181DC2CB0
		public void FindObservables(bool force = false /* Metadata: 0x0064F729 */) {} // 0x0000000181DC3080-0x0000000181DC31A0
		public void OnPreNetDestroy(PhotonView rootView) {} // 0x0000000181DC3400-0x0000000181DC3560
		protected internal void OnDestroy() {} // 0x0000000181DC32D0-0x0000000181DC3400
		public void RequestOwnership() {} // 0x0000000181DC39B0-0x0000000181DC3CD0
		public void TransferOwnership(Photon.Realtime.Player newOwner) {} // 0x0000000181DC4B50-0x0000000181DC4E50
		public void TransferOwnership(int newOwnerId) {} // 0x0000000181DC4E50-0x0000000181DC5300
		public void SerializeView(PhotonStream stream, PhotonMessageInfo info) {} // 0x0000000181DC42C0-0x0000000181DC4410
		public void DeserializeView(PhotonStream stream, PhotonMessageInfo info) {} // 0x0000000181DC2F40-0x0000000181DC3080
		protected internal void DeserializeComponent(Component component, PhotonStream stream, PhotonMessageInfo info) {} // 0x0000000181DC2CB0-0x0000000181DC2F40
		protected internal void SerializeComponent(Component component, PhotonStream stream, PhotonMessageInfo info) {} // 0x0000000181DC4030-0x0000000181DC42C0
		public void RefreshRpcMonoBehaviourCache() {} // 0x0000000181DC38B0-0x0000000181DC3900
		public void RPC(string methodName, RpcTarget target, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] parameters) {} // 0x0000000181DC35F0-0x0000000181DC3680
		public void RpcSecure(string methodName, RpcTarget target, bool encrypt, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] parameters) {} // 0x0000000181DC3F10-0x0000000181DC3FA0
		public void RPC(string methodName, Photon.Realtime.Player targetPlayer, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] parameters) {} // 0x0000000181DC3560-0x0000000181DC35F0
		public void RpcSecure(string methodName, Photon.Realtime.Player targetPlayer, bool encrypt, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] parameters) {} // 0x0000000181DC3FA0-0x0000000181DC4030
		public static PhotonView Get(Component component) => default; // 0x0000000181DC3260-0x0000000181DC32D0
		public static PhotonView Get(GameObject gameObj) => default; // 0x0000000181DC31F0-0x0000000181DC3260
		public static PhotonView Find(int viewID) => default; // 0x0000000181DC31A0-0x0000000181DC31F0
		public override string ToString() => default; // 0x0000000181DC4840-0x0000000181DC4B50
	}
}
