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
	public class GenericPoser : Poser // TypeDefIndex: 6774
	{
		// Fields
		public Map[] maps; // 0x50
	
		// Nested types
		[Serializable]
		public class Map // TypeDefIndex: 6775
		{
			// Fields
			public Transform bone; // 0x10
			public Transform target; // 0x18
			private Vector3 defaultLocalPosition; // 0x20
			private Quaternion defaultLocalRotation; // 0x2C
	
			// Constructors
			public Map() {} // Dummy constructor
			public Map(Transform bone, Transform target) {} // 0x0000000180539920-0x00000001805399D0
	
			// Methods
			public void StoreDefaultState() {} // 0x00000001805396C0-0x0000000180539720
			public void FixTransform() {} // 0x0000000180539660-0x00000001805396C0
			public void Update(float localRotationWeight, float localPositionWeight) {} // 0x0000000180539720-0x0000000180539920
		}
	
		// Constructors
		public GenericPoser() {} // 0x0000000180532030-0x0000000180532040
	
		// Methods
		// [ContextMenu] // 0x00000001800F5FF0-0x00000001800F6020
		public override void AutoMapping() {} // 0x00000001805317D0-0x0000000180531AB0
		protected override void InitiatePoser() {} // 0x0000000180531C30-0x0000000180531C40
		protected override void UpdatePoser() {} // 0x0000000180531D00-0x0000000180532030
		protected override void FixPoserTransforms() {} // 0x0000000180531AB0-0x0000000180531B80
		private void StoreDefaultState() {} // 0x0000000180531C40-0x0000000180531D00
		private Transform GetTargetNamed(string tName, Transform[] array) => default; // 0x0000000180531B80-0x0000000180531C30
	}
}
