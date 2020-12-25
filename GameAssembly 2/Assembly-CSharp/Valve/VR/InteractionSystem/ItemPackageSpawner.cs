/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	// [RequireComponent] // 0x000000018013B2A0-0x000000018013B2F0
	public class ItemPackageSpawner : MonoBehaviour // TypeDefIndex: 8379
	{
		// Fields
		public ItemPackage _itemPackage; // 0x18
		private bool useItemPackagePreview; // 0x20
		private bool useFadedPreview; // 0x21
		private GameObject previewObject; // 0x28
		public bool requireTriggerPressToTake; // 0x30
		public bool requireTriggerPressToReturn; // 0x31
		public bool showTriggerHint; // 0x32
		[EnumFlags] // 0x0000000180107390-0x00000001801073A0
		public Hand.AttachmentFlags attachmentFlags; // 0x34
		public string attachmentPoint; // 0x38
		public bool takeBackItem; // 0x40
		public bool acceptDifferentItems; // 0x41
		private GameObject spawnedItem; // 0x48
		private bool itemIsSpawned; // 0x50
		public UnityEvent pickupEvent; // 0x58
		public UnityEvent dropEvent; // 0x60
		public bool justPickedUpItem; // 0x68
	
		// Properties
		public ItemPackage itemPackage { get => default; set {} } // 0x0000000180246BC0-0x0000000180246BD0 0x0000000180FC6D70-0x0000000180FC6D80
	
		// Constructors
		public ItemPackageSpawner() {} // 0x0000000180FC6D50-0x0000000180FC6D70
	
		// Methods
		private void CreatePreviewObject() {} // 0x0000000180FC5E60-0x0000000180FC60E0
		private void Start() {} // 0x0000000180FC6B90-0x0000000180FC6C50
		private void VerifyItemPackage() {} // 0x0000000180FC6B90-0x0000000180FC6C50
		private void ItemPackageNotValid() {} // 0x0000000180FC6210-0x0000000180FC62E0
		private void ClearPreview() {} // 0x0000000180FC5C30-0x0000000180FC5E60
		private void Update() {} // 0x0000000180FC6CB0-0x0000000180FC6D50
		private void OnHandHoverBegin(Hand hand) {} // 0x0000000180FC62E0-0x0000000180FC63D0
		private void TakeBackItem(Hand hand) {} // 0x0000000180FC6C50-0x0000000180FC6CB0
		private ItemPackage GetAttachedItemPackage(Hand hand) => default; // 0x0000000180FC60E0-0x0000000180FC61C0
		private void HandHoverUpdate(Hand hand) {} // 0x0000000180FC61C0-0x0000000180FC6210
		private void OnHandHoverEnd(Hand hand) {} // 0x0000000180FC63D0-0x0000000180FC6420
		private void RemoveMatchingItemsFromHandStack(ItemPackage package, Hand hand) {} // 0x0000000180FC65E0-0x0000000180FC6800
		private void RemoveMatchingItemTypesFromHand(ItemPackage.ItemPackageType packageType, Hand hand) {} // 0x0000000180FC6420-0x0000000180FC65E0
		private void SpawnAndAttachObject(Hand hand) {} // 0x0000000180FC6800-0x0000000180FC6B90
	}
}
