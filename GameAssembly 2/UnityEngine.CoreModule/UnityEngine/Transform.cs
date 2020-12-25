/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180107570-0x0000000180107600
	// [NativeHeader] // 0x0000000180107570-0x0000000180107600
	// [NativeHeader] // 0x0000000180107570-0x0000000180107600
	[RequiredByNativeCode] // 0x0000000180107570-0x0000000180107600
	public class Transform : Component, IEnumerable // TypeDefIndex: 3325
	{
		// Properties
		public Vector3 position { get => default; set {} } // 0x00000001808E5630-0x00000001808E56A0 0x00000001808E6010-0x00000001808E6060
		public Vector3 localPosition { get => default; set {} } // 0x00000001808E5260-0x00000001808E52D0 0x00000001808E5D80-0x00000001808E5DD0
		public Vector3 eulerAngles { get => default; set {} } // 0x00000001808E4F60-0x00000001808E4FF0 0x00000001808E5AD0-0x00000001808E5B80
		public Vector3 localEulerAngles { get => default; set {} } // 0x00000001808E5180-0x00000001808E5210 0x00000001808E5C80-0x00000001808E5D30
		public Vector3 right { get => default; } // 0x00000001808E56A0-0x00000001808E57F0 
		public Vector3 up { get => default; } // 0x00000001808E58A0-0x00000001808E59F0 
		public Vector3 forward { get => default; set {} } // 0x00000001808E4FF0-0x00000001808E5140 0x00000001808E5B80-0x00000001808E5C30
		public Quaternion rotation { get => default; set {} } // 0x00000001808E5840-0x00000001808E58A0 0x00000001808E60B0-0x00000001808E6100
		public Quaternion localRotation { get => default; set {} } // 0x00000001808E5320-0x00000001808E5380 0x00000001808E5E20-0x00000001808E5E70
		public Vector3 localScale { get => default; set {} } // 0x00000001808E53D0-0x00000001808E5440 0x00000001808E5EC0-0x00000001808E5F10
		public Transform parent { get => default; set {} } // 0x00000001808E3850-0x00000001808E3890 0x00000001808E5F10-0x00000001808E5FC0
		internal Transform parentInternal { get => default; set {} } // 0x00000001808E3850-0x00000001808E3890 0x00000001808E4990-0x00000001808E49E0
		public Matrix4x4 worldToLocalMatrix { get => default; } // 0x00000001808E5A40-0x00000001808E5AD0 
		public Matrix4x4 localToWorldMatrix { get => default; } // 0x00000001808E5490-0x00000001808E5520 
		public Transform root { get => default; } // 0x00000001808E3890-0x00000001808E38D0 
		public int childCount { [NativeMethod] /* 0x0000000180107BB0-0x0000000180107BE0 */ get => default; } // 0x00000001808E4F20-0x00000001808E4F60 
		public Vector3 lossyScale { [NativeMethod] /* 0x0000000180107F70-0x0000000180107FA0 */ get => default; } // 0x00000001808E5570-0x00000001808E55E0 
		[NativeProperty] // 0x00000001801084B0-0x00000001801084E0
		public bool hasChanged { get => default; set {} } // 0x00000001808E5140-0x00000001808E5180 0x00000001808E5C30-0x00000001808E5C80
	
		// Nested types
		private class Enumerator : IEnumerator // TypeDefIndex: 3326
		{
			// Fields
			private Transform outer; // 0x10
			private int currentIndex; // 0x18
	
			// Properties
			public object Current { get => default; } // 0x00000001808D6250-0x00000001808D62A0 
	
			// Constructors
			public Enumerator() {} // Dummy constructor
			internal Enumerator(Transform outer) {} // 0x0000000180245720-0x0000000180245760
	
			// Methods
			public bool MoveNext() => default; // 0x00000001808D61F0-0x00000001808D6250
			public void Reset() {} // 0x0000000180245710-0x0000000180245720
		}
	
		// Constructors
		protected Transform() {} // 0x00000001808E4F10-0x00000001808E4F20
	
		// Methods
		private Transform GetParent() => default; // 0x00000001808E3850-0x00000001808E3890
		public void SetParent(Transform p) {} // 0x00000001808E4990-0x00000001808E49E0
		[FreeFunction] // 0x0000000180107670-0x00000001801076B0
		public void SetParent(Transform parent, bool worldPositionStays) {} // 0x00000001808E4930-0x00000001808E4990
		public void Translate(Vector3 translation, [DefaultValue] /* 0x00000001801076E0-0x0000000180107710 */ Space relativeTo) {} // 0x00000001808E4D40-0x00000001808E4F10
		public void Translate(Vector3 translation) {} // 0x00000001808E4D10-0x00000001808E4D40
		public void Rotate(Vector3 eulers, [DefaultValue] /* 0x00000001801076E0-0x0000000180107710 */ Space relativeTo) {} // 0x00000001808E4350-0x00000001808E4620
		public void Rotate(Vector3 eulers) {} // 0x00000001808E4620-0x00000001808E4650
		public void Rotate(float xAngle, float yAngle, float zAngle, [DefaultValue] /* 0x00000001801076E0-0x0000000180107710 */ Space relativeTo) {} // 0x00000001808E4730-0x00000001808E4770
		public void Rotate(float xAngle, float yAngle, float zAngle) {} // 0x00000001808E4770-0x00000001808E47B0
		[NativeMethod] // 0x0000000180107980-0x00000001801079B0
		internal void RotateAroundInternal(Vector3 axis, float angle) {} // 0x00000001808E40D0-0x00000001808E4130
		public void Rotate(Vector3 axis, float angle, [DefaultValue] /* 0x00000001801076E0-0x0000000180107710 */ Space relativeTo) {} // 0x00000001808E47B0-0x00000001808E48F0
		public void Rotate(Vector3 axis, float angle) {} // 0x00000001808E4650-0x00000001808E4730
		public void RotateAround(Vector3 point, Vector3 axis, float angle) {} // 0x00000001808E4130-0x00000001808E4350
		public void LookAt(Transform target, [DefaultValue] /* 0x00000001800EEEF0-0x00000001800EEF20 */ Vector3 worldUp) {} // 0x00000001808E3DF0-0x00000001808E3F00
		public void LookAt(Transform target) {} // 0x00000001808E3F00-0x00000001808E4070
		public void LookAt(Vector3 worldPosition, [DefaultValue] /* 0x00000001800EEEF0-0x00000001800EEF20 */ Vector3 worldUp) {} // 0x00000001808E3C80-0x00000001808E3CF0
		public void LookAt(Vector3 worldPosition) {} // 0x00000001808E3CF0-0x00000001808E3DF0
		[FreeFunction] // 0x0000000180107B40-0x0000000180107B80
		private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) {} // 0x00000001808E3930-0x00000001808E3990
		public Vector3 TransformDirection(Vector3 direction) => default; // 0x00000001808E4A40-0x00000001808E4AC0
		public Vector3 InverseTransformDirection(Vector3 direction) => default; // 0x00000001808E39F0-0x00000001808E3A70
		public Vector3 TransformVector(Vector3 vector) => default; // 0x00000001808E4C90-0x00000001808E4D10
		public Vector3 InverseTransformVector(Vector3 vector) => default; // 0x00000001808E3BB0-0x00000001808E3C30
		public Vector3 TransformPoint(Vector3 position) => default; // 0x00000001808E4BB0-0x00000001808E4C30
		public Vector3 TransformPoint(float x, float y, float z) => default; // 0x00000001808E4B20-0x00000001808E4BB0
		public Vector3 InverseTransformPoint(Vector3 position) => default; // 0x00000001808E3AD0-0x00000001808E3B50
		private Transform GetRoot() => default; // 0x00000001808E3890-0x00000001808E38D0
		[FreeFunction] // 0x0000000180107C60-0x0000000180107CA0
		public void DetachChildren() {} // 0x00000001808E3660-0x00000001808E36A0
		public void SetAsFirstSibling() {} // 0x00000001808E48F0-0x00000001808E4930
		[FreeFunction] // 0x00000001800F2910-0x00000001800F2920
		private static Transform FindRelativeTransformWithPath(Transform transform, string path, [DefaultValue] /* 0x00000001800DFAE0-0x00000001800DFB10 */ bool isActiveOnly) => default; // 0x00000001808E36A0-0x00000001808E3700
		public Transform Find(string n) => default; // 0x00000001808E3700-0x00000001808E37A0
		[FreeFunction] // 0x0000000180108090-0x00000001801080D0
		public bool IsChildOf([NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ Transform parent) => default; // 0x00000001808E3C30-0x00000001808E3C80
		public IEnumerator GetEnumerator() => default; // 0x00000001808E37E0-0x00000001808E3850
		[FreeFunction] // 0x00000001801082E0-0x0000000180108330
		[NativeThrows] // 0x00000001801082E0-0x0000000180108330
		public Transform GetChild(int index) => default; // 0x00000001808E37A0-0x00000001808E37E0
		private void get_position_Injected(out Vector3 ret) {
			ret = default;
		} // 0x00000001808E55E0-0x00000001808E5630
		private void set_position_Injected(ref Vector3 value) {} // 0x00000001808E5FC0-0x00000001808E6010
		private void get_localPosition_Injected(out Vector3 ret) {
			ret = default;
		} // 0x00000001808E5210-0x00000001808E5260
		private void set_localPosition_Injected(ref Vector3 value) {} // 0x00000001808E5D30-0x00000001808E5D80
		private void get_rotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x00000001808E57F0-0x00000001808E5840
		private void set_rotation_Injected(ref Quaternion value) {} // 0x00000001808E6060-0x00000001808E60B0
		private void get_localRotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x00000001808E52D0-0x00000001808E5320
		private void set_localRotation_Injected(ref Quaternion value) {} // 0x00000001808E5DD0-0x00000001808E5E20
		private void get_localScale_Injected(out Vector3 ret) {
			ret = default;
		} // 0x00000001808E5380-0x00000001808E53D0
		private void set_localScale_Injected(ref Vector3 value) {} // 0x00000001808E5E70-0x00000001808E5EC0
		private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x00000001808E59F0-0x00000001808E5A40
		private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x00000001808E5440-0x00000001808E5490
		private void RotateAroundInternal_Injected(ref Vector3 axis, float angle) {} // 0x00000001808E4070-0x00000001808E40D0
		private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) {} // 0x00000001808E38D0-0x00000001808E3930
		private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) {
			ret = default;
		} // 0x00000001808E49E0-0x00000001808E4A40
		private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) {
			ret = default;
		} // 0x00000001808E3990-0x00000001808E39F0
		private void TransformVector_Injected(ref Vector3 vector, out Vector3 ret) {
			ret = default;
		} // 0x00000001808E4C30-0x00000001808E4C90
		private void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret) {
			ret = default;
		} // 0x00000001808E3B50-0x00000001808E3BB0
		private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) {
			ret = default;
		} // 0x00000001808E4AC0-0x00000001808E4B20
		private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) {
			ret = default;
		} // 0x00000001808E3A70-0x00000001808E3AD0
		private void get_lossyScale_Injected(out Vector3 ret) {
			ret = default;
		} // 0x00000001808E5520-0x00000001808E5570
	}
}
