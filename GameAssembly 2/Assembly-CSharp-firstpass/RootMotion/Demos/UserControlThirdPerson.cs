/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.Demos
{
	public class UserControlThirdPerson : MonoBehaviour // TypeDefIndex: 6664
	{
		// Fields
		public bool walkByDefault; // 0x18
		public bool canCrouch; // 0x19
		public bool canJump; // 0x1A
		public State state; // 0x1C
		protected Transform cam; // 0x40
	
		// Nested types
		public struct State // TypeDefIndex: 6665
		{
			// Fields
			public Vector3 move; // 0x00
			public Vector3 lookPos; // 0x0C
			public bool crouch; // 0x18
			public bool jump; // 0x19
			public int actionIndex; // 0x1C
		}
	
		// Constructors
		public UserControlThirdPerson() {} // 0x000000018053E940-0x000000018053E950
	
		// Methods
		private void Start() {} // 0x000000018053E530-0x000000018053E570
		protected virtual void Update() {} // 0x000000018053E570-0x000000018053E940
	}
}
