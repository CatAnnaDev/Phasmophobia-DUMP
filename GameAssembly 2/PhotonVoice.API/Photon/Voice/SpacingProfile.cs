/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	internal class SpacingProfile // TypeDefIndex: 4659
	{
		// Fields
		private short[] buf; // 0x10
		private bool[] info; // 0x18
		private int capacity; // 0x20
		private int ptr; // 0x24
		private Stopwatch watch; // 0x28
		private long watchLast; // 0x30
		private bool flushed; // 0x38
	
		// Properties
		public string Dump { get => default; } // 0x0000000180F28B20-0x0000000180F28EB0 
		public int Max { get => default; } // 0x0000000180F28EB0-0x0000000180F28FC0 
	
		// Constructors
		public SpacingProfile() {} // Dummy constructor
		public SpacingProfile(int capacity) {} // 0x0000000180F28AF0-0x0000000180F28B20
	
		// Methods
		public void Start() {} // 0x0000000180F288D0-0x0000000180F28980
		public void Update(bool lost, bool flush) {} // 0x0000000180F28A10-0x0000000180F28AF0
	}
}
