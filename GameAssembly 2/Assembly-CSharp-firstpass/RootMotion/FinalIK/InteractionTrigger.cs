/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.FinalIK
{
	// [AddComponentMenu] // 0x00000001800F4B20-0x00000001800F4B80
	// [HelpURL] // 0x00000001800F4B20-0x00000001800F4B80
	public class InteractionTrigger : MonoBehaviour // TypeDefIndex: 6769
	{
		// Fields
		// [Tooltip] // 0x00000001800F4C60-0x00000001800F4C90
		public Range[] ranges; // 0x18
	
		// Nested types
		[Serializable]
		public class CharacterPosition // TypeDefIndex: 6770
		{
			// Fields
			// [Tooltip] // 0x00000001800F4F10-0x00000001800F4F40
			public bool use; // 0x10
			// [Tooltip] // 0x00000001800F5010-0x00000001800F5040
			public Vector2 offset; // 0x14
			// [Range] // 0x00000001800F50A0-0x00000001800F5100
			// [Tooltip] // 0x00000001800F50A0-0x00000001800F5100
			public float angleOffset; // 0x1C
			// [Range] // 0x00000001800F52F0-0x00000001800F5350
			// [Tooltip] // 0x00000001800F52F0-0x00000001800F5350
			public float maxAngle; // 0x20
			// [Tooltip] // 0x00000001800F5460-0x00000001800F5490
			public float radius; // 0x24
			// [Tooltip] // 0x00000001800F5490-0x00000001800F54C0
			public bool orbit; // 0x28
			// [Tooltip] // 0x00000001800F55A0-0x00000001800F55D0
			public bool fixYAxis; // 0x29
	
			// Properties
			public Vector3 offset3D { get => default; } // 0x00000001807DAF80-0x00000001807DAFC0 
			public Vector3 direction3D { get => default; } // 0x00000001807DAE70-0x00000001807DAF80 
	
			// Constructors
			public CharacterPosition() {} // 0x00000001807DAE50-0x00000001807DAE70
	
			// Methods
			public bool IsInRange(Transform character, Transform trigger, out float error) {
				error = default;
				return default;
			} // 0x00000001807DA520-0x00000001807DAE50
		}
	
		[Serializable]
		public class CameraPosition // TypeDefIndex: 6771
		{
			// Fields
			// [Tooltip] // 0x00000001800F56E0-0x00000001800F5710
			public Collider lookAtTarget; // 0x10
			// [Tooltip] // 0x00000001800F5830-0x00000001800F5860
			public Vector3 direction; // 0x18
			// [Tooltip] // 0x00000001800F5910-0x00000001800F5940
			public float maxDistance; // 0x24
			// [Range] // 0x00000001800F5A10-0x00000001800F5A70
			// [Tooltip] // 0x00000001800F5A10-0x00000001800F5A70
			public float maxAngle; // 0x28
			// [Tooltip] // 0x00000001800F5AB0-0x00000001800F5AE0
			public bool fixYAxis; // 0x2C
	
			// Constructors
			public CameraPosition() {} // 0x00000001807DA480-0x00000001807DA520
	
			// Methods
			public Quaternion GetRotation() => default; // 0x00000001807D9F60-0x00000001807DA170
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error) {
				error = default;
				return default;
			} // 0x00000001807DA170-0x00000001807DA480
		}
	
		[Serializable]
		public class Range // TypeDefIndex: 6772
		{
			// Fields
			[HideInInspector] // 0x00000001800D5490-0x00000001800D54C0
			[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
			public string name; // 0x10
			[HideInInspector] // 0x00000001800D5490-0x00000001800D54C0
			[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
			public bool show; // 0x18
			// [Tooltip] // 0x00000001800F5C40-0x00000001800F5C70
			public CharacterPosition characterPosition; // 0x20
			// [Tooltip] // 0x00000001800F5D30-0x00000001800F5D60
			public CameraPosition cameraPosition; // 0x28
			// [Tooltip] // 0x00000001800F5E10-0x00000001800F5E40
			public Interaction[] interactions; // 0x30
	
			// Nested types
			[Serializable]
			public class Interaction // TypeDefIndex: 6773
			{
				// Fields
				// [Tooltip] // 0x00000001800F5EC0-0x00000001800F5EF0
				public InteractionObject interactionObject; // 0x10
				// [Tooltip] // 0x00000001800F5F50-0x00000001800F5F80
				public FullBodyBipedEffector[] effectors; // 0x18
	
				// Constructors
				public Interaction() {} // 0x00000001802466A0-0x00000001802466B0
			}
	
			// Constructors
			public Range() {} // 0x00000001807E9A30-0x00000001807E9A40
	
			// Methods
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError) {
				maxError = default;
				return default;
			} // 0x00000001807E98E0-0x00000001807E9A30
		}
	
		// Constructors
		public InteractionTrigger() {} // 0x00000001807E6890-0x00000001807E68E0
	
		// Methods
		// [ContextMenu] // 0x00000001800F4D60-0x00000001800F4D90
		private void OpenTutorial4() {} // 0x00000001807E6810-0x00000001807E6850
		// [ContextMenu] // 0x00000001800D51F0-0x00000001800D5220
		private void SupportGroup() {} // 0x00000001807E6850-0x00000001807E6890
		// [ContextMenu] // 0x00000001800D5260-0x00000001800D5290
		private void ASThread() {} // 0x00000001807E6560-0x00000001807E65A0
		private void Start() {} // 0x0000000180246DB0-0x0000000180246DC0
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit) => default; // 0x00000001807E65A0-0x00000001807E6810
	}
}
